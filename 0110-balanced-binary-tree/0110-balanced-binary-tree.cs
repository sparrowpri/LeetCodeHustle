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
    public bool IsBalanced(TreeNode root) {
        return findHeight(root)==-1?false:true;
    }
    public int findHeight(TreeNode root)
    {
        if(root==null)
        {
            return 0;
        }
        var lheight=findHeight(root.left);
        var rheight=findHeight(root.right);
        if(Math.Abs(lheight-rheight)>1)
        {
            return -1;
        }
        if(lheight==-1 || rheight==-1)
        {
            return -1;
        }
        return Math.Max(lheight,rheight)+1;
    }
}