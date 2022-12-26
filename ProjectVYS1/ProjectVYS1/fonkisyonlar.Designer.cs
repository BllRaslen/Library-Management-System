namespace ProjectVYS1
{
    partial class fonkisyonlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fonkisyonlar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.TBSerarch = new System.Windows.Forms.TextBox();
            this.BTNSearchWithID = new System.Windows.Forms.Button();
            this.BTNSearchWithName = new System.Windows.Forms.Button();
            this.BTNListing = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNDevletKisaltmasiBul = new System.Windows.Forms.Button();
            this.TBDevletIsmi = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNFiatlarFiltre = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(747, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(408, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(740, 344);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 37);
            this.pictureBox6.TabIndex = 50;
            this.pictureBox6.TabStop = false;
            // 
            // TBSerarch
            // 
            this.TBSerarch.Location = new System.Drawing.Point(784, 344);
            this.TBSerarch.Name = "TBSerarch";
            this.TBSerarch.Size = new System.Drawing.Size(371, 27);
            this.TBSerarch.TabIndex = 49;
            // 
            // BTNSearchWithID
            // 
            this.BTNSearchWithID.Location = new System.Drawing.Point(747, 377);
            this.BTNSearchWithID.Name = "BTNSearchWithID";
            this.BTNSearchWithID.Size = new System.Drawing.Size(202, 28);
            this.BTNSearchWithID.TabIndex = 48;
            this.BTNSearchWithID.Text = "Search with ID";
            this.BTNSearchWithID.UseVisualStyleBackColor = true;
            this.BTNSearchWithID.Click += new System.EventHandler(this.BTNSearchWithID_Click);
            // 
            // BTNSearchWithName
            // 
            this.BTNSearchWithName.Location = new System.Drawing.Point(955, 377);
            this.BTNSearchWithName.Name = "BTNSearchWithName";
            this.BTNSearchWithName.Size = new System.Drawing.Size(202, 28);
            this.BTNSearchWithName.TabIndex = 53;
            this.BTNSearchWithName.Text = "Search with Name";
            this.BTNSearchWithName.UseVisualStyleBackColor = true;
            this.BTNSearchWithName.Click += new System.EventHandler(this.BTNSearchWithName_Click);
            // 
            // BTNListing
            // 
            this.BTNListing.Location = new System.Drawing.Point(747, 411);
            this.BTNListing.Name = "BTNListing";
            this.BTNListing.Size = new System.Drawing.Size(410, 27);
            this.BTNListing.TabIndex = 54;
            this.BTNListing.Text = "Listing";
            this.BTNListing.UseVisualStyleBackColor = true;
            this.BTNListing.Click += new System.EventHandler(this.BTNListing_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BTNDevletKisaltmasiBul);
            this.groupBox1.Controls.Add(this.TBDevletIsmi);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 407);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2 Function";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 28);
            this.button1.TabIndex = 57;
            this.button1.Text = "search in books by language";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNDevletKisaltmasiBul
            // 
            this.BTNDevletKisaltmasiBul.Location = new System.Drawing.Point(6, 339);
            this.BTNDevletKisaltmasiBul.Name = "BTNDevletKisaltmasiBul";
            this.BTNDevletKisaltmasiBul.Size = new System.Drawing.Size(279, 28);
            this.BTNDevletKisaltmasiBul.TabIndex = 56;
            this.BTNDevletKisaltmasiBul.Text = "Devlet Kisaltmasi Bul";
            this.BTNDevletKisaltmasiBul.UseVisualStyleBackColor = true;
            this.BTNDevletKisaltmasiBul.Click += new System.EventHandler(this.BTNDevletKisaltmasiBul_Click);
            // 
            // TBDevletIsmi
            // 
            this.TBDevletIsmi.Location = new System.Drawing.Point(120, 40);
            this.TBDevletIsmi.Name = "TBDevletIsmi";
            this.TBDevletIsmi.Size = new System.Drawing.Size(165, 27);
            this.TBDevletIsmi.TabIndex = 56;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(279, 247);
            this.dataGridView2.TabIndex = 56;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "send parametre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNFiatlarFiltre);
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Location = new System.Drawing.Point(414, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 426);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiatlar Filtre";
            // 
            // BTNFiatlarFiltre
            // 
            this.BTNFiatlarFiltre.Location = new System.Drawing.Point(6, 392);
            this.BTNFiatlarFiltre.Name = "BTNFiatlarFiltre";
            this.BTNFiatlarFiltre.Size = new System.Drawing.Size(254, 28);
            this.BTNFiatlarFiltre.TabIndex = 56;
            this.BTNFiatlarFiltre.Text = "Fiatlar Filtre";
            this.BTNFiatlarFiltre.UseVisualStyleBackColor = true;
            this.BTNFiatlarFiltre.Click += new System.EventHandler(this.BTNFiatlarFiltre_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 26);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(254, 360);
            this.dataGridView3.TabIndex = 56;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // fonkisyonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNListing);
            this.Controls.Add(this.BTNSearchWithName);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.TBSerarch);
            this.Controls.Add(this.BTNSearchWithID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fonkisyonlar";
            this.Text = "fonkisyonlar";
            this.Load += new System.EventHandler(this.fonkisyonlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox6;
        private TextBox TBSerarch;
        private Button BTNSearchWithID;
        private Button BTNSearchWithName;
        private Button BTNListing;
        private GroupBox groupBox1;
        private Label label1;
        private Button BTNDevletKisaltmasiBul;
        private TextBox TBDevletIsmi;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private Button BTNFiatlarFiltre;
        private DataGridView dataGridView3;
        private Button button1;
    }
}