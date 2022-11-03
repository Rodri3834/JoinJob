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