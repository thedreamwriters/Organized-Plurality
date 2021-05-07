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
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void listMenu_ItemActivate(object sender, EventArgs e)
        {
            if (listMenu.SelectedItems[0].Index == 0)
            {
                var notesFormAction = Application.OpenForms.OfType<notesForm>();

                if (notesFormAction.Any())
                {
                    notesFormAction.First().Focus();
                    listMenu.SelectedItems.Clear();
                }
                else
                {
                    notesForm notesForm = new notesForm();
                    notesForm.Show();
                    listMenu.SelectedItems.Clear();
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsFormAction = Application.OpenForms.OfType<settingsForm>();

            if (settingsFormAction.Any())
            {
                settingsFormAction.First().Focus();
            }
            else
            {
                settingsForm settingsForm = new settingsForm();
                settingsForm.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
