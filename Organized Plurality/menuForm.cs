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

        void funcDeselectItem()
        {
            listMenu.SelectedItems[0].Selected = false;
        }

        private void listMenu_ItemActivate(object sender, EventArgs e)
        {
            if (listMenu.SelectedItems[0].Index == 0)
            {
                var notesFormAction = Application.OpenForms.OfType<notesForm>();

                if (notesFormAction.Any())
                {
                    if (notesFormAction.First().WindowState == FormWindowState.Minimized)
                    {
                        notesFormAction.First().WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        notesFormAction.First().Focus();
                        funcDeselectItem();
                    }
                }
                else
                {
                    notesForm notesForm = new notesForm();
                    notesForm.Show();
                    funcDeselectItem();
                }
            }
            else if (listMenu.SelectedItems[0].Index == 1)
            {
                MessageBox.Show("Coming soon!", "Discord RPC");
                funcDeselectItem();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsFormAction = Application.OpenForms.OfType<settingsForm>();

            if (settingsFormAction.Any())
            {
                if (settingsFormAction.First().WindowState == FormWindowState.Minimized)
                {
                    settingsFormAction.First().WindowState = FormWindowState.Normal;
                }
                else
                {
                    settingsFormAction.First().Focus();
                }
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
