namespace ProjektReal
{
    partial class Presentation
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
            this.lstBoxCategory = new System.Windows.Forms.ListBox();
            this.lstBoxPodcast = new System.Windows.Forms.ListBox();
            this.lstBoxEpisode = new System.Windows.Forms.ListBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPodcast = new System.Windows.Forms.Label();
            this.lblEpisode = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxCategory
            // 
            this.lstBoxCategory.FormattingEnabled = true;
            this.lstBoxCategory.ItemHeight = 20;
            this.lstBoxCategory.Location = new System.Drawing.Point(12, 93);
            this.lstBoxCategory.Name = "lstBoxCategory";
            this.lstBoxCategory.Size = new System.Drawing.Size(420, 284);
            this.lstBoxCategory.TabIndex = 0;
            this.lstBoxCategory.SelectedIndexChanged += new System.EventHandler(this.lstBoxCategory_SelectedIndexChanged);
            // 
            // lstBoxPodcast
            // 
            this.lstBoxPodcast.FormattingEnabled = true;
            this.lstBoxPodcast.ItemHeight = 20;
            this.lstBoxPodcast.Location = new System.Drawing.Point(473, 93);
            this.lstBoxPodcast.Name = "lstBoxPodcast";
            this.lstBoxPodcast.Size = new System.Drawing.Size(414, 284);
            this.lstBoxPodcast.TabIndex = 1;
            // 
            // lstBoxEpisode
            // 
            this.lstBoxEpisode.FormattingEnabled = true;
            this.lstBoxEpisode.ItemHeight = 20;
            this.lstBoxEpisode.Location = new System.Drawing.Point(927, 93);
            this.lstBoxEpisode.Name = "lstBoxEpisode";
            this.lstBoxEpisode.Size = new System.Drawing.Size(407, 284);
            this.lstBoxEpisode.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(24, 54);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 20);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Kategori";
            // 
            // lblPodcast
            // 
            this.lblPodcast.AutoSize = true;
            this.lblPodcast.Location = new System.Drawing.Point(482, 54);
            this.lblPodcast.Name = "lblPodcast";
            this.lblPodcast.Size = new System.Drawing.Size(67, 20);
            this.lblPodcast.TabIndex = 4;
            this.lblPodcast.Text = "Podcast";
            // 
            // lblEpisode
            // 
            this.lblEpisode.AutoSize = true;
            this.lblEpisode.Location = new System.Drawing.Point(933, 54);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Size = new System.Drawing.Size(57, 20);
            this.lblEpisode.TabIndex = 5;
            this.lblEpisode.Text = "Avsnitt";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(152, 438);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(89, 33);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 629);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblEpisode);
            this.Controls.Add(this.lblPodcast);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lstBoxEpisode);
            this.Controls.Add(this.lstBoxPodcast);
            this.Controls.Add(this.lstBoxCategory);
            this.Name = "Presentation";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxCategory;
        private System.Windows.Forms.ListBox lstBoxPodcast;
        private System.Windows.Forms.ListBox lstBoxEpisode;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPodcast;
        private System.Windows.Forms.Label lblEpisode;
        private System.Windows.Forms.Button btnSettings;
    }
}

