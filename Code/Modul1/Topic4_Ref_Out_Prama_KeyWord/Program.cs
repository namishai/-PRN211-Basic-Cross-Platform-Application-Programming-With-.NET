// su dung ref, out, params key word trong khai bao tham so cua ham 
static void myMethod(int x, ref int y, out int z)
{
    x = 10; y = 11; z = 12;
}

static void SumArray(out int sum, params int[] arr)
{
    sum = 0;
    foreach (int i in arr)
    {
        sum += i;
    }
}

//goi trong ham Main 
int a = 1;
int b = 2;
int c = 3;

myMethod(a, ref b, out c);

//in cac gia tri cua a, b, c
Console.WriteLine($"a ={a}, b={b}, c = {c}");

//c1: truyen vafo doi so cho params
int[] arr = { 1, 2, 3, 4, 5};
int result1;
SumArray(out result1, arr);
Console.WriteLine($"Sum 1 = {result1}");
