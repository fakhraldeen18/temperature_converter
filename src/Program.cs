using System.Xml.XPath;

var temperature = new Temperature();

Console.WriteLine(temperature.TempConvert("F",32)); 

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

