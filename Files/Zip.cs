using System;
using System.IO.Compression;
using System.IO;
using System.Windows.Forms;

namespace BeagleAPI.Files
{
    public class Zip
    {
        /// <summary>
        /// Exportiert angegebene Dateien oder einen Ordner in eine ZIP-Datei.
        /// </summary>
        /// <param name="destFileName">Die Ziel-Datei des ZIP-Archivs.</param>
        /// <param name="isFolder">Gibt an, ob das zu speicherne Medium ein Ordner ist.</param>
        /// <param name="sourceFiles">Die Dateien, die in das ZIP-Archiv gespeichert werden sollen. Ordner müssen einzeln gespeichert werden. Mehrere Dateien müssen durch Kommata getrennt sein.</param>
        public void MakeZIP(string destFileName, bool isFolder, string sourceFiles)
        {
            if (isFolder)
            {
                ZipFile.CreateFromDirectory(sourceFiles, destFileName);
            }
            else
            {

                string[] files = sourceFiles.Split(',');
                ZipArchive zip = ZipFile.Open(destFileName, ZipArchiveMode.Create);
                foreach (string file in files)
                {
                    zip.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Optimal);
                }
                zip.Dispose();
            }
        }

        public void Unzip()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                DialogResult result2 = folderBrowserDialog1.ShowDialog();
                if (result2 == DialogResult.OK)
                {
                    ZipFile.ExtractToDirectory(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath);
                    MessageBox.Show("ZIP file extracted successfully!");
                }
            }
        }
    }
}
