namespace VideoGameDBProject
{
    partial class ReviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewForm));
            this.reviewLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.listLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.priceLabel1 = new System.Windows.Forms.Label();
            this.reviewCB = new System.Windows.Forms.ComboBox();
            this.reviewGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewLabel
            // 
            this.reviewLabel.AutoSize = true;
            this.reviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reviewLabel.Location = new System.Drawing.Point(660, 37);
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
            this.priceLabel.Location = new System.Drawing.Point(553, 37);
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
            this.listLabel.Location = new System.Drawing.Point(791, 37);
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
            this.homeLabel.Location = new System.Drawing.Point(449, 37);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(78, 29);
            this.homeLabel.TabIndex = 16;
            this.homeLabel.Text = "Home";
            this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(916, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // priceLabel1
            // 
            this.priceLabel1.AutoSize = true;
            this.priceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceLabel1.Location = new System.Drawing.Point(214, 132);
            this.priceLabel1.Name = "priceLabel1";
            this.priceLabel1.Size = new System.Drawing.Size(227, 29);
            this.priceLabel1.TabIndex = 22;
            this.priceLabel1.Text = "Select Video Game:";
            // 
            // reviewCB
            // 
            this.reviewCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reviewCB.FormattingEnabled = true;
            this.reviewCB.Location = new System.Drawing.Point(456, 133);
            this.reviewCB.Name = "reviewCB";
            this.reviewCB.Size = new System.Drawing.Size(382, 28);
            this.reviewCB.TabIndex = 21;
            this.reviewCB.SelectedIndexChanged += new System.EventHandler(this.reviewCB_SelectedIndexChanged);
            // 
            // reviewGrid
            // 
            this.reviewGrid.AllowUserToAddRows = false;
            this.reviewGrid.AllowUserToDeleteRows = false;
            this.reviewGrid.AllowUserToOrderColumns = true;
            this.reviewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reviewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewGrid.Location = new System.Drawing.Point(35, 198);
            this.reviewGrid.Name = "reviewGrid";
            this.reviewGrid.ReadOnly = true;
            this.reviewGrid.RowHeadersWidth = 62;
            this.reviewGrid.RowTemplate.Height = 28;
            this.reviewGrid.Size = new System.Drawing.Size(962, 445);
            this.reviewGrid.TabIndex = 20;
            this.reviewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reviewGrid_CellContentClick);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1038, 684);
            this.Controls.Add(this.priceLabel1);
            this.Controls.Add(this.reviewCB);
            this.Controls.Add(this.reviewGrid);
            this.Controls.Add(this.reviewLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReviewForm";
            this.Text = "Reviews";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReviewForm_FormClosing);
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reviewLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label priceLabel1;
        private System.Windows.Forms.ComboBox reviewCB;
        private System.Windows.Forms.DataGridView reviewGrid;
    }
}