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

    public class ManagementInfoPagina_Prolongatieborderellen : BaseWebAiiTest
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
        
        // Add your test methods here...
    
        [CodedStep(@"Verify of auto. gevulde jaar in 'MI_RekeCour_MaandVeld' overeenkomt met de huidige jaar waarin de test is afgespeeld.")]
        public void IsJaarVeldGevuldMetHuidigeJaar()
        {
            string strJaar = DateTime.Now.ToString("yyyy");
        	string ingevoerdeJaarWaarde = Pages.InternTestAccept.MI_RekeCour_JaarVeld.Text;
        	string logText = "LOG: Verwachte jaar[" + strJaar + "]; Daadwerkelijke jaar[" + ingevoerdeJaarWaarde + "]";
        	
        	Log.WriteLine(logText);
        	
        	Pages.InternTestAccept.MI_RekeCour_JaarVeld.AssertAttribute().Value("value", ArtOfTest.Common.StringCompareType.Exact, strJaar);
        }
    
        [CodedStep(@"Verify of gekozen maand in 'MI_RekeCour_MaandVeld' overeenkomt met de huidige maand waarin de test is afgespeeld")]
        public void IsMaandVeldGevuldMetHuidigeMaand()
        {
            string strMaand = DateTime.Now.ToString("%M");
            string ingevoerdeMaandIndexWaarde = (Pages.InternTestAccept.MI_RekeCour_MaandVeld.SelectedIndex + 1).ToString();
        	string logText = "LOG: Verwachte maand[" + strMaand + "]; Daadwerkelijke maand[" + ingevoerdeMaandIndexWaarde + "]";
        	
        	Log.WriteLine(logText);
        	
        	Pages.InternTestAccept.MI_RekeCour_MaandVeld.AssertSelect().SelectedValue(ArtOfTest.Common.StringCompareType.Exact, strMaand);
        }
    }
}
