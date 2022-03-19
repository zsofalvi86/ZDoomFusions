namespace PK3Tool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BaseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowseSrc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBFolders = new System.Windows.Forms.ListBox();
            this.LBLSelectedFolder = new System.Windows.Forms.Label();
            this.LBLDestFolder = new System.Windows.Forms.Label();
            this.btnBrowseDest = new System.Windows.Forms.Button();
            this.DestFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDoAll = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseFolderDialog
            // 
            this.BaseFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btnBrowseSrc
            // 
            this.btnBrowseSrc.Location = new System.Drawing.Point(3, 3);
            this.btnBrowseSrc.Name = "btnBrowseSrc";
            this.btnBrowseSrc.Size = new System.Drawing.Size(75, 24);
            this.btnBrowseSrc.TabIndex = 0;
            this.btnBrowseSrc.Text = "Browse";
            this.btnBrowseSrc.UseVisualStyleBackColor = true;
            this.btnBrowseSrc.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.LBFolders);
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 406);
            this.panel1.TabIndex = 1;
            // 
            // LBFolders
            // 
            this.LBFolders.DisplayMember = "Value";
            this.LBFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBFolders.FormattingEnabled = true;
            this.LBFolders.ItemHeight = 15;
            this.LBFolders.Location = new System.Drawing.Point(0, 0);
            this.LBFolders.Name = "LBFolders";
            this.LBFolders.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LBFolders.Size = new System.Drawing.Size(770, 406);
            this.LBFolders.TabIndex = 0;
            this.LBFolders.DoubleClick += new System.EventHandler(this.LBFolders_DoubleClick);
            // 
            // LBLSelectedFolder
            // 
            this.LBLSelectedFolder.AutoEllipsis = true;
            this.LBLSelectedFolder.AutoSize = true;
            this.LBLSelectedFolder.Location = new System.Drawing.Point(103, 0);
            this.LBLSelectedFolder.Name = "LBLSelectedFolder";
            this.LBLSelectedFolder.Size = new System.Drawing.Size(0, 15);
            this.LBLSelectedFolder.TabIndex = 2;
            // 
            // LBLDestFolder
            // 
            this.LBLDestFolder.AutoEllipsis = true;
            this.LBLDestFolder.AutoSize = true;
            this.LBLDestFolder.Location = new System.Drawing.Point(491, 0);
            this.LBLDestFolder.Name = "LBLDestFolder";
            this.LBLDestFolder.Size = new System.Drawing.Size(0, 15);
            this.LBLDestFolder.TabIndex = 4;
            // 
            // btnBrowseDest
            // 
            this.btnBrowseDest.Location = new System.Drawing.Point(391, 3);
            this.btnBrowseDest.Name = "btnBrowseDest";
            this.btnBrowseDest.Size = new System.Drawing.Size(75, 24);
            this.btnBrowseDest.TabIndex = 3;
            this.btnBrowseDest.Text = "Browse";
            this.btnBrowseDest.UseVisualStyleBackColor = true;
            this.btnBrowseDest.Click += new System.EventHandler(this.btnBrowseDest_Click);
            // 
            // btnDoAll
            // 
            this.btnDoAll.Location = new System.Drawing.Point(3, 33);
            this.btnDoAll.Name = "btnDoAll";
            this.btnDoAll.Size = new System.Drawing.Size(89, 24);
            this.btnDoAll.TabIndex = 5;
            this.btnDoAll.Text = "Pack Selected";
            this.btnDoAll.UseVisualStyleBackColor = true;
            this.btnDoAll.Click += new System.EventHandler(this.btnDoAll_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnBrowseSrc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDoAll, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBLSelectedFolder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBLDestFolder, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowseDest, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 472);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "PK3 Tool";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FolderBrowserDialog BaseFolderDialog;
        private Button btnBrowseSrc;
        private Panel panel1;
        private ListBox LBFolders;
        private Label LBLSelectedFolder;
        private Label LBLDestFolder;
        private Button btnBrowseDest;
        private FolderBrowserDialog DestFolderDialog;
        private Button btnDoAll;
        private TableLayoutPanel tableLayoutPanel1;
    }
}