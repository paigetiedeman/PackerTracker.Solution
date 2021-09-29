using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Packer
  {
    public string Items {get; set; }
    private static List<Packer> _instances = new List<Packer>{};

    public Packer(string items)
    {
      Items = items;
      _instances.Add(this);
    }

    public static List<Packer> GetAll()
    {
      return _instances;
    }
    
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}