int[] array = randomArray(4);
Console.WriteLine($"массив:[{string.Join(",",array)}] -> сумма элементов, стоящих на нечётных позициях = {sumOfOdd(array)}");

int[] randomArray(int size) 
{
    Random R = new Random();
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++) 
    {
        array[i] = R.Next(-10,100);
    }
    return array;
}

int sumOfOdd(int[] array) 
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++) 
    {
        if(i % 2 != 0) 
        {
            sum += array[i];
        }
    }
    return sum;
}

