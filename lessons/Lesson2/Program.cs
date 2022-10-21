//int timeout = 200;
//int counter = 0;
//while (counter != 10)
//{
//    Console.Write("\r| " + counter);
//    Thread.Sleep(timeout);
//    Console.Write("\r/ " + counter);
//    Thread.Sleep(timeout);
//    Console.Write("\r- " + counter);
//    Thread.Sleep(timeout);
//    Console.Write("\r\\ " + counter);
//    Thread.Sleep(timeout);
//    counter++;
//}

//int number = 3;
//while (number <= 20)
//{ 
//    Console.WriteLine(number);
//    number += 3;
//}

//int number = 1;
//while (number <= 20)
//{
//    if (number % 3 == 0)
//    {
//        Console.WriteLine(number);
//    }
//    number++;
//}

//for (int number = 3; number <= 20; number += 3)
//{
//    Console.WriteLine(number);
//}

int sum = 0;
for (int number = 1; number <= 100; number++);
{
    sum = sum + number;
}
Console.WriteLine(sum);
