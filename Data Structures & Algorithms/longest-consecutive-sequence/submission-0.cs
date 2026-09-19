public class Solution {
    public int LongestConsecutive(int[] nums) {
        var uniq = new HashSet<int>(nums);
        int longest = 0;
        foreach(var num in uniq){
            if(uniq.Contains(num-1)){
                continue;
            }
            var current = num;
            var count = 1;
            while(uniq.Contains(current+1)){
                count++;
                current++;
            }
            if(count>longest){
                longest = count;
            }
        }
        return longest;
    }
}
