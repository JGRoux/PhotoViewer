namespace MyPhotoViewer.View
{
    partial class UserControlPictures
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnPreviousPicture = new System.Windows.Forms.Button();
            this.btnNextPicture = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblPictureName = new System.Windows.Forms.Label();
            this.lblPictureSize = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPictureDimension = new System.Windows.Forms.Label();
            this.lblPictureDate = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtBxPictureDescription = new System.Windows.Forms.TextBox();
            this.lblDimension = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnPreviousPicture);
            this.panelTop.Controls.Add(this.btnNextPicture);
            this.panelTop.Controls.Add(this.btnBack);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(752, 36);
            this.panelTop.TabIndex = 0;
            // 
            // btnPreviousPicture
            // 
            this.btnPreviousPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviousPicture.BackgroundImage = global::MyPhotoViewer.Properties.Resources.icon_arrow_left;
            this.btnPreviousPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreviousPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousPicture.Location = new System.Drawing.Point(683, 3);
            this.btnPreviousPicture.Name = "btnPreviousPicture";
            this.btnPreviousPicture.Size = new System.Drawing.Size(30, 30);
            this.btnPreviousPicture.TabIndex = 1;
            this.btnPreviousPicture.UseVisualStyleBackColor = true;
            this.btnPreviousPicture.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNextPicture
            // 
            this.btnNextPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPicture.BackgroundImage = global::MyPhotoViewer.Properties.Resources.icon_arrow_right;
            this.btnNextPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPicture.Location = new System.Drawing.Point(719, 3);
            this.btnNextPicture.Name = "btnNextPicture";
            this.btnNextPicture.Size = new System.Drawing.Size(30, 30);
            this.btnNextPicture.TabIndex = 2;
            this.btnNextPicture.UseVisualStyleBackColor = true;
            this.btnNextPicture.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::MyPhotoViewer.Properties.Resources.icon_back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblPictureName);
            this.panelBottom.Controls.Add(this.lblPictureSize);
            this.panelBottom.Controls.Add(this.lblSize);
            this.panelBottom.Controls.Add(this.lblPictureDimension);
            this.panelBottom.Controls.Add(this.lblPictureDate);
            this.panelBottom.Controls.Add(this.star1);
            this.panelBottom.Controls.Add(this.star2);
            this.panelBottom.Controls.Add(this.star3);
            this.panelBottom.Controls.Add(this.star4);
            this.panelBottom.Controls.Add(this.star5);
            this.panelBottom.Controls.Add(this.lblDate);
            this.panelBottom.Controls.Add(this.lblDescription);
            this.panelBottom.Controls.Add(this.txtBxPictureDescription);
            this.panelBottom.Controls.Add(this.lblDimension);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 263);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(752, 75);
            this.panelBottom.TabIndex = 2;
            // 
            // lblPictureName
            // 
            this.lblPictureName.AutoSize = true;
            this.lblPictureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPictureName.Location = new System.Drawing.Point(4, 9);
            this.lblPictureName.Name = "lblPictureName";
            this.lblPictureName.Size = new System.Drawing.Size(0, 16);
            this.lblPictureName.TabIndex = 16;
            this.lblPictureName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPictureSize
            // 
            this.lblPictureSize.BackColor = System.Drawing.SystemColors.Control;
            this.lblPictureSize.Location = new System.Drawing.Point(343, 29);
            this.lblPictureSize.Name = "lblPictureSize";
            this.lblPictureSize.Size = new System.Drawing.Size(80, 20);
            this.lblPictureSize.TabIndex = 15;
            this.lblPictureSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSize.Location = new System.Drawing.Point(314, 33);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(33, 13);
            this.lblSize.TabIndex = 14;
            this.lblSize.Text = "Size :";
            // 
            // lblPictureDimension
            // 
            this.lblPictureDimension.BackColor = System.Drawing.SystemColors.Control;
            this.lblPictureDimension.Location = new System.Drawing.Point(224, 29);
            this.lblPictureDimension.Name = "lblPictureDimension";
            this.lblPictureDimension.Size = new System.Drawing.Size(80, 20);
            this.lblPictureDimension.TabIndex = 13;
            this.lblPictureDimension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPictureDate
            // 
            this.lblPictureDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblPictureDate.Location = new System.Drawing.Point(36, 29);
            this.lblPictureDate.Name = "lblPictureDate";
            this.lblPictureDate.Size = new System.Drawing.Size(120, 20);
            this.lblPictureDate.TabIndex = 12;
            this.lblPictureDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // star1
            // 
            this.star1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.star1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star1.Image = global::MyPhotoViewer.Properties.Resources.icon_empty_star;
            this.star1.Location = new System.Drawing.Point(624, 24);
            this.star1.Margin = new System.Windows.Forms.Padding(0);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(25, 25);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star1.TabIndex = 11;
            this.star1.TabStop = false;
            this.star1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stars_MouseClick);
            this.star1.MouseEnter += new System.EventHandler(this.stars_MouseEnter);
            this.star1.MouseLeave += new System.EventHandler(this.stars_MouseLeave);
            // 
            // star2
            // 
            this.star2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.star2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star2.Image = global::MyPhotoViewer.Properties.Resources.icon_empty_star;
            this.star2.Location = new System.Drawing.Point(649, 24);
            this.star2.Margin = new System.Windows.Forms.Padding(0);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(25, 25);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star2.TabIndex = 10;
            this.star2.TabStop = false;
            this.star2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stars_MouseClick);
            this.star2.MouseEnter += new System.EventHandler(this.stars_MouseEnter);
            this.star2.MouseLeave += new System.EventHandler(this.stars_MouseLeave);
            // 
            // star3
            // 
            this.star3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.star3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star3.Image = global::MyPhotoViewer.Properties.Resources.icon_empty_star;
            this.star3.Location = new System.Drawing.Point(674, 24);
            this.star3.Margin = new System.Windows.Forms.Padding(0);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(25, 25);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star3.TabIndex = 9;
            this.star3.TabStop = false;
            this.star3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stars_MouseClick);
            this.star3.MouseEnter += new System.EventHandler(this.stars_MouseEnter);
            this.star3.MouseLeave += new System.EventHandler(this.stars_MouseLeave);
            // 
            // star4
            // 
            this.star4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.star4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star4.Image = global::MyPhotoViewer.Properties.Resources.icon_empty_star;
            this.star4.Location = new System.Drawing.Point(699, 24);
            this.star4.Margin = new System.Windows.Forms.Padding(0);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(25, 25);
            this.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star4.TabIndex = 8;
            this.star4.TabStop = false;
            this.star4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stars_MouseClick);
            this.star4.MouseEnter += new System.EventHandler(this.stars_MouseEnter);
            this.star4.MouseLeave += new System.EventHandler(this.stars_MouseLeave);
            // 
            // star5
            // 
            this.star5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.star5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star5.Image = global::MyPhotoViewer.Properties.Resources.icon_empty_star;
            this.star5.Location = new System.Drawing.Point(724, 24);
            this.star5.Margin = new System.Windows.Forms.Padding(0);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(25, 25);
            this.star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star5.TabIndex = 7;
            this.star5.TabStop = false;
            this.star5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stars_MouseClick);
            this.star5.MouseEnter += new System.EventHandler(this.stars_MouseEnter);
            this.star5.MouseLeave += new System.EventHandler(this.stars_MouseLeave);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDate.Location = new System.Drawing.Point(4, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescription.Location = new System.Drawing.Point(4, 55);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description :";
            // 
            // txtBxPictureDescription
            // 
            this.txtBxPictureDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxPictureDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtBxPictureDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxPictureDescription.Location = new System.Drawing.Point(76, 55);
            this.txtBxPictureDescription.Margin = new System.Windows.Forms.Padding(0);
            this.txtBxPictureDescription.Name = "txtBxPictureDescription";
            this.txtBxPictureDescription.Size = new System.Drawing.Size(671, 13);
            this.txtBxPictureDescription.TabIndex = 2;
            this.txtBxPictureDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxPictureDescription_KeyDown);
            this.txtBxPictureDescription.MouseEnter += new System.EventHandler(this.txtBxPictureDescription_MouseEnter);
            this.txtBxPictureDescription.MouseLeave += new System.EventHandler(this.txtBxPictureDescription_MouseLeave);
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDimension.Location = new System.Drawing.Point(166, 33);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(62, 13);
            this.lblDimension.TabIndex = 1;
            this.lblDimension.Text = "Dimension :";
            // 
            // pictureBox
            // 
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 36);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(752, 227);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // UserControlPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "UserControlPictures";
            this.Size = new System.Drawing.Size(752, 338);
            this.Load += new System.EventHandler(this.UserControlPictures_Load);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnPreviousPicture;
        private System.Windows.Forms.Button btnNextPicture;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtBxPictureDescription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox star5;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star4;
        private System.Windows.Forms.Label lblPictureDimension;
        private System.Windows.Forms.Label lblPictureDate;
        private System.Windows.Forms.Label lblPictureSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPictureName;
    }
}
