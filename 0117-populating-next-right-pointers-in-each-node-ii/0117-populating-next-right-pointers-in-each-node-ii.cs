/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        
        var queue=new Queue<Node>();
        queue.Enqueue(root);
        while(root!=null && queue.Count>0)
        {
            var number=queue.Count;
            for(int i=0;i<number;i++)
            {
                var curr=queue.Dequeue();
                if(i!=number-1)
                {
                    curr.next=queue.Peek();
                }
                if(curr.left!=null)
                {
                    queue.Enqueue(curr.left);
                }
                if(curr.right!=null)
                {
                    queue.Enqueue(curr.right);
                }
            }
           
        }
         return root;
    }
}