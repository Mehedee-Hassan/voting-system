namespace Voting_System_App
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
            this.label1 = new System.Windows.Forms.Label();
            this.candidateEntryTextBox = new System.Windows.Forms.TextBox();
            this.symbolTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Candidate Entry:";
            // 
            // candidateEntryTextBox
            // 
            this.candidateEntryTextBox.Location = new System.Drawing.Point(89, 23);
            this.candidateEntryTextBox.Name = "candidateEntryTextBox";
            this.candidateEntryTextBox.Size = new System.Drawing.Size(167, 20);
            this.candidateEntryTextBox.TabIndex = 1;
            // 
            // symbolTextBox
            // 
            this.symbolTextBox.Location = new System.Drawing.Point(89, 64);
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.Size = new System.Drawing.Size(167, 20);
            this.symbolTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Symbol:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(197, 115);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.symbolTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.candidateEntryTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Candidate Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox candidateEntryTextBox;
        private System.Windows.Forms.TextBox symbolTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
    }
}

