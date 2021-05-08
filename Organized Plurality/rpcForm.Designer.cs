
namespace Organized_Plurality
{
    partial class rpcForm
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
            this.pnlCtrlBox = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnMin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tabctrlMain = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUpdateRPC = new Guna.UI2.WinForms.Guna2Button();
            this.txtBtnUrl = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkboxBtn1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtBtnTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStopRPC = new Guna.UI2.WinForms.Guna2Button();
            this.btnStartRPC = new Guna.UI2.WinForms.Guna2Button();
            this.comboFronterType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFronter2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFronter = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.tabselector = new MaterialSkin.Controls.MaterialTabSelector();
            this.dragForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlCtrlBox.SuspendLayout();
            this.tabctrlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // animForm
            // 
            this.animForm.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.animForm.TargetForm = this;
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
            this.pnlCtrlBox.ShadowDepth = 0;
            this.pnlCtrlBox.ShadowShift = 0;
            this.pnlCtrlBox.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlCtrlBox.Size = new System.Drawing.Size(612, 73);
            this.pnlCtrlBox.TabIndex = 2;
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
            this.btnMin.Location = new System.Drawing.Point(517, 12);
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
            this.btnClose.Location = new System.Drawing.Point(564, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(41, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabctrlMain
            // 
            this.tabctrlMain.Controls.Add(this.tabPage1);
            this.tabctrlMain.Controls.Add(this.tabPage3);
            this.tabctrlMain.Depth = 0;
            this.tabctrlMain.Location = new System.Drawing.Point(0, 121);
            this.tabctrlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabctrlMain.Multiline = true;
            this.tabctrlMain.Name = "tabctrlMain";
            this.tabctrlMain.SelectedIndex = 0;
            this.tabctrlMain.Size = new System.Drawing.Size(612, 444);
            this.tabctrlMain.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabPage1.Controls.Add(this.btnUpdateRPC);
            this.tabPage1.Controls.Add(this.txtBtnUrl);
            this.tabPage1.Controls.Add(this.checkboxBtn1);
            this.tabPage1.Controls.Add(this.txtBtnTitle);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnStopRPC);
            this.tabPage1.Controls.Add(this.btnStartRPC);
            this.tabPage1.Controls.Add(this.comboFronterType);
            this.tabPage1.Controls.Add(this.txtFronter2);
            this.tabPage1.Controls.Add(this.txtFronter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RPC";
            // 
            // btnUpdateRPC
            // 
            this.btnUpdateRPC.Animated = true;
            this.btnUpdateRPC.CheckedState.Parent = this.btnUpdateRPC;
            this.btnUpdateRPC.CustomImages.Parent = this.btnUpdateRPC;
            this.btnUpdateRPC.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Organized_Plurality.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnUpdateRPC.FillColor = global::Organized_Plurality.Properties.Settings.Default.MainColor;
            this.btnUpdateRPC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateRPC.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRPC.HoverState.Parent = this.btnUpdateRPC;
            this.btnUpdateRPC.Location = new System.Drawing.Point(212, 318);
            this.btnUpdateRPC.Name = "btnUpdateRPC";
            this.btnUpdateRPC.ShadowDecoration.Parent = this.btnUpdateRPC;
            this.btnUpdateRPC.Size = new System.Drawing.Size(180, 36);
            this.btnUpdateRPC.TabIndex = 18;
            this.btnUpdateRPC.Text = "Update";
            this.btnUpdateRPC.Visible = false;
            this.btnUpdateRPC.Click += new System.EventHandler(this.btnUpdateRPC_Click);
            // 
            // txtBtnUrl
            // 
            this.txtBtnUrl.Animated = true;
            this.txtBtnUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBtnUrl.DefaultText = "";
            this.txtBtnUrl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBtnUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBtnUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBtnUrl.DisabledState.Parent = this.txtBtnUrl;
            this.txtBtnUrl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBtnUrl.Enabled = false;
            this.txtBtnUrl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBtnUrl.FocusedState.Parent = this.txtBtnUrl;
            this.txtBtnUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBtnUrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBtnUrl.HoverState.Parent = this.txtBtnUrl;
            this.txtBtnUrl.Location = new System.Drawing.Point(300, 255);
            this.txtBtnUrl.Name = "txtBtnUrl";
            this.txtBtnUrl.PasswordChar = '\0';
            this.txtBtnUrl.PlaceholderText = "URL";
            this.txtBtnUrl.SelectedText = "";
            this.txtBtnUrl.ShadowDecoration.Parent = this.txtBtnUrl;
            this.txtBtnUrl.Size = new System.Drawing.Size(169, 36);
            this.txtBtnUrl.TabIndex = 17;
            this.txtBtnUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkboxBtn1
            // 
            this.checkboxBtn1.AutoSize = true;
            this.checkboxBtn1.Depth = 0;
            this.checkboxBtn1.Location = new System.Drawing.Point(253, 215);
            this.checkboxBtn1.Margin = new System.Windows.Forms.Padding(0);
            this.checkboxBtn1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkboxBtn1.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkboxBtn1.Name = "checkboxBtn1";
            this.checkboxBtn1.Ripple = true;
            this.checkboxBtn1.Size = new System.Drawing.Size(95, 37);
            this.checkboxBtn1.TabIndex = 16;
            this.checkboxBtn1.Text = "Button 1";
            this.checkboxBtn1.UseVisualStyleBackColor = true;
            this.checkboxBtn1.CheckedChanged += new System.EventHandler(this.checkboxBtn1_CheckedChanged);
            // 
            // txtBtnTitle
            // 
            this.txtBtnTitle.Animated = true;
            this.txtBtnTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBtnTitle.DefaultText = "";
            this.txtBtnTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBtnTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBtnTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBtnTitle.DisabledState.Parent = this.txtBtnTitle;
            this.txtBtnTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBtnTitle.Enabled = false;
            this.txtBtnTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBtnTitle.FocusedState.Parent = this.txtBtnTitle;
            this.txtBtnTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBtnTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBtnTitle.HoverState.Parent = this.txtBtnTitle;
            this.txtBtnTitle.Location = new System.Drawing.Point(125, 255);
            this.txtBtnTitle.Name = "txtBtnTitle";
            this.txtBtnTitle.PasswordChar = '\0';
            this.txtBtnTitle.PlaceholderText = "Title";
            this.txtBtnTitle.SelectedText = "";
            this.txtBtnTitle.ShadowDecoration.Parent = this.txtBtnTitle;
            this.txtBtnTitle.Size = new System.Drawing.Size(169, 36);
            this.txtBtnTitle.TabIndex = 15;
            this.txtBtnTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fronter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Additional(s):";
            // 
            // btnStopRPC
            // 
            this.btnStopRPC.Animated = true;
            this.btnStopRPC.CheckedState.Parent = this.btnStopRPC;
            this.btnStopRPC.CustomImages.Parent = this.btnStopRPC;
            this.btnStopRPC.FillColor = System.Drawing.Color.Firebrick;
            this.btnStopRPC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStopRPC.ForeColor = System.Drawing.Color.White;
            this.btnStopRPC.HoverState.Parent = this.btnStopRPC;
            this.btnStopRPC.Location = new System.Drawing.Point(212, 366);
            this.btnStopRPC.Name = "btnStopRPC";
            this.btnStopRPC.ShadowDecoration.Parent = this.btnStopRPC;
            this.btnStopRPC.Size = new System.Drawing.Size(180, 36);
            this.btnStopRPC.TabIndex = 11;
            this.btnStopRPC.Text = "Stop RPC";
            this.btnStopRPC.Visible = false;
            this.btnStopRPC.Click += new System.EventHandler(this.btnStopRPC_Click);
            // 
            // btnStartRPC
            // 
            this.btnStartRPC.Animated = true;
            this.btnStartRPC.CheckedState.Parent = this.btnStartRPC;
            this.btnStartRPC.CustomImages.Parent = this.btnStartRPC;
            this.btnStartRPC.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::Organized_Plurality.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnStartRPC.FillColor = global::Organized_Plurality.Properties.Settings.Default.MainColor;
            this.btnStartRPC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStartRPC.ForeColor = System.Drawing.Color.White;
            this.btnStartRPC.HoverState.Parent = this.btnStartRPC;
            this.btnStartRPC.Location = new System.Drawing.Point(212, 318);
            this.btnStartRPC.Name = "btnStartRPC";
            this.btnStartRPC.ShadowDecoration.Parent = this.btnStartRPC;
            this.btnStartRPC.Size = new System.Drawing.Size(180, 36);
            this.btnStartRPC.TabIndex = 10;
            this.btnStartRPC.Text = "Start RPC";
            this.btnStartRPC.Click += new System.EventHandler(this.btnStartRPC_Click);
            // 
            // comboFronterType
            // 
            this.comboFronterType.Animated = true;
            this.comboFronterType.BackColor = System.Drawing.Color.Transparent;
            this.comboFronterType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFronterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFronterType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboFronterType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboFronterType.FocusedState.Parent = this.comboFronterType;
            this.comboFronterType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboFronterType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboFronterType.HoverState.Parent = this.comboFronterType;
            this.comboFronterType.ItemHeight = 30;
            this.comboFronterType.Items.AddRange(new object[] {
            "",
            "Co-front",
            "Co-conscious"});
            this.comboFronterType.ItemsAppearance.Parent = this.comboFronterType;
            this.comboFronterType.Location = new System.Drawing.Point(232, 124);
            this.comboFronterType.Name = "comboFronterType";
            this.comboFronterType.ShadowDecoration.Parent = this.comboFronterType;
            this.comboFronterType.Size = new System.Drawing.Size(140, 36);
            this.comboFronterType.TabIndex = 7;
            this.comboFronterType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comboFronterType.SelectedIndexChanged += new System.EventHandler(this.comboFronterType_SelectedIndexChanged);
            // 
            // txtFronter2
            // 
            this.txtFronter2.Animated = true;
            this.txtFronter2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFronter2.DefaultText = "";
            this.txtFronter2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFronter2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFronter2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFronter2.DisabledState.Parent = this.txtFronter2;
            this.txtFronter2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFronter2.Enabled = false;
            this.txtFronter2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFronter2.FocusedState.Parent = this.txtFronter2;
            this.txtFronter2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFronter2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFronter2.HoverState.Parent = this.txtFronter2;
            this.txtFronter2.Location = new System.Drawing.Point(171, 168);
            this.txtFronter2.Name = "txtFronter2";
            this.txtFronter2.PasswordChar = '\0';
            this.txtFronter2.PlaceholderText = "";
            this.txtFronter2.SelectedText = "";
            this.txtFronter2.ShadowDecoration.Parent = this.txtFronter2;
            this.txtFronter2.Size = new System.Drawing.Size(263, 36);
            this.txtFronter2.TabIndex = 6;
            this.txtFronter2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtFronter.Location = new System.Drawing.Point(171, 42);
            this.txtFronter.Name = "txtFronter";
            this.txtFronter.PasswordChar = '\0';
            this.txtFronter.PlaceholderText = "";
            this.txtFronter.SelectedText = "";
            this.txtFronter.ShadowDecoration.Parent = this.txtFronter;
            this.txtFronter.Size = new System.Drawing.Size(263, 36);
            this.txtFronter.TabIndex = 5;
            this.txtFronter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtConsole);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(604, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Console";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtConsole
            // 
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.Location = new System.Drawing.Point(3, 3);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(598, 412);
            this.txtConsole.TabIndex = 5;
            this.txtConsole.Text = "";
            // 
            // tabselector
            // 
            this.tabselector.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabselector.BaseTabControl = this.tabctrlMain;
            this.tabselector.Depth = 0;
            this.tabselector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabselector.Location = new System.Drawing.Point(75, 73);
            this.tabselector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabselector.Name = "tabselector";
            this.tabselector.Size = new System.Drawing.Size(462, 48);
            this.tabselector.TabIndex = 0;
            // 
            // dragForm
            // 
            this.dragForm.ContainerControl = this;
            this.dragForm.DragStartTransparencyValue = 0.6D;
            this.dragForm.TargetControl = this.pnlCtrlBox;
            this.dragForm.TransparentWhileDrag = true;
            this.dragForm.UseTransparentDrag = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notifyIcon1.BalloonTipText = "An error has occured, check the console for more information";
            this.notifyIcon1.BalloonTipTitle = "OP - RPC";
            this.notifyIcon1.Visible = true;
            // 
            // rpcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(612, 566);
            this.Controls.Add(this.tabselector);
            this.Controls.Add(this.tabctrlMain);
            this.Controls.Add(this.pnlCtrlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rpcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rpcForm";
            this.pnlCtrlBox.ResumeLayout(false);
            this.tabctrlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow animForm;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlCtrlBox;
        private Guna.UI2.WinForms.Guna2CircleButton btnMin;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private MaterialSkin.Controls.MaterialTabControl tabctrlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTabSelector tabselector;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox txtConsole;
        private Guna.UI2.WinForms.Guna2DragControl dragForm;
        private Guna.UI2.WinForms.Guna2ComboBox comboFronterType;
        private Guna.UI2.WinForms.Guna2TextBox txtFronter2;
        private Guna.UI2.WinForms.Guna2TextBox txtFronter;
        private Guna.UI2.WinForms.Guna2Button btnStartRPC;
        private Guna.UI2.WinForms.Guna2Button btnStopRPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialCheckbox checkboxBtn1;
        private Guna.UI2.WinForms.Guna2TextBox txtBtnTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtBtnUrl;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRPC;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}