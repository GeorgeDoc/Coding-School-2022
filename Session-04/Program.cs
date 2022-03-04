using Session_04;

//1.
string myName = "George Aivaliotis";
Console.WriteLine(myName);
var text = new Class1();

string reversed1 = text.ReverseString(myName); //itteration
Console.WriteLine(reversed1);

//string reversed2 = text.ReverseString2(myName);//index out of bounds
//Console.WriteLine(reversed2);

string reversed3 = text.ReverseLib(myName); //library function
Console.WriteLine(reversed3);


//2. 
int n = 0;
Console.WriteLine("\nEnter an integer n: ");
n = Convert.ToInt32(Console.ReadLine());
var something = new Class2();

//Console.WriteLine("Do you want to calculate the sum (press 1), or the product of 1,...,n? press (2)");
//int selection = 0;
//if (selection == 1)// na mpei sto class
//{
//    int sum = something.GetSum(n);
//    Console.WriteLine("The sum up to n is: " + sum);
//} else if (selection == 2)
//{
//    int prod = something.GetProduct(n);
//    Console.WriteLine("The product up to n is: " + prod);
//} else
//{
//    Console.WriteLine("Not a valid option"); //TODO: make a while loop to get the correct selection
//}

int sum = something.GetSum(n);
Console.WriteLine("The sum up to n is: " + sum); //n incuded

int prod = something.GetProduct(n);
Console.WriteLine("The product up to n is: " + prod); // n included


//3. 
var from3 = new Class3();
Console.WriteLine("\nEnter a new integer n to show all the PRIME numbers up to n: "); // n not included
n = Convert.ToInt32(Console.ReadLine()); //TODO: validate n>=0
from3.GetPrimes(n);


//4. 
Console.WriteLine();
int[] Array1 = { 2, 4, 9, 12 };
int[] Array2 = { 1, 3, 7, 10};
var from4 = new Class4();
from4.GetArrayProduct(Array1, Array2);


//5. 
Console.WriteLine();
int[] toSort = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
var from5 = new Class5();
from5.SortArray(toSort);