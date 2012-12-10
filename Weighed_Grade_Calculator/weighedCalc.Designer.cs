namespace Weighed_Grade_Calculator
{
    partial class WeighedCalculator
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
            this.WPtxtBox = new System.Windows.Forms.TextBox();
            this.GWtxtBox = new System.Windows.Forms.TextBox();
            this.FinaltxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WPtxtBox
            // 
            this.WPtxtBox.Location = new System.Drawing.Point(159, 29);
            this.WPtxtBox.Name = "WPtxtBox";
            this.WPtxtBox.Size = new System.Drawing.Size(100, 20);
            this.WPtxtBox.TabIndex = 0;
            // 
            // GWtxtBox
            // 
            this.GWtxtBox.Location = new System.Drawing.Point(158, 71);
            this.GWtxtBox.Name = "GWtxtBox";
            this.GWtxtBox.Size = new System.Drawing.Size(100, 20);
            this.GWtxtBox.TabIndex = 1;
            // 
            // FinaltxtBox
            // 
            this.FinaltxtBox.Location = new System.Drawing.Point(157, 110);
            this.FinaltxtBox.Name = "FinaltxtBox";
            this.FinaltxtBox.Size = new System.Drawing.Size(100, 20);
            this.FinaltxtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Weighed Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grade Wanted";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Final Precentage";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WeighedCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 212);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinaltxtBox);
            this.Controls.Add(this.GWtxtBox);
            this.Controls.Add(this.WPtxtBox);
            this.Name = "WeighedCalculator";
            this.Text = "Weighed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WPtxtBox;
        private System.Windows.Forms.TextBox GWtxtBox;
        private System.Windows.Forms.TextBox FinaltxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

