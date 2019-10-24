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

    public class NieuweRelatieZakelijkAanmaken : BaseWebAiiTest
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
        
        public string relatieNaam;
        
        public string RelatieNaam()
        {
            if(string.IsNullOrEmpty(this.relatieNaam))
            {
                this.relatieNaam = "Zakel" + Resources.GetDateTodayValue() + "." +
                    Resources.GetTimeNowValue();
            }
            return this.relatieNaam;
        }
    
        [CodedStep(@"Is de datum in het 'Wijzigingsdatum'-veld gelijk aan de datum waarop de nieuwe relatie wordt aangemaakt?")]
        public void CheckSavedDateInWijzigingsdatumVeld()
        {
            GeneralTests.IsSavedDateSameAsToday(Pages.InternTestAccept.Relatie_WijzigingsdatumVeld);
        }
        
        [CodedStep(@"Vul een naam in voor de nieuwe particuliere relatie")]
        public void VulNaamVanNieuweRelatie()
        {
            Actions.SetText(Pages.InternTestAccept.NR_AlgGeg_NaamVeld, this.RelatieNaam());
            Pages.InternTestAccept.NR_AlgGeg_NaamVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
        
        [CodedStep(@"Is het 'naam'-veld gevuld met de invoer van relatieAchternaam?")]
        public void IsNaamVanNieuweRelatieIngevuld()
        {
            Pages.InternTestAccept.NR_AlgGeg_NaamVeld.AssertAttribute().Value("value_sync", ArtOfTest.Common.StringCompareType.Exact, this.relatieNaam);
        }
    }
}
