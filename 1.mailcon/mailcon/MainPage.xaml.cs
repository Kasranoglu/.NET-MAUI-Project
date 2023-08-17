using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace mailcon;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();

        List<Mail> Mails = new List<Mail>()
        {
            new Mail { Name="Ahmet Ali Kasranoglu ahmet.kasranoglu@student.um.si", Content="Hi thats me, do you know when we will go for summer house?"},
            new Mail { Name="Ahmet Suat Bal suat.bal@student.um.si", Content="Hello thats me, did you finish the assinment?"}
        };
        listMails.ItemsSource = Mails;

    }

    public class Mail
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }


}