namespace DotSpatial.Plugins.MenuBar
{
    partial class ZoomToCoordinatesDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoomToCoordinatesDialog));
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbWGS = new System.Windows.Forms.TabPage();
            this.latStatus1 = new System.Windows.Forms.Label();
            this.lonStatus1 = new System.Windows.Forms.Label();
            this.tbBW1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDJ1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbXian = new System.Windows.Forms.TabPage();
            this.latStatus2 = new System.Windows.Forms.Label();
            this.lonStatus2 = new System.Windows.Forms.Label();
            this.tbBW2 = new System.Windows.Forms.TextBox();
            this.tbDJ2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSZ = new System.Windows.Forms.TabPage();
            this.lonStatus3 = new System.Windows.Forms.Label();
            this.latStatus3 = new System.Windows.Forms.Label();
            this.tbBW3 = new System.Windows.Forms.TextBox();
            this.tbDJ3 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbWGS.SuspendLayout();
            this.tbXian.SuspendLayout();
            this.tbSZ.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(192, 217);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(72, 28);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Text = "确定";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(270, 217);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(72, 28);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbWGS);
            this.tabControl1.Controls.Add(this.tbXian);
            this.tabControl1.Controls.Add(this.tbSZ);
            this.tabControl1.Location = new System.Drawing.Point(9, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 195);
            this.tabControl1.TabIndex = 29;
            // 
            // tbWGS
            // 
            this.tbWGS.Controls.Add(this.latStatus1);
            this.tbWGS.Controls.Add(this.lonStatus1);
            this.tbWGS.Controls.Add(this.tbBW1);
            this.tbWGS.Controls.Add(this.label11);
            this.tbWGS.Controls.Add(this.tbDJ1);
            this.tbWGS.Controls.Add(this.label9);
            this.tbWGS.Controls.Add(this.label8);
            this.tbWGS.Controls.Add(this.label7);
            this.tbWGS.Controls.Add(this.label6);
            this.tbWGS.Location = new System.Drawing.Point(4, 22);
            this.tbWGS.Margin = new System.Windows.Forms.Padding(2);
            this.tbWGS.Name = "tbWGS";
            this.tbWGS.Padding = new System.Windows.Forms.Padding(2);
            this.tbWGS.Size = new System.Drawing.Size(325, 169);
            this.tbWGS.TabIndex = 0;
            this.tbWGS.Text = "WGS1984 坐标系";
            this.tbWGS.UseVisualStyleBackColor = true;
            // 
            // latStatus1
            // 
            this.latStatus1.AutoSize = true;
            this.latStatus1.Location = new System.Drawing.Point(57, 138);
            this.latStatus1.Name = "latStatus1";
            this.latStatus1.Size = new System.Drawing.Size(65, 12);
            this.latStatus1.TabIndex = 36;
            this.latStatus1.Text = "latWarning";
            // 
            // lonStatus1
            // 
            this.lonStatus1.AutoSize = true;
            this.lonStatus1.Location = new System.Drawing.Point(57, 87);
            this.lonStatus1.Name = "lonStatus1";
            this.lonStatus1.Size = new System.Drawing.Size(71, 12);
            this.lonStatus1.TabIndex = 35;
            this.lonStatus1.Text = "longWarning";
            // 
            // tbBW1
            // 
            this.tbBW1.Location = new System.Drawing.Point(100, 118);
            this.tbBW1.Name = "tbBW1";
            this.tbBW1.Size = new System.Drawing.Size(127, 21);
            this.tbBW1.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(229, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "°";
            // 
            // tbDJ1
            // 
            this.tbDJ1.Location = new System.Drawing.Point(100, 68);
            this.tbDJ1.Name = "tbDJ1";
            this.tbDJ1.Size = new System.Drawing.Size(127, 21);
            this.tbDJ1.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "北纬B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "东经L:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "请输入要定位的经纬度";
            // 
            // tbXian
            // 
            this.tbXian.Controls.Add(this.latStatus2);
            this.tbXian.Controls.Add(this.lonStatus2);
            this.tbXian.Controls.Add(this.tbBW2);
            this.tbXian.Controls.Add(this.tbDJ2);
            this.tbXian.Controls.Add(this.label14);
            this.tbXian.Controls.Add(this.label15);
            this.tbXian.Controls.Add(this.label16);
            this.tbXian.Location = new System.Drawing.Point(4, 22);
            this.tbXian.Margin = new System.Windows.Forms.Padding(2);
            this.tbXian.Name = "tbXian";
            this.tbXian.Padding = new System.Windows.Forms.Padding(2);
            this.tbXian.Size = new System.Drawing.Size(325, 169);
            this.tbXian.TabIndex = 1;
            this.tbXian.Text = "Xian1980 坐标系";
            this.tbXian.UseVisualStyleBackColor = true;
            this.tbXian.Click += new System.EventHandler(this.tbXian_Click);
            // 
            // latStatus2
            // 
            this.latStatus2.AutoSize = true;
            this.latStatus2.Location = new System.Drawing.Point(57, 138);
            this.latStatus2.Name = "latStatus2";
            this.latStatus2.Size = new System.Drawing.Size(65, 12);
            this.latStatus2.TabIndex = 30;
            this.latStatus2.Text = "latWarning";
            // 
            // lonStatus2
            // 
            this.lonStatus2.AutoSize = true;
            this.lonStatus2.Location = new System.Drawing.Point(57, 87);
            this.lonStatus2.Name = "lonStatus2";
            this.lonStatus2.Size = new System.Drawing.Size(71, 12);
            this.lonStatus2.TabIndex = 30;
            this.lonStatus2.Text = "longWarning";
            // 
            // tbBW2
            // 
            this.tbBW2.Location = new System.Drawing.Point(86, 118);
            this.tbBW2.Name = "tbBW2";
            this.tbBW2.Size = new System.Drawing.Size(141, 21);
            this.tbBW2.TabIndex = 40;
            // 
            // tbDJ2
            // 
            this.tbDJ2.Location = new System.Drawing.Point(86, 68);
            this.tbDJ2.Name = "tbDJ2";
            this.tbDJ2.Size = new System.Drawing.Size(141, 21);
            this.tbDJ2.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 12);
            this.label14.TabIndex = 39;
            this.label14.Text = "Y :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 12);
            this.label15.TabIndex = 38;
            this.label15.Text = "X :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(57, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 12);
            this.label16.TabIndex = 36;
            this.label16.Text = "请输入要定位的坐标值";
            // 
            // tbSZ
            // 
            this.tbSZ.Controls.Add(this.lonStatus3);
            this.tbSZ.Controls.Add(this.latStatus3);
            this.tbSZ.Controls.Add(this.tbBW3);
            this.tbSZ.Controls.Add(this.tbDJ3);
            this.tbSZ.Controls.Add(this.label19);
            this.tbSZ.Controls.Add(this.label20);
            this.tbSZ.Controls.Add(this.label21);
            this.tbSZ.Location = new System.Drawing.Point(4, 22);
            this.tbSZ.Margin = new System.Windows.Forms.Padding(2);
            this.tbSZ.Name = "tbSZ";
            this.tbSZ.Padding = new System.Windows.Forms.Padding(2);
            this.tbSZ.Size = new System.Drawing.Size(325, 169);
            this.tbSZ.TabIndex = 2;
            this.tbSZ.Text = "深圳坐标系";
            this.tbSZ.UseVisualStyleBackColor = true;
            // 
            // lonStatus3
            // 
            this.lonStatus3.AutoSize = true;
            this.lonStatus3.Location = new System.Drawing.Point(57, 87);
            this.lonStatus3.Name = "lonStatus3";
            this.lonStatus3.Size = new System.Drawing.Size(71, 12);
            this.lonStatus3.TabIndex = 43;
            this.lonStatus3.Text = "longWarning";
            // 
            // latStatus3
            // 
            this.latStatus3.AutoSize = true;
            this.latStatus3.Location = new System.Drawing.Point(57, 138);
            this.latStatus3.Name = "latStatus3";
            this.latStatus3.Size = new System.Drawing.Size(65, 12);
            this.latStatus3.TabIndex = 42;
            this.latStatus3.Text = "latWarning";
            // 
            // tbBW3
            // 
            this.tbBW3.Location = new System.Drawing.Point(86, 118);
            this.tbBW3.Name = "tbBW3";
            this.tbBW3.Size = new System.Drawing.Size(141, 21);
            this.tbBW3.TabIndex = 40;
            // 
            // tbDJ3
            // 
            this.tbDJ3.Location = new System.Drawing.Point(86, 68);
            this.tbDJ3.Name = "tbDJ3";
            this.tbDJ3.Size = new System.Drawing.Size(141, 21);
            this.tbDJ3.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(57, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 12);
            this.label19.TabIndex = 39;
            this.label19.Text = "Y :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(57, 68);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 12);
            this.label20.TabIndex = 38;
            this.label20.Text = "X :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(57, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(125, 12);
            this.label21.TabIndex = 36;
            this.label21.Text = "请输入要定位的坐标值";
            // 
            // ZoomToCoordinatesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZoomToCoordinatesDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定位";
            this.Load += new System.EventHandler(this.ZoomToCoordinatesDialog_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbWGS.ResumeLayout(false);
            this.tbWGS.PerformLayout();
            this.tbXian.ResumeLayout(false);
            this.tbXian.PerformLayout();
            this.tbSZ.ResumeLayout(false);
            this.tbSZ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbWGS;
        private System.Windows.Forms.TabPage tbXian;
        private System.Windows.Forms.TabPage tbSZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBW1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbDJ1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbBW2;
        private System.Windows.Forms.TextBox tbDJ2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbBW3;
        private System.Windows.Forms.TextBox tbDJ3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label latStatus2;
        private System.Windows.Forms.Label lonStatus2;
        private System.Windows.Forms.Label lonStatus1;
        private System.Windows.Forms.Label latStatus1;
        private System.Windows.Forms.Label lonStatus3;
        private System.Windows.Forms.Label latStatus3;
    }
}