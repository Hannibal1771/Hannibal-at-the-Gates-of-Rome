using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net;

namespace Инфа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].SetValues(Environment.UserName);

            ManagementObjectSearcher OS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject queryObj in OS.Get())
            {
                dataGridView1.Rows[0].Cells[1].Value = queryObj["Name"];
            }

            ManagementObjectSearcher Proc = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject queryObj in Proc.Get())
            {
                dataGridView1.Rows[0].Cells[2].Value = queryObj["Name"];
            }

            ManagementObjectSearcher Videokarta = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
            foreach (ManagementObject queryObj in Videokarta.Get())
            {
                dataGridView1.Rows[0].Cells[3].Value = queryObj["Name"];
            }

            ManagementObjectSearcher Oper= new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject queryObj in Oper.Get())
            {
                dataGridView1.Rows[0].Cells[4].Value = Math.Round(System.Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024 / 1024 / 2);
            }

            ManagementObjectSearcher Zdisk = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
            foreach (ManagementObject queryObj in Zdisk.Get())
            {
                dataGridView1.Rows[0].Cells[5].Value = queryObj["Model"];
            }

            
            string Host = System.Net.Dns.GetHostName();
            string IP = System.Net.Dns.GetHostByName(Host).AddressList[0].ToString();
            
            try
            {
                 string pubIP = new System.Net.WebClient().DownloadString("https://api.ipify.org");
                dataGridView1.Rows[0].Cells[8].Value = pubIP;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Подключение к Интернету отсутствует", "Ошибка");
                dataGridView1.Rows[0].Cells[8].Value = "Кабель не подключен";
            }
            dataGridView1.Rows[0].Cells[7].Value = Host;
            
            dataGridView1.Rows[0].Cells[6].Value = IP;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher7 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkLoginProfile");
            foreach (ManagementObject queryObj in searcher7.Get())
            {
                dataGridView2.Rows[0].SetValues (queryObj["Name"]);
            }

            ManagementObjectSearcher searcher8 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkLoginProfile");
            foreach (ManagementObject queryObj in searcher8.Get())
            {
                dataGridView2.Rows[0].Cells[1].Value = queryObj["UserID"];
            }
            ManagementObjectSearcher searcher9 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkLoginProfile");
            foreach (ManagementObject queryObj in searcher9.Get())
            {
                dataGridView2.Rows[0].Cells[2].Value = queryObj["NumberOfLogons"];
            }
        }
    }
}
