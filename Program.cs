string[] arr1 = new string[5] {"Vlad", "Hi", "1234654673", "124", "Summer"};
string[] arr2 = new string[arr1.Length];
void ArrayWithIf(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if(arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}
void PrintArr(string[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{arr[i]} ");
    }
    Console.WriteLine();
}
ArrayWithIf(arr1, arr2);
PrintArr(arr2);

