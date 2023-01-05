using C_SHARPBT2.OOP;

internal class Program
{
    private static void Main(string[] args)
    {/*
        Hinhchunhat hcn1 = new Hinhchunhat(10, 20);
        Console.WriteLine(hcn1);

        Hinhchunhat hcn2 = new Hinhchunhat(4, 5);
        Console.WriteLine(hcn2.tinhdientich());

        //Coppy hcn2 vào hcn3
        Hinhchunhat hcn3 = new Hinhchunhat(hcn2);
        Console.WriteLine(hcn3);


        Hinhchunhat hcn4 = Hinhchunhat.Enter1hcn();
        Console.WriteLine(hcn4);*/


        Console.WriteLine("Nhap so luong hcn : ");
        int soluong = Convert.ToInt32(Console.ReadLine());

        Hinhchunhat[] hcn10 = new Hinhchunhat[soluong];
        Hinhchunhat.nhapNHCN(hcn10, soluong);
        Hinhchunhat.xuatNHCN(hcn10);
       /* Hinhchunhat.maxHCN(hcn10);*/
        MyDate ngaytet = new MyDate(25,2,2001);
        Console.WriteLine(ngaytet);


    }
}