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
            this.lstBoxEpisode = new System.Windows.Forms.ListBox();
            this.lblEpisode = new System.Windows.Forms.Label();
            this.btnPren = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnMyPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxEpisode
            // 
            this.lstBoxEpisode.FormattingEnabled = true;
            this.lstBoxEpisode.ItemHeight = 20;
            this.lstBoxEpisode.Location = new System.Drawing.Point(166, 127);
            this.lstBoxEpisode.Name = "lstBoxEpisode";
            this.lstBoxEpisode.Size = new System.Drawing.Size(407, 284);
            this.lstBoxEpisode.TabIndex = 2;
            // 
            // lblEpisode
            // 
            this.lblEpisode.AutoSize = true;
            this.lblEpisode.Location = new System.Drawing.Point(169, 92);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Size = new System.Drawing.Size(57, 20);
            this.lblEpisode.TabIndex = 5;
            this.lblEpisode.Text = "Avsnitt";
            // 
            // btnPren
            // 
            this.btnPren.Location = new System.Drawing.Point(289, 451);
            this.btnPren.Name = "btnPren";
            this.btnPren.Size = new System.Drawing.Size(118, 47);
            this.btnPren.TabIndex = 6;
            this.btnPren.Text = "Prenumerera";
            this.btnPren.UseVisualStyleBackColor = true;
            this.btnPren.Click += new System.EventHandler(this.btnPren_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(118, 30);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(42, 20);
            this.lblURL.TabIndex = 8;
            this.lblURL.Text = "URL";
            this.lblURL.Click += new System.EventHandler(this.lblURL_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(166, 27);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(322, 26);
            this.txtURL.TabIndex = 11;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(538, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 37);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMyPage
            // 
            this.btnMyPage.Location = new System.Drawing.Point(691, 475);
            this.btnMyPage.Name = "btnMyPage";
            this.btnMyPage.Size = new System.Drawing.Size(135, 45);
            this.btnMyPage.TabIndex = 14;
            this.btnMyPage.Text = "Min sida";
            this.btnMyPage.UseVisualStyleBackColor = true;
            this.btnMyPage.Click += new System.EventHandler(this.btnMyPage_Click);
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 559);
            this.Controls.Add(this.btnMyPage);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.btnPren);
            this.Controls.Add(this.lblEpisode);
            this.Controls.Add(this.lstBoxEpisode);
            this.Name = "Presentation";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstBoxEpisode;
        private System.Windows.Forms.Label lblEpisode;
        private System.Windows.Forms.Button btnPren;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnMyPage;
    }
}

