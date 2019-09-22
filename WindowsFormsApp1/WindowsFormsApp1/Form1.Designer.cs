namespace WindowsFormsApp1
{
    partial class GameWindow
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
            this.health = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Location = new System.Drawing.Point(662, 38);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(35, 13);
            this.health.TabIndex = 1;
            this.health.Text = "label1";
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Location = new System.Drawing.Point(197, 38);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(35, 13);
            this.scorelabel.TabIndex = 2;
            this.scorelabel.Text = "label1";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(754, 426);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.health);
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label health;
        private System.Windows.Forms.Label scorelabel;
    }
}

