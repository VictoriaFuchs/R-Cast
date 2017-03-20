namespace WindowsFormsApp1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.VPN = new System.Windows.Forms.Button();
            this.BT = new System.Windows.Forms.Button();
            this.WLAN = new System.Windows.Forms.Button();
            this.LAN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.AudioOut = new System.Windows.Forms.Button();
            this.AudioIn = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 493);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.LAN);
            this.tabPage1.Controls.Add(this.WLAN);
            this.tabPage1.Controls.Add(this.BT);
            this.tabPage1.Controls.Add(this.VPN);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(909, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LAN";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.button15);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.AudioOut);
            this.tabPage2.Controls.Add(this.AudioIn);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(909, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "I| O";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(62, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Refresh LIst";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(62, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remember Device";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(62, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "Connect to Device";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(62, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 26);
            this.button4.TabIndex = 3;
            this.button4.Text = "Search for Devices";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(62, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Available Devices";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(272, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(578, 155);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // VPN
            // 
            this.VPN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.VPN.AutoSize = true;
            this.VPN.Location = new System.Drawing.Point(138, 342);
            this.VPN.Margin = new System.Windows.Forms.Padding(20);
            this.VPN.Name = "VPN";
            this.VPN.Size = new System.Drawing.Size(126, 26);
            this.VPN.TabIndex = 6;
            this.VPN.Text = "OFF";
            this.VPN.UseVisualStyleBackColor = true;
            this.VPN.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // BT
            // 
            this.BT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BT.AutoSize = true;
            this.BT.Location = new System.Drawing.Point(636, 342);
            this.BT.Margin = new System.Windows.Forms.Padding(20);
            this.BT.Name = "BT";
            this.BT.Size = new System.Drawing.Size(126, 26);
            this.BT.TabIndex = 7;
            this.BT.Text = "OFF";
            this.BT.UseVisualStyleBackColor = true;
            // 
            // WLAN
            // 
            this.WLAN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.WLAN.AutoSize = true;
            this.WLAN.Location = new System.Drawing.Point(470, 342);
            this.WLAN.Margin = new System.Windows.Forms.Padding(20);
            this.WLAN.Name = "WLAN";
            this.WLAN.Size = new System.Drawing.Size(126, 26);
            this.WLAN.TabIndex = 8;
            this.WLAN.Text = "OFF";
            this.WLAN.UseVisualStyleBackColor = true;
            // 
            // LAN
            // 
            this.LAN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LAN.AutoSize = true;
            this.LAN.Location = new System.Drawing.Point(304, 342);
            this.LAN.Margin = new System.Windows.Forms.Padding(20);
            this.LAN.Name = "LAN";
            this.LAN.Size = new System.Drawing.Size(126, 26);
            this.LAN.TabIndex = 9;
            this.LAN.Text = "OFF";
            this.LAN.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(343, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Toggle Available Services";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(346, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Toggle Available Services";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(307, 115);
            this.button8.Margin = new System.Windows.Forms.Padding(20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 26);
            this.button8.TabIndex = 14;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // AudioOut
            // 
            this.AudioOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AudioOut.AutoSize = true;
            this.AudioOut.Location = new System.Drawing.Point(473, 115);
            this.AudioOut.Margin = new System.Windows.Forms.Padding(20);
            this.AudioOut.Name = "AudioOut";
            this.AudioOut.Size = new System.Drawing.Size(126, 26);
            this.AudioOut.TabIndex = 13;
            this.AudioOut.Text = "button9";
            this.AudioOut.UseVisualStyleBackColor = true;
            // 
            // AudioIn
            // 
            this.AudioIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AudioIn.AutoSize = true;
            this.AudioIn.Location = new System.Drawing.Point(639, 115);
            this.AudioIn.Margin = new System.Windows.Forms.Padding(20);
            this.AudioIn.Name = "AudioIn";
            this.AudioIn.Size = new System.Drawing.Size(126, 26);
            this.AudioIn.TabIndex = 12;
            this.AudioIn.Text = "OFF";
            this.AudioIn.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button11.AutoSize = true;
            this.button11.Location = new System.Drawing.Point(141, 115);
            this.button11.Margin = new System.Windows.Forms.Padding(20);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(126, 26);
            this.button11.TabIndex = 11;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.Location = new System.Drawing.Point(346, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Toggle Available Services";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button12.AutoSize = true;
            this.button12.Location = new System.Drawing.Point(307, 338);
            this.button12.Margin = new System.Windows.Forms.Padding(20);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(126, 26);
            this.button12.TabIndex = 19;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button13.AutoSize = true;
            this.button13.Location = new System.Drawing.Point(473, 338);
            this.button13.Margin = new System.Windows.Forms.Padding(20);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(126, 26);
            this.button13.TabIndex = 18;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button14.AutoSize = true;
            this.button14.Location = new System.Drawing.Point(639, 338);
            this.button14.Margin = new System.Windows.Forms.Padding(20);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(126, 26);
            this.button14.TabIndex = 17;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button15.AutoSize = true;
            this.button15.Location = new System.Drawing.Point(141, 338);
            this.button15.Margin = new System.Windows.Forms.Padding(20);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(126, 26);
            this.button15.TabIndex = 16;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button LAN;
        private System.Windows.Forms.Button WLAN;
        private System.Windows.Forms.Button BT;
        private System.Windows.Forms.Button VPN;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button AudioOut;
        private System.Windows.Forms.Button AudioIn;
        private System.Windows.Forms.Button button11;
    }
}

