using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net.Http;
// using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Security.Policy;

namespace Expense_Tracker
{
    public partial class CryptoForm : UserControl
    {
        public CryptoForm()
        {
            InitializeComponent();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void box1_name_Click(object sender, EventArgs e)
        {

        }

        List<string> urls = new List<string>();

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            // string url = "https://www.coindesk.com/data/";
            //string webpage_url = "https://www.coindesk.com/";
            string url = "https://coinranking.com/";
            string webpage_url = "https://coinranking.com";

            var httpclient = new HttpClient();
            var html = httpclient.GetStringAsync(url).Result;

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            try
            {
                // Get Urls
                // var urlElements = htmlDocument.DocumentNode.SelectNodes("//a[@class='price-liststyles__ListCardWrapper-sc-ouhin1-2 hYRdsb negative']");
                var urlElements = htmlDocument.DocumentNode.SelectNodes("//a[@class='profile__link']");

                if (urlElements != null)
                {
                    // List<string> urls = new List<string>();
                    foreach (var element in urlElements)
                    {
                        var url_1 = webpage_url + element.GetAttributeValue("href", "");
                        urls.Add(url_1);
                    }
                }
                else
                {
                    Console.WriteLine("No urls found.");
                    urls = null;
                }


                // Get Changes in Prices
                // var changeElements = htmlDocument.DocumentNode.SelectNodes("//div[@class='percentage']");
                // var changeElements = htmlDocument.DocumentNode.SelectNodes("//h5[@class='Noto_Sans_Mono_sm_Mono-400-sm text-color-red']");
                var changeElements = htmlDocument.DocumentNode.SelectNodes("//div[@class='change change--light change--positive']");
                
                if (changeElements != null)
                {
                    List<string> changes = new List<string>();
                    foreach (var element in changeElements)
                    {
                        var change = element.InnerText.Trim();
                        changes.Add(change);
                    }
                    box1_change.Text = changes[0];
                    box2_change.Text = changes[1];
                    box3_change.Text = changes[2];
                    box4_change.Text = changes[3];
                    box5_change.Text = changes[4];
                    box6_change.Text = changes[5];
                    box7_change.Text = changes[6];
                }

                // Get Names
                // var nameElements = htmlDocument.DocumentNode.SelectNodes("//div[@class='price-liststyles__AssetColumn-sc-ouhin1-5 ggjoH left']");
                var nameElements = htmlDocument.DocumentNode.SelectNodes("//span[@class='profile__name']");

                if (nameElements != null)
                {
                    List<string> names = new List<string>();
                    foreach (var element in nameElements)
                    {
                        var name = element.InnerText.Trim();
                        name = name.Replace("  ", " ");
                        name = name.Replace("  ", " ");
                        name = name.Replace("  ", " ");
                        name = name.Replace("\n", "");
                        names.Add(name);
                    }
                    box1_name.Text = names[0];
                    box2_name.Text = names[1];
                    box3_name.Text = names[2];
                    box4_name.Text = names[3];
                    box5_name.Text = names[4];
                    box6_name.Text = names[5];
                    box7_name.Text = names[6];
                }

                // Get Price 
                // var pricesElements = htmlDocument.DocumentNode.SelectNodes("//span[@class='typography__StyledTypography-sc-owin6q-0 lnOdBs']");
                //var pricesElements = htmlDocument.DocumentNode.SelectNodes("//h5[@class='Noto_Sans_Mono_sm_Mono-400-sm text-color-black']");
                var pricesElements = htmlDocument.DocumentNode.SelectNodes("//td[contains(@class, 'table__cell table__cell--2-of-8 table__cell--responsive')]/div[contains(@class, 'valuta valuta--light')]");

                if (pricesElements != null)
                {
                    List<string> prices = new List<string>();
                    foreach (var element in pricesElements)
                    {
                        var price = element.InnerText.Trim();
                        price = price.Replace(" ", "");
                        price = price.Replace("\n", "");
                        prices.Add(price);
                    }
                    box1_price.Text = prices[0];
                    box2_price.Text = prices[1];
                    box3_price.Text = prices[2];
                    box4_price.Text = prices[3];
                    box5_price.Text = prices[4];
                    box6_price.Text = prices[5];
                    box7_price.Text = prices[6];
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void box1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void box3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void box2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void box4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void box6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void box5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void box7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CryptoForm_Load(object sender, EventArgs e)
        {

        }

        private void box1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(urls[0]);
            }
            catch
            {
                string url = "https://www.coindesk.com/data/";
                Process.Start(url);
            }   
        }

        private void box2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(urls[1]);
            }
            catch
            {
                string url = "https://www.coindesk.com/data/";
                Process.Start(url);
            }
        }

        private void box3_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(urls[2]);
            }
            catch
            {
                string url = "https://www.coindesk.com/data/";
                Process.Start(url);
            }
        }

        private void box4_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(urls[3]);
            }
            catch
            {
                string url = "https://www.coindesk.com/data/";
                Process.Start(url);
            }
        }

        private void box5_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(urls[4]);
            }
            catch
            {
                string url = "https://www.coindesk.com/data/";
                Process.Start(url);
            }
        }

        private void box6_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(urls[5]);
            }
            catch
            {
                string url = "https://www.coindesk.com/data/";
                Process.Start(url);
            }
        }

        private void box7_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(urls[6]);
            }
            catch
            {
                string url = "https://www.coindesk.com/data/";
                Process.Start(url);
            }
        }
    }
}
