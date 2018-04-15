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
            this.tbBW1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDJ1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbXian = new System.Windows.Forms.TabPage();
            this.tbBW2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDJ2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSZ = new System.Windows.Forms.TabPage();
            this.tbBW3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbDJ3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lonStatus2 = new System.Windows.Forms.Label();
            this.latStatus2 = new System.Windows.Forms.Label();
            this.lonStatus1 = new System.Windows.Forms.Label();
            this.latStatus1 = new System.Windows.Forms.Label();
            this.latStatus3 = new System.Windows.Forms.Label();
            this.lonStatus3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbWGS.SuspendLayout();
            this.tbXian.SuspendLayout();
            this.tbSZ.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(256, 289);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(4);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(96, 37);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Text = "确定";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(360, 289);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(96, 37);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbWGS);
            this.tabControl1.Controls.Add(this.tbXian);
            this.tabControl1.Controls.Add(this.tbSZ);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 260);
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
            this.tbWGS.Location = new System.Drawing.Point(4, 25);
            this.tbWGS.Name = "tbWGS";
            this.tbWGS.Padding = new System.Windows.Forms.Padding(3);
            this.tbWGS.Size = new System.Drawing.Size(436, 231);
            this.tbWGS.TabIndex = 0;
            this.tbWGS.Text = "WGS1984 坐标系";
            this.tbWGS.UseVisualStyleBackColor = true;
            // 
            // tbBW1
            // 
            this.tbBW1.Location = new System.Drawing.Point(157, 157);
            this.tbBW1.Margin = new System.Windows.Forms.Padding(4);
            this.tbBW1.Name = "tbBW1";
            this.tbBW1.Size = new System.Drawing.Size(144, 22);
            this.tbBW1.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 157);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "°";
            // 
            // tbDJ1
            // 
            this.tbDJ1.Location = new System.Drawing.Point(157, 90);
            this.tbDJ1.Margin = new System.Windows.Forms.Padding(4);
            this.tbDJ1.Name = "tbDJ1";
            this.tbDJ1.Size = new System.Drawing.Size(144, 22);
            this.tbDJ1.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "北纬B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "东经L:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "请输入要定位的经纬度";
            // 
            // tbXian
            // 
            this.tbXian.Controls.Add(this.latStatus2);
            this.tbXian.Controls.Add(this.lonStatus2);
            this.tbXian.Controls.Add(this.tbBW2);
            this.tbXian.Controls.Add(this.label12);
            this.tbXian.Controls.Add(this.tbDJ2);
            this.tbXian.Controls.Add(this.label13);
            this.tbXian.Controls.Add(this.label14);
            this.tbXian.Controls.Add(this.label15);
            this.tbXian.Controls.Add(this.label16);
            this.tbXian.Location = new System.Drawing.Point(4, 25);
            this.tbXian.Name = "tbXian";
            this.tbXian.Padding = new System.Windows.Forms.Padding(3);
            this.tbXian.Size = new System.Drawing.Size(436, 231);
            this.tbXian.TabIndex = 1;
            this.tbXian.Text = "Xian1980 坐标系";
            this.tbXian.UseVisualStyleBackColor = true;
            this.tbXian.Click += new System.EventHandler(this.tbXian_Click);
            // 
            // tbBW2
            // 
            this.tbBW2.Location = new System.Drawing.Point(157, 157);
            this.tbBW2.Margin = new System.Windows.Forms.Padding(4);
            this.tbBW2.Name = "tbBW2";
            this.tbBW2.Size = new System.Drawing.Size(144, 22);
            this.tbBW2.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 157);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "°";
            // 
            // tbDJ2
            // 
            this.tbDJ2.Location = new System.Drawing.Point(157, 90);
            this.tbDJ2.Margin = new System.Windows.Forms.Padding(4);
            this.tbDJ2.Name = "tbDJ2";
            this.tbDJ2.Size = new System.Drawing.Size(144, 22);
            this.tbDJ2.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(305, 86);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "°";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(76, 157);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "北纬B:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(76, 90);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 17);
            this.label15.TabIndex = 38;
            this.label15.Text = "东经L:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(76, 43);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 17);
            this.label16.TabIndex = 36;
            this.label16.Text = "请输入要定位的经纬度";
            // 
            // tbSZ
            // 
            this.tbSZ.Controls.Add(this.lonStatus3);
            this.tbSZ.Controls.Add(this.latStatus3);
            this.tbSZ.Controls.Add(this.tbBW3);
            this.tbSZ.Controls.Add(this.label17);
            this.tbSZ.Controls.Add(this.tbDJ3);
            this.tbSZ.Controls.Add(this.label18);
            this.tbSZ.Controls.Add(this.label19);
            this.tbSZ.Controls.Add(this.label20);
            this.tbSZ.Controls.Add(this.label21);
            this.tbSZ.Location = new System.Drawing.Point(4, 25);
            this.tbSZ.Name = "tbSZ";
            this.tbSZ.Padding = new System.Windows.Forms.Padding(3);
            this.tbSZ.Size = new System.Drawing.Size(436, 231);
            this.tbSZ.TabIndex = 2;
            this.tbSZ.Text = "深圳坐标系";
            this.tbSZ.UseVisualStyleBackColor = true;
            // 
            // tbBW3
            // 
            this.tbBW3.Location = new System.Drawing.Point(157, 157);
            this.tbBW3.Margin = new System.Windows.Forms.Padding(4);
            this.tbBW3.Name = "tbBW3";
            this.tbBW3.Size = new System.Drawing.Size(144, 22);
            this.tbBW3.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(305, 157);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 17);
            this.label17.TabIndex = 41;
            this.label17.Text = "°";
            // 
            // tbDJ3
            // 
            this.tbDJ3.Location = new System.Drawing.Point(157, 90);
            this.tbDJ3.Margin = new System.Windows.Forms.Padding(4);
            this.tbDJ3.Name = "tbDJ3";
            this.tbDJ3.Size = new System.Drawing.Size(144, 22);
            this.tbDJ3.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(305, 86);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 17);
            this.label18.TabIndex = 37;
            this.label18.Text = "°";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(76, 157);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 17);
            this.label19.TabIndex = 39;
            this.label19.Text = "北纬B:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(76, 90);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 17);
            this.label20.TabIndex = 38;
            this.label20.Text = "东经L:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(76, 43);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(148, 17);
            this.label21.TabIndex = 36;
            this.label21.Text = "请输入要定位的经纬度";
            // 
            // lonStatus2
            // 
            this.lonStatus2.AutoSize = true;
            this.lonStatus2.Location = new System.Drawing.Point(76, 116);
            this.lonStatus2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lonStatus2.Name = "lonStatus2";
            this.lonStatus2.Size = new System.Drawing.Size(88, 17);
            this.lonStatus2.TabIndex = 30;
            this.lonStatus2.Text = "longWarning";
            // 
            // latStatus2
            // 
            this.latStatus2.AutoSize = true;
            this.latStatus2.Location = new System.Drawing.Point(76, 184);
            this.latStatus2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.latStatus2.Name = "latStatus2";
            this.latStatus2.Size = new System.Drawing.Size(76, 17);
            this.latStatus2.TabIndex = 30;
            this.latStatus2.Text = "latWarning";
            // 
            // lonStatus1
            // 
            this.lonStatus1.AutoSize = true;
            this.lonStatus1.Location = new System.Drawing.Point(76, 116);
            this.lonStatus1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lonStatus1.Name = "lonStatus1";
            this.lonStatus1.Size = new System.Drawing.Size(88, 17);
            this.lonStatus1.TabIndex = 35;
            this.lonStatus1.Text = "longWarning";
            // 
            // latStatus1
            // 
            this.latStatus1.AutoSize = true;
            this.latStatus1.Location = new System.Drawing.Point(76, 184);
            this.latStatus1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.latStatus1.Name = "latStatus1";
            this.latStatus1.Size = new System.Drawing.Size(76, 17);
            this.latStatus1.TabIndex = 36;
            this.latStatus1.Text = "latWarning";
            // 
            // latStatus3
            // 
            this.latStatus3.AutoSize = true;
            this.latStatus3.Location = new System.Drawing.Point(76, 184);
            this.latStatus3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.latStatus3.Name = "latStatus3";
            this.latStatus3.Size = new System.Drawing.Size(76, 17);
            this.latStatus3.TabIndex = 42;
            this.latStatus3.Text = "latWarning";
            // 
            // lonStatus3
            // 
            this.lonStatus3.AutoSize = true;
            this.lonStatus3.Location = new System.Drawing.Point(76, 116);
            this.lonStatus3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lonStatus3.Name = "lonStatus3";
            this.lonStatus3.Size = new System.Drawing.Size(88, 17);
            this.lonStatus3.TabIndex = 43;
            this.lonStatus3.Text = "longWarning";
            // 
            // ZoomToCoordinatesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 333);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDJ2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbBW3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbDJ3;
        private System.Windows.Forms.Label label18;
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