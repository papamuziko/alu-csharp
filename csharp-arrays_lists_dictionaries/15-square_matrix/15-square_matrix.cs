using System.Collections;
using System;
class Matrix{

    static void Main(string[] args)
    {
        int i, j;
        int[,] squareMatrix;
        int[,] myMatrix = new int[,]
        {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
        };

        squareMatrix = Matrix.Square(myMatrix);

        for (i = 0; i < squareMatrix.GetLength(0); i++)
        {
            for (j = 0; j < squareMatrix.GetLength(1); j++)
            {
                Console.Write(squareMatrix[i, j]);
                if (j != squareMatrix.GetLength(1) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    public static int[,] Square(int[,] myMatrix){
        
        int columns = myMatrix.GetLength(1);
        int rows = myMatrix.GetLength(0);


        int[,] SquaredMatrix = new int[rows,columns];
        
        for(int i = 0; i < rows; i++ ){
            for(int j = 0; j < columns; j++){
                SquaredMatrix[i, j] = (int)Math.Pow(myMatrix[i, j], 2);
            }
        }

        return SquaredMatrix;
    }
}