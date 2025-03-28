using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Types;
using System.Collections;




namespace Calendar
{
    public partial class UserControlDays : UserControl
    {

        public static string s_days;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbdays.Text = numday + " ";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            s_days = lbdays.Text;
            timer1.Start();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        //new method to display event
        private void displayEvent()
        {
            
            //MySqlConnection conn = new MySqlConnection();
            //conn.Open();
            //String sql = "SELECT * FROM tbl_Calendar where Date = ?";
            //MySqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = sql;
            //cmd.Parameters.AddWithValue("Date", Form1.s_month + "-" + lbdays.Text + "-" + Form1.s_year);
            //MySqlDataReader reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    lbevent.Text = reader["Event"].ToString();
            //}
            //reader.Dispose();
            //cmd.Dispose();
            //conn.Close();

        }

        private void lbevent_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}


