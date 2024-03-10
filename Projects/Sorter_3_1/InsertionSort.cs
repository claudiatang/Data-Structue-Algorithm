namespace Sorter_3_1
{
    public class InsertionSort : ISorter
    {
        public InsertionSort() { }

        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            if (sequence is null) throw new ArgumentNullException();
            else if (sequence.Length <= 1)
            {
                Console.WriteLine($"Collection length is {sequence.Length}. There are not enough items to be sorted");
                return;
            }
            
            if (comparer == null) comparer = Comparer<K>.Default;

            // Iterative approach
            // Same as the algorithm on Page 108 of the SIT221 Workbook
            for (int i = 1; i < sequence.Length; i++)
            {
                int j;
                K temp = sequence[i];
                for (j = i - 1; j >= 0 && (comparer.Compare(sequence[j], temp) > 0); j--)
                {
                    sequence[j+1] = sequence[j];
                }
                sequence[j + 1] = temp;
            }
        }
    }
}