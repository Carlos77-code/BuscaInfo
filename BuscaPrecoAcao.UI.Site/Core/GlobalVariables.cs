using OpenQA.Selenium;
using System;

namespace BuscaPrecoAcao.UI.Site.Core
{
    public class GlobalVariables
    {
        // Define driver como trigger para o WebElements
        public IWebDriver driver;

        // Define 'Fechar navegador ao final do teste' como padrã 
        public bool driverQuit = false; // Dessa forma ele começa com valor false e não fecha a tela após o teste
    }
}
