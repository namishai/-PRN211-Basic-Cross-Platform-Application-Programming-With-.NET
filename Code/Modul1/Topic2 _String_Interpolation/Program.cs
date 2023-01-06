var name = "dung";
var salary = 11000.5;
DateTime dob= DateTime.Now;
//C1 : String intrepolation
string result = $"Name: {name, 6}, Salary: {salary, 9:N2}";
Console.WriteLine(result);

//C2: Dung hàm Format() của string
Console.WriteLine(string.Format("Name:{0,8}, Salary: {1,9:N2}",name,salary));

//In ra gia trij cuar dob theo dinh dang dd/MM/yyyy
string strDob = $"Dob: {dob:dd/MM/yyyy}";
Console.WriteLine(strDob);