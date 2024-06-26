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
            picturebox.SizeMode = PictureBoxSizeMode.StretchImage;

            if (textbox.Text == "")
            {
                MessageBox.Show("L?tfen ?ehiri giriniz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    temp_label.Text = veriSicaklik.ToString() + " �C";
                    temp_label.Location = new Point(form.Size.Width / 2 - temp_label.Size.Width / 2 - 10, 192);
                    dynamic picture = stuff.weather[0].icon;

                    dynamic status;
                    status = stuff.weather[0].description;
                    if (status == "a��k")
                    {
                        string iconCode = "01d";
                        picturebox.BackColor=Color.LightSkyBlue;
                        picturebox.Load($"https://openweathermap.org/img/w/{iconCode}.png");
                        weather_case_label.Text = status;
                        weather_case_label.Location = new Point(form.Size.Width / 2 - weather_case_label.Size.Width / 2 - 10, 259);
                    }
                    else if (status.ToString().Contains("bulut")) 
                    {
                        string iconCode = "02d";
                        picturebox.BackColor = Color.LightSkyBlue;
                        picturebox.Load($"https://openweathermap.org/img/w/{iconCode}.png");
                        weather_case_label.Text = status;
                        weather_case_label.Location = new Point(form.Size.Width / 2 - weather_case_label.Size.Width / 2 - 10, 259);
                    }
                    else if (status.ToString().Contains("kapal�"))
                    {
                        string iconCode = "04d";
                        picturebox.BackColor = Color.LightSkyBlue;
                        picturebox.Load($"https://openweathermap.org/img/w/{iconCode}.png");
                        weather_case_label.Text = status;
                        weather_case_label.Location = new Point(form.Size.Width / 2 - weather_case_label.Size.Width / 2 - 10, 259);
                    }

                    else if (status.ToString().Contains("ya�mur"))
                    {
                        string iconCode = "09d";
                        picturebox.BackColor = Color.LightSkyBlue;
                        picturebox.Load($"https://openweathermap.org/img/w/{iconCode}.png");
                        weather_case_label.Text = status;
                        weather_case_label.Location = new Point(form.Size.Width / 2 - weather_case_label.Size.Width / 2 - 10, 259);
                    }
                    
                    else if (status == "dolu")
                    {
                        string iconCode = "10d"; // Alternatif bir kod kullan�labilir
                        picturebox.BackColor = Color.LightSkyBlue;
                        picturebox.Load($"https://openweathermap.org/img/w/{iconCode}.png");
                        weather_case_label.Text = status;
                        weather_case_label.Location = new Point(form.Size.Width / 2 - weather_case_label.Size.Width / 2 - 10, 259);
                    }
                    
                    else if (status.ToString().Contains("f�rt�na"))
                    {
                        string iconCode = "11d";
                        picturebox.BackColor = Color.LightSkyBlue;
                        picturebox.Load($"https://openweathermap.org/img/w/{iconCode}.png");
                        weather_case_label.Text = status;
                        weather_case_label.Location = new Point(form.Size.Width / 2 - weather_case_label.Size.Width / 2 - 10, 259);
                    }
                   
                    else if (status.ToString().Contains("ya���"))
                    {
                        string iconCode = "09d"; // Alternatif bir kod kullan�labilir
                        picturebox.BackColor = Color.LightSkyBlue;
                        picturebox.Load($"https://openweathermap.org/img/w/{iconCode}.png");
                        weather_case_label.Text = status;
                        weather_case_label.Location = new Point(form.Size.Width / 2 - weather_case_label.Size.Width / 2 - 10, 259);
                    }
                    else if (status.ToString().Contains("kar"))
                    {
                        string iconCode = "13d"; // Alternatif bir kod kullan�labilir
                        picturebox.BackColor = Color.LightSkyBlue;
                        picturebox.Load($"https://openweathermap.org/img/w/{iconCode}.png");
                        weather_case_label.Text = status;
                        weather_case_label.Location = new Point(form.Size.Width / 2 - weather_case_label.Size.Width / 2 - 10, 259);
                    }
                    
                    dynamic country = stuff.sys.country;
                    dynamic name = stuff.name;
                    city_label.Text = $"{name}, {country}";
                    city_label.Location = new Point(form.Size.Width / 2 - city_label.Size.Width / 2 - 10, 431);
                    textbox.Text = "";
                }
                catch (System.Net.WebException)
                {
                    MessageBox.Show("B�yle bir lokasyon bulunamad�!");
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