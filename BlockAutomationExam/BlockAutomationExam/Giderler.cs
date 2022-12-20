﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockAutomationExam
{
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        SqlHelper ahmet = new SqlHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            int para = (int)numericUpDown1.Value;
            DateTime tarih = dateTimePicker1.Value;
            string giderler = "";
            foreach (Control item in groupBox1.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    giderler += "," + item.Text;
                }
            }
            giderler = giderler.Remove(0, 1);

            SqlParameter p1 = new SqlParameter("Gider",giderler);
            SqlParameter p2 = new SqlParameter("Para", para);
            SqlParameter p3 = new SqlParameter("Tarih", tarih);

            ahmet.ExecuteProc("giderlerim",p1,p2,p3);
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            DataTable ali = ahmet.GetTable("select * from Gider_Tablosu");

            foreach (DataRow item in ali.Rows)
            {
                listBox1.Items.Add(item[3]).ToString();
                listBox2.Items.Add(item[1]).ToString();
                listBox3.Items.Add(item[2]).ToString();
            }
        }
    }
}
