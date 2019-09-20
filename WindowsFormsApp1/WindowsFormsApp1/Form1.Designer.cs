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
            this.PlayerSprite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerSprite
            // 
            this.PlayerSprite.BackColor = System.Drawing.Color.Transparent;
            this.PlayerSprite.Image = global::WindowsFormsApp1.Properties.Resources._14397211_10154494910549383_438704762_n;
            this.PlayerSprite.Location = new System.Drawing.Point(0, 0);
            this.PlayerSprite.Name = "PlayerSprite";
            this.PlayerSprite.Size = new System.Drawing.Size(73, 120);
            this.PlayerSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerSprite.TabIndex = 0;
            this.PlayerSprite.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(754, 426);
            this.Controls.Add(this.PlayerSprite);
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSprite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PlayerSprite;
    }
}

