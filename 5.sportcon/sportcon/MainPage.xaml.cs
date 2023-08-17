namespace sportcon;

using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;


public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();

        List<Activity> Activities = new List<Activity>()
        {
            new Activity { Name="Jogging", Content="4.2km - KALENDERHANE - 1h36m"},
            new Activity { Name="Walking", Content="2.7km - TAHATAKALE - 1h06m"},
            new Activity { Name="Biking", Content="6.33km - SIRKECI - 0h34m"},
            new Activity { Name="LazyWalk", Content="5.5km - EMINONU - 4h35m"},
            new Activity { Name="Running", Content="2.4km - GRANDBAZAAR - 25m"},
            new Activity { Name="Walking", Content="5.0km - FISEKHANE - 2h18m"}
        };
        listActivities.ItemsSource = Activities;

    }

    public class Activity
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }


}