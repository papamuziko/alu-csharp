using System.Collections;

class List{

    public static List<int> CreatePrint(int size){
        
        if(size < 0){
            Console.WriteLine("Size cannot be negative");
            return null;
        }else{
            List<int> CacheList = new List<int>();
            for(int i = 0; i < size ; i ++){
                Console.Write(i + " ");
                CacheList.Add(i);
            }
            Console.WriteLine();
            return CacheList;
        }
    }
}