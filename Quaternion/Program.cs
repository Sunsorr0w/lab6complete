
// Ініціалізація кватерніонів
Quaternion q1 = new Quaternion(1, 2, 3, 4);
Quaternion q2 = new Quaternion(5, 6, 7, 8);

// Додавання, віднімання та множення
Quaternion sum = q1 + q2;
Quaternion difference = q1 - q2;
Quaternion product = q1 * q2;

// Виведення результатів
Console.WriteLine("Sum: " + sum.W + ", " + sum.X + ", " + sum.Y + ", " + sum.Z);
Console.WriteLine("Difference: " + difference.W + ", " + difference.X + ", " + difference.Y + ", " + difference.Z);
Console.WriteLine("Product: " + product.W + ", " + product.X + ", " + product.Y + ", " + product.Z);

        // Норма, спряжений та інверсний
