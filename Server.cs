using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Инфа
{

    public partial class Server : Form
    {
        int id = -1;
        TcpClient client;
        TcpListener listner;
        StreamReader sr;
        byte[] buffer;

        public Server()
        {
            InitializeComponent();

        }

        //кнопка выхода из приложения
        private void button2_Click(object sender, EventArgs e)
        {
            listner.Stop();//остановка прослушивания запросов на подключение
            Application.Exit();//выход из приложения
        }

        //кнопка "разлогиниться"
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth auth = new Auth();
            auth.Show();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            buffer = new byte[10000]; //размер буффера
            listner = new TcpListener(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12000)); //задаем локальную конечную точку
            listner.Start(); //ожидание входящих запросов на подключение
            try
            {
                client = listner.AcceptTcpClient();//принятие запроса на подключение
                MessageBox.Show("Подключение установлено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Подключение не установлено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             
        }

        //кнопка принятия запроса на получение данных
        private void button3_Click(object sender, EventArgs e)
        {
            sr = new StreamReader(client.GetStream());//чтение полученных данных
            id += 1;
            string date = sr.ReadToEnd(); //чтение содержимого в буфере
            string[] words = date.Split(new char[] { '/' });//структурирование данных
            int iter = 0;

            //заполнение таблицы
            for (int i = 0; i < words.Count() - 1; i++)
            {

                if (i != 0 && i % 2 != 0)
                {
                    SysInfo[iter, id].Value = words[i];//заполнение по столбцам и строкам
                }
                else
                {
                    iter = Int32.Parse(words[i]);
                }
            }
        }
    }
}
