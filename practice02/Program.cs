// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int rest = b % a;

if(rest == 0){
Console.WriteLine("Число кратное");
}
else{
    Console.WriteLine("Число не является кратным");
}