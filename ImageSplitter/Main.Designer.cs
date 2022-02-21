namespace ImageSplitter
{
    partial class Main
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
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.SelectSaveDirectoryButton = new System.Windows.Forms.Button();
            this.ColumsnUpDown = new System.Windows.Forms.NumericUpDown();
            this.RowsUpDown = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.DirectoryToSaveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumsnUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainPictureBox.Location = new System.Drawing.Point(12, 12);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(308, 339);
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.Location = new System.Drawing.Point(347, 12);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(140, 23);
            this.SelectImageButton.TabIndex = 1;
            this.SelectImageButton.Text = "Select Image";
            this.SelectImageButton.UseVisualStyleBackColor = true;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // ProcessButton
            // 
            this.ProcessButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProcessButton.Location = new System.Drawing.Point(126, 357);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessButton.TabIndex = 2;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = false;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // SelectSaveDirectoryButton
            // 
            this.SelectSaveDirectoryButton.Location = new System.Drawing.Point(347, 58);
            this.SelectSaveDirectoryButton.Name = "SelectSaveDirectoryButton";
            this.SelectSaveDirectoryButton.Size = new System.Drawing.Size(140, 23);
            this.SelectSaveDirectoryButton.TabIndex = 3;
            this.SelectSaveDirectoryButton.Text = "Select Save Directory";
            this.SelectSaveDirectoryButton.UseVisualStyleBackColor = true;
            this.SelectSaveDirectoryButton.Click += new System.EventHandler(this.SelectSaveDirectoryButton_Click);
            // 
            // ColumsnUpDown
            // 
            this.ColumsnUpDown.Location = new System.Drawing.Point(347, 161);
            this.ColumsnUpDown.Name = "ColumsnUpDown";
            this.ColumsnUpDown.Size = new System.Drawing.Size(120, 23);
            this.ColumsnUpDown.TabIndex = 5;
            // 
            // RowsUpDown
            // 
            this.RowsUpDown.Location = new System.Drawing.Point(347, 213);
            this.RowsUpDown.Name = "RowsUpDown";
            this.RowsUpDown.Size = new System.Drawing.Size(120, 23);
            this.RowsUpDown.TabIndex = 6;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(347, 143);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(55, 15);
            this.WidthLabel.TabIndex = 7;
            this.WidthLabel.Text = "Columns";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(347, 195);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(35, 15);
            this.HeightLabel.TabIndex = 8;
            this.HeightLabel.Text = "Rows";
            // 
            // DirectoryToSaveLabel
            // 
            this.DirectoryToSaveLabel.AutoSize = true;
            this.DirectoryToSaveLabel.Location = new System.Drawing.Point(326, 83);
            this.DirectoryToSaveLabel.Name = "DirectoryToSaveLabel";
            this.DirectoryToSaveLabel.Size = new System.Drawing.Size(0, 15);
            this.DirectoryToSaveLabel.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.DirectoryToSaveLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.RowsUpDown);
            this.Controls.Add(this.ColumsnUpDown);
            this.Controls.Add(this.SelectSaveDirectoryButton);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.SelectImageButton);
            this.Controls.Add(this.MainPictureBox);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumsnUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox MainPictureBox;
        private Button SelectImageButton;
        private Button ProcessButton;
        private Button SelectSaveDirectoryButton;
        private NumericUpDown ColumsnUpDown;
        private NumericUpDown RowsUpDown;
        private Label WidthLabel;
        private Label HeightLabel;
        private Label DirectoryToSaveLabel;
    }
}