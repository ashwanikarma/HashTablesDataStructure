namespace HashTableAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Practice Problems!!!");

            string frequency2 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";

            List<string> compareList2 = new List<string>();
            List<string> storeCountList2 = new List<string>();

            string[] frequencyArray2 = frequency2.Split(' ');

            MyMapNode<int, string> hash2 = new MyMapNode<int, string>(frequencyArray2.Length);

            Console.WriteLine("Given phrase is :\n");
            for (int i = 0; i < frequencyArray2.Length; i++)
            {
                hash2.Add(i, frequencyArray2[i]);

                Console.Write(hash2.Get(i) + " ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < frequencyArray2.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < frequencyArray2.Length; j++)
                {
                    if (frequencyArray2[j].ToLower() == hash2.Get(i).ToLower())
                    {
                        
                        count++;

                        if (compareList2.Contains(hash2.Get(j).ToLower()))
                        {
                            break;
                        }
                    }
                }
                if (compareList2.Contains(hash2.Get(i).ToLower()))
                {
                    continue;
                }
                compareList2.Add(hash2.Get(i));

                storeCountList2.Add(hash2.Get(i) + "\t" + count);
            }
            Console.WriteLine("Word and their frequencies shown below");
            for (int i = 0; i < storeCountList2.Count; i++)
            {
                Console.WriteLine(storeCountList2[i]);
            }
        }
        }
    }
