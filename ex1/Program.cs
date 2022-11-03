//I. Реализовать следующие функции для работы с массивами:


//Печать массива на экран



    void PrintArray(int[] array) 
    {
        for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
    }

// Поиск минимума


    void FillArray(int[] array, int min, int max) 
    {
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min,max);  
    }

    int MinArray(int[] array) 
    {
    int min = array[0];
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]<min)
        min = array[i];
    }
    return min;  
    }


// Поиск максимума


int MaxArray(int[] array) 
{
    int max = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i]>max)
           max = array[i];
return max;  
}

// сумма всех элементов массива


int SumArray(int[] array)   
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        sum = sum + array[i];
return sum;
}

//Поиск произведения элементов массива

int MultArray(int[] array) 
{
    int mult = 1;
    for(int i = 0; i < array.Length; i++)
        mult = mult * array[i];
return mult;
}

// Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
    int ValueArray(int [] array, int number)
    {
    for(int i = 0; i < array.Length; i++)
        if(array[i]==number)
        return i;    
    return - 1;        
    }

// Среднее арифметическое элеметов массива

int MidArray(int[] array)=>SumArray(array) / array.Length;

// Подсчёт количества отрицательных элементов массива

int NegativCount(int[] array)
{
int negativcount = 0;
for(int i = 0; i < array.Length; i++)
    if(array[i]<0)
       negativcount++;
return negativcount;
}

// Подсчёт количества вхождений элемента в массив
int Count(int [] array, int value)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i]==value)
           count++;
return count;
}

// Подсчёт количества чётных элементов в массив
int EvenArray(int[] array)
{
int count2 = 0;
 for(int i = 0; i < array.Length; i++)
    if(array[i]%2==0)
       count2++;
return count2; 
}

// Подсчёт количества положительных элементов в массиве
int PositiveCount(int[] array)
{
int positivecount = 0;
for(int i = 0; i < array.Length; i++)
    if(array[i]>0)
       positivecount++;
return positivecount;
}

// Подсчёт количества нечётных элементов в массиве
int UnevenArray(int[] array)
{
int count3 = 0;
 for(int i = 0; i < array.Length; i++)
    if(array[i]%2==1)
       count3++;
return count3;
}

// Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет.
    bool TrueArray(int [] array, int num)
    {
    for(int i = 0; i < array.Length; i++)
        if(array[i]==num)
        return true;    
    return false;        
    }


// Проверка является ли массив отсортированным по возрастанию. Если массив отсортирован, то возвращать true, иначе - false.
bool SortArray(int [] array)
 {
    for (int i = 0; i < array.Length - 1; i++)
         if (array[i] > array[i + 1]) 
             return false;
    return true;
 }


Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[length];
FillArray(array, -10,15);

Console.Write("Ваш массив: ");
PrintArray(array);

Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"количество вхождений элемента в массив: {Count(array, value)} ");

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"индекс заданного элемента {ValueArray(array, number)} ");

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Наличие числа в массиве:  {TrueArray(array,num)}");


Console.WriteLine($"min {MinArray(array)}");

Console.WriteLine($"max {MaxArray(array)}");  

Console.WriteLine($"сумма всех элементов массива: {SumArray(array)}");

Console.WriteLine($"произведение всех элементов массива: {MultArray(array)}");

Console.WriteLine($"среднее арифметическое: {MidArray(array)} ");

Console.WriteLine($"количество отрицательных элементов: {NegativCount(array)} ");

Console.WriteLine($"количество четных элементов: {EvenArray(array)} ");

Console.WriteLine($"количество положительных элементов: {PositiveCount(array)} ");

Console.WriteLine($"количество нечетных элементов: {UnevenArray(array)} "); 

Console.WriteLine($"Массив отсортирован по возрастанию: {SortArray(array)}"); 