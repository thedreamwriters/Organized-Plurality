
namespace Organized_Plurality
{
    partial class settingsForm
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
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.picSeconColorSelector = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblSecondaryColor = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.picColorSelector = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblMainColor = new System.Windows.Forms.Label();
            this.dragForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlCtrlBox = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnMin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeconColorSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColorSelector)).BeginInit();
            this.pnlCtrlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // animForm
            // 
            this.animForm.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.animForm.TargetForm = this;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.picSeconColorSelector);
            this.pnlMain.Controls.Add(this.lblSecondaryColor);
            this.pnlMain.Controls.Add(this.btnReset);
            this.pnlMain.Controls.Add(this.picColorSelector);
            this.pnlMain.Controls.Add(this.lblMainColor);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 73);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
            this.pnlMain.Size = new System.Drawing.Size(337, 274);
            this.pnlMain.TabIndex = 2;
            // 
            // picSeconColorSelector
            // 
            this.picSeconColorSelector.BackColor = global::Organized_Plurality.Properties.Settings.Default.SecondaryColor;
            this.picSeconColorSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSeconColorSelector.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Organized_Plurality.Properties.Settings.Default, "SecondaryColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.picSeconColorSelector.Location = new System.Drawing.Point(155, 86);
            this.picSeconColorSelector.Name = "picSeconColorSelector";
            this.picSeconColorSelector.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picSeconColorSelector.ShadowDecoration.Parent = this.picSeconColorSelector;
            this.picSeconColorSelector.Size = new System.Drawing.Size(27, 27);
            this.picSeconColorSelector.TabIndex = 5;
            this.picSeconColorSelector.TabStop = false;
            this.picSeconColorSelector.Click += new System.EventHandler(this.picSeconColorSelector_Click);
            // 
            // lblSecondaryColor
            // 
            this.lblSecondaryColor.AutoSize = true;
            this.lblSecondaryColor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaryColor.Location = new System.Drawing.Point(94, 112);
            this.lblSecondaryColor.Name = "lblSecondaryColor";
            this.lblSecondaryColor.Size = new System.Drawing.Size(148, 25);
            this.lblSecondaryColor.TabIndex = 4;
            this.lblSecondaryColor.Text = "Secondary color";
            // 
            // btnReset
            // 
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Organized_Plurality.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnReset.FillColor = global::Organized_Plurality.Properties.Settings.Default.MainColor;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(78, 217);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(180, 45);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Default";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picColorSelector
            // 
            this.picColorSelector.BackColor = global::Organized_Plurality.Properties.Settings.Default.MainColor;
            this.picColorSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picColorSelector.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Organized_Plurality.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.picColorSelector.Location = new System.Drawing.Point(155, 8);
            this.picColorSelector.Name = "picColorSelector";
            this.picColorSelector.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picColorSelector.ShadowDecoration.Parent = this.picColorSelector;
            this.picColorSelector.Size = new System.Drawing.Size(27, 27);
            this.picColorSelector.TabIndex = 2;
            this.picColorSelector.TabStop = false;
            this.picColorSelector.Click += new System.EventHandler(this.picColorSelector_Click);
            // 
            // lblMainColor
            // 
            this.lblMainColor.AutoSize = true;
            this.lblMainColor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainColor.Location = new System.Drawing.Point(117, 34);
            this.lblMainColor.Name = "lblMainColor";
            this.lblMainColor.Size = new System.Drawing.Size(103, 25);
            this.lblMainColor.TabIndex = 1;
            this.lblMainColor.Text = "Main color";
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
            this.pnlCtrlBox.Controls.Add(this.btnMin);
            this.pnlCtrlBox.Controls.Add(this.btnClose);
            this.pnlCtrlBox.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Organized_Plurality.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnlCtrlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCtrlBox.FillColor = global::Organized_Plurality.Properties.Settings.Default.MainColor;
            this.pnlCtrlBox.Location = new System.Drawing.Point(0, 0);
            this.pnlCtrlBox.Name = "pnlCtrlBox";
            this.pnlCtrlBox.ShadowColor = System.Drawing.Color.Black;
            this.pnlCtrlBox.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlCtrlBox.Size = new System.Drawing.Size(337, 73);
            this.pnlCtrlBox.TabIndex = 1;
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
            this.btnMin.Location = new System.Drawing.Point(242, 12);
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
            this.btnClose.Location = new System.Drawing.Point(289, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(41, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 347);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlCtrlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settingsForm";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeconColorSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColorSelector)).EndInit();
            this.pnlCtrlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow animForm;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlCtrlBox;
        private Guna.UI2.WinForms.Guna2CircleButton btnMin;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picColorSelector;
        private System.Windows.Forms.Label lblMainColor;
        private Guna.UI2.WinForms.Guna2DragControl dragForm;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picSeconColorSelector;
        private System.Windows.Forms.Label lblSecondaryColor;
    }
}