
namespace gym_management_system
{
    partial class bodybuilder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.filterComobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gym_managemntDataSet = new gym_management_system.gym_managemntDataSet();
            this.searchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDHeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDIllenessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDExpireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDMembershipPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excersise = new System.Windows.Forms.DataGridViewImageColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.bodyBuilderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2VScrollBar3 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.body_BuilderTableAdapter = new gym_management_system.gym_managemntDataSetTableAdapters.Body_BuilderTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SearcgBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gym_managemntDataSet)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyBuilderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // filterComobox
            // 
            this.filterComobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterComobox.BackColor = System.Drawing.Color.Transparent;
            this.filterComobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(103)))));
            this.filterComobox.BorderRadius = 50;
            this.filterComobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterComobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComobox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(103)))));
            this.filterComobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filterComobox.FocusedColor = System.Drawing.Color.Empty;
            this.filterComobox.FocusedState.Parent = this.filterComobox;
            this.filterComobox.Font = new System.Drawing.Font("Open Sans", 10F);
            this.filterComobox.ForeColor = System.Drawing.Color.White;
            this.filterComobox.FormattingEnabled = true;
            this.filterComobox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(103)))));
            this.filterComobox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(103)))));
            this.filterComobox.HoverState.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComobox.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.filterComobox.HoverState.Parent = this.filterComobox;
            this.filterComobox.ItemHeight = 35;
            this.filterComobox.Items.AddRange(new object[] {
            "BD_ID",
            "BD_First_Name",
            "BD_Last_Name",
            "BD_Weight",
            "BD_Height",
            "BD_Illeness",
            "BD_Start_Date",
            "BD_Expire_Date",
            "BD_Gender"});
            this.filterComobox.ItemsAppearance.BackColor = System.Drawing.Color.DimGray;
            this.filterComobox.ItemsAppearance.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComobox.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.filterComobox.ItemsAppearance.Parent = this.filterComobox;
            this.filterComobox.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(103)))));
            this.filterComobox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.filterComobox.Location = new System.Drawing.Point(493, 62);
            this.filterComobox.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.filterComobox.Name = "filterComobox";
            this.filterComobox.ShadowDecoration.Depth = 100;
            this.filterComobox.ShadowDecoration.Parent = this.filterComobox;
            this.filterComobox.Size = new System.Drawing.Size(289, 41);
            this.filterComobox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.filterComobox.TabIndex = 21;
            this.filterComobox.SelectedIndexChanged += new System.EventHandler(this.filterComobox_SelectedIndexChanged);
            // 
            // gym_managemntDataSet
            // 
            this.gym_managemntDataSet.DataSetName = "gym_managemntDataSet";
            this.gym_managemntDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchTxt
            // 
            this.searchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxt.Animated = true;
            this.searchTxt.BackColor = System.Drawing.Color.Transparent;
            this.searchTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.searchTxt.BorderRadius = 15;
            this.searchTxt.BorderThickness = 3;
            this.searchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxt.DefaultText = "";
            this.searchTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxt.DisabledState.Parent = this.searchTxt;
            this.searchTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.searchTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(104)))), ((int)(((byte)(82)))));
            this.searchTxt.FocusedState.Parent = this.searchTxt;
            this.searchTxt.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.searchTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(104)))), ((int)(((byte)(82)))));
            this.searchTxt.HoverState.Parent = this.searchTxt;
            this.searchTxt.Location = new System.Drawing.Point(887, 62);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PasswordChar = '\0';
            this.searchTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.searchTxt.PlaceholderText = "Search";
            this.searchTxt.SelectedText = "";
            this.searchTxt.ShadowDecoration.Depth = 100;
            this.searchTxt.ShadowDecoration.Parent = this.searchTxt;
            this.searchTxt.Size = new System.Drawing.Size(307, 44);
            this.searchTxt.TabIndex = 19;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.bunifuCustomDataGrid2);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 288);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1303, 685);
            this.guna2Panel1.TabIndex = 24;
            // 
            // bunifuCustomDataGrid2
            // 
            this.bunifuCustomDataGrid2.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid2.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(104)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(104)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid2.ColumnHeadersHeight = 35;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bunifuCustomDataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bDIDDataGridViewTextBoxColumn,
            this.bDFirstNameDataGridViewTextBoxColumn,
            this.bDLastNameDataGridViewTextBoxColumn,
            this.bDWeightDataGridViewTextBoxColumn,
            this.bDHeightDataGridViewTextBoxColumn,
            this.bDIllenessDataGridViewTextBoxColumn,
            this.bDStartDateDataGridViewTextBoxColumn,
            this.bDExpireDateDataGridViewTextBoxColumn,
            this.bDMembershipPaymentDataGridViewTextBoxColumn,
            this.bDPhoneNumberDataGridViewTextBoxColumn,
            this.bDGenderDataGridViewTextBoxColumn,
            this.excersise,
            this.edit,
            this.delete});
            this.bunifuCustomDataGrid2.DataSource = this.bodyBuilderBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid2.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid2.DoubleBuffered = false;
            this.bunifuCustomDataGrid2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(104)))), ((int)(((byte)(82)))));
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomDataGrid2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCustomDataGrid2.MultiSelect = false;
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.ReadOnly = true;
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.RowHeadersVisible = false;
            this.bunifuCustomDataGrid2.RowHeadersWidth = 60;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid2.RowTemplate.Height = 40;
            this.bunifuCustomDataGrid2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuCustomDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1276, 685);
            this.bunifuCustomDataGrid2.TabIndex = 20;
            this.bunifuCustomDataGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid2_CellContentClick_1);
            // 
            // bDIDDataGridViewTextBoxColumn
            // 
            this.bDIDDataGridViewTextBoxColumn.DataPropertyName = "BD_ID";
            this.bDIDDataGridViewTextBoxColumn.HeaderText = "BD_ID";
            this.bDIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDIDDataGridViewTextBoxColumn.Name = "bDIDDataGridViewTextBoxColumn";
            this.bDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDFirstNameDataGridViewTextBoxColumn
            // 
            this.bDFirstNameDataGridViewTextBoxColumn.DataPropertyName = "BD_First_Name";
            this.bDFirstNameDataGridViewTextBoxColumn.HeaderText = "BD_First_Name";
            this.bDFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDFirstNameDataGridViewTextBoxColumn.Name = "bDFirstNameDataGridViewTextBoxColumn";
            this.bDFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDLastNameDataGridViewTextBoxColumn
            // 
            this.bDLastNameDataGridViewTextBoxColumn.DataPropertyName = "BD_Last_Name";
            this.bDLastNameDataGridViewTextBoxColumn.HeaderText = "BD_Last_Name";
            this.bDLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDLastNameDataGridViewTextBoxColumn.Name = "bDLastNameDataGridViewTextBoxColumn";
            this.bDLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDWeightDataGridViewTextBoxColumn
            // 
            this.bDWeightDataGridViewTextBoxColumn.DataPropertyName = "BD_Weight";
            this.bDWeightDataGridViewTextBoxColumn.HeaderText = "BD_Weight";
            this.bDWeightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDWeightDataGridViewTextBoxColumn.Name = "bDWeightDataGridViewTextBoxColumn";
            this.bDWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDHeightDataGridViewTextBoxColumn
            // 
            this.bDHeightDataGridViewTextBoxColumn.DataPropertyName = "BD_Height";
            this.bDHeightDataGridViewTextBoxColumn.HeaderText = "BD_Height";
            this.bDHeightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDHeightDataGridViewTextBoxColumn.Name = "bDHeightDataGridViewTextBoxColumn";
            this.bDHeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDIllenessDataGridViewTextBoxColumn
            // 
            this.bDIllenessDataGridViewTextBoxColumn.DataPropertyName = "BD_Illeness";
            this.bDIllenessDataGridViewTextBoxColumn.HeaderText = "BD_Illeness";
            this.bDIllenessDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDIllenessDataGridViewTextBoxColumn.Name = "bDIllenessDataGridViewTextBoxColumn";
            this.bDIllenessDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDStartDateDataGridViewTextBoxColumn
            // 
            this.bDStartDateDataGridViewTextBoxColumn.DataPropertyName = "BD_Start_Date";
            this.bDStartDateDataGridViewTextBoxColumn.HeaderText = "BD_Start_Date";
            this.bDStartDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDStartDateDataGridViewTextBoxColumn.Name = "bDStartDateDataGridViewTextBoxColumn";
            this.bDStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDExpireDateDataGridViewTextBoxColumn
            // 
            this.bDExpireDateDataGridViewTextBoxColumn.DataPropertyName = "BD_Expire_Date";
            this.bDExpireDateDataGridViewTextBoxColumn.HeaderText = "BD_Expire_Date";
            this.bDExpireDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDExpireDateDataGridViewTextBoxColumn.Name = "bDExpireDateDataGridViewTextBoxColumn";
            this.bDExpireDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDMembershipPaymentDataGridViewTextBoxColumn
            // 
            this.bDMembershipPaymentDataGridViewTextBoxColumn.DataPropertyName = "BD_Membership_Payment";
            this.bDMembershipPaymentDataGridViewTextBoxColumn.HeaderText = "BD_Membership_Payment";
            this.bDMembershipPaymentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDMembershipPaymentDataGridViewTextBoxColumn.Name = "bDMembershipPaymentDataGridViewTextBoxColumn";
            this.bDMembershipPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDPhoneNumberDataGridViewTextBoxColumn
            // 
            this.bDPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "BD_Phone_Number";
            this.bDPhoneNumberDataGridViewTextBoxColumn.HeaderText = "BD_Phone_Number";
            this.bDPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDPhoneNumberDataGridViewTextBoxColumn.Name = "bDPhoneNumberDataGridViewTextBoxColumn";
            this.bDPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDGenderDataGridViewTextBoxColumn
            // 
            this.bDGenderDataGridViewTextBoxColumn.DataPropertyName = "BD_Gender";
            this.bDGenderDataGridViewTextBoxColumn.HeaderText = "BD_Gender";
            this.bDGenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDGenderDataGridViewTextBoxColumn.Name = "bDGenderDataGridViewTextBoxColumn";
            this.bDGenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // excersise
            // 
            this.excersise.FillWeight = 50F;
            this.excersise.HeaderText = "";
            this.excersise.Image = global::gym_management_system.Properties.Resources.gym;
            this.excersise.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.excersise.MinimumWidth = 6;
            this.excersise.Name = "excersise";
            this.excersise.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.FillWeight = 50F;
            this.edit.HeaderText = "";
            this.edit.Image = global::gym_management_system.Properties.Resources.pencil;
            this.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.FillWeight = 50F;
            this.delete.HeaderText = "";
            this.delete.Image = global::gym_management_system.Properties.Resources.garbage;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // bodyBuilderBindingSource
            // 
            this.bodyBuilderBindingSource.DataMember = "Body_Builder";
            this.bodyBuilderBindingSource.DataSource = this.gym_managemntDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2VScrollBar3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1276, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 685);
            this.panel1.TabIndex = 0;
            // 
            // guna2VScrollBar3
            // 
            this.guna2VScrollBar3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2VScrollBar3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.guna2VScrollBar3.HoverState.Parent = null;
            this.guna2VScrollBar3.LargeChange = 10;
            this.guna2VScrollBar3.Location = new System.Drawing.Point(0, 34);
            this.guna2VScrollBar3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2VScrollBar3.MouseWheelBarPartitions = 100;
            this.guna2VScrollBar3.Name = "guna2VScrollBar3";
            this.guna2VScrollBar3.PressedState.Parent = this.guna2VScrollBar3;
            this.guna2VScrollBar3.ScrollbarSize = 27;
            this.guna2VScrollBar3.Size = new System.Drawing.Size(27, 651);
            this.guna2VScrollBar3.TabIndex = 18;
            this.guna2VScrollBar3.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(104)))), ((int)(((byte)(82)))));
            this.guna2VScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2VScrollBar3_Scroll);
            // 
            // body_BuilderTableAdapter
            // 
            this.body_BuilderTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::gym_management_system.Properties.Resources.garbage;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 67;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::gym_management_system.Properties.Resources.pencil;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 67;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.FillWeight = 50F;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::gym_management_system.Properties.Resources.gym;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 116;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gym_management_system.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(265, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(103)))));
            this.guna2Button1.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::gym_management_system.Properties.Resources.add;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button1.Location = new System.Drawing.Point(38, 58);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(221, 45);
            this.guna2Button1.TabIndex = 23;
            this.guna2Button1.Text = "Add Bodybuilder";
            this.guna2Button1.TextOffset = new System.Drawing.Point(-25, 0);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox3.Image = global::gym_management_system.Properties.Resources.filter__1_;
            this.guna2PictureBox3.Location = new System.Drawing.Point(788, 64);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(48, 39);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 22;
            this.guna2PictureBox3.TabStop = false;
            // 
            // SearcgBtn
            // 
            this.SearcgBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearcgBtn.Animated = true;
            this.SearcgBtn.CheckedState.Parent = this.SearcgBtn;
            this.SearcgBtn.CustomImages.Parent = this.SearcgBtn;
            this.SearcgBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(104)))), ((int)(((byte)(82)))));
            this.SearcgBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearcgBtn.ForeColor = System.Drawing.Color.White;
            this.SearcgBtn.HoverState.Parent = this.SearcgBtn;
            this.SearcgBtn.Image = global::gym_management_system.Properties.Resources.search;
            this.SearcgBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.SearcgBtn.Location = new System.Drawing.Point(1201, 62);
            this.SearcgBtn.Name = "SearcgBtn";
            this.SearcgBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.SearcgBtn.ShadowDecoration.Parent = this.SearcgBtn;
            this.SearcgBtn.Size = new System.Drawing.Size(55, 44);
            this.SearcgBtn.TabIndex = 20;
            // 
            // bodybuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.filterComobox);
            this.Controls.Add(this.SearcgBtn);
            this.Controls.Add(this.searchTxt);
            this.Name = "bodybuilder";
            this.Size = new System.Drawing.Size(1303, 973);
            this.Load += new System.EventHandler(this.bodybuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gym_managemntDataSet)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyBuilderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2ComboBox filterComobox;
        private Guna.UI2.WinForms.Guna2CircleButton SearcgBtn;
        private Guna.UI2.WinForms.Guna2TextBox searchTxt;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.BindingSource bodyBuilderBindingSource;
        private gym_managemntDataSet gym_managemntDataSet;
        private gym_managemntDataSetTableAdapters.Body_BuilderTableAdapter body_BuilderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDHeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDIllenessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDExpireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDMembershipPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn excersise;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
