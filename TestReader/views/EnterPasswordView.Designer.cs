namespace TestReader
{
    partial class EnterPasswordView
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.passwordTextF = new System.Windows.Forms.TextBox();
            this.enterPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(56, 73);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(99, 32);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(161, 73);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(99, 32);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // passwordTextF
            // 
            this.passwordTextF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTextF.Location = new System.Drawing.Point(23, 38);
            this.passwordTextF.Name = "passwordTextF";
            this.passwordTextF.Size = new System.Drawing.Size(277, 29);
            this.passwordTextF.TabIndex = 0;
            this.passwordTextF.UseSystemPasswordChar = true;
            this.passwordTextF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextF_KeyPress);
            // 
            // enterPasswordLabel
            // 
            this.enterPasswordLabel.AutoSize = true;
            this.enterPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enterPasswordLabel.Location = new System.Drawing.Point(88, 9);
            this.enterPasswordLabel.Name = "enterPasswordLabel";
            this.enterPasswordLabel.Size = new System.Drawing.Size(141, 24);
            this.enterPasswordLabel.TabIndex = 3;
            this.enterPasswordLabel.Text = "Enter password";
            // 
            // EnterPasswordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(326, 117);
            this.Controls.Add(this.enterPasswordLabel);
            this.Controls.Add(this.passwordTextF);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cancelButton);
            this.MaximizeBox = false;
            this.Name = "EnterPasswordView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox passwordTextF;
        private System.Windows.Forms.Label enterPasswordLabel;
    }
}