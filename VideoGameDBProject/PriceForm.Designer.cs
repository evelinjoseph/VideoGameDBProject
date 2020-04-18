namespace VideoGameDBProject
{
    partial class PriceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceForm));
            this.priceGrid = new System.Windows.Forms.DataGridView();
            this.priceCB = new System.Windows.Forms.ComboBox();
            this.priceLabel1 = new System.Windows.Forms.Label();
            this.reviewLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.listLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // priceGrid
            // 
            this.priceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceGrid.Location = new System.Drawing.Point(31, 189);
            this.priceGrid.Name = "priceGrid";
            this.priceGrid.RowHeadersWidth = 62;
            this.priceGrid.RowTemplate.Height = 28;
            this.priceGrid.Size = new System.Drawing.Size(879, 316);
            this.priceGrid.TabIndex = 1;
            this.priceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.priceGrid_CellContentClick);
            // 
            // priceCB
            // 
            this.priceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priceCB.FormattingEnabled = true;
            this.priceCB.Location = new System.Drawing.Point(385, 133);
            this.priceCB.Name = "priceCB";
            this.priceCB.Size = new System.Drawing.Size(382, 28);
            this.priceCB.TabIndex = 2;
            this.priceCB.SelectedIndexChanged += new System.EventHandler(this.priceCB_SelectedIndexChanged);
            // 
            // priceLabel1
            // 
            this.priceLabel1.AutoSize = true;
            this.priceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceLabel1.Location = new System.Drawing.Point(143, 132);
            this.priceLabel1.Name = "priceLabel1";
            this.priceLabel1.Size = new System.Drawing.Size(227, 29);
            this.priceLabel1.TabIndex = 3;
            this.priceLabel1.Text = "Select Video Game:";
            this.priceLabel1.Click += new System.EventHandler(this.priceLabel1_Click);
            // 
            // reviewLabel
            // 
            this.reviewLabel.AutoSize = true;
            this.reviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reviewLabel.Location = new System.Drawing.Point(581, 37);
            this.reviewLabel.Name = "reviewLabel";
            this.reviewLabel.Size = new System.Drawing.Size(105, 29);
            this.reviewLabel.TabIndex = 14;
            this.reviewLabel.Text = "Reviews";
            this.reviewLabel.Click += new System.EventHandler(this.reviewLabel_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceLabel.Location = new System.Drawing.Point(474, 37);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(81, 29);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "Prices";
            this.priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listLabel.Location = new System.Drawing.Point(712, 37);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(99, 29);
            this.listLabel.TabIndex = 12;
            this.listLabel.Text = "My Lists";
            this.listLabel.Click += new System.EventHandler(this.listLabel_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeLabel.Location = new System.Drawing.Point(370, 37);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(78, 29);
            this.homeLabel.TabIndex = 11;
            this.homeLabel.Text = "Home";
            this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(837, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(959, 546);
            this.Controls.Add(this.reviewLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.priceLabel1);
            this.Controls.Add(this.priceCB);
            this.Controls.Add(this.priceGrid);
            this.Name = "PriceForm";
            this.Text = "Prices";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PriceForm_FormClosing);
            this.Load += new System.EventHandler(this.PriceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView priceGrid;
        private System.Windows.Forms.ComboBox priceCB;
        private System.Windows.Forms.Label priceLabel1;
        private System.Windows.Forms.Label reviewLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}