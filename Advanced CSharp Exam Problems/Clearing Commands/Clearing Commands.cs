using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;


    class ClearingCommands
    {
        static void Main()
        {
            List<char[]> matrix = new List<char[]>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                else
                {
                    char[] temp = input.ToCharArray();
                    matrix.Add(temp);
                }
            }
            for (int i = 0; i < matrix.Count; i++)
            {
                char[] str=matrix[i];
                for (int j = 0; j <str.Length ; j++)
                {
                    char ch = str[j];
                    if (ch=='>')
                    {
                        for (int row = j+1; row < str.Length; row++)
                        {
                            char letter = str[row];
                            if (letter=='>' || letter=='<' ||letter=='v'||letter=='^')
                            {
                                break;
                            }
                            else
                            {
                                matrix[i][row] = ' ';
                            }
                        } 
                    }
                    else if (ch == '<')
                    {
                        for (int col = j-1; col >=0; col--)
                        {
                            char letter = str[col];
                            if (letter == '>' || letter == '<' || letter == 'v' || letter == '^')
                            {
                                break;
                            }
                            else
                            {
                                matrix[i][col] = ' ';
                            }
                        }
                    }
                    else if (ch == 'v')
                    {
                        for (int row = i + 1; row < matrix.Count; row++)
                        {
                            char letter = matrix[row][j];
                            if (letter == '>' || letter == '<' || letter == 'v' || letter == '^')
                            {
                                break;
                            }
                            else
                            {
                                matrix[row][j] = ' ';
                            }
                        }
                    }
                    else if (ch == '^')
                    {
                        for (int row = i - 1; row>=0; row--)
                        {
                            char letter = matrix[row][j];
                            if (letter == '>' || letter == '<' || letter == 'v' || letter == '^')
                            {
                                break;
                            }
                            else
                            {
                                matrix[row][j] = ' ';
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            foreach (var item in matrix)
            {
                string output = string.Join("", item);
                Console.WriteLine("<p>" + SecurityElement.Escape(output)+ "</p>");
            }
        }
    }

