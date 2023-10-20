using Shop;
using System.Security;
AddInfo addinfo = new AddInfo();
Delete delete = new Delete();
GetInfo getInfo = new GetInfo();
Find find = new Find();
Selling selling = new Selling();
Update update = new Update();
Console.WriteLine( ">>>>>>>>>>>>>>> Sunny_shop ga hush kelipsiz >>>>>>>>>>>>>>>>>>>");

Console.WriteLine("Mahsulot qushish uchun : 1");
Console.WriteLine("Mahsolot qidirish : 2");
Console.WriteLine("Mahsulotni sotib olish : 3");
Console.WriteLine("Bazadagi barcha malumotlarni uchirish : 4");
Console.WriteLine("1 ta malumotni uchirish : 5");
Console.WriteLine("Bazadagi malumotlarni chiqarish : 6");
Console.WriteLine("Yangilash malumotni : 7");
salom:
Console.Write(">>");
int son = int.Parse(Console.ReadLine());
if (son == 1) 
{
    Console.Write("Mahsulot nomi: ");
    string tu = Console.ReadLine();
    Console.Write("Mahsulot narxi: ");
    int tu1 = int.Parse(Console.ReadLine());
    Console.Write("Mahsulot miqdori: ");
    int tu2 = int.Parse(Console.ReadLine());
    addinfo.AddProduct(tu, tu1,tu2 );
    getInfo.ProductOlish(tu);


}
else if(son == 2)
{
    Console.Write("Mahsulot nomi: ");
    string tu = Console.ReadLine();
    find.FindProduct(tu);
}
else if(son == 3)
{
    Console.Write("Mahsulot nomi: ");
    string tu = Console.ReadLine();
    Console.Write("Mahsulot narxi: ");
    int tu1 = int.Parse(Console.ReadLine());
    Console.Write("Mahsulot miqdori: ");
    int tu2 = int.Parse(Console.ReadLine());
    selling.SotipOlish(tu, tu1,tu2);
    getInfo.ProductOlish(tu);
}
else if(son == 4)
{
    delete.DeleteAllProducts();
}
else if(son == 5)
{
    Console.Write("Mahsulot nomi: ");
    string tu = Console.ReadLine();
    delete.OneDeletaProduct(tu);
}
else if(son == 6)
{
    Console.Write("Mahsulot nomi: ");
    string tu = Console.ReadLine();
    getInfo.ProductOlish(tu);

}
else if(son == 7)
{
    Console.Write("Mahsulot nomi: ");
    string tu = Console.ReadLine();
    addinfo.UpdateProduct(tu);
    getInfo.ProductOlish(tu);
}


goto salom;


