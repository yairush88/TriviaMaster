namespace TriviaMaster.App
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox groupBoxAnswers;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnHoliday;
        private System.Windows.Forms.Button btnIsrael;
        private System.Windows.Forms.Button btnJerusalem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblQuestion = new Label();
            groupBoxAnswers = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            btnNext = new Button();
            lblScore = new Label();
            btnRetry = new Button();
            btnHoliday = new Button();
            btnIsrael = new Button();
            btnJerusalem = new Button();
            groupBoxAnswers.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 14F);
            lblQuestion.Location = new Point(359, 152);
            lblQuestion.Margin = new Padding(6, 0, 6, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.RightToLeft = RightToLeft.Yes;
            lblQuestion.Size = new Size(187, 51);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "שאלה כאן";
            // 
            // groupBoxAnswers
            // 
            groupBoxAnswers.Controls.Add(radioButton1);
            groupBoxAnswers.Controls.Add(radioButton2);
            groupBoxAnswers.Controls.Add(radioButton3);
            groupBoxAnswers.Controls.Add(radioButton4);
            groupBoxAnswers.Location = new Point(343, 223);
            groupBoxAnswers.Margin = new Padding(6);
            groupBoxAnswers.Name = "groupBoxAnswers";
            groupBoxAnswers.Padding = new Padding(6);
            groupBoxAnswers.RightToLeft = RightToLeft.Yes;
            groupBoxAnswers.Size = new Size(669, 320);
            groupBoxAnswers.TabIndex = 1;
            groupBoxAnswers.TabStop = false;
            groupBoxAnswers.Text = "תשובות";
            groupBoxAnswers.Enter += groupBoxAnswers_Enter;
            // 
            // radioButton1
            // 
            radioButton1.Location = new Point(503, 44);
            radioButton1.Margin = new Padding(6);
            radioButton1.Name = "radioButton1";
            radioButton1.RightToLeft = RightToLeft.Yes;
            radioButton1.Size = new Size(150, 36);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "תשובה 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Location = new Point(503, 97);
            radioButton2.Margin = new Padding(6);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(150, 36);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "תשובה 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.Location = new Point(503, 150);
            radioButton3.Margin = new Padding(6);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(150, 36);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "תשובה 3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.Location = new Point(503, 204);
            radioButton4.Margin = new Padding(6);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(150, 36);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "תשובה 4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(343, 565);
            btnNext.Margin = new Padding(6);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(139, 49);
            btnNext.TabIndex = 2;
            btnNext.Text = "בדוק";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(343, 653);
            lblScore.Margin = new Padding(6, 0, 6, 0);
            lblScore.Name = "lblScore";
            lblScore.RightToLeft = RightToLeft.Yes;
            lblScore.Size = new Size(166, 32);
            lblScore.TabIndex = 3;
            lblScore.Text = "נכון: 0 מתוך 10";
            // 
            // btnRetry
            // 
            btnRetry.Location = new Point(590, 565);
            btnRetry.Margin = new Padding(6);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(139, 49);
            btnRetry.TabIndex = 4;
            btnRetry.Text = "שחק שוב";
            btnRetry.UseVisualStyleBackColor = true;
            btnRetry.Visible = false;
            btnRetry.Click += btnRetry_Click;
            // 
            // btnHoliday
            // 
            btnHoliday.Location = new Point(606, 106);
            btnHoliday.Margin = new Padding(6);
            btnHoliday.Name = "btnHoliday";
            btnHoliday.Size = new Size(139, 49);
            btnHoliday.TabIndex = 5;
            btnHoliday.Text = "חגים ומועדים";
            btnHoliday.UseVisualStyleBackColor = true;
            btnHoliday.Click += btnHoliday_Click;
            // 
            // btnIsrael
            // 
            btnIsrael.Location = new Point(606, 191);
            btnIsrael.Margin = new Padding(6);
            btnIsrael.Name = "btnIsrael";
            btnIsrael.Size = new Size(139, 49);
            btnIsrael.TabIndex = 6;
            btnIsrael.Text = "ישראל וציונות";
            btnIsrael.UseVisualStyleBackColor = true;
            btnIsrael.Click += btnIsrael_Click;
            // 
            // btnJerusalem
            // 
            btnJerusalem.Location = new Point(606, 276);
            btnJerusalem.Margin = new Padding(6);
            btnJerusalem.Name = "btnJerusalem";
            btnJerusalem.Size = new Size(139, 49);
            btnJerusalem.TabIndex = 7;
            btnJerusalem.Text = "ירושלים";
            btnJerusalem.UseVisualStyleBackColor = true;
            btnJerusalem.Click += btnJerusalem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 1029);
            Controls.Add(btnJerusalem);
            Controls.Add(btnIsrael);
            Controls.Add(btnHoliday);
            Controls.Add(btnRetry);
            Controls.Add(lblScore);
            Controls.Add(btnNext);
            Controls.Add(groupBoxAnswers);
            Controls.Add(lblQuestion);
            Margin = new Padding(6);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "משחק טריוויה";
            groupBoxAnswers.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
