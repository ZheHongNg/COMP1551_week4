
namespace COMP1551_week4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FNameTxt = new System.Windows.Forms.TextBox();
            this.LNameTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DltBtn = new System.Windows.Forms.Button();
            this.PrvBtn = new System.Windows.Forms.Button();
            this.NxtBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // FNameTxt
            // 
            this.FNameTxt.Location = new System.Drawing.Point(28, 44);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.Size = new System.Drawing.Size(179, 20);
            this.FNameTxt.TabIndex = 3;
            // 
            // LNameTxt
            // 
            this.LNameTxt.Location = new System.Drawing.Point(28, 109);
            this.LNameTxt.Name = "LNameTxt";
            this.LNameTxt.Size = new System.Drawing.Size(179, 20);
            this.LNameTxt.TabIndex = 4;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(31, 154);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(176, 20);
            this.EmailTxt.TabIndex = 5;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(31, 193);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DltBtn
            // 
            this.DltBtn.Location = new System.Drawing.Point(132, 193);
            this.DltBtn.Name = "DltBtn";
            this.DltBtn.Size = new System.Drawing.Size(75, 23);
            this.DltBtn.TabIndex = 7;
            this.DltBtn.Text = "Delete";
            this.DltBtn.UseVisualStyleBackColor = true;
            this.DltBtn.Click += new System.EventHandler(this.DltBtn_Click);
            // 
            // PrvBtn
            // 
            this.PrvBtn.Location = new System.Drawing.Point(31, 223);
            this.PrvBtn.Name = "PrvBtn";
            this.PrvBtn.Size = new System.Drawing.Size(75, 23);
            this.PrvBtn.TabIndex = 8;
            this.PrvBtn.Text = "Previous";
            this.PrvBtn.UseVisualStyleBackColor = true;
            this.PrvBtn.Click += new System.EventHandler(this.PrvBtn_Click);
            // 
            // NxtBtn
            // 
            this.NxtBtn.Location = new System.Drawing.Point(132, 223);
            this.NxtBtn.Name = "NxtBtn";
            this.NxtBtn.Size = new System.Drawing.Size(75, 23);
            this.NxtBtn.TabIndex = 9;
            this.NxtBtn.Text = "Next";
            this.NxtBtn.UseVisualStyleBackColor = true;
            this.NxtBtn.Click += new System.EventHandler(this.NxtBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "No record";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 291);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NxtBtn);
            this.Controls.Add(this.PrvBtn);
            this.Controls.Add(this.DltBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.LNameTxt);
            this.Controls.Add(this.FNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FNameTxt;
        private System.Windows.Forms.TextBox LNameTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DltBtn;
        private System.Windows.Forms.Button PrvBtn;
        private System.Windows.Forms.Button NxtBtn;
        private System.Windows.Forms.Label label4;
    }
}

