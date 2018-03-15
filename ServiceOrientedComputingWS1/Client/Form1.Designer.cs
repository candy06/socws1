namespace Client
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
            this.button1 = new System.Windows.Forms.Button();
            this.citiesList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.stationsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.selectNewCityButton = new System.Windows.Forms.Button();
            this.selectNewStationButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show cities";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // citiesList
            // 
            this.citiesList.FormattingEnabled = true;
            this.citiesList.Location = new System.Drawing.Point(28, 248);
            this.citiesList.Name = "citiesList";
            this.citiesList.Size = new System.Drawing.Size(165, 238);
            this.citiesList.TabIndex = 1;
            this.citiesList.SelectedIndexChanged += new System.EventHandler(this.citiesList_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(254, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show stations";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stationsList
            // 
            this.stationsList.FormattingEnabled = true;
            this.stationsList.Location = new System.Drawing.Point(254, 248);
            this.stationsList.Name = "stationsList";
            this.stationsList.Size = new System.Drawing.Size(215, 238);
            this.stationsList.TabIndex = 3;
            this.stationsList.SelectedIndexChanged += new System.EventHandler(this.stationsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(710, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(510, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 51);
            this.button3.TabIndex = 5;
            this.button3.Text = "How many bikes?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // selectNewCityButton
            // 
            this.selectNewCityButton.Enabled = false;
            this.selectNewCityButton.Location = new System.Drawing.Point(28, 492);
            this.selectNewCityButton.Name = "selectNewCityButton";
            this.selectNewCityButton.Size = new System.Drawing.Size(161, 23);
            this.selectNewCityButton.TabIndex = 6;
            this.selectNewCityButton.Text = "Select new city";
            this.selectNewCityButton.UseVisualStyleBackColor = true;
            this.selectNewCityButton.Click += new System.EventHandler(this.selectNewCityButton_Click);
            // 
            // selectNewStationButton
            // 
            this.selectNewStationButton.Enabled = false;
            this.selectNewStationButton.Location = new System.Drawing.Point(254, 492);
            this.selectNewStationButton.Name = "selectNewStationButton";
            this.selectNewStationButton.Size = new System.Drawing.Size(214, 23);
            this.selectNewStationButton.TabIndex = 7;
            this.selectNewStationButton.Text = "Select new station";
            this.selectNewStationButton.UseVisualStyleBackColor = true;
            this.selectNewStationButton.Click += new System.EventHandler(this.selectNewStationButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "Are you looking for a bike?";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 59);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(391, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 106);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(391, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(510, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 267);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Execution times";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectNewStationButton);
            this.Controls.Add(this.selectNewCityButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stationsList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.citiesList);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox citiesList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox stationsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button selectNewCityButton;
        private System.Windows.Forms.Button selectNewStationButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

