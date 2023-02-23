HappyNewYear(2023, "Sancho");
Console.WriteLine(Sum(100, 50));
Console.WriteLine(CheckParity(10));
int myNumber = 10;
ChangeNumber(ref myNumber);
Console.WriteLine(myNumber);
var myArray = new int[] {1,2,3,4,5 };
ChangeArray(myArray);
foreach (var item in myArray)
{
    Console.Write(item + " ");
}
Console.ReadKey(true);

void HappyNewYear(int year, string name)
{
    Console.WriteLine($"{name}, С новым{year} годом!");
}
int Sum (int a, int b)
{
    while (a!=0 && b != 0)
    {
        if (a > b) { a = a % b; }
        else { b = b % a; }
    }
    return a + b;
}
bool CheckParity(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
     return false;
}
void ChangeNumber(ref int number)
{
    number += 100;
}
void ChangeArray(int[] array)
{
    array[0] += 100;
}