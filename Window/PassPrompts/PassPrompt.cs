using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeagleAPI.SysDebug.DelegatesEvents;

namespace BeagleAPI.Window.PassPrompts
{
    public partial class PassPrompt : StdW.StdWin
    {
        /// <summary>
        /// Tritt auf, wenn ein Passwort eingegeben und das Formular mit OK geschlossen wird.
        /// </summary>
        public event EventHandler<EnteredPasswordEventArgs> PasswordEntered;
        
        private string pass = "";

        /// <summary>
        /// Initialize password prompt window.
        /// </summary>
        /// <param name="password">The password the user must enter.</param>
        public PassPrompt(string password) : base()
        {
            InitializeComponent();
            pass = password;
            //RegisterWindow();
        }

        private void buttonE1_Click(object sender, EventArgs e)
        {
            //CheckForEqu(pass => pass == textBox1.Text);
            CheckForEqu(CheckPass);
            EnteredPasswordEventArgs args = new EnteredPasswordEventArgs();
            if (textBox1.Text == pass)
            {
                args.IsValid = true;
                args.TimeReached = DateTime.Now;
                OnEnterPassword(args);
            }
            else
            {
                args.IsValid = false;
                args.TimeReached = DateTime.Now;
                OnEnterPassword(args);
            }

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        //    Manager.ManageHelper.h__returnAllRegistations();
        //    BeagleAPI.OS.EntryPoint en = new OS.EntryPoint();
        //    en.Show();
        }

        private void OnEnterPassword(EnteredPasswordEventArgs e)
        {
            PasswordEntered?.Invoke(this, e);
        }

        private void CheckForEqu(Predicate<string> match)
        {
            //if(match(pass))
            if(match(textBox1.Text))
            {
                Message.Messages m = new Message.Messages("Erfolg!",
                    "Das eingegebene Passwort stimmt überein mit dem Anwendungspasswort.");
                m.ShowDialog();
            }
        }

        private bool CheckPass(string password)
        {
            return pass == password;
        }
    }
}
