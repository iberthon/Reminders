using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace Reminders
{
    public partial class Form1 : Form
    {
        private int showFor;
        private DateTime theDay;

        public Form1()
        {
            InitializeComponent();

            showFor = 14;
            next14DaysToolStripMenuItem.Checked = true;

            theDay = DateTime.Today;

            String[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                Debug.Print("Args: {0}", String.Join(", ", args));
                theDay = DateTime.Parse(args[1]);
            }
            labelDate.Text = String.Format("{0:MMMM dd, yyyy}", theDay);
        }

        public void OnThisDay()
        {
            SQLiteConnection db;

            string dbfile = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\reminders.db3";
            Debug.Print("DB File: {0}", dbfile);

            db = new SQLiteConnection("Data Source=" + dbfile);
            db.Open();
            using (SQLiteCommand cmd = db.CreateCommand())
            {
                cmd.CommandText = String.Format("SELECT * FROM onthisday WHERE mth={0} AND dy={1}", theDay.Month, theDay.Day);
                //Debug.Print("OnThisDay: {0}", cmd.CommandText);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        richTextBox1.Clear();
                        richTextBox1.BackColor = Color.White;
                        richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold | FontStyle.Underline);
                        richTextBox1.SelectedText = "On This Day\n";

                        while (reader.Read())
                        {
                            var y = reader.GetValue(reader.GetOrdinal("yr"));
                            int cat = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("cat")));
                            String name = Convert.ToString(reader.GetValue(reader.GetOrdinal("name")));

                            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                            if (Convert.IsDBNull(y))
                            {
                                richTextBox1.SelectionColor = Color.Tomato;
                                richTextBox1.SelectedText = String.Format("{0}\n", name);
                            }
                            else
                            {
                                richTextBox1.SelectedText = String.Format("{0} ({1})\n", name, Convert.ToInt32(y));
                            }
                        }
                    }
                }
            }
        }

        public void Reminders()
        {
            SQLiteConnection db;

            string dbfile = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\reminders.db3";

            db = new SQLiteConnection("Data Source=" + dbfile);
            db.Open();
            using (SQLiteCommand cmd = db.CreateCommand())
            {
                cmd.CommandText = String.Format("SELECT dt, name, strftime('%Y','{0:yyyy-MM-dd}')||substr(dt,5) AS due, (julianday(strftime('%Y','{1:yyyy-MM-dd}')||substr(dt,5)) - julianday(Date('{2:yyyy-MM-dd}'))) AS diff, strftime('%Y','{3:yyyy-MM-dd}')||substr(dt,5)-dt as age FROM reminders WHERE diff<{4} AND diff>=0 order by due", theDay, theDay, theDay, theDay, showFor);
                //Debug.Print("Reminders: {0}", cmd.CommandText);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DateTime dt = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("dt")));
                            String name = Convert.ToString(reader.GetValue(reader.GetOrdinal("name")));
                            DateTime due = Convert.ToDateTime(reader.GetValue(reader.GetOrdinal("due")));
                            int diff = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("diff")));
                            int age = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("age")));

                            String yrs = (age != 1 ? "years" : "year");
                            String dys = (diff != 1 ? "days" : "day");

                            Color c = Color.Black;
                            if (diff == 0)
                            {
                                c = Color.Green;
                            }
                            else if (diff <= 7)
                            {
                                c = Color.Red;
                            }

                            richTextBox1.SelectionColor = c;
                            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold | FontStyle.Underline);
                            richTextBox1.SelectedText = String.Format("\n{0:MMMM dd, yyyy}\n", due);

                            richTextBox1.SelectionColor = c;
                            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                            richTextBox1.SelectedText = String.Format("{0} ({1} {2}) in {3} {4}.\n", name, age, yrs, diff, dys);
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Text = String.Format("Reminders - {0:MMMM dd, yyyy}", theDay);

            OnThisDay();
            Reminders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void next7DaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFor = 7;
            next7DaysToolStripMenuItem.Checked = true;
            next14DaysToolStripMenuItem.Checked = false;
            next21DaysToolStripMenuItem.Checked = false;
            next28DaysToolStripMenuItem.Checked = false;

            Reminders();
        }

        private void next14DaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFor = 14;
            next7DaysToolStripMenuItem.Checked = false;
            next14DaysToolStripMenuItem.Checked = true;
            next21DaysToolStripMenuItem.Checked = false;
            next28DaysToolStripMenuItem.Checked = false;

            Reminders();
        }

        private void next21DaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFor = 21;
            next7DaysToolStripMenuItem.Checked = false;
            next14DaysToolStripMenuItem.Checked = false;
            next21DaysToolStripMenuItem.Checked = true;
            next28DaysToolStripMenuItem.Checked = false;

            Reminders();
        }

        private void next28DaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFor = 28;
            next7DaysToolStripMenuItem.Checked = false;
            next14DaysToolStripMenuItem.Checked = false;
            next21DaysToolStripMenuItem.Checked = false;
            next28DaysToolStripMenuItem.Checked = true;

            Reminders();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
