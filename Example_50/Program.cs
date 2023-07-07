/* Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
int [,] CreateArray(int row, int col, int min, int max){ 
    Random rand = new Random(); 
    int [,] array = new int [row,col]; 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            array[i,j] = rand.Next(min,max+1); 
        } 
    } 
    return array; 
} 
 
void PrintArray(int [,] array){ 
    int row = array.GetLength(0); 
    int col = array.GetLength(1); 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            Console.Write($"{array [i,j]}\t"); 
        } 
        Console.WriteLine(); 
    } 
} 

void Print (string text){  
   Console.Write(text); 
}

int GetIntNum(){
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FindNumber(int [,] array, int rowNumb, int colNumb){
    if ((rowNumb > 0) && (rowNumb <= array.GetLength(0)))
    {
        if ((colNumb > 0) && (colNumb <= array.GetLength(1)))
        {
            Print($"Число -> {array[rowNumb-1, colNumb-1]}");
        }
        else
        {
            Print("такой ячейки в массиве нет");
        }                
    }
    else
    {
        Print("такой ячейки в массиве нет");
    }
}
Console.Clear(); 
int [,] array = CreateArray(4,6,-20,50); 
PrintArray(array); 
Console.WriteLine("Введите позицию элемента в двумерном массиве: ");
Print("Номер строки => ");
int rowNumb = GetIntNum();
Print("Номер столбца => ");
int colNumb = GetIntNum();
FindNumber(array, rowNumb, colNumb);