// See https://aka.ms/new-console-template for more information

using PracticalTest_Caoquoctrung_t2108a1;

ProductController productController = new ProductController();

    int ch=4;
    do
    {
        Console.WriteLine("==========Menu==========");
        Console.WriteLine("1.Add Product");
        Console.WriteLine("2.Display Product");
        Console.WriteLine("3.Delete Product");
        Console.WriteLine("4.End ");
        ch = int.Parse(Console.ReadLine());
    switch (ch)
    {
        case 1:
            productController.AddProduct();
            break;
        case 2:
            productController.GetAllProduct();
            break;
        case 3:
            productController.DeleteById();
            break;
        case 4:
            break;
        default:
            Console.WriteLine("Please check your selection!");
            break;
    }
    } while (ch != 4);


