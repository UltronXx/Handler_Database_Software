namespace handler
{
    partial class Form3
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
            this.saveButton = new Guna.UI.WinForms.GunaButton();
            this.clearButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.labelNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.macAddressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.assigneeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.deviceNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.departmentComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.referenceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.AnimationHoverSpeed = 0.07F;
            this.saveButton.AnimationSpeed = 0.03F;
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(153)))), ((int)(((byte)(251)))));
            this.saveButton.BorderColor = System.Drawing.Color.Black;
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveButton.FocusedColor = System.Drawing.Color.Empty;
            this.saveButton.Font = new System.Drawing.Font("SF UI Text", 11F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Image = global::handler.Properties.Resources.saveIcon;
            this.saveButton.ImageOffsetX = 4;
            this.saveButton.ImageSize = new System.Drawing.Size(11, 15);
            this.saveButton.Location = new System.Drawing.Point(309, 564);
            this.saveButton.Name = "saveButton";
            this.saveButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.saveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.saveButton.OnHoverForeColor = System.Drawing.Color.White;
            this.saveButton.OnHoverImage = null;
            this.saveButton.OnPressedColor = System.Drawing.Color.Black;
            this.saveButton.Radius = 8;
            this.saveButton.Size = new System.Drawing.Size(115, 35);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.TextOffsetX = 10;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AnimationHoverSpeed = 0.07F;
            this.clearButton.AnimationSpeed = 0.03F;
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(153)))), ((int)(((byte)(251)))));
            this.clearButton.BorderColor = System.Drawing.Color.Black;
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clearButton.FocusedColor = System.Drawing.Color.Empty;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Image = global::handler.Properties.Resources.clearIcon;
            this.clearButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clearButton.ImageSize = new System.Drawing.Size(18, 18);
            this.clearButton.Location = new System.Drawing.Point(239, 564);
            this.clearButton.Name = "clearButton";
            this.clearButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.clearButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clearButton.OnHoverForeColor = System.Drawing.Color.White;
            this.clearButton.OnHoverImage = null;
            this.clearButton.OnPressedColor = System.Drawing.Color.Black;
            this.clearButton.Radius = 8;
            this.clearButton.Size = new System.Drawing.Size(59, 35);
            this.clearButton.TabIndex = 0;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("SF UI Text", 10F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.gunaLabel1.Location = new System.Drawing.Point(49, 445);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(84, 16);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Label name";
            // 
            // labelNameTextBox
            // 
            this.labelNameTextBox.BorderRadius = 10;
            this.labelNameTextBox.BorderThickness = 2;
            this.labelNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelNameTextBox.DefaultText = "";
            this.labelNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.labelNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.labelNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.labelNameTextBox.DisabledState.Parent = this.labelNameTextBox;
            this.labelNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.labelNameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.labelNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.labelNameTextBox.FocusedState.Parent = this.labelNameTextBox;
            this.labelNameTextBox.Font = new System.Drawing.Font("SF UI Text", 10F);
            this.labelNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.labelNameTextBox.HoverState.Parent = this.labelNameTextBox;
            this.labelNameTextBox.Location = new System.Drawing.Point(33, 474);
            this.labelNameTextBox.Name = "labelNameTextBox";
            this.labelNameTextBox.PasswordChar = '\0';
            this.labelNameTextBox.PlaceholderText = "";
            this.labelNameTextBox.SelectedText = "";
            this.labelNameTextBox.ShadowDecoration.Parent = this.labelNameTextBox;
            this.labelNameTextBox.Size = new System.Drawing.Size(185, 35);
            this.labelNameTextBox.TabIndex = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("SF UI Text", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.gunaLabel2.Location = new System.Drawing.Point(27, 25);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(166, 33);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Edit device";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("SF UI Text", 10F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.gunaLabel3.Location = new System.Drawing.Point(255, 445);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(95, 16);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "MAC address";
            // 
            // macAddressTextBox
            // 
            this.macAddressTextBox.BorderRadius = 10;
            this.macAddressTextBox.BorderThickness = 2;
            this.macAddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.macAddressTextBox.DefaultText = "";
            this.macAddressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.macAddressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.macAddressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.macAddressTextBox.DisabledState.Parent = this.macAddressTextBox;
            this.macAddressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.macAddressTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.macAddressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.macAddressTextBox.FocusedState.Parent = this.macAddressTextBox;
            this.macAddressTextBox.Font = new System.Drawing.Font("SF UI Text", 10F);
            this.macAddressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.macAddressTextBox.HoverState.Parent = this.macAddressTextBox;
            this.macAddressTextBox.Location = new System.Drawing.Point(239, 474);
            this.macAddressTextBox.Name = "macAddressTextBox";
            this.macAddressTextBox.PasswordChar = '\0';
            this.macAddressTextBox.PlaceholderText = "";
            this.macAddressTextBox.SelectedText = "";
            this.macAddressTextBox.ShadowDecoration.Parent = this.macAddressTextBox;
            this.macAddressTextBox.Size = new System.Drawing.Size(185, 35);
            this.macAddressTextBox.TabIndex = 2;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("SF UI Text", 10F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.gunaLabel4.Location = new System.Drawing.Point(49, 174);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(66, 16);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Assignee";
            // 
            // assigneeTextBox
            // 
            this.assigneeTextBox.BorderRadius = 10;
            this.assigneeTextBox.BorderThickness = 2;
            this.assigneeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.assigneeTextBox.DefaultText = "";
            this.assigneeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.assigneeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.assigneeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.assigneeTextBox.DisabledState.Parent = this.assigneeTextBox;
            this.assigneeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.assigneeTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.assigneeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.assigneeTextBox.FocusedState.Parent = this.assigneeTextBox;
            this.assigneeTextBox.Font = new System.Drawing.Font("SF UI Text", 10F);
            this.assigneeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.assigneeTextBox.HoverState.Parent = this.assigneeTextBox;
            this.assigneeTextBox.Location = new System.Drawing.Point(33, 203);
            this.assigneeTextBox.Name = "assigneeTextBox";
            this.assigneeTextBox.PasswordChar = '\0';
            this.assigneeTextBox.PlaceholderText = "";
            this.assigneeTextBox.SelectedText = "";
            this.assigneeTextBox.ShadowDecoration.Parent = this.assigneeTextBox;
            this.assigneeTextBox.Size = new System.Drawing.Size(391, 35);
            this.assigneeTextBox.TabIndex = 2;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("SF UI Text", 10F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.gunaLabel5.Location = new System.Drawing.Point(49, 264);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(92, 16);
            this.gunaLabel5.TabIndex = 1;
            this.gunaLabel5.Text = "Device name";
            // 
            // deviceNameTextBox
            // 
            this.deviceNameTextBox.BorderRadius = 10;
            this.deviceNameTextBox.BorderThickness = 2;
            this.deviceNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deviceNameTextBox.DefaultText = "";
            this.deviceNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.deviceNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.deviceNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.deviceNameTextBox.DisabledState.Parent = this.deviceNameTextBox;
            this.deviceNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.deviceNameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.deviceNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.deviceNameTextBox.FocusedState.Parent = this.deviceNameTextBox;
            this.deviceNameTextBox.Font = new System.Drawing.Font("SF UI Text", 10F);
            this.deviceNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.deviceNameTextBox.HoverState.Parent = this.deviceNameTextBox;
            this.deviceNameTextBox.Location = new System.Drawing.Point(33, 293);
            this.deviceNameTextBox.Name = "deviceNameTextBox";
            this.deviceNameTextBox.PasswordChar = '\0';
            this.deviceNameTextBox.PlaceholderText = "";
            this.deviceNameTextBox.SelectedText = "";
            this.deviceNameTextBox.ShadowDecoration.Parent = this.deviceNameTextBox;
            this.deviceNameTextBox.Size = new System.Drawing.Size(391, 35);
            this.deviceNameTextBox.TabIndex = 2;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("SF UI Text", 10F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.gunaLabel6.Location = new System.Drawing.Point(49, 353);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(85, 16);
            this.gunaLabel6.TabIndex = 1;
            this.gunaLabel6.Text = "Department";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("SF UI Text", 10F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.gunaLabel7.Location = new System.Drawing.Point(255, 353);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(38, 16);
            this.gunaLabel7.TabIndex = 1;
            this.gunaLabel7.Text = "Date";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.BackColor = System.Drawing.Color.Transparent;
            this.departmentComboBox.BorderColor = System.Drawing.Color.Silver;
            this.departmentComboBox.BorderRadius = 10;
            this.departmentComboBox.BorderThickness = 2;
            this.departmentComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.departmentComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.departmentComboBox.FocusedState.Parent = this.departmentComboBox;
            this.departmentComboBox.Font = new System.Drawing.Font("SF UI Text", 10F, System.Drawing.FontStyle.Bold);
            this.departmentComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.HoverState.Parent = this.departmentComboBox;
            this.departmentComboBox.ItemHeight = 30;
            this.departmentComboBox.Items.AddRange(new object[] {
            "Television",
            "Engineering",
            "Radio",
            "Others"});
            this.departmentComboBox.ItemsAppearance.Parent = this.departmentComboBox;
            this.departmentComboBox.Location = new System.Drawing.Point(33, 381);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.ShadowDecoration.Parent = this.departmentComboBox;
            this.departmentComboBox.Size = new System.Drawing.Size(185, 36);
            this.departmentComboBox.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.BorderColor = System.Drawing.Color.Silver;
            this.dateTimePicker.BorderRadius = 10;
            this.dateTimePicker.BorderThickness = 2;
            this.dateTimePicker.CheckedState.Parent = this.dateTimePicker;
            this.dateTimePicker.FillColor = System.Drawing.Color.Empty;
            this.dateTimePicker.Font = new System.Drawing.Font("SF UI Text", 10F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.HoverState.Parent = this.dateTimePicker;
            this.dateTimePicker.Location = new System.Drawing.Point(239, 381);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShadowDecoration.Parent = this.dateTimePicker;
            this.dateTimePicker.Size = new System.Drawing.Size(185, 36);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateTimePicker.Value = new System.DateTime(2021, 10, 26, 18, 22, 30, 399);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("SF UI Text", 10F);
            this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.gunaLabel8.Location = new System.Drawing.Point(49, 88);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(74, 16);
            this.gunaLabel8.TabIndex = 1;
            this.gunaLabel8.Text = "Reference";
            // 
            // referenceTextBox
            // 
            this.referenceTextBox.BorderRadius = 10;
            this.referenceTextBox.BorderThickness = 2;
            this.referenceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.referenceTextBox.DefaultText = "";
            this.referenceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.referenceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.referenceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.referenceTextBox.DisabledState.Parent = this.referenceTextBox;
            this.referenceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.referenceTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.referenceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.referenceTextBox.FocusedState.Parent = this.referenceTextBox;
            this.referenceTextBox.Font = new System.Drawing.Font("SF UI Text", 10F);
            this.referenceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.referenceTextBox.HoverState.Parent = this.referenceTextBox;
            this.referenceTextBox.Location = new System.Drawing.Point(33, 119);
            this.referenceTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.PasswordChar = '\0';
            this.referenceTextBox.PlaceholderText = "";
            this.referenceTextBox.ReadOnly = true;
            this.referenceTextBox.SelectedText = "";
            this.referenceTextBox.ShadowDecoration.Parent = this.referenceTextBox;
            this.referenceTextBox.Size = new System.Drawing.Size(185, 35);
            this.referenceTextBox.TabIndex = 2;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::handler.Properties.Resources.closeButton;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(18, 18);
            this.guna2ImageButton1.Location = new System.Drawing.Point(417, 23);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(21, 23);
            this.guna2ImageButton1.TabIndex = 5;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 634);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.deviceNameTextBox);
            this.Controls.Add(this.referenceTextBox);
            this.Controls.Add(this.assigneeTextBox);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.macAddressTextBox);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.labelNameTextBox);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton clearButton;
        private Guna.UI.WinForms.GunaButton saveButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox labelNameTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2TextBox macAddressTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2TextBox assigneeTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2TextBox deviceNameTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2ComboBox departmentComboBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2TextBox referenceTextBox;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}