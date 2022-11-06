using System.IO.Compression;

namespace PK3Tool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            ReadIni();

            InitializeComponent();
            Folders = new Dictionary<string, string>();
            if (string.IsNullOrEmpty(srcPath)) { srcPath = Directory.GetCurrentDirectory(); }
            if (string.IsNullOrEmpty(destPath)) { destPath = Directory.GetParent(Directory.GetCurrentDirectory())?.ToString() ?? srcPath; }
            BaseFolderDialog.InitialDirectory = BaseFolderDialog.SelectedPath = srcPath;
            DestFolderDialog.InitialDirectory = DestFolderDialog.SelectedPath = destPath;
            RefreshSrcFolders();
            RefreshDestFolder();

            WriteIni();
        }

        const string iniFile = "PKTool.ini";
        private string srcPath;
        private string destPath;

        Dictionary<string, string> Folders;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (BaseFolderDialog.ShowDialog(this) == DialogResult.OK)
            {
                RefreshSrcFolders();
            }
        }

        private void btnBrowseDest_Click(object sender, EventArgs e)
        {
            if (DestFolderDialog.ShowDialog(this) == DialogResult.OK)
            {
                RefreshDestFolder();
            }
        }

        private void RefreshSrcFolders()
        {
            srcPath = BaseFolderDialog.SelectedPath;
            BaseFolderDialog.InitialDirectory = srcPath;
            LBLSelectedFolder.Text = srcPath;
            LBFolders.Items.Clear();
            Folders.Clear();
            foreach (var dir in Directory.GetDirectories(srcPath))
            {
                Folders.Add(dir, $"{dir} - {Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Count()} files");
            }

            foreach (var folder in Folders)
            {
                LBFolders.Items.Add(folder);
            }

            SelectAll();
            WriteIni();
        }

        private void RefreshDestFolder()
        {
            destPath = DestFolderDialog.SelectedPath;
            DestFolderDialog.InitialDirectory = destPath;
            LBLDestFolder.Text = destPath;

            WriteIni();
        }

        private void WriteIni()
        {
            File.WriteAllLines(iniFile, new string[] { srcPath, destPath });
        }

        private void ReadIni()
        {
            if (File.Exists(iniFile))
            {
                var lines = File.ReadAllLines(iniFile);
                srcPath = lines[0];
                destPath = lines[1];
            }
        }

        private async Task ZipFolder(string folder)
        {
            await Task.Run(() =>
            {
                var file = Path.Combine(destPath, $"{Path.GetRelativePath(srcPath, folder)}.pk3");
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
                ZipFile.CreateFromDirectory(folder, file, CompressionLevel.Optimal, false);
            });
        }

        private async void btnDoAll_Click(object sender, EventArgs e)
        {
            btnBrowseSrc.Enabled = false; 
            btnBrowseDest.Enabled = false;
            btnDoAll.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            foreach (var folder in LBFolders.SelectedItems)
            {
                var folderLoc = (folder as Nullable<KeyValuePair<string, string>>)?.Key;
                if (folderLoc != null)
                {
                    await ZipFolder(folderLoc);
                }
            }
            btnBrowseSrc.Enabled = true;
            btnBrowseDest.Enabled = true;
            btnDoAll.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void SelectAll()
        {
            for (int i = 0; i < LBFolders.Items.Count; i++)
            {
                LBFolders.SetSelected(i, true);
            }
        }

        private void LBFolders_DoubleClick(object sender, EventArgs e)
        {
            SelectAll();
        }
    }
}