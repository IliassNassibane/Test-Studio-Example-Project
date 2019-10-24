using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
    public class GeneralTests
    {
        public static void IsSavedDateSameAsToday(HtmlControl element)
        {            
            element.AssertAttribute().Value("value", ArtOfTest.Common.StringCompareType.Exact, DateTime.Today.ToString("d-M-yyyy"));
        }
        
        public static void IsSavedDateSameAsSetDate(HtmlControl element, DateTime dateValue)
        {
            element.AssertAttribute().Value("value", ArtOfTest.Common.StringCompareType.Exact, dateValue.ToString("d-M-yyyy"));
        }
    }
}
