using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string url = "http://modlist.mcf.li/api/v3/1.7.10.json";
        System.Net.WebClient client = new System.Net.WebClient();
        string rawjson;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            rawjson = client.DownloadString(url);
            List<mod> mods = JsonConvert.DeserializeObject<List<mod>>(rawjson);
            //modControl1. = mods[0];
            for(int i=0;i<10;i++)
            {
                //listView1.Controls.Add(new UC.ModControl(mods[i]));
            }
        }
    }
}
