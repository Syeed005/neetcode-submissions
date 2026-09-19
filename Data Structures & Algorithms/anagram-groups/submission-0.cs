public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var group = new Dictionary<string, List<String>>();
foreach (var item in strs) {
    char[] chars = item.ToCharArray();
    Array.Sort(chars);
    string str = new string(chars);
    if (!group.ContainsKey(str)) {
        group[str] = new List<string>();
    }
    group[str].Add(item);
}
return group.Values.Select(x => (List<string>) x).ToList();
    }
}
