using System.Xml.XPath;


var temperature = new Temperature();
Console.WriteLine($" Enter a temperature and its unit (C or F):");
string? input = Console.ReadLine();
if(input is null){
    return;
}

string[] subInput = input.Split(' ');

double degree = Convert.ToDouble(subInput[0]);
char unit = Convert.ToChar(subInput[1]);

Console.WriteLine(temperature.TempConvert(unit.ToString(),Convert.ToInt16(degree))); 

class Temperature (){



    public string TempConvert(string unit, int amount){
        if(unit == "F"){
           int result =  (amount - 32) * 5/9;
            return result.ToString() + " C";
        }
        else if(unit == "C"){
            int result = (amount * 9/5) + 32;
            return result.ToString() + " F";

        }
        else{
            return "invalid temperature";
        }
    }
}

