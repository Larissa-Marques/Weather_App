using System.Drawing.Text;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_info_Click(object sender, EventArgs e)
        {
            decimal temp = Convert.ToDecimal(textBox_temp.Text);  

            //When this button is clicked,display city, state, temp and date
            // be displayed as a label
            string[] row = { dateTimePicker_input.Value.ToShortDateString(), textBox_city.Text, 
                comboBox_state.Text, temp.ToString("0.00") + "°F" };
            ListViewItem listViewItem = new ListViewItem(row);
            listView_output.Items.Add(listViewItem);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //When this button is clicked, the data (city, state, temp, date) will be erased.
            textBox_city.Text = "";
            comboBox_state.Text = "";
            textBox_temp.Text = "";
            dateTimePicker_input.Value = DateTime.Today;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //When this button is clicked, it will find on the table the data entered by the user
            string search_term = textBox_search.Text;
            ListViewItem matched_item = listView_output.FindItemWithText(search_term);

            if (matched_item != null)
                MessageBox.Show("Date: " + matched_item.SubItems[0].Text + "\nCity: " +
                    matched_item.SubItems[1].Text + "\nState: " +
                    matched_item.SubItems[2].Text + "\nTemperature: " + matched_item.SubItems[3].Text);
            else
                MessageBox.Show("Search not found!");
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

            listView_output.Items.Remove(listView_output.SelectedItems[0]);
           
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            ListViewItem selected_item = listView_output.SelectedItems[0];
            dateTimePicker_input.Text = selected_item.SubItems[0].Text;
            textBox_city.Text = selected_item.SubItems[1].Text;
            comboBox_state.Text = selected_item.SubItems[2].Text;
            textBox_temp.Text = selected_item.SubItems[3].Text;
            listView_output.Items.Remove(selected_item);
        }

        private void btn_remove_all_Click(object sender, EventArgs e)
        {
            listView_output.Items.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            string message = "Do you want to save changes?";
            string caption = "Weather Information";
            DialogResult result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
               this.Close();
            }
        }

        private void btn_highest_temp_Click(object sender, EventArgs e)
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
            lbl__test.Text = highest_temp.ToString();
            MessageBox.Show("Date: " + highest_temp_item.SubItems[0].Text + "\nCity: " +
                    highest_temp_item.SubItems[1].Text + "\nState: " +
                    highest_temp_item.SubItems[2].Text + "\nTemperature: " + 
                    highest_temp_item.SubItems[3].Text);
        }

        private void btn_lowest_temp_Click(object sender, EventArgs e)
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
            lbl__test.Text = lowest_temp.ToString();
            MessageBox.Show("Date: " + lowest_temp_item.SubItems[0].Text + "\nCity: " +
                    lowest_temp_item.SubItems[1].Text + "\nState: " +
                    lowest_temp_item.SubItems[2].Text + "\nTemperature: " +
                    lowest_temp_item.SubItems[3].Text);
        }
    }
}