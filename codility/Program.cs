namespace codility
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testData = new int[] { 4, 1, 5, 6, 2 };
            SampleTest.GetNumber(testData);

            int n = 213;
            string result1 = GetSibling.GetSiblingThroughString(n).ToString();
            string result2 = GetSibling.GetSiblingWithoutConverting(n).ToString();

            int[] trees = new int[] { 5,5,5,7,7,7 };
            TreesInForest.GetWidestPath(trees);
        }        

        
    }
}
