// See https://aka.ms/new-console-template for more information

using System;


namespace MatrixAndVector
{
    class Program
    {
        public static void Main(string[] args)
        {
            //new matrix object created and we fill in the items
            Matrix matrix = new Matrix(3, 3);
            int counter = 1;
            for (int i = 0; i < matrix.GetColRowLength((int)ColumnOrRow.row); i++)
            {
                for (int j = 0; j < matrix.GetColRowLength((int)ColumnOrRow.col); j++)
                {
                    matrix.SetRowColValue(i, j, counter++);
                }
            }
            matrix.PrintAllValues();

            Matrix matrix2 = new Matrix(3, 3);
            counter = 9;
            for (int i = 0; i < matrix2.GetColRowLength((int)ColumnOrRow.row); i++)
            {
                for (int j = 0; j < matrix2.GetColRowLength((int)ColumnOrRow.col); j++)
                {
                    matrix2.SetRowColValue(i, j, counter++);
                }
            }
            matrix2.PrintAllValues();


            matrix = (Matrix)(matrix + matrix2);
            matrix.PrintAllValues();

            matrix = (Matrix)(matrix - matrix2);
            matrix.PrintAllValues();

            matrix = (Matrix)(matrix * matrix2);
            matrix.PrintAllValues();


            Vector vector = new Vector(3);
            counter = 1;
            for (int i = 0; i < vector.GetColRowLength((int)ColumnOrRow.col); i++)
            {
                vector.setColValue(i, counter++);
            }

            vector.PrintAllValues();

            Vector vector2 = new Vector(3);
            counter = 3;
            for (int i = 0; i < vector.GetColRowLength((int)ColumnOrRow.col); i++)
            {
                vector2.setColValue(i, counter--);
            }

            vector.PrintAllValues();

            vector = (Vector)(vector + vector2);
            vector.PrintAllValues();

            vector = (Vector)(vector - vector2);
            vector.PrintAllValues();

            vector = (Vector)(vector * vector2);
            vector.PrintAllValues();
        }
    }
}
