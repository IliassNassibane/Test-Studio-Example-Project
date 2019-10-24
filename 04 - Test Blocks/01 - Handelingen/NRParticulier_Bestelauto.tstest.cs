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
    public class NRParticulier___Bestelauto : BaseWebAiiTest
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
        
        public string relatieAchternaam;
        public string relatieVoorletters;
        
        public string RelatieAchternaam()
        {
            if(string.IsNullOrEmpty(this.relatieAchternaam))
            {
                this.relatieAchternaam = "Part" + Resources.GetDateTodayValue();
            }
            return this.relatieAchternaam;
        }
        
        public string RelatieVoorletters()
        {
            if(string.IsNullOrEmpty(this.relatieVoorletters))
            {
                this.relatieVoorletters = "BESTELAUTO" + Resources.GetTimeNowValue();
            }
            return this.relatieVoorletters;
        }
        
        [CodedStep(@"Vul een achternaam in voor de nieuwe particuliere relatie")]
        public void VulAchternaamVanNieuweRelatie()
        {
            Actions.SetText(Pages.InternTestAccept.NR_AlgGeg_AchternaamVeld, this.RelatieAchternaam());
            Pages.InternTestAccept.NR_AlgGeg_AchternaamVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
        
        [CodedStep(@"Is het 'achternaam'-veld gevuld met de invoer van relatieAchternaam?")]
        public void IsAchternaamVanNieuweRelatieIngevuld()
        {
            Pages.InternTestAccept.NR_AlgGeg_AchternaamVeld.AssertAttribute().Value("value_sync", ArtOfTest.Common.StringCompareType.Exact, this.relatieAchternaam);
        }
        
        [CodedStep(@"Vul de voorletters in voor de nieuwe particuliere relatie")]
        public void VulVoorlettersVanNieuweRelatie()
        {
            Actions.SetText(Pages.InternTestAccept.NR_AlgGeg_VoorlettersVeld, this.RelatieVoorletters());
            Pages.InternTestAccept.NR_AlgGeg_VoorlettersVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
        
        [CodedStep(@"Is het 'voorletters'-veld gevuld met de invoer van relatievoorletters?")]
        public void IsVoorlettersVanNieuweRelatieIngevuld()
        {
            Pages.InternTestAccept.NR_AlgGeg_VoorlettersVeld.AssertAttribute().Value("value_sync", ArtOfTest.Common.StringCompareType.Exact, this.relatieVoorletters);
        }
    }
}
