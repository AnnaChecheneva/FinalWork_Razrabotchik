System.Console.WriteLine("Hello!");

string[] CreateArray(int len)
{
    string[] array = new string[len];
    System.Console.WriteLine("Please, input the elements:");
    for ( int i = 0; i< array.Length; i++)
    {
        System.Console.Write($"{i+1} --> ");
        array[i] = Console.ReadLine(); 
    }
    System.Console.WriteLine();
    return array;
}

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintArray(string[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        System.Console.Write(array[i] + " | ");
        
    }
System.Console.WriteLine();
}

string[] ChangeArThreeEl(string[] array)
{

    string[] ResArray = new string[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
        string[] tempResArray = new string[ResArray.Length + 1];
            for( int j =0; j< ResArray.Length; j++)
                {
                    tempResArray[j] = ResArray[j]; 
                }

        tempResArray[tempResArray.Length-1] = array[i];
        ResArray = tempResArray;
        }
    }
    return ResArray;
}

int len = Prompt("Please, enter how many elements do you want in the array ---> ");
string[] array = CreateArray(len);
System.Console.WriteLine("Current array:");
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
string[] ChangeArray = ChangeArThreeEl(array);
System.Console.WriteLine("Great! Changed array with less than three elements:");
System.Console.WriteLine();
PrintArray(ChangeArray);