namespace MyPhotoViewer
{
    partial class MainForm
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelAlbums = new System.Windows.Forms.Panel();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.lstBxAlbums = new System.Windows.Forms.ListBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelAlbums.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelAlbums);
            this.splitContainer.Panel1.Controls.Add(this.lstBxAlbums);
            this.splitContainer.Panel1MinSize = 130;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer.Panel2.Controls.Add(this.lblWelcome);
            this.splitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer.Panel2MinSize = 600;
            this.splitContainer.Size = new System.Drawing.Size(784, 412);
            this.splitContainer.SplitterDistance = 130;
            this.splitContainer.TabIndex = 2;
            // 
            // panelAlbums
            // 
            this.panelAlbums.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAlbums.Controls.Add(this.lblAlbum);
            this.panelAlbums.Controls.Add(this.btnAddAlbum);
            this.panelAlbums.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlbums.Location = new System.Drawing.Point(0, 0);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(128, 36);
            this.panelAlbums.TabIndex = 3;
            // 
            // lblAlbum
            // 
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(11, 10);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(62, 20);
            this.lblAlbum.TabIndex = 1;
            this.lblAlbum.Text = "Albums";
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAlbum.BackgroundImage = global::MyPhotoViewer.Properties.Resources.icon_album;
            this.btnAddAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAlbum.Location = new System.Drawing.Point(95, 3);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(30, 30);
            this.btnAddAlbum.TabIndex = 2;
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.buttonAddAlbum_Click);
            // 
            // lstBxAlbums
            // 
            this.lstBxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBxAlbums.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBxAlbums.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstBxAlbums.FormattingEnabled = true;
            this.lstBxAlbums.HorizontalScrollbar = true;
            this.lstBxAlbums.IntegralHeight = false;
            this.lstBxAlbums.Location = new System.Drawing.Point(-1, 35);
            this.lstBxAlbums.Name = "lstBxAlbums";
            this.lstBxAlbums.Size = new System.Drawing.Size(131, 377);
            this.lstBxAlbums.Sorted = true;
            this.lstBxAlbums.TabIndex = 0;
            this.lstBxAlbums.SelectedIndexChanged += new System.EventHandler(this.lstBxAlbums_SelectedIndexChanged);
            this.lstBxAlbums.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.SystemColors.Control;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Image = ((System.Drawing.Image)(resources.GetObject("lblWelcome.Image")));
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(648, 410);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "\r\n\r\n\r\nWelcome to PhotoViewer\r\n\r\nCreated by Alexandre Bensimon and Jean-Guillaume " +
    "Roux";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.Text = "PhotoViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelAlbums.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.Panel panelAlbums;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ListBox lstBxAlbums;


    }
}

