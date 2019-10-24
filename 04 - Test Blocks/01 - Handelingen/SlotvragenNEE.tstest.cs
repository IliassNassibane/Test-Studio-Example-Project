using Telerik.TestStudio.Translators.Common;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public class BeoAVPAllianzSlotvragenNEE : BaseWebAiiTest
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
        
        private ReadOnlyCollection<HtmlDiv> slotvragen;
        
        [CodedStep(@"Vind alle slotvraag Nee's en plaats die in een list...")]
        public void VindAlleSlotvragenInAanvraagScherm()
        {
            slotvragen = ActiveBrowser.Find.AllByAttributes<HtmlDiv>("class=radio", "selector=~vraag_", "selector=~_Radio_Nee");
        }
        
        [CodedStep(@"Klik Nee op alle aanwezige slotvragen...")]
        public void KlikNeeOpAlleSlotvragen()
        {
            if(slotvragen.Count > 0)
            {
                foreach(HtmlDiv div in slotvragen)
                {
                    div.Click();
                }
            }            
        }
    }
}