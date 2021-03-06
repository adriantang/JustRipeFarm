﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JustRipeFarm
{
    public partial class Mainscreen : Form
    {
        public Mainscreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void Mainscreen_Load(object sender, EventArgs e)
        {
            button6.Text = "Shop /" + Environment.NewLine + "Wholesale";

            panel1.Hide();
            panel2.Hide();
            panel3.Show();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();

            panel1.Width = 852;
            panel1.Height = 386;
            panel1.Location = new Point(2, 134);
            panel2.Width = 852;
            panel2.Height = 386;
            panel2.Location = new Point(2, 134);
            panel3.Width = 852;
            panel3.Height = 386;
            panel3.Location = new Point(2, 134);
            panel4.Width = 852;
            panel4.Height = 386;
            panel4.Location = new Point(2, 134);
            panel5.Width = 852;
            panel5.Height = 386;
            panel5.Location = new Point(2, 134);
            panel6.Width = 852;
            panel6.Height = 386;
            panel6.Location = new Point(2, 134);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Show();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Show();
            panel5.Hide();
            panel6.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Show();
            panel6.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DbConnecter dbConn = new DbConnecter();
            dbConn.connect();

            Labourer labr = new Labourer();
            labr.Name = "Adam";
            labr.Age = 30;
            labr.Gender = "male";

            LabourerHandler labHnd = new LabourerHandler();
            int recordCnt = labHnd.addNewLabourer(dbConn.getConn(), labr);
            MessageBox.Show(recordCnt + " record has been inserted !! ");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DbConnecter dbConn = new DbConnecter();
            dbConn.connect();

            Labourer labr = new Labourer();
            labr.Name = textBox2.Text;
            labr.Age = Convert.ToInt32(numericUpDown1.Value);
            labr.Gender = comboBox4.Text;

            LabourerHandler labHnd = new LabourerHandler();
            int recordCnt = labHnd.addNewLabourer(dbConn.getConn(), labr);
            MessageBox.Show(recordCnt + " record has been inserted !! ");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            numericUpDown1.ResetText();
            comboBox4.ResetText();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DbConnecter dbConn = new DbConnecter();
            dbConn.connect();
            dataGridView1.DataSource = dbConn.Load().Tables[0];
            //MySqlConnection connection = new MySqlConnection("server=localhost;user=dbcli;database=demojustripedb;port=3306;password=dbcli123");
            //MySqlConnection connection = dbConn.getConn();
            //MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM demojustripedb.labourer", connection);

            //connection.Open();

            //try
            //{
            //    DataSet ds = new DataSet();
            //    adapter.Fill(ds, "labourer");
            //    dataGridView1.DataSource = ds.Tables["labourer"];
            //    connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }
    }
}
