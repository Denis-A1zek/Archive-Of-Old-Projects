namespace Diplom.EasyTest.WinForms
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewQuiz = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadQuiz = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSetAnswer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkBoxAnswer1 = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkBoxAnswer2 = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkBoxAnswer3 = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.checkBoxAnswer4 = new System.Windows.Forms.CheckBox();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTesterName = new System.Windows.Forms.TextBox();
            this.buttonStartQuiz = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewQuiz,
            this.uploadQuiz});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // createNewQuiz
            // 
            this.createNewQuiz.BackColor = System.Drawing.Color.White;
            this.createNewQuiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createNewQuiz.Name = "createNewQuiz";
            this.createNewQuiz.Size = new System.Drawing.Size(161, 22);
            this.createNewQuiz.Text = "Создать тест";
            this.createNewQuiz.Click += new System.EventHandler(this.createNewQuiz_Click);
            // 
            // uploadQuiz
            // 
            this.uploadQuiz.BackColor = System.Drawing.Color.White;
            this.uploadQuiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uploadQuiz.Name = "uploadQuiz";
            this.uploadQuiz.Size = new System.Drawing.Size(161, 22);
            this.uploadQuiz.Text = "Загрузить тест";
            this.uploadQuiz.Click += new System.EventHandler(this.uploadQuiz_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(644, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(644, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.buttonSetAnswer);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 201);
            this.panel1.TabIndex = 4;
            // 
            // buttonSetAnswer
            // 
            this.buttonSetAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSetAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetAnswer.Font = new System.Drawing.Font("Rubik", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSetAnswer.Location = new System.Drawing.Point(29, 142);
            this.buttonSetAnswer.Name = "buttonSetAnswer";
            this.buttonSetAnswer.Size = new System.Drawing.Size(140, 36);
            this.buttonSetAnswer.TabIndex = 3;
            this.buttonSetAnswer.Text = "Следующий вопрос";
            this.buttonSetAnswer.UseVisualStyleBackColor = false;
            this.buttonSetAnswer.Click += new System.EventHandler(this.buttonSetAnswer_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.pictureBox);
            this.panel4.Location = new System.Drawing.Point(466, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 150);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxQuestion);
            this.panel3.Location = new System.Drawing.Point(29, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 109);
            this.panel3.TabIndex = 0;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQuestion.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxQuestion.Location = new System.Drawing.Point(0, 0);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(411, 109);
            this.textBoxQuestion.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 204);
            this.panel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(644, 204);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkBoxAnswer1);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(315, 93);
            this.panel5.TabIndex = 1;
            // 
            // checkBoxAnswer1
            // 
            this.checkBoxAnswer1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxAnswer1.AutoSize = true;
            this.checkBoxAnswer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxAnswer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxAnswer1.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.checkBoxAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAnswer1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAnswer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxAnswer1.Location = new System.Drawing.Point(0, 0);
            this.checkBoxAnswer1.Name = "checkBoxAnswer1";
            this.checkBoxAnswer1.Size = new System.Drawing.Size(315, 93);
            this.checkBoxAnswer1.TabIndex = 0;
            this.checkBoxAnswer1.Text = "checkBox1";
            this.checkBoxAnswer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAnswer1.UseVisualStyleBackColor = false;
            this.checkBoxAnswer1.Click += new System.EventHandler(this.checkBoxAnswer1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.checkBoxAnswer2);
            this.panel6.Location = new System.Drawing.Point(324, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(315, 93);
            this.panel6.TabIndex = 2;
            // 
            // checkBoxAnswer2
            // 
            this.checkBoxAnswer2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxAnswer2.AutoSize = true;
            this.checkBoxAnswer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxAnswer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxAnswer2.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.checkBoxAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAnswer2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAnswer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxAnswer2.Location = new System.Drawing.Point(0, 0);
            this.checkBoxAnswer2.Name = "checkBoxAnswer2";
            this.checkBoxAnswer2.Size = new System.Drawing.Size(315, 93);
            this.checkBoxAnswer2.TabIndex = 1;
            this.checkBoxAnswer2.Text = "checkBox2";
            this.checkBoxAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAnswer2.UseVisualStyleBackColor = false;
            this.checkBoxAnswer2.Click += new System.EventHandler(this.checkBoxAnswer1_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.checkBoxAnswer3);
            this.panel7.Location = new System.Drawing.Point(3, 102);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(315, 93);
            this.panel7.TabIndex = 3;
            // 
            // checkBoxAnswer3
            // 
            this.checkBoxAnswer3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxAnswer3.AutoSize = true;
            this.checkBoxAnswer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxAnswer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxAnswer3.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.checkBoxAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAnswer3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAnswer3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxAnswer3.Location = new System.Drawing.Point(0, 0);
            this.checkBoxAnswer3.Name = "checkBoxAnswer3";
            this.checkBoxAnswer3.Size = new System.Drawing.Size(315, 93);
            this.checkBoxAnswer3.TabIndex = 2;
            this.checkBoxAnswer3.Text = "checkBox3";
            this.checkBoxAnswer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAnswer3.UseVisualStyleBackColor = false;
            this.checkBoxAnswer3.Click += new System.EventHandler(this.checkBoxAnswer1_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.checkBoxAnswer4);
            this.panel8.Location = new System.Drawing.Point(324, 102);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(315, 93);
            this.panel8.TabIndex = 4;
            // 
            // checkBoxAnswer4
            // 
            this.checkBoxAnswer4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxAnswer4.AutoSize = true;
            this.checkBoxAnswer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBoxAnswer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxAnswer4.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.checkBoxAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAnswer4.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAnswer4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxAnswer4.Location = new System.Drawing.Point(0, 0);
            this.checkBoxAnswer4.Name = "checkBoxAnswer4";
            this.checkBoxAnswer4.Size = new System.Drawing.Size(315, 93);
            this.checkBoxAnswer4.TabIndex = 3;
            this.checkBoxAnswer4.Text = "checkBox4";
            this.checkBoxAnswer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAnswer4.UseVisualStyleBackColor = false;
            this.checkBoxAnswer4.Click += new System.EventHandler(this.checkBoxAnswer1_Click);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelMainMenu.Controls.Add(this.label1);
            this.panelMainMenu.Controls.Add(this.textBoxTesterName);
            this.panelMainMenu.Controls.Add(this.buttonStartQuiz);
            this.panelMainMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 24);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(641, 405);
            this.panelMainMenu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(156, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // textBoxTesterName
            // 
            this.textBoxTesterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxTesterName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTesterName.Font = new System.Drawing.Font("Rubik Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTesterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTesterName.Location = new System.Drawing.Point(159, 142);
            this.textBoxTesterName.Multiline = true;
            this.textBoxTesterName.Name = "textBoxTesterName";
            this.textBoxTesterName.Size = new System.Drawing.Size(339, 34);
            this.textBoxTesterName.TabIndex = 1;
            // 
            // buttonStartQuiz
            // 
            this.buttonStartQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonStartQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartQuiz.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartQuiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStartQuiz.Location = new System.Drawing.Point(268, 201);
            this.buttonStartQuiz.Name = "buttonStartQuiz";
            this.buttonStartQuiz.Size = new System.Drawing.Size(121, 31);
            this.buttonStartQuiz.TabIndex = 0;
            this.buttonStartQuiz.Text = "Начать тест";
            this.buttonStartQuiz.UseVisualStyleBackColor = false;
            this.buttonStartQuiz.Click += new System.EventHandler(this.buttonStartQuiz_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 451);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MaximumSize = new System.Drawing.Size(660, 490);
            this.MinimumSize = new System.Drawing.Size(660, 490);
            this.Name = "MainForm";
            this.Text = "Easy Test";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewQuiz;
        private System.Windows.Forms.ToolStripMenuItem uploadQuiz;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox checkBoxAnswer1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox checkBoxAnswer2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox checkBoxAnswer3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox checkBoxAnswer4;
        private System.Windows.Forms.Button buttonSetAnswer;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button buttonStartQuiz;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxTesterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

