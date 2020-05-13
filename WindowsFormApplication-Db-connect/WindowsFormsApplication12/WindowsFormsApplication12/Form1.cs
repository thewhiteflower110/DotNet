﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        String con = "Data Source=(localdb)\\Projects;Initial Catalog=mydb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
       
        public Form1()
        {
            InitializeComponent();
        }
        private void displaydata()
        {
            SqlConnection cn = new SqlConnection(con);
            cn.Open();
            String query1 = "Select * from mytable";
            SqlDataAdapter adpt = new SqlDataAdapter(query1,cn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            //SqlCommand cmd = new SqlCommand(query1, cn);
            //cmd.ExecuteNonQuery();
           cn.Close();
        }
        private void cleardata()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //INSERT QUERY
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection cn = new SqlConnection(con);
                cn.Open();
                String query1 = "Insert into mytable values ('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(query1, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("data inserted");
                cleardata();
                displaydata();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UPDATE BUTTON
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection cn = new SqlConnection(con);
                cn.Open();
                String query1 = "Update mytable set Name=@name, State=@state";
                SqlCommand cmd = new SqlCommand(query1, cn);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@state", textBox2.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("data updated");
                cleardata();
                displaydata();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }
    }
}
