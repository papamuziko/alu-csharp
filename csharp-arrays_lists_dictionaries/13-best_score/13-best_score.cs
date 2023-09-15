using System.Collections;

class Dictionary{


    public static string BestScore(Dictionary<string, int> myList){
        /*

        var AList = myList.ToList();
        AList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
        AList.Reverse();
        var DictNow = AList.Distinct().ToDictionary(x => x, x => x);
        
        foreach(var temp in DictNow){
            Console.WriteLine(temp);
        }

        return null;
        */
        string BestSoFar = "";
        int LargestSoFar = -1;
        foreach(KeyValuePair<string, int> temp in myList){
            if(temp.Value > LargestSoFar){
                LargestSoFar = temp.Value;
                BestSoFar = temp.Key;
            }
        }

        if(BestSoFar != null){
            return BestSoFar;
        }else{
            return null;
        }

        /*
        string BestScore = "";

        foreach(var temp in sortedDict){
            BestScore = sortedDict.Key;
            break;
        }

        if(BestScore != null){
            return BestScore;
        }else{
            return null;
        }
        */
    
    }
}