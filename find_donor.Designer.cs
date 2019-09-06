namespace foisal
{
    partial class find_donor
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
            this.bg = new System.Windows.Forms.ComboBox();
            this.loc = new System.Windows.Forms.ComboBox();
            this.search_box = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.FormattingEnabled = true;
            this.bg.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.bg.Location = new System.Drawing.Point(544, 129);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(176, 21);
            this.bg.TabIndex = 21;
            // 
            // loc
            // 
            this.loc.FormattingEnabled = true;
            this.loc.Items.AddRange(new object[] {
            "Mirpur 1",
            "Mirpur 2",
            "Farmgate",
            "Uttra",
            "Bonani"});
            this.loc.Location = new System.Drawing.Point(765, 129);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(167, 21);
            this.loc.TabIndex = 22;
            // 
            // search_box
            // 
            this.search_box.BackgroundImage = global::foisal.Properties.Resources.deep_red;
            this.search_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_box.Location = new System.Drawing.Point(957, 104);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(139, 46);
            this.search_box.TabIndex = 23;
            this.search_box.Text = "Search";
            this.search_box.UseVisualStyleBackColor = true;
            this.search_box.Click += new System.EventHandler(this.search_box_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(436, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 320);
            this.dataGridView1.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::foisal.Properties.Resources.y;
            this.pictureBox2.Location = new System.Drawing.Point(11, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 391);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(540, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "BLOOD GROUP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(761, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "LOCATION";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::foisal.Properties.Resources.home;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1052, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 40);
            this.button3.TabIndex = 45;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // find_donor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::foisal.Properties.Resources.sky;
            this.ClientSize = new System.Drawing.Size(1111, 491);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.bg);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "find_donor";
            this.Text = "Bucket of donors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox bg;
        private System.Windows.Forms.ComboBox loc;
        private System.Windows.Forms.Button search_box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
    }
}