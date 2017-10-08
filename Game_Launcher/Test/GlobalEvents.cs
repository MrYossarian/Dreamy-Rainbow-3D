using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Test
{
    class GlobalEvents
    {
        #region Functions
        /// <summary>
        /// Author: MrYossarian
        /// Description: Code that will play the cursor sound.
        /// Date: 01/25/17
        /// </summary>
        public void PlaySound_Cursor()
        {
            Stream str = Properties.Resources.RSelect;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
        }

        /// <summary>
        /// Author: MrYossarian
        /// Description: Code that will play the confirm sound.
        /// Date: 01/25/17
        /// </summary>
        public void PlaySound_Confirm()
        {
            Stream str = Properties.Resources.HTCancel;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
        }

        /// <summary>
        /// Author: MrYossarian
        /// Description: Code that will play the cancel sound.
        /// Date: 01/25/17
        /// </summary>
        public void PlaySound_Cancel()
        {
            Stream str = Properties.Resources.MOCancel;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
        }

        /// <summary>
        /// Author: MrYossarian
        /// Description: Code that will play the browse sound.
        /// Date: 01/25/17
        /// </summary>
        public void PlaySound_Browse()
        {
            Stream str = Properties.Resources.WMBrowse;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
        }

        /// <summary>
        /// Author: MrYossarian
        /// Description: Code that closes the application (Usually for other forms).
        /// Date: 01/25/17
        /// </summary>
        public void Application_Close()
        {
            Application.Exit();
        }
        #endregion
    }
}
