string [] startArray = new string [5] {"123", "123456", "yes", "fun", "sunny"};
string []finalArray = new string [startArray.Length];


void GetResult (string [] startArray, string []finalArray)
{
    int count = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i].Length <= 3)
        {
         finalArray[count] = startArray[i];
          count++;
         }
    }
}
void PrintResult (string [] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
}

GetResult (startArray,finalArray);
PrintResult (finalArray);