namespace ii_computers
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
            this.prodsBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.msg = new System.Windows.Forms.RichTextBox();
            this.pc1Box = new System.Windows.Forms.RichTextBox();
            this.pc2Box = new System.Windows.Forms.RichTextBox();
            this.pc3Box = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reqBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // prodsBox
            // 
            this.prodsBox.DropDownWidth = 250;
            this.prodsBox.FormattingEnabled = true;
            this.prodsBox.Location = new System.Drawing.Point(496, 12);
            this.prodsBox.Name = "prodsBox";
            this.prodsBox.Size = new System.Drawing.Size(238, 21);
            this.prodsBox.TabIndex = 0;
            this.prodsBox.SelectedIndexChanged += new System.EventHandler(this.prodsBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(796, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 97);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(162, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 97);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(311, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 97);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 115);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(134, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(162, 115);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(134, 23);
            this.progressBar2.TabIndex = 6;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(311, 115);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(134, 23);
            this.progressBar3.TabIndex = 7;
            // 
            // msg
            // 
            this.msg.Enabled = false;
            this.msg.Location = new System.Drawing.Point(496, 55);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(375, 83);
            this.msg.TabIndex = 8;
            this.msg.Text = "";
            // 
            // pc1Box
            // 
            this.pc1Box.Enabled = false;
            this.pc1Box.Location = new System.Drawing.Point(12, 190);
            this.pc1Box.Name = "pc1Box";
            this.pc1Box.Size = new System.Drawing.Size(134, 134);
            this.pc1Box.TabIndex = 9;
            this.pc1Box.Text = "";
            // 
            // pc2Box
            // 
            this.pc2Box.Enabled = false;
            this.pc2Box.Location = new System.Drawing.Point(162, 190);
            this.pc2Box.Name = "pc2Box";
            this.pc2Box.Size = new System.Drawing.Size(134, 134);
            this.pc2Box.TabIndex = 10;
            this.pc2Box.Text = "";
            // 
            // pc3Box
            // 
            this.pc3Box.Enabled = false;
            this.pc3Box.Location = new System.Drawing.Point(311, 190);
            this.pc3Box.Name = "pc3Box";
            this.pc3Box.Size = new System.Drawing.Size(134, 134);
            this.pc3Box.TabIndex = 11;
            this.pc3Box.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(604, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "System requirements";
            // 
            // reqBox
            // 
            this.reqBox.Enabled = false;
            this.reqBox.Location = new System.Drawing.Point(496, 190);
            this.reqBox.Name = "reqBox";
            this.reqBox.Size = new System.Drawing.Size(375, 134);
            this.reqBox.TabIndex = 13;
            this.reqBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(153, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Computer specifications";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reqBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pc3Box);
            this.Controls.Add(this.pc2Box);
            this.Controls.Add(this.pc1Box);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prodsBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox prodsBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.RichTextBox msg;
        private System.Windows.Forms.RichTextBox pc1Box;
        private System.Windows.Forms.RichTextBox pc2Box;
        private System.Windows.Forms.RichTextBox pc3Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox reqBox;
        private System.Windows.Forms.Label label2;
    }
}

