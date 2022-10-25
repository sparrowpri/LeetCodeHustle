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
    public int MaxPathSum(TreeNode root) {
        return MaxPath(root)[2];
    }
    public int[] MaxPath(TreeNode root)
    {
        if(root==null)
        {
            return new int[3]{-2000,-2000,-2000};
        }
        int[] lefth=MaxPath(root.left);
        int[] righth=MaxPath(root.right);
        var arr=new int[3];
       
        arr[0]=Math.Max(Math.Max(lefth[0],righth[0])+root.val,root.val);
        arr[1]=Math.Max(arr[0],lefth[0]+righth[0]+root.val);
        arr[2]=Math.Max(Math.Max(lefth[2],righth[2]),arr[1]);
        arr[2]=Math.Max(arr[2],root.val);
        
        
        return arr;
    }
}