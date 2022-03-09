using Calculcator;

Console.WriteLine("Calculator Logic Tester"); // Maybe doubles would have been better than decimals

string str = "2+3";
string str2 = "4";

//var a = new Operation();
//string[] strArr = (a.ConvertToDec(str));
//foreach (String s in strArr)
//{
//    Console.WriteLine(s);
//}
var a = new Addition();
Console.WriteLine(a.Add(str));

var b = new SquarePower();
Console.WriteLine(b.Square(str2));

var c = new SquareRoot();
Console.WriteLine(c.Root(str2));
