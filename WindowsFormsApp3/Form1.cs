using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baseAddress = "http://localhost:58063/api/";
            try
            {
                //  Execute(baseAddress).Wait();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);
                    var response = client.GetAsync($"Square?a={textBox1.Text}").Result.Content.ReadAsStringAsync();
                    
                    MessageBox.Show(response.Result, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Execute method
        /// </summary>
        /// <param name="baseAddress"></param>
        /// <returns></returns>
        async Task Execute(string baseAddress)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                var response = client.GetAsync($"Square?a=100").Result.Content.ReadAsStringAsync();
                MessageBox.Show(response.Result, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
