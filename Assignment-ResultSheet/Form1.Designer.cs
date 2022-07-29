namespace Assignment_ResultSheet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inName = new System.Windows.Forms.TextBox();
            this.inNumber = new System.Windows.Forms.TextBox();
            this.inSinhala = new System.Windows.Forms.TextBox();
            this.inHistory = new System.Windows.Forms.TextBox();
            this.inMath = new System.Windows.Forms.TextBox();
            this.inEng = new System.Windows.Forms.TextBox();
            this.inScience = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.disAvg = new System.Windows.Forms.Label();
            this.disTotal = new System.Windows.Forms.Label();
            this.gradeScience = new System.Windows.Forms.Label();
            this.gradeMath = new System.Windows.Forms.Label();
            this.gradeEnglish = new System.Windows.Forms.Label();
            this.gradeHistory = new System.Windows.Forms.Label();
            this.gradeSinhala = new System.Windows.Forms.Label();
            this.btnGetGrade = new System.Windows.Forms.Button();
            this.btnGetTotal = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Result Sheet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "History:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sinhala:";
            // 
            // inName
            // 
            this.inName.Location = new System.Drawing.Point(161, 73);
            this.inName.Name = "inName";
            this.inName.Size = new System.Drawing.Size(363, 27);
            this.inName.TabIndex = 5;
            // 
            // inNumber
            // 
            this.inNumber.Location = new System.Drawing.Point(161, 108);
            this.inNumber.Name = "inNumber";
            this.inNumber.Size = new System.Drawing.Size(363, 27);
            this.inNumber.TabIndex = 6;
            // 
            // inSinhala
            // 
            this.inSinhala.Location = new System.Drawing.Point(151, 172);
            this.inSinhala.Name = "inSinhala";
            this.inSinhala.Size = new System.Drawing.Size(125, 27);
            this.inSinhala.TabIndex = 7;
            // 
            // inHistory
            // 
            this.inHistory.Location = new System.Drawing.Point(151, 205);
            this.inHistory.Name = "inHistory";
            this.inHistory.Size = new System.Drawing.Size(125, 27);
            this.inHistory.TabIndex = 8;
            // 
            // inMath
            // 
            this.inMath.Location = new System.Drawing.Point(151, 273);
            this.inMath.Name = "inMath";
            this.inMath.Size = new System.Drawing.Size(125, 27);
            this.inMath.TabIndex = 10;
            // 
            // inEng
            // 
            this.inEng.Location = new System.Drawing.Point(151, 240);
            this.inEng.Name = "inEng";
            this.inEng.Size = new System.Drawing.Size(125, 27);
            this.inEng.TabIndex = 9;
            // 
            // inScience
            // 
            this.inScience.Location = new System.Drawing.Point(151, 306);
            this.inScience.Name = "inScience";
            this.inScience.Size = new System.Drawing.Size(125, 27);
            this.inScience.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mathematics:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "English:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Science:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Average:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total:";
            // 
            // disAvg
            // 
            this.disAvg.AutoSize = true;
            this.disAvg.Location = new System.Drawing.Point(151, 392);
            this.disAvg.Name = "disAvg";
            this.disAvg.Size = new System.Drawing.Size(0, 20);
            this.disAvg.TabIndex = 18;
            // 
            // disTotal
            // 
            this.disTotal.AutoSize = true;
            this.disTotal.Location = new System.Drawing.Point(151, 355);
            this.disTotal.Name = "disTotal";
            this.disTotal.Size = new System.Drawing.Size(0, 20);
            this.disTotal.TabIndex = 17;
            // 
            // gradeScience
            // 
            this.gradeScience.AutoSize = true;
            this.gradeScience.Location = new System.Drawing.Point(382, 313);
            this.gradeScience.Name = "gradeScience";
            this.gradeScience.Size = new System.Drawing.Size(0, 20);
            this.gradeScience.TabIndex = 23;
            // 
            // gradeMath
            // 
            this.gradeMath.AutoSize = true;
            this.gradeMath.Location = new System.Drawing.Point(382, 276);
            this.gradeMath.Name = "gradeMath";
            this.gradeMath.Size = new System.Drawing.Size(0, 20);
            this.gradeMath.TabIndex = 22;
            // 
            // gradeEnglish
            // 
            this.gradeEnglish.AutoSize = true;
            this.gradeEnglish.Location = new System.Drawing.Point(382, 243);
            this.gradeEnglish.Name = "gradeEnglish";
            this.gradeEnglish.Size = new System.Drawing.Size(0, 20);
            this.gradeEnglish.TabIndex = 21;
            // 
            // gradeHistory
            // 
            this.gradeHistory.AutoSize = true;
            this.gradeHistory.Location = new System.Drawing.Point(382, 208);
            this.gradeHistory.Name = "gradeHistory";
            this.gradeHistory.Size = new System.Drawing.Size(0, 20);
            this.gradeHistory.TabIndex = 20;
            // 
            // gradeSinhala
            // 
            this.gradeSinhala.AutoSize = true;
            this.gradeSinhala.Location = new System.Drawing.Point(382, 175);
            this.gradeSinhala.Name = "gradeSinhala";
            this.gradeSinhala.Size = new System.Drawing.Size(0, 20);
            this.gradeSinhala.TabIndex = 19;
            // 
            // btnGetGrade
            // 
            this.btnGetGrade.Location = new System.Drawing.Point(570, 173);
            this.btnGetGrade.Name = "btnGetGrade";
            this.btnGetGrade.Size = new System.Drawing.Size(94, 29);
            this.btnGetGrade.TabIndex = 24;
            this.btnGetGrade.Text = "Get Grade";
            this.btnGetGrade.UseVisualStyleBackColor = true;
            this.btnGetGrade.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetTotal
            // 
            this.btnGetTotal.Location = new System.Drawing.Point(570, 208);
            this.btnGetTotal.Name = "btnGetTotal";
            this.btnGetTotal.Size = new System.Drawing.Size(94, 29);
            this.btnGetTotal.TabIndex = 25;
            this.btnGetTotal.Text = "Get Total";
            this.btnGetTotal.UseVisualStyleBackColor = true;
            this.btnGetTotal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(570, 281);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(94, 29);
            this.btnClr.TabIndex = 27;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(553, 244);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(111, 29);
            this.btnAvg.TabIndex = 26;
            this.btnAvg.Text = "Get Average";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(570, 318);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(94, 29);
            this.btnPop.TabIndex = 28;
            this.btnPop.Text = "Comment";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnGetTotal);
            this.Controls.Add(this.btnGetGrade);
            this.Controls.Add(this.gradeScience);
            this.Controls.Add(this.gradeMath);
            this.Controls.Add(this.gradeEnglish);
            this.Controls.Add(this.gradeHistory);
            this.Controls.Add(this.gradeSinhala);
            this.Controls.Add(this.disAvg);
            this.Controls.Add(this.disTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inScience);
            this.Controls.Add(this.inMath);
            this.Controls.Add(this.inEng);
            this.Controls.Add(this.inHistory);
            this.Controls.Add(this.inSinhala);
            this.Controls.Add(this.inNumber);
            this.Controls.Add(this.inName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox inName;
        private TextBox inNumber;
        private TextBox inSinhala;
        private TextBox inHistory;
        private TextBox inMath;
        private TextBox inEng;
        private TextBox inScience;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label disAvg;
        private Label disTotal;
        private Label gradeScience;
        private Label gradeMath;
        private Label gradeEnglish;
        private Label gradeHistory;
        private Label gradeSinhala;
        private Button btnGetGrade;
        private Button btnGetTotal;
        private Button btnClr;
        private Button btnAvg;
        private Button btnPop;
    }
}