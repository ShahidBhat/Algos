namespace DynamicConnectivity
{
    public class QuickFind
    {
        private int[] arr;
        //Ctor sets value to each index to i
        public QuickFind(int N)
        {
            arr = new int[N];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i;
        }

        public bool Connected(int p, int q)
        {
            return arr[p] == arr[q];
        }

        public void Union(int p, int q)
        {
            int pid = arr[p];
            int qid = arr[q];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == pid)
                    arr[i] = qid;
            }
        }

    }
}
