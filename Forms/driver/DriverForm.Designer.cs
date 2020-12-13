namespace GIBDDFine
{
    partial class DriverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverForm));
            this.navigatePanel = new System.Windows.Forms.Panel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.chekFine = new Guna.UI2.WinForms.Guna2Button();
            this.ViewInfoCar = new Guna.UI2.WinForms.Guna2Button();
            this.componentPanel = new System.Windows.Forms.Panel();
            this.navigatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // navigatePanel
            // 
            this.navigatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.navigatePanel.BackColor = System.Drawing.Color.White;
            this.navigatePanel.Controls.Add(this.logoBox);
            this.navigatePanel.Controls.Add(this.chekFine);
            this.navigatePanel.Controls.Add(this.ViewInfoCar);
            this.navigatePanel.Location = new System.Drawing.Point(0, 0);
            this.navigatePanel.Name = "navigatePanel";
            this.navigatePanel.Size = new System.Drawing.Size(221, 600);
            this.navigatePanel.TabIndex = 11;
            // 
            // logoBox
            // 
            this.logoBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logoBox.Image = global::GIBDDFine.Properties.Resources.логоГибдд;
            this.logoBox.Location = new System.Drawing.Point(3, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(215, 179);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 9;
            this.logoBox.TabStop = false;
            // 
            // chekFine
            // 
            this.chekFine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chekFine.CheckedState.Parent = this.chekFine;
            this.chekFine.CustomImages.Parent = this.chekFine;
            this.chekFine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chekFine.ForeColor = System.Drawing.Color.White;
            this.chekFine.HoverState.Parent = this.chekFine;
            this.chekFine.Location = new System.Drawing.Point(0, 472);
            this.chekFine.Name = "chekFine";
            this.chekFine.ShadowDecoration.Parent = this.chekFine;
            this.chekFine.Size = new System.Drawing.Size(220, 60);
            this.chekFine.TabIndex = 8;
            this.chekFine.Text = "Проверить штрафы";
            this.chekFine.Click += new System.EventHandler(this.chekFine_Click);
            // 
            // ViewInfoCar
            // 
            this.ViewInfoCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewInfoCar.CheckedState.Parent = this.ViewInfoCar;
            this.ViewInfoCar.CustomImages.Parent = this.ViewInfoCar;
            this.ViewInfoCar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ViewInfoCar.ForeColor = System.Drawing.Color.White;
            this.ViewInfoCar.HoverState.Parent = this.ViewInfoCar;
            this.ViewInfoCar.Location = new System.Drawing.Point(1, 538);
            this.ViewInfoCar.Name = "ViewInfoCar";
            this.ViewInfoCar.ShadowDecoration.Parent = this.ViewInfoCar;
            this.ViewInfoCar.Size = new System.Drawing.Size(220, 60);
            this.ViewInfoCar.TabIndex = 7;
            this.ViewInfoCar.Text = "Информация о ваших автомобилях";
            // 
            // componentPanel
            // 
            this.componentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentPanel.BackColor = System.Drawing.Color.White;
            this.componentPanel.Location = new System.Drawing.Point(221, 0);
            this.componentPanel.Name = "componentPanel";
            this.componentPanel.Size = new System.Drawing.Size(779, 600);
            this.componentPanel.TabIndex = 12;
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.componentPanel);
            this.Controls.Add(this.navigatePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1016, 635);
            this.Name = "DriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DriverForm_Load);
            this.navigatePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigatePanel;
        private System.Windows.Forms.PictureBox logoBox;
        private Guna.UI2.WinForms.Guna2Button chekFine;
        private Guna.UI2.WinForms.Guna2Button ViewInfoCar;
        private System.Windows.Forms.Panel componentPanel;
    }
}