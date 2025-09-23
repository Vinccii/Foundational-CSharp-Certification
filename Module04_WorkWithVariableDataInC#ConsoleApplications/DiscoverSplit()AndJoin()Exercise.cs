namespace Module04_WorkWithVariableDataInC_ConsoleApplications
{
    public static class DiscoverSplit__AndJoin__Exercise
    {
        public static void Run()
        {
            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            // string result = new string(valueArray);
            string result = String.Join(",", valueArray);
            Console.WriteLine(result);

            string[] items = result.Split(',');
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
