namespace DynamicConnectivity
{
    public class QuickUnion
    {
        private int[] arr;
        public QuickUnion()
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i;
        }

        public int Root(int i)
        {
            while (i != arr[i])
                i = arr[i];
            return i;
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            arr[i] = j;
        }

    }
}
