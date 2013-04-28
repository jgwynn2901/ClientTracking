
using System.Linq;
using emergeRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestClientTracking
{
  [TestClass]
  public class UnitTestRepository
  {
    [TestMethod]
    public void TestClient()
    {
      var repo = new ClientRepository();
      var results = repo.FindAll()
        .Where(a => a.LastName == "Gwynn");
      Assert.IsTrue(results.Count() == 1);
    }
  }
}
