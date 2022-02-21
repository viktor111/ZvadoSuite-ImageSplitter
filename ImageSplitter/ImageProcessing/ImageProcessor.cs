namespace ImageSplitter.ImageProcessing
{
    internal class ImageProcessor
    {
        public void SaveImageGrid(ImageGrid imageGrid, string directory)
        {
            for (int i = 0; i < imageGrid.Rows; i++)
            {
                for (int j = 0; j < imageGrid.Columns; j++)
                {
                    imageGrid.Images[i, j].Save(@"" + directory + "/Image_" + i + "_" + j + ".jpg");
                }
            }
        }
    }
}
