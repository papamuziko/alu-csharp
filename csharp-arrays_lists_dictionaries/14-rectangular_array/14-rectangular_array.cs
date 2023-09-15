using System.Collections;


class Program{
    public static void  Main(string[] args){
        int[,] RecArray = new int[5,5];
        for(int i = 0; i < 5; i++){
            for(int j = 0; j < 5; j++){
                if(i == 2 && j == 2){

                    Console.Write("1 ");
                    RecArray[i,j] = 1;
                    //Console.Write(RecArray[i, j]);
                    
                    continue;
                }
                Console.Write("0 ");
                RecArray[i,j] = 0;
                //Console.Write(RecArray[i, j]);

            }
            Console.WriteLine();
        }
    }
}