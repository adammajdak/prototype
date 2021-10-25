using System;
using System.Collections.Generic;
using System.Text;

public abstract class Supermarket
{
  
  public string Bread { get; set; }
  public string Butter { get; set; }

  public ProductPrototype(decimal price)
  {
      _type = Price;
        Price = 0;
  }

  public ProductPrototype Clone(){
    return (ProductPrototype) this.MemberwiseClone();
  }
  
}


public class Bread : ProductPrototype
{
  
  public Bread(decimal price) : base(price){}

}


public class Butter : ProductPrototype
{
  
  public Butter(decimal price) : base(price){}

}


public class Supermarket
{
  
  private Dictionary<string, ProductPrototype> _productList = new Dictionary<string, ProductPrototype>();

  public void AddProduct(string key, ProductPrototype productPrototype)
  {
    _productList.Add(key, productPrototype);
  }

  public ProductPrototype GetClonedProduct(string key)
  {
      //... zwraca klon
  }
  
}


class MainClass 
{
  public static void Main (string[] args) 
  {
    Console.OutputEncoding = Encoding.UTF8;
      //... supermarket
      //... product; 
      
      supermarket.AddProduct("Bread", new Bread(9.50m));
      supermarket.AddProduct("Butter", new Butter(5.30m));
      
      
      product = supermarket.GetClonedProduct("Butter");
      product = supermarket.GetClonedProduct("Bread");
      Console.WriteLine(String.Format("Bread - {0:F2} zł", product.Price));
      Console.WriteLine(String.Format("Butter - {0:F2} zł", product.Price));
      
  }
}
