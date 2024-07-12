using System;
using OpenQA.Selenium.Chrome;

namespace BuscaPrecoAcao.UI.Site.Core
{
    // Essa classe é responsavel pelas instruções que virão antes e depois da execução dos testes.
    public class Begin : DSL
    {
        private void AbreNavegador()
        {
            var headlessMode = new ChromeOptions();
            headlessMode.AddArgument("window-size=1366x768"); //configura para esse tamanho de tela
            headlessMode.AddArgument("disk-cache-size=0"); // apaga todo o cache
            headlessMode.AddArgument("headless");

            var devMode = new ChromeOptions();
            devMode.AddArgument("disk-cache-size=0"); // apaga todo o cache
            devMode.AddArgument("start-maximized");

            if(headlessTest)
            {
                driver = new ChromeDriver(headlessMode);
            }
            else
            {
                driver = new ChromeDriver(devMode); driverQuit = false;
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        [SetUp]
        public void InicioTeste()
        {
            AbreNavegador();
            driver.Navigate().GoToUrl("https://investidor10.com.br/");
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