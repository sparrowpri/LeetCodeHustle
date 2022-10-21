/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/discuss/ *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        return makeTree(nums,0,nums.Length-1);
        
    }
    public TreeNode makeTree(int[] nums,int start,int end)
    {
        if(start>end)
        {
            return null;
        }
        var mid=(start+end)/2;
        var root=new TreeNode(nums[mid]);
        root.left=makeTree(nums,start,mid-1);
        root.right=makeTree(nums,mid+1,end);
        return root;
        
    }
     
}