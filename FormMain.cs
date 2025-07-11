using System;
using System.Windows.Forms;
using System.IO;

namespace GoProRename
{
    public partial class FormMain : Form
    {
        public FormMain(string[] args) {
            InitializeComponent();
            TextBoxFolder.AutoSize = false;
            ProcessCmdArgs(args);
        }

        private void ButtonFolder_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath)) {
                TextBoxFolder.Text = dialog.SelectedPath;
                ButtonRename.Enabled = true;
            }
        }

        private void ButtonRename_Click(object sender, EventArgs e) {
            ProcessFolder(TextBoxFolder.Text);
            ButtonRename.Enabled = false;
        }

        private void ProcessCmdArgs(string[] args) {
            if (args != null && args.Length > 0) {
                string path = args[0];
                if (Directory.Exists(path)) {
                    ProcessFolder(path);
                }

                Close();
            }
        }

        private void ProcessFolder(string path) {
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (!IsGoProFile(file)) continue;
                FileInfo info = new FileInfo(file);
                info.MoveTo(GetRenamedFile(file));
            }
        }

        private bool IsGoProFile(string file) {
            string ext = Path.GetExtension(file).ToUpper();
            if (ext != ".MP4" && ext != ".LRV" && ext != ".THM") return false;
            if (Path.GetFileName(file).Length != 12) return false;
            return true;
        }

        private string GetRenamedFile(string file) {
            string filename = Path.GetFileName(file);
            string chapter = filename.Substring(2, 2);
            string number = filename.Substring(4, 4);
            string path = Path.GetDirectoryName(file);
            return Path.Combine(path, number + chapter + "_" + filename);
        }

        private void TextBoxFolder_TextChanged(object sender, EventArgs e) {
            ButtonRename.Enabled = Directory.Exists(TextBoxFolder.Text);
        }
    }
}
