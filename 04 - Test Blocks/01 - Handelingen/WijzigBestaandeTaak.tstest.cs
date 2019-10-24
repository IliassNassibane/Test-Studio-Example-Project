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

    public class WijzigBestaandeTaak : BaseWebAiiTest
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
        
        private string updateBericht = " - (UPDATE) Dit is een update voor test AWI-PROT0106.";
        
        [CodedStep(@"Update inhoud van het 'Omschrijving'-veld...")]
        public void UpdateOmschrijving()
        {            
            Actions.SetText(Pages.InternTestAccept.Nieuw_Taak_OmschrijvingVeld, DateTime.Now.ToString() + updateBericht);
            
            Pages.InternTestAccept.Nieuw_Taak_OmschrijvingVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
        
        [CodedStep(@"Update inhoud van het 'Tekst'-veld...")]
        public void UpdateTekst()
        {            
            Actions.SetText(Pages.InternTestAccept.Nieuw_TekstVeld, 
            ((string)(System.Convert.ChangeType(Data["TekstVeld"], typeof(string)))) + "\n" 
                + DateTime.Now.ToString() + updateBericht
            );
            
            Pages.InternTestAccept.Nieuw_TekstVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
    }
}
