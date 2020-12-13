namespace GIBDDFine
{
    partial class DriverViewInfoAboutCars
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.fioLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(3, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Вернуться к выбору";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 417);
            this.dataGridView1.TabIndex = 2;
            // 
            // refreshButton
            // 
            this.refreshButton.CheckedState.Parent = this.refreshButton;
            this.refreshButton.CustomImages.Parent = this.refreshButton;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.HoverState.Parent = this.refreshButton;
            this.refreshButton.Location = new System.Drawing.Point(748, 121);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.ShadowDecoration.Parent = this.refreshButton;
            this.refreshButton.Size = new System.Drawing.Size(110, 21);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // fioLabel
            // 
            this.fioLabel.BackColor = System.Drawing.Color.Transparent;
            this.fioLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioLabel.Location = new System.Drawing.Point(109, 110);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(210, 32);
            this.fioLabel.TabIndex = 7;
            this.fioLabel.Text = "guna2HtmlLabel1";
            // 
            // DriverViewInfoAboutCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fioLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2Button1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DriverViewInfoAboutCars";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.DriverViewInfoAboutCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button refreshButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel fioLabel;
    }
}
