using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Uyghurdev
{
    public partial class MainForm : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private SortedDictionary<string, int> _uniqueTokens = new SortedDictionary<string, int>();

        private UyghurTokenizer tokenizer = new UyghurTokenizer();

        public MainForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string extention = txtFileExt.Text.Trim().Trim('.');
            if (string.IsNullOrEmpty(extention))
                return;
            if (!this.lbExtentions.Items.Contains(extention))
                this.lbExtentions.Items.Insert(0,extention);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.lbExtentions.SelectedIndex > -1)
                if (this.lbExtentions.Items.Count > 1)
                    this.lbExtentions.Items.RemoveAt(this.lbExtentions.SelectedIndex);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogREsult = folderBrowserDialog.ShowDialog();
            if (dialogREsult == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
            {
                this.txtDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string fileSearchPattern = string.Empty;
            List<string> extentions = new List<string>();
            foreach (var item in lbExtentions.Items)
                extentions.Add(item.ToString());
            fileSearchPattern = fileSearchPattern.TrimEnd('|');
            _uniqueTokens = new SortedDictionary<string, int>();

            AllocConsole();

            Console.Write(string.Format("{0}Tokenizing started at {1}...", Environment.NewLine, DateTime.Now.ToLongTimeString()));
            this.Enabled = false;
            tokenizeDirectory(this.txtDirectory.Text, extentions.ToArray(), cbSubDirectory.Checked);
            string resultFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("sozler_{0}.txt", DateTime.Now.ToString("yyyyMMddHHmmss")));

             try
            {
                List<string> lines = new List<string>();
                bool addFreq = cbFreq.Checked;
                foreach (var item in _uniqueTokens)
                {
                    if (addFreq)
                        lines.Add(item.Key + "\t"+item.Value);
                    else
                        lines.Add(item.Key);
                }

                File.WriteAllLines(resultFile, lines.ToArray());

                Console.Write(string.Format(Environment.NewLine + "Tokenizing done at {0}", DateTime.Now.ToLongTimeString()));
                Console.Write(string.Format(Environment.NewLine + "Tokens saved in {0}", resultFile));
            }
            catch (Exception exp){
                Console.Write(string.Format(Environment.NewLine + "Tokenizing done at {0}", DateTime.Now.ToLongTimeString()));
                Console.Write(string.Format(Environment.NewLine + "An error occured when saving the tokens to file {0}", resultFile));
            }

            this.Enabled = true;
        }

        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {
            this.btnStart.Enabled = System.IO.Directory.Exists(this.txtDirectory.Text);
        }

        // Process all files in the directory passed in, recurse on any directories  
        // that are found, and process the files they contain. 
        private void tokenizeDirectory(string targetDirectory, string[] extentions, bool recurseSubDirectiory)
        {
            // Process the list of files found in the directory. 
            List<string> fileEntries = new List<string>();
            foreach (var item in extentions)
            {
                fileEntries.AddRange(Directory.GetFiles(targetDirectory, "*." + item));
            }
                
            foreach (string fileName in fileEntries)
            {

                tokenizeFile(fileName);
            }

            // Recurse into subdirectories of this directory. 
            if (!recurseSubDirectiory)
                return;
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                tokenizeDirectory(subdirectory, extentions, recurseSubDirectiory);
        }

        private  void tokenizeFile(string fileName)
        {
            try
            {
                Console.Write(Environment.NewLine);
                Console.Write(string.Format("Tokenizing {0}...", fileName));
                string fileContent = System.IO.File.ReadAllText(fileName);
                IEnumerator<string> tokenEnumerator = tokenizer.GetTokenIterator(fileContent);
                while (tokenEnumerator.MoveNext())
                {
                    string word = tokenEnumerator.Current;
                    if (_uniqueTokens.ContainsKey(word))
                        _uniqueTokens[word] = _uniqueTokens[word] + 1;
                    else
                        _uniqueTokens.Add(word, 1);
                }

                Console.Write("Done!");
            }
            catch (Exception exp)
            {
                Console.Write("Error!");
            }
            
        }
    }
}
