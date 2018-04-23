namespace TestReader
{
    partial class AnswerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.choosenCheckbox = new System.Windows.Forms.CheckBox();
            this.answerTextF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // choosenCheckbox
            // 
            this.choosenCheckbox.AutoSize = true;
            this.choosenCheckbox.Location = new System.Drawing.Point(6, 43);
            this.choosenCheckbox.Name = "choosenCheckbox";
            this.choosenCheckbox.Size = new System.Drawing.Size(15, 14);
            this.choosenCheckbox.TabIndex = 0;
            this.choosenCheckbox.UseVisualStyleBackColor = true;
            this.choosenCheckbox.Click += new System.EventHandler(this.choosenCheckbox_Click);
            // 
            // answerTextF
            // 
            this.answerTextF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.answerTextF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerTextF.Location = new System.Drawing.Point(53, 3);
            this.answerTextF.Multiline = true;
            this.answerTextF.Name = "answerTextF";
            this.answerTextF.ReadOnly = true;
            this.answerTextF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answerTextF.Size = new System.Drawing.Size(593, 94);
            this.answerTextF.TabIndex = 2;
            // 
            // AnswerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.answerTextF);
            this.Controls.Add(this.choosenCheckbox);
            this.Name = "AnswerControl";
            this.Size = new System.Drawing.Size(649, 102);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox choosenCheckbox;
        private System.Windows.Forms.TextBox answerTextF;
    }
}
