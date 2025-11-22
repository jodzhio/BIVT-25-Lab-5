using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Lab5
{
    public class Purple
    {
        public int[] Task1(int[,] matrix)
        {
            int[] answer = null;

            // code 
            int[] temp = new int[matrix.GetLength(1)];
            int idx = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int count = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, i] < 0)
                    {
                        count++; 
                    }
                }
                temp[idx++] = count;
            }
            answer = temp;
            // end

            return answer;
        }
        public void Task2(int[,] matrix)
        {
            // В метод передается матрица(двумерный массив) matrix.В каждой строке матрицы
            // минимальный элемент поместить в начало строки, сохранив порядок остальных элементов.
            // Если в строке несколько равных минимумов, выбирать первый(левый) и перемещать его в
            // начало, остальные сохраняются в порядке.
            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int mn = 10000000;
                int minIdx = -1;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < mn)
                    {
                        mn = matrix[i, j];
                        minIdx = j;
                    }
                }

                if (minIdx == 0)
                {
                    continue;
                }
                int temp = matrix[i, minIdx];
                for (int j = minIdx; j > 0; j--)
                {
                    matrix[i, j] = matrix[i, j - 1];
                }
                matrix[i, 0] = temp;
            }
            // end
        }
        public int[,] Task3(int[,] matrix)
        {
            //В метод передается матрица(двумерный массив) matrix.В каждой строке продублировать
            //максимальный элемент, вставив новый элемент равный максимальному, сразу после
            //максимального.При нескольких максимумов брать первый(левый) максимум и вставлять
            //новый элемент сразу после него(то есть сдвинуть последующие элементы вправо).
            //int[,] answer = null;
            int[,] answer = new int[matrix.GetLength(0), matrix.GetLength(1) + 1];
            //int[,] temp = new int[matrix.GetLength(0), matrix.GetLength(1) + 1];
            // code here
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int mx = -10000000;
                int mxIdx = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > mx)
                    {
                        mx = matrix[i, j];
                        mxIdx = j;
                    }
                }
                for (int j = 0; j < matrix.GetLength(1) + 1; j++)
                {
                    if (j <= mxIdx)
                    {
                        answer[i, j] = matrix[i, j];
                    }
                    else if (j == mxIdx + 1)
                    {
                        answer[i, j] = mx;
                    }
                    else
                    {
                        answer[i, j] = matrix[i, j - 1];
                    }
                }
            }
            // end

            return answer;
        }
        public void Task4(int[,] matrix)
        {
            //В метод передается матрица(двумерный массив) matrix.В каждой строке заменить все
            //отрицательные элементы, расположенные перед первым(левым) максимальным элементом, на
            //среднее арифметическое среди положительных элементов, расположенных после него.Если
            //после максимального нет положительных элементов, изменения не производить. Для
            //целочисленных матриц брать только целую часть среднего.
            // code here

            // end

        }
        public void Task5(int[,] matrix, int k)
        {

            // code here

            // end

        }
        public void Task6(int[,] matrix, int[] array)
        {

            // code here

            // end

        }
        public void Task7(int[,] matrix)
        {

            // code here

            // end

        }
        public int[] Task8(int[,] matrix)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task9(int[,] matrix, int k)
        {

            // code here

            // end

        }
        public int[,] Task10(int[,] A, int[,] B)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public int[][] Task11(int[,] matrix)
        {
            int[][] answer = null;

            // code here

            // end

            return answer;
        }
        public int[,] Task12(int[][] array)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
    }
}