using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using static weathercon.MainPage;

namespace weathercon;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        List<Weather> WeatherList = new List<Weather>()
        {
            new Weather { Image = "cloudy2.png",Degree="19", Time="7PM"},
            new Weather { Image = "cloudy2.png",Degree="19", Time="7.30PM"},
            new Weather { Image = "cloudy1.png", Degree="18", Time="8PM"},
            new Weather { Image = "cloudy1.png", Degree="18", Time="8.30PM"},
            new Weather { Image = "cloudy1.png", Degree="18", Time="9PM"},
            new Weather { Image = "cloudy1.png", Degree="17", Time="9.30PM"},
            new Weather { Image = "cloudy1.png", Degree="15", Time="10PM"},
            new Weather { Image = "cloudy1.png", Degree="15", Time="10.30PM"},
            new Weather { Image = "cloudy1.png", Degree="15", Time="11PM"},
            new Weather { Image = "cloudy1.png", Degree="13", Time="11.30PM"},
            new Weather { Image = "cloudy1.png", Degree="13", Time="12PM"},
            new Weather { Image = "cloudy1.png", Degree="13", Time="0.30AM"},
            new Weather { Image = "cloudy1.png", Degree="11", Time="1AM"},
            new Weather { Image = "cloudy1.png", Degree="11", Time="1.30AM"},
            new Weather { Image = "cloudy1.png", Degree="11", Time="2AM"},
            new Weather {Image = "cloudy1.png",  Degree="12", Time="2.30AM"},
            new Weather { Image = "cloudy1.png", Degree="10", Time="3AM"},
            new Weather { Image = "cloudy1.png", Degree="10", Time="3.30AM"},
            new Weather { Image = "sun.png", Degree="10", Time="4AM"},
            new Weather { Image = "sun.png", Degree="10", Time="4.30AM"},
            new Weather { Image = "sun.png", Degree="14", Time="5AM"},
            new Weather { Image = "sun.png", Degree="15", Time="5.30AM"},
            new Weather { Image = "sun.png", Degree="16", Time="6AM"},
            new Weather { Image = "sun.png", Degree="17", Time="6.30AM"},
            new Weather { Image = "sun.png", Degree="17", Time="7AM"},
            new Weather { Image = "sun.png", Degree="17", Time="7.30AM"},

        };
        CvWeather.ItemsSource = WeatherList;

    }

    public class Weather
    {
        public string Degree { get; set; }
        public string Time { get; set; }
        public string Image { get; set; }

    }
}