using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("root");

            XmlElement Product = doc.CreateElement("Product");
            Product.InnerText = "Product1";

            XmlElement Name = doc.CreateElement("Name");
            Name.InnerText = "Metal";

            XmlElement Price = doc.CreateElement("Price");
            Price.InnerText = "20";

            doc.AppendChild(root);
            root.AppendChild(Product);
            Product.AppendChild(Name);
            Product.AppendChild(Price);
            
            doc.Save("ProductPrice.xml");

        }
    }
}
