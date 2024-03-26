// See https://aka.ms/new-console-template for more information

using ConsoleAppProgram;

class Program
{
    public static void Main(string[] args)
    {
        List<Product> listOfProducts = new List<Product>();
        char c = 'Y';   
        while (c == 'Y' || c == 'y' ) 
        { 

            Console.WriteLine("Select the Product Type: \n 1.Iron \n 2.Steel \n 3.Silver \n");
            int type = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Select the Product Stage: \n 1.Assembly \n 2.Production \n 3.Delivery \n");
            int stage = Int32.Parse(Console.ReadLine());

            Product product = new Product();
            product.ProductId = type;
            product.ProductType = (ProductType)type;
            product.ProductStage = (ProductStage)stage;

            listOfProducts.Add(product);

            Console.WriteLine($"The Product {product.ProductType} is in {product.ProductStage} Stage");

            Console.WriteLine("\n");

            Console.WriteLine("The List Of Product includes: \n");
            int count = 0;  

            foreach (var item in listOfProducts)
            {
                count++;
                Console.WriteLine($" {count}. ProductId: {item.ProductId} \n ProductType: {item.ProductType} \n ProductStage: {item.ProductStage} \n");
                
            }
            Console.WriteLine($" Do you want to add more Items? press Y or y ");

        }
    }
    
   
}

