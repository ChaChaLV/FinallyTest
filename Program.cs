string [] startArray = new string [] {"123", "123456", "yes", "fun", "sunny"};
string []finalArray = new string [startArray.Length];
int count = 0;

void GetResult (string [] startArray, string []finalArray)
{
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i].Length <= 3)
        {
         finalArray[count] = startArray[i];
          count++;
         }
    }
}
