// Weather application purpose is to collect weather data to calculate averages of five states (Minnesota,
// North Dakota, South Dakota, Wisconsin and Iowa) and the region. It is also possible to find the 
// lowest and highest temperature, remove a selected record or remove all records. There is the option to
// save changes when closing the application.

using System.Drawing.Text;
using System.Net.Security;
using static System.Windows.Forms.LinkLabel;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Reading the file and populating the listview 
            string fullPath = Path.GetFullPath(Path.GetDirectoryName(Application.ExecutablePath) + "\\Weather.csv");
            string[] contents = File.ReadAllLines(fullPath);
            foreach (string line in contents)
            {
                string[] line_split = line.Split(',');
                ListViewItem listViewItem = new ListViewItem(line_split);
                listView_output.Items.Add(listViewItem);
            }
            // Populate the temperature averages
            populate_averages();
        }

        private void populate_averages() 
        {
            // Calling the calculate_averages method for the region and each state (MN, ND, SD, WI, IA)
            textBox_region.Text = calculate_averages();
            textBox_MN.Text = calculate_averages("MN");
            textBox_ND.Text = calculate_averages("ND");
            textBox_SD.Text = calculate_averages("SD");
            textBox_IA.Text = calculate_averages("IA");
            textBox_WI.Text = calculate_averages("WI");
        }

        private string calculate_averages(string state = "")
        {
            // Based on the given state, or no state, calculate and return the average temperature.
            string result = "";
            decimal sum = 0;
            int count = 0;
            foreach (ListViewItem item in listView_output.Items)
            {
                if (state == "" || item.SubItems[2].Text == state)
                {
                    decimal temp = Convert.ToDecimal(item.SubItems[3].Text.Split("°")[0]);
                    sum = sum + temp;
                    count++;
                }
            }
            if (count != 0) 
            {
                decimal average = sum / count;
                result = average.ToString("0.00") + "°F";
            }
            return result;
        }

        private void btn_add_info_Click(object sender, EventArgs e)
        {
            decimal temp;
            // Validation if no data is entered, temperature formating and range.
            if (textBox_city.Text == "")
            {
                textBox_city.Focus();
                MessageBox.Show("Please enter a city.");
            }
            else if (comboBox_state.Text == "")
            {
                comboBox_state.Focus();
                MessageBox.Show("Please enter a state.");
            }
            else if (textBox_temp.Text == "")
            {
                textBox_temp.Focus();
                MessageBox.Show("Please enter a temperature.");
            }
            else if (!Decimal.TryParse(textBox_temp.Text, out temp))
            {
                textBox_temp.Focus();
                MessageBox.Show("Invalid temperature format. Please enter a number.");
            }
            else if (temp < -80 || temp > 130)
            {
                textBox_temp.Focus();
                MessageBox.Show("The temperature should be above -80 and below 130.");
            }
            else
            {
                // When this button is clicked, the city, state, temperature and date will be displayed on
                // the listview.
                string[] row = { dateTimePicker_input.Value.ToShortDateString(), textBox_city.Text,
                    comboBox_state.Text, temp.ToString("0.00") + "°F" };
                ListViewItem listViewItem = new ListViewItem(row);
                listView_output.Items.Add(listViewItem);
                populate_averages();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // When this button is clicked, the info (city, state, temp, date) will be erased.
            textBox_city.Text = "";
            comboBox_state.Text = "";
            textBox_temp.Text = "";
            dateTimePicker_input.Value = DateTime.Today;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //When this button is clicked, it will find on the listview the data entered by the user
            string search_term = textBox_search.Text;
            ListViewItem matched_item = listView_output.FindItemWithText(search_term);

            if (matched_item != null && search_term != "")
                MessageBox.Show("Date: " + matched_item.SubItems[0].Text + "\nCity: " +
                    matched_item.SubItems[1].Text + "\nState: " +
                    matched_item.SubItems[2].Text + "\nTemperature: " + matched_item.SubItems[3].Text);
            else
                MessageBox.Show("Search not found!");
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will remove all the selected information.
            if (listView_output.SelectedItems.Count > 0)
            {
                listView_output.Items.Remove(listView_output.SelectedItems[0]);
                populate_averages();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will edit the selected information.
            if (listView_output.SelectedItems.Count > 0)
            {
                ListViewItem selected_item = listView_output.SelectedItems[0];
                dateTimePicker_input.Text = selected_item.SubItems[0].Text;
                textBox_city.Text = selected_item.SubItems[1].Text;
                comboBox_state.Text = selected_item.SubItems[2].Text;
                textBox_temp.Text = selected_item.SubItems[3].Text;
                listView_output.Items.Remove(selected_item);
                populate_averages();
            }
        }

        private void btn_remove_all_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will remove all the information without any selection.
            listView_output.Items.Clear();
            populate_averages();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            string message = "Do you want to save changes?";
            string caption = "Weather Information";
            DialogResult result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo);

            // If the Yes button is pressed...
            if (result == DialogResult.Yes)
            {
                // Save data to the file.
                List<string> lines = new List<string>();
                foreach (ListViewItem item in listView_output.Items)
                {
                    string line = item.SubItems[0].Text + ',' + item.SubItems[1].Text + ',' +
                        item.SubItems[2].Text + ',' + item.SubItems[3].Text;
                    lines.Add(line);
                }
                File.WriteAllLines("Weather.csv", lines);
            }
            this.Close();
        }

        private void btn_highest_temp_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will find and show the record with the highest temperature.
            if (listView_output.Items.Count != 0)
            {
                decimal highest_temp = -80;
                ListViewItem highest_temp_item = new ListViewItem();
                foreach (ListViewItem item in listView_output.Items)
                {
                    decimal temp = Convert.ToDecimal(item.SubItems[3].Text.Split("°")[0]);
                    if (temp > highest_temp)
                    {
                        highest_temp = temp;
                        highest_temp_item = item;
                    }
                }

                MessageBox.Show("Date: " + highest_temp_item.SubItems[0].Text + "\nCity: " +
                        highest_temp_item.SubItems[1].Text + "\nState: " +
                        highest_temp_item.SubItems[2].Text + "\nTemperature: " +
                        highest_temp_item.SubItems[3].Text);
            }
        }

        private void btn_lowest_temp_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will find and show the record with the lowest temperature.
            if (listView_output.Items.Count != 0)
            {
                decimal lowest_temp = 130;
                ListViewItem lowest_temp_item = new ListViewItem();
                foreach (ListViewItem item in listView_output.Items)
                {
                    decimal temp = Convert.ToDecimal(item.SubItems[3].Text.Split("°")[0]);
                    if (temp < lowest_temp)
                    {
                        lowest_temp = temp;
                        lowest_temp_item = item;
                    }
                }

                MessageBox.Show("Date: " + lowest_temp_item.SubItems[0].Text + "\nCity: " +
                        lowest_temp_item.SubItems[1].Text + "\nState: " +
                        lowest_temp_item.SubItems[2].Text + "\nTemperature: " +
                        lowest_temp_item.SubItems[3].Text);
            }
        }
    }
}