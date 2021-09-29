using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class PackerTracker
  {
    [TestMethod]
    public void PackerConstructor_CreateInstanceOfPacker_Packer()
    {
      Packer newPacker = new Packer("test");
      Assert.AreEqual(typeof(Packer), newPacker.GetType());
    }
    [TestMethod]
    public void GetItems_ReturnsItems_String()
    {
      string item = "Water Bottle";
      Packer newPacker = new Packer(item);
      string result = newPacker.Items;
      Assert.AreEqual(item, result);
    }
  }
}