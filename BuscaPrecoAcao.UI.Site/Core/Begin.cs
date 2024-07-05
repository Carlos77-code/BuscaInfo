using System;
using OpenQA.Selenium.Chrome;

namespace BuscaPrecoAcao.UI.Site.Core
{
    // Essa classe � responsavel pelas instru��es que vir�o antes e depois da execu��o dos testes.
    public class Begin : DSL
    {
        [SetUp]
        public void InicioTeste()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://investidor10.com.br/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driverQuit = true; // Dessa forma como 'true' ap�s o teste ele fecha o teste
        }

        [TearDown]
        public void FimTeste()
        {
            if (driverQuit)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}