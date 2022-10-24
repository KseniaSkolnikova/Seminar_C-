// Задача 45: 
// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}


int[] NewArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];

    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите массив через пробел: ");
string input = Console.ReadLine();
int[] numArray = GetArrayFromString(input);

int[] newArray = NewArray2 (numArray);

Console.WriteLine(String.Join(", ", newArray));