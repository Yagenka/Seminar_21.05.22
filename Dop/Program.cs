// Напишите функцию, которая принимает слово и возвращает true, если в этом слове есть две одинаковые, стоящие рядом буквы.
// "ссора" -> true, "клюющий" -> true, "кодер" -> false, "цыпленок"-> false

Console.Write("Введите слово: ");
string text = Console.ReadLine();
int length = text.Length;

string Method (string text)
{
string result = string.Empty;
int count = 0;
for (int i = 0; i < length - 1; i++)
{
    if (text[i] == text[i + 1]) count = count + 1;
    else count = count;
}
if (count >= 1) result = "true";
else result = "false";
return result;
}

string res = Method (text);
Console.WriteLine(res);