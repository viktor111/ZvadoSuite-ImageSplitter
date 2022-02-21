namespace ImageSplitter.ImageProcessing
{
    internal class ImageSplitters
    {
        public ImageGrid SplitToGrid(Image img, int rows, int columns)
        {
            var imgarray = new Image[rows, columns];

            var height = img.Height;
            var width = img.Width;

            var one_img_h = height / rows;
            var one_img_w = width / columns;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    imgarray[i, j] = new Bitmap(one_img_w, one_img_h);

                    var graphics = Graphics.FromImage(imgarray[i, j]);

                    graphics.DrawImage(img, new Rectangle(0, 0, one_img_w, one_img_h), new Rectangle(j * one_img_w, i * one_img_h, one_img_w, one_img_h), GraphicsUnit.Pixel);

                    graphics.Dispose();
                }
            }

            return new ImageGrid(imgarray, rows, columns);
        }
    }
}
