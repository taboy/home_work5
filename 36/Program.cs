// Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.
int[] massiv=new int [15];
void printArray(int []printed){
    for(int i =0;i<printed.Length;i++){
        Console.Write($"({printed[i]}) ");
    }
}
void fillArray(int [] filled){
    for(int i=0;i<filled.Length;i++){
        filled[i]= new Random().Next(10,99);
    }
}
void even(int[] even){
    int evenc=0;
    int nonevenc=0;
    for(int i =0;i<even.Length;i++){       
        if (even[i]%2==0) evenc++;
        else nonevenc ++;       
    }
    Console.WriteLine($"count of even numbers is {evenc} count of noneven number is {nonevenc}");
}
fillArray(massiv);
printArray(massiv);
even(massiv);