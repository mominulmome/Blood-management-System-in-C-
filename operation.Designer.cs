namespace foisal
{
    partial class operation
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
            this.components = new System.ComponentModel.Container();
            this.search = new System.Windows.Forms.Button();
            this.pnumber = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.u_n = new System.Windows.Forms.TextBox();
            this.u_w = new System.Windows.Forms.TextBox();
            this.u_e = new System.Windows.Forms.TextBox();
            this.u_p = new System.Windows.Forms.TextBox();
            this.u_l = new System.Windows.Forms.ComboBox();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLoc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWeight = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackgroundImage = global::foisal.Properties.Resources.Group_1514;
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(287, 76);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(120, 40);
            this.search.TabIndex = 1;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // pnumber
            // 
            this.pnumber.Location = new System.Drawing.Point(156, 50);
            this.pnumber.Name = "pnumber";
            this.pnumber.Size = new System.Drawing.Size(251, 20);
            this.pnumber.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(442, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 354);
            this.dataGridView1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::foisal.Properties.Resources.Group_1511;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(156, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::foisal.Properties.Resources.Group_1517;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(287, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // u_n
            // 
            this.u_n.Location = new System.Drawing.Point(156, 200);
            this.u_n.Name = "u_n";
            this.u_n.Size = new System.Drawing.Size(251, 20);
            this.u_n.TabIndex = 23;
            this.u_n.TextChanged += new System.EventHandler(this.u_n_TextChanged);
            this.u_n.Validating += new System.ComponentModel.CancelEventHandler(this.u_n_Validating);
            // 
            // u_w
            // 
            this.u_w.Location = new System.Drawing.Point(156, 308);
            this.u_w.Name = "u_w";
            this.u_w.Size = new System.Drawing.Size(251, 20);
            this.u_w.TabIndex = 29;
            // 
            // u_e
            // 
            this.u_e.Location = new System.Drawing.Point(156, 272);
            this.u_e.Name = "u_e";
            this.u_e.Size = new System.Drawing.Size(251, 20);
            this.u_e.TabIndex = 27;
            // 
            // u_p
            // 
            this.u_p.Location = new System.Drawing.Point(156, 347);
            this.u_p.Name = "u_p";
            this.u_p.Size = new System.Drawing.Size(251, 20);
            this.u_p.TabIndex = 31;
            // 
            // u_l
            // 
            this.u_l.FormattingEnabled = true;
            this.u_l.Items.AddRange(new object[] {
            "Mirpur 1",
            "Mirpur 2",
            "Farmgate",
            "Uttra",
            "Bonani"});
            this.u_l.Location = new System.Drawing.Point(156, 236);
            this.u_l.Name = "u_l";
            this.u_l.Size = new System.Drawing.Size(251, 21);
            this.u_l.TabIndex = 32;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderLoc
            // 
            this.errorProviderLoc.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderWeight
            // 
            this.errorProviderWeight.ContainerControl = this;
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(79, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(80, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "NAME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(36, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 41;
            this.label8.Text = "LOCATION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(59, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 42;
            this.label9.Text = "WEIGHT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(67, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 24);
            this.label10.TabIndex = 43;
            this.label10.Text = "PHONE";
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::foisal.Properties.Resources.back;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1161, 23);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 40);
            this.button7.TabIndex = 46;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(152, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "PHONE";
            // 
            // operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::foisal.Properties.Resources.Group_1562;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1241, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.u_l);
            this.Controls.Add(this.u_p);
            this.Controls.Add(this.u_w);
            this.Controls.Add(this.u_e);
            this.Controls.Add(this.u_n);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnumber);
            this.Controls.Add(this.search);
            this.DoubleBuffered = true;
            this.Name = "operation";
            this.Text = "Search by phone number";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox pnumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox u_n;
        private System.Windows.Forms.TextBox u_w;
        private System.Windows.Forms.TextBox u_e;
        private System.Windows.Forms.TextBox u_p;
        private System.Windows.Forms.ComboBox u_l;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderLoc;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderWeight;
        private System.Windows.Forms.ErrorProvider errorProviderPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
    }
}