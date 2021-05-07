
namespace Organized_Plurality
{
    partial class menuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Plural Notes"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.animForm = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.imagelist = new System.Windows.Forms.ImageList(this.components);
            this.listMenu = new System.Windows.Forms.ListView();
            this.dragForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlCtrlBox = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnSettings = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.pnlCtrlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // animForm
            // 
            this.animForm.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.animForm.TargetForm = this;
            // 
            // imagelist
            // 
            this.imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelist.ImageStream")));
            this.imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelist.Images.SetKeyName(0, "notes-icon.png");
            // 
            // listMenu
            // 
            this.listMenu.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listMenu.BackColor = System.Drawing.SystemColors.Control;
            this.listMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.listMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMenu.HideSelection = false;
            this.listMenu.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listMenu.LargeImageList = this.imagelist;
            this.listMenu.Location = new System.Drawing.Point(0, 73);
            this.listMenu.MultiSelect = false;
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(555, 433);
            this.listMenu.TabIndex = 0;
            this.listMenu.UseCompatibleStateImageBehavior = false;
            this.listMenu.ItemActivate += new System.EventHandler(this.listMenu_ItemActivate);
            // 
            // dragForm
            // 
            this.dragForm.ContainerControl = this;
            this.dragForm.DragStartTransparencyValue = 0.6D;
            this.dragForm.TargetControl = this.pnlCtrlBox;
            this.dragForm.TransparentWhileDrag = true;
            this.dragForm.UseTransparentDrag = true;
            // 
            // pnlCtrlBox
            // 
            this.pnlCtrlBox.BackColor = System.Drawing.Color.Transparent;
            this.pnlCtrlBox.Controls.Add(this.btnSettings);
            this.pnlCtrlBox.Controls.Add(this.btnMin);
            this.pnlCtrlBox.Controls.Add(this.btnClose);
            this.pnlCtrlBox.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Organized_Plurality.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnlCtrlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCtrlBox.FillColor = global::Organized_Plurality.Properties.Settings.Default.MainColor;
            this.pnlCtrlBox.Location = new System.Drawing.Point(0, 0);
            this.pnlCtrlBox.Name = "pnlCtrlBox";
            this.pnlCtrlBox.ShadowColor = System.Drawing.Color.Black;
            this.pnlCtrlBox.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlCtrlBox.Size = new System.Drawing.Size(555, 73);
            this.pnlCtrlBox.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Animated = true;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Organized_Plurality.Properties.Settings.Default, "SecondaryColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSettings.FillColor = global::Organized_Plurality.Properties.Settings.Default.SecondaryColor;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::Organized_Plurality.Properties.Resources.settings_icon;
            this.btnSettings.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSettings.Location = new System.Drawing.Point(12, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(41, 38);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnMin
            // 
            this.btnMin.Animated = true;
            this.btnMin.CheckedState.Parent = this.btnMin;
            this.btnMin.CustomImages.Parent = this.btnMin;
            this.btnMin.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Organized_Plurality.Properties.Settings.Default, "SecondaryColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnMin.FillColor = global::Organized_Plurality.Properties.Settings.Default.SecondaryColor;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.HoverState.Parent = this.btnMin;
            this.btnMin.Location = new System.Drawing.Point(455, 12);
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
            this.btnClose.Animated = true;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(502, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(41, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2NotificationPaint1
            // 
            this.guna2NotificationPaint1.TargetControl = this;
            this.guna2NotificationPaint1.Text = "hello";
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 506);
            this.Controls.Add(this.listMenu);
            this.Controls.Add(this.pnlCtrlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlCtrlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow animForm;
        private System.Windows.Forms.ImageList imagelist;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlCtrlBox;
        private System.Windows.Forms.ListView listMenu;
        private Guna.UI2.WinForms.Guna2DragControl dragForm;
        private Guna.UI2.WinForms.Guna2CircleButton btnMin;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2CircleButton btnSettings;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
    }
}

