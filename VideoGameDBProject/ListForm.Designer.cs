namespace VideoGameDBProject
{
    partial class ListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            this.reviewLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.listLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.VG_ListView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReleaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Developer_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Publisher_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List_ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addPic = new System.Windows.Forms.PictureBox();
            this.editPic = new System.Windows.Forms.PictureBox();
            this.deletePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePic)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewLabel
            // 
            this.reviewLabel.AutoSize = true;
            this.reviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reviewLabel.Location = new System.Drawing.Point(756, 37);
            this.reviewLabel.Name = "reviewLabel";
            this.reviewLabel.Size = new System.Drawing.Size(105, 29);
            this.reviewLabel.TabIndex = 19;
            this.reviewLabel.Text = "Reviews";
            this.reviewLabel.Click += new System.EventHandler(this.reviewLabel_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceLabel.Location = new System.Drawing.Point(649, 37);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(81, 29);
            this.priceLabel.TabIndex = 18;
            this.priceLabel.Text = "Prices";
            this.priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listLabel.Location = new System.Drawing.Point(887, 37);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(99, 29);
            this.listLabel.TabIndex = 17;
            this.listLabel.Text = "My Lists";
            this.listLabel.Click += new System.EventHandler(this.listLabel_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeLabel.Location = new System.Drawing.Point(545, 37);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(78, 29);
            this.homeLabel.TabIndex = 16;
            this.homeLabel.Text = "Home";
            this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1012, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(728, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 28);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // VG_ListView
            // 
            this.VG_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.ReleaseDate,
            this.Genre,
            this.Developer_Name,
            this.Publisher_Name});
            this.VG_ListView.HideSelection = false;
            this.VG_ListView.Location = new System.Drawing.Point(33, 212);
            this.VG_ListView.Name = "VG_ListView";
            this.VG_ListView.Size = new System.Drawing.Size(527, 383);
            this.VG_ListView.TabIndex = 24;
            this.VG_ListView.UseCompatibleStateImageBehavior = false;
            this.VG_ListView.View = System.Windows.Forms.View.Details;
            this.VG_ListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 78;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.Text = "Release Date";
            this.ReleaseDate.Width = 124;
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            this.Genre.Width = 63;
            // 
            // Developer_Name
            // 
            this.Developer_Name.Text = "Developer Name";
            this.Developer_Name.Width = 132;
            // 
            // Publisher_Name
            // 
            this.Publisher_Name.Text = "Publisher Name";
            this.Publisher_Name.Width = 132;
            // 
            // List_ListView
            // 
            this.List_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.List_ListView.HideSelection = false;
            this.List_ListView.Location = new System.Drawing.Point(576, 212);
            this.List_ListView.Name = "List_ListView";
            this.List_ListView.Size = new System.Drawing.Size(527, 383);
            this.List_ListView.TabIndex = 25;
            this.List_ListView.UseCompatibleStateImageBehavior = false;
            this.List_ListView.View = System.Windows.Forms.View.Details;
            this.List_ListView.SelectedIndexChanged += new System.EventHandler(this.List_ListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Release Date";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Genre";
            this.columnHeader3.Width = 63;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Developer Name";
            this.columnHeader4.Width = 132;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Publisher Name";
            this.columnHeader5.Width = 132;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(235, 616);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 41);
            this.button2.TabIndex = 27;
            this.button2.Text = "Add to List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(769, 616);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 41);
            this.button3.TabIndex = 28;
            this.button3.Text = "Delete from List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addPic
            // 
            this.addPic.Image = ((System.Drawing.Image)(resources.GetObject("addPic.Image")));
            this.addPic.Location = new System.Drawing.Point(926, 144);
            this.addPic.Name = "addPic";
            this.addPic.Size = new System.Drawing.Size(52, 49);
            this.addPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addPic.TabIndex = 31;
            this.addPic.TabStop = false;
            // 
            // editPic
            // 
            this.editPic.Image = ((System.Drawing.Image)(resources.GetObject("editPic.Image")));
            this.editPic.Location = new System.Drawing.Point(987, 144);
            this.editPic.Name = "editPic";
            this.editPic.Size = new System.Drawing.Size(52, 49);
            this.editPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.editPic.TabIndex = 32;
            this.editPic.TabStop = false;
            // 
            // deletePic
            // 
            this.deletePic.Image = ((System.Drawing.Image)(resources.GetObject("deletePic.Image")));
            this.deletePic.Location = new System.Drawing.Point(1048, 144);
            this.deletePic.Name = "deletePic";
            this.deletePic.Size = new System.Drawing.Size(52, 49);
            this.deletePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.deletePic.TabIndex = 33;
            this.deletePic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(595, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Select List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(42, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Video Games:";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1134, 777);
            this.Controls.Add(this.deletePic);
            this.Controls.Add(this.editPic);
            this.Controls.Add(this.addPic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.List_ListView);
            this.Controls.Add(this.VG_ListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reviewLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListForm";
            this.Text = "My Lists";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListForm_FormClosing);
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reviewLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView VG_ListView;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader ReleaseDate;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ColumnHeader Developer_Name;
        private System.Windows.Forms.ColumnHeader Publisher_Name;
        private System.Windows.Forms.ListView List_ListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox addPic;
        private System.Windows.Forms.PictureBox editPic;
        private System.Windows.Forms.PictureBox deletePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}