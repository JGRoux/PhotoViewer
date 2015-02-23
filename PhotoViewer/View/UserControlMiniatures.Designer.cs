namespace MyPhotoViewer.View
{
    partial class UserControlMiniatures
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
            this.panelTopCenter = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.listViewMiniatures = new System.Windows.Forms.ListView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.lblNoPicture = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnDeletePictures = new System.Windows.Forms.Button();
            this.btnDiaporama = new System.Windows.Forms.Button();
            this.btnAddPictures = new System.Windows.Forms.Button();
            this.panelTopCenter.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopCenter
            // 
            this.panelTopCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopCenter.Controls.Add(this.panelCenter);
            this.panelTopCenter.Controls.Add(this.panelTop);
            this.panelTopCenter.Controls.Add(this.lblNoPicture);
            this.panelTopCenter.Location = new System.Drawing.Point(0, 0);
            this.panelTopCenter.Margin = new System.Windows.Forms.Padding(0);
            this.panelTopCenter.Name = "panelTopCenter";
            this.panelTopCenter.Size = new System.Drawing.Size(320, 282);
            this.panelTopCenter.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.SystemColors.Control;
            this.panelCenter.Controls.Add(this.listViewMiniatures);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 36);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(320, 246);
            this.panelCenter.TabIndex = 3;
            // 
            // listViewMiniatures
            // 
            this.listViewMiniatures.AllowDrop = true;
            this.listViewMiniatures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewMiniatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMiniatures.Location = new System.Drawing.Point(0, 0);
            this.listViewMiniatures.Margin = new System.Windows.Forms.Padding(0);
            this.listViewMiniatures.Name = "listViewMiniatures";
            this.listViewMiniatures.Size = new System.Drawing.Size(320, 246);
            this.listViewMiniatures.TabIndex = 0;
            this.listViewMiniatures.UseCompatibleStateImageBehavior = false;
            this.listViewMiniatures.DragDrop += new System.Windows.Forms.DragEventHandler(this.picture_DragDrop);
            this.listViewMiniatures.DragEnter += new System.Windows.Forms.DragEventHandler(this.picture_DragEnter);
            this.listViewMiniatures.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            this.listViewMiniatures.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView_MouseMove);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblAlbumName);
            this.panelTop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(320, 36);
            this.panelTop.TabIndex = 2;
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumName.Location = new System.Drawing.Point(3, 10);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(0, 16);
            this.lblAlbumName.TabIndex = 0;
            // 
            // lblNoPicture
            // 
            this.lblNoPicture.AllowDrop = true;
            this.lblNoPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoPicture.Location = new System.Drawing.Point(0, 0);
            this.lblNoPicture.Name = "lblNoPicture";
            this.lblNoPicture.Size = new System.Drawing.Size(320, 282);
            this.lblNoPicture.TabIndex = 0;
            this.lblNoPicture.Text = "There is no pictures in this album yet.\r\nDrag&Drop pictures here or use the butto" +
    "n below.";
            this.lblNoPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.picture_DragDrop);
            this.lblNoPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.picture_DragEnter);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnDeletePictures);
            this.panelBottom.Controls.Add(this.btnDiaporama);
            this.panelBottom.Controls.Add(this.btnAddPictures);
            this.panelBottom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 284);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(320, 36);
            this.panelBottom.TabIndex = 1;
            // 
            // btnDeletePictures
            // 
            this.btnDeletePictures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePictures.BackgroundImage = global::MyPhotoViewer.Properties.Resources.icon_delete;
            this.btnDeletePictures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePictures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePictures.Location = new System.Drawing.Point(287, 4);
            this.btnDeletePictures.Name = "btnDeletePictures";
            this.btnDeletePictures.Size = new System.Drawing.Size(30, 30);
            this.btnDeletePictures.TabIndex = 2;
            this.btnDeletePictures.UseVisualStyleBackColor = true;
            this.btnDeletePictures.Click += new System.EventHandler(this.btnDeletePictures_Click);
            // 
            // btnDiaporama
            // 
            this.btnDiaporama.BackgroundImage = global::MyPhotoViewer.Properties.Resources.icon_play;
            this.btnDiaporama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiaporama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiaporama.Location = new System.Drawing.Point(39, 4);
            this.btnDiaporama.Name = "btnDiaporama";
            this.btnDiaporama.Size = new System.Drawing.Size(30, 30);
            this.btnDiaporama.TabIndex = 1;
            this.btnDiaporama.UseVisualStyleBackColor = true;
            this.btnDiaporama.Click += new System.EventHandler(this.btnDiaporama_Click);
            // 
            // btnAddPictures
            // 
            this.btnAddPictures.BackgroundImage = global::MyPhotoViewer.Properties.Resources.icon_add;
            this.btnAddPictures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPictures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPictures.Location = new System.Drawing.Point(3, 4);
            this.btnAddPictures.Name = "btnAddPictures";
            this.btnAddPictures.Size = new System.Drawing.Size(30, 30);
            this.btnAddPictures.TabIndex = 0;
            this.btnAddPictures.UseVisualStyleBackColor = true;
            this.btnAddPictures.Click += new System.EventHandler(this.btnAddPictures_Click);
            // 
            // UserControlMiniatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTopCenter);
            this.Name = "UserControlMiniatures";
            this.Size = new System.Drawing.Size(320, 320);
            this.Load += new System.EventHandler(this.UserControlMiniatures_Load);
            this.panelTopCenter.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopCenter;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAddPictures;
        private System.Windows.Forms.Label lblNoPicture;
        private System.Windows.Forms.Button btnDiaporama;
        private System.Windows.Forms.Button btnDeletePictures;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.Panel panelCenter;
        public System.Windows.Forms.ListView listViewMiniatures;

    }
}
