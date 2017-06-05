using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeagleAPI.Misc
{
    public class Cryption
    {
        private byte[] key;
        private byte[] IV;
        private byte[] hash_key;
        private string file_to_be_encrypted;
        private string file_to_be_decrypted;
        private bool error = false;
        BackgroundWorker back_encrypt;
        BackgroundWorker back_decrypt;

        //Constructor of the class
        public Cryption(BackgroundWorker encryptBackWork, BackgroundWorker decryptBackWork)
        {
            back_encrypt = encryptBackWork;
            back_decrypt = decryptBackWork;

            IV = new byte[16];
            //Initialization vector for AES 256 encryption
            for (int i = 0; i < IV.Length; i++)
                IV[i] = (byte)(i * 3);
            //Initializes the required setting for the software
            back_encrypt = new BackgroundWorker();
            back_decrypt = new BackgroundWorker();
            back_encrypt.WorkerReportsProgress = true;
            back_encrypt.DoWork += new DoWorkEventHandler(encrypt);
            //back_encrypt.ProgressChanged += new ProgressChangedEventHandler(UpdateProgressBar);
            //back_encrypt.RunWorkerCompleted += new RunWorkerCompletedEventHandler(EncryptionDone);
            //back_decrypt.DoWork += new DoWorkEventHandler(decrypt);
            //back_decrypt.ProgressChanged += new ProgressChangedEventHandler(UpdateDecryptProgess);
            //back_decrypt.WorkerReportsProgress = true;
            //back_decrypt.RunWorkerCompleted += new RunWorkerCompletedEventHandler(DecryptionCompleted);
            back_decrypt.WorkerSupportsCancellation = true;
        }

        //Function to encrypt the files
        private void encrypt(object sender, DoWorkEventArgs a)
        {
            byte[] block = new byte[5242880];
            using (Aes myaes = Aes.Create())
            {
                myaes.Key = key;
                myaes.IV = IV;
                long length;
                ICryptoTransform encrypter = myaes.CreateEncryptor(myaes.Key, myaes.IV);
                using (var input_stream = new FileStream(file_to_be_encrypted, FileMode.Open, FileAccess.Read))
                {
                    using (var output_stream = new FileStream(file_to_be_encrypted + ".crypt256", FileMode.Create, FileAccess.Write))
                    {
                        using (SHA256 key_hash = SHA256.Create())
                        {
                            //creating the hash of the key using SHA256 and storing it in the first block of the file iteself
                            hash_key = key_hash.ComputeHash(key);
                            output_stream.Write(hash_key, 0, hash_key.Length);
                            using (CryptoStream cstream = new CryptoStream(output_stream, encrypter, CryptoStreamMode.Write))
                            {
                                long pos = 0;
                                length = input_stream.Length;
                                double factor = 0.0;
                                while ((pos = input_stream.Read(block, 0, block.Length)) > 0)
                                {
                                    factor += ((double)pos / (double)length) * 100.0;
                                    cstream.Write(block, 0, (int)pos);
                                    back_encrypt.ReportProgress((int)factor);
                                }
                            }
                        }
                    }
                }
            }
        }

        //Function to decrypt the files
        private void decrypt(object sender, DoWorkEventArgs e)
        {
            byte[] block = new byte[5242880];
            byte[] extract_key = new byte[32];
            using (Aes myaes = Aes.Create())
            {
                myaes.Key = key;
                myaes.IV = IV;
                long length;
                ICryptoTransform decrypt = myaes.CreateDecryptor(myaes.Key, myaes.IV);
                using (var input_stream = new FileStream(file_to_be_decrypted, FileMode.Open, FileAccess.Read))
                {
                    input_stream.Read(extract_key, 0, extract_key.Length);
                    using (SHA256 key_hash = SHA256.Create())
                    {
                        //matching the hash of the key and the hash recovered from the file
                        if (Encoding.ASCII.GetString(key_hash.ComputeHash(key)) == Encoding.ASCII.GetString(extract_key))
                        {
                            file_to_be_decrypted = file_to_be_decrypted.Replace(".crypt256", string.Empty);
                            using (var output_stream = new FileStream(file_to_be_decrypted, FileMode.Create, FileAccess.Write))
                            {
                                using (CryptoStream cstream = new CryptoStream(output_stream, decrypt, CryptoStreamMode.Write))
                                {
                                    long pos = 0;
                                    length = input_stream.Length;
                                    double factor = 0.0;
                                    while ((pos = input_stream.Read(block, 0, block.Length)) > 0)
                                    {
                                        factor += ((double)pos / (double)length) * 100.0;
                                        cstream.Write(block, 0, (int)pos);
                                        back_decrypt.ReportProgress((int)factor);
                                    }
                                }
                            }
                        }
                        else
                        {
                            error = true;
                        }
                    }
                }
            }
        }

        //function to update the progress bar as the decryption proceeds
        private void UpdateDecryptProgess(ProgressBar decryption_bar, Label decrypt_per, ProgressChangedEventArgs e)
        {
            decryption_bar.Value = e.ProgressPercentage;
            decrypt_per.Text = e.ProgressPercentage + "%";
        }

        //method executed when the Decryption completed
        private void DecryptionCompleted(ProgressBar decryption_bar, Label decrypt_per, RunWorkerCompletedEventArgs e)
        {
            if (!error)
            {
                decryption_bar.Value = 100;
                decrypt_per.Text = "100%";
                MessageBox.Show("Decryption Complete", "Error");
                decryption_bar.Value = 0;
                decrypt_per.Text = string.Empty;
                File.Delete(file_to_be_decrypted + ".crypt256");
            }
            else
            {
                MessageBox.Show("Wrong password Inserted!!!", "Error");
                error = false;
            }
        }

        //Method executed when the encryption is completed
        //private void EncryptionDone(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    progressBar1.Value = 100;
        //    encryption_per.Text = "100%";
        //    MessageBox.Show(this, "Encryption complete", "Message");
        //    progressBar1.Value = 0;
        //    file_location_box.Text = string.Empty;
        //    encryption_per.Text = string.Empty;
        //    password_field.Text = string.Empty;
        //    erpass_field.Text = string.Empty;
        //}

        ////Method to update the progress bar 
        //private void UpdateProgressBar(object sender, ProgressChangedEventArgs e)
        //{
        //    progressBar1.Value = e.ProgressPercentage;
        //    encryption_per.Text = "" + e.ProgressPercentage + "%";
        //}

        ////Create the 256 bit key from the string
        //private byte[] CreateKey(string pass)
        //{
        //    byte[] tempkey = new byte[32];
        //    int length = Encoding.Default.GetBytes(pass).Length > 32 ? 32 : Encoding.Default.GetBytes(pass).Length;
        //    for (int i = 0; i < length; i++)
        //    {
        //        tempkey[i] = Encoding.Default.GetBytes(pass)[i];
        //    }
        //    if (tempkey.Length < 32)
        //    {
        //        Console.WriteLine(tempkey.Length);
        //        for (int i = pass.Length - 1; i <= 31; i++)
        //            tempkey[i] = (byte)0;
        //        return tempkey;
        //    }
        //    else
        //        return tempkey;
        //}

        ////select the file using file dialog box
        //private void select_file_e_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1.ShowDialog(this);
        //    string filename = openFileDialog1.FileName;
        //    if (filename.Length != 0)
        //    {
        //        file_to_be_encrypted = filename;
        //        file_location_box.Text = file_to_be_encrypted;
        //    }
        //}

        ////Action when the encrypt button is pressed
        //private void encrypt_button_Click(object sender, EventArgs e)
        //{
        //    if (file_to_be_encrypted == null)
        //    {
        //        MessageBox.Show(this, "No file selected!!!", "Error");
        //    }
        //    else
        //    if (erpass_field.Text.Length == 0 || password_field.Text.Length == 0)
        //    {
        //        MessageBox.Show(this, "Password field cannot be left blank", "Error");
        //    }
        //    else
        //    if (erpass_field.Text.CompareTo(password_field.Text) != 0)
        //    {
        //        MessageBox.Show(this, "Password do not match", "Error");
        //    }
        //    else
        //    if (file_to_be_encrypted.Contains(".crypt256"))
        //    {
        //        MessageBox.Show(this, "The file is already encrypted", "Error");
        //    }
        //    else
        //    {
        //        key = CreateKey(password_field.Text);
        //        back_encrypt.RunWorkerAsync();
        //    }
        //}

        ////Action when the decrypt button is clicked
        //private void Decrypt_btn_Click(object sender, EventArgs e)
        //{
        //    if (file_to_be_decrypted == null)
        //    {
        //        MessageBox.Show(this, "No file selected!!!", "Error");
        //    }
        //    else
        //    if (drepeat_pass_field.Text.Length == 0 || Decrypt_pass_field.Text.Length == 0)
        //    {
        //        MessageBox.Show(this, "Password field cannot be left blank", "Error");
        //    }
        //    else
        //    if (drepeat_pass_field.Text.CompareTo(Decrypt_pass_field.Text) != 0)
        //    {
        //        MessageBox.Show(this, "Password do not match", "Error");
        //    }
        //    else
        //    if (!file_to_be_decrypted.Contains(".crypt256"))
        //    {
        //        MessageBox.Show(this, "The file is not Encrypted.Cannot decrypted", "Error");
        //    }
        //    else
        //    {
        //        key = CreateKey(Decrypt_pass_field.Text);
        //        back_decrypt.RunWorkerAsync();
        //    }
        //}

        ////Select the encrypted file using Open file dialog
        //private void browse_encrytpt_file_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1.ShowDialog(this);
        //    string filename = openFileDialog1.FileName;
        //    if (filename.Length != 0)
        //    {
        //        file_to_be_decrypted = filename;
        //        decryption_file_box.Text = file_to_be_decrypted;
        //    }
        //}
    }
}
