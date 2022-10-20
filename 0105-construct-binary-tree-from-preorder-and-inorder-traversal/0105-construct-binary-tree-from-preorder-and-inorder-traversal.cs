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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        var index=0;
       return Buildhere(ref index,0,inorder.Length,preorder,inorder);
    }
    public TreeNode Buildhere(ref int prestart,int instart,int inend,int[] preorder,int[] inorder)
    {
        if(prestart>=preorder.Length|| instart>inend)
        {
            return null;
        }
        var root=new TreeNode(preorder[prestart++]);
        var index=-1;
        for(int i=0;i<inorder.Length;i++)
        {
            if(inorder[i]==root.val)
            { index=i;
                break;
            }
        }
        root.left=Buildhere(ref prestart,instart,index-1,preorder,inorder);
        root.right=Buildhere(ref prestart,index+1,inend,preorder,inorder);
        return root;
    }
}