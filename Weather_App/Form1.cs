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
            //When this button is clicked,display city, state, temp and date
            // be displayed as a label
            string[] row = { dateTimePicker_input.Value.ToString(), textBox_city.Text, comboBox_state.Text, textBox_temp.Text };
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
            MessageBox.Show(matched_item.Text);
        }
    }
}