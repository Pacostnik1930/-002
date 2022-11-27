// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

int number = int.Parse(Console.ReadLine());
int rest7 = number % 7;
int rest23 = number % 23;

if( rest7 == 0 && rest23 == 0){
    Console.WriteLine($"Поздравляем,число{number} кратно одновременно 7 и 23");
}
else{
    Console.WriteLine($"Число {number} не являтся кратным 7 и 23");
}