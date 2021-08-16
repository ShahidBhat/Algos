using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicConnectivity
{
    public class WeightedQuickUnion
    {
        private int[] arr;
        private int[] sz;
        public WeightedQuickUnion(int N)
        {
            arr = new int[N];
            sz = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = i;
                sz[i] = 1;
            }
        }

        public int Root(int i)
        {
            while( i != arr[i])
            {
                i = arr[i];
            }
            return i;
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public void Union(int p, int q)
        {
            int pId = Root(p);
            int qId = Root(q);
            if (pId == qId) return;
            if(sz[p] > sz[q])
            {
                arr[q] = pId;
                sz[p] += sz[q];
            }else
            {
                arr[p] = qId;
                sz[q] += sz[p];
            }
        }
    }
}
