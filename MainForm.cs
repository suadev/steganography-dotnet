using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Steganography
{
    public partial class MainForm : Form
    {
        #region Fields
        private readonly Importer _importer;
        private readonly Exporter _exporter;
        #endregion

        #region Properties

        public Bitmap Bmp;
        public Stopwatch Sw;
        public int ImageWidth, ImageHeight;

        public ProgressBar ImpProgressBar
        {
            get { return ImportProgressBar; }
        }
        public int ImportProgressBarValue
        {
            set { ImportProgressBar.Value = value; }
        }
        public int ImportProgressBarMaximum
        {
            set { ImportProgressBar.Maximum = value; }
        }

        public ProgressBar ExpProgressBar
        {
            get { return ExportProgressBar; }
        }
        public int ExportProgressBarValue
        {
            set { ExportProgressBar.Value = value; }
        }
        public int ExportProgressBarMaximum
        {
            set { ExportProgressBar.Maximum = value; }
        }

        public Image ImportPictureBoxImage
        {
            get { return ImportPictureBox.Image; }
            set { ImportPictureBox.Image = value; }
        }
        public Image ExportPictureBoxImage
        {
            get { return ExportPictureBox.Image; }
            set { ExportPictureBox.Image = value; }
        }

        public string ImportTextBoxText
        {
            get { return ImportTextBox.Text; }
            set { ImportTextBox.Text = value; }
        }
        public string ImportWidthLabelText
        {
            get { return ImportWidthLabel.Text; }
            set { ImportWidthLabel.Text = value; }
        }
        public string ImportHeightLabelText
        {
            get { return ImportHeightLabel.Text; }
            set { ImportHeightLabel.Text = value; }
        }
        public string ImportFormatLabelText
        {
            get { return ImportFormatLabel.Text; }
            set { ImportFormatLabel.Text = value; }
        }
        public string ImportPixelsLabelText
        {
            get { return ImportPixelsLabel.Text; }
            set { ImportPixelsLabel.Text = value; }
        }
        public string ImportMaxLengthLabelText
        {
            get { return ImportMaxLengthLabel.Text; }
            set { ImportMaxLengthLabel.Text = value; }
        }
        public string ImportedTextLengtLabelText
        {
            get { return ImportedTextLengtLabel.Text; }
            set { ImportedTextLengtLabel.Text = value; }
        }
        public string ImportDurationLabelText
        {
            get { return ImportDurationLabel.Text; }
            set { ImportDurationLabel.Text = value; }
        }

        public string ExportTextBoxText
        {
            get { return ExportTextBox.Text; }
            set { ExportTextBox.Text = value; }
        }
        public string ExportWidthLabelText
        {
            get { return ExportWidthLabel.Text; }
            set { ExportWidthLabel.Text = value; }
        }
        public string ExportHeightLabelText
        {
            get { return ExportHeightLabel.Text; }
            set { ExportHeightLabel.Text = value; }
        }
        public string ExportFormatLabelText
        {
            get { return ExportFormatLabel.Text; }
            set { ExportFormatLabel.Text = value; }
        }
        public string ExportPixelsLabelText
        {
            get { return ExportPixelsLabel.Text; }
            set { ExportPixelsLabel.Text = value; }
        }
        public string ExportMaxLengthLabelText
        {
            get { return ExportMaxLengthLabel.Text; }
            set { ExportMaxLengthLabel.Text = value; }
        }
        public string ExportedTextLengtLabelText
        {
            get { return ExportedTextLengtLabel.Text; }
            set { ExportedTextLengtLabel.Text = value; }
        }
        public string ExportDurationLabelText
        {
            get { return ExportDurationLabel.Text; }
            set { ExportDurationLabel.Text = value; }
        }

        public bool ImportTickPictureBoxVisible
        {
            set { ImportTickPictureBox.Visible = value; }
        }
        public bool ExportTickPictureBoxVisible
        {
            set { ExportTickPictureBox.Visible = value; }
        }
        #endregion

        #region Ctor

        public MainForm()
        {
            InitializeComponent();
            _exporter = new Exporter(this);
            _importer = new Importer(this);
        }

        #endregion

        #region Button Click Events
        private void OpenFileImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = CommonConstants.OpenFileFilter;
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportPictureBox.Image = Image.FromFile(OpenFileDialog.FileName);
                Bmp = new Bitmap(ImportPictureBox.Image);
                _importer.SetImportedImageInfo();
            }
        }
        private void OpenFileExportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = CommonConstants.OpenFileFilter;
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportPictureBox.Image = Image.FromFile(OpenFileDialog.FileName);
                _exporter.SetExportedImageInfo();
            }
        }
        private void ImportButton_Click(object sender, EventArgs e)
        {
            if (ImportTextBox.TextLength > 0)
            {
                _importer.Import();
            }
            else
            {
                MessageBox.Show("Enter text before!", CommonConstants.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (ExportWidthLabel.Text != "-")
            {
                _exporter.Export();
            }
            else
            {
                MessageBox.Show("Open an image file before!", CommonConstants.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {

        }

        private void ExportPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = CommonConstants.SaveDialogFilter;
            saveFileDialog.Title = CommonConstants.SaveDialogTitle;
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != string.Empty)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        Bmp.Save(saveFileDialog.FileName);
                        break;
                    case 2:
                        Bmp.Save(saveFileDialog.FileName);
                        break;
                    case 3:
                        System.IO.FileStream fs2 = (System.IO.FileStream)saveFileDialog.OpenFile();
                        Bmp.Save(fs2, System.Drawing.Imaging.ImageFormat.Bmp);
                        fs2.Close();
                        break;
                }
            }
        }
        #endregion
    }
}