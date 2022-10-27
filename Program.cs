



// Массив и сумма элеиентов на нечетных индексах


/*

int [] CreateRandomArray(int size, int minValve, int maxValve)
{
    int [] newArray = new int [size];
    for (int i = 0; i< size; i ++)
    {
        newArray [i] = new Random().Next(minValve, maxValve +1);

    }
    return newArray;
}

void ShowArray(int[] array)            
{
    Console.WriteLine($"Получившийся массив ->");

    for ( int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}



int Summa(int[] array)      
{
    int sum = 0;
    for( int i = 1;  i < array.Length; i=i+2)
    { 
        sum = sum + array[i];
    }  
    return sum;
}  


Console.WriteLine("введите длинну массива");
int size  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите минимальное значение массива");
int min  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите макси мальное число массива");
int max  = Convert.ToInt32(Console.ReadLine());

int[] MArray = CreateRandomArray(size, min, max);
ShowArray(MArray);
int result = Summa(MArray);
Console.WriteLine($" сумма элементов массива  стоящих на нечетных позициях {result}  ");


*/

// рандомный массив находящий разницу  макс - мин

/*
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int DifferenceMaxMin(int[] array, int max)
{   
    int max1 = 0;
    int min = max;
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max1)
        {
            max1 = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }

    }
    result = max1 - min;
    return result;
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = RandomArray(a, min, max);
ShowArray(myArray);
int result = DifferenceMaxMin(myArray, max);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива -> {result}");.

*/



// кол во четных чисел в массиве из трехзначных чисел



int[] RandomArray(int size)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(100, 1000);
    }
    return myArray;
}
void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int CountsEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int [] myArray = RandomArray(a);
ShowArray(myArray);
int result = CountsEven(myArray);
Console.WriteLine($"В этом массиве количество четных чисел -> {result}");

//
