namespace ProjectVYS1
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN = new System.Windows.Forms.Button();
            this.BTNBuyer = new System.Windows.Forms.Button();
            this.BTNBorrower = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectVYS1.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(1, 422);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 16);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BTN
            // 
            this.BTN.Location = new System.Drawing.Point(1, 411);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(78, 40);
            this.BTN.TabIndex = 2;
            this.BTN.Text = "Back";
            this.BTN.UseVisualStyleBackColor = true;
            this.BTN.Click += new System.EventHandler(this.BTN_Click);
            // 
            // BTNBuyer
            // 
            this.BTNBuyer.Location = new System.Drawing.Point(45, 322);
            this.BTNBuyer.Name = "BTNBuyer";
            this.BTNBuyer.Size = new System.Drawing.Size(266, 48);
            this.BTNBuyer.TabIndex = 4;
            this.BTNBuyer.Text = "Buyer ";
            this.BTNBuyer.UseVisualStyleBackColor = true;
            this.BTNBuyer.Click += new System.EventHandler(this.BTNBuyer_Click);
            // 
            // BTNBorrower
            // 
            this.BTNBorrower.Location = new System.Drawing.Point(517, 333);
            this.BTNBorrower.Name = "BTNBorrower";
            this.BTNBorrower.Size = new System.Drawing.Size(238, 48);
            this.BTNBorrower.TabIndex = 5;
            this.BTNBorrower.Text = "Borrower";
            this.BTNBorrower.UseVisualStyleBackColor = true;
            this.BTNBorrower.Click += new System.EventHandler(this.BTNBorrower_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 71);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 244);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(517, 71);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(238, 261);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BTNBorrower);
            this.Controls.Add(this.BTNBuyer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button BTN;
        private Button BTNBuyer;
        private Button BTNBorrower;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}