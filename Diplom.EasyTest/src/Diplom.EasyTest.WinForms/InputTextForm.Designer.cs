namespace Diplom.EasyTest.WinForms
{
    partial class InputTextForm
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
            this.textBoxQuizName = new System.Windows.Forms.TextBox();
            this.buttonConfirmStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxQuizName
            // 
            this.textBoxQuizName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxQuizName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuizName.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuizName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxQuizName.Location = new System.Drawing.Point(28, 31);
            this.textBoxQuizName.Name = "textBoxQuizName";
            this.textBoxQuizName.Size = new System.Drawing.Size(211, 26);
            this.textBoxQuizName.TabIndex = 0;
            // 
            // buttonConfirmStart
            // 
            this.buttonConfirmStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonConfirmStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonConfirmStart.Location = new System.Drawing.Point(95, 72);
            this.buttonConfirmStart.Name = "buttonConfirmStart";
            this.buttonConfirmStart.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmStart.TabIndex = 1;
            this.buttonConfirmStart.Text = "Создать";
            this.buttonConfirmStart.UseVisualStyleBackColor = false;
            this.buttonConfirmStart.Click += new System.EventHandler(this.buttonConfirmStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите название теста";
            // 
            // InputTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(271, 113);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirmStart);
            this.Controls.Add(this.textBoxQuizName);
            this.MaximumSize = new System.Drawing.Size(287, 152);
            this.MinimumSize = new System.Drawing.Size(287, 152);
            this.Name = "InputTextForm";
            this.Text = "Название теста";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputTextForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuizName;
        private System.Windows.Forms.Button buttonConfirmStart;
        private System.Windows.Forms.Label label1;
    }
}