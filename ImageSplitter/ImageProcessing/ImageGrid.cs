namespace ImageSplitter.ImageProcessing
{
    internal class ImageGrid
    {
        public ImageGrid(Image[,] images, int rows, int columns)
        {
            this.Validate(images, rows, columns);

            this.Images = images;
            this.Rows = rows;
            this.Columns = columns;
        }

        public Image[,] Images { get; private set; }

        public int Rows { get; private set; }

        public int Columns { get; private set; }

        public ImageGrid UpdateImages(Image[,] images)
        {
            this.ValidateImages(images);
            this.Images = images;
            return this;
        }

        private void Validate(Image[,]images, int rows, int columns)
        {
            this.ValidateImages(images);
            this.ValidateRows(rows);
            this.ValidateColumns(columns);
        }

        private void ValidateImages(Image[,] images)
        {
            if(images == null) throw new ImageProcessingNotValidException();
        }

        private void ValidateRows(int rows)
        {
            if (rows <= 0) throw new ImageProcessingNotValidException(); 
        }
        private void ValidateColumns(int rows)
        {
            if (rows <= 0) throw new ImageProcessingNotValidException(); 
        }
    }
}
