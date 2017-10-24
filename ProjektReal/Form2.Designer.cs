namespace ProjektReal
{
    partial class Form2
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
            this.lblCate = new System.Windows.Forms.Label();
            this.lblPod = new System.Windows.Forms.Label();
            this.lblEpisode = new System.Windows.Forms.Label();
            this.lstBoxCate = new System.Windows.Forms.ListBox();
            this.lstBoxPod = new System.Windows.Forms.ListBox();
            this.lstBoxEpisode = new System.Windows.Forms.ListBox();
            this.btnAddCate = new System.Windows.Forms.Button();
            this.btnChangeCate = new System.Windows.Forms.Button();
            this.btnRemoveCate = new System.Windows.Forms.Button();
            this.btnStopPren = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnChangeUpdate = new System.Windows.Forms.Button();
            this.btnChangePodCate = new System.Windows.Forms.Button();
            this.btnShowMore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(72, 65);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(68, 20);
            this.lblCate.TabIndex = 0;
            this.lblCate.Text = "Kategori";
            // 
            // lblPod
            // 
            this.lblPod.AutoSize = true;
            this.lblPod.Location = new System.Drawing.Point(504, 65);
            this.lblPod.Name = "lblPod";
            this.lblPod.Size = new System.Drawing.Size(67, 20);
            this.lblPod.TabIndex = 1;
            this.lblPod.Text = "Podcast";
            // 
            // lblEpisode
            // 
            this.lblEpisode.AutoSize = true;
            this.lblEpisode.Location = new System.Drawing.Point(919, 65);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Size = new System.Drawing.Size(57, 20);
            this.lblEpisode.TabIndex = 2;
            this.lblEpisode.Text = "Avsnitt";
            // 
            // lstBoxCate
            // 
            this.lstBoxCate.FormattingEnabled = true;
            this.lstBoxCate.ItemHeight = 20;
            this.lstBoxCate.Location = new System.Drawing.Point(12, 97);
            this.lstBoxCate.Name = "lstBoxCate";
            this.lstBoxCate.Size = new System.Drawing.Size(348, 244);
            this.lstBoxCate.TabIndex = 3;
            // 
            // lstBoxPod
            // 
            this.lstBoxPod.FormattingEnabled = true;
            this.lstBoxPod.ItemHeight = 20;
            this.lstBoxPod.Location = new System.Drawing.Point(435, 97);
            this.lstBoxPod.Name = "lstBoxPod";
            this.lstBoxPod.Size = new System.Drawing.Size(421, 244);
            this.lstBoxPod.TabIndex = 4;
            // 
            // lstBoxEpisode
            // 
            this.lstBoxEpisode.FormattingEnabled = true;
            this.lstBoxEpisode.ItemHeight = 20;
            this.lstBoxEpisode.Location = new System.Drawing.Point(905, 97);
            this.lstBoxEpisode.Name = "lstBoxEpisode";
            this.lstBoxEpisode.Size = new System.Drawing.Size(364, 244);
            this.lstBoxEpisode.TabIndex = 5;
            // 
            // btnAddCate
            // 
            this.btnAddCate.Location = new System.Drawing.Point(29, 361);
            this.btnAddCate.Name = "btnAddCate";
            this.btnAddCate.Size = new System.Drawing.Size(86, 39);
            this.btnAddCate.TabIndex = 6;
            this.btnAddCate.Text = "Lägg till";
            this.btnAddCate.UseVisualStyleBackColor = true;
            // 
            // btnChangeCate
            // 
            this.btnChangeCate.Location = new System.Drawing.Point(136, 361);
            this.btnChangeCate.Name = "btnChangeCate";
            this.btnChangeCate.Size = new System.Drawing.Size(88, 39);
            this.btnChangeCate.TabIndex = 7;
            this.btnChangeCate.Text = "Ändra";
            this.btnChangeCate.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCate
            // 
            this.btnRemoveCate.Location = new System.Drawing.Point(246, 361);
            this.btnRemoveCate.Name = "btnRemoveCate";
            this.btnRemoveCate.Size = new System.Drawing.Size(102, 39);
            this.btnRemoveCate.TabIndex = 8;
            this.btnRemoveCate.Text = "Ta bort";
            this.btnRemoveCate.UseVisualStyleBackColor = true;
            // 
            // btnStopPren
            // 
            this.btnStopPren.Location = new System.Drawing.Point(451, 409);
            this.btnStopPren.Name = "btnStopPren";
            this.btnStopPren.Size = new System.Drawing.Size(176, 42);
            this.btnStopPren.TabIndex = 9;
            this.btnStopPren.Text = "Avsluta prenumeration";
            this.btnStopPren.UseVisualStyleBackColor = true;
            // 
            // btnHomePage
            // 
            this.btnHomePage.Location = new System.Drawing.Point(1034, 510);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(165, 43);
            this.btnHomePage.TabIndex = 10;
            this.btnHomePage.Text = "Startsida";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnChangeUpdate
            // 
            this.btnChangeUpdate.Location = new System.Drawing.Point(538, 358);
            this.btnChangeUpdate.Name = "btnChangeUpdate";
            this.btnChangeUpdate.Size = new System.Drawing.Size(221, 42);
            this.btnChangeUpdate.TabIndex = 11;
            this.btnChangeUpdate.Text = "Ändra uppdateringsintervall";
            this.btnChangeUpdate.UseVisualStyleBackColor = true;
            // 
            // btnChangePodCate
            // 
            this.btnChangePodCate.Location = new System.Drawing.Point(664, 409);
            this.btnChangePodCate.Name = "btnChangePodCate";
            this.btnChangePodCate.Size = new System.Drawing.Size(182, 42);
            this.btnChangePodCate.TabIndex = 12;
            this.btnChangePodCate.Text = "Ändra kategori";
            this.btnChangePodCate.UseVisualStyleBackColor = true;
            // 
            // btnShowMore
            // 
            this.btnShowMore.Location = new System.Drawing.Point(1034, 361);
            this.btnShowMore.Name = "btnShowMore";
            this.btnShowMore.Size = new System.Drawing.Size(116, 42);
            this.btnShowMore.TabIndex = 13;
            this.btnShowMore.Text = "Visa mer";
            this.btnShowMore.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 601);
            this.Controls.Add(this.btnShowMore);
            this.Controls.Add(this.btnChangePodCate);
            this.Controls.Add(this.btnChangeUpdate);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.btnStopPren);
            this.Controls.Add(this.btnRemoveCate);
            this.Controls.Add(this.btnChangeCate);
            this.Controls.Add(this.btnAddCate);
            this.Controls.Add(this.lstBoxEpisode);
            this.Controls.Add(this.lstBoxPod);
            this.Controls.Add(this.lstBoxCate);
            this.Controls.Add(this.lblEpisode);
            this.Controls.Add(this.lblPod);
            this.Controls.Add(this.lblCate);
            this.Name = "Form2";
            this.Text = "Min sida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.Label lblPod;
        private System.Windows.Forms.Label lblEpisode;
        private System.Windows.Forms.ListBox lstBoxCate;
        private System.Windows.Forms.ListBox lstBoxPod;
        private System.Windows.Forms.ListBox lstBoxEpisode;
        private System.Windows.Forms.Button btnAddCate;
        private System.Windows.Forms.Button btnChangeCate;
        private System.Windows.Forms.Button btnRemoveCate;
        private System.Windows.Forms.Button btnStopPren;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnChangeUpdate;
        private System.Windows.Forms.Button btnChangePodCate;
        private System.Windows.Forms.Button btnShowMore;
    }
}