using System.Drawing;

var sh = new Shop();
var pr = new Product ();
pr.Name = "Abdullo";
pr.Price = 150;

var phone = new Phone ();
phone.Name = "Jack";
phone.Price = 210;
phone.Models = "iPhone 12";
phone.Company = "Apple";

var car = new Car ();
car.Name = "Bill";
car.Price = 250;
car.Color = "red";
car.Brand = "Lexus";
car.Year = 2018;

sh.AddProduct(pr);
sh.AddProduct(phone);
sh.AddProduct(car);
sh.PrintProduct();

sh.RemoveProduct(car);
sh.PrintProduct();
