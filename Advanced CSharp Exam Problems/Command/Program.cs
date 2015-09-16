using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> words = Regex.Split(input, @"\s+").ToList();
            int invalidCommands = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else
                {
                    string[] commandList = command.Split(' ').ToArray();
                    string first = commandList[0];
                    if (first == "reverse")
                    {
                        int start = int.Parse(commandList[2]);
                        int count = int.Parse(commandList[4]);
                        if (start >= 0 && start <= words.Count &&
                            start + count - 1 > start && start + count - 1 >= 0
                                && start + count - 1 <= words.Count)
                        {
                            List<string> reversedList = new List<string>();
                            for (int i = start + count - 1; i >= start; i--)
                            {
                                reversedList.Add(words[i]);
                            }
                            int index = 0;
                            for (int j = start; j < start + count; j++)
                            {
                                words[j] = reversedList[index];
                                index++;
                            }
                        }
                        else
                        {

                            invalidCommands++;
                            Console.WriteLine("Invalid input parameters.");
                        }
                    }
                    else if (first == "sort")
                    {
                        int start = int.Parse(commandList[2]);
                        int count = int.Parse(commandList[4]);
                        if (start < 0 || start>words.Count||
                            start + count > words.Count || count <= 0)
                        {

                            invalidCommands++;
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            List<string> sortedList = new List<string>();
                            for (int i = start; i < count; i++)
                            {
                                sortedList.Add(words[i]);
                            }
                            StringComparer ordICCmp = StringComparer.InvariantCulture; ;
                            sortedList.Sort();
                            //var sorted = sortedList.OrderBy(x => x).ToList();
                            int index = 0;
                            for (int j = start; j < count; j++)
                            {
                                words[j] = sortedList[index];
                                index++;
                            }
                        }
                    }
                    else if (first == "rollLeft")
                    {

                        int count = int.Parse(commandList[1]);
                        if (count < 0 || words.Count == 1)
                        {
                            invalidCommands++;
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            if (count > words.Count)
                            {
                                count = count % words.Count;
                            }
                            for (int i = 0; i < count; i++)
                            {
                                string left = words[0];
                                words.RemoveAt(0);
                                words.Add(left);
                            }
                        }
                    }
                    else if (first == "rollRight")
                    {
                        int count = int.Parse(commandList[1]);
                        if (count < 0||words.Count==1)
                        {
                            invalidCommands++;
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            if (count > words.Count)
                            {
                                count = count % words.Count;
                            }
                            for (int i = 0; i < count; i++)
                            {
                                string left = words[words.Count - 1];
                                words.RemoveAt(words.Count - 1);
                                words.Insert(0, left);
                            }
                        }
                    }
                }
            }
            //for (int a = 0; a < invalidCommands; a++)
            //{
            //    Console.WriteLine("Invalid input parameters.");
            //}

            Console.WriteLine("[" + String.Join(", ", words) + "]");
            // Console.WriteLine(words.Count);
        }
    }
}
