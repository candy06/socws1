namespace CalculatorClient
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
            this.buttonSumEP1 = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonSumEP2 = new System.Windows.Forms.Button();
            this.buttonSubEP1 = new System.Windows.Forms.Button();
            this.buttonSubEP2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSumEP1
            // 
            this.buttonSumEP1.Location = new System.Drawing.Point(28, 169);
            this.buttonSumEP1.Name = "buttonSumEP1";
            this.buttonSumEP1.Size = new System.Drawing.Size(119, 23);
            this.buttonSumEP1.TabIndex = 0;
            this.buttonSumEP1.Text = "Sum1";
            this.buttonSumEP1.UseVisualStyleBackColor = true;
            this.buttonSumEP1.Click += new System.EventHandler(this.buttonSumEP1_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(74, 40);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 1;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(74, 66);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "B = ";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(42, 107);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(67, 13);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Result: none";
            // 
            // buttonSumEP2
            // 
            this.buttonSumEP2.Location = new System.Drawing.Point(28, 198);
            this.buttonSumEP2.Name = "buttonSumEP2";
            this.buttonSumEP2.Size = new System.Drawing.Size(119, 23);
            this.buttonSumEP2.TabIndex = 6;
            this.buttonSumEP2.Text = "Sum2";
            this.buttonSumEP2.UseVisualStyleBackColor = true;
            this.buttonSumEP2.Click += new System.EventHandler(this.buttonSumEP2_Click);
            // 
            // buttonSubEP1
            // 
            this.buttonSubEP1.Location = new System.Drawing.Point(153, 169);
            this.buttonSubEP1.Name = "buttonSubEP1";
            this.buttonSubEP1.Size = new System.Drawing.Size(119, 23);
            this.buttonSubEP1.TabIndex = 7;
            this.buttonSubEP1.Text = "Sub1";
            this.buttonSubEP1.UseVisualStyleBackColor = true;
            this.buttonSubEP1.Click += new System.EventHandler(this.buttonSubEP1_Click);
            // 
            // buttonSubEP2
            // 
            this.buttonSubEP2.Location = new System.Drawing.Point(153, 198);
            this.buttonSubEP2.Name = "buttonSubEP2";
            this.buttonSubEP2.Size = new System.Drawing.Size(119, 23);
            this.buttonSubEP2.TabIndex = 8;
            this.buttonSubEP2.Text = "Sub2";
            this.buttonSubEP2.UseVisualStyleBackColor = true;
            this.buttonSubEP2.Click += new System.EventHandler(this.buttonSubEP2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSubEP2);
            this.Controls.Add(this.buttonSubEP1);
            this.Controls.Add(this.buttonSumEP2);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.buttonSumEP1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSumEP1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonSumEP2;
        private System.Windows.Forms.Button buttonSubEP1;
        private System.Windows.Forms.Button buttonSubEP2;
    }
}

