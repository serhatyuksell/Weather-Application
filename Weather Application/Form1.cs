using Guna.UI2.WinForms.Interfaces;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Weather_Application
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        public void islem1()
        {
            if (textbox.Text == "")
            {
                MessageBox.Show("Lütfen þehiri giriniz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Form form = new Form();
                    string htmlCode = "";

                    using (WebClient client = new WebClient())
                    {
                        client.Encoding = Encoding.UTF8;
                        htmlCode = client.DownloadString($"https://api.openweathermap.org/data/2.5/weather?q={textbox.Text}&appid=e1da852ecc5df05d42494b7973419edc&lang=tr");
                    }

                    dynamic stuff = JObject.Parse(htmlCode);
                    dynamic sicaklik = stuff.main.temp;
                    int veriSicaklik = (sicaklik - 273);// Kelvin
                    temp_label.Text = veriSicaklik.ToString() + " °C";
                    temp_label.Location = new Point(form.Size.Width / 2 - temp_label.Size.Width / 2 - 10, 192);
                    dynamic picture = stuff.weather[0].icon;

                    string iconCode = "01d";
                    picturebox.Load($"https://openweathermap.org/img/w/{iconCode}.png");
                    dynamic status = stuff.weather[0].description;
                    weather_case_label.Text = status;
                    weather_case_label.Location = new Point(form.Size.Width / 2 - weather_case_label.Size.Width / 2 - 10, 259);
                    dynamic country = stuff.sys.country;
                    dynamic name = stuff.name;
                    city_label.Text = $"{name}, {country}";
                    city_label.Location = new Point(form.Size.Width / 2 - city_label.Size.Width / 2 - 10, 431);
                    textbox.Text = "";
                }
                catch (System.Net.WebException)
                {
                    MessageBox.Show("Böyle bir lokasyon bulunamadý!");
                }
            }
        }




        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temp_label.Text = "";
            weather_case_label.Text = "";
            city_label.Text = "";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Thread islem = new Thread(() => islem1());
            islem.Start();
        }

        private void picturebox_Click(object sender, EventArgs e)
        {

        }

        private void city_label_Click(object sender, EventArgs e)
        {

        }
    }
}