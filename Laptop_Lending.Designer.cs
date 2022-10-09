
namespace 소프트웨어콘텐츠계열_노트북_대여_프로그램
{
    partial class Laptop_Lending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laptop_Lending));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Title = new System.Windows.Forms.Label();
            this.agree_btn = new System.Windows.Forms.RadioButton();
            this.disagree_btn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.Student_Number_TextBox = new System.Windows.Forms.TextBox();
            this.Student_Number = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tell_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Address_TextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Parent_Tell_TextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Parent_Address_TextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.rental_date = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.return_date = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.Application_date = new System.Windows.Forms.DateTimePicker();
            this.label37 = new System.Windows.Forms.Label();
            this.Application_Name = new System.Windows.Forms.TextBox();
            this.Application_Parent_Name = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.Application_Btn = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.Parent_Name_TextBox = new System.Windows.Forms.TextBox();
            this.Rental_Btn = new System.Windows.Forms.RadioButton();
            this.Return_Btn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("굴림", 10F);
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "[개인정보 수집 · 이용 동의]",
            "",
            "1) 개인정보 수집 · 이용 목적 : 본인 확인 및 대여 기록 관리",
            "",
            "2) 수집하는 개인정보의 항목 : 소속, 학번, 이름, 휴대폰 번호",
            "",
            "3) 개인정보의 보유 및 이용기간 (파기 前까지) : 1년",
            "",
            "4) 동의 거부 권리 안내 : 귀하는 본 개인정보 수집 · 이용 동의에 거부할 권리가 있습니다.",
            "",
            "- 단, 동의를 거부할 경우에는 대여가 불가할 수 있습니다."});
            this.listBox1.Location = new System.Drawing.Point(60, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(552, 123);
            this.listBox1.TabIndex = 16;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(236, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(203, 24);
            this.Title.TabIndex = 17;
            this.Title.Text = "노트북 대여 신청";
            // 
            // agree_btn
            // 
            this.agree_btn.AutoSize = true;
            this.agree_btn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agree_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.agree_btn.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.agree_btn.Location = new System.Drawing.Point(20, 7);
            this.agree_btn.Name = "agree_btn";
            this.agree_btn.Size = new System.Drawing.Size(92, 22);
            this.agree_btn.TabIndex = 1;
            this.agree_btn.TabStop = true;
            this.agree_btn.Text = "동의함";
            this.agree_btn.UseVisualStyleBackColor = true;
            // 
            // disagree_btn
            // 
            this.disagree_btn.AutoSize = true;
            this.disagree_btn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.disagree_btn.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.disagree_btn.Location = new System.Drawing.Point(118, 8);
            this.disagree_btn.Name = "disagree_btn";
            this.disagree_btn.Size = new System.Drawing.Size(143, 21);
            this.disagree_btn.TabIndex = 2;
            this.disagree_btn.TabStop = true;
            this.disagree_btn.Text = "동의하지 않음";
            this.disagree_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(57, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "개인정보의 수집 및 이용에 동의하십니까?";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(-10, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(650, 10);
            this.label10.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-10, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(650, 10);
            this.label2.TabIndex = 45;
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Location = new System.Drawing.Point(113, 280);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(2, 18);
            this.label25.TabIndex = 48;
            // 
            // Student_Number_TextBox
            // 
            this.Student_Number_TextBox.Location = new System.Drawing.Point(126, 278);
            this.Student_Number_TextBox.Name = "Student_Number_TextBox";
            this.Student_Number_TextBox.Size = new System.Drawing.Size(156, 25);
            this.Student_Number_TextBox.TabIndex = 3;
            this.Student_Number_TextBox.TextChanged += new System.EventHandler(this.Student_Number_TextBox_TextChanged);
            // 
            // Student_Number
            // 
            this.Student_Number.AutoSize = true;
            this.Student_Number.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Student_Number.Location = new System.Drawing.Point(12, 280);
            this.Student_Number.Name = "Student_Number";
            this.Student_Number.Size = new System.Drawing.Size(45, 15);
            this.Student_Number.TabIndex = 46;
            this.Student_Number.Text = "학 번";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(400, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 18);
            this.label3.TabIndex = 51;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(413, 278);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(156, 25);
            this.Name_TextBox.TabIndex = 4;
            this.Name_TextBox.TextChanged += new System.EventHandler(this.Name_TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(344, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "이 름";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(400, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 18);
            this.label5.TabIndex = 57;
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Location = new System.Drawing.Point(413, 326);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(156, 25);
            this.Email_TextBox.TabIndex = 6;
            this.Email_TextBox.TextChanged += new System.EventHandler(this.Email_TextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(344, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "이메일";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(113, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 18);
            this.label7.TabIndex = 54;
            // 
            // Tell_TextBox
            // 
            this.Tell_TextBox.Location = new System.Drawing.Point(126, 326);
            this.Tell_TextBox.Name = "Tell_TextBox";
            this.Tell_TextBox.Size = new System.Drawing.Size(156, 25);
            this.Tell_TextBox.TabIndex = 5;
            this.Tell_TextBox.TextChanged += new System.EventHandler(this.Tell_TextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(12, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 52;
            this.label8.Text = "휴대폰";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(113, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2, 18);
            this.label9.TabIndex = 60;
            // 
            // Address_TextBox
            // 
            this.Address_TextBox.Location = new System.Drawing.Point(126, 373);
            this.Address_TextBox.Name = "Address_TextBox";
            this.Address_TextBox.Size = new System.Drawing.Size(443, 25);
            this.Address_TextBox.TabIndex = 7;
            this.Address_TextBox.TextChanged += new System.EventHandler(this.Address_TextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(12, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 58;
            this.label11.Text = "주소";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(400, 436);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(2, 18);
            this.label12.TabIndex = 66;
            // 
            // Parent_Tell_TextBox
            // 
            this.Parent_Tell_TextBox.Location = new System.Drawing.Point(413, 434);
            this.Parent_Tell_TextBox.Name = "Parent_Tell_TextBox";
            this.Parent_Tell_TextBox.Size = new System.Drawing.Size(156, 25);
            this.Parent_Tell_TextBox.TabIndex = 9;
            this.Parent_Tell_TextBox.TextChanged += new System.EventHandler(this.Parent_Tell_TextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(342, 437);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 64;
            this.label13.Text = "휴대폰";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(113, 436);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(2, 18);
            this.label14.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(12, 439);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 15);
            this.label15.TabIndex = 61;
            this.label15.Text = "보호자 성함";
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(113, 486);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(2, 18);
            this.label16.TabIndex = 69;
            // 
            // Parent_Address_TextBox
            // 
            this.Parent_Address_TextBox.Location = new System.Drawing.Point(126, 484);
            this.Parent_Address_TextBox.Name = "Parent_Address_TextBox";
            this.Parent_Address_TextBox.Size = new System.Drawing.Size(443, 25);
            this.Parent_Address_TextBox.TabIndex = 10;
            this.Parent_Address_TextBox.TextChanged += new System.EventHandler(this.Parent_Address_TextBox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(12, 487);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 15);
            this.label17.TabIndex = 67;
            this.label17.Text = "보호자 주소";
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(-10, 523);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(650, 10);
            this.label18.TabIndex = 70;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(-10, 414);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(650, 10);
            this.label19.TabIndex = 71;
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(113, 543);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(2, 18);
            this.label20.TabIndex = 73;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(12, 543);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 15);
            this.label21.TabIndex = 72;
            this.label21.Text = "대여 날짜";
            // 
            // rental_date
            // 
            this.rental_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rental_date.Location = new System.Drawing.Point(126, 537);
            this.rental_date.Name = "rental_date";
            this.rental_date.Size = new System.Drawing.Size(200, 25);
            this.rental_date.TabIndex = 11;
            this.rental_date.ValueChanged += new System.EventHandler(this.rental_date_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(333, 543);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 15);
            this.label22.TabIndex = 75;
            this.label22.Text = "부터";
            // 
            // return_date
            // 
            this.return_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.return_date.Location = new System.Drawing.Point(376, 537);
            this.return_date.Name = "return_date";
            this.return_date.Size = new System.Drawing.Size(200, 25);
            this.return_date.TabIndex = 12;
            this.return_date.ValueChanged += new System.EventHandler(this.return_date_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(582, 543);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 15);
            this.label23.TabIndex = 77;
            this.label23.Text = "까지";
            // 
            // label24
            // 
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label24.Location = new System.Drawing.Point(-10, 575);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(650, 10);
            this.label24.TabIndex = 78;
            // 
            // label26
            // 
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label26.Location = new System.Drawing.Point(113, 591);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(2, 18);
            this.label26.TabIndex = 80;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.Location = new System.Drawing.Point(12, 591);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 15);
            this.label27.TabIndex = 79;
            this.label27.Text = "대여 물품";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(123, 592);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(397, 15);
            this.label28.TabIndex = 81;
            this.label28.Text = "노트북 | 마우스 | 배터리 | 충전기 | 충전기 어댑터 | 가방";
            // 
            // label29
            // 
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label29.Location = new System.Drawing.Point(526, 591);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(2, 18);
            this.label29.TabIndex = 83;
            // 
            // label30
            // 
            this.label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label30.Location = new System.Drawing.Point(526, 634);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(2, 18);
            this.label30.TabIndex = 88;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(123, 635);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(397, 15);
            this.label31.TabIndex = 86;
            this.label31.Text = "노트북 | 마우스 | 배터리 | 충전기 | 충전기 어댑터 | 가방";
            // 
            // label32
            // 
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label32.Location = new System.Drawing.Point(113, 634);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(2, 18);
            this.label32.TabIndex = 85;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label33.Location = new System.Drawing.Point(12, 634);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(77, 15);
            this.label33.TabIndex = 84;
            this.label33.Text = "반납 물품";
            // 
            // label34
            // 
            this.label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label34.Location = new System.Drawing.Point(-10, 620);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(650, 10);
            this.label34.TabIndex = 89;
            // 
            // label35
            // 
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.Location = new System.Drawing.Point(-10, 663);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(650, 10);
            this.label35.TabIndex = 90;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label36.Location = new System.Drawing.Point(22, 685);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(587, 45);
            this.label36.TabIndex = 91;
            this.label36.Text = "본인은 노트북을 대여하며 개인정보 수집이용 동의여부를 직접 작성하였음을 확인하고\r\n\r\n노트북 대여 제도 시행 지침을 준수할 것을 서약합니다.";
            // 
            // Application_date
            // 
            this.Application_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Application_date.Location = new System.Drawing.Point(240, 754);
            this.Application_date.Name = "Application_date";
            this.Application_date.Size = new System.Drawing.Size(200, 25);
            this.Application_date.TabIndex = 15;
            this.Application_date.ValueChanged += new System.EventHandler(this.Application_date_ValueChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(237, 805);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(52, 15);
            this.label37.TabIndex = 93;
            this.label37.Text = "신청자";
            // 
            // Application_Name
            // 
            this.Application_Name.Location = new System.Drawing.Point(295, 795);
            this.Application_Name.Name = "Application_Name";
            this.Application_Name.Size = new System.Drawing.Size(145, 25);
            this.Application_Name.TabIndex = 16;
            this.Application_Name.TextChanged += new System.EventHandler(this.Application_Name_TextChanged);
            // 
            // Application_Parent_Name
            // 
            this.Application_Parent_Name.Location = new System.Drawing.Point(295, 840);
            this.Application_Parent_Name.Name = "Application_Parent_Name";
            this.Application_Parent_Name.Size = new System.Drawing.Size(145, 25);
            this.Application_Parent_Name.TabIndex = 17;
            this.Application_Parent_Name.TextChanged += new System.EventHandler(this.Application_Parent_Name_TextChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(237, 850);
            this.label38.Name = "label38";
            this.label38.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label38.Size = new System.Drawing.Size(52, 15);
            this.label38.TabIndex = 95;
            this.label38.Text = "보호자";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.label39.Location = new System.Drawing.Point(21, 887);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(537, 24);
            this.label39.TabIndex = 97;
            this.label39.Text = "영남이공대 소프트웨어콘텐츠계열 학과장 귀하";
            // 
            // Application_Btn
            // 
            this.Application_Btn.BackColor = System.Drawing.Color.Navy;
            this.Application_Btn.FlatAppearance.BorderSize = 0;
            this.Application_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Application_Btn.Font = new System.Drawing.Font("경기천년제목 Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Application_Btn.ForeColor = System.Drawing.Color.White;
            this.Application_Btn.Location = new System.Drawing.Point(494, 795);
            this.Application_Btn.Name = "Application_Btn";
            this.Application_Btn.Size = new System.Drawing.Size(75, 71);
            this.Application_Btn.TabIndex = 18;
            this.Application_Btn.Text = "신청";
            this.Application_Btn.UseVisualStyleBackColor = false;
            this.Application_Btn.Click += new System.EventHandler(this.Application_Btn_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(446, 805);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(34, 15);
            this.label40.TabIndex = 99;
            this.label40.Text = "(인)";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(446, 850);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(34, 15);
            this.label41.TabIndex = 100;
            this.label41.Text = "(인)";
            // 
            // Parent_Name_TextBox
            // 
            this.Parent_Name_TextBox.Location = new System.Drawing.Point(126, 434);
            this.Parent_Name_TextBox.Name = "Parent_Name_TextBox";
            this.Parent_Name_TextBox.Size = new System.Drawing.Size(156, 25);
            this.Parent_Name_TextBox.TabIndex = 8;
            this.Parent_Name_TextBox.TextChanged += new System.EventHandler(this.Parent_Name_TextBox_TextChanged);
            // 
            // Rental_Btn
            // 
            this.Rental_Btn.AutoSize = true;
            this.Rental_Btn.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Rental_Btn.Location = new System.Drawing.Point(5, 11);
            this.Rental_Btn.Name = "Rental_Btn";
            this.Rental_Btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rental_Btn.Size = new System.Drawing.Size(65, 21);
            this.Rental_Btn.TabIndex = 101;
            this.Rental_Btn.TabStop = true;
            this.Rental_Btn.Text = "확인";
            this.Rental_Btn.UseVisualStyleBackColor = true;
            // 
            // Return_Btn
            // 
            this.Return_Btn.AutoSize = true;
            this.Return_Btn.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.Return_Btn.Location = new System.Drawing.Point(5, 10);
            this.Return_Btn.Name = "Return_Btn";
            this.Return_Btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Return_Btn.Size = new System.Drawing.Size(65, 21);
            this.Return_Btn.TabIndex = 14;
            this.Return_Btn.TabStop = true;
            this.Return_Btn.Text = "확인";
            this.Return_Btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.disagree_btn);
            this.panel1.Controls.Add(this.agree_btn);
            this.panel1.Location = new System.Drawing.Point(354, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 39);
            this.panel1.TabIndex = 103;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Rental_Btn);
            this.panel2.Location = new System.Drawing.Point(534, 580);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 37);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Return_Btn);
            this.panel3.Location = new System.Drawing.Point(534, 624);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(73, 36);
            this.panel3.TabIndex = 105;
            // 
            // Laptop_Lending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.AutoScrollMinSize = new System.Drawing.Size(0, 20);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 981);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.Application_Btn);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.Application_Parent_Name);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.Application_Name);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.Application_date);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.return_date);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.rental_date);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Parent_Address_TextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Parent_Tell_TextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Parent_Name_TextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Address_TextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Email_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Tell_TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.Student_Number_TextBox);
            this.Controls.Add(this.Student_Number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(680, 1028);
            this.MinimumSize = new System.Drawing.Size(680, 1028);
            this.Name = "Laptop_Lending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "노트북 대여";
            this.Load += new System.EventHandler(this.Labtop_Lending_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RadioButton agree_btn;
        private System.Windows.Forms.RadioButton disagree_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox Student_Number_TextBox;
        private System.Windows.Forms.Label Student_Number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tell_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Address_TextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Parent_Tell_TextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Parent_Address_TextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker rental_date;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker return_date;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DateTimePicker Application_date;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox Application_Name;
        private System.Windows.Forms.TextBox Application_Parent_Name;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button Application_Btn;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox Parent_Name_TextBox;
        private System.Windows.Forms.RadioButton Rental_Btn;
        private System.Windows.Forms.RadioButton Return_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}