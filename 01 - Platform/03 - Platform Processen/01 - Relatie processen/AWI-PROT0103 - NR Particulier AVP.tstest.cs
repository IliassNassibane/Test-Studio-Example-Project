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
    public class AWI_PROT0103___NR_Particulier_AVP : BaseWebAiiTest
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
    
        [CodedStep(@"Voer de opgeslagen waardes van het 'achternaam'-veld en 'voorletters'-veld...")]
        public void SetTextWithSavedFieldValues()
        {
            Actions.SetText(Pages.InternTestAccept.RelatieFilterVeld, 
            ((string)(System.Convert.ChangeType(Data["NieuweRelatieParticulier_Achternaam"], typeof(string)))) 
            + ", " + ((string)(System.Convert.ChangeType(Data["NieuweRelatieParticulier_Voorletters"], typeof(string))))
            );
        }
    
        [CodedStep(@"Heeft deze nieuwe relatie nog steeds dezelfde naam?")]
        public void AWIPROT0101__Nieuwe_Relatie_Particulier_invoercontrole_en_aanmaak_CodedStep()
        {
            Pages.InternTestAccept.NRTestRelatie.AssertAttribute().Value("title", ArtOfTest.Common.StringCompareType.Exact, 
            ((string)(System.Convert.ChangeType(Data["NieuweRelatieParticulier_Achternaam"], typeof(string))))
            + ", " + ((string)(System.Convert.ChangeType(Data["NieuweRelatieParticulier_Voorletters"], typeof(string))))
            );
            
        }
    }
}
