public class Solution {
    public bool hasDuplicate(int[] nums) {
        bool hasDuplicates = nums.Distinct().Count() != nums.Length;
        if (hasDuplicates == true) {
            return true;
        }
        else{
            return false;
        }
    }
}
