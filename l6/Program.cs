using l6;

bool isRunning = true;


BookList bl = new BookList();

while (isRunning)
{
    Console.WriteLine("===Menu===");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Show");
    Console.WriteLine("3. Xep");
    Console.WriteLine("0.Thoat");



    Console.Write("===> ");
    int Chon = int.Parse(Console.ReadLine());


    switch (Chon)
    {
        case 1:
            bl.Add();
            break;
            case 2:
            bl.Show();
            break;
            case 3:
            bl.SapXep();
            break;
        case 0:
            isRunning = false;
            break;
        default:
            Console.WriteLine("Vui long chon lai!");
            break;
    }
}