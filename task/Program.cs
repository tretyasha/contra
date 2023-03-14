// Написать программу, которая из имеющегося массива строк формирует массив из строк,длинна которых меньше либо равна 3 символа
string[] massiv = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };
int count = 0;
for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i].Length <= 3)
    {
        count++;
    }
}
string[] newMassiv = new string[count];
int k = 0;
for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i].Length <= 3)
    {
        newMassiv[k] = massiv[i];
        k++;
    }
}
for (k = 0; k < count; k++)
{
    Console.Write(newMassiv[k] + " ");
}
