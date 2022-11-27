// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int square1 = number1 * number1;
int square2 = number2 * number2;

if(square1 == number2 || square2 == number1){
    Console.WriteLine("ДА");
}
else{
    Console.WriteLine("НЕТ");
}