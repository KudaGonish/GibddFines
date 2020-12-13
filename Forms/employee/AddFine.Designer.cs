namespace GIBDDFine.employeeFormsAndComponents
{
    partial class AddFine
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabelLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addFineButton = new Guna.UI2.WinForms.Guna2Button();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.gosNomerBox = new System.Windows.Forms.TextBox();
            this.costBox = new System.Windows.Forms.TextBox();
            this.brandBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Табельный номер сотрудника:";
            // 
            // tabelLabel
            // 
            this.tabelLabel.AutoSize = true;
            this.tabelLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabelLabel.Location = new System.Drawing.Point(152, 40);
            this.tabelLabel.Name = "tabelLabel";
            this.tabelLabel.Size = new System.Drawing.Size(57, 21);
            this.tabelLabel.TabIndex = 0;
            this.tabelLabel.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Государственный номер автомобиля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(112, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Марка автомобиля";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(121, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Сумма штрафа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(111, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Описание штрафа";
            // 
            // addFineButton
            // 
            this.addFineButton.CheckedState.Parent = this.addFineButton;
            this.addFineButton.CustomImages.Parent = this.addFineButton;
            this.addFineButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addFineButton.ForeColor = System.Drawing.Color.White;
            this.addFineButton.HoverState.Parent = this.addFineButton;
            this.addFineButton.Location = new System.Drawing.Point(90, 415);
            this.addFineButton.Name = "addFineButton";
            this.addFineButton.ShadowDecoration.Parent = this.addFineButton;
            this.addFineButton.Size = new System.Drawing.Size(180, 45);
            this.addFineButton.TabIndex = 2;
            this.addFineButton.Text = "Добавить штраф";
            this.addFineButton.Click += new System.EventHandler(this.addFineButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.infoBox.Location = new System.Drawing.Point(12, 268);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(341, 141);
            this.infoBox.TabIndex = 4;
            // 
            // gosNomerBox
            // 
            this.gosNomerBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gosNomerBox.Location = new System.Drawing.Point(122, 93);
            this.gosNomerBox.Multiline = true;
            this.gosNomerBox.Name = "gosNomerBox";
            this.gosNomerBox.Size = new System.Drawing.Size(119, 24);
            this.gosNomerBox.TabIndex = 4;
            // 
            // costBox
            // 
            this.costBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.costBox.Location = new System.Drawing.Point(122, 205);
            this.costBox.Multiline = true;
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(119, 24);
            this.costBox.TabIndex = 4;
            // 
            // brandBox
            // 
            this.brandBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.brandBox.Location = new System.Drawing.Point(122, 148);
            this.brandBox.Multiline = true;
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(119, 24);
            this.brandBox.TabIndex = 4;
            // 
            // AddFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 473);
            this.Controls.Add(this.brandBox);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.gosNomerBox);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.addFineButton);
            this.Controls.Add(this.tabelLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFine";
            this.Text = "ч";
            this.Load += new System.EventHandler(this.AddFine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tabelLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button addFineButton;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.TextBox gosNomerBox;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.TextBox brandBox;
    }
}