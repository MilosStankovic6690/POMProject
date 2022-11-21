using NUnit.Framework;
using OrangeProject.Driver;
using OrangeProject.Page;

namespace OrangeProject
{
    public class Tests
    {
        Login _login;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            _login = new Login();
        }

        [Test]
        public void Test1()
        {
            _login.LoginUser("Admin", "admin123");
        }
    }
}