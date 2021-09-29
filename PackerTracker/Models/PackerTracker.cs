using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Packer
  {
    public string Items {get; set; }

    public Packer(string items)
    {
      Items = items;
    }
  }
}