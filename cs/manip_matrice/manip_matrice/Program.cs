using System.Diagnostics;
using System.Security.Principal;

namespace manip_matrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Function func = new Function();


            ConsoleKey input;
            ConsoleKey action;

            bool restart = true;

            do
            {
                int[,] matrix1;
                int[,] matrix2;
                int[,] output = new int[0,0];

                Console.Clear();

                bool wrongInput = true; //permet de vérif les entrées d'utillisateur

                string choix = string.Empty; //retiens si il faut générer de manière aléatoire les matrices ou pas

                string size; //input de l'utilisateur pour la taille des dimensions des matrices

                int matrix1Dim1; //taille dim1 de matrix 1
                int matrix1Dim2; //taille dim2 de matrix 1
                int matrix2Dim1; //taille dim1 de matrix 2
                int matrix2Dim2; //taille dim2 de matrix 2



                //demande de l'action voulue
                do
                {
                    Console.WriteLine("bienvenu dans ma manip de matrices. sellectionnez votre opération :\n" +
                        "1 - faire une addition de matrices\n" +
                        "2 - faire une multiplication de matrices");

                    input = Console.ReadKey().Key;

                    if ((input == ConsoleKey.D1 || input == ConsoleKey.NumPad1) || (input == ConsoleKey.D2 || input == ConsoleKey.NumPad2))
                    {
                        wrongInput = false;
                    }
                    else
                    {
                        wrongInput = true;
                        Console.Clear();
                        Console.WriteLine("mauvaise entrée.\n");
                    }
                } while (wrongInput);

                //sauvegarde de l'action voulue par l'utilisateur
                action = input;

                //demande à l'utilisateur si il veux faire sa matrice ou si il veux la remplir lui même
                do
                {

                    Console.Clear();
                    Console.WriteLine("voulez vous générer une matrice de façon aléatoire (Y) ou la générer manutellement (N)?");
                    input = Console.ReadKey().Key;
                    
                    if (input == ConsoleKey.Y)
                    {
                        choix = "auto";
                        wrongInput = false;
                    }else if(input == ConsoleKey.N)
                    {
                        //génération manuelle du tableau
                        choix = "manual";
                        wrongInput = false;
                    }
                    else
                    {
                        wrongInput = true;
                    }

                } while (wrongInput);


                
                //demande des tailles

                do //dim1matrix1
                {
                    Console.Clear();
                    Console.WriteLine("de quelle taille voulez vous que la ligne du premier tableau soit ?");
                    size = Console.ReadLine();
                } while (!int.TryParse(size, out matrix1Dim1));

                do //dim2matrix1
                {
                    Console.Clear();
                    Console.WriteLine("de quelle taille voulez vous que la colonne du premier tableau soit ?");
                    size = Console.ReadLine();
                } while (!int.TryParse(size, out matrix1Dim2));

                do //dim1matrix2
                {
                    Console.Clear();
                    Console.WriteLine("de quelle taille voulez vous que la ligne du deuxième tableau soit ?");
                    size = Console.ReadLine();
                } while (!int.TryParse(size, out matrix2Dim1));

                do //dim2matrix2
                {
                    Console.Clear();
                    Console.WriteLine("de quelle taille voulez vous que la colonne du deuxième tableau soit ?");
                    size = Console.ReadLine();
                } while (!int.TryParse(size, out matrix2Dim2));



                //lancement des actions de génération de matrices
                Console.Clear();
                if (choix == "auto") //faire un tableau aléatoire
                {
                    func.generateMatrix(matrix1Dim1, matrix1Dim2, matrix2Dim1, matrix2Dim2,out matrix1, out matrix2);

                    Console.WriteLine("matrice 1 :\n\n");
                    
                    for(int i = 0; i < matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix1.GetLength(1); j++)
                        {
                            Console.Write("[" + matrix1[i, j] + "] ");
                        }
                        Console.Write("\n\n");
                    }
                    Console.Write("\n\n\n\n");

                    Console.WriteLine("matrice 2 :\n\n");

                    for (int i = 0; i < matrix2.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix2.GetLength(1); j++)
                        {
                            Console.Write("[" + matrix2[i, j] + "] ");
                        }
                        Console.Write("\n\n");
                    }
                }
                else //assignation manuelle des valeurs dans les matrices
                {
                    string value; //entrée du user
                    int Ivalue; //version vérifiée de value

                    int writeDim1 = 0;
                    int writeDim2 = 0;

                    matrix1 = new int[matrix1Dim1, matrix1Dim2];
                    matrix2 = new int[matrix2Dim1, matrix2Dim2];


                    //assignation des valeurs de la matrice 1
                    for (int i = 0; i < matrix1.GetLength(0) * matrix1.GetLength(1); i++)
                    {
                        for (int dim1 = 0; dim1 < matrix1.GetLength(0); dim1++)
                        {
                            for (int dim2 = 0; dim2 < matrix1.GetLength(1); dim2++)
                            {
                                if (matrix1[dim1, dim2] == 0)
                                {
                                    Console.Write("[_] ");
                                }
                                else
                                {
                                    Console.Write("[" + matrix1[dim1, dim2] + "] ");
                                }
                            }
                            Console.Write("\n\n");
                        }
                        do
                        {
                            value = Console.ReadLine();
                        } while (!int.TryParse(value, out Ivalue));
                        
                        if(writeDim2 < matrix1.GetLength(0))
                        {
                            matrix1[writeDim1, writeDim2] = Ivalue;
                            writeDim2++;
                        }
                        else
                        {
                            writeDim2 = 0;
                            writeDim1++;
                            matrix1[writeDim1, writeDim2] = Ivalue;
                            writeDim2++;
                        }
                        Console.Clear();
                    }
                    writeDim2 = 0;
                    writeDim1 = 0;


                    //assignation des valeurs de la matrice 2
                    for (int i = 0; i < matrix2.GetLength(0) * matrix2.GetLength(1); i++)
                    {
                        for (int dim1 = 0; dim1 < matrix2.GetLength(0); dim1++)
                        {
                            for (int dim2 = 0; dim2 < matrix2.GetLength(1); dim2++)
                            {
                                if (matrix2[dim1, dim2] == 0)
                                {
                                    Console.Write("[_] ");
                                }
                                else
                                {
                                    Console.Write("[" + matrix2[dim1, dim2] + "] ");
                                }
                            }
                            Console.Write("\n\n");
                        }
                        do
                        {
                            value = Console.ReadLine();
                        } while (!int.TryParse(value, out Ivalue));

                        if (writeDim2 < matrix2.GetLength(0))
                        {
                            matrix2[writeDim1, writeDim2] = Ivalue;
                            writeDim2++;
                        }
                        else
                        {
                            writeDim2 = 0;
                            writeDim1++;
                            matrix2[writeDim1, writeDim2] = Ivalue;
                            writeDim2++;
                        }
                        Console.Clear();
                    }
                }


                Console.Clear();

                //lancement des opérations
                if (action == ConsoleKey.D1 || action == ConsoleKey.NumPad1)//addition des matrices
                {
                    if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix2.GetLength(1) == matrix1.GetLength(1))
                    {
                        func.addMatrix(matrix1, matrix2, out output);
                        wrongInput = true;
                    }
                    else
                    {
                        Console.WriteLine("vos matrices n'ont pas la même taile et ne peuvent donc pas être additionnées");
                        wrongInput = false;
                    }
                }//multiplication des matrices
                else
                {
                    if(matrix1.GetLength(1) == matrix2.GetLength(0))
                    {
                        func.multiplyMatrix(matrix1, matrix2, out output);
                        wrongInput = true;
                    }
                    else
                    {
                        Console.WriteLine("les dimentions de vos matrices ne sont pas valides");
                        wrongInput = false;
                    }
                }

                Console.Clear();//affichage du tableau final
                if (wrongInput)
                {
                    for(int dim1 = 0; dim1 < output.GetLength(0); dim1++)
                {
                    for(int dim2 = 0; dim2 < output.GetLength(1); dim2++)
                    {
                        Console.Write("[" + output[dim1, dim2] + "] ");
                    }
                    Console.Write("\n\n");
                }
                }


                Console.ReadKey();
                //section qui permet de relancer le programme
                Console.Clear(); Console.WriteLine("voulez vous quitter ? (Y)");
                if(Console.ReadKey().Key == ConsoleKey.Y)
                {
                    restart = false;
                }
                else
                {
                    restart = true;
                }
            } while (restart);
        }
    }
}
