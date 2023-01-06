/***
 * Viết 1 CT quản lý sinh viên gồm các thông tin sau:
 * -id :
 * -Name:
 * -Mark:
 * -Gender:
 * 
 * In thông tin sinh viên sau khi nhập thành công
 * theo dinh dạng: Id:xxx, Name:yyy, Gender:zzz, Mark: kkkk
 * 
 * Yêu cầu:
 * - Id kiểm tra tính hợp lệ. Ví dụ: SE123456
 * - Mark đúng định dạng 
 * -> Dữ liệu không hợp lệ thì nhập lại 
 * - Name tự động chuyển đổi thành chuỗi chuẩn. Vd: hoang van binh -> Hoang Van Binh 
 */

using System.Text.RegularExpressions;
using System;
using System.Globalization;

string id;
double mark;
string name;
string gender;

Regex rx = new Regex("^SE[0-9]{6}");
TextInfo tf = new CultureInfo("en-US", false).TextInfo;

Console.WriteLine("-----Input student information-----");

Console.WriteLine("Enter ID: ");
id = Console.ReadLine();

while (!rx.IsMatch(id))
{
    Console.WriteLine("re-Enter ID: ");
    id = Console.ReadLine();
}

Console.WriteLine("Enter Name: ");
name = Console.ReadLine();

Console.WriteLine("Enter Mark:");
while (!Double.TryParse(Console.ReadLine(), out mark))
{
    Console.WriteLine("re-Enter Mark:");
}

Console.WriteLine("Enter Gender: ");
gender = Console.ReadLine();

Console.WriteLine("Name: " + tf.ToTitleCase(name) + ", ID: " + id + ", Gender: " + gender + ", Mark: {0}", mark);
