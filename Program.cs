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
