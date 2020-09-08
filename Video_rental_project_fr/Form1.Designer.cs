namespace Video_rental_project_fr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.show_cust = new System.Windows.Forms.Button();
            this.show_video = new System.Windows.Forms.Button();
            this.show_rental = new System.Windows.Forms.Button();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genre_v = new System.Windows.Forms.TextBox();
            this.plot_v = new System.Windows.Forms.TextBox();
            this.V_add = new System.Windows.Forms.Button();
            this.v_update = new System.Windows.Forms.Button();
            this.v_delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.copy_v = new System.Windows.Forms.TextBox();
            this.rating_v = new System.Windows.Forms.TextBox();
            this.year_v = new System.Windows.Forms.TextBox();
            this.title_v = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.del_btn_rental = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.return_btn = new System.Windows.Forms.Button();
            this.Rental_V_ID = new System.Windows.Forms.TextBox();
            this.Issue_btn = new System.Windows.Forms.Button();
            this.rental_cus_ID = new System.Windows.Forms.TextBox();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.BookingDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delete_c = new System.Windows.Forms.Button();
            this.add_c = new System.Windows.Forms.Button();
            this.update_c = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.address_c = new System.Windows.Forms.TextBox();
            this.email_c = new System.Windows.Forms.TextBox();
            this.name_c = new System.Windows.Forms.TextBox();
            this.good_cus = new System.Windows.Forms.Button();
            this.high_rented_v = new System.Windows.Forms.Button();
            this.lblRental_ID = new System.Windows.Forms.Label();
            this.lblOption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // show_cust
            // 
            this.show_cust.BackColor = System.Drawing.Color.Red;
            this.show_cust.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_cust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_cust.Location = new System.Drawing.Point(12, 12);
            this.show_cust.Name = "show_cust";
            this.show_cust.Size = new System.Drawing.Size(152, 36);
            this.show_cust.TabIndex = 0;
            this.show_cust.Text = "Show Customers";
            this.show_cust.UseVisualStyleBackColor = false;
            this.show_cust.Click += new System.EventHandler(this.show_cust_Click);
            // 
            // show_video
            // 
            this.show_video.BackColor = System.Drawing.Color.Red;
            this.show_video.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_video.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_video.Location = new System.Drawing.Point(187, 12);
            this.show_video.Name = "show_video";
            this.show_video.Size = new System.Drawing.Size(152, 36);
            this.show_video.TabIndex = 1;
            this.show_video.Text = "Show Videos";
            this.show_video.UseVisualStyleBackColor = false;
            this.show_video.Click += new System.EventHandler(this.show_video_Click);
            // 
            // show_rental
            // 
            this.show_rental.BackColor = System.Drawing.Color.Red;
            this.show_rental.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_rental.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_rental.Location = new System.Drawing.Point(369, 12);
            this.show_rental.Name = "show_rental";
            this.show_rental.Size = new System.Drawing.Size(152, 36);
            this.show_rental.TabIndex = 2;
            this.show_rental.Text = "Show Rentals";
            this.show_rental.UseVisualStyleBackColor = false;
            this.show_rental.Click += new System.EventHandler(this.show_rental_Click);
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(12, 54);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(787, 173);
            this.dataTable.TabIndex = 3;
            this.dataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.genre_v);
            this.groupBox1.Controls.Add(this.plot_v);
            this.groupBox1.Controls.Add(this.V_add);
            this.groupBox1.Controls.Add(this.v_update);
            this.groupBox1.Controls.Add(this.v_delete);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.copy_v);
            this.groupBox1.Controls.Add(this.rating_v);
            this.groupBox1.Controls.Add(this.year_v);
            this.groupBox1.Controls.Add(this.title_v);
            this.groupBox1.Location = new System.Drawing.Point(12, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Plot";
            // 
            // genre_v
            // 
            this.genre_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_v.Location = new System.Drawing.Point(425, 63);
            this.genre_v.Name = "genre_v";
            this.genre_v.Size = new System.Drawing.Size(117, 26);
            this.genre_v.TabIndex = 42;
            // 
            // plot_v
            // 
            this.plot_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plot_v.Location = new System.Drawing.Point(425, 19);
            this.plot_v.Name = "plot_v";
            this.plot_v.Size = new System.Drawing.Size(117, 26);
            this.plot_v.TabIndex = 40;
            // 
            // V_add
            // 
            this.V_add.BackColor = System.Drawing.Color.Red;
            this.V_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.V_add.Location = new System.Drawing.Point(695, 19);
            this.V_add.Name = "V_add";
            this.V_add.Size = new System.Drawing.Size(86, 42);
            this.V_add.TabIndex = 38;
            this.V_add.Text = "Add";
            this.V_add.UseVisualStyleBackColor = false;
            this.V_add.Click += new System.EventHandler(this.V_add_Click);
            // 
            // v_update
            // 
            this.v_update.BackColor = System.Drawing.Color.Red;
            this.v_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.v_update.Location = new System.Drawing.Point(602, 69);
            this.v_update.Name = "v_update";
            this.v_update.Size = new System.Drawing.Size(91, 41);
            this.v_update.TabIndex = 37;
            this.v_update.Text = "Update";
            this.v_update.UseVisualStyleBackColor = false;
            this.v_update.Click += new System.EventHandler(this.v_update_Click);
            // 
            // v_delete
            // 
            this.v_delete.BackColor = System.Drawing.Color.Red;
            this.v_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.v_delete.Location = new System.Drawing.Point(669, 129);
            this.v_delete.Name = "v_delete";
            this.v_delete.Size = new System.Drawing.Size(97, 53);
            this.v_delete.TabIndex = 36;
            this.v_delete.Text = "Delete";
            this.v_delete.UseVisualStyleBackColor = false;
            this.v_delete.Click += new System.EventHandler(this.v_delete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Copies ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Year realesed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(70, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Rating(Points)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Movie Title :";
            // 
            // copy_v
            // 
            this.copy_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy_v.Location = new System.Drawing.Point(184, 143);
            this.copy_v.Name = "copy_v";
            this.copy_v.Size = new System.Drawing.Size(117, 26);
            this.copy_v.TabIndex = 31;
            // 
            // rating_v
            // 
            this.rating_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating_v.Location = new System.Drawing.Point(184, 51);
            this.rating_v.Name = "rating_v";
            this.rating_v.Size = new System.Drawing.Size(117, 26);
            this.rating_v.TabIndex = 30;
            // 
            // year_v
            // 
            this.year_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_v.Location = new System.Drawing.Point(184, 95);
            this.year_v.Name = "year_v";
            this.year_v.Size = new System.Drawing.Size(117, 26);
            this.year_v.TabIndex = 29;
            // 
            // title_v
            // 
            this.title_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_v.Location = new System.Drawing.Point(184, 6);
            this.title_v.Name = "title_v";
            this.title_v.Size = new System.Drawing.Size(117, 26);
            this.title_v.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOption);
            this.groupBox2.Controls.Add(this.lblRental_ID);
            this.groupBox2.Controls.Add(this.del_btn_rental);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.return_btn);
            this.groupBox2.Controls.Add(this.Rental_V_ID);
            this.groupBox2.Controls.Add(this.Issue_btn);
            this.groupBox2.Controls.Add(this.rental_cus_ID);
            this.groupBox2.Controls.Add(this.ReturnDate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.BookingDate);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(12, 440);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 194);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rental Add";
            // 
            // del_btn_rental
            // 
            this.del_btn_rental.BackColor = System.Drawing.Color.Red;
            this.del_btn_rental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn_rental.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.del_btn_rental.Location = new System.Drawing.Point(251, 90);
            this.del_btn_rental.Name = "del_btn_rental";
            this.del_btn_rental.Size = new System.Drawing.Size(100, 31);
            this.del_btn_rental.TabIndex = 51;
            this.del_btn_rental.Text = "Delete Movie";
            this.del_btn_rental.UseVisualStyleBackColor = false;
            this.del_btn_rental.Click += new System.EventHandler(this.del_btn_rental_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 43;
            this.label14.Text = "Video Id:";
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.Red;
            this.return_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.return_btn.Location = new System.Drawing.Point(251, 53);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(98, 31);
            this.return_btn.TabIndex = 50;
            this.return_btn.Text = "Retrun Now";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // Rental_V_ID
            // 
            this.Rental_V_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rental_V_ID.Location = new System.Drawing.Point(104, 29);
            this.Rental_V_ID.Name = "Rental_V_ID";
            this.Rental_V_ID.Size = new System.Drawing.Size(117, 26);
            this.Rental_V_ID.TabIndex = 41;
            // 
            // Issue_btn
            // 
            this.Issue_btn.BackColor = System.Drawing.Color.Red;
            this.Issue_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issue_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Issue_btn.Location = new System.Drawing.Point(253, 16);
            this.Issue_btn.Name = "Issue_btn";
            this.Issue_btn.Size = new System.Drawing.Size(58, 31);
            this.Issue_btn.TabIndex = 49;
            this.Issue_btn.Text = "Issue";
            this.Issue_btn.UseVisualStyleBackColor = false;
            this.Issue_btn.Click += new System.EventHandler(this.Issue_btn_Click);
            // 
            // rental_cus_ID
            // 
            this.rental_cus_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_cus_ID.Location = new System.Drawing.Point(104, 80);
            this.rental_cus_ID.Name = "rental_cus_ID";
            this.rental_cus_ID.Size = new System.Drawing.Size(117, 26);
            this.rental_cus_ID.TabIndex = 42;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDate.Location = new System.Drawing.Point(111, 160);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(110, 20);
            this.ReturnDate.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Customer ID";
            // 
            // BookingDate
            // 
            this.BookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BookingDate.Location = new System.Drawing.Point(111, 127);
            this.BookingDate.Name = "BookingDate";
            this.BookingDate.Size = new System.Drawing.Size(110, 20);
            this.BookingDate.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 20);
            this.label16.TabIndex = 45;
            this.label16.Text = "Issue Date ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 20);
            this.label15.TabIndex = 46;
            this.label15.Text = "Return Date";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delete_c);
            this.groupBox3.Controls.Add(this.add_c);
            this.groupBox3.Controls.Add(this.update_c);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.address_c);
            this.groupBox3.Controls.Add(this.email_c);
            this.groupBox3.Controls.Add(this.name_c);
            this.groupBox3.Location = new System.Drawing.Point(373, 440);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 194);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New Customer Add";
            // 
            // delete_c
            // 
            this.delete_c.BackColor = System.Drawing.Color.Red;
            this.delete_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_c.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_c.Location = new System.Drawing.Point(318, 111);
            this.delete_c.Name = "delete_c";
            this.delete_c.Size = new System.Drawing.Size(74, 31);
            this.delete_c.TabIndex = 39;
            this.delete_c.Text = "Delete";
            this.delete_c.UseVisualStyleBackColor = false;
            this.delete_c.Click += new System.EventHandler(this.delete_c_Click);
            // 
            // add_c
            // 
            this.add_c.BackColor = System.Drawing.Color.Red;
            this.add_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_c.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_c.Location = new System.Drawing.Point(318, 29);
            this.add_c.Name = "add_c";
            this.add_c.Size = new System.Drawing.Size(65, 31);
            this.add_c.TabIndex = 38;
            this.add_c.Text = "Add ";
            this.add_c.UseVisualStyleBackColor = false;
            this.add_c.Click += new System.EventHandler(this.add_c_Click);
            // 
            // update_c
            // 
            this.update_c.BackColor = System.Drawing.Color.Red;
            this.update_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_c.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_c.Location = new System.Drawing.Point(318, 66);
            this.update_c.Name = "update_c";
            this.update_c.Size = new System.Drawing.Size(78, 31);
            this.update_c.TabIndex = 37;
            this.update_c.Text = "Update";
            this.update_c.UseVisualStyleBackColor = false;
            this.update_c.Click += new System.EventHandler(this.update_c_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Full Name :";
            // 
            // address_c
            // 
            this.address_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_c.Location = new System.Drawing.Point(134, 127);
            this.address_c.Name = "address_c";
            this.address_c.Size = new System.Drawing.Size(117, 26);
            this.address_c.TabIndex = 32;
            // 
            // email_c
            // 
            this.email_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_c.Location = new System.Drawing.Point(134, 80);
            this.email_c.Name = "email_c";
            this.email_c.Size = new System.Drawing.Size(117, 26);
            this.email_c.TabIndex = 31;
            // 
            // name_c
            // 
            this.name_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_c.Location = new System.Drawing.Point(134, 35);
            this.name_c.Name = "name_c";
            this.name_c.Size = new System.Drawing.Size(117, 26);
            this.name_c.TabIndex = 29;
            // 
            // good_cus
            // 
            this.good_cus.BackColor = System.Drawing.Color.Red;
            this.good_cus.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.good_cus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.good_cus.Location = new System.Drawing.Point(537, 12);
            this.good_cus.Name = "good_cus";
            this.good_cus.Size = new System.Drawing.Size(152, 36);
            this.good_cus.TabIndex = 7;
            this.good_cus.Text = "Good Customer";
            this.good_cus.UseVisualStyleBackColor = false;
            this.good_cus.Click += new System.EventHandler(this.good_cus_Click);
            // 
            // high_rented_v
            // 
            this.high_rented_v.BackColor = System.Drawing.Color.Red;
            this.high_rented_v.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high_rented_v.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.high_rented_v.Location = new System.Drawing.Point(704, 12);
            this.high_rented_v.Name = "high_rented_v";
            this.high_rented_v.Size = new System.Drawing.Size(168, 36);
            this.high_rented_v.TabIndex = 8;
            this.high_rented_v.Text = "High Rented Video";
            this.high_rented_v.UseVisualStyleBackColor = false;
            this.high_rented_v.Click += new System.EventHandler(this.high_rented_v_Click);
            // 
            // lblRental_ID
            // 
            this.lblRental_ID.AutoSize = true;
            this.lblRental_ID.Location = new System.Drawing.Point(250, 140);
            this.lblRental_ID.Name = "lblRental_ID";
            this.lblRental_ID.Size = new System.Drawing.Size(0, 13);
            this.lblRental_ID.TabIndex = 47;
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Location = new System.Drawing.Point(317, 155);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(0, 13);
            this.lblOption.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 646);
            this.Controls.Add(this.high_rented_v);
            this.Controls.Add(this.good_cus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.show_rental);
            this.Controls.Add(this.show_video);
            this.Controls.Add(this.show_cust);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_cust;
        private System.Windows.Forms.Button show_video;
        private System.Windows.Forms.Button show_rental;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox genre_v;
        private System.Windows.Forms.TextBox plot_v;
        private System.Windows.Forms.Button V_add;
        private System.Windows.Forms.Button v_update;
        private System.Windows.Forms.Button v_delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox copy_v;
        private System.Windows.Forms.TextBox rating_v;
        private System.Windows.Forms.TextBox year_v;
        private System.Windows.Forms.TextBox title_v;
        private System.Windows.Forms.Button del_btn_rental;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.TextBox Rental_V_ID;
        private System.Windows.Forms.Button Issue_btn;
        private System.Windows.Forms.TextBox rental_cus_ID;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker BookingDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button delete_c;
        private System.Windows.Forms.Button add_c;
        private System.Windows.Forms.Button update_c;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address_c;
        private System.Windows.Forms.TextBox email_c;
        private System.Windows.Forms.TextBox name_c;
        private System.Windows.Forms.Button good_cus;
        private System.Windows.Forms.Button high_rented_v;
        private System.Windows.Forms.Label lblRental_ID;
        private System.Windows.Forms.Label lblOption;
    }
}

