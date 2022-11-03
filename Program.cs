// Алгоритм и методы

// Создать массив из строк
// Заполнить массив случайными символами и цифрами
// Распечатать полученный массив
// Создать новый массив
// Заполнить новый массив символами, не являющиеся цифрами, из первого массива
// Распечатать полученный массив

// 1. Метод создания массива строк
string[] CreateArrayStrings(int size)
{
    return new string[size];
}

// 2. Метод заполнения массива случайными символами
void FillArrayStrings(string[] text, string selectChar, int lengthItemMin, int lengthItemMax)
{
    int size = text.Length;
    int count = selectChar.Length;
    for (int i = 0; i < size; i++)
    {
        int lengthItem = new Random().Next(lengthItemMin, lengthItemMax + 1);
        for (int j = 0; j < lengthItem; j++)
        {
            text[i] += selectChar[new Random().Next(0, count)];
        }
    }
}

// 3. Метод распечатки массива
void PrintArrayStrings(string[] text)
{
    int size = text.Length;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine(text[i]);
    }
}

// 4. Метод удаления цифр из массива строк
string[] DelNumbers(string[] text)
{
    int size = text.Length;
    string[] result = new string[size];
    int lengthItem = 0;
    for (int i = 0; i < size; i++)
    {
        lengthItem = text[i].Length;
        for (int j = 0; j < lengthItem; j++)
        {
            if (!(text[i][j] >= '0' && text[i][j] <= '9'))
            {
                result[i] += text[i][j];
            }
        }
    }
    return result;
}

// 5. Метод печати рядом двух массивов
void Print2ArrayStrings(string[] text, string[] text2)
{
    int size = text.Length;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"{text[i],15}{text2[i],19}");
    }
}

// 6. Метод подсчета количества пустых строк
int CountEmptyItems(string[] text)
{
    int count = 0;
    int size = text.Length;
    for (int i = 0; i < size; i++)
    {
        if (text[i] == null)
        {
            count++;
        }
    }
    return count;
}

// 7. Метод удаления из массива пустых элементов
string[] DelEmptyItems(string[] text, int countNull)
{
    int size = text.Length;
    string[] result = new string[size - countNull];
    int correctItem = 0;
    for (int i = 0; i < size; i++)
    {
        if (text[i] != null)
        {
            result[i - correctItem] = text[i];
        }
        else correctItem++;
    }
    return result;
}

