namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> L1 = new List<int>() {1, 3, 5, 7, 9, 11 };
            List<int> L2 = new List<int>() { 2, 4, 6, 8, 10, 12 };
            List<int> L3 =  L1;
            L3 = L3.Concat(L2).ToList();

            Console.WriteLine("Listas Concatenadas:");
            Console.WriteLine(string.Join(",", L3));

            L3.Sort();
            Console.WriteLine("Lista Crescente:");
            Console.WriteLine(string.Join(",", L3));

            L3.Reverse();
            Console.WriteLine("Lista Decrescente:");
            Console.WriteLine(string.Join(",", L3));
        }
    }
}