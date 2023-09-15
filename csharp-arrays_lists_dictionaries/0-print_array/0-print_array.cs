using System.Collections;

class Array{
    public static int[]? CreatePrint(int size){
        int[] NumberList = new int[size];
        if(size == 0){
            Console.WriteLine();
            return NumberList;
        }else if(size < 0){
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        for(int i = 0; i < size; i ++){
            NumberList[i] = i;
        }

        return NumberList;
    }
}
