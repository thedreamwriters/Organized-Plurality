using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organized_Plurality
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void picColorSelector_Click(object sender, EventArgs e)
        {
            Cyotek.Windows.Forms.ColorPickerDialog ColorPicker = new Cyotek.Windows.Forms.ColorPickerDialog();

            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                Organized_Plurality.Properties.Settings.Default.MainColor = ColorPicker.Color;
                Organized_Plurality.Properties.Settings.Default.Save();
            }

        }

        private void picSeconColorSelector_Click(object sender, EventArgs e)
        {
            Cyotek.Windows.Forms.ColorPickerDialog SecondColorPicker = new Cyotek.Windows.Forms.ColorPickerDialog();

            if (SecondColorPicker.ShowDialog() == DialogResult.OK)
            {
                Organized_Plurality.Properties.Settings.Default.SecondaryColor = SecondColorPicker.Color;
                Organized_Plurality.Properties.Settings.Default.Save();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            // Running this in the following way to not reset other settings
            Organized_Plurality.Properties.Settings.Default.MainColor = Color.RoyalBlue;
            Organized_Plurality.Properties.Settings.Default.SecondaryColor = Color.FromArgb(94, 148, 255);
            Organized_Plurality.Properties.Settings.Default.Save();
        }
    }
}
