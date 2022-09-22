using static System.Console;
WriteLine("Введите 2 числа для cравнения: ");

int a = Convert.ToInt32(ReadLine());
int b = Convert.ToInt32(ReadLine());

if(a>b)
{
    WriteLine(a);
}
if(a<b)
{
    WriteLine(b);
}
else
{
    WriteLine("Числа равны");
}