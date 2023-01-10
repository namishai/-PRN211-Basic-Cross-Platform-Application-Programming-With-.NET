//static (int sum, int count) MyMethod(params int[] arr)
//{
//    var a = (sum: 0, count: 0);
//    foreach (var i in arr)
//    {
//        if (CheckEven(i))
//        {
//            a.sum += i;
//            a.count++;
//        }
//    }
//    return a;
//    //local function 
//    bool CheckEven(int number)
//    {
//        if (number % 2 == 0)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}

//var (sum, count) = MyMethod(1, 2, 4, 5, 6, 7, 8, 13, 12);

//Console.WriteLine($"Sum = {sum}, Count = {count}");

//string[] stringArray = { "12", "Hello", "3.14", "20" }; for (int i = 0; i < stringArray.Length; i++) ;
//for (int i = 0; i < stringArray.Length; i++)
//{
//    if (int.TryParse(stringArray[i], out _)) Console.WriteLine($"{stringArray[i]}: valid");
//    else
//        Console.WriteLine($"{stringArray[i]}: invalid");
//}
//Console.ReadLine();


//Console.Write("Input data:"); int.TryParse(Console.ReadLine(), out int n); switch (n)
//{
//    case int count when count > 0: Console.WriteLine(new string('*', count)); break;
//    default:
//        Console.WriteLine("Data invalid."); break;
//}
//Console.ReadLine();



//int[] array1 = null;
//Console.WriteLine($"{array1?.Length.ToString() ?? "Array is empty."}");
//array1 = new int[] { 2, 1, 3 };
//dynamic[] array2 = { array1, null };
//var s = array2?[0]?.Length ?? "Array is empty.";
//Console.WriteLine($"{s}");
//s = array2?[1]?.Length ?? "Array is empty.";
//Console.WriteLine($"{s}");

int? a = null;
if (a is null)
{
    Console.WriteLine("a does not have a value"); 
    a = 2050;
}
if (a is int valueOfA)
{
    Console.WriteLine($"a is {valueOfA}");
}
Console.ReadLine();

