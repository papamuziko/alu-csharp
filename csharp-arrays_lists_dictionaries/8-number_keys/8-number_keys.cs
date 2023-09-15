using System.Collections;

class Dictionary{


    public static int NumberOfKeys(Dictionary<string, string> myDict){
        int count = 0;
        foreach(var key in myDict){
            count++;
        }

      //  foreach(KeyValuePair<string, string> key in myDict){
      //      count++;
       // }
        return count;
    }
}