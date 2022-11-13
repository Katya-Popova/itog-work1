int size = 6;
int x = 3;
string [] arrayOne= new string[size];
Console.WriteLine($"Введите элементы строкового массива, {size} раз через Enter:" );
FillArray(arrayOne);
PrintArray(arrayOne);
if (SecondArraySize (arrayOne) == 0)
{
Console.WriteLine("Искомые элементы не найдены.");
}
else
{
    string[] arraySecond= FillArraySecond(arrayOne);
    Console.WriteLine($"Из имеющегося массива можно сформировать массив из строк, длина которых меньше или равна {x} символам.");
    PrintArray(arraySecond);
}

void FillArray(string[] array)
{  
for (int i=0; i< size;i++)
{
    array[i]=Console.ReadLine() ??"";
}
}
void PrintArray(string[] array)
{
    
      Console.WriteLine("Вывод массива:" );
      Console.Write("[" );
      for (int i=0; i<array.Length; i++)
   
{
       Console.Write(array[i]+" ");
}
Console.Write("]" );
Console.WriteLine(" ");
}
int SecondArraySize (string[] array)
{
int sizesecond =0;
for (int i=0; i< arrayOne.Length;i++)
{
    
    if (arrayOne[i].Length <= x)
    {
        sizesecond++;
    }
    
}
 return sizesecond;
}  

string[] FillArraySecond(string[] array)
{  
string [] arraySecond= new string[SecondArraySize(arrayOne)];
for (int i = 0, j = 0; i < array.Length; i++)
{
    if (array[i].Length<=3)
    {
      arraySecond[j]=array[i];
      j++;
    } 
    
}
return arraySecond;
}