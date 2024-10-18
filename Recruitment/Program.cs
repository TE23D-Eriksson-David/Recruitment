
using SC = System.Console;



bool run = true;
//string name = "";
string Choice;
bool Active = true;
string strRecruit;
//int reamovePlace = 0;
int intname = 0;


List<string> listPeople = ["Jacob", "Emelie", "Michael"];
List<string> listrecrutedPeople = ["Emphty", "Emphty", "Emphty"];

string[] arylistPeople = listPeople.ToArray();



String filepath = @"C:\Users\david.eriksson5\Desktop\Programering VS\Recruitment\Recruitment\NamesRecruitment";
string info = File.ReadAllText(filepath);
SC.WriteLine(info);
SC.ReadLine();


while (run == true)
{

    string[] aPeople = listPeople.ToArray();

    string[] aRecPeople = listrecrutedPeople.ToArray();


SC.WriteLine(@$"Write the persons number, to select them for hiering 
or to remove them from the recruted.

 Avalible people        Recruted People
  ___       ___          ___       ___   
 |  _|     |_  |        |  _|     |_  |  
 | |         | |        | |         | | 
     {aPeople[0]}                 {aRecPeople[^1]}
        1                      4 
 | |_       _| |        | |_       _| | 
 |___|     |___|        |___|     |___| 
  ___       ___          ___       ___  
 |  _|     |_  |        |  _|     |_  |
 | |         | |        | |         | | 
      {aPeople[1]}                 {aRecPeople[^2]}
        2                      5
 | |_       _| |        | |_       _| |   
 |___|     |___|        |___|     |___|
  ___       ___          ___       ___
 |  _|     |_  |        |  _|     |_  |   
 | |         | |        | |         | |
      {aPeople[2]}                  {aRecPeople[^3]}
        3                      6
 | |_       _| |        | |_       _| |
 |___|     |___|        |___|     |___| 
                     
");


    strRecruit = SC.ReadLine().ToLower();
    intname = int.Parse(strRecruit);


    Active = true;

    if (intname != 0 && intname < 6) //&& aPeople[intname] != "Emphty" && aRecPeople[intname] != "Emphty"
    { 
        intname--; 

        while (Active == true)
        {
            if (intname <= 2 && aPeople[intname] != "Emphty"){
            SC.WriteLine($"Do you want to move {aPeople[intname]} to the recruted list?");
            SC.WriteLine("Write: Yes or No.");
            } if (intname >= 3 && aRecPeople[intname] != "Emphty"){
                intname=-4;
            SC.WriteLine($"Do you want to move {aRecPeople[intname]} to the recruted list?");
            SC.WriteLine("Write: Yes or No.");
                intname=+4;    
            }

            Choice = SC.ReadLine().ToLower();
            if (Choice == "yes")
            {
                if (intname <= 2){
                Active = false;
                listrecrutedPeople.Add(aPeople[intname]);
                listPeople.Add(aRecPeople[intname]);
                listPeople.RemoveAt(intname);
                } else {
                Active = false;
                intname=-4;
                listPeople.Add(aRecPeople[intname]);
                listrecrutedPeople.Add(aPeople[intname]);
                listrecrutedPeople.RemoveAt(intname);    
                }
            }
            else if (Choice == "no") { Active = false; }
        }

        
    }
    SC.Clear();
}



/*
//List<string> listNamn = new List<string>();
//listPeople.Add($"{name}");
//listPeople.Remove($"{name}");

//int length = listPeople.Count;

//listPeople.RemoveAt(reamovePlace);

//string[] contents = File.ReadAllLines(@"localfile.txt");

//Console.WriteLine($"mdmns{aPeople[1]}"); 
*/





/*
int s = Random.Shared.Next(5);

List<string> names;
List<string> name = [];
List<string> nam = ["micke","martin","Lena"];

/*Console.WriteLine(nam[^1]);
string ost = SC.ReadLine();
if (ost == nam[1]){
    SC.WriteLine("");
}

nam[1] = "Nicholas";
nam.Add("Jacob");


// for (int i = 0; i < nam.Count; i++)
// {
//     SC.WriteLine(nam[i]);
// }

//SC.WriteLine(string.Join("\n", nam));

nam.Remove(nam[1]); // index
nam.RemoveAt(0); // värde
SC.ReadLine();
*/