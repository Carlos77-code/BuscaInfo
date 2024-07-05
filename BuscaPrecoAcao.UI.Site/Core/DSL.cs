using OpenQA.Selenium;
using System;

namespace BuscaPrecoAcao.UI.Site.Core
{
    public class DSL : GlobalVariables
    {
        #region Escrever em campos
        public void EscreveTexto(string xpath, string value)
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }
        #endregion

        #region Clica Elemento
        public void ClicaElement(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }
        #endregion

        #region Clica no resultado da busca
        public void ClicaResultado(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }
        #endregion

        #region Valida dados
        public void ValidaDados(string xpath, string value)
        {
            Assert.That(driver.FindElement(By.XPath(xpath)).Text, Does.Contain(value));
        }
        #endregion
    }
}
