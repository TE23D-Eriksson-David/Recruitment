
using SC = System.Console;

string name = ""; 
string Choice;
bool Active = true;
string strRecruit;
int reamovePlace = 0;

//List<string> listNamn = new List<string>();
List<string> listPeople = ["Jacob", "Emelie", "Michael"];
List<string> listrecrutedPeople = ["","",""];


//listPeople.Add($"{name}");
//listPeople.Remove($"{name}");

//int length = listPeople.Count;

//listPeople.RemoveAt(reamovePlace);

/*
string[] arylistPeople = listPeople.ToArray();

Console.WriteLine(names[n]); // #0 = pls 1 

string[] contents = File.ReadAllLines(@"localfile.txt");


*/

String filepath = @"C:\Users\david.eriksson5\Desktop\Programering VS\Recruitment\Recruitment\NamesRecruitment";
string info = File.ReadAllText(filepath);
SC.WriteLine(info);




while(true){

string[] aPeople = listPeople.ToArray();

string[] aRecPeople = listrecrutedPeople.ToArray();

Console.WriteLine($"mdmns{aPeople[^2]}"); 
SC.ReadLine();

SC.WriteLine(@$"
Write the persons number, to select them for hiering 
or to remove them from the recruted.

 Avalible people        Recruted People
  ___       ___          ___       ___   
 |  _|     |_  |        |  _|     |_  |  
 | |         | |        | |         | | 
     {aPeople[^1]}         {aRecPeople[^1]}
        1                      4 
 | |_       _| |        | |_       _| | 
 |___|     |___|        |___|     |___| 
  ___       ___          ___       ___  
 |  _|     |_  |        |  _|     |_  |
 | |         | |        | |         | | 
    {aPeople[^2]}          {aRecPeople[^2]}
        2                       5
 | |_       _| |        | |_       _| |   
 |___|     |___|        |___|     |___|
  ___       ___          ___       ___
 |  _|     |_  |        |  _|     |_  |   
 | |         | |        | |         | |
    {aPeople[^3]}          {aRecPeople[^3]}
        3                       6
 | |_       _| |        | |_       _| |
 |___|     |___|        |___|     |___| 
                     
");


strRecruit = SC.ReadLine().ToLower();
SC.WriteLine(strRecruit);


Active = true;
switch((string)(strRecruit)){

case (string)("1"):
while(Active == true){
SC.WriteLine($"Do you want to move {aPeople[^1]} to the recruted list?");
SC.WriteLine("Write: Yes or No.");
Choice = SC.ReadLine().ToLower();
if (Choice == "yes"){
    Active = false;
    listrecrutedPeople.Add(aPeople[1]);
    listPeople.RemoveAt(1);
    }
    else if(Choice == "no"){Active = false;}
}
break;
case (string)("2"):
SC.WriteLine($"Do you want to move {aPeople[^2]} to the recruted list?");
SC.ReadLine();
break;
case (string)("3"):
SC.WriteLine($"Do you want to move {aPeople[^3]} to the recruted list?");
SC.ReadLine();
break;

case (string)("4"):
SC.WriteLine($"Do you want to move {aRecPeople[^1]} of the recruted list?");
SC.ReadLine();
break;
case (string)("5"):
SC.WriteLine($"Do you want to move {aRecPeople[^2]} of the recruted list?");
SC.ReadLine();
break;
case (string)("6"):
SC.WriteLine($"Do you want to move {aRecPeople[^3]} of the recruted list?");
SC.ReadLine();
break;



}



SC.Clear();
}