namespace GIBDDFine
{
    partial class DriverViewFine
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.finesGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.moreInffoButton = new Guna.UI2.WinForms.Guna2Button();
            this.filterBox = new Guna.UI.WinForms.GunaComboBox();
            this.tipForButtons = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.finesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // finesGridView
            // 
            this.finesGridView.AllowUserToAddRows = false;
            this.finesGridView.AllowUserToDeleteRows = false;
            this.finesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.finesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.finesGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.finesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.finesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.finesGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.finesGridView.Location = new System.Drawing.Point(3, 43);
            this.finesGridView.Name = "finesGridView";
            this.finesGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.finesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.finesGridView.Size = new System.Drawing.Size(773, 558);
            this.finesGridView.TabIndex = 1;
            this.finesGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.finesGridView_DataBindingComplete);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.CheckedState.Parent = this.refreshButton;
            this.refreshButton.CustomImages.Parent = this.refreshButton;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.HoverState.Parent = this.refreshButton;
            this.refreshButton.Location = new System.Drawing.Point(662, 9);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.ShadowDecoration.Parent = this.refreshButton;
            this.refreshButton.Size = new System.Drawing.Size(110, 21);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // moreInffoButton
            // 
            this.moreInffoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moreInffoButton.CheckedState.Parent = this.moreInffoButton;
            this.moreInffoButton.CustomImages.Parent = this.moreInffoButton;
            this.moreInffoButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.moreInffoButton.ForeColor = System.Drawing.Color.White;
            this.moreInffoButton.HoverState.Parent = this.moreInffoButton;
            this.moreInffoButton.Location = new System.Drawing.Point(546, 9);
            this.moreInffoButton.Name = "moreInffoButton";
            this.moreInffoButton.ShadowDecoration.Parent = this.moreInffoButton;
            this.moreInffoButton.Size = new System.Drawing.Size(110, 21);
            this.moreInffoButton.TabIndex = 6;
            this.moreInffoButton.Text = "Подробнее";
            this.tipForButtons.SetToolTip(this.moreInffoButton, "Что бы увидеть информацию подробнее, выберите строку в таблице");
            this.moreInffoButton.Click += new System.EventHandler(this.moreInffoButton_Click);
            // 
            // filterBox
            // 
            this.filterBox.BackColor = System.Drawing.Color.Transparent;
            this.filterBox.BaseColor = System.Drawing.Color.White;
            this.filterBox.BorderColor = System.Drawing.Color.Silver;
            this.filterBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox.FocusedColor = System.Drawing.Color.Empty;
            this.filterBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterBox.ForeColor = System.Drawing.Color.Black;
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Items.AddRange(new object[] {
            "Все",
            "Оплачено",
            "Не оплачено"});
            this.filterBox.Location = new System.Drawing.Point(4, 7);
            this.filterBox.Name = "filterBox";
            this.filterBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.filterBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.filterBox.Size = new System.Drawing.Size(110, 26);
            this.filterBox.TabIndex = 7;
            this.filterBox.SelectedIndexChanged += new System.EventHandler(this.filterBox_SelectedIndexChanged);
            // 
            // DriverViewFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.moreInffoButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.finesGridView);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DriverViewFine";
            this.Size = new System.Drawing.Size(779, 600);
            this.Load += new System.EventHandler(this.DriverViewFine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView finesGridView;
        private Guna.UI2.WinForms.Guna2Button refreshButton;
        private Guna.UI2.WinForms.Guna2Button moreInffoButton;
        private Guna.UI.WinForms.GunaComboBox filterBox;
        private System.Windows.Forms.ToolTip tipForButtons;
    }
}
