namespace BBM.Ui
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.loginButtonMainForm = new MetroFramework.Controls.MetroButton();
            this.clearButtonMainForm = new MetroFramework.Controls.MetroButton();
            this.registerButtonMainForm = new MetroFramework.Controls.MetroButton();
            this.userNameTextBoxMainForm = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextBoxMainForm = new MetroFramework.Controls.MetroTextBox();
            this.passwordLabelMainForm = new MetroFramework.Controls.MetroLabel();
            this.userNameLabelMainForm = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButtonMainForm
            // 
            this.loginButtonMainForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButtonMainForm.BackgroundImage")));
            this.loginButtonMainForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButtonMainForm.Location = new System.Drawing.Point(815, 217);
            this.loginButtonMainForm.Margin = new System.Windows.Forms.Padding(4);
            this.loginButtonMainForm.Name = "loginButtonMainForm";
            this.loginButtonMainForm.Size = new System.Drawing.Size(86, 92);
            this.loginButtonMainForm.TabIndex = 5;
            this.loginButtonMainForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.loginButtonMainForm.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginButtonMainForm.UseSelectable = true;
            this.loginButtonMainForm.Click += new System.EventHandler(this.loginButtonMainForm_Click);
            // 
            // clearButtonMainForm
            // 
            this.clearButtonMainForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearButtonMainForm.BackgroundImage")));
            this.clearButtonMainForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearButtonMainForm.Location = new System.Drawing.Point(982, 217);
            this.clearButtonMainForm.Margin = new System.Windows.Forms.Padding(4);
            this.clearButtonMainForm.Name = "clearButtonMainForm";
            this.clearButtonMainForm.Size = new System.Drawing.Size(90, 92);
            this.clearButtonMainForm.TabIndex = 6;
            this.clearButtonMainForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clearButtonMainForm.UseSelectable = true;
            this.clearButtonMainForm.Click += new System.EventHandler(this.clearButtonMainForm_Click);
            // 
            // registerButtonMainForm
            // 
            this.registerButtonMainForm.BackColor = System.Drawing.Color.Transparent;
            this.registerButtonMainForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerButtonMainForm.BackgroundImage")));
            this.registerButtonMainForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerButtonMainForm.Location = new System.Drawing.Point(880, 367);
            this.registerButtonMainForm.Margin = new System.Windows.Forms.Padding(4);
            this.registerButtonMainForm.Name = "registerButtonMainForm";
            this.registerButtonMainForm.Size = new System.Drawing.Size(126, 85);
            this.registerButtonMainForm.TabIndex = 7;
            this.registerButtonMainForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.registerButtonMainForm.UseSelectable = true;
            this.registerButtonMainForm.Click += new System.EventHandler(this.registerButtonMainForm_Click);
            // 
            // userNameTextBoxMainForm
            // 
            // 
            // 
            // 
            this.userNameTextBoxMainForm.CustomButton.Image = null;
            this.userNameTextBoxMainForm.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.userNameTextBoxMainForm.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.userNameTextBoxMainForm.CustomButton.Name = "";
            this.userNameTextBoxMainForm.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.userNameTextBoxMainForm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userNameTextBoxMainForm.CustomButton.TabIndex = 1;
            this.userNameTextBoxMainForm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userNameTextBoxMainForm.CustomButton.UseSelectable = true;
            this.userNameTextBoxMainForm.CustomButton.Visible = false;
            this.userNameTextBoxMainForm.Lines = new string[0];
            this.userNameTextBoxMainForm.Location = new System.Drawing.Point(781, 92);
            this.userNameTextBoxMainForm.Margin = new System.Windows.Forms.Padding(4);
            this.userNameTextBoxMainForm.MaxLength = 32767;
            this.userNameTextBoxMainForm.Name = "userNameTextBoxMainForm";
            this.userNameTextBoxMainForm.PasswordChar = '\0';
            this.userNameTextBoxMainForm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextBoxMainForm.SelectedText = "";
            this.userNameTextBoxMainForm.SelectionLength = 0;
            this.userNameTextBoxMainForm.SelectionStart = 0;
            this.userNameTextBoxMainForm.Size = new System.Drawing.Size(320, 37);
            this.userNameTextBoxMainForm.TabIndex = 10;
            this.userNameTextBoxMainForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNameTextBoxMainForm.UseSelectable = true;
            this.userNameTextBoxMainForm.WaterMark = "User Name";
            this.userNameTextBoxMainForm.WaterMarkColor = System.Drawing.Color.Red;
            this.userNameTextBoxMainForm.WaterMarkFont = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // passwordTextBoxMainForm
            // 
            // 
            // 
            // 
            this.passwordTextBoxMainForm.CustomButton.Image = null;
            this.passwordTextBoxMainForm.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.passwordTextBoxMainForm.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBoxMainForm.CustomButton.Name = "";
            this.passwordTextBoxMainForm.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.passwordTextBoxMainForm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBoxMainForm.CustomButton.TabIndex = 1;
            this.passwordTextBoxMainForm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBoxMainForm.CustomButton.UseSelectable = true;
            this.passwordTextBoxMainForm.CustomButton.Visible = false;
            this.passwordTextBoxMainForm.Lines = new string[0];
            this.passwordTextBoxMainForm.Location = new System.Drawing.Point(781, 164);
            this.passwordTextBoxMainForm.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBoxMainForm.MaxLength = 32767;
            this.passwordTextBoxMainForm.Name = "passwordTextBoxMainForm";
            this.passwordTextBoxMainForm.PasswordChar = '●';
            this.passwordTextBoxMainForm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBoxMainForm.SelectedText = "";
            this.passwordTextBoxMainForm.SelectionLength = 0;
            this.passwordTextBoxMainForm.SelectionStart = 0;
            this.passwordTextBoxMainForm.Size = new System.Drawing.Size(320, 37);
            this.passwordTextBoxMainForm.TabIndex = 11;
            this.passwordTextBoxMainForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBoxMainForm.UseSelectable = true;
            this.passwordTextBoxMainForm.UseSystemPasswordChar = true;
            this.passwordTextBoxMainForm.WaterMark = "Password";
            this.passwordTextBoxMainForm.WaterMarkColor = System.Drawing.Color.Red;
            this.passwordTextBoxMainForm.WaterMarkFont = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // passwordLabelMainForm
            // 
            this.passwordLabelMainForm.AutoSize = true;
            this.passwordLabelMainForm.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.passwordLabelMainForm.Location = new System.Drawing.Point(669, 170);
            this.passwordLabelMainForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabelMainForm.Name = "passwordLabelMainForm";
            this.passwordLabelMainForm.Size = new System.Drawing.Size(84, 20);
            this.passwordLabelMainForm.TabIndex = 9;
            this.passwordLabelMainForm.Text = "Password :";
            // 
            // userNameLabelMainForm
            // 
            this.userNameLabelMainForm.AutoSize = true;
            this.userNameLabelMainForm.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.userNameLabelMainForm.Location = new System.Drawing.Point(658, 98);
            this.userNameLabelMainForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabelMainForm.Name = "userNameLabelMainForm";
            this.userNameLabelMainForm.Size = new System.Drawing.Size(95, 20);
            this.userNameLabelMainForm.TabIndex = 8;
            this.userNameLabelMainForm.Text = "User Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 519);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(834, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sign In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1005, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Clear";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 656);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordTextBoxMainForm);
            this.Controls.Add(this.userNameTextBoxMainForm);
            this.Controls.Add(this.passwordLabelMainForm);
            this.Controls.Add(this.userNameLabelMainForm);
            this.Controls.Add(this.registerButtonMainForm);
            this.Controls.Add(this.clearButtonMainForm);
            this.Controls.Add(this.loginButtonMainForm);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Blood Bank Management System";
            this.TransparencyKey = System.Drawing.Color.SkyBlue;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton loginButtonMainForm;
        private MetroFramework.Controls.MetroButton clearButtonMainForm;
        private MetroFramework.Controls.MetroButton registerButtonMainForm;
        private MetroFramework.Controls.MetroTextBox userNameTextBoxMainForm;
        private MetroFramework.Controls.MetroTextBox passwordTextBoxMainForm;
        private MetroFramework.Controls.MetroLabel passwordLabelMainForm;
        private MetroFramework.Controls.MetroLabel userNameLabelMainForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

