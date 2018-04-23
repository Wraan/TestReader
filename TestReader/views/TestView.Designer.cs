namespace TestReader
{
    partial class TestView
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
            this.components = new System.ComponentModel.Container();
            this.timerLabel = new System.Windows.Forms.Label();
            this.questionsNumbersLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.questionTextF = new System.Windows.Forms.TextBox();
            this.answer4Control = new TestReader.AnswerControl();
            this.answer3Control = new TestReader.AnswerControl();
            this.answer2Control = new TestReader.AnswerControl();
            this.answer1Control = new TestReader.AnswerControl();
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timerLabel.Location = new System.Drawing.Point(132, 41);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 39);
            this.timerLabel.TabIndex = 4;
            // 
            // questionsNumbersLabel
            // 
            this.questionsNumbersLabel.AutoSize = true;
            this.questionsNumbersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionsNumbersLabel.Location = new System.Drawing.Point(173, 115);
            this.questionsNumbersLabel.Name = "questionsNumbersLabel";
            this.questionsNumbersLabel.Size = new System.Drawing.Size(0, 31);
            this.questionsNumbersLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Question: ";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitButton.Location = new System.Drawing.Point(45, 202);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(267, 84);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit Test";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prevButton.Location = new System.Drawing.Point(45, 510);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(125, 68);
            this.prevButton.TabIndex = 8;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextButton.Location = new System.Drawing.Point(187, 510);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(125, 68);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // questionTextF
            // 
            this.questionTextF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.questionTextF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionTextF.Location = new System.Drawing.Point(405, 29);
            this.questionTextF.Multiline = true;
            this.questionTextF.Name = "questionTextF";
            this.questionTextF.ReadOnly = true;
            this.questionTextF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.questionTextF.Size = new System.Drawing.Size(591, 94);
            this.questionTextF.TabIndex = 10;
            // 
            // answer4Control
            // 
            this.answer4Control.AnswerNumber = 0;
            this.answer4Control.Location = new System.Drawing.Point(350, 510);
            this.answer4Control.Name = "answer4Control";
            this.answer4Control.Size = new System.Drawing.Size(651, 105);
            this.answer4Control.TabIndex = 3;
            // 
            // answer3Control
            // 
            this.answer3Control.AnswerNumber = 0;
            this.answer3Control.Location = new System.Drawing.Point(350, 400);
            this.answer3Control.Name = "answer3Control";
            this.answer3Control.Size = new System.Drawing.Size(651, 104);
            this.answer3Control.TabIndex = 2;
            // 
            // answer2Control
            // 
            this.answer2Control.AnswerNumber = 0;
            this.answer2Control.Location = new System.Drawing.Point(350, 291);
            this.answer2Control.Name = "answer2Control";
            this.answer2Control.Size = new System.Drawing.Size(651, 103);
            this.answer2Control.TabIndex = 1;
            // 
            // answer1Control
            // 
            this.answer1Control.AnswerNumber = 0;
            this.answer1Control.Location = new System.Drawing.Point(350, 180);
            this.answer1Control.Name = "answer1Control";
            this.answer1Control.Size = new System.Drawing.Size(651, 105);
            this.answer1Control.TabIndex = 0;
            // 
            // TestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1038, 631);
            this.Controls.Add(this.questionTextF);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionsNumbersLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.answer4Control);
            this.Controls.Add(this.answer3Control);
            this.Controls.Add(this.answer2Control);
            this.Controls.Add(this.answer1Control);
            this.MaximizeBox = false;
            this.Name = "TestView";
            this.Text = "TestView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestView_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AnswerControl answer1Control;
        private AnswerControl answer2Control;
        private AnswerControl answer3Control;
        private AnswerControl answer4Control;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label questionsNumbersLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox questionTextF;
    }
}