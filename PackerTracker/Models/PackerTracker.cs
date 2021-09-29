using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Packer
  {
    public string Items {get; }

    public Packer(string items)
    {
      Items = items;
    }
  }
}