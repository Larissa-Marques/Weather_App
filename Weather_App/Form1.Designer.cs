namespace Weather_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.lbl_temperature = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_MN = new System.Windows.Forms.Label();
            this.lbl_ND = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.comboBox_state = new System.Windows.Forms.ComboBox();
            this.textBox_temp = new System.Windows.Forms.TextBox();
            this.btn_add_info = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl__region = new System.Windows.Forms.Label();
            this.dateTimePicker_input = new System.Windows.Forms.DateTimePicker();
            this.listView_output = new System.Windows.Forms.ListView();
            this.column_date = new System.Windows.Forms.ColumnHeader();
            this.column_city = new System.Windows.Forms.ColumnHeader();
            this.column_state = new System.Windows.Forms.ColumnHeader();
            this.column_temp = new System.Windows.Forms.ColumnHeader();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_remove_all = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_highest_temp = new System.Windows.Forms.Button();
            this.btn_lowest_temp = new System.Windows.Forms.Button();
            this.textBox_region = new System.Windows.Forms.TextBox();
            this.lbl_SD = new System.Windows.Forms.Label();
            this.lbl_IA = new System.Windows.Forms.Label();
            this.lbl_WI = new System.Windows.Forms.Label();
            this.textBox_MN = new System.Windows.Forms.TextBox();
            this.textBox_ND = new System.Windows.Forms.TextBox();
            this.textBox_SD = new System.Windows.Forms.TextBox();
            this.textBox_IA = new System.Windows.Forms.TextBox();
            this.textBox_WI = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox_weather = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox_weather.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(25, 26);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(35, 20);
            this.lbl_city.TabIndex = 1;
            this.lbl_city.Text = "City";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(25, 71);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(43, 20);
            this.lbl_state.TabIndex = 2;
            this.lbl_state.Text = "State";
            // 
            // lbl_temperature
            // 
            this.lbl_temperature.AutoSize = true;
            this.lbl_temperature.Location = new System.Drawing.Point(25, 111);
            this.lbl_temperature.Name = "lbl_temperature";
            this.lbl_temperature.Size = new System.Drawing.Size(91, 20);
            this.lbl_temperature.TabIndex = 3;
            this.lbl_temperature.Text = "Temp (in °F)";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(25, 157);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(40, 20);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "Date";
            // 
            // lbl_MN
            // 
            this.lbl_MN.AutoSize = true;
            this.lbl_MN.Location = new System.Drawing.Point(35, 50);
            this.lbl_MN.Name = "lbl_MN";
            this.lbl_MN.Size = new System.Drawing.Size(33, 20);
            this.lbl_MN.TabIndex = 6;
            this.lbl_MN.Text = "MN";
            // 
            // lbl_ND
            // 
            this.lbl_ND.AutoSize = true;
            this.lbl_ND.Location = new System.Drawing.Point(35, 93);
            this.lbl_ND.Name = "lbl_ND";
            this.lbl_ND.Size = new System.Drawing.Size(31, 20);
            this.lbl_ND.TabIndex = 7;
            this.lbl_ND.Text = "ND";
            // 
            // textBox_city
            // 
            this.textBox_city.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_city.Location = new System.Drawing.Point(186, 26);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(125, 28);
            this.textBox_city.TabIndex = 8;
            // 
            // comboBox_state
            // 
            this.comboBox_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_state.FormattingEnabled = true;
            this.comboBox_state.Items.AddRange(new object[] {
            "",
            "MN",
            "ND",
            "SD",
            "IA",
            "WI"});
            this.comboBox_state.Location = new System.Drawing.Point(186, 68);
            this.comboBox_state.Name = "comboBox_state";
            this.comboBox_state.Size = new System.Drawing.Size(125, 28);
            this.comboBox_state.TabIndex = 9;
            // 
            // textBox_temp
            // 
            this.textBox_temp.Location = new System.Drawing.Point(186, 111);
            this.textBox_temp.Name = "textBox_temp";
            this.textBox_temp.Size = new System.Drawing.Size(125, 28);
            this.textBox_temp.TabIndex = 10;
            // 
            // btn_add_info
            // 
            this.btn_add_info.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_add_info.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_info.Location = new System.Drawing.Point(25, 203);
            this.btn_add_info.Name = "btn_add_info";
            this.btn_add_info.Size = new System.Drawing.Size(128, 29);
            this.btn_add_info.TabIndex = 12;
            this.btn_add_info.Text = "Add Information";
            this.btn_add_info.UseVisualStyleBackColor = false;
            this.btn_add_info.Click += new System.EventHandler(this.btn_add_info_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Location = new System.Drawing.Point(217, 203);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 29);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl__region
            // 
            this.lbl__region.AutoSize = true;
            this.lbl__region.Location = new System.Drawing.Point(28, 269);
            this.lbl__region.Name = "lbl__region";
            this.lbl__region.Size = new System.Drawing.Size(55, 20);
            this.lbl__region.TabIndex = 14;
            this.lbl__region.Text = "Region";
            // 
            // dateTimePicker_input
            // 
            this.dateTimePicker_input.Location = new System.Drawing.Point(70, 152);
            this.dateTimePicker_input.Name = "dateTimePicker_input";
            this.dateTimePicker_input.Size = new System.Drawing.Size(241, 28);
            this.dateTimePicker_input.TabIndex = 15;
            // 
            // listView_output
            // 
            this.listView_output.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_date,
            this.column_city,
            this.column_state,
            this.column_temp});
            this.listView_output.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_output.Location = new System.Drawing.Point(12, 364);
            this.listView_output.Name = "listView_output";
            this.listView_output.Size = new System.Drawing.Size(642, 146);
            this.listView_output.TabIndex = 16;
            this.listView_output.UseCompatibleStateImageBehavior = false;
            this.listView_output.View = System.Windows.Forms.View.Details;
            // 
            // column_date
            // 
            this.column_date.Text = "Date";
            this.column_date.Width = 150;
            // 
            // column_city
            // 
            this.column_city.Text = "City";
            this.column_city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_city.Width = 180;
            // 
            // column_state
            // 
            this.column_state.Text = "State";
            this.column_state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_state.Width = 150;
            // 
            // column_temp
            // 
            this.column_temp.Text = "Temperature";
            this.column_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_temp.Width = 150;
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_search.Location = new System.Drawing.Point(14, 528);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(129, 28);
            this.textBox_search.TabIndex = 17;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Location = new System.Drawing.Point(174, 528);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(129, 29);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_remove.Location = new System.Drawing.Point(349, 527);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(129, 29);
            this.btn_remove.TabIndex = 19;
            this.btn_remove.Text = "Remove Record";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_edit.Location = new System.Drawing.Point(525, 528);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(129, 29);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "Edit Record";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_remove_all
            // 
            this.btn_remove_all.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_remove_all.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove_all.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_remove_all.Location = new System.Drawing.Point(349, 576);
            this.btn_remove_all.Name = "btn_remove_all";
            this.btn_remove_all.Size = new System.Drawing.Size(129, 29);
            this.btn_remove_all.TabIndex = 21;
            this.btn_remove_all.Text = "Remove All";
            this.btn_remove_all.UseVisualStyleBackColor = false;
            this.btn_remove_all.Click += new System.EventHandler(this.btn_remove_all_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_close.Location = new System.Drawing.Point(525, 576);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(129, 29);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_highest_temp
            // 
            this.btn_highest_temp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_highest_temp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_highest_temp.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_highest_temp.Location = new System.Drawing.Point(14, 576);
            this.btn_highest_temp.Name = "btn_highest_temp";
            this.btn_highest_temp.Size = new System.Drawing.Size(129, 29);
            this.btn_highest_temp.TabIndex = 23;
            this.btn_highest_temp.Text = "Highest Temp";
            this.btn_highest_temp.UseVisualStyleBackColor = false;
            this.btn_highest_temp.Click += new System.EventHandler(this.btn_highest_temp_Click);
            // 
            // btn_lowest_temp
            // 
            this.btn_lowest_temp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_lowest_temp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lowest_temp.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_lowest_temp.Location = new System.Drawing.Point(174, 576);
            this.btn_lowest_temp.Name = "btn_lowest_temp";
            this.btn_lowest_temp.Size = new System.Drawing.Size(129, 29);
            this.btn_lowest_temp.TabIndex = 24;
            this.btn_lowest_temp.Text = "Lowest Temp";
            this.btn_lowest_temp.UseVisualStyleBackColor = false;
            this.btn_lowest_temp.Click += new System.EventHandler(this.btn_lowest_temp_Click);
            // 
            // textBox_region
            // 
            this.textBox_region.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_region.Location = new System.Drawing.Point(124, 266);
            this.textBox_region.Name = "textBox_region";
            this.textBox_region.ReadOnly = true;
            this.textBox_region.Size = new System.Drawing.Size(125, 28);
            this.textBox_region.TabIndex = 25;
            // 
            // lbl_SD
            // 
            this.lbl_SD.AutoSize = true;
            this.lbl_SD.Location = new System.Drawing.Point(35, 136);
            this.lbl_SD.Name = "lbl_SD";
            this.lbl_SD.Size = new System.Drawing.Size(30, 20);
            this.lbl_SD.TabIndex = 26;
            this.lbl_SD.Text = "SD";
            // 
            // lbl_IA
            // 
            this.lbl_IA.AutoSize = true;
            this.lbl_IA.Location = new System.Drawing.Point(36, 179);
            this.lbl_IA.Name = "lbl_IA";
            this.lbl_IA.Size = new System.Drawing.Size(22, 20);
            this.lbl_IA.TabIndex = 27;
            this.lbl_IA.Text = "IA";
            // 
            // lbl_WI
            // 
            this.lbl_WI.AutoSize = true;
            this.lbl_WI.Location = new System.Drawing.Point(36, 227);
            this.lbl_WI.Name = "lbl_WI";
            this.lbl_WI.Size = new System.Drawing.Size(26, 20);
            this.lbl_WI.TabIndex = 28;
            this.lbl_WI.Text = "WI";
            // 
            // textBox_MN
            // 
            this.textBox_MN.Location = new System.Drawing.Point(124, 47);
            this.textBox_MN.Name = "textBox_MN";
            this.textBox_MN.ReadOnly = true;
            this.textBox_MN.Size = new System.Drawing.Size(125, 28);
            this.textBox_MN.TabIndex = 29;
            // 
            // textBox_ND
            // 
            this.textBox_ND.Location = new System.Drawing.Point(124, 90);
            this.textBox_ND.Name = "textBox_ND";
            this.textBox_ND.ReadOnly = true;
            this.textBox_ND.Size = new System.Drawing.Size(125, 28);
            this.textBox_ND.TabIndex = 30;
            // 
            // textBox_SD
            // 
            this.textBox_SD.Location = new System.Drawing.Point(124, 133);
            this.textBox_SD.Name = "textBox_SD";
            this.textBox_SD.ReadOnly = true;
            this.textBox_SD.Size = new System.Drawing.Size(125, 28);
            this.textBox_SD.TabIndex = 31;
            // 
            // textBox_IA
            // 
            this.textBox_IA.Location = new System.Drawing.Point(124, 176);
            this.textBox_IA.Name = "textBox_IA";
            this.textBox_IA.ReadOnly = true;
            this.textBox_IA.Size = new System.Drawing.Size(125, 28);
            this.textBox_IA.TabIndex = 32;
            // 
            // textBox_WI
            // 
            this.textBox_WI.Location = new System.Drawing.Point(124, 224);
            this.textBox_WI.Name = "textBox_WI";
            this.textBox_WI.ReadOnly = true;
            this.textBox_WI.Size = new System.Drawing.Size(125, 28);
            this.textBox_WI.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(185, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox_weather
            // 
            this.groupBox_weather.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_weather.Controls.Add(this.textBox_city);
            this.groupBox_weather.Controls.Add(this.lbl_city);
            this.groupBox_weather.Controls.Add(this.comboBox_state);
            this.groupBox_weather.Controls.Add(this.textBox_temp);
            this.groupBox_weather.Controls.Add(this.btn_clear);
            this.groupBox_weather.Controls.Add(this.btn_add_info);
            this.groupBox_weather.Controls.Add(this.dateTimePicker_input);
            this.groupBox_weather.Controls.Add(this.lbl_temperature);
            this.groupBox_weather.Controls.Add(this.lbl_date);
            this.groupBox_weather.Controls.Add(this.lbl_state);
            this.groupBox_weather.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_weather.Location = new System.Drawing.Point(12, 12);
            this.groupBox_weather.Name = "groupBox_weather";
            this.groupBox_weather.Size = new System.Drawing.Size(333, 247);
            this.groupBox_weather.TabIndex = 36;
            this.groupBox_weather.TabStop = false;
            this.groupBox_weather.Text = "Weather Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_MN);
            this.groupBox1.Controls.Add(this.textBox_ND);
            this.groupBox1.Controls.Add(this.lbl_SD);
            this.groupBox1.Controls.Add(this.lbl_IA);
            this.groupBox1.Controls.Add(this.lbl_WI);
            this.groupBox1.Controls.Add(this.textBox_WI);
            this.groupBox1.Controls.Add(this.textBox_SD);
            this.groupBox1.Controls.Add(this.textBox_IA);
            this.groupBox1.Controls.Add(this.textBox_region);
            this.groupBox1.Controls.Add(this.lbl_MN);
            this.groupBox1.Controls.Add(this.lbl__region);
            this.groupBox1.Controls.Add(this.lbl_ND);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(374, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 328);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Average Temperature";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 621);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_lowest_temp);
            this.Controls.Add(this.btn_highest_temp);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_remove_all);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.listView_output);
            this.Controls.Add(this.groupBox_weather);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox_weather.ResumeLayout(false);
            this.groupBox_weather.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_city;
        private Label lbl_state;
        private Label lbl_temperature;
        private Label lbl_date;
        private Label lbl_MN;
        private Label lbl_ND;
        private TextBox textBox_city;
        private ComboBox comboBox_state;
        private TextBox textBox_temp;
        private Button btn_add_info;
        private Button btn_clear;
        private Label lbl__region;
        private DateTimePicker dateTimePicker_input;
        private ListView listView_output;
        private ColumnHeader column_date;
        private ColumnHeader column_city;
        private ColumnHeader column_state;
        private ColumnHeader column_temp;
        private TextBox textBox_search;
        private Button btn_search;
        private Button btn_remove;
        private Button btn_edit;
        private Button btn_remove_all;
        private Button btn_close;
        private Button btn_highest_temp;
        private Button btn_lowest_temp;
        private TextBox textBox_region;
        private Label lbl_SD;
        private Label lbl_IA;
        private Label lbl_WI;
        private TextBox textBox_MN;
        private TextBox textBox_ND;
        private TextBox textBox_SD;
        private TextBox textBox_IA;
        private TextBox textBox_WI;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox_weather;
        private GroupBox groupBox1;
    }
}