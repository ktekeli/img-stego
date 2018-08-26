namespace IMG_Stego
{
    partial class FormStego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStego));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radioButtonEmbedFile = new System.Windows.Forms.RadioButton();
            this.radioButtonEmbedText = new System.Windows.Forms.RadioButton();
            this.groupBoxImage = new System.Windows.Forms.GroupBox();
            this.labelImageSize = new System.Windows.Forms.Label();
            this.textBoxBrowseMessage = new System.Windows.Forms.TextBox();
            this.buttonBrowseEmbed = new System.Windows.Forms.Button();
            this.pictureBoxCoverImage = new System.Windows.Forms.PictureBox();
            this.groupBoxPlainFile = new System.Windows.Forms.GroupBox();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.textBoxFileMessage = new System.Windows.Forms.TextBox();
            this.buttonSaveAsEmbed = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonEmbed = new System.Windows.Forms.Button();
            this.groupBoxPlainText = new System.Windows.Forms.GroupBox();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonSave1 = new System.Windows.Forms.Button();
            this.buttonApply1 = new System.Windows.Forms.Button();
            this.richTextPlain = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonExtractFile = new System.Windows.Forms.RadioButton();
            this.radioButtonExtractText = new System.Windows.Forms.RadioButton();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBoxEncoded = new System.Windows.Forms.GroupBox();
            this.labelImageSize2 = new System.Windows.Forms.Label();
            this.textBoxBrowse2 = new System.Windows.Forms.TextBox();
            this.buttonBrowseExract = new System.Windows.Forms.Button();
            this.pictureBoxEncoded2 = new System.Windows.Forms.PictureBox();
            this.groupBoxRecodedFile = new System.Windows.Forms.GroupBox();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.buttonExtractAndSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxRecodedText = new System.Windows.Forms.GroupBox();
            this.label_Text2 = new System.Windows.Forms.Label();
            this.richTextBoxDecoded = new System.Windows.Forms.RichTextBox();
            this.buttonDeText = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverImage)).BeginInit();
            this.groupBoxPlainFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.groupBoxPlainText.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxEncoded.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded2)).BeginInit();
            this.groupBoxRecodedFile.SuspendLayout();
            this.groupBoxRecodedText.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 44);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(889, 506);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.radioButtonEmbedFile);
            this.tabPage1.Controls.Add(this.radioButtonEmbedText);
            this.tabPage1.Controls.Add(this.groupBoxImage);
            this.tabPage1.Controls.Add(this.groupBoxPlainFile);
            this.tabPage1.Controls.Add(this.groupBoxPlainText);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(881, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Embedding";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(449, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "<";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(431, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "<";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 427);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(861, 28);
            this.progressBar1.TabIndex = 3;
            // 
            // radioButtonEmbedFile
            // 
            this.radioButtonEmbedFile.AutoSize = true;
            this.radioButtonEmbedFile.Location = new System.Drawing.Point(153, 20);
            this.radioButtonEmbedFile.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonEmbedFile.Name = "radioButtonEmbedFile";
            this.radioButtonEmbedFile.Size = new System.Drawing.Size(99, 21);
            this.radioButtonEmbedFile.TabIndex = 0;
            this.radioButtonEmbedFile.Text = "Embed File";
            this.radioButtonEmbedFile.UseVisualStyleBackColor = true;
            this.radioButtonEmbedFile.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonEmbedText
            // 
            this.radioButtonEmbedText.AutoSize = true;
            this.radioButtonEmbedText.Checked = true;
            this.radioButtonEmbedText.Location = new System.Drawing.Point(11, 20);
            this.radioButtonEmbedText.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonEmbedText.Name = "radioButtonEmbedText";
            this.radioButtonEmbedText.Size = new System.Drawing.Size(104, 21);
            this.radioButtonEmbedText.TabIndex = 0;
            this.radioButtonEmbedText.TabStop = true;
            this.radioButtonEmbedText.Text = "Embed Text";
            this.radioButtonEmbedText.UseVisualStyleBackColor = true;
            this.radioButtonEmbedText.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBoxImage
            // 
            this.groupBoxImage.Controls.Add(this.labelImageSize);
            this.groupBoxImage.Controls.Add(this.textBoxBrowseMessage);
            this.groupBoxImage.Controls.Add(this.buttonBrowseEmbed);
            this.groupBoxImage.Controls.Add(this.pictureBoxCoverImage);
            this.groupBoxImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxImage.Location = new System.Drawing.Point(8, 49);
            this.groupBoxImage.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxImage.Name = "groupBoxImage";
            this.groupBoxImage.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxImage.Size = new System.Drawing.Size(428, 363);
            this.groupBoxImage.TabIndex = 1;
            this.groupBoxImage.TabStop = false;
            this.groupBoxImage.Text = "Image";
            // 
            // labelImageSize
            // 
            this.labelImageSize.AutoSize = true;
            this.labelImageSize.Location = new System.Drawing.Point(25, 334);
            this.labelImageSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImageSize.Name = "labelImageSize";
            this.labelImageSize.Size = new System.Drawing.Size(0, 17);
            this.labelImageSize.TabIndex = 4;
            // 
            // textBoxBrowseMessage
            // 
            this.textBoxBrowseMessage.BackColor = System.Drawing.Color.Ivory;
            this.textBoxBrowseMessage.Location = new System.Drawing.Point(27, 295);
            this.textBoxBrowseMessage.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBrowseMessage.Name = "textBoxBrowseMessage";
            this.textBoxBrowseMessage.Size = new System.Drawing.Size(264, 22);
            this.textBoxBrowseMessage.TabIndex = 0;
            // 
            // buttonBrowseEmbed
            // 
            this.buttonBrowseEmbed.Location = new System.Drawing.Point(300, 293);
            this.buttonBrowseEmbed.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowseEmbed.Name = "buttonBrowseEmbed";
            this.buttonBrowseEmbed.Size = new System.Drawing.Size(100, 28);
            this.buttonBrowseEmbed.TabIndex = 0;
            this.buttonBrowseEmbed.Text = "Browse";
            this.buttonBrowseEmbed.UseVisualStyleBackColor = true;
            this.buttonBrowseEmbed.Click += new System.EventHandler(this.buttonBrowse1_Click);
            // 
            // pictureBoxCoverImage
            // 
            this.pictureBoxCoverImage.BackColor = System.Drawing.Color.Ivory;
            this.pictureBoxCoverImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCoverImage.Location = new System.Drawing.Point(27, 30);
            this.pictureBoxCoverImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCoverImage.Name = "pictureBoxCoverImage";
            this.pictureBoxCoverImage.Size = new System.Drawing.Size(373, 258);
            this.pictureBoxCoverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverImage.TabIndex = 0;
            this.pictureBoxCoverImage.TabStop = false;
            // 
            // groupBoxPlainFile
            // 
            this.groupBoxPlainFile.Controls.Add(this.pictureBoxShow);
            this.groupBoxPlainFile.Controls.Add(this.textBoxFileMessage);
            this.groupBoxPlainFile.Controls.Add(this.buttonSaveAsEmbed);
            this.groupBoxPlainFile.Controls.Add(this.buttonOpenFile);
            this.groupBoxPlainFile.Controls.Add(this.buttonEmbed);
            this.groupBoxPlainFile.Location = new System.Drawing.Point(444, 49);
            this.groupBoxPlainFile.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPlainFile.Name = "groupBoxPlainFile";
            this.groupBoxPlainFile.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPlainFile.Size = new System.Drawing.Size(428, 363);
            this.groupBoxPlainFile.TabIndex = 2;
            this.groupBoxPlainFile.TabStop = false;
            this.groupBoxPlainFile.Text = "File to be Hidden";
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BackColor = System.Drawing.Color.Ivory;
            this.pictureBoxShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShow.Location = new System.Drawing.Point(28, 30);
            this.pictureBoxShow.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(373, 258);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShow.TabIndex = 3;
            this.pictureBoxShow.TabStop = false;
            // 
            // textBoxFileMessage
            // 
            this.textBoxFileMessage.BackColor = System.Drawing.Color.Ivory;
            this.textBoxFileMessage.Location = new System.Drawing.Point(28, 295);
            this.textBoxFileMessage.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFileMessage.Name = "textBoxFileMessage";
            this.textBoxFileMessage.Size = new System.Drawing.Size(264, 22);
            this.textBoxFileMessage.TabIndex = 1;
            // 
            // buttonSaveAsEmbed
            // 
            this.buttonSaveAsEmbed.Location = new System.Drawing.Point(301, 327);
            this.buttonSaveAsEmbed.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveAsEmbed.Name = "buttonSaveAsEmbed";
            this.buttonSaveAsEmbed.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveAsEmbed.TabIndex = 2;
            this.buttonSaveAsEmbed.Text = "Save As";
            this.buttonSaveAsEmbed.UseVisualStyleBackColor = true;
            this.buttonSaveAsEmbed.Click += new System.EventHandler(this.buttonSaveAs1_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(301, 293);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(100, 28);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Open";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpen1_Click);
            // 
            // buttonEmbed
            // 
            this.buttonEmbed.Location = new System.Drawing.Point(193, 327);
            this.buttonEmbed.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEmbed.Name = "buttonEmbed";
            this.buttonEmbed.Size = new System.Drawing.Size(100, 28);
            this.buttonEmbed.TabIndex = 2;
            this.buttonEmbed.Text = "Embed";
            this.buttonEmbed.UseVisualStyleBackColor = true;
            this.buttonEmbed.Click += new System.EventHandler(this.buttonFApply1_Click);
            // 
            // groupBoxPlainText
            // 
            this.groupBoxPlainText.Controls.Add(this.labelText);
            this.groupBoxPlainText.Controls.Add(this.buttonSave1);
            this.groupBoxPlainText.Controls.Add(this.buttonApply1);
            this.groupBoxPlainText.Controls.Add(this.richTextPlain);
            this.groupBoxPlainText.Location = new System.Drawing.Point(444, 49);
            this.groupBoxPlainText.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPlainText.Name = "groupBoxPlainText";
            this.groupBoxPlainText.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPlainText.Size = new System.Drawing.Size(428, 363);
            this.groupBoxPlainText.TabIndex = 2;
            this.groupBoxPlainText.TabStop = false;
            this.groupBoxPlainText.Text = "Text to be Hidden";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(25, 334);
            this.labelText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(0, 17);
            this.labelText.TabIndex = 1;
            // 
            // buttonSave1
            // 
            this.buttonSave1.Location = new System.Drawing.Point(303, 293);
            this.buttonSave1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave1.Name = "buttonSave1";
            this.buttonSave1.Size = new System.Drawing.Size(100, 28);
            this.buttonSave1.TabIndex = 1;
            this.buttonSave1.Text = "Save As";
            this.buttonSave1.UseVisualStyleBackColor = true;
            this.buttonSave1.Click += new System.EventHandler(this.buttonSave1_Click);
            // 
            // buttonApply1
            // 
            this.buttonApply1.Location = new System.Drawing.Point(195, 293);
            this.buttonApply1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApply1.Name = "buttonApply1";
            this.buttonApply1.Size = new System.Drawing.Size(100, 28);
            this.buttonApply1.TabIndex = 1;
            this.buttonApply1.Text = "Embed";
            this.buttonApply1.UseVisualStyleBackColor = true;
            this.buttonApply1.Click += new System.EventHandler(this.buttonApply1_Click);
            // 
            // richTextPlain
            // 
            this.richTextPlain.BackColor = System.Drawing.Color.Ivory;
            this.richTextPlain.Location = new System.Drawing.Point(28, 30);
            this.richTextPlain.Margin = new System.Windows.Forms.Padding(4);
            this.richTextPlain.Name = "richTextPlain";
            this.richTextPlain.Size = new System.Drawing.Size(372, 258);
            this.richTextPlain.TabIndex = 0;
            this.richTextPlain.Text = "";
            this.richTextPlain.TextChanged += new System.EventHandler(this.richTextPlain_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.radioButtonExtractFile);
            this.tabPage2.Controls.Add(this.radioButtonExtractText);
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.groupBoxEncoded);
            this.tabPage2.Controls.Add(this.groupBoxRecodedFile);
            this.tabPage2.Controls.Add(this.groupBoxRecodedText);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(881, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extraction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(431, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = ">";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(412, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = ">";
            // 
            // radioButtonExtractFile
            // 
            this.radioButtonExtractFile.AutoSize = true;
            this.radioButtonExtractFile.Location = new System.Drawing.Point(153, 20);
            this.radioButtonExtractFile.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonExtractFile.Name = "radioButtonExtractFile";
            this.radioButtonExtractFile.Size = new System.Drawing.Size(98, 21);
            this.radioButtonExtractFile.TabIndex = 0;
            this.radioButtonExtractFile.Text = "Extract File";
            this.radioButtonExtractFile.UseVisualStyleBackColor = true;
            this.radioButtonExtractFile.CheckedChanged += new System.EventHandler(this.radioButtonExtractFile_CheckedChanged);
            // 
            // radioButtonExtractText
            // 
            this.radioButtonExtractText.AutoSize = true;
            this.radioButtonExtractText.Checked = true;
            this.radioButtonExtractText.Location = new System.Drawing.Point(11, 20);
            this.radioButtonExtractText.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonExtractText.Name = "radioButtonExtractText";
            this.radioButtonExtractText.Size = new System.Drawing.Size(103, 21);
            this.radioButtonExtractText.TabIndex = 0;
            this.radioButtonExtractText.TabStop = true;
            this.radioButtonExtractText.Text = "Extract Text";
            this.radioButtonExtractText.UseVisualStyleBackColor = true;
            this.radioButtonExtractText.CheckedChanged += new System.EventHandler(this.radioButtonExtractText_CheckedChanged);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(11, 427);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(861, 28);
            this.progressBar2.TabIndex = 4;
            // 
            // groupBoxEncoded
            // 
            this.groupBoxEncoded.Controls.Add(this.labelImageSize2);
            this.groupBoxEncoded.Controls.Add(this.textBoxBrowse2);
            this.groupBoxEncoded.Controls.Add(this.buttonBrowseExract);
            this.groupBoxEncoded.Controls.Add(this.pictureBoxEncoded2);
            this.groupBoxEncoded.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxEncoded.Location = new System.Drawing.Point(8, 49);
            this.groupBoxEncoded.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEncoded.Name = "groupBoxEncoded";
            this.groupBoxEncoded.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEncoded.Size = new System.Drawing.Size(428, 363);
            this.groupBoxEncoded.TabIndex = 1;
            this.groupBoxEncoded.TabStop = false;
            this.groupBoxEncoded.Text = "Image";
            // 
            // labelImageSize2
            // 
            this.labelImageSize2.AutoSize = true;
            this.labelImageSize2.Location = new System.Drawing.Point(25, 334);
            this.labelImageSize2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImageSize2.Name = "labelImageSize2";
            this.labelImageSize2.Size = new System.Drawing.Size(0, 17);
            this.labelImageSize2.TabIndex = 2;
            // 
            // textBoxBrowse2
            // 
            this.textBoxBrowse2.BackColor = System.Drawing.Color.Ivory;
            this.textBoxBrowse2.Location = new System.Drawing.Point(27, 295);
            this.textBoxBrowse2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBrowse2.Name = "textBoxBrowse2";
            this.textBoxBrowse2.Size = new System.Drawing.Size(264, 22);
            this.textBoxBrowse2.TabIndex = 0;
            // 
            // buttonBrowseExract
            // 
            this.buttonBrowseExract.Location = new System.Drawing.Point(300, 293);
            this.buttonBrowseExract.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowseExract.Name = "buttonBrowseExract";
            this.buttonBrowseExract.Size = new System.Drawing.Size(100, 28);
            this.buttonBrowseExract.TabIndex = 0;
            this.buttonBrowseExract.Text = "Browse";
            this.buttonBrowseExract.UseVisualStyleBackColor = true;
            this.buttonBrowseExract.Click += new System.EventHandler(this.buttonBrowse2_Click);
            // 
            // pictureBoxEncoded2
            // 
            this.pictureBoxEncoded2.BackColor = System.Drawing.Color.Ivory;
            this.pictureBoxEncoded2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEncoded2.Location = new System.Drawing.Point(27, 30);
            this.pictureBoxEncoded2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxEncoded2.Name = "pictureBoxEncoded2";
            this.pictureBoxEncoded2.Size = new System.Drawing.Size(373, 258);
            this.pictureBoxEncoded2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEncoded2.TabIndex = 0;
            this.pictureBoxEncoded2.TabStop = false;
            // 
            // groupBoxRecodedFile
            // 
            this.groupBoxRecodedFile.Controls.Add(this.richTextBoxInfo);
            this.groupBoxRecodedFile.Controls.Add(this.buttonExtractAndSave);
            this.groupBoxRecodedFile.Controls.Add(this.label2);
            this.groupBoxRecodedFile.Location = new System.Drawing.Point(444, 49);
            this.groupBoxRecodedFile.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRecodedFile.Name = "groupBoxRecodedFile";
            this.groupBoxRecodedFile.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRecodedFile.Size = new System.Drawing.Size(428, 363);
            this.groupBoxRecodedFile.TabIndex = 2;
            this.groupBoxRecodedFile.TabStop = false;
            this.groupBoxRecodedFile.Text = "Hidden Data";
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BackColor = System.Drawing.Color.Ivory;
            this.richTextBoxInfo.Location = new System.Drawing.Point(28, 30);
            this.richTextBoxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(372, 258);
            this.richTextBoxInfo.TabIndex = 0;
            this.richTextBoxInfo.Text = "";
            // 
            // buttonExtractAndSave
            // 
            this.buttonExtractAndSave.Location = new System.Drawing.Point(28, 293);
            this.buttonExtractAndSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExtractAndSave.Name = "buttonExtractAndSave";
            this.buttonExtractAndSave.Size = new System.Drawing.Size(373, 28);
            this.buttonExtractAndSave.TabIndex = 1;
            this.buttonExtractAndSave.Text = "Extract and Save";
            this.buttonExtractAndSave.UseVisualStyleBackColor = true;
            this.buttonExtractAndSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 5;
            // 
            // groupBoxRecodedText
            // 
            this.groupBoxRecodedText.Controls.Add(this.label_Text2);
            this.groupBoxRecodedText.Controls.Add(this.richTextBoxDecoded);
            this.groupBoxRecodedText.Controls.Add(this.buttonDeText);
            this.groupBoxRecodedText.Controls.Add(this.textBox1);
            this.groupBoxRecodedText.Location = new System.Drawing.Point(444, 49);
            this.groupBoxRecodedText.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRecodedText.Name = "groupBoxRecodedText";
            this.groupBoxRecodedText.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRecodedText.Size = new System.Drawing.Size(428, 363);
            this.groupBoxRecodedText.TabIndex = 5;
            this.groupBoxRecodedText.TabStop = false;
            this.groupBoxRecodedText.Text = "Hidden Text";
            // 
            // label_Text2
            // 
            this.label_Text2.AutoSize = true;
            this.label_Text2.Location = new System.Drawing.Point(25, 334);
            this.label_Text2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Text2.Name = "label_Text2";
            this.label_Text2.Size = new System.Drawing.Size(0, 17);
            this.label_Text2.TabIndex = 5;
            // 
            // richTextBoxDecoded
            // 
            this.richTextBoxDecoded.BackColor = System.Drawing.Color.Ivory;
            this.richTextBoxDecoded.Location = new System.Drawing.Point(28, 30);
            this.richTextBoxDecoded.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxDecoded.Name = "richTextBoxDecoded";
            this.richTextBoxDecoded.ReadOnly = true;
            this.richTextBoxDecoded.Size = new System.Drawing.Size(372, 258);
            this.richTextBoxDecoded.TabIndex = 0;
            this.richTextBoxDecoded.Text = "";
            // 
            // buttonDeText
            // 
            this.buttonDeText.Location = new System.Drawing.Point(301, 293);
            this.buttonDeText.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeText.Name = "buttonDeText";
            this.buttonDeText.Size = new System.Drawing.Size(100, 28);
            this.buttonDeText.TabIndex = 2;
            this.buttonDeText.Text = "Extract";
            this.buttonDeText.UseVisualStyleBackColor = true;
            this.buttonDeText.Click += new System.EventHandler(this.buttonDeText_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 199);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(887, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelVersion.Location = new System.Drawing.Point(769, 559);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(105, 17);
            this.labelVersion.TabIndex = 7;
            this.labelVersion.Text = "IMG Stego v1.0";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.BackColor = System.Drawing.Color.Transparent;
            this.labelProgress.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelProgress.Location = new System.Drawing.Point(12, 559);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelProgress.Size = new System.Drawing.Size(0, 17);
            this.labelProgress.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(409, 558);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 15);
            this.textBox2.TabIndex = 12;
            // 
            // FormStego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(887, 583);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMG Stego";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxImage.ResumeLayout(false);
            this.groupBoxImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverImage)).EndInit();
            this.groupBoxPlainFile.ResumeLayout(false);
            this.groupBoxPlainFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.groupBoxPlainText.ResumeLayout(false);
            this.groupBoxPlainText.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxEncoded.ResumeLayout(false);
            this.groupBoxEncoded.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncoded2)).EndInit();
            this.groupBoxRecodedFile.ResumeLayout(false);
            this.groupBoxRecodedFile.PerformLayout();
            this.groupBoxRecodedText.ResumeLayout(false);
            this.groupBoxRecodedText.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxImage;
        private System.Windows.Forms.PictureBox pictureBoxCoverImage;
        private System.Windows.Forms.GroupBox groupBoxPlainText;
        private System.Windows.Forms.RichTextBox richTextPlain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxBrowseMessage;
        private System.Windows.Forms.Button buttonBrowseEmbed;
        private System.Windows.Forms.Button buttonSave1;
        private System.Windows.Forms.Button buttonApply1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.RadioButton radioButtonEmbedFile;
        private System.Windows.Forms.RadioButton radioButtonEmbedText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.GroupBox groupBoxPlainFile;
        private System.Windows.Forms.TextBox textBoxFileMessage;
        private System.Windows.Forms.Button buttonSaveAsEmbed;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonEmbed;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Label labelImageSize;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.GroupBox groupBoxEncoded;
        private System.Windows.Forms.Label labelImageSize2;
        private System.Windows.Forms.TextBox textBoxBrowse2;
        private System.Windows.Forms.Button buttonBrowseExract;
        private System.Windows.Forms.PictureBox pictureBoxEncoded2;
        private System.Windows.Forms.GroupBox groupBoxRecodedText;
        private System.Windows.Forms.Label label_Text2;
        private System.Windows.Forms.RichTextBox richTextBoxDecoded;
        private System.Windows.Forms.Button buttonDeText;
        private System.Windows.Forms.GroupBox groupBoxRecodedFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExtractAndSave;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonExtractFile;
        private System.Windows.Forms.RadioButton radioButtonExtractText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
    }
}

