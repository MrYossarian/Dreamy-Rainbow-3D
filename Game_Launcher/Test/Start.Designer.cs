namespace Test
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblGamemode = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnMultiplayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.Location = new System.Drawing.Point(79, 144);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(97, 23);
            this.btnSinglePlayer.TabIndex = 0;
            this.btnSinglePlayer.Text = "&Single Player";
            this.btnSinglePlayer.UseVisualStyleBackColor = true;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            this.btnSinglePlayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConfirmSnd);
            this.btnSinglePlayer.MouseHover += new System.EventHandler(this.CursorSnd);
            // 
            // picLogo
            // 
            this.picLogo.Enabled = false;
            this.picLogo.Image = global::Test.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(43, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(159, 94);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblGamemode
            // 
            this.lblGamemode.AutoSize = true;
            this.lblGamemode.Location = new System.Drawing.Point(71, 119);
            this.lblGamemode.Name = "lblGamemode";
            this.lblGamemode.Size = new System.Drawing.Size(113, 13);
            this.lblGamemode.TabIndex = 2;
            this.lblGamemode.Text = "Choose a game mode:";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(12, 239);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(148, 13);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "© Gamejolt MrYossarian 2017";
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.Enabled = false;
            this.btnMultiplayer.Location = new System.Drawing.Point(80, 185);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(96, 23);
            this.btnMultiplayer.TabIndex = 4;
            this.btnMultiplayer.Text = "&Multiplayer";
            this.btnMultiplayer.UseVisualStyleBackColor = true;
            this.btnMultiplayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConfirmSnd);
            this.btnMultiplayer.MouseHover += new System.EventHandler(this.CursorSnd);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 261);
            this.Controls.Add(this.btnMultiplayer);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblGamemode);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnSinglePlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dreamy Rainbow 3D - Launcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Application_Close);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblGamemode;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button btnMultiplayer;
    }
}

