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

        private void btnOpenNotes_Click(object sender, EventArgs e)
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
                }
            }
            else
            {
                notesForm notesForm = new notesForm();
                notesForm.Show();
            }
        }

        private void btnOpenRPC_Click(object sender, EventArgs e)
        {
            var rpcFormAction = Application.OpenForms.OfType<rpcForm>();

            if (rpcFormAction.Any())
            {
                if (rpcFormAction.First().WindowState == FormWindowState.Minimized)
                {
                    rpcFormAction.First().WindowState = FormWindowState.Normal;
                }
                else
                {
                    rpcFormAction.First().Focus();
                }
            }
            else
            {
                rpcForm rpcForm = new rpcForm();
                rpcForm.Show();

            }
        }
    }
}
