
//На основе исходного массива sourceArray формируем результирующий resultArray
(string[] resultArray, int count) CreateResultArray(string[] sourceArray)
{
    if (sourceArray.Length == 0) return (sourceArray, 0);
    string[] resultArray = new string[sourceArray.Length];
    int count = 0;

    foreach (string item in sourceArray)
    {
        if (item.Length <= 3)
        {
            resultArray[count] = item;
            count++;
        }
    }
    return (resultArray, count);
}


//using code:
string[] sourceArray = { "hello", "2", "world", ":-)", "I", "am", "Lord", "Voldemort", "ci2", "psi" };

//Выводим исходный массив
System.Console.WriteLine("> Исходный массив строк: ");
foreach (string item in sourceArray)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine();

//На основе исходного массива sourceArray формируем результирующий resultArray
(string[] resultArray, int count) = CreateResultArray(sourceArray);

//Выводим результирующий массив
System.Console.WriteLine("> Сформированный массив строк: ");
for (int i = 0; i < count; i++)
{
    System.Console.WriteLine(resultArray[i]);
}
