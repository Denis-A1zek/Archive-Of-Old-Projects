namespace IntersectionPoint.View
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(12D, 5D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 7D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(11D, 3D);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.valueLine1Point2Y = new System.Windows.Forms.TextBox();
            this.valueLine1Point2X = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.valueLine1Point1Y = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.valueLine1Point1X = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.valueLine2Point2Y = new System.Windows.Forms.TextBox();
            this.valueLine2Point2X = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.valueLine2Point1Y = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.valueLine2Point1X = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_FindCross = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 463);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.button_FindCross);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(170, 431);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.valueLine1Point2Y);
            this.panel5.Controls.Add(this.valueLine1Point2X);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 104);
            this.panel5.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.label14.Location = new System.Drawing.Point(102, 67);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label14.Size = new System.Drawing.Size(24, 31);
            this.label14.TabIndex = 9;
            this.label14.Text = "Y:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // valueLine1Point2Y
            // 
            this.valueLine1Point2Y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valueLine1Point2Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.valueLine1Point2Y.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueLine1Point2Y.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLine1Point2Y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.valueLine1Point2Y.Location = new System.Drawing.Point(122, 71);
            this.valueLine1Point2Y.Name = "valueLine1Point2Y";
            this.valueLine1Point2Y.Size = new System.Drawing.Size(23, 22);
            this.valueLine1Point2Y.TabIndex = 8;
            this.valueLine1Point2Y.Text = "0";
            this.valueLine1Point2Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueLine1Point2Y.TextChanged += new System.EventHandler(this.button_FindCross_Click);
            // 
            // valueLine1Point2X
            // 
            this.valueLine1Point2X.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valueLine1Point2X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.valueLine1Point2X.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueLine1Point2X.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLine1Point2X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.valueLine1Point2X.Location = new System.Drawing.Point(78, 71);
            this.valueLine1Point2X.Name = "valueLine1Point2X";
            this.valueLine1Point2X.Size = new System.Drawing.Size(23, 22);
            this.valueLine1Point2X.TabIndex = 7;
            this.valueLine1Point2X.Text = "0";
            this.valueLine1Point2X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueLine1Point2X.TextChanged += new System.EventHandler(this.button_FindCross_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.label7.Location = new System.Drawing.Point(143, 67);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(57, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "]          ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.label6.Location = new System.Drawing.Point(0, 67);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label6.Size = new System.Drawing.Size(83, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Point 2 [ X:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.valueLine1Point1Y);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.valueLine1Point1X);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 67);
            this.panel2.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.label15.Location = new System.Drawing.Point(102, 28);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label15.Size = new System.Drawing.Size(24, 31);
            this.label15.TabIndex = 10;
            this.label15.Text = "Y:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // valueLine1Point1Y
            // 
            this.valueLine1Point1Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.valueLine1Point1Y.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueLine1Point1Y.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLine1Point1Y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.valueLine1Point1Y.Location = new System.Drawing.Point(123, 30);
            this.valueLine1Point1Y.Name = "valueLine1Point1Y";
            this.valueLine1Point1Y.Size = new System.Drawing.Size(23, 22);
            this.valueLine1Point1Y.TabIndex = 6;
            this.valueLine1Point1Y.Text = "0";
            this.valueLine1Point1Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueLine1Point1Y.TextChanged += new System.EventHandler(this.button_FindCross_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.label5.Location = new System.Drawing.Point(143, 26);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(57, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "]          ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valueLine1Point1X
            // 
            this.valueLine1Point1X.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valueLine1Point1X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.valueLine1Point1X.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueLine1Point1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valueLine1Point1X.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLine1Point1X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.valueLine1Point1X.Location = new System.Drawing.Point(77, 30);
            this.valueLine1Point1X.Name = "valueLine1Point1X";
            this.valueLine1Point1X.Size = new System.Drawing.Size(23, 22);
            this.valueLine1Point1X.TabIndex = 5;
            this.valueLine1Point1X.Text = "0";
            this.valueLine1Point1X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueLine1Point1X.TextChanged += new System.EventHandler(this.button_FindCross_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.label4.Location = new System.Drawing.Point(0, 26);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Point 1 [ X:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 26);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(23, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "First line";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::IntersectionPoint.View.Properties.Resources.chart;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(100)))), ((int)(((byte)(108)))));
            this.panel9.Location = new System.Drawing.Point(20, 113);
            this.panel9.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(131, 2);
            this.panel9.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.valueLine2Point2Y);
            this.panel6.Controls.Add(this.valueLine2Point2X);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(3, 121);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 111);
            this.panel6.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.label13.Location = new System.Drawing.Point(102, 67);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label13.Size = new System.Drawing.Size(24, 31);
            this.label13.TabIndex = 8;
            this.label13.Text = "Y:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // valueLine2Point2Y
            // 
            this.valueLine2Point2Y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valueLine2Point2Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.valueLine2Point2Y.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueLine2Point2Y.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLine2Point2Y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.valueLine2Point2Y.Location = new System.Drawing.Point(122, 71);
            this.valueLine2Point2Y.Name = "valueLine2Point2Y";
            this.valueLine2Point2Y.Size = new System.Drawing.Size(23, 22);
            this.valueLine2Point2Y.TabIndex = 8;
            this.valueLine2Point2Y.Text = "0";
            this.valueLine2Point2Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueLine2Point2Y.TextChanged += new System.EventHandler(this.button_FindCross_Click);
            // 
            // valueLine2Point2X
            // 
            this.valueLine2Point2X.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valueLine2Point2X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.valueLine2Point2X.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueLine2Point2X.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLine2Point2X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.valueLine2Point2X.Location = new System.Drawing.Point(78, 71);
            this.valueLine2Point2X.Name = "valueLine2Point2X";
            this.valueLine2Point2X.Size = new System.Drawing.Size(23, 22);
            this.valueLine2Point2X.TabIndex = 7;
            this.valueLine2Point2X.Text = "0";
            this.valueLine2Point2X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueLine2Point2X.TextChanged += new System.EventHandler(this.button_FindCross_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.label8.Location = new System.Drawing.Point(143, 67);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(57, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "]          ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.label9.Location = new System.Drawing.Point(0, 67);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label9.Size = new System.Drawing.Size(83, 31);
            this.label9.TabIndex = 7;
            this.label9.Text = "Point 2 [ X:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.valueLine2Point1Y);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.valueLine2Point1X);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 67);
            this.panel7.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(102, 26);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label2.Size = new System.Drawing.Size(24, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // valueLine2Point1Y
            // 
            this.valueLine2Point1Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.valueLine2Point1Y.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueLine2Point1Y.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLine2Point1Y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.valueLine2Point1Y.Location = new System.Drawing.Point(123, 30);
            this.valueLine2Point1Y.Name = "valueLine2Point1Y";
            this.valueLine2Point1Y.Size = new System.Drawing.Size(23, 22);
            this.valueLine2Point1Y.TabIndex = 6;
            this.valueLine2Point1Y.Text = "0";
            this.valueLine2Point1Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueLine2Point1Y.TextChanged += new System.EventHandler(this.button_FindCross_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.label10.Location = new System.Drawing.Point(143, 26);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(57, 31);
            this.label10.TabIndex = 5;
            this.label10.Text = "]          ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valueLine2Point1X
            // 
            this.valueLine2Point1X.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valueLine2Point1X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.valueLine2Point1X.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueLine2Point1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valueLine2Point1X.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLine2Point1X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.valueLine2Point1X.Location = new System.Drawing.Point(77, 30);
            this.valueLine2Point1X.Name = "valueLine2Point1X";
            this.valueLine2Point1X.Size = new System.Drawing.Size(23, 22);
            this.valueLine2Point1X.TabIndex = 5;
            this.valueLine2Point1X.Text = "0";
            this.valueLine2Point1X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueLine2Point1X.TextChanged += new System.EventHandler(this.button_FindCross_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.label11.Location = new System.Drawing.Point(0, 26);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label11.Size = new System.Drawing.Size(83, 31);
            this.label11.TabIndex = 4;
            this.label11.Text = "Point 1 [ X:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.pictureBox2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 26);
            this.panel8.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.label12.Location = new System.Drawing.Point(23, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Second line";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::IntersectionPoint.View.Properties.Resources.chart;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button_FindCross
            // 
            this.button_FindCross.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.button_FindCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FindCross.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_FindCross.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.button_FindCross.Location = new System.Drawing.Point(3, 238);
            this.button_FindCross.Name = "button_FindCross";
            this.button_FindCross.Size = new System.Drawing.Size(167, 50);
            this.button_FindCross.TabIndex = 10;
            this.button_FindCross.Text = "FIND";
            this.button_FindCross.UseVisualStyleBackColor = true;
            this.button_FindCross.Click += new System.EventHandler(this.button_FindCross_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 32);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(100)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Line entry";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chartFunction
            // 
            this.chartFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(100)))), ((int)(((byte)(108)))));
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Noto Sans", 9F);
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(100)))), ((int)(((byte)(108)))));
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "Y";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Noto Sans", 9F);
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Noto Sans", 9F);
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.chartFunction.ChartAreas.Add(chartArea1);
            this.chartFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartFunction.Location = new System.Drawing.Point(173, 3);
            this.chartFunction.Margin = new System.Windows.Forms.Padding(20);
            this.chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "line1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "line2";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Name = "pointCross";
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartFunction.Series.Add(series1);
            this.chartFunction.Series.Add(series2);
            this.chartFunction.Series.Add(series3);
            this.chartFunction.Size = new System.Drawing.Size(521, 463);
            this.chartFunction.TabIndex = 1;
            this.chartFunction.Text = "chartFunction";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 469);
            this.Controls.Add(this.chartFunction);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "CrossPointFinder";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valueLine1Point1Y;
        private System.Windows.Forms.TextBox valueLine1Point1X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox valueLine1Point2Y;
        private System.Windows.Forms.TextBox valueLine1Point2X;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox valueLine2Point2Y;
        private System.Windows.Forms.TextBox valueLine2Point2X;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox valueLine2Point1Y;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox valueLine2Point1X;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_FindCross;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
    }
}

