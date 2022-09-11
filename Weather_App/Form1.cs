using System.Drawing.Text;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //store inputs (city, state, temp, date) in the memory
        public class CityRecord
        {
            public string city;
            public string state;
            public string temperature;
            public DateTime date;
        }

        List<CityRecord> records = new List<CityRecord>();
        private void btn_add_info_Click(object sender, EventArgs e)
        {
            
            //When this button is clicked,display city, state, temp and date
            // be displayed as a label
            CityRecord record = new CityRecord();

            record.city = textBox_city.Text;
            record.state = comboBox_state.Text;
            record.temperature = textBox_temp.Text;
            record.date = dateTimePicker_input.Value;

            records.Add(record);

            string output = "";

            foreach (CityRecord i in records)
            {
                output = output + i.date + " " + i.city + " " + i.state + " " + i.temperature;
            }

            lbl__test.Text = output; 

        }

    }
}