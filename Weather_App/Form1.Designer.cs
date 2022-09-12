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
            this.lbl_weather_info = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.lbl_temperature = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_average_temp = new System.Windows.Forms.Label();
            this.lbl_MN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.comboBox_state = new System.Windows.Forms.ComboBox();
            this.textBox_temp = new System.Windows.Forms.TextBox();
            this.btn_add_info = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl__test = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // lbl_weather_info
            // 
            this.lbl_weather_info.AutoSize = true;
            this.lbl_weather_info.Location = new System.Drawing.Point(50, 41);
            this.lbl_weather_info.Name = "lbl_weather_info";
            this.lbl_weather_info.Size = new System.Drawing.Size(146, 20);
            this.lbl_weather_info.TabIndex = 0;
            this.lbl_weather_info.Text = "Weather Information";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(54, 77);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(34, 20);
            this.lbl_city.TabIndex = 1;
            this.lbl_city.Text = "City";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(57, 113);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(43, 20);
            this.lbl_state.TabIndex = 2;
            this.lbl_state.Text = "State";
            // 
            // lbl_temperature
            // 
            this.lbl_temperature.AutoSize = true;
            this.lbl_temperature.Location = new System.Drawing.Point(57, 149);
            this.lbl_temperature.Name = "lbl_temperature";
            this.lbl_temperature.Size = new System.Drawing.Size(89, 20);
            this.lbl_temperature.TabIndex = 3;
            this.lbl_temperature.Text = "Temp (in °F)";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(60, 184);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(41, 20);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "Date";
            // 
            // lbl_average_temp
            // 
            this.lbl_average_temp.AutoSize = true;
            this.lbl_average_temp.Location = new System.Drawing.Point(404, 48);
            this.lbl_average_temp.Name = "lbl_average_temp";
            this.lbl_average_temp.Size = new System.Drawing.Size(152, 20);
            this.lbl_average_temp.TabIndex = 5;
            this.lbl_average_temp.Text = "Average Temperature";
            // 
            // lbl_MN
            // 
            this.lbl_MN.AutoSize = true;
            this.lbl_MN.Location = new System.Drawing.Point(405, 82);
            this.lbl_MN.Name = "lbl_MN";
            this.lbl_MN.Size = new System.Drawing.Size(33, 20);
            this.lbl_MN.TabIndex = 6;
            this.lbl_MN.Text = "MN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(94, 74);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(125, 27);
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
            this.comboBox_state.Location = new System.Drawing.Point(106, 107);
            this.comboBox_state.Name = "comboBox_state";
            this.comboBox_state.Size = new System.Drawing.Size(151, 28);
            this.comboBox_state.TabIndex = 9;
            // 
            // textBox_temp
            // 
            this.textBox_temp.Location = new System.Drawing.Point(152, 149);
            this.textBox_temp.Name = "textBox_temp";
            this.textBox_temp.Size = new System.Drawing.Size(125, 27);
            this.textBox_temp.TabIndex = 10;
            // 
            // btn_add_info
            // 
            this.btn_add_info.Location = new System.Drawing.Point(46, 230);
            this.btn_add_info.Name = "btn_add_info";
            this.btn_add_info.Size = new System.Drawing.Size(128, 29);
            this.btn_add_info.TabIndex = 12;
            this.btn_add_info.Text = "Add Information";
            this.btn_add_info.UseVisualStyleBackColor = true;
            this.btn_add_info.Click += new System.EventHandler(this.btn_add_info_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(194, 230);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 29);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl__test
            // 
            this.lbl__test.AutoSize = true;
            this.lbl__test.Location = new System.Drawing.Point(435, 182);
            this.lbl__test.Name = "lbl__test";
            this.lbl__test.Size = new System.Drawing.Size(50, 20);
            this.lbl__test.TabIndex = 14;
            this.lbl__test.Text = "label2";
            // 
            // dateTimePicker_input
            // 
            this.dateTimePicker_input.Location = new System.Drawing.Point(105, 182);
            this.dateTimePicker_input.Name = "dateTimePicker_input";
            this.dateTimePicker_input.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_input.TabIndex = 15;
            // 
            // listView_output
            // 
            this.listView_output.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_date,
            this.column_city,
            this.column_state,
            this.column_temp});
            this.listView_output.Location = new System.Drawing.Point(50, 292);
            this.listView_output.Name = "listView_output";
            this.listView_output.Size = new System.Drawing.Size(711, 146);
            this.listView_output.TabIndex = 16;
            this.listView_output.UseCompatibleStateImageBehavior = false;
            this.listView_output.View = System.Windows.Forms.View.Details;
            // 
            // column_date
            // 
            this.column_date.Text = "Date";
            this.column_date.Width = 200;
            // 
            // column_city
            // 
            this.column_city.Text = "City";
            this.column_city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_city.Width = 200;
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
            this.column_temp.Width = 200;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(57, 459);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(125, 27);
            this.textBox_search.TabIndex = 17;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(194, 457);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 29);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(304, 457);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(134, 29);
            this.btn_remove.TabIndex = 19;
            this.btn_remove.Text = "Remove Record";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(462, 457);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(101, 29);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "Edit Record";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_remove_all
            // 
            this.btn_remove_all.Location = new System.Drawing.Point(316, 507);
            this.btn_remove_all.Name = "btn_remove_all";
            this.btn_remove_all.Size = new System.Drawing.Size(134, 29);
            this.btn_remove_all.TabIndex = 21;
            this.btn_remove_all.Text = "Remove All";
            this.btn_remove_all.UseVisualStyleBackColor = true;
            this.btn_remove_all.Click += new System.EventHandler(this.btn_remove_all_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(469, 507);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(94, 29);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_highest_temp
            // 
            this.btn_highest_temp.Location = new System.Drawing.Point(57, 507);
            this.btn_highest_temp.Name = "btn_highest_temp";
            this.btn_highest_temp.Size = new System.Drawing.Size(125, 29);
            this.btn_highest_temp.TabIndex = 23;
            this.btn_highest_temp.Text = "Highest Temp";
            this.btn_highest_temp.UseVisualStyleBackColor = true;
            this.btn_highest_temp.Click += new System.EventHandler(this.btn_highest_temp_Click);
            // 
            // btn_lowest_temp
            // 
            this.btn_lowest_temp.Location = new System.Drawing.Point(194, 507);
            this.btn_lowest_temp.Name = "btn_lowest_temp";
            this.btn_lowest_temp.Size = new System.Drawing.Size(110, 29);
            this.btn_lowest_temp.TabIndex = 24;
            this.btn_lowest_temp.Text = "Lowest Temp";
            this.btn_lowest_temp.UseVisualStyleBackColor = true;
            this.btn_lowest_temp.Click += new System.EventHandler(this.btn_lowest_temp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.btn_lowest_temp);
            this.Controls.Add(this.btn_highest_temp);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_remove_all);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.listView_output);
            this.Controls.Add(this.dateTimePicker_input);
            this.Controls.Add(this.lbl__test);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add_info);
            this.Controls.Add(this.textBox_temp);
            this.Controls.Add(this.comboBox_state);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_MN);
            this.Controls.Add(this.lbl_average_temp);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_temperature);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.lbl_weather_info);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_weather_info;
        private Label lbl_city;
        private Label lbl_state;
        private Label lbl_temperature;
        private Label lbl_date;
        private Label lbl_average_temp;
        private Label lbl_MN;
        private Label label1;
        private TextBox textBox_city;
        private ComboBox comboBox_state;
        private TextBox textBox_temp;
        private Button btn_add_info;
        private Button btn_clear;
        private Label lbl__test;
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
    }
}