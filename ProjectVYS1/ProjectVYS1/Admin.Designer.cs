namespace ProjectVYS1
{
    partial class Admin
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
            this.BTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNPublisher = new System.Windows.Forms.Button();
            this.BTNLanguage = new System.Windows.Forms.Button();
            this.BTNAuthor = new System.Windows.Forms.Button();
            this.BTNBook = new System.Windows.Forms.Button();
            this.BTNAllInformation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN
            // 
            this.BTN.Location = new System.Drawing.Point(4, 398);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(78, 40);
            this.BTN.TabIndex = 0;
            this.BTN.Text = "Back";
            this.BTN.UseVisualStyleBackColor = true;
            this.BTN.Click += new System.EventHandler(this.BTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectVYS1.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(4, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 16);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BTNPublisher
            // 
            this.BTNPublisher.Location = new System.Drawing.Point(20, 204);
            this.BTNPublisher.Name = "BTNPublisher";
            this.BTNPublisher.Size = new System.Drawing.Size(94, 29);
            this.BTNPublisher.TabIndex = 2;
            this.BTNPublisher.Text = "Publisher";
            this.BTNPublisher.UseVisualStyleBackColor = true;
            this.BTNPublisher.Click += new System.EventHandler(this.BTNPublisher_Click);
            // 
            // BTNLanguage
            // 
            this.BTNLanguage.Location = new System.Drawing.Point(347, 204);
            this.BTNLanguage.Name = "BTNLanguage";
            this.BTNLanguage.Size = new System.Drawing.Size(94, 29);
            this.BTNLanguage.TabIndex = 3;
            this.BTNLanguage.Text = "Language";
            this.BTNLanguage.UseVisualStyleBackColor = true;
            this.BTNLanguage.Click += new System.EventHandler(this.BTNLanguage_Click);
            // 
            // BTNAuthor
            // 
            this.BTNAuthor.Location = new System.Drawing.Point(674, 204);
            this.BTNAuthor.Name = "BTNAuthor";
            this.BTNAuthor.Size = new System.Drawing.Size(94, 29);
            this.BTNAuthor.TabIndex = 4;
            this.BTNAuthor.Text = "Author";
            this.BTNAuthor.UseVisualStyleBackColor = true;
            this.BTNAuthor.Click += new System.EventHandler(this.BTNAuthor_Click);
            // 
            // BTNBook
            // 
            this.BTNBook.Location = new System.Drawing.Point(20, 239);
            this.BTNBook.Name = "BTNBook";
            this.BTNBook.Size = new System.Drawing.Size(748, 29);
            this.BTNBook.TabIndex = 5;
            this.BTNBook.Text = "Book";
            this.BTNBook.UseVisualStyleBackColor = true;
            this.BTNBook.Click += new System.EventHandler(this.BTNBook_Click);
            // 
            // BTNAllInformation
            // 
            this.BTNAllInformation.Location = new System.Drawing.Point(20, 169);
            this.BTNAllInformation.Name = "BTNAllInformation";
            this.BTNAllInformation.Size = new System.Drawing.Size(748, 29);
            this.BTNAllInformation.TabIndex = 6;
            this.BTNAllInformation.Text = "All Information";
            this.BTNAllInformation.UseVisualStyleBackColor = true;
            this.BTNAllInformation.Click += new System.EventHandler(this.BTNAllInformation_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(748, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Fonkisyonlar Calistir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNAllInformation);
            this.Controls.Add(this.BTNBook);
            this.Controls.Add(this.BTNAuthor);
            this.Controls.Add(this.BTNLanguage);
            this.Controls.Add(this.BTNPublisher);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BTN;
        private PictureBox pictureBox1;
        private Button BTNPublisher;
        private Button BTNLanguage;
        private Button BTNAuthor;
        private Button BTNBook;
        private Button BTNAllInformation;
        private Button button1;
    }
}