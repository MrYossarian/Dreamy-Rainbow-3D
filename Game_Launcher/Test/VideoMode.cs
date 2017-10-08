using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Media;

namespace Test
{
    public partial class VideoMode : Form
    {
        #region Initializer
        public VideoMode()
        {
            InitializeComponent();
            cmbLanguage.SelectedIndex = 0;
        }
        #endregion

        #region Enumerations
        public enum LANGUAGE
        {
            ENGLISH,
            RUSSIAN,
            POLISH,
            GERMAN,
            FRENCH,
            SPANISH
        }
        #endregion

        #region Constants
        const string GZDOOM = "Game/gzdoom.exe";
        #endregion

        #region Global Variables
        string _sArgs = "";
        #endregion

        #region Global Events
        GlobalEvents GE = new GlobalEvents();
        #endregion

        #region Functions
        private void CursorSnd(object sender, EventArgs e)
        {
            GE.PlaySound_Cursor();
        }

        private void ConfirmSnd(object sender, MouseEventArgs e)
        {
            GE.PlaySound_Confirm();
        }

        private void CancelSnd(object sender, MouseEventArgs e)
        {
            GE.PlaySound_Cancel();
        }

        private void BrowseSnd(object sender, MouseEventArgs e)
        {
            GE.PlaySound_Browse();
        }

        private void LaunchGame(string Args)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(GZDOOM);
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = Args;

            Process.Start(startInfo);
        }

        private void Application_Close(object sender, FormClosedEventArgs e)
        {
            GE.Application_Close();
        }
        #endregion

        #region Events
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            string[] asLanguages = { "eng", "rus", "plk", "de", "fr", "esn" };
            if (File.Exists(GZDOOM))
            {
                if (optFullscreen.Checked)
                    _sArgs = "-file Game/data.pk3 Game/patches/*.pk3 Game/patches/" + asLanguages[cmbLanguage.SelectedIndex].ToUpper() + "/*.pk3 +language " + asLanguages[cmbLanguage.SelectedIndex] + " -config Game/config.ini +fullscreen 1";
                else
                    _sArgs = "-file Game/data.pk3 Game/patches/*.pk3 Game/patches/" + asLanguages[cmbLanguage.SelectedIndex].ToUpper() + "/*.pk3 +language " + asLanguages[cmbLanguage.SelectedIndex] + " -config Game/config.ini +fullscreen 0";
                LaunchGame(_sArgs);
            }
            else
            {
                MessageBox.Show(GZDOOM + " hasn't been found!\nMake sure that you've placed \"gzdoom.exe\" inside the \"Game\" folder.\nMake sure that the \"Game\" folder is in" +
                    " the same location as this launcher.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] asTranslators = { "None", "ZEkA10000", "PLukol", "Akur", "MrYossarian", "Christian69229" };

            switch (cmbLanguage.SelectedIndex)
            {
                case (int)LANGUAGE.ENGLISH:
                    grpTranslated.Visible = false;
                    lblTranslator.Visible = false;
                    break;
                default:
                    grpTranslated.Visible = true;
                    lblTranslator.Visible = true;
                    lblTranslator.Text = asTranslators[cmbLanguage.SelectedIndex];
                    break;
            }

            GE.PlaySound_Browse();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Start formtoshow = new Start();
            Hide();
            formtoshow.Show();
        }
        #endregion
    }
}
