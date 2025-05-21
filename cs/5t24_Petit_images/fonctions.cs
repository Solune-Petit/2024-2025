using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5t24_Petit_images
{
    class fonctions
    {
        public string showTable(int [,] mat)
        {
            string output = "";

            for (int matX = 0; matX < mat.GetLength(0); matX++)
            {
                for (int matY = 0; matY < mat.GetLength(1); matY++)
                {
                    if (mat[matX, matY] < 10)
                    {
                        output += " [" + mat[matX, matY] + "]  ";
                    }else if (mat[matX, matY] < 100)
                    {
                        output += " [" + mat[matX, matY] + "] ";
                    }
                    else
                    {
                        output += " [" + mat[matX, matY] + "]";
                    }
                }
                output += "\n";
            }

            return output;
        }

        public string ConcateneImageGraphique(int[,] mat)
        {
            string output = "";
            string characters = " .:-=+*#%@";

            for (int matX = 0; matX < mat.GetLength(0); matX++)
            {
                for (int matY = 0; matY < mat.GetLength(1); matY++)
                {
                    int temp = (int)(mat[matX, matY] * 10 / 256 );

                    switch (temp)
                    {
                        case 0:
                            output += characters[0];
                            break;

                        case 1:
                            output += characters[1];
                            break;

                        case 2:
                            output += characters[2];
                            break;
                        case 3:
                            output += characters[3];
                            break;
                        case 4:
                            output += characters[4];
                            break;
                        case 5:
                            output += characters[5];
                            break;
                        case 6:
                            output += characters[6];
                            break;
                        case 7:
                            output += characters[7];
                            break;
                        case 8:
                            output += characters[8];
                            break;
                        default:
                            output += characters[9];
                            break;

                    }
                }
                output += "\n";
            }

            return output;
        }

        public string Negative(int[,] img)
        {
            string output = "";

            int[,] negative = new int[img.GetLength(0), img.GetLength(1)];

            for (int matX = 0; matX < negative.GetLength(0); matX++)
            {
                for (int matY = 0; matY < negative.GetLength(1); matY++)
                {
                    negative[matX, matY] = 255 - img[matX, matY];
                }
            }

            output = ConcateneImageGraphique(negative);

            return output;
        }

        public string Seuillage(int[,] img, int range)
        {
            string output = "";

            string[,] imgBlacWhite = new string[img.GetLength(0), img.GetLength(1)];

            for (int matX = 0; matX < img.GetLength(0); matX++)
            {
                for (int matY = 0; matY < img.GetLength(1); matY++)
                {
                    if (img[matX, matY] < range)
                    {
                        output += " ";
                    }
                    else
                    {
                        output += "@";
                    }
                }
                output += "\n";
            }

            return output;
        }

        public string Histogramme(int[,] img)
        {
            string output = "";
            string[] histogram = new string[256];
            int counter = 0;
            for (int matX = 0; matX < img.GetLength(0); matX++)
            {
                for (int matY = 0; matY < img.GetLength(1); matY++)
                {
                    histogram[img[matX, matY]] += "@";
                }
            }
            for (int i = 0; i < histogram.Length; i++)
            {
                if (!(histogram[i] == null))
                {
                    output += "[" + counter + "] : " + histogram[i] + "\n";
                }
                counter++;
            }
            return output;
        }
    }
}
