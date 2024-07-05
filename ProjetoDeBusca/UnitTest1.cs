using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProjetoDeBusca
{
    public class Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void InicioDoTeste()
        {
            
        }

        [Test]
        public void Test1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://buscacepinter.correios.com.br/app/endereco/index.php");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void FimTeste()
        {
            if(driver != null)
            {
                driver.Close();
                driver.Dispose();
            }
        }
    }
}