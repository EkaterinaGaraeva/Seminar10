/*
Задача 71: В некотором машинном алфавите имеются четыре буквы 
«а», «и», «с» и «в». Покажите все слова, состоящие из n букв, 
которые можно построить из букв этого алфавита.
n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
ав, ва, ви, ив, св, вс
*/

int n = 0;
void Words(string text, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
    }
    else
    {
        for (int i = 0; i < text.Length; i++)
        {
            word[length] = text[i];
            Words(text, word, length + 1);
        }
    }
}

Words("аисв", new char[2]);
