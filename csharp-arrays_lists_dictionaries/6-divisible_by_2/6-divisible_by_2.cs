using System.Collections;

class List{

    public static List<bool> DivisibleBy2(List<int> myList){
        List<bool> BoolList = new List<bool>();

        foreach(int value in myList){
            if(value % 2 == 0){
                BoolList.Add(true);
            }else{
                BoolList.Add(false);
            }
        }

        return BoolList;
    }
}