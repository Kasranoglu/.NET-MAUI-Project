using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace filecon;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();

        CodeTerminal.Text = @"cd ""/Users/ahmetalikasranoglu/Desktop/Algorithms/"" && g++ Assignment1.cpp -o Assignment1 && ""/Users/ahmetalikasranoglu/Desktop/Algorithms/""Assignment1
ahmetalikasranoglu@Ahmet-MacBook-Pro aa % cd ""/Users/ahmetalikasranoglu/Desktop/Algorithms/"" && g++ Assignment1.cpp -o Assignment1 && ""/Users/ahmetalikasranoglu/Desktop/Algorithms
/""Assignment1
GGGGGGGGGGGGGGBefore Sorting
99999, 9999, 1000101, 1472, 1460, 1079, 8395, 4653, 9136, 8252, 
Before Sorting
99999, 9999, 1000101, 1472, 1460, 1079, 8395, 4653, 9136, 8252, 
After Sorting
1079, 1460, 1472, 4653, 8252, 8395, 9136, 9999, 99999, 1000101, %                                                                                                                  
ahmetalikasranoglu@Ahmet-MacBook-Pro Algorithms % ";

        CodeEditor.Text = @"#include <iostream>
#include <fstream>
using namespace std;


void CountingSort(int input[], int s, int r)
{

    int outputArray[s];
    int countArray[r];

    for (int i = 0; i < r; i++)
    {
        countArray[i] = 0;
    }

    for (int i = 0; i < s; i++)
    {
        ++countArray[input[i]];
    }
    for (int i = 1; i < r; i++)
    {
        countArray[i] = countArray[i] + countArray[i - 1];
    }
    for (int i = 0; i < s; i++)
    {
        outputArray[--countArray[input[i]]] = input[i];
    }
    for (int i = 0; i < s; i++)
    {
        input[i] = outputArray[i];
    }
}

int main()
{
    const int size = 10;
    int range = 0;
    int myarray[10];

    ofstream dosya;

    

    

    ifstream myfile;
    myfile.open(""input.txt"");
    if (myfile.is_open())
    {
        cout<<""GGGGGGGGGGGGGG"";
        for (int i = 0; i < size; i++)
        {
            myfile >> myarray[i];
        }
        myfile.close();
    }

    else
    { cout << ""nah"";
    }
    
    cout << ""Before Sorting\n"";
    for (int i = 0; i < size; i++)
    {
        cout << myarray[i] << "", "";
    }
    cout << ""\n"";
    int max_num = 0;
    for (int i = 0; i < size; i++)
    {
        if (myarray[i] > max_num)
        {
            max_num = myarray[i];
        }
    }
    range = max_num + 1;

    /* cout << ""Enter size of array \n:"";
     cin >> size;
     int myarray[size];

     cout << ""Enter range of array \n:"";
     cin >> range;

     cout << ""Enter "" << size << "" integers in any order in range of 0-"" <<range-1<< ""\n"";
     for (int i = 0; i < size; i++)
     {
         cin >> myarray[i];
     }
 */
    cout << ""Before Sorting\n"";
    for (int i = 0; i < size; i++)
    {
        cout << myarray[i] << "", "";
    }
    cout << ""\n"";

    CountingSort(myarray, size, range);

    cout << ""After Sorting\n"";
    for (int i = 0; i < size; i++)
    {
        cout << myarray[i] << "", "";
    }

    

    return 0;
}
";

        List<Row> Rows = new List<Row>()
        {
             new Row { Type = "Method ", Name = "CountingSort", Signature = "void CountingSort(int input[]" },
             new Row { Type = "Method ", Name = "Main", Signature = "void main()" },
             new Row { Type = "Variable ", Name = "Name", Signature = "public string Name { get; set; }" },
             new Row { Type = "Variable ", Name = "Age", Signature = "public int Age { get; set; }" }, };

        listRows.ItemsSource = Rows;

    }

    public class Row
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Signature { get; set; }
    }


}


