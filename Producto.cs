using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoparts
{
  class Producto
  {
    int id;
    string name;
    string description;
    string imageURL;
    float price;

    public Producto()
    {
       
    }
    // getters and setters
    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public string Description { get => description; set => description = value; }
    public string ImageURL { get => imageURL; set => imageURL = value; }
    public float Price { get => price; set => price = value; }
  }
}
