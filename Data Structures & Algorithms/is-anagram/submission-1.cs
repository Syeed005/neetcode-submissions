public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
    return false;
}
        var freq = new Dictionary<char, int>();
foreach (var item in s) {
    freq[item] = freq.GetValueOrDefault(item) + 1;
}

foreach (var item in t) {
    freq[item] = freq.GetValueOrDefault(item) - 1;
}

foreach (var item in freq) {
    if (item.Value > 0) {
        return false;
    }
}
return true;

    }
}
