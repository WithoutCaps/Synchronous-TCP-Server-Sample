using System;

namespace TCP_Server_Sample
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
            this.console_txt = new System.Windows.Forms.TextBox();
            this.broadcast_btn = new System.Windows.Forms.Button();
            this.send_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.Connection_lbl = new System.Windows.Forms.Label();
            this.send_cbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // console_txt
            // 
            this.console_txt.Location = new System.Drawing.Point(12, 12);
            this.console_txt.Multiline = true;
            this.console_txt.Name = "console_txt";
            this.console_txt.Size = new System.Drawing.Size(581, 608);
            this.console_txt.TabIndex = 5;
            // 
            // broadcast_btn
            // 
            this.broadcast_btn.Location = new System.Drawing.Point(518, 624);
            this.broadcast_btn.Name = "broadcast_btn";
            this.broadcast_btn.Size = new System.Drawing.Size(75, 20);
            this.broadcast_btn.TabIndex = 4;
            this.broadcast_btn.Text = "Broadcast";
            this.broadcast_btn.UseVisualStyleBackColor = true;
            this.broadcast_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // send_txt
            // 
            this.send_txt.Location = new System.Drawing.Point(12, 624);
            this.send_txt.Name = "send_txt";
            this.send_txt.Size = new System.Drawing.Size(419, 20);
            this.send_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 654);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // port_txt
            // 
            this.port_txt.Location = new System.Drawing.Point(12, 670);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(266, 20);
            this.port_txt.TabIndex = 9;
            this.port_txt.Text = "1000";
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(12, 696);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(266, 26);
            this.connect_btn.TabIndex = 10;
            this.connect_btn.Text = "Start listening";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // Connection_lbl
            // 
            this.Connection_lbl.AutoSize = true;
            this.Connection_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F);
            this.Connection_lbl.ForeColor = System.Drawing.Color.Red;
            this.Connection_lbl.Location = new System.Drawing.Point(293, 667);
            this.Connection_lbl.Name = "Connection_lbl";
            this.Connection_lbl.Size = new System.Drawing.Size(300, 52);
            this.Connection_lbl.TabIndex = 11;
            this.Connection_lbl.Text = "Server Closed";
            // 
            // send_cbox
            // 
            this.send_cbox.AutoSize = true;
            this.send_cbox.Location = new System.Drawing.Point(435, 626);
            this.send_cbox.Name = "send_cbox";
            this.send_cbox.Size = new System.Drawing.Size(77, 17);
            this.send_cbox.TabIndex = 12;
            this.send_cbox.Text = "+New Line";
            this.send_cbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 728);
            this.Controls.Add(this.send_cbox);
            this.Controls.Add(this.Connection_lbl);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.port_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.console_txt);
            this.Controls.Add(this.broadcast_btn);
            this.Controls.Add(this.send_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.TextBox console_txt;
        private System.Windows.Forms.Button broadcast_btn;
        private System.Windows.Forms.TextBox send_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox port_txt;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Label Connection_lbl;
        private System.Windows.Forms.CheckBox send_cbox;
    }
}

