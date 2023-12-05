class Quaternion
{
    public double W { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    // Конструктор для ініціалізації кватерніона
    public Quaternion(double w, double x, double y, double z)
    {
        W = w;
        X = x;
        Y = y;
        Z = z;
    }

    // Перевантаження операторів для арифметичних операцій

    public static Quaternion operator +(Quaternion q1, Quaternion q2)
    {
        return new Quaternion(q1.W + q2.W, q1.X + q2.X, q1.Y + q2.Y, q1.Z + q2.Z);
    }

    public static Quaternion operator -(Quaternion q1, Quaternion q2)
    {
        return new Quaternion(q1.W - q2.W, q1.X - q2.X, q1.Y - q2.Y, q1.Z - q2.Z);
    }

    public static Quaternion operator *(Quaternion q1, Quaternion q2)
    {
        double w = q1.W * q2.W - q1.X * q2.X - q1.Y * q2.Y - q1.Z * q2.Z;
        double x = q1.W * q2.X + q1.X * q2.W + q1.Y * q2.Z - q1.Z * q2.Y;
        double y = q1.W * q2.Y - q1.X * q2.Z + q1.Y * q2.W + q1.Z * q2.X;
        double z = q1.W * q2.Z + q1.X * q2.Y - q1.Y * q2.X + q1.Z * q2.W;

        return new Quaternion(w, x, y, z);
    }

    // Метод для обчислення норми кватерніона
    public double Norm()
    {
        return Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
    }

    // Метод для отримання спряженого кватерніона
    public Quaternion Conjugate()
    {
        return new Quaternion(W, -X, -Y, -Z);
    }

    // Метод для отримання інверсного кватерніона
    public Quaternion Inverse()
    {
        double normSquared = W * W + X * X + Y * Y + Z * Z;

        if (normSquared == 0)
            throw new InvalidOperationException("Quaternion has zero norm, cannot compute inverse.");

        double inverseNorm = 1.0 / normSquared;

        return new Quaternion(W * inverseNorm, -X * inverseNorm, -Y * inverseNorm, -Z * inverseNorm);
    }

    // Перевантажені версії операторів порівняння

    public static bool operator ==(Quaternion q1, Quaternion q2)
    {
        return q1.W == q2.W && q1.X == q2.X && q1.Y == q2.Y && q1.Z == q2.Z;
    }

    public static bool operator !=(Quaternion q1, Quaternion q2)
    {
        return !(q1 == q2);
    }

    // Метод для конвертації кватерніона в матрицю обертання
    public double[,] ToRotationMatrix()
    {
        double[,] matrix = new double[3, 3];

        double w2 = W * W;
        double x2 = X * X;
        double y2 = Y * Y;
        double z2 = Z * Z;

        double twoXY = 2.0 * X * Y;
        double twoXZ = 2.0 * X * Z;
        double twoYZ = 2.0 * Y * Z;
        double twoWX = 2.0 * W * X;
        double twoWY = 2.0 * W * Y;
        double twoWZ = 2.0 * W * Z;

        matrix[0, 0] = w2 + x2 - y2 - z2;
        matrix[0, 1] = twoXY - twoWZ;
        matrix[0, 2] = twoXZ + twoWY;

        matrix[1, 0] = twoXY + twoWZ;
        matrix[1, 1] = w2 - x2 + y2 - z2;
        matrix[1, 2] = twoYZ - twoWX;

        matrix[2, 0] = twoXZ - twoWY;
        matrix[2, 1] = twoYZ + twoWX;
        matrix[2, 2] = w2 - x2 - y2 + z2;

        return matrix;
    }
}