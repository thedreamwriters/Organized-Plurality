
namespace Organized_Plurality
{
    partial class notesForm
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
            this.components = new System.ComponentModel.Container();
            this.animForm = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.txtNoteContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.designerForm = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFronter = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFronter = new System.Windows.Forms.Label();
            this.pnlCtrlBoxDesigner = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnDesignerClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlCtrlBox = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnAddNote = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.listNotesMenu = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSaveNote = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnRemoveNote = new Guna.UI2.WinForms.Guna2CircleButton();
            this.designerForm.SuspendLayout();
            this.pnlCtrlBoxDesigner.SuspendLayout();
            this.pnlCtrlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // animForm
            // 
            this.animForm.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.animForm.TargetForm = this;
            // 
            // txtNoteContent
            // 
            this.txtNoteContent.Animated = true;
            this.txtNoteContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoteContent.DefaultText = "";
            this.txtNoteContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoteContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoteContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoteContent.DisabledState.Parent = this.txtNoteContent;
            this.txtNoteContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoteContent.FillColor = System.Drawing.SystemColors.Control;
            this.txtNoteContent.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtNoteContent.FocusedState.Parent = this.txtNoteContent;
            this.txtNoteContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteContent.HideSelection = false;
            this.txtNoteContent.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtNoteContent.HoverState.Parent = this.txtNoteContent;
            this.txtNoteContent.Location = new System.Drawing.Point(0, 73);
            this.txtNoteContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoteContent.Multiline = true;
            this.txtNoteContent.Name = "txtNoteContent";
            this.txtNoteContent.PasswordChar = '\0';
            this.txtNoteContent.PlaceholderText = "";
            this.txtNoteContent.SelectedText = "";
            this.txtNoteContent.ShadowDecoration.Parent = this.txtNoteContent;
            this.txtNoteContent.Size = new System.Drawing.Size(546, 460);
            this.txtNoteContent.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNoteContent.TabIndex = 0;
            // 
            // designerForm
            // 
            this.designerForm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.designerForm.BorderColor = System.Drawing.Color.Black;
            this.designerForm.BorderThickness = 1;
            this.designerForm.Controls.Add(this.btnSubmit);
            this.designerForm.Controls.Add(this.txtTitle);
            this.designerForm.Controls.Add(this.lblTitle);
            this.designerForm.Controls.Add(this.txtFronter);
            this.designerForm.Controls.Add(this.lblFronter);
            this.designerForm.Controls.Add(this.pnlCtrlBoxDesigner);
            this.designerForm.Location = new System.Drawing.Point(236, 102);
            this.designerForm.Name = "designerForm";
            this.designerForm.ShadowDecoration.Parent = this.designerForm;
            this.designerForm.Size = new System.Drawing.Size(227, 328);
            this.designerForm.TabIndex = 4;
            this.designerForm.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Animated = true;
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Organized_Plurality.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSubmit.FillColor = global::Organized_Plurality.Properties.Settings.Default.MainColor;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(46, 265);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(135, 45);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Create note";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Animated = true;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.Parent = this.txtTitle;
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.FocusedState.Parent = this.txtTitle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.HoverState.Parent = this.txtTitle;
            this.txtTitle.Location = new System.Drawing.Point(33, 211);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            this.txtTitle.ShadowDecoration.Parent = this.txtTitle;
            this.txtTitle.Size = new System.Drawing.Size(161, 36);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(68, 176);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Note title";
            // 
            // txtFronter
            // 
            this.txtFronter.Animated = true;
            this.txtFronter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFronter.DefaultText = "";
            this.txtFronter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFronter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFronter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFronter.DisabledState.Parent = this.txtFronter;
            this.txtFronter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFronter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFronter.FocusedState.Parent = this.txtFronter;
            this.txtFronter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFronter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFronter.HoverState.Parent = this.txtFronter;
            this.txtFronter.Location = new System.Drawing.Point(33, 123);
            this.txtFronter.Name = "txtFronter";
            this.txtFronter.PasswordChar = '\0';
            this.txtFronter.PlaceholderText = "";
            this.txtFronter.SelectedText = "";
            this.txtFronter.ShadowDecoration.Parent = this.txtFronter;
            this.txtFronter.Size = new System.Drawing.Size(161, 36);
            this.txtFronter.TabIndex = 3;
            this.txtFronter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFronter
            // 
            this.lblFronter.AutoSize = true;
            this.lblFronter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFronter.Location = new System.Drawing.Point(67, 88);
            this.lblFronter.Name = "lblFronter";
            this.lblFronter.Size = new System.Drawing.Size(93, 25);
            this.lblFronter.TabIndex = 2;
            this.lblFronter.Text = "Fronter(s)";
            // 
            // pnlCtrlBoxDesigner
            // 
            this.pnlCtrlBoxDesigner.BackColor = System.Drawing.Color.Transparent;
            this.pnlCtrlBoxDesigner.Controls.Add(this.btnDesignerClose);
            this.pnlCtrlBoxDesigner.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Organized_Plurality.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnlCtrlBoxDesigner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCtrlBoxDesigner.FillColor = global::Organized_Plurality.Properties.Settings.Default.MainColor;
            this.pnlCtrlBoxDesigner.Location = new System.Drawing.Point(0, 0);
            this.pnlCtrlBoxDesigner.Name = "pnlCtrlBoxDesigner";
            this.pnlCtrlBoxDesigner.ShadowColor = System.Drawing.Color.Black;
            this.pnlCtrlBoxDesigner.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlCtrlBoxDesigner.Size = new System.Drawing.Size(227, 73);
            this.pnlCtrlBoxDesigner.TabIndex = 2;
            // 
            // btnDesignerClose
            // 
            this.btnDesignerClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDesignerClose.Animated = true;
            this.btnDesignerClose.CheckedState.Parent = this.btnDesignerClose;
            this.btnDesignerClose.CustomImages.Parent = this.btnDesignerClose;
            this.btnDesignerClose.FillColor = System.Drawing.Color.IndianRed;
            this.btnDesignerClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesignerClose.ForeColor = System.Drawing.Color.White;
            this.btnDesignerClose.HoverState.Parent = this.btnDesignerClose;
            this.btnDesignerClose.Location = new System.Drawing.Point(174, 12);
            this.btnDesignerClose.Name = "btnDesignerClose";
            this.btnDesignerClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDesignerClose.ShadowDecoration.Parent = this.btnDesignerClose;
            this.btnDesignerClose.Size = new System.Drawing.Size(41, 38);
            this.btnDesignerClose.TabIndex = 1;
            this.btnDesignerClose.Text = "X";
            this.btnDesignerClose.Click += new System.EventHandler(this.btnDesignerClose_Click);
            // 
            // pnlCtrlBox
            // 
            this.pnlCtrlBox.BackColor = System.Drawing.Color.Transparent;
            this.pnlCtrlBox.Controls.Add(this.btnRemoveNote);
            this.pnlCtrlBox.Controls.Add(this.btnSaveNote);
            this.pnlCtrlBox.Controls.Add(this.btnAddNote);
            this.pnlCtrlBox.Controls.Add(this.btnMin);
            this.pnlCtrlBox.Controls.Add(this.btnClose);
            this.pnlCtrlBox.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Organized_Plurality.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnlCtrlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCtrlBox.FillColor = global::Organized_Plurality.Properties.Settings.Default.MainColor;
            this.pnlCtrlBox.Location = new System.Drawing.Point(0, 0);
            this.pnlCtrlBox.Name = "pnlCtrlBox";
            this.pnlCtrlBox.ShadowColor = System.Drawing.Color.Black;
            this.pnlCtrlBox.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlCtrlBox.Size = new System.Drawing.Size(699, 73);
            this.pnlCtrlBox.TabIndex = 1;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNote.Animated = true;
            this.btnAddNote.CheckedState.Parent = this.btnAddNote;
            this.btnAddNote.CustomImages.Parent = this.btnAddNote;
            this.btnAddNote.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Organized_Plurality.Properties.Settings.Default, "SecondaryColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddNote.FillColor = global::Organized_Plurality.Properties.Settings.Default.SecondaryColor;
            this.btnAddNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNote.ForeColor = System.Drawing.Color.White;
            this.btnAddNote.HoverState.Parent = this.btnAddNote;
            this.btnAddNote.Location = new System.Drawing.Point(12, 12);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddNote.ShadowDecoration.Parent = this.btnAddNote;
            this.btnAddNote.Size = new System.Drawing.Size(41, 38);
            this.btnAddNote.TabIndex = 3;
            this.btnAddNote.Text = "+";
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMin.Animated = true;
            this.btnMin.CheckedState.Parent = this.btnMin;
            this.btnMin.CustomImages.Parent = this.btnMin;
            this.btnMin.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Organized_Plurality.Properties.Settings.Default, "SecondaryColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnMin.FillColor = global::Organized_Plurality.Properties.Settings.Default.SecondaryColor;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.HoverState.Parent = this.btnMin;
            this.btnMin.Location = new System.Drawing.Point(599, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMin.ShadowDecoration.Parent = this.btnMin;
            this.btnMin.Size = new System.Drawing.Size(41, 38);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "-";
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Animated = true;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(646, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(41, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listNotesMenu
            // 
            this.listNotesMenu.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listNotesMenu.AutoSizeTable = false;
            this.listNotesMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listNotesMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listNotesMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listNotesMenu.Depth = 0;
            this.listNotesMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.listNotesMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNotesMenu.FullRowSelect = true;
            this.listNotesMenu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listNotesMenu.HideSelection = false;
            this.listNotesMenu.Location = new System.Drawing.Point(553, 73);
            this.listNotesMenu.MinimumSize = new System.Drawing.Size(50, 100);
            this.listNotesMenu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listNotesMenu.MouseState = MaterialSkin.MouseState.OUT;
            this.listNotesMenu.MultiSelect = false;
            this.listNotesMenu.Name = "listNotesMenu";
            this.listNotesMenu.OwnerDraw = true;
            this.listNotesMenu.ShowGroups = false;
            this.listNotesMenu.Size = new System.Drawing.Size(146, 460);
            this.listNotesMenu.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listNotesMenu.TabIndex = 5;
            this.listNotesMenu.UseCompatibleStateImageBehavior = false;
            this.listNotesMenu.View = System.Windows.Forms.View.Details;
            this.listNotesMenu.ItemActivate += new System.EventHandler(this.listNotesMenu_ItemActivate);
            this.listNotesMenu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listNotesMenu_KeyUp);
            // 
            // columnHeader2
            // 
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveNote.Animated = true;
            this.btnSaveNote.CheckedState.Parent = this.btnSaveNote;
            this.btnSaveNote.CustomImages.Parent = this.btnSaveNote;
            this.btnSaveNote.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Organized_Plurality.Properties.Settings.Default, "SecondaryColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSaveNote.FillColor = global::Organized_Plurality.Properties.Settings.Default.SecondaryColor;
            this.btnSaveNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNote.ForeColor = System.Drawing.Color.White;
            this.btnSaveNote.HoverState.Parent = this.btnSaveNote;
            this.btnSaveNote.Location = new System.Drawing.Point(106, 12);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSaveNote.ShadowDecoration.Parent = this.btnSaveNote;
            this.btnSaveNote.Size = new System.Drawing.Size(41, 38);
            this.btnSaveNote.TabIndex = 4;
            this.btnSaveNote.Text = "💾";
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // btnRemoveNote
            // 
            this.btnRemoveNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemoveNote.Animated = true;
            this.btnRemoveNote.CheckedState.Parent = this.btnRemoveNote;
            this.btnRemoveNote.CustomImages.Parent = this.btnRemoveNote;
            this.btnRemoveNote.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Organized_Plurality.Properties.Settings.Default, "SecondaryColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnRemoveNote.FillColor = global::Organized_Plurality.Properties.Settings.Default.SecondaryColor;
            this.btnRemoveNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNote.ForeColor = System.Drawing.Color.White;
            this.btnRemoveNote.HoverState.Parent = this.btnRemoveNote;
            this.btnRemoveNote.Location = new System.Drawing.Point(59, 12);
            this.btnRemoveNote.Name = "btnRemoveNote";
            this.btnRemoveNote.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRemoveNote.ShadowDecoration.Parent = this.btnRemoveNote;
            this.btnRemoveNote.Size = new System.Drawing.Size(41, 38);
            this.btnRemoveNote.TabIndex = 5;
            this.btnRemoveNote.Text = "-";
            this.btnRemoveNote.Click += new System.EventHandler(this.btnRemoveNote_Click);
            // 
            // notesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 533);
            this.Controls.Add(this.listNotesMenu);
            this.Controls.Add(this.designerForm);
            this.Controls.Add(this.txtNoteContent);
            this.Controls.Add(this.pnlCtrlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "notesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "notesForm";
            this.Load += new System.EventHandler(this.notesForm_Load);
            this.designerForm.ResumeLayout(false);
            this.designerForm.PerformLayout();
            this.pnlCtrlBoxDesigner.ResumeLayout(false);
            this.pnlCtrlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow animForm;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlCtrlBox;
        private Guna.UI2.WinForms.Guna2CircleButton btnMin;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtNoteContent;
        private Guna.UI2.WinForms.Guna2Panel designerForm;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlCtrlBoxDesigner;
        private Guna.UI2.WinForms.Guna2CircleButton btnDesignerClose;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddNote;
        private System.Windows.Forms.Label lblFronter;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtFronter;
        private MaterialSkin.Controls.MaterialListView listNotesMenu;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Guna.UI2.WinForms.Guna2CircleButton btnSaveNote;
        private Guna.UI2.WinForms.Guna2CircleButton btnRemoveNote;
    }
}