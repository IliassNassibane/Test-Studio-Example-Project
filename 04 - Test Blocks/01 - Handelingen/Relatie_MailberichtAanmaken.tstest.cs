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

    public class Relatie_MailberichtAanmaken : BaseWebAiiTest
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
    
        private string mailFieldValue;
        
        [CodedStep(@"Voert een standaard tekst met actuele datum in het 'Onderwerp'-veld...")]
        public void SetOnderwerpVeld()
        {
            Actions.SetText(Pages.InternTestAccept.Relatie_MailBericht_OnderwerpVeld, 
            DateTime.Now.ToString() + ": AWI-PROT0108 - Dit is een testonderwerp" 
            );
            Pages.InternTestAccept.Relatie_MailBericht_OnderwerpVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
        
        [CodedStep(@"Voert een standaard tekst met actuele datum in het 'Mail'-veld...")]
        public void SetMailVeld()
        {
            this.mailFieldValue = DateTime.Now.ToString() + ": AWI-PROT0108 - Dit is een testmailbericht";
            
            Actions.SetText(Pages.InternTest.Relatie_Mailbericht_MailVeld, mailFieldValue);
            Pages.InternTest.Relatie_Mailbericht_MailVeld.InvokeEvent(ArtOfTest.WebAii.Core.ScriptEventType.OnBlur);
        }
    
        [CodedStep(@"De waarde in het Mail-veld is nog steeds hetzelfde als tijdens het opslaan...")]
        public void Relatie_MailberichtAanmaken_CodedStep()
        {
            Pages.InternTest.Relatie_Mailbericht_MailVeld_Inhoud.AssertContent().InnerText(ArtOfTest.Common.StringCompareType.Same, mailFieldValue);
        }
    }
}
