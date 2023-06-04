void Main()
{
    bool isWork = true;
    while (isWork)
    {
        System.Console.Write("Enter command: ");
        string command = System.Console.ReadLine();
        switch (command)
        {
            case "task":
                task();
                break;
            case "exit":
                isWork = false;
                break;
            default:
                System.Console.WriteLine(
                "Warning! Enter only:\n" +
                "task\n" +
                "exit");
                break;
        }
    }
}

void printArray(string[] array, string message = "Print array:")
{
    System.Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

string[] GetNewArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

Main();

void task()
{
    System.Console.WriteLine("start Task");
    string[] array = new string[] { "123", "Denmark", "23", "computer science", "1567", "hello", "world", "res", "-2" };
    printArray(array);
    printArray(GetNewArray(array), "Print new array, elements length <= 3:");
    System.Console.WriteLine("End task");
}
