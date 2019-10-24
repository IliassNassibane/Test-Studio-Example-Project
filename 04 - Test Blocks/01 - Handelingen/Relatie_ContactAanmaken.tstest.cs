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
    public class Relatie_ContactAanmaken : BaseWebAiiTest
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
    
        [CodedStep(@"Vul Contactdatum-veld met datum van vandaag...")]
        public void SetContactDatumMetDatumVanVandaag()
        {
            Actions.SetText(Pages.InternTestAccept.Nieuw_ContactdatumVeld, DateTime.Now.ToString("dd-MM-yyyy"));
            Pages.InternTestAccept.Nieuw_ContactdatumVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
    
        [CodedStep(@"Vul onderwerp met standaardtekst...")]
        public void SetOnderwerpMetStandaardTekst()
        {
            Actions.SetText(Pages.InternTestAccept.Nieuw_OnderwerpVeld, 
            DateTime.Now.ToString() + ": (UPDATE) AWI-PROT0105 - Dit is een testbericht" 
            );
            Pages.InternTestAccept.Nieuw_OnderwerpVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
    
        [CodedStep(@"Heeft het 'Memo'-veld een regel met de datum van vandaag?")]
        public void IsMemoVeldRegelGevuldMetDatumVandaag()
        {
            Pages.InternTestAccept.Nieuw_MemoVeld.AssertAttribute().Value("value", ArtOfTest.Common.StringCompareType.Contains, 
            DateTime.Now.ToString("dd-MM-yyyy"));
        }
    
        [CodedStep(@"Voer het onderwerp in de Onderwerp-filter...")]
        public void SetOnderwerpVeldInContactBar()
        {
            string storedValue = ((string)(System.Convert.ChangeType(Data["WaardeOpgeslagenInOnderwerp"], typeof(string))));
            string newValue = storedValue.Substring(0, storedValue.IndexOf("("));
            Actions.SetText(Pages.InternTestAccept.Relatie_Contacten_OnderwerpFilterVeld, newValue);
            Pages.InternTestAccept.Relatie_Contacten_OnderwerpFilterVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
    }
}
