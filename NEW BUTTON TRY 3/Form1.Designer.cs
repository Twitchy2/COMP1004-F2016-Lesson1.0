namespace NEW_BUTTON_TRY_3
{
    partial class Form1
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
            this.buttonPress = new System.Windows.Forms.Button();
            this.wordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPress
            // 
            this.buttonPress.Location = new System.Drawing.Point(101, 193);
            this.buttonPress.Name = "buttonPress";
            this.buttonPress.Size = new System.Drawing.Size(85, 35);
            this.buttonPress.TabIndex = 0;
            this.buttonPress.Text = "Press me";
            this.buttonPress.UseVisualStyleBackColor = true;
            this.buttonPress.Click += new System.EventHandler(this.buttonPress_Click);
            this.buttonPress.MouseHover += new System.EventHandler(this.buttonPress_MouseHover);
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(74, 65);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(132, 26);
            this.wordLabel.TabIndex = 1;
            this.wordLabel.Text = "Guess what happens \r\nwhen you press the button";
            this.wordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 271);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.buttonPress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Press The Button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPress;
        private System.Windows.Forms.Label wordLabel;
    }
}

