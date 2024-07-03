namespace PictureViewer
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.DrawTimer = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.timer30s = new System.Windows.Forms.Button();
            this.timer60s = new System.Windows.Forms.Button();
            this.timer2m = new System.Windows.Forms.Button();
            this.timer5m = new System.Windows.Forms.Button();
            this.timer10m = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.customTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NudePanel = new System.Windows.Forms.Panel();
            this.NudeCheckbox = new System.Windows.Forms.CheckBox();
            this.SetNudeDirectoryButton = new System.Windows.Forms.Button();
            this.NudeDirectoryButton = new System.Windows.Forms.Button();
            this.ClothedPanel = new System.Windows.Forms.Panel();
            this.ClothedCheckbox = new System.Windows.Forms.CheckBox();
            this.SetClothedDirectoryButton = new System.Windows.Forms.Button();
            this.ClothedDirectoryButton = new System.Windows.Forms.Button();
            this.PortraitPanel = new System.Windows.Forms.Panel();
            this.PortraitCheckbox = new System.Windows.Forms.CheckBox();
            this.SetPortraitDirectoryButton = new System.Windows.Forms.Button();
            this.PortraitDirectoryButton = new System.Windows.Forms.Button();
            this.setDirectoryButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.PictureBox1 = new PictureViewer.MyPictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.BufferTimer = new System.Windows.Forms.Timer(this.components);
            this.StepTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.NudePanel.SuspendLayout();
            this.ClothedPanel.SuspendLayout();
            this.PortraitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PictureBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 761F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1459, 761);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.timer30s);
            this.flowLayoutPanel1.Controls.Add(this.timer60s);
            this.flowLayoutPanel1.Controls.Add(this.timer2m);
            this.flowLayoutPanel1.Controls.Add(this.timer5m);
            this.flowLayoutPanel1.Controls.Add(this.timer10m);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.customTime);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.NudePanel);
            this.flowLayoutPanel1.Controls.Add(this.ClothedPanel);
            this.flowLayoutPanel1.Controls.Add(this.PortraitPanel);
            this.flowLayoutPanel1.Controls.Add(this.setDirectoryButton);
            this.flowLayoutPanel1.Controls.Add(this.testButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(155, 596);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.DrawTimer);
            this.flowLayoutPanel2.Controls.Add(this.StartButton);
            this.flowLayoutPanel2.Controls.Add(this.StopButton);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(0, 227);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(149, 227);
            this.flowLayoutPanel2.TabIndex = 210;
            // 
            // DrawTimer
            // 
            this.DrawTimer.BackColor = System.Drawing.Color.LightGray;
            this.DrawTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawTimer.Enabled = false;
            this.DrawTimer.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawTimer.ForeColor = System.Drawing.Color.Coral;
            this.DrawTimer.Location = new System.Drawing.Point(3, 20);
            this.DrawTimer.Margin = new System.Windows.Forms.Padding(3, 20, 3, 15);
            this.DrawTimer.Name = "DrawTimer";
            this.DrawTimer.Size = new System.Drawing.Size(143, 77);
            this.DrawTimer.TabIndex = 4;
            this.DrawTimer.Text = "00:00";
            this.DrawTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(12, 132);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(124, 52);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.StopButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StopButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(25, 190);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(98, 34);
            this.StopButton.TabIndex = 209;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // timer30s
            // 
            this.timer30s.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timer30s.Location = new System.Drawing.Point(40, 236);
            this.timer30s.Name = "timer30s";
            this.timer30s.Size = new System.Drawing.Size(75, 23);
            this.timer30s.TabIndex = 20;
            this.timer30s.Text = "30 Seconds";
            this.timer30s.UseVisualStyleBackColor = true;
            this.timer30s.Click += new System.EventHandler(this.Timer30s_Click);
            // 
            // timer60s
            // 
            this.timer60s.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timer60s.Location = new System.Drawing.Point(40, 265);
            this.timer60s.Name = "timer60s";
            this.timer60s.Size = new System.Drawing.Size(75, 23);
            this.timer60s.TabIndex = 30;
            this.timer60s.Text = "60 Seconds";
            this.timer60s.UseVisualStyleBackColor = true;
            this.timer60s.Click += new System.EventHandler(this.Timer60s_Click);
            // 
            // timer2m
            // 
            this.timer2m.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timer2m.Location = new System.Drawing.Point(40, 294);
            this.timer2m.Name = "timer2m";
            this.timer2m.Size = new System.Drawing.Size(75, 23);
            this.timer2m.TabIndex = 40;
            this.timer2m.Text = "2 minutes";
            this.timer2m.UseVisualStyleBackColor = true;
            this.timer2m.Click += new System.EventHandler(this.Timer2m_Click);
            // 
            // timer5m
            // 
            this.timer5m.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timer5m.Location = new System.Drawing.Point(40, 323);
            this.timer5m.Name = "timer5m";
            this.timer5m.Size = new System.Drawing.Size(75, 23);
            this.timer5m.TabIndex = 50;
            this.timer5m.Text = "5 minutes";
            this.timer5m.UseVisualStyleBackColor = true;
            this.timer5m.Click += new System.EventHandler(this.Timer5m_Click);
            // 
            // timer10m
            // 
            this.timer10m.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timer10m.Location = new System.Drawing.Point(40, 352);
            this.timer10m.Name = "timer10m";
            this.timer10m.Size = new System.Drawing.Size(75, 23);
            this.timer10m.TabIndex = 60;
            this.timer10m.Text = "10 minutes";
            this.timer10m.UseVisualStyleBackColor = true;
            this.timer10m.Click += new System.EventHandler(this.Timer10m_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(33, 384);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 208;
            this.label2.Text = "Custom Time";
            // 
            // customTime
            // 
            this.customTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customTime.Location = new System.Drawing.Point(27, 403);
            this.customTime.Name = "customTime";
            this.customTime.Size = new System.Drawing.Size(100, 20);
            this.customTime.TabIndex = 0;
            this.customTime.TextChanged += new System.EventHandler(this.CustomTime_TextChanged);
            this.customTime.Enter += new System.EventHandler(this.CustomTime_Enter);
            this.customTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlBackspace);
            this.customTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomTimePressKey);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(31, 432);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 205;
            this.label1.Text = "Categories";
            // 
            // NudePanel
            // 
            this.NudePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NudePanel.Controls.Add(this.NudeCheckbox);
            this.NudePanel.Controls.Add(this.SetNudeDirectoryButton);
            this.NudePanel.Controls.Add(this.NudeDirectoryButton);
            this.NudePanel.Location = new System.Drawing.Point(13, 454);
            this.NudePanel.Name = "NudePanel";
            this.NudePanel.Size = new System.Drawing.Size(128, 23);
            this.NudePanel.TabIndex = 206;
            // 
            // NudeCheckbox
            // 
            this.NudeCheckbox.AutoSize = true;
            this.NudeCheckbox.Location = new System.Drawing.Point(7, 5);
            this.NudeCheckbox.Name = "NudeCheckbox";
            this.NudeCheckbox.Size = new System.Drawing.Size(15, 14);
            this.NudeCheckbox.TabIndex = 204;
            this.NudeCheckbox.UseVisualStyleBackColor = true;
            this.NudeCheckbox.CheckedChanged += new System.EventHandler(this.NudeCheckbox_CheckedChanged);
            // 
            // SetNudeDirectoryButton
            // 
            this.SetNudeDirectoryButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SetNudeDirectoryButton.AutoSize = true;
            this.SetNudeDirectoryButton.Location = new System.Drawing.Point(102, 0);
            this.SetNudeDirectoryButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.SetNudeDirectoryButton.Name = "SetNudeDirectoryButton";
            this.SetNudeDirectoryButton.Size = new System.Drawing.Size(26, 23);
            this.SetNudeDirectoryButton.TabIndex = 203;
            this.SetNudeDirectoryButton.Text = "...";
            this.SetNudeDirectoryButton.UseVisualStyleBackColor = true;
            this.SetNudeDirectoryButton.Click += new System.EventHandler(this.SetNudeDirectoryButton_Click);
            // 
            // NudeDirectoryButton
            // 
            this.NudeDirectoryButton.AutoSize = true;
            this.NudeDirectoryButton.Location = new System.Drawing.Point(25, 0);
            this.NudeDirectoryButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.NudeDirectoryButton.Name = "NudeDirectoryButton";
            this.NudeDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.NudeDirectoryButton.TabIndex = 202;
            this.NudeDirectoryButton.Text = " Nude";
            this.NudeDirectoryButton.UseVisualStyleBackColor = true;
            this.NudeDirectoryButton.Click += new System.EventHandler(this.NudeDirectoryButton_Click);
            // 
            // ClothedPanel
            // 
            this.ClothedPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClothedPanel.Controls.Add(this.ClothedCheckbox);
            this.ClothedPanel.Controls.Add(this.SetClothedDirectoryButton);
            this.ClothedPanel.Controls.Add(this.ClothedDirectoryButton);
            this.ClothedPanel.Location = new System.Drawing.Point(13, 483);
            this.ClothedPanel.Name = "ClothedPanel";
            this.ClothedPanel.Size = new System.Drawing.Size(128, 23);
            this.ClothedPanel.TabIndex = 207;
            // 
            // ClothedCheckbox
            // 
            this.ClothedCheckbox.AutoSize = true;
            this.ClothedCheckbox.Location = new System.Drawing.Point(7, 5);
            this.ClothedCheckbox.Name = "ClothedCheckbox";
            this.ClothedCheckbox.Size = new System.Drawing.Size(15, 14);
            this.ClothedCheckbox.TabIndex = 205;
            this.ClothedCheckbox.UseVisualStyleBackColor = true;
            this.ClothedCheckbox.CheckedChanged += new System.EventHandler(this.ClothedCheckbox_CheckedChanged);
            // 
            // SetClothedDirectoryButton
            // 
            this.SetClothedDirectoryButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SetClothedDirectoryButton.AutoSize = true;
            this.SetClothedDirectoryButton.Location = new System.Drawing.Point(102, 0);
            this.SetClothedDirectoryButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.SetClothedDirectoryButton.Name = "SetClothedDirectoryButton";
            this.SetClothedDirectoryButton.Size = new System.Drawing.Size(26, 23);
            this.SetClothedDirectoryButton.TabIndex = 203;
            this.SetClothedDirectoryButton.Text = "...";
            this.SetClothedDirectoryButton.UseVisualStyleBackColor = true;
            this.SetClothedDirectoryButton.Click += new System.EventHandler(this.SetClothedDirectoryButton_Click);
            // 
            // ClothedDirectoryButton
            // 
            this.ClothedDirectoryButton.AutoSize = true;
            this.ClothedDirectoryButton.Location = new System.Drawing.Point(25, 0);
            this.ClothedDirectoryButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ClothedDirectoryButton.Name = "ClothedDirectoryButton";
            this.ClothedDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.ClothedDirectoryButton.TabIndex = 202;
            this.ClothedDirectoryButton.Text = "Clothed";
            this.ClothedDirectoryButton.UseVisualStyleBackColor = true;
            this.ClothedDirectoryButton.Click += new System.EventHandler(this.ClothedDirectoryButton_Click);
            // 
            // PortraitPanel
            // 
            this.PortraitPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PortraitPanel.Controls.Add(this.PortraitCheckbox);
            this.PortraitPanel.Controls.Add(this.SetPortraitDirectoryButton);
            this.PortraitPanel.Controls.Add(this.PortraitDirectoryButton);
            this.PortraitPanel.Location = new System.Drawing.Point(13, 512);
            this.PortraitPanel.Name = "PortraitPanel";
            this.PortraitPanel.Size = new System.Drawing.Size(128, 23);
            this.PortraitPanel.TabIndex = 207;
            // 
            // PortraitCheckbox
            // 
            this.PortraitCheckbox.AutoSize = true;
            this.PortraitCheckbox.Location = new System.Drawing.Point(7, 5);
            this.PortraitCheckbox.Name = "PortraitCheckbox";
            this.PortraitCheckbox.Size = new System.Drawing.Size(15, 14);
            this.PortraitCheckbox.TabIndex = 206;
            this.PortraitCheckbox.UseVisualStyleBackColor = true;
            this.PortraitCheckbox.CheckedChanged += new System.EventHandler(this.PortraitCheckbox_CheckedChanged);
            // 
            // SetPortraitDirectoryButton
            // 
            this.SetPortraitDirectoryButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SetPortraitDirectoryButton.AutoSize = true;
            this.SetPortraitDirectoryButton.Location = new System.Drawing.Point(102, 0);
            this.SetPortraitDirectoryButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.SetPortraitDirectoryButton.Name = "SetPortraitDirectoryButton";
            this.SetPortraitDirectoryButton.Size = new System.Drawing.Size(26, 23);
            this.SetPortraitDirectoryButton.TabIndex = 203;
            this.SetPortraitDirectoryButton.Text = "...";
            this.SetPortraitDirectoryButton.UseVisualStyleBackColor = true;
            this.SetPortraitDirectoryButton.Click += new System.EventHandler(this.SetPortraitDirectoryButton_Click);
            // 
            // PortraitDirectoryButton
            // 
            this.PortraitDirectoryButton.AutoSize = true;
            this.PortraitDirectoryButton.Location = new System.Drawing.Point(25, 0);
            this.PortraitDirectoryButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.PortraitDirectoryButton.Name = "PortraitDirectoryButton";
            this.PortraitDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.PortraitDirectoryButton.TabIndex = 202;
            this.PortraitDirectoryButton.Text = "Portrait";
            this.PortraitDirectoryButton.UseVisualStyleBackColor = true;
            this.PortraitDirectoryButton.Click += new System.EventHandler(this.PortraitDirectoryButton_Click);
            // 
            // setDirectoryButton
            // 
            this.setDirectoryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.setDirectoryButton.AutoSize = true;
            this.setDirectoryButton.Location = new System.Drawing.Point(38, 541);
            this.setDirectoryButton.Name = "setDirectoryButton";
            this.setDirectoryButton.Size = new System.Drawing.Size(78, 23);
            this.setDirectoryButton.TabIndex = 200;
            this.setDirectoryButton.Text = "Set Directory";
            this.setDirectoryButton.UseVisualStyleBackColor = true;
            this.setDirectoryButton.Visible = false;
            this.setDirectoryButton.Click += new System.EventHandler(this.SetDirectoryButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(3, 570);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 201;
            this.testButton.Text = "button1";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Visible = false;
            this.testButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.Image = null;
            this.PictureBox1.Location = new System.Drawing.Point(178, 3);
            this.PictureBox1.MinimumSize = new System.Drawing.Size(500, 500);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(1278, 755);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BufferTimer
            // 
            this.BufferTimer.Interval = 1000;
            this.BufferTimer.Tick += new System.EventHandler(this.BufferTimer_Tick);
            // 
            // StepTimer
            // 
            this.StepTimer.Interval = 1;
            this.StepTimer.Tick += new System.EventHandler(this.StepTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Picture Viewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.NudePanel.ResumeLayout(false);
            this.NudePanel.PerformLayout();
            this.ClothedPanel.ResumeLayout(false);
            this.ClothedPanel.PerformLayout();
            this.PortraitPanel.ResumeLayout(false);
            this.PortraitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MyPictureBox PictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label DrawTimer;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button timer30s;
        private System.Windows.Forms.Button timer60s;
        private System.Windows.Forms.Button timer2m;
        private System.Windows.Forms.Button setDirectoryButton;
        private System.Windows.Forms.Timer BufferTimer;
        private System.Windows.Forms.Button timer5m;
        private System.Windows.Forms.Button timer10m;
        private System.Windows.Forms.TextBox customTime;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button NudeDirectoryButton;
        private System.Windows.Forms.Button SetNudeDirectoryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel NudePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ClothedPanel;
        private System.Windows.Forms.Button SetClothedDirectoryButton;
        private System.Windows.Forms.Button ClothedDirectoryButton;
        private System.Windows.Forms.Panel PortraitPanel;
        private System.Windows.Forms.Button SetPortraitDirectoryButton;
        private System.Windows.Forms.Button PortraitDirectoryButton;
        private System.Windows.Forms.CheckBox NudeCheckbox;
        private System.Windows.Forms.CheckBox ClothedCheckbox;
        private System.Windows.Forms.CheckBox PortraitCheckbox;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Timer StepTimer;
    }
}

