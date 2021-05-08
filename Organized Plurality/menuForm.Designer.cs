
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
            this.animForm = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.imagelist = new System.Windows.Forms.ImageList(this.components);
            this.dragForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlCtrlBox = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnSettings = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenRPC = new Guna.UI2.WinForms.Guna2Button();
            this.btnOpenNotes = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCtrlBox.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.imagelist.Images.SetKeyName(1, "rpc-icon.png");
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
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpenRPC);
            this.panel1.Controls.Add(this.btnOpenNotes);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 405);
            this.panel1.TabIndex = 8;
            // 
            // btnOpenRPC
            // 
            this.btnOpenRPC.Animated = true;
            this.btnOpenRPC.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenRPC.CheckedState.Parent = this.btnOpenRPC;
            this.btnOpenRPC.CustomImages.Parent = this.btnOpenRPC;
            this.btnOpenRPC.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnOpenRPC.ForeColor = System.Drawing.Color.White;
            this.btnOpenRPC.HoverState.Parent = this.btnOpenRPC;
            this.btnOpenRPC.Image = global::Organized_Plurality.Properties.Resources.rich_presence_picture;
            this.btnOpenRPC.ImageSize = new System.Drawing.Size(700, 250);
            this.btnOpenRPC.Location = new System.Drawing.Point(0, 206);
            this.btnOpenRPC.Name = "btnOpenRPC";
            this.btnOpenRPC.ShadowDecoration.Parent = this.btnOpenRPC;
            this.btnOpenRPC.Size = new System.Drawing.Size(555, 197);
            this.btnOpenRPC.TabIndex = 1;
            this.btnOpenRPC.TextFormatNoPrefix = true;
            this.btnOpenRPC.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnOpenRPC.Click += new System.EventHandler(this.btnOpenRPC_Click);
            // 
            // btnOpenNotes
            // 
            this.btnOpenNotes.Animated = true;
            this.btnOpenNotes.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenNotes.CheckedState.Parent = this.btnOpenNotes;
            this.btnOpenNotes.CustomImages.Parent = this.btnOpenNotes;
            this.btnOpenNotes.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenNotes.ForeColor = System.Drawing.Color.White;
            this.btnOpenNotes.HoverState.Parent = this.btnOpenNotes;
            this.btnOpenNotes.Image = global::Organized_Plurality.Properties.Resources.notepad_picture;
            this.btnOpenNotes.ImageSize = new System.Drawing.Size(700, 300);
            this.btnOpenNotes.Location = new System.Drawing.Point(0, 3);
            this.btnOpenNotes.Name = "btnOpenNotes";
            this.btnOpenNotes.ShadowDecoration.Parent = this.btnOpenNotes;
            this.btnOpenNotes.Size = new System.Drawing.Size(594, 203);
            this.btnOpenNotes.TabIndex = 0;
            this.btnOpenNotes.Text = "Plural Notes";
            this.btnOpenNotes.TextFormatNoPrefix = true;
            this.btnOpenNotes.TextOffset = new System.Drawing.Point(-190, 0);
            this.btnOpenNotes.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnOpenNotes.Click += new System.EventHandler(this.btnOpenNotes_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 472);
            this.Controls.Add(this.pnlCtrlBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OP - Menu";
            this.pnlCtrlBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow animForm;
        private System.Windows.Forms.ImageList imagelist;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlCtrlBox;
        private Guna.UI2.WinForms.Guna2DragControl dragForm;
        private Guna.UI2.WinForms.Guna2CircleButton btnMin;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2CircleButton btnSettings;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnOpenNotes;
        private Guna.UI2.WinForms.Guna2Button btnOpenRPC;
    }
}

