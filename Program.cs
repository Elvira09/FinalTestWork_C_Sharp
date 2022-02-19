void PrintArray(string[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"\" {array[i]}\"");
		if (i != array.Length - 1)
		{
			Console.Write(", ");
		}
	}
	Console.Write("]");
}

int SearchItems(string[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		string strTemp = array[i];
		if (strTemp.Length <= 3)
		{
			count++;
		}
	}
	return count;
}

void FillArraySelectedItemsAndPrint(string[] array)
{
	string[] newArray = new string [array.Length];
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		string strTemp = array[i];
		int j = SearchItems(array) - 1;
		if (strTemp.Length <= 3)
		{
			newArray[j] = array[i];
			Console.Write($"\"{newArray[j]}\"");
			if (i != array.Length - 1)
			{
				Console.Write(", ");
			}
		}
	}
	Console.Write("]");
}

string[] stringArray = { "hello", "25", "Russia", "-2", "world", ":-", "dog", "1345", "947" };
PrintArray(stringArray);
Console.Write("  ->  ");
FillArraySelectedItemsAndPrint(stringArray);
Console.WriteLine();

