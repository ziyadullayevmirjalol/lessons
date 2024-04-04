using FileProject;

string path = "C:\\Users\\trash\\source\\repos\\lessons\\FileProject\\MOCK_DATA.txt";
StreamReader streamreader = new StreamReader(path);

var data = streamreader.ReadToEnd();
string[] lines = data.Split('\n');

List<string> males = new List<string>();
List<string> females = new List<string>();
List<string> Others = new List<string>();

int userscount = 0;
int malescount = 0;
int femalescount = 0;
int otherscount = 0;

foreach (string line in lines)
{
    if (string.IsNullOrEmpty(line))
        continue;

    string[] values = line.Split(",");

    string id = values[0];
    string firstName = values[1];

    string lastName = values[2];
    string email = values[3];
    string gender = values[4];

    if (gender == "Female")
    {
        femalescount++; 
        females.Add(line);
    }    
    else if (gender == "Male")
    {
        malescount++; 
        males.Add(line);
    }
    else {
        otherscount++;
        Others.Add(line);
    }

    userscount++;
}

Gn.Males(males);
Console.WriteLine("\n\n\n");
Gn.Feales(females);
Console.WriteLine("\n\n\n");
Gn.Others(Others);
Console.WriteLine("\n\n\n");

double malesPercentage = (double)malescount / userscount * 100;
Console.WriteLine($"Males: {malesPercentage:F2}%");
double femalesPercentage = (double)femalescount / userscount * 100;
Console.WriteLine($"Females: {femalesPercentage:F2}%");
double othersPercentage = (double)otherscount / userscount * 100;
Console.WriteLine($"Others: {othersPercentage:F2}%");

