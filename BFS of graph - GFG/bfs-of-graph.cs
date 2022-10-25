//{ Driver Code Starts
// Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode {

class GFG {
    static void Main(string[] args) {
        int testcases; // Taking testcase as input
        testcases = Convert.ToInt32(Console.ReadLine());
        while (testcases-- > 0) // Looping through all testcases
        {
            var ip = Console.ReadLine().Trim().Split(' ');
            int V = int.Parse(ip[0]);
            int E = int.Parse(ip[1]);
            List<List<int>> adj = new List<List<int>>();
            for (int i = 0; i < V; i++) {
                adj.Add(new List<int>());
            }
            for (int i = 0; i < E; i++) {
                ip = Console.ReadLine().Trim().Split(' ');
                int u = int.Parse(ip[0]);
                int v = int.Parse(ip[1]);
                adj[u].Add(v);
            }
            Solution obj = new Solution();
            var res = obj.bfsOfGraph(V, adj);
            foreach (int i in res) { Console.Write(i + " "); }
            Console.WriteLine();
        }
    }
}
}
// } Driver Code Ends


// User function Template for C#

class Solution {

    // Function to return Breadth First Traversal of given graph.
  public
    List<int> bfsOfGraph(int V, List<List<int>> adj) {
        // Code here
        var visited=new int[V+1];
        var queue=new Queue<int>();
        queue.Enqueue(0);
        visited[0]=1;
        var lis=new List<int>();
        while(queue.Any())
        {
            var deque=queue.Dequeue();
            lis.Add(deque);
            foreach(var item in adj[deque])
            {
                if(visited[item]==0)
                {
                    visited[item]=1;
                    queue.Enqueue(item);
                }
            }
        }
        return lis;
        
    }
}
