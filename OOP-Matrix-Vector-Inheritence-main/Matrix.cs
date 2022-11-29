namespace MatrixAndVector;

class Matrix : VectorAndMatrixBaseClass
{
    public Matrix(int row, int col)
    {
        matrix = new int[row, col];
    }
}