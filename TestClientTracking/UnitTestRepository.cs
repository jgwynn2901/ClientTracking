
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
        .Where(a => a.LastName == " DiPasquale");
      var count = results.Count();
      Assert.IsTrue(count == 1);
    }
    [TestMethod]
    public void TestStatus()
    {
      var results = ClientRepository.GetActiveStatus();
      Assert.IsTrue(results.Count() >= 8);
    }
    [TestMethod]
    public void TestRace()
    {
      var results = ClientRepository.GetRace();
      Assert.IsTrue(results.Count() >= 48);
    }
    [TestMethod]
    public void TestLanguage()
    {
      var results = ClientRepository.GetLanguage();
      Assert.IsTrue(results.Count() >= 17);
    }

    [TestMethod]
    public void TestFindById()
    {
      var results = new ClientRepository().FindById(86);
      Assert.IsTrue(results.LastName == " DiPasquale");
    }

    [TestMethod]
    public void TestMaxId()
    {
      var results =  ClientRepository.GetMaxPrimaryKey();
      Assert.IsTrue(results != -1);
    }
  }
}
