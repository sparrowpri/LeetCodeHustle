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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        var postend=postorder.Length-1;
        return BuildHere(ref postend,0,inorder.Length,inorder,postorder);
    }
    public TreeNode BuildHere(ref int postend,int instart,int inend,int[] inorder,int[] postorder)
    {
        if(postend<0 || instart>=inend)
        {
            return null;
        }
        var root=new TreeNode(postorder[postend--]);
        var index=-1;
        for(int i=instart;i<inend;i++)
        {
            if(inorder[i]==root.val)
            {
                index=i;
                break;
            }
        }
        
         root.right=BuildHere(ref postend,index+1,inend,inorder,postorder);
        root.left=BuildHere(ref postend,instart,index,inorder,postorder);
       
        return root;
    }
}