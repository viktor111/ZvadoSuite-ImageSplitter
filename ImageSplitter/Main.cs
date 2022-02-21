namespace ImageSplitter
{
    using ImageProcessing;

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            var directoryToSave = DirectoryToSaveLabel.Text;
            var image = MainPictureBox.Image;

            if (string.IsNullOrEmpty(directoryToSave))
            {
                MessageBox.Show("Select directory to save images first");
                return;
            }
            if(image == null)
            {
                MessageBox.Show("Select image first");
                return;
            }
            if(RowsUpDown.Value <= 0 || ColumsnUpDown.Value <= 0)
            {
                MessageBox.Show("Rows or Columsn has invalid value. Can't be 0 or below.");
                return;
            }

            var imageSplitters = new ImageSplitters();

            var rows = Convert.ToInt32(RowsUpDown.Value);
            var cols = Convert.ToInt32(ColumsnUpDown.Value);

            var images = imageSplitters.SplitToGrid(image, rows, cols);

            var imageProcessor = new ImageProcessor();
            imageProcessor.SaveImageGrid(images, directoryToSave);

            MessageBox.Show("Done!");
        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var bitMap = new Bitmap(fileDialog.FileName);

                MainPictureBox.Image = bitMap;
                MainPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void SelectSaveDirectoryButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string directory = fbd.SelectedPath;
                    DirectoryToSaveLabel.Text = directory;
                }
            }
        }
    }
}
