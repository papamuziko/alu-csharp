using System.Collections;

class List{

    public static List<int> DeleteAt(List<int> myList, int index){
        int ListSize = myList.Count;
        List<int> CacheList = new List<int>();

        if(index >= 0 && index < ListSize){
            for(int i = 0; i < ListSize; i++){
                if(i == index){
                   // Console.WriteLine("Value o index is : " + index + " and value of i : " + i) ;
                   // Console.WriteLine("index found");
                    continue;
                }else{
                       // Console.WriteLine("Adding the number : " + myList[i]);
                        CacheList.Add(myList[i]);
                }
            
            }
           // foreach(int temp in CacheList){
           //         Console.WriteLine("Printing the cache list elements " + temp);
           // }

            return CacheList;
        }else{
            Console.WriteLine("Index is out of range");
            return myList;
        }

    }
}