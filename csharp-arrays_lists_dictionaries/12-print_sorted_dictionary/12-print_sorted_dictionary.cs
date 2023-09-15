using System.Collections.Generic;
using System;


class Dictionary{
    
    public static void PrintSorted(Dictionary<string, string> myDict){
        List<string> KeyDict  = new List<string>();
        foreach(KeyValuePair<string, string> temp in myDict){
            KeyDict.Add(temp.Key);
        }

        KeyDict.Sort();

        foreach(string key in KeyDict){
            Console.WriteLine(key + ": " + myDict[key]);
        }

    }
}
