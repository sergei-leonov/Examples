// Напишите программу коротрая выводит случайное трехзначное число и удаляет вторую 
// цыфру этого числа 

/*int CutNumber(int num)                            // Cut - резать , метод пишется с большой буквы,  (int num) - аргумент 
{                                                 // 315 -> 3 5 -> 35
    int hundreds = num / 100;                      // hundreds- сотни
    int ones = num % 10;

    return hundreds * 10 + ones;                          // Return возврат значения, выполняется в последнюю очередь после результата " hundreds * 10 + ones"                    
}

int randNumber = new Random().Next(100, 1000);             // Next это метод требующий аргумент (Исходные данные) прописываются числа в  рамках которого он будит генирироваться

int newNumber = CutNumber(randNumber);                      // int таким обрпзом мы выделяем память, вызвали метод CutNumber по его имени (randNunber)- отправили аргумент 
 
 Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

// Нпапишите программу которая принимает на вход некоторое число и проверяет кратно ли 
// это число одновременно (а) и (B)


/*bool isDivisiable(int number, int firstDivider, int secondDivide)
{
    return number % firstDivider == 0 && number % secondDivide == 0;
    //if (number % firstDivider == 0 && number % secondDivide == 0);
        // return true; // истина 
    //else
       // return false; // ложь
}   
Console.Write (" imput a number for checking: ");                                            
int num = Convert.ToInt32 (Console.ReadLine());   
Console.Write (" imput a first Divide: ");                                            
int div1 = Convert.ToInt32 (Console.ReadLine());  
Console.Write (" imput a second Divide: ");                                            
int div2 = Convert.ToInt32 (Console.ReadLine());  

Console.WriteLine(isDivisiable(num, div1, div2));
*/



//Напишите программу которое выводит случайное число из отрезка 10 , 99 и показывает наибольшую цифру числа 

/*int OutputsNumber(int num)                             //65
{                                                
    int hundreds = num / 10;                     
    int ones = num % 10;

if (hundreds > ones)
{
    return hundreds;
}
else
{
    return ones;
}

} 
int randNumber = new Random().Next(10, 100);            
int newNumber = OutputsNumber(randNumber);                     
 
 Console.WriteLine($"New version of {randNumber} is Max nambers {newNumber}");
 */


// Наришите прог принимает 2 числа и проверяет , является ли одно число квадратом другого 

bool isDivisiable( int num1,  int num2)
{
    return (num1*num1==num2 || num2*num2 == num1);
}
Console.Write("Введите первое число: ");                          // 5  6
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isDivisiable(num1, num2));

























/*bool DublNumber(int numone, int numsecond);
{
    return (numone == numsecond * numsecond || numsecond == numone * numone);
}
Console.Write (" введите число первое: ");                                            
int number1 = Convert.ToInt32 (Console.ReadLine());   
Console.Write (" введите число второе: ");                                            
int number1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ($"{DublNumber (numone, numsecond)}");
*/
