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
    public int Rob(TreeNode root) {
       return RobWithHash(root,new Dictionary<TreeNode,int>());
    }
    public int RobWithHash(TreeNode root,Dictionary<TreeNode,int> hash)
    {
        if(root==null)
        {
            return 0;
        }
        if(hash.ContainsKey(root))
        {
            return hash[root];
        }
        int val=0;
        if(root.left!=null)
        {
            val+=RobWithHash(root.left.left,hash)+RobWithHash(root.left.right,hash);
        }
        if(root.right!=null)
        {
            val+=RobWithHash(root.right.left,hash)+RobWithHash(root.right.right,hash);
        }
         hash[root]=Math.Max(root.val+val,RobWithHash(root.right,hash)+RobWithHash(root.left,hash));
        return hash[root];
    }
}