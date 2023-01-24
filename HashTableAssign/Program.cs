namespace HashTableAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Practice Problems!!!");
                                     
                    string frequency = "To be or not to be";
                    List<string> compareList = new List<string>();
                    List<string> storeCountList = new List<string>();
                    string[] frequencyArray = frequency.Split(' ');
                    MyMapNode<int, string> hash1 = new MyMapNode<int, string>(frequencyArray.Length);
                    for (int i = 0; i < frequencyArray.Length; i++)
                    {
                        hash1.Add(i, frequencyArray[i]);

                        Console.Write(hash1.Get(i) + " ");
                    }
                    Console.WriteLine();
                    for (int i = 0; i < frequencyArray.Length; i++)
                    {
                        int count = 0;
                        for (int j = 0; j < frequencyArray.Length; j++)
                        {
                            if (frequencyArray[j].ToLower() == hash1.Get(i).ToLower())
                            {
                                count++;

                                if (compareList.Contains(hash1.Get(j).ToLower()))
                                {
                                    break;
                                }
                            }
                        }
                        if (compareList.Contains(hash1.Get(i).ToLower()))
                        {
                            continue;
                        }
                        compareList.Add(hash1.Get(i));

                        storeCountList.Add(hash1.Get(i) + "\t" + count);
                    }

                    Console.WriteLine("Word and their frequencies shown below");
                    for (int i = 0; i < storeCountList.Count; i++)
                    {
                        Console.WriteLine(storeCountList[i]);
                    }
            }
        }
    }
