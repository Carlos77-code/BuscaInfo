using System;
using OpenQA.Selenium.Chrome;

namespace BuscaPrecoAcao.UI.Site.Core
{
    // Essa classe é responsavel pelas instruções que virão antes e depois da execução dos testes.
    public class Begin : DSL
    {
        [SetUp]
        public void InicioTeste()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://investidor10.com.br/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driverQuit = true; // Dessa forma como 'true' após o teste ele fecha o teste
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