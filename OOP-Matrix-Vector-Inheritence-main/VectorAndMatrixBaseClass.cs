namespace MatrixAndVector;

    public class VectorAndMatrixBaseClass
    {
        internal int[,] matrix;

        //class is a  behaves like array but this method only readonly access not set value
        internal int this[int i, int j] {

            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }


        // matrix1 and matrix2  sum method
        public static VectorAndMatrixBaseClass operator +(VectorAndMatrixBaseClass matrix1,VectorAndMatrixBaseClass matrix2)
        {
            for (int i = 0; i < matrix1.GetColRowLength((int)ColumnOrRow.row); i++)
            {
                for (int j = 0; j < matrix1.GetColRowLength((int)ColumnOrRow.col); j++)
                {
                    //Console.WriteLine("op");
                    matrix1[i, j] += matrix2[i, j];
                }
            }
          
            return matrix1; 
        }

        // matrix1 and matrix2 extraction  method
        public static VectorAndMatrixBaseClass operator *(VectorAndMatrixBaseClass matrix1, VectorAndMatrixBaseClass matrix2)
        {
            for (int i = 0; i < matrix1.GetColRowLength((int)ColumnOrRow.row); i++)
            {
                for (int j = 0; j < matrix1.GetColRowLength((int)ColumnOrRow.col); j++)
                {
                    matrix1[i, j] *= matrix2[i, j];
                }
            }
            return matrix1;
        }

        // matrix1 and matrix2 multiplaction method
        public static VectorAndMatrixBaseClass operator -(VectorAndMatrixBaseClass matrix1, VectorAndMatrixBaseClass matrix2)
        {
            for (int i = 0; i < matrix1.GetColRowLength((int)ColumnOrRow.row); i++)
            {
                for (int j = 0; j < matrix1.GetColRowLength((int)ColumnOrRow.col); j++)
                {
                    matrix1[i, j] -= matrix2[i, j];
                }
            }
            return matrix1;
        }

        internal void PrintAllValues()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[i, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        internal int GetRowColValue(int row , int col)
        {
            //according to the entered value set matrix element
            return matrix[row, col];
        }

        internal int GetColValue(int col)
        {
            return matrix[0,col];
        }

        internal void SetRowColValue(int row,int col,int values)
        {
            matrix[row, col] = values;
        }

        internal void setColValue(int colNumber, int values)
        {
            matrix[0,colNumber] = values;
        }

        internal int GetColRowLength(int colOrRow)
        {
            // 0 => get row length , 1  get column length
            if (colOrRow == ((int)ColumnOrRow.row))
            {
                return matrix.GetLength(0);
            }
            else
            {
                return matrix.GetLength(1);
            }

        }
       
    }
