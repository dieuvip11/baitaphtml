
      
    class Tranhoangdieuhangso
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tran Hoang Dieu");
            Console.WriteLine("2021050131");            
            //khai bao hang so pi
            const double pi = 3.14159;            
            double r;
            Console.Write("Nhap ban kinh: ");
            r = Convert.ToDouble(Console.ReadLine());
            double dien_tich = pi * r * r;
            Console.WriteLine("\nBan kinh: {0}, Dien tich: {1}", r, dien_tich);
            Console.ReadLine();            
            Console.ReadKey();
        }
    }


