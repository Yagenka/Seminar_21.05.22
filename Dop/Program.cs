// Напишите функцию, которая принимает слово и возвращает true, если в этом слове есть две одинаковые, стоящие рядом буквы.
// "ссора" -> true, "клюющий" -> true, "кодер" -> false, "цыпленок"-> false

Console.Write("Введите слово: ");
string text1 = Console.ReadLine();
string text = text1.ToUpper();                            // перевод всех букв в верхний регистр

int length = text.Length;


bool FindDouble(string text)
{
    bool result = false;

    for (int i = 0; i < length - 1; i++)
    {
        if (text[i] == text[i + 1])
        {
            result = true;
            break;
        }
    }
    return result;
}

bool res = FindDouble(text);
Console.WriteLine(res);