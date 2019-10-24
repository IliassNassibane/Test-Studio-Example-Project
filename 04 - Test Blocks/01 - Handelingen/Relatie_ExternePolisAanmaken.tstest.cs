using Telerik.TestStudio.Translators.Common;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace AWI___Automatische_Tests
{

    public class Relatie_ExternePolisAanmaken : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        [CodedStep(@"Is de datum in het 'Ingangsdatum'-veld hetzelfde als de datum van vandaag?")]
        public void IsIngangsdatumGelijkAanVandaag()
        {
            Pages.InternTestAccept.NieuweExternePolis_IngangsdatumVeld.AssertAttribute().Value("value", ArtOfTest.Common.StringCompareType.Exact, DateTime.Now.ToString("dd-MM-yyyy"));
        }
    
        [CodedStep(@"Genereer een tekst en plaats die in het 'Polisnummer'-veld...")]
        public void SetPolisnummerVeld()
        {
            Actions.SetText(Pages.InternTest.NieuweExternePolis_PolisNummerVeld, 
            Resources.GetDateTodayValue() + Resources.GetTimeNowValue() + "Test"
            );
            Pages.InternTest.NieuweExternePolis_PolisNummerVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
        
        [CodedStep(@"Genereer een tekst en plaats die in het 'Omschrijving'-veld...")]
        public void SetOmschrijvingVeld()
        {
            Actions.SetText(Pages.InternTestAccept.NieuweExternePolis_OmschrijvingVeld, 
            DateTime.Now.ToString() + ": Test - AWI-PROT0109"
            );
            Pages.InternTestAccept.NieuweExternePolis_OmschrijvingVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
    }
}
