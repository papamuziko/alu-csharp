using System.Collections;

class Dictionary{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value){
        if(myDict.ContainsKey(key)){
            myDict[key] = value;
        }else{
            myDict[key] = value;
        }

        return myDict;
    }
}
