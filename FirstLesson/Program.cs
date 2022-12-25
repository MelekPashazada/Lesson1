
//c# output
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

//Console.WriteLine("Hello, World!");

//Console.WriteLine(3 + 3); //toplama

//multiline comment
/*
 * 
 * 
*/

//Comments


float y = 3.14f;
double z = 3.14;
char ch = 'M';
string str= "1";
//int bir = 1;
bool bl = true;
bool bl1 = false;




//int 4 byte
//float 4 byte
//long 8 byte
//double
//char
//string
//bool

//constants
const double pi = 3.14;

//display variables

int x = -5;
int u = 33;
int m = 55;
long l = 4;

//Console.WriteLine(x+u);

//multiple variables

string name = "Melek";
string surname = "Pasazade";

//Baki Azerbaycanin paxtaxtidir
string seher = "Baki";
string olke = "Azerbaycan";
//Console.WriteLine(seher+" "+olke,"in paxtaxtidir");


//Meleyin yasi 23-dur
string ad = "Melek";
int age =23;
//Console.WriteLine(name);

//type casting
double db = 1;
double db1 = 3.1;

//int i= 1;

//double db2 = i;

//Console.WriteLine("i deyiseninin deyeri=" + i + "\n" +
//    "db2 deyiseninin deyer=" + db2);
//Implicit Casting
//int myInt = 9;
//double myDouble = myInt;       // Automatic casting: int to double

//Console.WriteLine(myInt);      // Outputs 9
//Console.WriteLine(myDouble);   // Outputs 9

//double d = 2.7;
//int i = (int) d;

//Console.WriteLine("d deyisenin deyeri=" + d + "\n" +
//    "i deyiseninin deyeri="+ i );

//Explicit Casting
//double myDouble = 9.78;
//int myInt = (int)myDouble;    // Manual casting: double to int

//Console.WriteLine(myDouble);   // Outputs 9.78
//Console.WriteLine(myInt);      // Outputs 9


//Type Conversion Methods

int i = 1;
double d = 1.1;
string str1 = "1";


int.Parse(str);

Console.WriteLine( Convert.ToString(i));
Console.WriteLine( Convert.ToInt32(d));

string truefalse = "false";
string falsetrue = "true";
//bool bl12 = false;

Console.WriteLine(Convert.ToBoolean(truefalse));


