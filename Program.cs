// // // Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// // // длина которых меньше, либо равна 3 символам.

string[] input = { "Full", "Hello", "top", "M", "879" };
int maxLength = 3;
 
string[] result = new string[input.Length];
for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= maxLength)

    {
        result[i] = input[i];
    }

}
foreach (string resultItem in result)
{

    Console.WriteLine(resultItem);
}