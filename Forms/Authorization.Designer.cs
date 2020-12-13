namespace GIBDDFine
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.label1 = new System.Windows.Forms.Label();
            this.enterButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать!";
            // 
            // enterButton
            // 
            this.enterButton.CheckedState.Parent = this.enterButton;
            this.enterButton.CustomImages.Parent = this.enterButton;
            this.enterButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.HoverState.Parent = this.enterButton;
            this.enterButton.Location = new System.Drawing.Point(21, 289);
            this.enterButton.Name = "enterButton";
            this.enterButton.ShadowDecoration.Parent = this.enterButton;
            this.enterButton.Size = new System.Drawing.Size(265, 45);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Войти";
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Пароль:";
            // 
            // loginBox
            // 
            this.loginBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginBox.DefaultText = "";
            this.loginBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginBox.DisabledState.Parent = this.loginBox;
            this.loginBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginBox.FocusedState.Parent = this.loginBox;
            this.loginBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginBox.HoverState.Parent = this.loginBox;
            this.loginBox.Location = new System.Drawing.Point(21, 130);
            this.loginBox.Name = "loginBox";
            this.loginBox.PasswordChar = '\0';
            this.loginBox.PlaceholderText = "";
            this.loginBox.SelectedText = "";
            this.loginBox.ShadowDecoration.Parent = this.loginBox;
            this.loginBox.Size = new System.Drawing.Size(265, 37);
            this.loginBox.TabIndex = 4;
            // 
            // passwordBox
            // 
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.DefaultText = "";
            this.passwordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.DisabledState.Parent = this.passwordBox;
            this.passwordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.FocusedState.Parent = this.passwordBox;
            this.passwordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.HoverState.Parent = this.passwordBox;
            this.passwordBox.Location = new System.Drawing.Point(21, 212);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.PlaceholderText = "";
            this.passwordBox.SelectedText = "";
            this.passwordBox.ShadowDecoration.Parent = this.passwordBox;
            this.passwordBox.Size = new System.Drawing.Size(265, 37);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 346);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button enterButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox loginBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordBox;
    }
}

