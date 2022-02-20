// Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.
int[] massiv=new int [5];
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
void nonEvenSumm(int[] summ){
    int nonEvenSumm1=0;
    for(int i =0;i<summ.Length;i++){
        if (i % 2==1) nonEvenSumm1+=summ[i];
    }
    Console.WriteLine(nonEvenSumm1);
}
fillArray(massiv);
printArray(massiv);
nonEvenSumm(massiv);