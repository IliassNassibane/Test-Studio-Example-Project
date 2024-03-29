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
    public class AWI_PROT0209___In_pakket_van_2___1_polis_afwijzen : BaseWebAiiTest
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
    
        [CodedStep(@"Voer de datum van vandaag in de 'Afloopdatum'-filter...")]
        public void SetAfloopDatumDatumVandaag()
        {
            Actions.SetText(Pages.InternTest.TakenWidget_AfloopdatumFilterVeld, DateTime.Now.ToString("dd-MM-yyyy"));
        }
    
        [CodedStep(@"Is het Gekoppeld aan tekst gelijk aan de omschrijving van de beoordelentaak?")]
        public void CheckGekoppeldAanTekstGelijkAanOmschrijvingBeoordelenTaak()
        {
            Log.WriteLine("BeoordelenTaak_OmschrijvingWaarde: " + ((string)(System.Convert.ChangeType(Data["BeoordelenTaak_OmschrijvingWaarde"], typeof(string)))));
            
            string omschrijvingStringWaarde = ((string)(System.Convert.ChangeType(Data["BeoordelenTaak_OmschrijvingWaarde"], typeof(string))));
            string gekoppeldAanWaarde = omschrijvingStringWaarde.Substring(16, (omschrijvingStringWaarde.IndexOf("(")-17));
            
            Log.WriteLine("gekoppeldAanWaarde: " + gekoppeldAanWaarde);
            
            Pages.InternTest.Nieuw_GekoppeldAanVeld.AssertAttribute().Value("value", ArtOfTest.Common.StringCompareType.Exact, gekoppeldAanWaarde);
        }
    
        [CodedStep(@"Is de opgeslagen datum van het Aanmaakdatum veld gelijk aan de datum waarop de beoordeling plaats heeft gevonden?")]
        public void CheckAanmaakdatumSameAsDateOfBeoordeling()// ----- Dit mag misschien weg
        {
            Pages.InternTest.AanmaakDatumVeld.AssertAttribute().Value("value", ArtOfTest.Common.StringCompareType.Contains, DateTime.Now.ToString("dd-MM-yyyy"));
        }
    
        [CodedStep(@"Is het 'Datum gelezen' veld gevuld met de datum van vandaag?")]
        public void CheckDatumGelezenVeldGevuldDatumVandaag()
        {
            Pages.InternTest.DatumGelezenVeld.AssertAttribute().Value("value", ArtOfTest.Common.StringCompareType.StartsWith, DateTime.Now.ToString("dd-MM-yyyy"));
        }
    
        [CodedStep(@"Voer in het Aanmaakdatum filter veld de datum van vandaag...")]
        public void SetAanmaakDatumDatumVandaag()
        {
            Actions.SetText(Pages.InternTestAccept.Beoordelen_AanmaakdatumFilterVeld, DateTime.Now.ToString("dd-MM-yyyy"));
        }
        
        [CodedStep(@"Vind alle premie netto instanties...")]
        public void VindAlleNettoPremies()
        {
            HtmlFindExpression expr = new HtmlFindExpression("class=premie", "propcode=premnetto");
            
            IList<Element> allePremNettos = Find.AllByExpression(expr);
            
            foreach(Element el in allePremNettos)
            {
                Log.WriteLine(allePremNettos.IndexOf(el) + "Inhoud van premienetto: " + el.Content);
            }
        }
    }
}
