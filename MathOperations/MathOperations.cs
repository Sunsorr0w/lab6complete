
class MathOperations
{
    // Перевантажений метод для додавання чисел
    public static T Add<T>(T a, T b)
    {
        return a as dynamic + b as dynamic;
    }

    // Перевантажений метод для додавання масивів чисел
    public static T[] Add<T>(T[] a, T[] b)
    {
        if (a.Length != b.Length)
            throw new ArgumentException("Arrays must have the same length");

        T[] result = new T[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = Add(a[i], b[i]);
        }
        return result;
    }

    // Перевантажений метод для додавання матриць
    public static T[,] Add<T>(T[,] a, T[,] b)
    {
        int rows = a.GetLength(0);
        int columns = a.GetLength(1);

        if (rows != b.GetLength(0) || columns != b.GetLength(1))
            throw new ArgumentException("Matrices must have the same dimensions");

        T[,] result = new T[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = Add(a[i, j], b[i, j]);
            }
        }
        return result;
    }

    // Додаткові перевантажені методи для віднімання, множення та інших операцій можна додати аналогічно.
}