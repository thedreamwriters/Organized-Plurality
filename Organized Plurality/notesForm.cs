using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Organized_Plurality
{
    public partial class notesForm : Form
    {
        string datapath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Organized Plurality\";
        public notesForm()
        {
            InitializeComponent();
        }

        private void notesForm_Load(object sender, EventArgs e)
        {
            funcLoadNotes();
            listNotesMenu.BackColor = Control.DefaultBackColor;
            
        }
        void funcLoadNotes()
        {
            DirectoryInfo directory = new DirectoryInfo(datapath);

            foreach (var file in directory.GetFiles("*.op"))
            {
                listNotesMenu.Items.Add(Path.GetFileNameWithoutExtension(datapath + file.Name));
            }
        }

        void funcCreateNote()
        {
            var NewNote = datapath + txtFronter.Text + " - " + txtTitle.Text + ".op";

            if (!(File.Exists(NewNote)))
            {
                designerForm.Visible = false;
                File.AppendAllLines(NewNote, txtNoteContent.Lines);
                listNotesMenu.Items.Add(Path.GetFileNameWithoutExtension(NewNote));
                designerForm.Visible = false;
            }
        }

        void funcRemoveNote()
        {
            if (listNotesMenu.SelectedItems.Count != 0)
            {
                var SelectedNotePath = datapath + listNotesMenu.SelectedItems[0].Text + ".op";

                if ((File.Exists(SelectedNotePath)))
                {
                    DialogResult DeleteConfirmation = MessageBox.Show("You are about to delete " + listNotesMenu.SelectedItems[0].Text + ", would you like to proceed?", "Note removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DeleteConfirmation == DialogResult.Yes)
                    {
                        File.Delete(SelectedNotePath);
                        listNotesMenu.Items.Remove(listNotesMenu.SelectedItems[0]);
                        txtNoteContent.Clear();
                    }
                }
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

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (!(designerForm.Visible))
            {
                designerForm.Visible = true;
            }
        }

        private void btnDesignerClose_Click(object sender, EventArgs e)
        {
            designerForm.Visible = false;
            txtFronter.Clear();
            txtTitle.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            funcCreateNote();
        }

        private void listNotesMenu_ItemActivate(object sender, EventArgs e)
        {
            var SelectedNotePath = datapath + listNotesMenu.SelectedItems[0].Text + ".op";

            if (File.Exists(SelectedNotePath))
            {
                txtNoteContent.Lines = File.ReadAllLines(SelectedNotePath);
            }
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            var SelectedNotePath = datapath + listNotesMenu.SelectedItems[0].Text + ".op";

            File.Delete(SelectedNotePath);
            File.AppendAllLines(datapath + listNotesMenu.SelectedItems[0].Text + ".op", txtNoteContent.Lines);
        }

        private void btnRemoveNote_Click(object sender, EventArgs e)
        {
            funcRemoveNote();
        }

        private void listNotesMenu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
            {
                funcRemoveNote();
            }
        }
    }
}
