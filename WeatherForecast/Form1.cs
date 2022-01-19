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
using System.IO;
using Newtonsoft.Json;
using LiveCharts;
using LiveCharts.Wpf;
using System.Globalization;

namespace WeatherForecast
{
    public partial class Form1 : Form
    {
        Responce responce = null;
        public Form1()
        {
            InitializeComponent();
        }
        private static DateTime UnixTimeStampToDateTime(int unixTimeStamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        private void forecastBtn_Click(object sender, EventArgs e)
        {
            if(latitudeTextBox.Text == String.Empty || longitudeTextBox.Text == String.Empty)
            {
                MessageBox.Show("You didn`t enter latitude or longitude values.");
                return;
            }
            double latitude, longitude;
            try
            {
                latitude = Convert.ToDouble(latitudeTextBox.Text, CultureInfo.InvariantCulture);
                longitude = Convert.ToDouble(longitudeTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            try
            {
                HttpWebRequest webRequest = HttpWebRequest.Create($"https://api.openweathermap.org/data/2.5/onecall?lat={latitude}1&lon={longitude}&exclude=current,minutely,daily,alerts&units=metric&lang=ua&appid=e55dcdd08091e114853a428e36ba58bf") as HttpWebRequest;
                webRequest.Method = "GET";
                HttpWebResponse webResponse = webRequest.GetResponse() as HttpWebResponse;
                string json;
                using (StreamReader sr = new StreamReader(webResponse.GetResponseStream()))
                {
                    json = sr.ReadToEnd();
                }
                responce = JsonConvert.DeserializeObject<Responce>(json);
            }
            catch
            {
                MessageBox.Show("Wrong coordinates!");
                return;
            }

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            List<double> values = new List<double>();
            foreach (Hourly hour in responce.hourly)
            {
                values.Add(hour.temp);
            }
            series.Add(new LineSeries() { Title = "Temperature", Values = new ChartValues<double>(values), 
                Stroke = System.Windows.Media.Brushes.Red, Fill = System.Windows.Media.Brushes.LightSalmon });
            cartesianChart1.Series = series;

            cartesianChart2.Series.Clear();
            SeriesCollection newSeries = new SeriesCollection();
            List<int> humidityValues = new List<int>();
            foreach (Hourly hour in responce.hourly)
            {
                humidityValues.Add(hour.humidity);
            }
            newSeries.Add(new LineSeries() { Title = "Humidity", Values = new ChartValues<int>(humidityValues)});
            cartesianChart2.Series = newSeries;
        }
        private void InitializeCharts()
        {
            List<string> labels = new List<string>();
            for (int i = 0; i < responce.hourly.Count; i++)
            {
                labels.Add(UnixTimeStampToDateTime(responce.hourly[i].dt).ToString());
            }
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Time",
                Labels = labels
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Temperature",
                LabelFormatter = value => value.ToString() + "°C"
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Bottom;
            cartesianChart1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            cartesianChart2.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Time",
                Labels = labels
            });
            cartesianChart2.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Humidity",
                LabelFormatter = value => value.ToString() + "%"
            });
            cartesianChart2.LegendLocation = LiveCharts.LegendLocation.Bottom;
            cartesianChart2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HttpWebRequest webRequest = HttpWebRequest.Create($"https://api.openweathermap.org/data/2.5/onecall?lat=0&lon=0&exclude=current,minutely,daily,alerts&units=metric&lang=ua&appid=e55dcdd08091e114853a428e36ba58bf") as HttpWebRequest;
            webRequest.Method = "GET";
            HttpWebResponse webResponse = webRequest.GetResponse() as HttpWebResponse;
            string json;
            using (StreamReader sr = new StreamReader(webResponse.GetResponseStream()))
            {
                json = sr.ReadToEnd();
            }
            responce = JsonConvert.DeserializeObject<Responce>(json);

            InitializeCharts();
        }
    }
}