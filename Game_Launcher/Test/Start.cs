using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Test
{
    public partial class Start : Form
    {
        #region Initializer
        public Start()
        {
            InitializeComponent();
        }
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

        private void Application_Close(object sender, FormClosedEventArgs e)
        {
            GE.Application_Close();
        }
        #endregion

        #region Events
        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            VideoMode formtoshow = new VideoMode();
            Hide();
            formtoshow.Show();
        }
        #endregion
    }
}
