public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
foreach (var item in nums) {
    freq[item] = freq.GetValueOrDefault(item) + 1;
}

var buckets = new List<int>[nums.Length + 1];
foreach (var item in freq) {
    if (buckets[item.Value] == null) {
        buckets[item.Value] = new List<int>();
    }
    buckets[item.Value].Add(item.Key);
}

var result = new List<int>();
for (int i = nums.Length; i >= 1; i--) {
    if (buckets[i] == null) {
        continue;
    }
    foreach (var item in buckets[i]) {
        result.Add(item);
        if (result.Count == k) {
            return result.ToArray();
        }
    }
}
return result.ToArray();
    }
}
