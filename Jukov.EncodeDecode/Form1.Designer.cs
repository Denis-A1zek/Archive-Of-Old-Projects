
namespace Jukov.EncodeDecode
{
    partial class Encode
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encode));
            this.formElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.controlPanel = new System.Windows.Forms.Panel();
            this.openButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.textModeVisible = new System.Windows.Forms.Label();
            this.closeApplication = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.textMailBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxKey = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonVigenere = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonOpenCaesar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.switchModeCipher = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.textBoxEncoder = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.textSecondBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.buttonEncode = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeApplication)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // formElipse
            // 
            this.formElipse.ElipseRadius = 5;
            this.formElipse.TargetControl = this;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(107)))));
            this.controlPanel.Controls.Add(this.openButton);
            this.controlPanel.Controls.Add(this.textModeVisible);
            this.controlPanel.Controls.Add(this.closeApplication);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(800, 25);
            this.controlPanel.TabIndex = 0;
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.Transparent;
            this.openButton.Image = global::Jukov.EncodeDecode.Properties.Resources.download;
            this.openButton.ImageActive = null;
            this.openButton.Location = new System.Drawing.Point(170, 5);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(15, 15);
            this.openButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openButton.TabIndex = 3;
            this.openButton.TabStop = false;
            this.openButton.Zoom = 10;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // textModeVisible
            // 
            this.textModeVisible.AutoSize = true;
            this.textModeVisible.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textModeVisible.ForeColor = System.Drawing.SystemColors.Control;
            this.textModeVisible.Location = new System.Drawing.Point(193, 3);
            this.textModeVisible.Name = "textModeVisible";
            this.textModeVisible.Size = new System.Drawing.Size(208, 18);
            this.textModeVisible.TabIndex = 2;
            this.textModeVisible.Text = "Режим шифрования: Цезарь";
            // 
            // closeApplication
            // 
            this.closeApplication.BackColor = System.Drawing.Color.Transparent;
            this.closeApplication.Image = global::Jukov.EncodeDecode.Properties.Resources.cancel;
            this.closeApplication.ImageActive = null;
            this.closeApplication.Location = new System.Drawing.Point(780, 5);
            this.closeApplication.Name = "closeApplication";
            this.closeApplication.Size = new System.Drawing.Size(15, 15);
            this.closeApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeApplication.TabIndex = 1;
            this.closeApplication.TabStop = false;
            this.closeApplication.Zoom = 10;
            this.closeApplication.Click += new System.EventHandler(this.closeApplication_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encoder ";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(128)))));
            this.panelMenu.Controls.Add(this.textMailBox);
            this.panelMenu.Controls.Add(this.textBoxKey);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.buttonVigenere);
            this.panelMenu.Controls.Add(this.buttonOpenCaesar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 25);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(193, 425);
            this.panelMenu.TabIndex = 1;
            // 
            // textMailBox
            // 
            this.textMailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textMailBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textMailBox.ForeColor = System.Drawing.Color.White;
            this.textMailBox.HintForeColor = System.Drawing.Color.Empty;
            this.textMailBox.HintText = "";
            this.textMailBox.isPassword = false;
            this.textMailBox.LineFocusedColor = System.Drawing.Color.White;
            this.textMailBox.LineIdleColor = System.Drawing.Color.White;
            this.textMailBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.textMailBox.LineThickness = 3;
            this.textMailBox.Location = new System.Drawing.Point(15, 189);
            this.textMailBox.Margin = new System.Windows.Forms.Padding(4);
            this.textMailBox.Name = "textMailBox";
            this.textMailBox.Size = new System.Drawing.Size(163, 44);
            this.textMailBox.TabIndex = 4;
            this.textMailBox.Text = "Адрес получателя";
            this.textMailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxKey.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxKey.ForeColor = System.Drawing.Color.White;
            this.textBoxKey.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxKey.HintText = "";
            this.textBoxKey.isPassword = false;
            this.textBoxKey.LineFocusedColor = System.Drawing.Color.White;
            this.textBoxKey.LineIdleColor = System.Drawing.Color.White;
            this.textBoxKey.LineMouseHoverColor = System.Drawing.Color.White;
            this.textBoxKey.LineThickness = 3;
            this.textBoxKey.Location = new System.Drawing.Point(13, 133);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(163, 44);
            this.textBoxKey.TabIndex = 3;
            this.textBoxKey.Text = "Введите ключ";
            this.textBoxKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "© Жуков Никита 1КСК-17";
            // 
            // buttonVigenere
            // 
            this.buttonVigenere.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonVigenere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonVigenere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVigenere.BorderRadius = 0;
            this.buttonVigenere.ButtonText = "Шифр \"Виженера\"";
            this.buttonVigenere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVigenere.DisabledColor = System.Drawing.Color.Gray;
            this.buttonVigenere.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonVigenere.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonVigenere.Iconimage")));
            this.buttonVigenere.Iconimage_right = null;
            this.buttonVigenere.Iconimage_right_Selected = null;
            this.buttonVigenere.Iconimage_Selected = null;
            this.buttonVigenere.IconMarginLeft = 0;
            this.buttonVigenere.IconMarginRight = 0;
            this.buttonVigenere.IconRightVisible = true;
            this.buttonVigenere.IconRightZoom = 0D;
            this.buttonVigenere.IconVisible = true;
            this.buttonVigenere.IconZoom = 90D;
            this.buttonVigenere.IsTab = false;
            this.buttonVigenere.Location = new System.Drawing.Point(0, 72);
            this.buttonVigenere.Name = "buttonVigenere";
            this.buttonVigenere.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonVigenere.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.buttonVigenere.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonVigenere.selected = false;
            this.buttonVigenere.Size = new System.Drawing.Size(200, 48);
            this.buttonVigenere.TabIndex = 1;
            this.buttonVigenere.Text = "Шифр \"Виженера\"";
            this.buttonVigenere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVigenere.Textcolor = System.Drawing.Color.White;
            this.buttonVigenere.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVigenere.Click += new System.EventHandler(this.buttonVigenere_Click);
            // 
            // buttonOpenCaesar
            // 
            this.buttonOpenCaesar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonOpenCaesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonOpenCaesar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOpenCaesar.BorderRadius = 0;
            this.buttonOpenCaesar.ButtonText = "Шифр \"Цезаря\"";
            this.buttonOpenCaesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenCaesar.DisabledColor = System.Drawing.Color.Gray;
            this.buttonOpenCaesar.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonOpenCaesar.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonOpenCaesar.Iconimage")));
            this.buttonOpenCaesar.Iconimage_right = null;
            this.buttonOpenCaesar.Iconimage_right_Selected = null;
            this.buttonOpenCaesar.Iconimage_Selected = null;
            this.buttonOpenCaesar.IconMarginLeft = 0;
            this.buttonOpenCaesar.IconMarginRight = 0;
            this.buttonOpenCaesar.IconRightVisible = true;
            this.buttonOpenCaesar.IconRightZoom = 0D;
            this.buttonOpenCaesar.IconVisible = true;
            this.buttonOpenCaesar.IconZoom = 90D;
            this.buttonOpenCaesar.IsTab = false;
            this.buttonOpenCaesar.Location = new System.Drawing.Point(0, 18);
            this.buttonOpenCaesar.Name = "buttonOpenCaesar";
            this.buttonOpenCaesar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonOpenCaesar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.buttonOpenCaesar.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonOpenCaesar.selected = false;
            this.buttonOpenCaesar.Size = new System.Drawing.Size(200, 48);
            this.buttonOpenCaesar.TabIndex = 0;
            this.buttonOpenCaesar.Text = "Шифр \"Цезаря\"";
            this.buttonOpenCaesar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenCaesar.Textcolor = System.Drawing.Color.White;
            this.buttonOpenCaesar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenCaesar.Click += new System.EventHandler(this.buttonOpenCaesar_Click);
            // 
            // switchModeCipher
            // 
            this.switchModeCipher.BackColor = System.Drawing.Color.Transparent;
            this.switchModeCipher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchModeCipher.BackgroundImage")));
            this.switchModeCipher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchModeCipher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchModeCipher.Location = new System.Drawing.Point(715, 403);
            this.switchModeCipher.Name = "switchModeCipher";
            this.switchModeCipher.OffColor = System.Drawing.Color.Gray;
            this.switchModeCipher.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.switchModeCipher.Size = new System.Drawing.Size(43, 25);
            this.switchModeCipher.TabIndex = 2;
            this.switchModeCipher.Value = true;
            this.switchModeCipher.Click += new System.EventHandler(this.bunifuiOSSwitch1_Click);
            // 
            // textBoxEncoder
            // 
            this.textBoxEncoder.BorderColor = System.Drawing.Color.Black;
            this.textBoxEncoder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEncoder.Location = new System.Drawing.Point(217, 43);
            this.textBoxEncoder.MaxLength = 30000;
            this.textBoxEncoder.Multiline = true;
            this.textBoxEncoder.Name = "textBoxEncoder";
            this.textBoxEncoder.Size = new System.Drawing.Size(559, 159);
            this.textBoxEncoder.TabIndex = 2;
            // 
            // textSecondBox
            // 
            this.textSecondBox.BorderColor = System.Drawing.Color.Black;
            this.textSecondBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSecondBox.Location = new System.Drawing.Point(217, 224);
            this.textSecondBox.MaxLength = 30000;
            this.textSecondBox.Multiline = true;
            this.textSecondBox.Name = "textSecondBox";
            this.textSecondBox.Size = new System.Drawing.Size(559, 159);
            this.textSecondBox.TabIndex = 3;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonEncode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonEncode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEncode.BorderRadius = 0;
            this.buttonEncode.ButtonText = "Шифровать";
            this.buttonEncode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEncode.DisabledColor = System.Drawing.Color.Gray;
            this.buttonEncode.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonEncode.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonEncode.Iconimage")));
            this.buttonEncode.Iconimage_right = null;
            this.buttonEncode.Iconimage_right_Selected = null;
            this.buttonEncode.Iconimage_Selected = null;
            this.buttonEncode.IconMarginLeft = 0;
            this.buttonEncode.IconMarginRight = 0;
            this.buttonEncode.IconRightVisible = true;
            this.buttonEncode.IconRightZoom = 0D;
            this.buttonEncode.IconVisible = false;
            this.buttonEncode.IconZoom = 90D;
            this.buttonEncode.IsTab = false;
            this.buttonEncode.Location = new System.Drawing.Point(217, 399);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonEncode.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.buttonEncode.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonEncode.selected = false;
            this.buttonEncode.Size = new System.Drawing.Size(141, 35);
            this.buttonEncode.TabIndex = 4;
            this.buttonEncode.Text = "Шифровать";
            this.buttonEncode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonEncode.Textcolor = System.Drawing.Color.White;
            this.buttonEncode.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.BorderRadius = 0;
            this.buttonSave.ButtonText = "Сохранить";
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.DisabledColor = System.Drawing.Color.Gray;
            this.buttonSave.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonSave.Iconimage")));
            this.buttonSave.Iconimage_right = null;
            this.buttonSave.Iconimage_right_Selected = null;
            this.buttonSave.Iconimage_Selected = null;
            this.buttonSave.IconMarginLeft = 0;
            this.buttonSave.IconMarginRight = 0;
            this.buttonSave.IconRightVisible = true;
            this.buttonSave.IconRightZoom = 0D;
            this.buttonSave.IconVisible = false;
            this.buttonSave.IconZoom = 90D;
            this.buttonSave.IsTab = false;
            this.buttonSave.Location = new System.Drawing.Point(378, 399);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.buttonSave.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSave.selected = false;
            this.buttonSave.Size = new System.Drawing.Size(141, 35);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSave.Textcolor = System.Drawing.Color.White;
            this.buttonSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrint.BorderRadius = 0;
            this.buttonPrint.ButtonText = "Отправить почтой";
            this.buttonPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrint.DisabledColor = System.Drawing.Color.Gray;
            this.buttonPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Iconimage")));
            this.buttonPrint.Iconimage_right = null;
            this.buttonPrint.Iconimage_right_Selected = null;
            this.buttonPrint.Iconimage_Selected = null;
            this.buttonPrint.IconMarginLeft = 0;
            this.buttonPrint.IconMarginRight = 0;
            this.buttonPrint.IconRightVisible = true;
            this.buttonPrint.IconRightZoom = 0D;
            this.buttonPrint.IconVisible = false;
            this.buttonPrint.IconZoom = 90D;
            this.buttonPrint.IsTab = false;
            this.buttonPrint.Location = new System.Drawing.Point(541, 399);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.buttonPrint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.buttonPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonPrint.selected = false;
            this.buttonPrint.Size = new System.Drawing.Size(141, 35);
            this.buttonPrint.TabIndex = 6;
            this.buttonPrint.Text = "Отправить почтой";
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPrint.Textcolor = System.Drawing.Color.White;
            this.buttonPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.controlPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.controlPanel;
            this.bunifuDragControl3.Vertical = true;
            // 
            // Encode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.switchModeCipher);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.textSecondBox);
            this.Controls.Add(this.textBoxEncoder);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Encode";
            this.Text = "Encoder";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeApplication)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse formElipse;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton buttonOpenCaesar;
        private System.Windows.Forms.Panel controlPanel;
        private Bunifu.Framework.UI.BunifuFlatButton buttonVigenere;
        private Bunifu.Framework.UI.BunifuImageButton closeApplication;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchModeCipher;
        private Bunifu.Framework.UI.BunifuFlatButton buttonPrint;
        private Bunifu.Framework.UI.BunifuFlatButton buttonSave;
        private Bunifu.Framework.UI.BunifuFlatButton buttonEncode;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox textSecondBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox textBoxEncoder;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxKey;
        private System.Windows.Forms.Label textModeVisible;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textMailBox;
        private Bunifu.Framework.UI.BunifuImageButton openButton;
    }
}

