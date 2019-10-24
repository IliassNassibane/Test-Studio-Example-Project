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
    public class AlertAanmaken : BaseWebAiiTest
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
        
        private string datePattern = "dd-MM-yyyy";
        
        [CodedStep(@"Voer datum van vandaag in het 'AfloopdatumVeld'")]
        public void SetDatumVandaagAfloopdatum()
        {            
            Actions.SetText(Pages.InternTestAccept.Nieuw_AfloopdatumVeld, DateTime.Now.ToString(datePattern));
            Pages.InternTestAccept.Nieuw_AfloopdatumVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
    
        [CodedStep(@"Voer datum van vandaag in het 'EinddatumVeld'")]
        public void SetDatumVandaagEinddatum()
        {            
            Actions.SetText(Pages.InternTestAccept.Nieuw_Alert_EinddatumVeld, DateTime.Now.ToString(datePattern));
            Pages.InternTestAccept.Nieuw_Alert_EinddatumVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
    
        [CodedStep(@"Genereer standaard bericht voor het 'Alert Omschrijving'-veld")]
        public void SetAlertOmschrijving()
        {            
            Actions.SetText(Pages.InternTestAccept.Nieuw_OmschrijvingVeld,
            DateTime.Now.ToString() + " - Dit is een omschrijving voor test AWI-PROT0105. TEST.\n"
            );
            
            Pages.InternTestAccept.Nieuw_OmschrijvingVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
    
        [CodedStep(@"Genereer update van het 'Omschrijving'-veld na een wijziging")]
        public void UpdateAlertOmschrijving()
        {            
            Actions.SetText(Pages.InternTestAccept.Nieuw_OmschrijvingVeld,
            ((string)(System.Convert.ChangeType(Data["Alert_OmschrijvingVeld_Value"], typeof(string)))) + "\n"
            + DateTime.Now.ToString() + " - (TEST) Dit is een update voor test AWI-PROT0103. UPDATE."
            );
            
            Pages.InternTestAccept.Nieuw_OmschrijvingVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
    }
}
