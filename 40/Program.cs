// Задача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.
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
void maxminFinder (int[]find){
    int max =find[0];
    int min=find[0];
        for(int i=0;i<find.Length;i++){
        if(find[i]>= max) max=find[i];
        else if (find[i]<= min) min = find[i];
        
    }
    Console.WriteLine(max);
    Console.WriteLine(min);
    Console.WriteLine($"Difference between largest and smallest number is ({max-min})");
}
fillArray(massiv);
printArray(massiv);
maxminFinder(massiv);