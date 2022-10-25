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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var list1=new List<int>();
        var list2=new List<int>();
            LeafCount(root1,list1);
            LeafCount(root2,list2);
        if(list1.Count!=list2.Count)
        {
            return false;
        }
        else
        {
            for(int i=0;i<list1.Count;i++)
            {
                if(list1[i]!=list2[i])
                {
                    return false;
                }
            }
        }
        return true;
    }
    public void LeafCount(TreeNode root,List<int> lis)
    {
        if(root==null)
        {
            return;
        }
       LeafCount(root.left,lis);
       LeafCount(root.right,lis);
        if(root.left==null && root.right==null)
        {
            lis.Add(root.val);
        }
        
        return;
    }
}