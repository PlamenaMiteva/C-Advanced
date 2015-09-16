using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class StringMatrixRotation
    {
        static void Main()
        {
            string num = Console.ReadLine();
            StringBuilder builder = new StringBuilder(num);
            builder.Replace("Rotate", "");
            builder.Replace("(", "");
            builder.Replace(")", "");
            int degree = int.Parse(builder.ToString());
            List<char[]> result = new List<char[]>();
            int maxLength = 0;
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
                    result.Add(temp);
                    if (input.Length>maxLength)
                    {
                        maxLength = input.Length; 
                    }
                }
            }
            int row=0;
            int col=0;
            char[,] matrix= new char[result.Count,maxLength];
            foreach (var key in result)
            {
                foreach (var item in key)
                {
                    matrix[row, col]=item;
                    col++;
                }
                row++;
                col = 0;
            }
            
            if ((degree/90)%4==1||degree==90)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    for (int j =  matrix.GetLength(0)-1; j >=0; j--)
                    {
                        if (matrix[j,i] == '\0')
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(matrix[j, i]);
                        }
                    }
                    Console.WriteLine();
                } 
            }
                else if ((degree/90)%4==2||degree==180)
            {
                for (int i = matrix.GetLength(0) - 1; i >=0; i--)
                {
                    for (int j =  matrix.GetLength(1)-1; j >=0; j--)
                    {
                        if (matrix[i, j] == '\0')
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(matrix[i, j]);
                        }
                    }
                    Console.WriteLine();
                } 
            }
            else if ((degree / 90) % 4 == 3 || degree == 270)
            {
                for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        if (matrix[j,i] == '\0')
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(matrix[j, i]);
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if ((degree / 90) % 4 == 0 || degree == 0)
            {
                for (int i = 0; i <matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == '\0')
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(matrix[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }

