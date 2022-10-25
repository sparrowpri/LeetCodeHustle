public class Solution {
    public int FindCircleNum(int[][] isConnected) {
      var visited=new int[isConnected.Length+1]; 
      var ans=0;
      for(int i=0;i<isConnected.Length;i++)
      {
          if(visited[i]==0)
          {
              ans+=1;
              bfs(isConnected,visited,i);
              //uncomment below line to use dfs code
              //dfs(i,visited,adjmatrix);
          }
      }
        return ans;
    }
    public void dfs(int node,int[] visited,int[][] adjmatrix)
    {
        visited[node]=1;
        for(int i=0;i<adjmatrix[node].Length;i++)
        {
            if(adjmatrix[node][i]==1 && visited[i]==0 && i!=node )
            {
                dfs(i,visited,adjmatrix);
            }
            
        }
    }
    public void bfs(int[][] adjmatrix,int[] visited,int node)
    {
        var queue=new Queue<int>();
        queue.Enqueue(node);
        visited[node]=1;
        while(queue.Any())
        {
            var deque=queue.Dequeue();
            for(int i=0;i<adjmatrix[deque].Length;i++)
        {
            if(adjmatrix[deque][i]==1 && visited[i]==0 && i!=node )
            {
                queue.Enqueue(i);
                visited[i]=1;
            }
            
        }
        }
    }
}