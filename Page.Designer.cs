
namespace CreativeWordLearner {
    partial class Page {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.baseLayout = new System.Windows.Forms.TableLayoutPanel();
            this.header = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.headerRight = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_AskedWords = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.TableLayoutPanel();
            this.question = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_User = new System.Windows.Forms.Button();
            this.box_User = new System.Windows.Forms.ComboBox();
            this.lblSelectTxt = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_Help = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_switch = new System.Windows.Forms.Button();
            this.lbl_language = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_userLevel = new System.Windows.Forms.Label();
            this.bar_userProgress = new System.Windows.Forms.ProgressBar();
            this.btn_delete = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.baseLayout.SuspendLayout();
            this.header.SuspendLayout();
            this.headerRight.SuspendLayout();
            this.footer.SuspendLayout();
            this.container.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseLayout
            // 
            this.baseLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.baseLayout.ColumnCount = 1;
            this.baseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.baseLayout.Controls.Add(this.header, 0, 0);
            this.baseLayout.Controls.Add(this.footer, 0, 2);
            this.baseLayout.Controls.Add(this.container, 0, 1);
            this.baseLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseLayout.Location = new System.Drawing.Point(0, 0);
            this.baseLayout.Name = "baseLayout";
            this.baseLayout.RowCount = 3;
            this.baseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.05959F));
            this.baseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.79404F));
            this.baseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.226468F));
            this.baseLayout.Size = new System.Drawing.Size(1947, 1108);
            this.baseLayout.TabIndex = 0;
            // 
            // header
            // 
            this.header.ColumnCount = 2;
            this.header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.header.Controls.Add(this.label1, 0, 0);
            this.header.Controls.Add(this.headerRight, 1, 0);
            this.header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header.Location = new System.Drawing.Point(3, 3);
            this.header.Name = "header";
            this.header.RowCount = 1;
            this.header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.header.Size = new System.Drawing.Size(1941, 149);
            this.header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1352, 149);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creative Word Learner";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerRight
            // 
            this.headerRight.ColumnCount = 2;
            this.headerRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.58232F));
            this.headerRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.41768F));
            this.headerRight.Controls.Add(this.label2, 0, 0);
            this.headerRight.Controls.Add(this.label3, 0, 1);
            this.headerRight.Controls.Add(this.lblDate, 1, 0);
            this.headerRight.Controls.Add(this.lblTime, 1, 1);
            this.headerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerRight.Location = new System.Drawing.Point(1361, 3);
            this.headerRight.Name = "headerRight";
            this.headerRight.RowCount = 2;
            this.headerRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.headerRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.headerRight.Size = new System.Drawing.Size(577, 143);
            this.headerRight.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 71);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 72);
            this.label3.TabIndex = 1;
            this.label3.Text = "Time:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(191, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(383, 71);
            this.lblDate.TabIndex = 0;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(191, 71);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(383, 72);
            this.lblTime.TabIndex = 2;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // footer
            // 
            this.footer.ColumnCount = 2;
            this.footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.62597F));
            this.footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.37403F));
            this.footer.Controls.Add(this.label5, 1, 1);
            this.footer.Controls.Add(this.lbl_AskedWords, 0, 0);
            this.footer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footer.Location = new System.Drawing.Point(3, 1008);
            this.footer.Name = "footer";
            this.footer.RowCount = 2;
            this.footer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.footer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.footer.Size = new System.Drawing.Size(1941, 97);
            this.footer.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(1665, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 49);
            this.label5.TabIndex = 0;
            this.label5.Text = "Version: 0.1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AskedWords
            // 
            this.lbl_AskedWords.AutoSize = true;
            this.lbl_AskedWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_AskedWords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_AskedWords.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_AskedWords.Location = new System.Drawing.Point(3, 0);
            this.lbl_AskedWords.Name = "lbl_AskedWords";
            this.lbl_AskedWords.Size = new System.Drawing.Size(1656, 48);
            this.lbl_AskedWords.TabIndex = 1;
            this.lbl_AskedWords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.ColumnCount = 5;
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.container.Controls.Add(this.question, 2, 0);
            this.container.Controls.Add(this.answer, 2, 2);
            this.container.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.container.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.container.Controls.Add(this.btn_start, 2, 3);
            this.container.Controls.Add(this.lbl_Help, 2, 1);
            this.container.Controls.Add(this.tableLayoutPanel4, 4, 3);
            this.container.Controls.Add(this.btn_help, 4, 2);
            this.container.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.container.Controls.Add(this.btn_delete, 0, 3);
            this.container.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.container.Location = new System.Drawing.Point(3, 158);
            this.container.Name = "container";
            this.container.RowCount = 4;
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.23697F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.76303F));
            this.container.Size = new System.Drawing.Size(1941, 844);
            this.container.TabIndex = 1;
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.question.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.question.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.question.Location = new System.Drawing.Point(488, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(964, 211);
            this.question.TabIndex = 0;
            this.question.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // answer
            // 
            this.answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer.Enabled = false;
            this.answer.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answer.Location = new System.Drawing.Point(488, 502);
            this.answer.Margin = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.answer.MaxLength = 20;
            this.answer.Name = "answer";
            this.answer.PlaceholderText = "Enter your answer";
            this.answer.Size = new System.Drawing.Size(964, 66);
            this.answer.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.btn_User, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.box_User, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSelectTxt, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.31707F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.04878F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.12195F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 205);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btn_User
            // 
            this.btn_User.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_User.Location = new System.Drawing.Point(104, 135);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(230, 67);
            this.btn_User.TabIndex = 12;
            this.btn_User.TabStop = false;
            this.btn_User.Text = "New";
            this.btn_User.UseVisualStyleBackColor = true;
            this.btn_User.Click += new System.EventHandler(this.NewProfileButton_Clicked);
            // 
            // box_User
            // 
            this.box_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_User.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_User.FormattingEnabled = true;
            this.box_User.Location = new System.Drawing.Point(60, 58);
            this.box_User.Name = "box_User";
            this.box_User.Size = new System.Drawing.Size(319, 56);
            this.box_User.TabIndex = 0;
            this.box_User.SelectedIndexChanged += new System.EventHandler(this.UserSelectList_SelectedIndexChanged);
            // 
            // lblSelectTxt
            // 
            this.lblSelectTxt.AutoSize = true;
            this.lblSelectTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectTxt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectTxt.Location = new System.Drawing.Point(60, 0);
            this.lblSelectTxt.Name = "lblSelectTxt";
            this.lblSelectTxt.Size = new System.Drawing.Size(319, 55);
            this.lblSelectTxt.TabIndex = 2;
            this.lblSelectTxt.Text = "Select profile:";
            this.lblSelectTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.txt_User, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 214);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(382, 205);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // txt_User
            // 
            this.txt_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_User.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_User.Location = new System.Drawing.Point(60, 60);
            this.txt_User.Margin = new System.Windows.Forms.Padding(3, 60, 3, 3);
            this.txt_User.MaxLength = 10;
            this.txt_User.Name = "txt_User";
            this.txt_User.PlaceholderText = "Enter name";
            this.txt_User.Size = new System.Drawing.Size(319, 55);
            this.txt_User.TabIndex = 6;
            this.txt_User.Visible = false;
            // 
            // btn_start
            // 
            this.btn_start.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.Enabled = false;
            this.btn_start.Location = new System.Drawing.Point(855, 638);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(230, 70);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.StartButton_Clicked);
            // 
            // lbl_Help
            // 
            this.lbl_Help.AutoSize = true;
            this.lbl_Help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Help.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Help.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Help.Location = new System.Drawing.Point(488, 211);
            this.lbl_Help.Name = "lbl_Help";
            this.lbl_Help.Size = new System.Drawing.Size(964, 211);
            this.lbl_Help.TabIndex = 9;
            this.lbl_Help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Controls.Add(this.btn_switch, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_language, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1555, 638);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.7537F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.2463F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(383, 203);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // btn_switch
            // 
            this.btn_switch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_switch.Enabled = false;
            this.btn_switch.Location = new System.Drawing.Point(47, 104);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(230, 70);
            this.btn_switch.TabIndex = 10;
            this.btn_switch.TabStop = false;
            this.btn_switch.Text = "English";
            this.btn_switch.UseVisualStyleBackColor = true;
            this.btn_switch.Click += new System.EventHandler(this.LanguageButton_Clicked);
            // 
            // lbl_language
            // 
            this.lbl_language.AutoSize = true;
            this.lbl_language.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_language.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_language.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_language.Location = new System.Drawing.Point(3, 0);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.Size = new System.Drawing.Size(319, 101);
            this.lbl_language.TabIndex = 11;
            this.lbl_language.Text = "Question language:";
            this.lbl_language.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_help
            // 
            this.btn_help.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_help.Enabled = false;
            this.btn_help.Location = new System.Drawing.Point(1631, 425);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(230, 70);
            this.btn_help.TabIndex = 3;
            this.btn_help.TabStop = false;
            this.btn_help.Text = "Get help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_userName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_userLevel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.bar_userProgress, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 425);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(382, 207);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_userName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_userName.Location = new System.Drawing.Point(60, 0);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(319, 69);
            this.lbl_userName.TabIndex = 0;
            this.lbl_userName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_userLevel
            // 
            this.lbl_userLevel.AutoSize = true;
            this.lbl_userLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_userLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_userLevel.Location = new System.Drawing.Point(60, 69);
            this.lbl_userLevel.Name = "lbl_userLevel";
            this.lbl_userLevel.Size = new System.Drawing.Size(319, 69);
            this.lbl_userLevel.TabIndex = 1;
            this.lbl_userLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bar_userProgress
            // 
            this.bar_userProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar_userProgress.Location = new System.Drawing.Point(60, 141);
            this.bar_userProgress.Name = "bar_userProgress";
            this.bar_userProgress.Size = new System.Drawing.Size(319, 44);
            this.bar_userProgress.TabIndex = 2;
            this.bar_userProgress.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Location = new System.Drawing.Point(88, 638);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(211, 50);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.TabStop = false;
            this.btn_delete.Text = "Delete Profile";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.DeleteButton_Clicked);
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1947, 1108);
            this.Controls.Add(this.baseLayout);
            this.MinimumSize = new System.Drawing.Size(1650, 1000);
            this.Name = "Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Page_Closing);
            this.Load += new System.EventHandler(this.Page_Load);
            this.baseLayout.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.headerRight.ResumeLayout(false);
            this.headerRight.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel baseLayout;
        private System.Windows.Forms.TableLayoutPanel header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel headerRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel container;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.TableLayoutPanel footer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox box_User;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label lblSelectTxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_userLevel;
        private System.Windows.Forms.ProgressBar bar_userProgress;
        private System.Windows.Forms.Label lbl_Help;
        private System.Windows.Forms.Button btn_switch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_language;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_AskedWords;
    }
}

