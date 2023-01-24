namespace HashTableAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Practice Problems!!!");

            string removeString = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";

            string[] removeStringArray = removeString.Split(' ');

            MyMapNode<int, string> hash3 = new MyMapNode<int, string>(removeStringArray.Length);
            Console.WriteLine("Given phrase is : \n");

            for (int i = 0; i < removeStringArray.Length; i++)
            {
                hash3.Add(i, removeStringArray[i]);
                Console.Write(hash3.Get(i) + " ");
            }

            hash3.Remove(17);

            Console.WriteLine("\n\nAfter removing word \"avoidable\" from phrase, the phrase is : \n");

            for (int i = 0; i < removeStringArray.Length; i++)
            {
                Console.Write(hash3.Get(i) + " ");
            }
            Console.WriteLine();
        }
        }
    }
