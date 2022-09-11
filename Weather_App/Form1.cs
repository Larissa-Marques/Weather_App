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

    }
}