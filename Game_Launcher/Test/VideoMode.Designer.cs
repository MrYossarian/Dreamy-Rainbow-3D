namespace Test
{
    partial class VideoMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoMode));
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.optWindowed = new System.Windows.Forms.RadioButton();
            this.optFullscreen = new System.Windows.Forms.RadioButton();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.grpTranslated = new System.Windows.Forms.GroupBox();
            this.lblTranslator = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.grpMode.SuspendLayout();
            this.grpTranslated.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.optWindowed);
            this.grpMode.Controls.Add(this.optFullscreen);
            this.grpMode.Location = new System.Drawing.Point(13, 41);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(223, 73);
            this.grpMode.TabIndex = 0;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Video Mode";
            // 
            // optWindowed
            // 
            this.optWindowed.AutoSize = true;
            this.optWindowed.Location = new System.Drawing.Point(7, 44);
            this.optWindowed.Name = "optWindowed";
            this.optWindowed.Size = new System.Drawing.Size(76, 17);
            this.optWindowed.TabIndex = 1;
            this.optWindowed.Text = "Windowed";
            this.optWindowed.UseVisualStyleBackColor = true;
            this.optWindowed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BrowseSnd);
            this.optWindowed.MouseHover += new System.EventHandler(this.CursorSnd);
            // 
            // optFullscreen
            // 
            this.optFullscreen.AutoSize = true;
            this.optFullscreen.Checked = true;
            this.optFullscreen.Location = new System.Drawing.Point(7, 20);
            this.optFullscreen.Name = "optFullscreen";
            this.optFullscreen.Size = new System.Drawing.Size(73, 17);
            this.optFullscreen.TabIndex = 0;
            this.optFullscreen.TabStop = true;
            this.optFullscreen.Text = "Fullscreen";
            this.optFullscreen.UseVisualStyleBackColor = true;
            this.optFullscreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BrowseSnd);
            this.optFullscreen.MouseHover += new System.EventHandler(this.CursorSnd);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.Location = new System.Drawing.Point(13, 177);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(223, 37);
            this.btnLaunch.TabIndex = 1;
            this.btnLaunch.Text = "&Launch!";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            this.btnLaunch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConfirmSnd);
            this.btnLaunch.MouseHover += new System.EventHandler(this.CursorSnd);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CancelSnd);
            this.btnBack.MouseHover += new System.EventHandler(this.CursorSnd);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(10, 133);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(58, 13);
            this.lblLanguage.TabIndex = 4;
            this.lblLanguage.Text = "Language:";
            // 
            // grpTranslated
            // 
            this.grpTranslated.Controls.Add(this.lblTranslator);
            this.grpTranslated.Location = new System.Drawing.Point(140, 134);
            this.grpTranslated.Name = "grpTranslated";
            this.grpTranslated.Size = new System.Drawing.Size(96, 37);
            this.grpTranslated.TabIndex = 5;
            this.grpTranslated.TabStop = false;
            this.grpTranslated.Text = "Translated by:";
            this.grpTranslated.Visible = false;
            // 
            // lblTranslator
            // 
            this.lblTranslator.AutoSize = true;
            this.lblTranslator.Location = new System.Drawing.Point(6, 19);
            this.lblTranslator.Name = "lblTranslator";
            this.lblTranslator.Size = new System.Drawing.Size(54, 13);
            this.lblTranslator.TabIndex = 0;
            this.lblTranslator.Text = "Translator";
            this.lblTranslator.Visible = false;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "English",
            "Русский",
            "Polskie",
            "Deutsch",
            "Français",
            "Español"});
            this.cmbLanguage.Location = new System.Drawing.Point(13, 149);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(121, 21);
            this.cmbLanguage.TabIndex = 7;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            this.cmbLanguage.MouseHover += new System.EventHandler(this.CursorSnd);
            // 
            // VideoMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 226);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.grpTranslated);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.grpMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dreamy Rainbow 3D - Launcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Application_Close);
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.grpTranslated.ResumeLayout(false);
            this.grpTranslated.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.RadioButton optWindowed;
        private System.Windows.Forms.RadioButton optFullscreen;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.GroupBox grpTranslated;
        private System.Windows.Forms.Label lblTranslator;
        private System.Windows.Forms.ComboBox cmbLanguage;
    }
}