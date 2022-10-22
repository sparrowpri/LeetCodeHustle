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
 *     }
 * }
 */
public class Solution {
    public int DiameterOfBinaryTree(TreeNode root) {
        return DiameterandHeight(root)[1];
    }
    public int[] DiameterandHeight(TreeNode root)
    {
        
        if(root==null)
        {
           
            return new int[]{-1,-1};
        }
        int[] arr1=DiameterandHeight(root.left);
        int[] arr2=DiameterandHeight(root.right);
        
        var maxh=Math.Max(arr1[0],arr2[0]);
        return new int[]{maxh+1,Math.Max(arr1[0]+arr2[0]+2,Math.Max(arr1[1],arr2[1]))};
    }
}
