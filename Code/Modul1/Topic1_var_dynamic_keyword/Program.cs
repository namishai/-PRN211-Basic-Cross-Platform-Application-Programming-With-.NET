//khi dung 'var' khai bao bien cuc bo ==> phai khoi gan gia tri ban dau 
using Topic1_var_dynamic_keyword;

var a = 10;
var b= true;
var c= 3.5;
var d = "Hello";
var e = new Student();

Console.WriteLine("Type of a : " + a.GetType().Name);
Console.WriteLine("Type of b : " + b.GetType().Name);
Console.WriteLine("Type of c : " + c.GetType().Name);
Console.WriteLine("Type of d : " + d.GetType().Name);
Console.WriteLine("Type of e : " + e.GetType().Name);

//Dynamic Keyword
dynamic myVar = false;
Console.WriteLine("Type of myVar : " + myVar.GetType().Name);

myVar = new Student();
Console.WriteLine("Type of myVar : " + myVar.GetType().Name);

myVar = 3.5f;
Console.WriteLine("Type of myVar : " + myVar.GetType().Name);

Console.ReadLine();
