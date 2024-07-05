using BuscaPrecoAcao.UI.Site.Page;
using System;

namespace BuscaPrecoAcao.UI.Site.Test
{
    public class ValidaDividendosTest : ValidaDividendosPage
    {
        [Test]
        public void ValidaDividendo()
        {
            PreencherCampoDeBusca();
            ClicaBtnBusca();
            ClicaResultadoBusca();
            ValidaResultado();
        }
    }
}
