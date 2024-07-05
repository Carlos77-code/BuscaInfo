using BuscaPrecoAcao.UI.Site.Core;
using System;

namespace BuscaPrecoAcao.UI.Site.Page
{
    public class ValidaDividendosPage : Begin
    {
        public void PreencherCampoDeBusca()
        {
            EscreveTexto("/html/body/div[4]/div[2]/div/section[1]/div/div/div[1]/div/form/div/span/input[2]", "MXRF11");
        }

        public void ClicaBtnBusca()
        {
            ClicaElement("/html/body/div[4]/div[2]/div/section[1]/div/div/div[1]/div/form/div/button");
        }

        public void ClicaResultadoBusca()
        {
            ClicaResultado("//*[@id=\'results\']/div/div[2]/div[1]/div/div/a/div/div[1]/div/h4");
        }

        public void ValidaResultado()
        {
            ValidaDados("//*[@id=\'header_action\']/div[1]/div[2]/h1", "MXRF11");
        }
    }
}
