using System.Collections;

class Array{
    public static int[] ReplaceElement(int[] array, int index, int n){
        int[] cacheArray = array;
        int size = cacheArray.Length;
        if(index >= 0 && index < size){
            cacheArray[index] = n;
            return cacheArray;
        }else{
            Console.WriteLine("Index out of range");
            return cacheArray;
        }
    }
}