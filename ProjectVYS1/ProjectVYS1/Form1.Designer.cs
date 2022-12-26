namespace ProjectVYS1
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
            this.BTNAdmin = new System.Windows.Forms.Button();
            this.BTNStudent = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNAdmin
            // 
            this.BTNAdmin.Location = new System.Drawing.Point(46, 386);
            this.BTNAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNAdmin.Name = "BTNAdmin";
            this.BTNAdmin.Size = new System.Drawing.Size(266, 59);
            this.BTNAdmin.TabIndex = 0;
            this.BTNAdmin.Text = "Admin";
            this.BTNAdmin.UseVisualStyleBackColor = true;
            this.BTNAdmin.Click += new System.EventHandler(this.BTNAdmin_Click);
            // 
            // BTNStudent
            // 
            this.BTNStudent.Location = new System.Drawing.Point(518, 386);
            this.BTNStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNStudent.Name = "BTNStudent";
            this.BTNStudent.Size = new System.Drawing.Size(238, 59);
            this.BTNStudent.TabIndex = 1;
            this.BTNStudent.Text = "Student";
            this.BTNStudent.UseVisualStyleBackColor = true;
            this.BTNStudent.Click += new System.EventHandler(this.BTNStudent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectVYS1.Properties.Resources.graduated;
            this.pictureBox1.Location = new System.Drawing.Point(518, 110);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 268);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectVYS1.Properties.Resources.unauthorized_person;
            this.pictureBox2.Location = new System.Drawing.Point(46, 110);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 268);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNStudent);
            this.Controls.Add(this.BTNAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BTNAdmin;
        private Button BTNStudent;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}