using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Xml.Linq;

namespace BuscaPrecoAcao.UI.Site.Core
{
    public class DSL : GlobalVariables
    {
        #region Funções de Manipulação
        // Espera um tempo até carregar a tela/página
        public static void Espere(int time) => Thread.Sleep(time);

        // Limpa campos que fora preenchidos.
        public void LimpaCampo(string element) => driver.FindElement(By.XPath(element)).Clear();

        // Clica fora do campo(as vezes é preciso para que seja validado o que incluimos no campo)
        public void ClicaFora() => driver.FindElement(By.XPath("//html")).Click();

        // Espera um elemento ficar visível (tem o tempo por default 90 segundos, mas é possível diminuir ou aumentar direto na chamada)
        public void EsperaElemento(string element, int second = 90)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
            wait.Until((d) => { return d.FindElement(By.XPath(element)); } );
        }

        // Espera um elemento sumir da tela (tem o tempo por default 90 segundos, mas é possível diminuir ou aumentar direto na chamada)
        public void EsperaElementoSumir(string element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
            wait.Until(d => d.FindElements(By.XPath(element)).Count == 0);
        }

        // Valida se um determinado elemento está realmente presente em tela.
        public bool ValidaElementoExistente(string xPath)
        {
            try
            {
                driver.FindElement(By.XPath(xPath)); return true;
            }
            catch(NoSuchDriverException)
            {
                return false;
            }
        }
        #endregion

        #region Funções de Interação
        public void EscreveTexto(string xpath, string value)
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }

        public void ClicaElement(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }

        public void ClicaResultado(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }
       
        public void ValidaDados(string xpath, string value)
        {
            Assert.That(driver.FindElement(By.XPath(xpath)).Text, Does.Contain(value));
        }
        #endregion
        #region Funções de Atribuição

        #endregion
    }
}
