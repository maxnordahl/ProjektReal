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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstBoxCategory
            // 
            this.lstBoxCategory.FormattingEnabled = true;
            this.lstBoxCategory.ItemHeight = 20;
            this.lstBoxCategory.Location = new System.Drawing.Point(12, 174);
            this.lstBoxCategory.Name = "lstBoxCategory";
            this.lstBoxCategory.Size = new System.Drawing.Size(420, 284);
            this.lstBoxCategory.TabIndex = 0;
            this.lstBoxCategory.SelectedIndexChanged += new System.EventHandler(this.lstBoxCategory_SelectedIndexChanged);
            // 
            // lstBoxPodcast
            // 
            this.lstBoxPodcast.FormattingEnabled = true;
            this.lstBoxPodcast.ItemHeight = 20;
            this.lstBoxPodcast.Location = new System.Drawing.Point(469, 174);
            this.lstBoxPodcast.Name = "lstBoxPodcast";
            this.lstBoxPodcast.Size = new System.Drawing.Size(414, 284);
            this.lstBoxPodcast.TabIndex = 1;
            // 
            // lstBoxEpisode
            // 
            this.lstBoxEpisode.FormattingEnabled = true;
            this.lstBoxEpisode.ItemHeight = 20;
            this.lstBoxEpisode.Location = new System.Drawing.Point(925, 174);
            this.lstBoxEpisode.Name = "lstBoxEpisode";
            this.lstBoxEpisode.Size = new System.Drawing.Size(407, 284);
            this.lstBoxEpisode.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(29, 138);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 20);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Kategori";
            // 
            // lblPodcast
            // 
            this.lblPodcast.AutoSize = true;
            this.lblPodcast.Location = new System.Drawing.Point(484, 138);
            this.lblPodcast.Name = "lblPodcast";
            this.lblPodcast.Size = new System.Drawing.Size(67, 20);
            this.lblPodcast.TabIndex = 4;
            this.lblPodcast.Text = "Podcast";
            // 
            // lblEpisode
            // 
            this.lblEpisode.AutoSize = true;
            this.lblEpisode.Location = new System.Drawing.Point(954, 138);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Size = new System.Drawing.Size(57, 20);
            this.lblEpisode.TabIndex = 5;
            this.lblEpisode.Text = "Avsnitt";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(135, 551);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(89, 33);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Uppdateringsintervall";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 26);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(727, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 26);
            this.textBox2.TabIndex = 12;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(124, 135);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(194, 28);
            this.cmbCategory.TabIndex = 13;
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 629);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}

