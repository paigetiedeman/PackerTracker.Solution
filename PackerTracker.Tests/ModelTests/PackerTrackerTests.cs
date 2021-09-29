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
      Packer newPacker = new Packer();
      Assert.AreEqual(typeof(Packer), newPacker.GetType());
    }
  }
}