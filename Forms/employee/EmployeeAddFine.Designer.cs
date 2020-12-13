namespace GIBDDFine.employeeFormsAndComponents
{
    partial class EmployeeAddFine
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddFineButton = new Guna.UI2.WinForms.Guna2Button();
            this.fioLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(579, 514);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(588, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 600);
            this.panel1.TabIndex = 4;
            // 
            // refreshButton
            // 
            this.refreshButton.CheckedState.Parent = this.refreshButton;
            this.refreshButton.CustomImages.Parent = this.refreshButton;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.HoverState.Parent = this.refreshButton;
            this.refreshButton.Location = new System.Drawing.Point(472, 56);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.ShadowDecoration.Parent = this.refreshButton;
            this.refreshButton.Size = new System.Drawing.Size(110, 21);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Обновить";
            // 
            // AddFineButton
            // 
            this.AddFineButton.CheckedState.Parent = this.AddFineButton;
            this.AddFineButton.CustomImages.Parent = this.AddFineButton;
            this.AddFineButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddFineButton.ForeColor = System.Drawing.Color.White;
            this.AddFineButton.HoverState.Parent = this.AddFineButton;
            this.AddFineButton.Location = new System.Drawing.Point(356, 56);
            this.AddFineButton.Name = "AddFineButton";
            this.AddFineButton.ShadowDecoration.Parent = this.AddFineButton;
            this.AddFineButton.Size = new System.Drawing.Size(110, 21);
            this.AddFineButton.TabIndex = 6;
            this.AddFineButton.Text = "Добавить штраф";
            this.AddFineButton.Click += new System.EventHandler(this.AddFineButton_Click);
            // 
            // fioLabel
            // 
            this.fioLabel.BackColor = System.Drawing.Color.Transparent;
            this.fioLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioLabel.Location = new System.Drawing.Point(3, 58);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(107, 19);
            this.fioLabel.TabIndex = 8;
            this.fioLabel.Text = "guna2HtmlLabel1";
            // 
            // EmployeeAddFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fioLabel);
            this.Controls.Add(this.AddFineButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EmployeeAddFine";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.EmployeeAddFine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button refreshButton;
        private Guna.UI2.WinForms.Guna2Button AddFineButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel fioLabel;
    }
}
