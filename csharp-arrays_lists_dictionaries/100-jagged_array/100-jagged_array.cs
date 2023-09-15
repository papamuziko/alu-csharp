using System.Collections;

class Program{
    public static void Main(string[] args){
        int[][] JaggedArray = new int[3][];
        JaggedArray[0] = new int[]{ 0, 1, 2, 3};
        JaggedArray[1] = new int[]{ 0 , 1, 2, 3, 4, 5, 6};
        JaggedArray[2] = new int[]{ 0, 1};


    for(int i = 0; i < JaggedArray.Length ; i++){
        for(int j = 0; j < JaggedArray[i].Length; j++){
            Console.Write(JaggedArray[i][j] + " ");
        }
        Console.WriteLine();
    }        
    }


}
