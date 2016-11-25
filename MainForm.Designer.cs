namespace Steganography
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ImportTabPage = new System.Windows.Forms.TabPage();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ImportPixelsLabel = new System.Windows.Forms.Label();
            this.ImportMaxLengthLabel = new System.Windows.Forms.Label();
            this.ImportFormatLabel = new System.Windows.Forms.Label();
            this.ImportHeightLabel = new System.Windows.Forms.Label();
            this.ImportWidthLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImportTickPictureBox = new System.Windows.Forms.PictureBox();
            this.ImportedTextLengtLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ImportDurationLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ImportProgressBar = new System.Windows.Forms.ProgressBar();
            this.ImportTextBox = new System.Windows.Forms.RichTextBox();
            this.OpenFileImportButton = new System.Windows.Forms.Button();
            this.ImportPictureBox = new System.Windows.Forms.PictureBox();
            this.ExportTabPage = new System.Windows.Forms.TabPage();
            this.OpenFileExportButton = new System.Windows.Forms.Button();
            this.ExportPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ExportPixelsLabel = new System.Windows.Forms.Label();
            this.ExportMaxLengthLabel = new System.Windows.Forms.Label();
            this.ExportFormatLabel = new System.Windows.Forms.Label();
            this.ExportHeightLabel = new System.Windows.Forms.Label();
            this.ExportWidthLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ExportTickPictureBox = new System.Windows.Forms.PictureBox();
            this.ExportedTextLengtLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ExportDurationLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ExportProgressBar = new System.Windows.Forms.ProgressBar();
            this.ExportTextBox = new System.Windows.Forms.RichTextBox();
            this.AboutTabPage = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TabControl.SuspendLayout();
            this.ImportTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportTickPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportPictureBox)).BeginInit();
            this.ExportTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExportPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExportTickPictureBox)).BeginInit();
            this.AboutTabPage.SuspendLayout();
            this.Help.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabControl.Controls.Add(this.ImportTabPage);
            this.TabControl.Controls.Add(this.ExportTabPage);
            this.TabControl.Controls.Add(this.AboutTabPage);
            this.TabControl.Controls.Add(this.Help);
            this.TabControl.Location = new System.Drawing.Point(13, 13);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1058, 514);
            this.TabControl.TabIndex = 0;
            // 
            // ImportTabPage
            // 
            this.ImportTabPage.BackColor = System.Drawing.Color.Silver;
            this.ImportTabPage.Controls.Add(this.SaveButton);
            this.ImportTabPage.Controls.Add(this.panel1);
            this.ImportTabPage.Controls.Add(this.OpenFileImportButton);
            this.ImportTabPage.Controls.Add(this.ImportPictureBox);
            this.ImportTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ImportTabPage.Location = new System.Drawing.Point(4, 25);
            this.ImportTabPage.Name = "ImportTabPage";
            this.ImportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ImportTabPage.Size = new System.Drawing.Size(1050, 485);
            this.ImportTabPage.TabIndex = 0;
            this.ImportTabPage.Text = "                Import                 ";
            this.ImportTabPage.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SaveButton.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveButton.Image = global::Steganography.Properties.Resources.save;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(180, 6);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(163, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(575, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 435);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ImportPixelsLabel);
            this.groupBox2.Controls.Add(this.ImportMaxLengthLabel);
            this.groupBox2.Controls.Add(this.ImportFormatLabel);
            this.groupBox2.Controls.Add(this.ImportHeightLabel);
            this.groupBox2.Controls.Add(this.ImportWidthLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(8, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 143);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Info";
            // 
            // ImportPixelsLabel
            // 
            this.ImportPixelsLabel.AutoSize = true;
            this.ImportPixelsLabel.Location = new System.Drawing.Point(141, 88);
            this.ImportPixelsLabel.Name = "ImportPixelsLabel";
            this.ImportPixelsLabel.Size = new System.Drawing.Size(11, 15);
            this.ImportPixelsLabel.TabIndex = 9;
            this.ImportPixelsLabel.Text = "-";
            // 
            // ImportMaxLengthLabel
            // 
            this.ImportMaxLengthLabel.AutoSize = true;
            this.ImportMaxLengthLabel.Location = new System.Drawing.Point(140, 114);
            this.ImportMaxLengthLabel.Name = "ImportMaxLengthLabel";
            this.ImportMaxLengthLabel.Size = new System.Drawing.Size(11, 15);
            this.ImportMaxLengthLabel.TabIndex = 8;
            this.ImportMaxLengthLabel.Text = "-";
            // 
            // ImportFormatLabel
            // 
            this.ImportFormatLabel.AutoSize = true;
            this.ImportFormatLabel.Location = new System.Drawing.Point(141, 66);
            this.ImportFormatLabel.Name = "ImportFormatLabel";
            this.ImportFormatLabel.Size = new System.Drawing.Size(11, 15);
            this.ImportFormatLabel.TabIndex = 7;
            this.ImportFormatLabel.Text = "-";
            // 
            // ImportHeightLabel
            // 
            this.ImportHeightLabel.AutoSize = true;
            this.ImportHeightLabel.Location = new System.Drawing.Point(140, 40);
            this.ImportHeightLabel.Name = "ImportHeightLabel";
            this.ImportHeightLabel.Size = new System.Drawing.Size(11, 15);
            this.ImportHeightLabel.TabIndex = 6;
            this.ImportHeightLabel.Text = "-";
            // 
            // ImportWidthLabel
            // 
            this.ImportWidthLabel.AutoSize = true;
            this.ImportWidthLabel.Location = new System.Drawing.Point(146, 16);
            this.ImportWidthLabel.Name = "ImportWidthLabel";
            this.ImportWidthLabel.Size = new System.Drawing.Size(11, 15);
            this.ImportWidthLabel.TabIndex = 5;
            this.ImportWidthLabel.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(41, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pixel Count :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max Text Length :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pixel Format :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImportTickPictureBox);
            this.groupBox1.Controls.Add(this.ImportedTextLengtLabel);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ImportDurationLabel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ImportButton);
            this.groupBox1.Controls.Add(this.ImportProgressBar);
            this.groupBox1.Controls.Add(this.ImportTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(10, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 264);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Info";
            // 
            // ImportTickPictureBox
            // 
            this.ImportTickPictureBox.ErrorImage = null;
            this.ImportTickPictureBox.Image = global::Steganography.Properties.Resources.tick;
            this.ImportTickPictureBox.Location = new System.Drawing.Point(399, 188);
            this.ImportTickPictureBox.Name = "ImportTickPictureBox";
            this.ImportTickPictureBox.Size = new System.Drawing.Size(16, 16);
            this.ImportTickPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImportTickPictureBox.TabIndex = 17;
            this.ImportTickPictureBox.TabStop = false;
            this.ImportTickPictureBox.Visible = false;
            // 
            // ImportedTextLengtLabel
            // 
            this.ImportedTextLengtLabel.AutoSize = true;
            this.ImportedTextLengtLabel.Location = new System.Drawing.Point(131, 165);
            this.ImportedTextLengtLabel.Name = "ImportedTextLengtLabel";
            this.ImportedTextLengtLabel.Size = new System.Drawing.Size(11, 15);
            this.ImportedTextLengtLabel.TabIndex = 12;
            this.ImportedTextLengtLabel.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(31, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Text Lenght :";
            // 
            // ImportDurationLabel
            // 
            this.ImportDurationLabel.AutoSize = true;
            this.ImportDurationLabel.Location = new System.Drawing.Point(132, 191);
            this.ImportDurationLabel.Name = "ImportDurationLabel";
            this.ImportDurationLabel.Size = new System.Drawing.Size(11, 15);
            this.ImportDurationLabel.TabIndex = 10;
            this.ImportDurationLabel.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(3, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Processing Time :";
            // 
            // ImportButton
            // 
            this.ImportButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImportButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ImportButton.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ImportButton.Image = global::Steganography.Properties.Resources.circle;
            this.ImportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImportButton.Location = new System.Drawing.Point(254, 137);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(163, 23);
            this.ImportButton.TabIndex = 7;
            this.ImportButton.Text = "Import Text";
            this.ImportButton.UseVisualStyleBackColor = false;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ImportProgressBar
            // 
            this.ImportProgressBar.BackColor = System.Drawing.Color.Black;
            this.ImportProgressBar.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ImportProgressBar.Location = new System.Drawing.Point(5, 232);
            this.ImportProgressBar.Name = "ImportProgressBar";
            this.ImportProgressBar.Size = new System.Drawing.Size(421, 25);
            this.ImportProgressBar.TabIndex = 6;
            // 
            // ImportTextBox
            // 
            this.ImportTextBox.Location = new System.Drawing.Point(7, 14);
            this.ImportTextBox.Name = "ImportTextBox";
            this.ImportTextBox.Size = new System.Drawing.Size(410, 116);
            this.ImportTextBox.TabIndex = 4;
            this.ImportTextBox.Text = "";
            // 
            // OpenFileImportButton
            // 
            this.OpenFileImportButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OpenFileImportButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OpenFileImportButton.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OpenFileImportButton.Image = global::Steganography.Properties.Resources.picture__plus;
            this.OpenFileImportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFileImportButton.Location = new System.Drawing.Point(7, 6);
            this.OpenFileImportButton.Name = "OpenFileImportButton";
            this.OpenFileImportButton.Size = new System.Drawing.Size(163, 23);
            this.OpenFileImportButton.TabIndex = 1;
            this.OpenFileImportButton.Text = "Open File";
            this.OpenFileImportButton.UseVisualStyleBackColor = false;
            this.OpenFileImportButton.Click += new System.EventHandler(this.OpenFileImportButton_Click);
            // 
            // ImportPictureBox
            // 
            this.ImportPictureBox.Image = global::Steganography.Properties.Resources.questionmark;
            this.ImportPictureBox.Location = new System.Drawing.Point(7, 35);
            this.ImportPictureBox.Name = "ImportPictureBox";
            this.ImportPictureBox.Size = new System.Drawing.Size(560, 443);
            this.ImportPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImportPictureBox.TabIndex = 0;
            this.ImportPictureBox.TabStop = false;
            // 
            // ExportTabPage
            // 
            this.ExportTabPage.BackColor = System.Drawing.Color.Silver;
            this.ExportTabPage.Controls.Add(this.OpenFileExportButton);
            this.ExportTabPage.Controls.Add(this.ExportPictureBox);
            this.ExportTabPage.Controls.Add(this.panel2);
            this.ExportTabPage.Location = new System.Drawing.Point(4, 25);
            this.ExportTabPage.Name = "ExportTabPage";
            this.ExportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ExportTabPage.Size = new System.Drawing.Size(1050, 485);
            this.ExportTabPage.TabIndex = 1;
            this.ExportTabPage.Text = "                 Export                 ";
            this.ExportTabPage.UseVisualStyleBackColor = true;
            // 
            // OpenFileExportButton
            // 
            this.OpenFileExportButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OpenFileExportButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OpenFileExportButton.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OpenFileExportButton.Image = global::Steganography.Properties.Resources.picture__plus;
            this.OpenFileExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFileExportButton.Location = new System.Drawing.Point(5, 5);
            this.OpenFileExportButton.Name = "OpenFileExportButton";
            this.OpenFileExportButton.Size = new System.Drawing.Size(163, 23);
            this.OpenFileExportButton.TabIndex = 3;
            this.OpenFileExportButton.Text = "Open File";
            this.OpenFileExportButton.UseVisualStyleBackColor = false;
            this.OpenFileExportButton.Click += new System.EventHandler(this.OpenFileExportButton_Click);
            // 
            // ExportPictureBox
            // 
            this.ExportPictureBox.Image = global::Steganography.Properties.Resources.questionmark;
            this.ExportPictureBox.Location = new System.Drawing.Point(6, 34);
            this.ExportPictureBox.Name = "ExportPictureBox";
            this.ExportPictureBox.Size = new System.Drawing.Size(560, 443);
            this.ExportPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExportPictureBox.TabIndex = 2;
            this.ExportPictureBox.TabStop = false;
            this.ExportPictureBox.Click += new System.EventHandler(this.ExportPictureBox_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(576, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 435);
            this.panel2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ExportPixelsLabel);
            this.groupBox4.Controls.Add(this.ExportMaxLengthLabel);
            this.groupBox4.Controls.Add(this.ExportFormatLabel);
            this.groupBox4.Controls.Add(this.ExportHeightLabel);
            this.groupBox4.Controls.Add(this.ExportWidthLabel);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Uighur", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(8, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(436, 143);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "File Info";
            // 
            // ExportPixelsLabel
            // 
            this.ExportPixelsLabel.AutoSize = true;
            this.ExportPixelsLabel.Location = new System.Drawing.Point(132, 88);
            this.ExportPixelsLabel.Name = "ExportPixelsLabel";
            this.ExportPixelsLabel.Size = new System.Drawing.Size(11, 15);
            this.ExportPixelsLabel.TabIndex = 9;
            this.ExportPixelsLabel.Text = "-";
            // 
            // ExportMaxLengthLabel
            // 
            this.ExportMaxLengthLabel.AutoSize = true;
            this.ExportMaxLengthLabel.Location = new System.Drawing.Point(132, 114);
            this.ExportMaxLengthLabel.Name = "ExportMaxLengthLabel";
            this.ExportMaxLengthLabel.Size = new System.Drawing.Size(11, 15);
            this.ExportMaxLengthLabel.TabIndex = 8;
            this.ExportMaxLengthLabel.Text = "-";
            // 
            // ExportFormatLabel
            // 
            this.ExportFormatLabel.AutoSize = true;
            this.ExportFormatLabel.Location = new System.Drawing.Point(132, 65);
            this.ExportFormatLabel.Name = "ExportFormatLabel";
            this.ExportFormatLabel.Size = new System.Drawing.Size(11, 15);
            this.ExportFormatLabel.TabIndex = 7;
            this.ExportFormatLabel.Text = "-";
            // 
            // ExportHeightLabel
            // 
            this.ExportHeightLabel.AutoSize = true;
            this.ExportHeightLabel.Location = new System.Drawing.Point(136, 40);
            this.ExportHeightLabel.Name = "ExportHeightLabel";
            this.ExportHeightLabel.Size = new System.Drawing.Size(11, 15);
            this.ExportHeightLabel.TabIndex = 6;
            this.ExportHeightLabel.Text = "-";
            // 
            // ExportWidthLabel
            // 
            this.ExportWidthLabel.AutoSize = true;
            this.ExportWidthLabel.Location = new System.Drawing.Point(136, 18);
            this.ExportWidthLabel.Name = "ExportWidthLabel";
            this.ExportWidthLabel.Size = new System.Drawing.Size(11, 15);
            this.ExportWidthLabel.TabIndex = 5;
            this.ExportWidthLabel.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(37, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Pixel Count :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(3, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Max Text Length :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(31, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Pixel Format :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(70, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Height :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(76, 17);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Width :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ExportTickPictureBox);
            this.groupBox3.Controls.Add(this.ExportedTextLengtLabel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ExportDurationLabel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.ExportButton);
            this.groupBox3.Controls.Add(this.ExportProgressBar);
            this.groupBox3.Controls.Add(this.ExportTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(6, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 263);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Text Info";
            // 
            // ExportTickPictureBox
            // 
            this.ExportTickPictureBox.ErrorImage = null;
            this.ExportTickPictureBox.Image = global::Steganography.Properties.Resources.tick;
            this.ExportTickPictureBox.Location = new System.Drawing.Point(401, 190);
            this.ExportTickPictureBox.Name = "ExportTickPictureBox";
            this.ExportTickPictureBox.Size = new System.Drawing.Size(16, 16);
            this.ExportTickPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ExportTickPictureBox.TabIndex = 18;
            this.ExportTickPictureBox.TabStop = false;
            this.ExportTickPictureBox.Visible = false;
            // 
            // ExportedTextLengtLabel
            // 
            this.ExportedTextLengtLabel.AutoSize = true;
            this.ExportedTextLengtLabel.Location = new System.Drawing.Point(134, 162);
            this.ExportedTextLengtLabel.Name = "ExportedTextLengtLabel";
            this.ExportedTextLengtLabel.Size = new System.Drawing.Size(11, 15);
            this.ExportedTextLengtLabel.TabIndex = 12;
            this.ExportedTextLengtLabel.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(34, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Text Lenght :";
            // 
            // ExportDurationLabel
            // 
            this.ExportDurationLabel.AutoSize = true;
            this.ExportDurationLabel.Location = new System.Drawing.Point(134, 188);
            this.ExportDurationLabel.Name = "ExportDurationLabel";
            this.ExportDurationLabel.Size = new System.Drawing.Size(11, 15);
            this.ExportDurationLabel.TabIndex = 10;
            this.ExportDurationLabel.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(5, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Processing Time :";
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExportButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ExportButton.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExportButton.Image = global::Steganography.Properties.Resources.circle;
            this.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location = new System.Drawing.Point(257, 135);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(163, 23);
            this.ExportButton.TabIndex = 7;
            this.ExportButton.Text = "Export Text";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ExportProgressBar
            // 
            this.ExportProgressBar.BackColor = System.Drawing.Color.Black;
            this.ExportProgressBar.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ExportProgressBar.Location = new System.Drawing.Point(5, 229);
            this.ExportProgressBar.Name = "ExportProgressBar";
            this.ExportProgressBar.Size = new System.Drawing.Size(421, 27);
            this.ExportProgressBar.TabIndex = 6;
            // 
            // ExportTextBox
            // 
            this.ExportTextBox.Location = new System.Drawing.Point(9, 14);
            this.ExportTextBox.Name = "ExportTextBox";
            this.ExportTextBox.Size = new System.Drawing.Size(410, 116);
            this.ExportTextBox.TabIndex = 4;
            this.ExportTextBox.Text = "";
            // 
            // AboutTabPage
            // 
            this.AboutTabPage.Controls.Add(this.label14);
            this.AboutTabPage.Location = new System.Drawing.Point(4, 25);
            this.AboutTabPage.Name = "AboutTabPage";
            this.AboutTabPage.Size = new System.Drawing.Size(1050, 485);
            this.AboutTabPage.TabIndex = 2;
            this.AboutTabPage.Text = "                 About                 ";
            this.AboutTabPage.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(447, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "suadev@gmail.com";
            // 
            // Help
            // 
            this.Help.Controls.Add(this.label8);
            this.Help.Controls.Add(this.label6);
            this.Help.Controls.Add(this.pictureBox2);
            this.Help.Controls.Add(this.pictureBox1);
            this.Help.Cursor = System.Windows.Forms.Cursors.Default;
            this.Help.Location = new System.Drawing.Point(4, 25);
            this.Help.Name = "Help";
            this.Help.Padding = new System.Windows.Forms.Padding(3);
            this.Help.Size = new System.Drawing.Size(1050, 485);
            this.Help.TabIndex = 3;
            this.Help.Text = "                 Help                 ";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 20F);
            this.label8.Location = new System.Drawing.Point(256, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "2.Export Process";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 20F);
            this.label6.Location = new System.Drawing.Point(569, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "1.Import Process";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(557, 234);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(488, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 247);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1084, 537);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEGANOGRAPHY v.1.0  Suat KÖSE";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.ImportTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportTickPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportPictureBox)).EndInit();
            this.ExportTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExportPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExportTickPictureBox)).EndInit();
            this.AboutTabPage.ResumeLayout(false);
            this.AboutTabPage.PerformLayout();
            this.Help.ResumeLayout(false);
            this.Help.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ImportTabPage;
        private System.Windows.Forms.TabPage ExportTabPage;
        private System.Windows.Forms.Button OpenFileImportButton;
        private System.Windows.Forms.PictureBox ImportPictureBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ImportMaxLengthLabel;
        private System.Windows.Forms.Label ImportFormatLabel;
        private System.Windows.Forms.Label ImportHeightLabel;
        private System.Windows.Forms.Label ImportWidthLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar ImportProgressBar;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ImportPixelsLabel;
        private System.Windows.Forms.Label ImportDurationLabel;
        private System.Windows.Forms.Label ImportedTextLengtLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button OpenFileExportButton;
        private System.Windows.Forms.PictureBox ExportPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ExportedTextLengtLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ExportDurationLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.ProgressBar ExportProgressBar;
        private System.Windows.Forms.RichTextBox ImportTextBox;
        private System.Windows.Forms.RichTextBox ExportTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ExportPixelsLabel;
        private System.Windows.Forms.Label ExportMaxLengthLabel;
        private System.Windows.Forms.Label ExportFormatLabel;
        private System.Windows.Forms.Label ExportHeightLabel;
        private System.Windows.Forms.Label ExportWidthLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox ImportTickPictureBox;
        private System.Windows.Forms.PictureBox ExportTickPictureBox;
        private System.Windows.Forms.TabPage AboutTabPage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage Help;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

