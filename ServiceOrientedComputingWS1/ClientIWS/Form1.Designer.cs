namespace ClientIWS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSelectCity = new System.Windows.Forms.Button();
            this.buttonMoreInformation = new System.Windows.Forms.Button();
            this.buttonBikes = new System.Windows.Forms.Button();
            this.buttonStations = new System.Windows.Forms.Button();
            this.buttonCities = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.labelSelectedStation = new System.Windows.Forms.Label();
            this.labelSelectedCity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCities = new System.Windows.Forms.ListBox();
            this.listBoxStations = new System.Windows.Forms.ListBox();
            this.labelError = new System.Windows.Forms.Label();
            this.labelAvailableBikes = new System.Windows.Forms.Label();
            this.labelMoreInformation = new System.Windows.Forms.Label();
            this.labelExecutionTime = new System.Windows.Forms.Label();
            this.SubscribeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSelectCity);
            this.panel1.Controls.Add(this.buttonMoreInformation);
            this.panel1.Controls.Add(this.buttonBikes);
            this.panel1.Controls.Add(this.buttonStations);
            this.panel1.Controls.Add(this.buttonCities);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 723);
            this.panel1.TabIndex = 0;
            // 
            // buttonSelectCity
            // 
            this.buttonSelectCity.FlatAppearance.BorderSize = 0;
            this.buttonSelectCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectCity.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectCity.ForeColor = System.Drawing.Color.White;
            this.buttonSelectCity.Location = new System.Drawing.Point(0, 526);
            this.buttonSelectCity.Name = "buttonSelectCity";
            this.buttonSelectCity.Size = new System.Drawing.Size(199, 106);
            this.buttonSelectCity.TabIndex = 0;
            this.buttonSelectCity.Text = "Select another city";
            this.buttonSelectCity.UseVisualStyleBackColor = true;
            this.buttonSelectCity.Visible = false;
            this.buttonSelectCity.Click += new System.EventHandler(this.ButtonSelectCity_Click);
            // 
            // buttonMoreInformation
            // 
            this.buttonMoreInformation.FlatAppearance.BorderSize = 0;
            this.buttonMoreInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoreInformation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoreInformation.ForeColor = System.Drawing.Color.White;
            this.buttonMoreInformation.Location = new System.Drawing.Point(0, 427);
            this.buttonMoreInformation.Name = "buttonMoreInformation";
            this.buttonMoreInformation.Size = new System.Drawing.Size(199, 93);
            this.buttonMoreInformation.TabIndex = 4;
            this.buttonMoreInformation.Text = "More information";
            this.buttonMoreInformation.UseVisualStyleBackColor = true;
            this.buttonMoreInformation.Click += new System.EventHandler(this.ButtonMoreInformation_Click);
            // 
            // buttonBikes
            // 
            this.buttonBikes.FlatAppearance.BorderSize = 0;
            this.buttonBikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBikes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBikes.ForeColor = System.Drawing.Color.White;
            this.buttonBikes.Location = new System.Drawing.Point(0, 328);
            this.buttonBikes.Name = "buttonBikes";
            this.buttonBikes.Size = new System.Drawing.Size(199, 93);
            this.buttonBikes.TabIndex = 3;
            this.buttonBikes.Text = "Bikes";
            this.buttonBikes.UseVisualStyleBackColor = true;
            this.buttonBikes.Click += new System.EventHandler(this.ButtonBikes_Click);
            // 
            // buttonStations
            // 
            this.buttonStations.FlatAppearance.BorderSize = 0;
            this.buttonStations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStations.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStations.ForeColor = System.Drawing.Color.White;
            this.buttonStations.Location = new System.Drawing.Point(0, 229);
            this.buttonStations.Name = "buttonStations";
            this.buttonStations.Size = new System.Drawing.Size(199, 93);
            this.buttonStations.TabIndex = 2;
            this.buttonStations.Text = "Stations";
            this.buttonStations.UseVisualStyleBackColor = true;
            this.buttonStations.Click += new System.EventHandler(this.ButtonStations_Click);
            // 
            // buttonCities
            // 
            this.buttonCities.FlatAppearance.BorderSize = 0;
            this.buttonCities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCities.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCities.ForeColor = System.Drawing.Color.White;
            this.buttonCities.Location = new System.Drawing.Point(0, 130);
            this.buttonCities.Name = "buttonCities";
            this.buttonCities.Size = new System.Drawing.Size(199, 93);
            this.buttonCities.TabIndex = 1;
            this.buttonCities.Text = "Cities";
            this.buttonCities.UseVisualStyleBackColor = true;
            this.buttonCities.Click += new System.EventHandler(this.ButtonCities_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(199, 130);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(7, 93);
            this.panelLeft.TabIndex = 2;
            this.panelLeft.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(267, 56);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(96, 33);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "label2";
            this.labelTitle.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SubscribeButton);
            this.panel4.Controls.Add(this.map);
            this.panel4.Controls.Add(this.labelSelectedStation);
            this.panel4.Controls.Add(this.labelSelectedCity);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(990, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(466, 723);
            this.panel4.TabIndex = 4;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(17, 375);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 100;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = false;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(437, 278);
            this.map.TabIndex = 8;
            this.map.Visible = false;
            this.map.Zoom = 15D;
            // 
            // labelSelectedStation
            // 
            this.labelSelectedStation.AutoSize = true;
            this.labelSelectedStation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelSelectedStation.Location = new System.Drawing.Point(45, 328);
            this.labelSelectedStation.Name = "labelSelectedStation";
            this.labelSelectedStation.Size = new System.Drawing.Size(51, 19);
            this.labelSelectedStation.TabIndex = 4;
            this.labelSelectedStation.Text = "None";
            // 
            // labelSelectedCity
            // 
            this.labelSelectedCity.AutoSize = true;
            this.labelSelectedCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelSelectedCity.Location = new System.Drawing.Point(45, 189);
            this.labelSelectedCity.Name = "labelSelectedCity";
            this.labelSelectedCity.Size = new System.Drawing.Size(51, 19);
            this.labelSelectedCity.TabIndex = 3;
            this.labelSelectedCity.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Selected station";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selected city";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(466, 100);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, -19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 117);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recap\'";
            // 
            // listBoxCities
            // 
            this.listBoxCities.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxCities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCities.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCities.FormattingEnabled = true;
            this.listBoxCities.ItemHeight = 22;
            this.listBoxCities.Location = new System.Drawing.Point(455, 100);
            this.listBoxCities.Name = "listBoxCities";
            this.listBoxCities.Size = new System.Drawing.Size(393, 396);
            this.listBoxCities.TabIndex = 5;
            this.listBoxCities.Visible = false;
            this.listBoxCities.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // listBoxStations
            // 
            this.listBoxStations.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxStations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxStations.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStations.FormattingEnabled = true;
            this.listBoxStations.ItemHeight = 22;
            this.listBoxStations.Location = new System.Drawing.Point(455, 100);
            this.listBoxStations.Name = "listBoxStations";
            this.listBoxStations.Size = new System.Drawing.Size(393, 396);
            this.listBoxStations.TabIndex = 6;
            this.listBoxStations.Visible = false;
            this.listBoxStations.SelectedIndexChanged += new System.EventHandler(this.ListBoxStations_SelectedIndexChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelError.Location = new System.Drawing.Point(269, 109);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(96, 33);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "label5";
            this.labelError.Visible = false;
            // 
            // labelAvailableBikes
            // 
            this.labelAvailableBikes.AutoSize = true;
            this.labelAvailableBikes.Font = new System.Drawing.Font("Monotype Corsiva", 200.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableBikes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelAvailableBikes.Location = new System.Drawing.Point(502, 152);
            this.labelAvailableBikes.Name = "labelAvailableBikes";
            this.labelAvailableBikes.Size = new System.Drawing.Size(240, 292);
            this.labelAvailableBikes.TabIndex = 5;
            this.labelAvailableBikes.Text = "0";
            this.labelAvailableBikes.Visible = false;
            // 
            // labelMoreInformation
            // 
            this.labelMoreInformation.AutoSize = true;
            this.labelMoreInformation.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoreInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelMoreInformation.Location = new System.Drawing.Point(305, 118);
            this.labelMoreInformation.Name = "labelMoreInformation";
            this.labelMoreInformation.Size = new System.Drawing.Size(74, 24);
            this.labelMoreInformation.TabIndex = 5;
            this.labelMoreInformation.Text = "label5";
            this.labelMoreInformation.Visible = false;
            // 
            // labelExecutionTime
            // 
            this.labelExecutionTime.AutoSize = true;
            this.labelExecutionTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExecutionTime.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelExecutionTime.Location = new System.Drawing.Point(790, 646);
            this.labelExecutionTime.Name = "labelExecutionTime";
            this.labelExecutionTime.Size = new System.Drawing.Size(58, 19);
            this.labelExecutionTime.TabIndex = 8;
            this.labelExecutionTime.Text = "label5";
            this.labelExecutionTime.Visible = false;
            // 
            // SubscribeButton
            // 
            this.SubscribeButton.Location = new System.Drawing.Point(25, 668);
            this.SubscribeButton.Name = "SubscribeButton";
            this.SubscribeButton.Size = new System.Drawing.Size(218, 43);
            this.SubscribeButton.TabIndex = 9;
            this.SubscribeButton.Text = "Subscribe";
            this.SubscribeButton.UseVisualStyleBackColor = true;
            this.SubscribeButton.Click += new System.EventHandler(this.SubscribeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1456, 723);
            this.Controls.Add(this.labelExecutionTime);
            this.Controls.Add(this.labelMoreInformation);
            this.Controls.Add(this.labelAvailableBikes);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.listBoxStations);
            this.Controls.Add(this.listBoxCities);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "IWS Client";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMoreInformation;
        private System.Windows.Forms.Button buttonBikes;
        private System.Windows.Forms.Button buttonStations;
        private System.Windows.Forms.Button buttonCities;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listBoxCities;
        private System.Windows.Forms.Label labelSelectedStation;
        private System.Windows.Forms.Label labelSelectedCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSelectCity;
        private System.Windows.Forms.ListBox listBoxStations;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelAvailableBikes;
        private System.Windows.Forms.Label labelMoreInformation;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label labelExecutionTime;
        private System.Windows.Forms.Button SubscribeButton;
    }
}

