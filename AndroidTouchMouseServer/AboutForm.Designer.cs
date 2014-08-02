namespace AndroidTouchMouseServer {
    partial class AboutForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serverAddressList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.licenseLink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Android TouchMouse Server";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serverAddressList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(43, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Info";
            // 
            // serverAddressList
            // 
            this.serverAddressList.FullRowSelect = true;
            this.serverAddressList.GridLines = true;
            this.serverAddressList.Location = new System.Drawing.Point(9, 37);
            this.serverAddressList.MultiSelect = false;
            this.serverAddressList.Name = "serverAddressList";
            this.serverAddressList.Size = new System.Drawing.Size(185, 97);
            this.serverAddressList.TabIndex = 1;
            this.serverAddressList.UseCompatibleStateImageBehavior = false;
            this.serverAddressList.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Listening on:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Source: ";
            // 
            // licenseLink
            // 
            this.licenseLink.AutoSize = true;
            this.licenseLink.Location = new System.Drawing.Point(123, 239);
            this.licenseLink.Name = "licenseLink";
            this.licenseLink.Size = new System.Drawing.Size(66, 13);
            this.licenseLink.TabIndex = 3;
            this.licenseLink.TabStop = true;
            this.licenseLink.Text = "MIT License";
            this.licenseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.licenseLink_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "License";
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Location = new System.Drawing.Point(123, 212);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(130, 13);
            this.githubLink.TabIndex = 5;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "github.com/marcusfeeney";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 272);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.licenseLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AboutForm";
            this.Text = "About";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView serverAddressList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel licenseLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel githubLink;
    }
}