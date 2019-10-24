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

    public class BestaandeRow0AlertAanpassen : BaseWebAiiTest
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
        
        string omschrijving;
            
        [CodedStep(@"Pas de omschrijving aan van de bestaande Alert...")]
        public void SetBestaandeAlertAanpassen()
        {
            omschrijving = 
            ((string)(System.Convert.ChangeType(Data["OmschrijvingVeld_Inhoud"], typeof(string)))) + "\n"
            + DateTime.Now.ToString() + " - (TEST) Dit is een update op een bestaande Alert, voor test AWI-PROT0103. UPDATE.";
            
            Actions.SetText(Pages.InternTestAccept.Nieuw_OmschrijvingVeld, omschrijving);
            
            Pages.InternTestAccept.Nieuw_OmschrijvingVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
    
        [CodedStep(@"Is de omschrijving overschreven met de nieuwe omschrijving?")]
        public void CheckOfBestaandeAlertIsAangepast()
        {
            Pages.InternTestAccept.Nieuw_OmschrijvingVeld.AssertContent().TextContent(ArtOfTest.Common.StringCompareType.Contains, omschrijving);
        }
    }
}
