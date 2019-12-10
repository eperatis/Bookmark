using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restapi3
{
    public partial class Form1 : Form
    {

        String URL = "http://localhost:80/rest/";
        String AUTH = "admin|admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           


        }

        private void button_get_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest("index.php" + "?A=" + AUTH, Method.GET);

            listBox1.Items.Clear();

            IRestResponse<List<Bookmark>> response = client.Execute<List<Bookmark>>(request);
            foreach (Bookmark bk in response.Data)
            {
                listBox1.Items.Add(bk.Id+" "+bk.name+" "+bk.url);
            }
            
            //var content = response.Content;
            //textBox1.Text = content;
        }

        private void button_getid_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String ROUTE = "index.php" + "?A=" + AUTH + "&id=" + textBox2.Text;
            var request = new RestRequest(ROUTE, Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content.Split(',')[2].Split(':')[1].ToString();
            textBox1.Text = content.Substring(1, content.Length - 2);
        }

        private void button_post_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest("index.php" + "?A=" + AUTH, Method.POST);  //index is kellett mögé
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new Bookmark
            {
                name = textBox_name.Text,
                url = textBox_url.Text
            });
            IRestResponse response = client.Execute(request);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String ROUTE = "index.php/{id}";
            var request = new RestRequest(ROUTE + "?A=" + AUTH, Method.DELETE);
            request.AddParameter("id", textBox2.Text);
            IRestResponse response = client.Execute(request);
            
        }

        private void button_put_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String ROUTE = "index.php" + "?A=" + AUTH + "&id=" + textBox2.Text;
            var request = new RestRequest(ROUTE, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new Bookmark
            {
                name = textBox_name.Text,
                url = textBox_url.Text
            });
            IRestResponse response = client.Execute(request);
        }
    }

    public class Bookmark
    {
        public string Id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

}
