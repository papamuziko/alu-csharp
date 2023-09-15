using System.Collections;


class Dictionary{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key){
        Dictionary<string, string> tempDict = myDict;
        if(tempDict.ContainsKey(key)){
            tempDict.Remove(key);
        }

        return tempDict;

    }
}