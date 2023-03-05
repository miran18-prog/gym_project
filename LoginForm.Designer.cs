
namespace gym_management_system
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.locked = new Guna.UI2.WinForms.Guna2PictureBox();
            this.passwordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.snackbarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.snackbatPanelLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.snackbarTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.snackbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.locked);
            this.panel1.Controls.Add(this.passwordTxt);
            this.panel1.Controls.Add(this.usernameTxt);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 670);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Open Sans", 10F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(232, 215);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(353, 23);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "Please enter you\'r username and password.";
            // 
            // loginBtn
            // 
            this.loginBtn.Animated = true;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BorderRadius = 15;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(103)))));
            this.loginBtn.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(257, 501);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(287, 61);
            this.loginBtn.TabIndex = 14;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // locked
            // 
            this.locked.BackColor = System.Drawing.Color.Transparent;
            this.locked.Image = global::gym_management_system.Properties.Resources.lock_svgrepo_com;
            this.locked.Location = new System.Drawing.Point(522, 389);
            this.locked.Name = "locked";
            this.locked.ShadowDecoration.Parent = this.locked;
            this.locked.Size = new System.Drawing.Size(35, 35);
            this.locked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.locked.TabIndex = 13;
            this.locked.TabStop = false;
            this.locked.Click += new System.EventHandler(this.locked_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Animated = true;
            this.passwordTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(103)))));
            this.passwordTxt.BorderRadius = 10;
            this.passwordTxt.BorderThickness = 3;
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.DefaultText = "";
            this.passwordTxt.DisabledState.BorderColor = System.Drawing.Color.White;
            this.passwordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.passwordTxt.DisabledState.ForeColor = System.Drawing.Color.White;
            this.passwordTxt.DisabledState.Parent = this.passwordTxt;
            this.passwordTxt.DisabledState.PlaceholderForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.passwordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(104)))), ((int)(((byte)(82)))));
            this.passwordTxt.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.passwordTxt.FocusedState.ForeColor = System.Drawing.Color.White;
            this.passwordTxt.FocusedState.Parent = this.passwordTxt;
            this.passwordTxt.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.passwordTxt.Font = new System.Drawing.Font("Open Sans", 12F);
            this.passwordTxt.ForeColor = System.Drawing.Color.White;
            this.passwordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.passwordTxt.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.passwordTxt.HoverState.ForeColor = System.Drawing.Color.White;
            this.passwordTxt.HoverState.Parent = this.passwordTxt;
            this.passwordTxt.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.passwordTxt.IconRightOffset = new System.Drawing.Point(20, 0);
            this.passwordTxt.IconRightSize = new System.Drawing.Size(30, 30);
            this.passwordTxt.Location = new System.Drawing.Point(206, 374);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '\0';
            this.passwordTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.ShadowDecoration.Parent = this.passwordTxt;
            this.passwordTxt.Size = new System.Drawing.Size(374, 62);
            this.passwordTxt.TabIndex = 12;
            this.passwordTxt.TextOffset = new System.Drawing.Point(10, 0);
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Animated = true;
            this.usernameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(103)))));
            this.usernameTxt.BorderRadius = 10;
            this.usernameTxt.BorderThickness = 3;
            this.usernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxt.DefaultText = "";
            this.usernameTxt.DisabledState.BorderColor = System.Drawing.Color.White;
            this.usernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.usernameTxt.DisabledState.ForeColor = System.Drawing.Color.White;
            this.usernameTxt.DisabledState.Parent = this.usernameTxt;
            this.usernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.usernameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(104)))), ((int)(((byte)(82)))));
            this.usernameTxt.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.usernameTxt.FocusedState.ForeColor = System.Drawing.Color.White;
            this.usernameTxt.FocusedState.Parent = this.usernameTxt;
            this.usernameTxt.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.usernameTxt.Font = new System.Drawing.Font("Open Sans", 12F);
            this.usernameTxt.ForeColor = System.Drawing.Color.White;
            this.usernameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(206)))), ((int)(((byte)(162)))));
            this.usernameTxt.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.usernameTxt.HoverState.ForeColor = System.Drawing.Color.White;
            this.usernameTxt.HoverState.Parent = this.usernameTxt;
            this.usernameTxt.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.usernameTxt.IconRight = global::gym_management_system.Properties.Resources.icons8_user_90;
            this.usernameTxt.IconRightOffset = new System.Drawing.Point(20, 0);
            this.usernameTxt.IconRightSize = new System.Drawing.Size(35, 35);
            this.usernameTxt.Location = new System.Drawing.Point(206, 298);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '\0';
            this.usernameTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.usernameTxt.PlaceholderText = "Username";
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.ShadowDecoration.Parent = this.usernameTxt;
            this.usernameTxt.Size = new System.Drawing.Size(374, 62);
            this.usernameTxt.TabIndex = 11;
            this.usernameTxt.TextOffset = new System.Drawing.Point(10, 0);
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Open Sans", 40F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(103)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(224, 144);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(364, 92);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "Welcome!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gym_management_system.Properties.Resources.Rectangle_84;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // snackbarPanel
            // 
            this.snackbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(103)))));
            this.snackbarPanel.Controls.Add(this.snackbatPanelLabel);
            this.snackbarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.snackbarPanel.Location = new System.Drawing.Point(0, 670);
            this.snackbarPanel.Name = "snackbarPanel";
            this.snackbarPanel.ShadowDecoration.Parent = this.snackbarPanel;
            this.snackbarPanel.Size = new System.Drawing.Size(1300, 50);
            this.snackbarPanel.TabIndex = 2;
            this.snackbarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // snackbatPanelLabel
            // 
            this.snackbatPanelLabel.AutoSize = true;
            this.snackbatPanelLabel.Font = new System.Drawing.Font("Open Sans", 12F);
            this.snackbatPanelLabel.ForeColor = System.Drawing.Color.White;
            this.snackbatPanelLabel.Location = new System.Drawing.Point(39, 15);
            this.snackbatPanelLabel.Name = "snackbatPanelLabel";
            this.snackbatPanelLabel.Size = new System.Drawing.Size(292, 27);
            this.snackbatPanelLabel.TabIndex = 0;
            this.snackbatPanelLabel.Text = "Please enter a valid credential!";
            // 
            // snackbarTimer
            // 
            this.snackbarTimer.Interval = 1;
            this.snackbarTimer.Tick += new System.EventHandler(this.snackbarTimer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::gym_management_system.Properties.Resources.Rectangle_85;
            this.pictureBox2.Location = new System.Drawing.Point(1054, 557);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::gym_management_system.Properties.Resources.icons8_subtract_90;
            this.guna2PictureBox3.Location = new System.Drawing.Point(1198, 4);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(37, 39);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 4;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.Click += new System.EventHandler(this.guna2PictureBox3_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::gym_management_system.Properties.Resources.icons8_close_window_96;
            this.guna2PictureBox2.Location = new System.Drawing.Point(1241, 4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(37, 39);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 3;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::gym_management_system.Properties.Resources.Workout_amico__1_;
            this.guna2PictureBox1.Location = new System.Drawing.Point(759, 11);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(517, 595);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.snackbarPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.snackbarPanel.ResumeLayout(false);
            this.snackbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2PictureBox locked;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxt;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI2.WinForms.Guna2Panel snackbarPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel snackbatPanelLabel;
        private System.Windows.Forms.Timer snackbarTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}