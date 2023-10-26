// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка
//  [-9, 9]. Найдите сумму отрицательных и положительных
//   элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
//  сумма положительных чисел равна 29, сумма отрицательных
//   равна -20.


// CreateArray();

// void CreateArray()
// {
//     int sumPosNum=0;
//     int sumNegNum=0;
    
//     int[] array = new int[12];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9,10);
//         Console.Write(array[i]+ " "); 

//         if(array[i]>0)
//         {
//             sumPosNum= sumPosNum + array[i];
//         }
//         else
//         {
//             sumNegNum = sumNegNum+ array[i];
//         }
//     }
//     System.Console.WriteLine("\nПолож. = "+
//      sumPosNum+ " отриц.= "+ sumNegNum);
// }


// Задача 32: Напишите программу замена элементов
//  массива: положительные элементы замените на
//   соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// CreateArray();

// void CreateArray()
// {
//     int[] array = new int[]{-4, -8, 8, 2, -31};

//     for (int i = 0; i < array.Length; i++)
//     {
//         // array[i] = array[i] *-1;
//         array[i] *= -1;
//         Console.Write(array[i]+ " "); 
//     }
// }


// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// CreateArray();

// void CreateArray()
// {    
//     Console.WriteLine("Введите число");
//     int num = Convert.ToInt32(Console.ReadLine());

//     bool isFind = false;
//     int[] array = new int[12];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,10);
//         Console.Write(array[i]+ " "); 

//         if(array[i]==num)
//         {
//             isFind =true;
             
//         }
//     }

//     if(isFind==true)
//     {
//         Console.Write("Да");      
//     }
//     else
//     {
//         Console.Write("Нет"); 
//     }
// }



// Задача 35: Задайте одномерный массив из 123 случайных 
// чисел. Найдите количество элементов массива, значения 
// которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём 
// решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Сначала делаем маленький массив и проверяем. Если работаем - увеличим массив до 123 

// CreateArray();

// void CreateArray()
// {    
//     int count =0;
//     int[] array = new int[123];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,200);
//         Console.Write(array[i]+ " "); 

//         if(array[i]> 9 && array[i]<100)
//         {
//             count++;
//         }
//     }
//     System.Console.WriteLine("Кол. = "+ count);
// }


// Задача 37: Найдите произведение пар чисел в 
// одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д.
//  Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// CreateArray();

// void CreateArray()
// {    
//     Console.WriteLine("Введите число");
//     int num = Convert.ToInt32(Console.ReadLine());

//     int[] array = new int[num];
//     int[] array2 = new int[array.Length/2+ array.Length%2];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,10);
//         Console.Write(array[i]+ " "); 
//     }
//     System.Console.WriteLine();
//     for (int i = 0; i < array2.Length; i++)
//     {
//         array2[i] = array[i] *  array[array.Length-1-i];

//         if(i== array.Length-1-i)  //для центрального элемента массива не чётного размера
//         {
//             array2[i] = array[i];
//         }
//         System.Console.Write(array2[i]+ " ");
//     }
// }