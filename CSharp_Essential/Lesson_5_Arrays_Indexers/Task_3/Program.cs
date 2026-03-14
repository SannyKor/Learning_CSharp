using Task_3;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

bool exit = false;
while (!exit)
    {
    Console.WriteLine("Введіть кількість рядків матриці:");
    int rows = int.Parse(Console.ReadLine());

    Console.WriteLine("Введіть кількість стовпців матриці:");
    int cols = int.Parse(Console.ReadLine());
    MyMatrix matrix = new MyMatrix(rows, cols);

    Console.WriteLine("\nЗгенерована матриця та її похідні:");
    matrix.PrintMatrix();
    matrix.PrintDerivedMatrixs();

    Console.WriteLine("\nБажаєте створити іншу матрицю? (y/n)");
    string choice = Console.ReadLine().ToLower();
    if (choice != "y")
        exit = true;
}
