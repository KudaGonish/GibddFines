namespace GIBDDFine.Forms.driver
{
    partial class InfoAboutFine
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
            this.tnLabel = new System.Windows.Forms.Label();
            this.gsLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.opLabel = new System.Windows.Forms.Label();
            this.suLabel = new System.Windows.Forms.Label();
            this.sLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.payButton = new Guna.UI2.WinForms.Guna2Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.markLabel = new System.Windows.Forms.Label();
            this.gosNumLabel = new System.Windows.Forms.Label();
            this.tabelLabel = new System.Windows.Forms.Label();
            this.opisanieBox = new System.Windows.Forms.TextBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.SuspendLayout();
            // 
            // tnLabel
            // 
            this.tnLabel.AutoSize = true;
            this.tnLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tnLabel.Location = new System.Drawing.Point(23, 25);
            this.tnLabel.Name = "tnLabel";
            this.tnLabel.Size = new System.Drawing.Size(305, 23);
            this.tnLabel.TabIndex = 0;
            this.tnLabel.Text = "Табельный номер сотрудника:";
            // 
            // gsLabel
            // 
            this.gsLabel.AutoSize = true;
            this.gsLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gsLabel.Location = new System.Drawing.Point(23, 71);
            this.gsLabel.Name = "gsLabel";
            this.gsLabel.Size = new System.Drawing.Size(257, 23);
            this.gsLabel.TabIndex = 1;
            this.gsLabel.Text = "Государственный номер:";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mLabel.Location = new System.Drawing.Point(23, 117);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(201, 23);
            this.mLabel.TabIndex = 2;
            this.mLabel.Text = "Марка автомобиля:";
            // 
            // opLabel
            // 
            this.opLabel.AutoSize = true;
            this.opLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opLabel.Location = new System.Drawing.Point(23, 209);
            this.opLabel.Name = "opLabel";
            this.opLabel.Size = new System.Drawing.Size(273, 23);
            this.opLabel.TabIndex = 3;
            this.opLabel.Text = "Полное описание штрафа:";
            // 
            // suLabel
            // 
            this.suLabel.AutoSize = true;
            this.suLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.suLabel.Location = new System.Drawing.Point(23, 452);
            this.suLabel.Name = "suLabel";
            this.suLabel.Size = new System.Drawing.Size(172, 23);
            this.suLabel.TabIndex = 4;
            this.suLabel.Text = "Сумма к оплате:";
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sLabel.Location = new System.Drawing.Point(23, 406);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(177, 23);
            this.sLabel.TabIndex = 5;
            this.sLabel.Text = "Статус Штрафа:";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dLabel.Location = new System.Drawing.Point(23, 163);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(251, 23);
            this.dLabel.TabIndex = 6;
            this.dLabel.Text = "Дата создания штрафа:";
            // 
            // payButton
            // 
            this.payButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.payButton.CheckedState.Parent = this.payButton;
            this.payButton.CustomImages.Parent = this.payButton;
            this.payButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.payButton.ForeColor = System.Drawing.Color.White;
            this.payButton.HoverState.Parent = this.payButton;
            this.payButton.Location = new System.Drawing.Point(23, 488);
            this.payButton.Name = "payButton";
            this.payButton.ShadowDecoration.Parent = this.payButton;
            this.payButton.Size = new System.Drawing.Size(415, 66);
            this.payButton.TabIndex = 7;
            this.payButton.Text = "Оплатить штраф";
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(329, 163);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(110, 22);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "12-11-2020";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(329, 406);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(130, 22);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Не оплачено";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumLabel.Location = new System.Drawing.Point(329, 452);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(43, 22);
            this.sumLabel.TabIndex = 11;
            this.sumLabel.Text = "500";
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markLabel.Location = new System.Drawing.Point(329, 117);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(87, 22);
            this.markLabel.TabIndex = 10;
            this.markLabel.Text = "автоубс";
            // 
            // gosNumLabel
            // 
            this.gosNumLabel.AutoSize = true;
            this.gosNumLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gosNumLabel.Location = new System.Drawing.Point(329, 71);
            this.gosNumLabel.Name = "gosNumLabel";
            this.gosNumLabel.Size = new System.Drawing.Size(74, 22);
            this.gosNumLabel.TabIndex = 9;
            this.gosNumLabel.Text = "у231ув";
            // 
            // tabelLabel
            // 
            this.tabelLabel.AutoSize = true;
            this.tabelLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabelLabel.Location = new System.Drawing.Point(329, 25);
            this.tabelLabel.Name = "tabelLabel";
            this.tabelLabel.Size = new System.Drawing.Size(43, 22);
            this.tabelLabel.TabIndex = 8;
            this.tabelLabel.Text = "213";
            // 
            // opisanieBox
            // 
            this.opisanieBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opisanieBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opisanieBox.Location = new System.Drawing.Point(23, 255);
            this.opisanieBox.Multiline = true;
            this.opisanieBox.Name = "opisanieBox";
            this.opisanieBox.Size = new System.Drawing.Size(415, 128);
            this.opisanieBox.TabIndex = 14;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(323, 25);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 450);
            this.guna2VSeparator1.TabIndex = 15;
            // 
            // InfoAboutFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 566);
            this.Controls.Add(this.opisanieBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.gosNumLabel);
            this.Controls.Add(this.tabelLabel);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.suLabel);
            this.Controls.Add(this.opLabel);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.gsLabel);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.tnLabel);
            this.Name = "InfoAboutFine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подробная информация о штрафе";
            this.Load += new System.EventHandler(this.InfoAboutFine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tnLabel;
        private System.Windows.Forms.Label gsLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label opLabel;
        private System.Windows.Forms.Label suLabel;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.Label dLabel;
        private Guna.UI2.WinForms.Guna2Button payButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.Label gosNumLabel;
        private System.Windows.Forms.Label tabelLabel;
        private System.Windows.Forms.TextBox opisanieBox;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
    }
}