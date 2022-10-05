// Вид 1
void Method1()
{
   Console.WriteLine("Автор..."); 
}

Method1();

// Вид 2
void Method2(string msg)
{
   Console.WriteLine(msg); 
}

Method2("Текст сообщения");

Method2(msg: "Текст сообщения"); // именованные аргументы

void Method21(string msg, int count)
{
   int i = 0;
   while (i < count)
   {
        Console.WriteLine(msg); 
        i++;
   }
}

Method21("Текст", 4);

Method21(msg:"Текст", count: 4);
Method21(count: 4, msg:"Текст"); // именованные аргументы могут идти в любом порядке

// Вид 3
int Method3()
{
   return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4
// string Method4(int count, string text)
// {
//    int i = 0;
//    string result = String.Empty;

//    while (i < count)
//    {
//         result = result + text;
//         i++;
//    }
   
//    return result;
// }

string Method4(int count, string text)
{
   string result = String.Empty;

   for (int i = 0; i < count; i++)
   {
        result = result + text;
   }
   
   return result;
}


string res = Method4(10, "asdf");
Console.WriteLine(res);

// вывод таблицы умножения на экран
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}"); // Интерполяция строк
    }

    Console.WriteLine();
}

// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; // в result посимвольно собирается новая строка и делаются замены
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(text, 'с', 'С');
Console.WriteLine(newText);

// Сортировка
// 1. Найти позицию min элеманта в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять, пока есть неотсортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int [] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

void SelectionSortUp(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) // array.Length - 1 потому, что во вложенном цикле j = i + 1 (не пропустить последний элемент)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
           
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSortDown(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) // array.Length - 1 потому, что во вложенном цикле j = i + 1 (не пропустить последний элемент)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
           
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);

SelectionSortUp(arr);
PrintArray(arr);

SelectionSortDown(arr);
PrintArray(arr);
