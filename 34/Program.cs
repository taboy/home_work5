//Задача 34: Написать программу для замены элементов массива на противоположные.
int[] massiv=new int [15];
void printArray(int []printed){
    for(int i =0;i<printed.Length;i++){
        Console.Write($"({printed[i]}) ");
    }
}
void fillArray(int [] filled){
    for(int i=0;i<filled.Length;i++){
        filled[i]= new Random().Next(1,15);
    }
}

void opposite(int[] inverse){
    for(int i=0;i<inverse.Length;i++){
        Console.Write($"({inverse[i] * -1 })");
    }
}
fillArray(massiv);
printArray(massiv);
Console.WriteLine();
opposite(massiv);
