public class Solution {

    public string Encode(IList<string> strs) {
        var result = new StringBuilder();
        foreach(var str in strs){
            result.Append(str.Length);
            result.Append("#");
            result.Append(str);
        }
        return result.ToString();
    }

    public List<string> Decode(string s) {
        var output = new List<string>();
        var i = 0;
        while(i < s.Length){
            int j = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, j-i));
            var str = s.Substring(j+1, length);
            output.Add(str);
            i = j+length+1;
        }
        return output;
   }
}
