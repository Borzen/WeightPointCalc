namespace Weighed_Grade_Calculator
{
    partial class PartsPopup
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
            this.gradeTxtBox = new System.Windows.Forms.TextBox();
            this.weightTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitbttn = new System.Windows.Forms.Button();
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gradeTxtBox
            // 
            this.gradeTxtBox.Location = new System.Drawing.Point(114, 126);
            this.gradeTxtBox.Name = "gradeTxtBox";
            this.gradeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.gradeTxtBox.TabIndex = 0;
            // 
            // weightTxtBox
            // 
            this.weightTxtBox.Location = new System.Drawing.Point(113, 153);
            this.weightTxtBox.Name = "weightTxtBox";
            this.weightTxtBox.Size = new System.Drawing.Size(100, 20);
            this.weightTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grade in part";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight";
            // 
            // submitbttn
            // 
            this.submitbttn.Location = new System.Drawing.Point(126, 179);
            this.submitbttn.Name = "submitbttn";
            this.submitbttn.Size = new System.Drawing.Size(75, 23);
            this.submitbttn.TabIndex = 4;
            this.submitbttn.Text = "Submit";
            this.submitbttn.UseVisualStyleBackColor = true;
            this.submitbttn.Click += new System.EventHandler(this.submitbttn_Click);
            // 
            // messageTxt
            // 
            this.messageTxt.Enabled = false;
            this.messageTxt.Location = new System.Drawing.Point(12, 60);
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(436, 20);
            this.messageTxt.TabIndex = 5;
            // 
            // PartsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 316);
            this.Controls.Add(this.messageTxt);
            this.Controls.Add(this.submitbttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weightTxtBox);
            this.Controls.Add(this.gradeTxtBox);
            this.Name = "PartsPopup";
            this.Text = "PartsPopup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PartsPopup_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gradeTxtBox;
        private System.Windows.Forms.TextBox weightTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitbttn;
        private System.Windows.Forms.TextBox messageTxt;
    }
}