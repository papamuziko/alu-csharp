using System.Collections;

class Array{
    public static int elementAt(int[] array, int index){
        int size = array.Length;
        if(index >= 0 && index < size){
             return array[index];
        }else{
            Console.WriteLine("Index out of range");
            return -1;
        }

    }
}