namespace DotPad.View
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarItemExtension = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxRealm = new System.Windows.Forms.TextBox();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(80)))), ((int)(((byte)(83)))));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarItemExtension,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusBar.Location = new System.Drawing.Point(0, 395);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(703, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarItemExtension
            // 
            this.statusBarItemExtension.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBarItemExtension.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusBarItemExtension.Name = "statusBarItemExtension";
            this.statusBarItemExtension.Size = new System.Drawing.Size(73, 17);
            this.statusBarItemExtension.Text = "DotPad: txt";
            this.statusBarItemExtension.Click += new System.EventHandler(this.statusBarItemExtension_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel2.Text = "Ln 0, Col 0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel3.Text = "UTF-8";
            // 
            // textBoxRealm
            // 
            this.textBoxRealm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxRealm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRealm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRealm.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRealm.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxRealm.Location = new System.Drawing.Point(0, 0);
            this.textBoxRealm.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRealm.Multiline = true;
            this.textBoxRealm.Name = "textBoxRealm";
            this.textBoxRealm.Size = new System.Drawing.Size(703, 395);
            this.textBoxRealm.TabIndex = 1;
            this.textBoxRealm.TextChanged += new System.EventHandler(this.textBoxRealm_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 417);
            this.Controls.Add(this.textBoxRealm);
            this.Controls.Add(this.statusBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotPad";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.TextBox textBoxRealm;
        private System.Windows.Forms.ToolStripStatusLabel statusBarItemExtension;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

