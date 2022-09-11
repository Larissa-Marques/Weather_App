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
            this.comboBox_state.FormattingEnabled = true;
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
            this.listView_output.Location = new System.Drawing.Point(46, 292);
            this.listView_output.Name = "listView_output";
            this.listView_output.Size = new System.Drawing.Size(704, 146);
            this.listView_output.TabIndex = 16;
            this.listView_output.UseCompatibleStateImageBehavior = false;
            this.listView_output.View = System.Windows.Forms.View.Details;
            // 
            // column_date
            // 
            this.column_date.Text = "Date";
            // 
            // column_city
            // 
            this.column_city.Text = "City";
            this.column_city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // column_state
            // 
            this.column_state.Text = "State";
            this.column_state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // column_temp
            // 
            this.column_temp.Text = "Temperature";
            this.column_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}