﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;



namespace Calendar
{
    public partial class EventForm : Form
    {
        //connection string
        String connString = "server=localhost;user id=root; database=db_calendar; sslmode=none";
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txtDate.Text = UserControlDays.s_days + "/" + Form1.s_month + "/" + Form1.s_year;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO tbl_calendar(date, event)values(?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("Date", txtDate.Text);
            cmd.Parameters.AddWithValue("Event", txtEvent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved!");
            cmd.Dispose();
            conn.Close();
        }
    }
}
