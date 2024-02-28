// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа 
//‘q’ или при вводе числа, сумма цифр которого чётная.
int numb;
int Function (int lost)
    {
        int s = 0;
        while (lost > 0)
        {
            s = s + lost % 10;
            lost = lost / 10;
        }
         return s;
        }
        
while (true)
{
    Console.Write("Введите любое целое число или q чтобы выйти из программы: ");
    string? input = Console.ReadLine();
    bool number = int.TryParse(input, out numb);
    if (input == "q" | Function(numb) % 2 == 0 )
    {
        Console.WriteLine("Выход");
        break;
    }
}
    













