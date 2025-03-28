using System.Globalization;

namespace Calendar
{
    public partial class Form1 : Form
    {
        int month, year;
        public static int s_month, s_year;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displays();
            
        }

        private void displays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;
            s_month = month;
            s_year  = year;



            //first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //count of days of the month
            int days = DateTime.DaysInMonth(year, month);

            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

           


            //create a blank usercontrol
            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                daycontainer.Controls.Add(ucblank);

            }

            //create usercontrol for days 
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }


        }
        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            //clear container 
            daycontainer.Controls.Clear();
            s_month = month; 
            s_year = year;

            month++;            
            DateTime startofthemonth = new DateTime(year, month, 1);

            //count of days of the month
            int days = DateTime.DaysInMonth(year, month);

            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;


            //create a blank usercontrol
            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                daycontainer.Controls.Add(ucblank);

            }

            //create usercontrol for days 
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;
        }

        

        private void btnprevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month--;
            s_month = month;
            s_year = year;
            DateTime startofthemonth = new DateTime(year, month, 1);            
            int days = DateTime.DaysInMonth(year, month);            
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;


            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                daycontainer.Controls.Add(ucblank);

            }


            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;
        }
    }
}
