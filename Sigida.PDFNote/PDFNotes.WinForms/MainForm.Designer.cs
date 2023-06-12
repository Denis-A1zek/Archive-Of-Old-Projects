namespace PDFNotes.WinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sizeChecker = new System.Windows.Forms.CheckBox();
            this.convertToPDF = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 541);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 506);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.panel4.Controls.Add(this.addImage);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.deleteList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 35);
            this.panel4.TabIndex = 0;
            // 
            // addImage
            // 
            this.addImage.BackColor = System.Drawing.Color.Transparent;
            this.addImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.addImage.FlatAppearance.BorderSize = 0;
            this.addImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.addImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.addImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImage.Image = global::PDFNotes.WinForms.Properties.Resources.plus;
            this.addImage.Location = new System.Drawing.Point(150, 0);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(30, 35);
            this.addImage.TabIndex = 2;
            this.addImage.UseVisualStyleBackColor = false;
            this.addImage.Click += new System.EventHandler(this.addImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image: ";
            // 
            // deleteList
            // 
            this.deleteList.BackColor = System.Drawing.Color.Transparent;
            this.deleteList.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteList.FlatAppearance.BorderSize = 0;
            this.deleteList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.deleteList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.deleteList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteList.Image = global::PDFNotes.WinForms.Properties.Resources.delete;
            this.deleteList.Location = new System.Drawing.Point(180, 0);
            this.deleteList.Name = "deleteList";
            this.deleteList.Size = new System.Drawing.Size(30, 35);
            this.deleteList.TabIndex = 1;
            this.deleteList.UseVisualStyleBackColor = false;
            this.deleteList.Click += new System.EventHandler(this.deleteList_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.sizeChecker);
            this.panel2.Controls.Add(this.convertToPDF);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(211, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 35);
            this.panel2.TabIndex = 3;
            // 
            // sizeChecker
            // 
            this.sizeChecker.AutoSize = true;
            this.sizeChecker.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.sizeChecker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.sizeChecker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.sizeChecker.Font = new System.Drawing.Font("Noto Sans", 8F);
            this.sizeChecker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.sizeChecker.Location = new System.Drawing.Point(6, 6);
            this.sizeChecker.Name = "sizeChecker";
            this.sizeChecker.Size = new System.Drawing.Size(82, 23);
            this.sizeChecker.TabIndex = 4;
            this.sizeChecker.Text = "Minimized";
            this.sizeChecker.UseVisualStyleBackColor = true;
            // 
            // convertToPDF
            // 
            this.convertToPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.convertToPDF.FlatAppearance.BorderSize = 0;
            this.convertToPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.convertToPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.convertToPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertToPDF.Font = new System.Drawing.Font("Noto Sans", 11F);
            this.convertToPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.convertToPDF.Location = new System.Drawing.Point(335, 0);
            this.convertToPDF.Name = "convertToPDF";
            this.convertToPDF.Size = new System.Drawing.Size(87, 35);
            this.convertToPDF.TabIndex = 3;
            this.convertToPDF.Text = "Convert";
            this.convertToPDF.UseVisualStyleBackColor = false;
            this.convertToPDF.Click += new System.EventHandler(this.convertToPDF_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(211, 35);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(423, 506);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(211, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(423, 1);
            this.panel5.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(210, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 541);
            this.panel3.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(634, 541);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(650, 580);
            this.MinimumSize = new System.Drawing.Size(650, 580);
            this.Name = "MainForm";
            this.Text = "PDFNotes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteList;
        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button convertToPDF;
        private System.Windows.Forms.CheckBox sizeChecker;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
    }
}

