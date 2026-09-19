public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int, int>();
var output = new int[] { };
for (int i = 0; i < nums.Length; i++) {
    var needed = target - nums[i];
    if (seen.ContainsKey(needed)) {
        output =  [seen[needed], i ];
    }
    seen[nums[i]] = i;
}
return output;

    }
}
