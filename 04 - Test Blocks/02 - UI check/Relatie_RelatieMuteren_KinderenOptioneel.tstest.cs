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

    public class Relatie_RelatieMuteren_KinderenOptioneel : BaseWebAiiTest
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
    
        [CodedStep(@"Check instelling van kinderen aantal veld en voer checks uit gerelateerd op die instelling")]
        public void Relatie_RelatieMuteren_KinderenOptioneel_CodedStep()
        {
            
            if(Pages.InternTestAccept.NR_Kinderen_AantalKinderenVeld.SelectedIndex == 1)
            {
                Log.WriteLine("Instelling voor aantal kinderen veld is \"1 kind\"");
                
                Relatie_RelatieMuteren_KinderenOptioneel_CodedStep1(1);
            }
            else if(Pages.InternTestAccept.NR_Kinderen_AantalKinderenVeld.SelectedIndex == 2)
            {
                Log.WriteLine("Instelling voor aantal kinderen veld is \"2 kinderen\"");
                
                Relatie_RelatieMuteren_KinderenOptioneel_CodedStep1(2);
            }
            else if(Pages.InternTestAccept.NR_Kinderen_AantalKinderenVeld.SelectedIndex == 3)
            {
                Log.WriteLine("Instelling voor aantal kinderen veld is \"3 kinderen\"");
                
                Relatie_RelatieMuteren_KinderenOptioneel_CodedStep1(3);
            }
            else if(Pages.InternTestAccept.NR_Kinderen_AantalKinderenVeld.SelectedIndex == 4)
            {
                Log.WriteLine("Instelling voor aantal kinderen veld is \"4 kinderen\"");
                
                Relatie_RelatieMuteren_KinderenOptioneel_CodedStep1(4);
            }
            else if(Pages.InternTestAccept.NR_Kinderen_AantalKinderenVeld.SelectedIndex == 5)
            {
                Log.WriteLine("Instelling voor aantal kinderen veld is \"5 of meer kinderen\"");
                
                Relatie_RelatieMuteren_KinderenOptioneel_CodedStep1(5);
            }
            else
            {
                Log.WriteLine("Instelling voor aantal kinderen veld is \"Geen kinderen\"");
            }
        }
    
        [CodedStep(@"If statement voor het uitvoeren van de verschillende checks")]
        public void Relatie_RelatieMuteren_KinderenOptioneel_CodedStep1(int input)
        {            
            if(input >= 1)
            {
                Log.WriteLine("Kind nummer 1 wordt gecheckt");
                
                if(Pages.InternTestAccept.NR_Kinderen_Kind1_GeslachtTitle.IsVisible())
                {
                    Log.WriteLine("PASS; Kind nummer 1: Geslachttitle is zichtbaar");
                }
                else
                {
                    Log.WriteLine("FAIL; Kind nummer 1: Geslachttitle is niet zichtbaar");
                }
                
                if(Pages.InternTestAccept.NR_Kinderen_Kind1_GeslachtManTitle.IsVisible())
                {
                    Log.WriteLine("PASS; Kind nummer 1: GeslachtManTitle is zichtbaar");
                }
                else
                {
                    Log.WriteLine("FAIL; Kind nummer 1: GeslachtManTitle is niet zichtbaar");
                }
                
                if(Pages.InternTestAccept.NR_Kinderen_Kind1_GeslachtManRadio.IsVisible())
                {
                    Log.WriteLine("PASS; Kind nummer 1: GeslachtManRadio is zichtbaar");
                }
                else
                {
                    Log.WriteLine("FAIL; Kind nummer 1: GeslachtManRadio is niet zichtbaar");
                }
                
                if(Pages.InternTestAccept.NR_Kinderen_Kind1_GeslachtVrouwTitle.IsVisible())
                {
                    Log.WriteLine("PASS; Kind nummer 1: GeslachtVrouwTitle is zichtbaar");
                }
                else
                {
                    Log.WriteLine("FAIL; Kind nummer 1: GeslachtManRadio is niet zichtbaar");
                }
                
                if(Pages.InternTestAccept.NR_Kinderen_Kind1_GeslachtVrouwRadio.IsVisible())
                {
                    Log.WriteLine("PASS; Kind nummer 1: GeslachtVrouwRadio is zichtbaar");
                }
                else
                {
                    Log.WriteLine("FAIL; Kind nummer 1: GeslachtVrouwRadio is niet zichtbaar");
                }
                
                if(Pages.InternTestAccept.NR_Kinderen_Kind1_VoorlettersTitle.IsVisible())
                {
                    Log.WriteLine("PASS; Kind nummer 1: VoorlettersTitle is zichtbaar");
                }
                else
                {
                    Log.WriteLine("FAIL; Kind nummer 1: VoorlettersTitle is niet zichtbaar");
                }
                
                if(Pages.InternTestAccept.NR_Kinderen_Kind1_VoorlettersVeld.IsVisible())
                {
                    Log.WriteLine("PASS; Kind nummer 1: VoorlettersVeld is zichtbaar");
                }
                else
                {
                    Log.WriteLine("FAIL; Kind nummer 1: VoorlettersVeld is niet zichtbaar");
                }
                
                if(Pages.InternTestAccept.NR_Kinderen_Kind1_AchternaamTitle.IsVisible())
                {
                    Log.WriteLine("PASS; Kind nummer 1: AchternaamTitle is zichtbaar");
                }
                else
                {
                    Log.WriteLine("FAIL; Kind nummer 1: AchternaamTitle is niet zichtbaar");
                }
                
                if(Pages.InternTestAccept.NR_Kinderen_Kind1_AchternaamVeld.IsVisible())
                {
                    Log.WriteLine("PASS; Kind nummer 1: AchternaamVeld is zichtbaar");
                }
                else
                {
                    Log.WriteLine("FAIL; Kind nummer 1: AchternaamVeld is niet zichtbaar");
                }
                
                if(Pages.InternTestAccept.NR_Kinderen_Kind1_GeboortedatumTitle.IsVisible())
                {                    
                    Log.WriteLine("PASS; Kind nummer 1: GeboortedatumTitle is zichtbaar");
                }
                else
                {
                    Log.WriteLine("FAIL; Kind nummer 1: GeboortedatumTitle is niet zichtbaar");
                }
                
                if(Pages.InternTestAccept.NR_Kinderen_Kind1_GeboortedatumVeld.IsVisible())
                {
                    Log.WriteLine("PASS; Kind nummer 1: GeboortedatumVeld is zichtbaar");
                }
                else
                {
                    Log.WriteLine("FAIL; Kind nummer 1: GeboortedatumVeld is niet zichtbaar");
                }
                
                if(input >= 2)
                {
                    Log.WriteLine("Kind nummer 2 wordt gecheckt");
                    
                    if(Pages.InternTestAccept.NR_Kinderen_Kind2_GeslachtTitle.IsVisible())
                    {
                        Log.WriteLine("PASS; Kind nummer 2: GeslachtTitle is zichtbaar");
                    }
                    else
                    {
                        Log.WriteLine("FAIL; Kind nummer 2: GeslachtTitle is niet zichtbaar");
                    }
                        
                    if(Pages.InternTestAccept.NR_Kinderen_Kind2_GeslachtManTitle.IsVisible())
                    {
                        Log.WriteLine("PASS; Kind nummer 2: GeslachtManTitle is zichtbaar");
                    }
                    else
                    {
                        Log.WriteLine("FAIL; Kind nummer 2: GeslachtManTitle is niet zichtbaar");
                    }
                    
                    if(Pages.InternTestAccept.NR_Kinderen_Kind2_GeslachtManRadio.IsVisible())
                    {
                        Log.WriteLine("PASS; Kind nummer 2: GeslachtManRadio is zichtbaar");
                    }
                    else
                    {
                        Log.WriteLine("FAIL; Kind nummer 2: GeslachtManRadio is niet zichtbaar");
                    }
                    
                    if(Pages.InternTestAccept.NR_Kinderen_Kind2_GeslachtVrouwTitle.IsVisible())
                    {
                        Log.WriteLine("PASS; Kind nummer 2: GeslachtVrouwTitle is zichtbaar");
                    }
                    else
                    {
                        Log.WriteLine("FAIL; Kind nummer 2: GeslachtVrouwTitle is niet zichtbaar");
                    }
                    
                    if(Pages.InternTestAccept.NR_Kinderen_Kind2_GeslachtVrouwRadio.IsVisible())
                    {
                        Log.WriteLine("PASS; Kind nummer 2: GeslachtVrouwRadio is zichtbaar");
                    }
                    else
                    {
                        Log.WriteLine("FAIL; Kind nummer 2: GeslachtVrouwRadio is niet zichtbaar");
                    }
                    
                    if(Pages.InternTestAccept.NR_Kinderen_Kind2_VoorlettersTitle.IsVisible())
                    {
                        Log.WriteLine("PASS; Kind nummer 2: VoorlettersTitle is zichtbaar");
                    }
                    else
                    {
                        Log.WriteLine("FAIL; Kind nummer 2: VoorlettersTitle is niet zichtbaar");
                    }
                    
                    if(Pages.InternTestAccept.NR_Kinderen_Kind2_VoorlettersVeld.IsVisible())
                    {
                        Log.WriteLine("PASS; Kind nummer 2: VoorlettersVeld is zichtbaar");
                    }
                    else
                    {
                        Log.WriteLine("FAIL; Kind nummer 2: VoorlettersVeld is niet zichtbaar");
                    }
                    
                    if(Pages.InternTestAccept.NR_Kinderen_Kind2_AchternaamTitle.IsVisible())
                    {
                        Log.WriteLine("PASS; Kind nummer 2: AchternaamTitle is zichtbaar");
                    }
                    else
                    {
                        Log.WriteLine("FAIL; Kind nummer 2: AchternaamTitle is niet zichtbaar");
                    }
        
                    if(Pages.InternTestAccept.NR_Kinderen_Kind2_AchternaamVeld.IsVisible())
                    {
                        Log.WriteLine("PASS; Kind nummer 2: AchternaamVeld is zichtbaar");
                    }
                    else
                    {
                        Log.WriteLine("FAIL; Kind nummer 2: AchternaamVeld is niet zichtbaar");
                    }
                    
                    if(Pages.InternTestAccept.NR_Kinderen_Kind2_GeboortedatumTitle.IsVisible())
                    {
                        Log.WriteLine("PASS; Kind nummer 2: GeboortedatumTitle is zichtbaar");
                    }
                    else
                    {
                        Log.WriteLine("FAIL; Kind nummer 2: GeboortedatumTitle is niet zichtbaar");
                    }
                    
                    if(Pages.InternTestAccept.NR_Kinderen_Kind2_GeboortedatumVeld.IsVisible())
                    {
                        Log.WriteLine("PASS; Kind nummer 2: GeboortedatumVeld is zichtbaar");
                    }
                    else
                    {
                        Log.WriteLine("FAIL; Kind nummer 2: GeboortedatumVeld is niet zichtbaar");
                    }
                        
                    if(input >= 3)
                    {
                        Log.WriteLine("Kind nummer 3 wordt gecheckt");
                        
                        if(Pages.InternTestAccept.NR_Kinderen_Kind3_GeslachtTitle.IsVisible())
                        {
                            Log.WriteLine("PASS; Kind nummer 3: GeslachtTitle is zichtbaar");
                        }
                        else
                        {
                            Log.WriteLine("FAIL; Kind nummer 3: GeslachtTitle is niet zichtbaar");
                        }
                        
                        if(Pages.InternTestAccept.NR_Kinderen_Kind3_GeslachtManTitle.IsVisible())
                        {
                            Log.WriteLine("PASS; Kind nummer 3: GeslachtManTitle is zichtbaar");
                        }
                        else
                        {
                            Log.WriteLine("FAIL; Kind nummer 3: GeslachtManTitle is niet zichtbaar");
                        }
                        
                        if(Pages.InternTestAccept.NR_Kinderen_Kind3_GeslachtManRadio.IsVisible())
                        {
                            Log.WriteLine("PASS; Kind nummer 3: GeslachtManRadio is zichtbaar");
                        }
                        else
                        {
                            Log.WriteLine("FAIL; Kind nummer 3: GeslachtManRadio is niet zichtbaar");
                        }
                        
                        if(Pages.InternTestAccept.NR_Kinderen_Kind3_GeslachtVrouwTitle.IsVisible())
                        {
                            Log.WriteLine("PASS; Kind nummer 3: GeslachtVrouwTitle is zichtbaar");
                        }
                        else
                        {
                            Log.WriteLine("FAIL; Kind nummer 3: GeslachtVrouwTitle is niet zichtbaar");
                        }
                        
                        if(Pages.InternTestAccept.NR_Kinderen_Kind3_GeslachtVrouwRadio.IsVisible())
                        {
                            Log.WriteLine("PASS; Kind nummer 3: GeslachtVrouwRadio is zichtbaar");
                        }
                        else
                        {
                            Log.WriteLine("FAIL; Kind nummer 3: GeslachtVrouwRadio is niet zichtbaar");
                        }
                        
                        if(Pages.InternTestAccept.NR_Kinderen_Kind3_VoorlettersTitle.IsVisible())
                        {
                            Log.WriteLine("PASS; Kind nummer 3: VoorlettersTitle is zichtbaar");
                        }
                        else
                        {
                            Log.WriteLine("FAIL; Kind nummer 3: VoorlettersTitle is niet zichtbaar");
                        }
                        
                        if(Pages.InternTestAccept.NR_Kinderen_Kind3_VoorlettersVeld.IsVisible())
                        {
                            Log.WriteLine("PASS; Kind nummer 3: VoorlettersVeld is zichtbaar");
                        }
                        else
                        {
                            Log.WriteLine("FAIL; Kind nummer 3: VoorlettersVeld is niet zichtbaar");
                        }
                        
                        if(Pages.InternTestAccept.NR_Kinderen_Kind3_AchternaamTitle.IsVisible())
                        {
                            Log.WriteLine("PASS; Kind nummer 3: AchternaamTitle is zichtbaar");
                        }
                        else
                        {
                            Log.WriteLine("FAIL; Kind nummer 3: AchternaamTitle is niet zichtbaar");
                        }
                        
                        if(Pages.InternTestAccept.NR_Kinderen_Kind3_AchternaamVeld.IsVisible())
                        {
                            Log.WriteLine("PASS; Kind nummer 3: AchternaamVeld is zichtbaar");
                        }
                        else
                        {
                            Log.WriteLine("FAIL; Kind nummer 3: AchternaamVeld is niet zichtbaar");
                        }
                        
                        if(Pages.InternTestAccept.NR_Kinderen_Kind3_GeboortedatumTitle.IsVisible())
                        {
                            Log.WriteLine("PASS; Kind nummer 3: GeboortedatumTitle is zichtbaar");
                        }
                        else
                        {
                            Log.WriteLine("FAIL; Kind nummer 3: GeboortedatumTitle is niet zichtbaar");
                        }
                        
                        if(Pages.InternTestAccept.NR_Kinderen_Kind3_GeboortedatumVeld.IsVisible())
                        {
                            Log.WriteLine("PASS; Kind nummer 3: GeboortedatumVeld is zichtbaar");
                        }
                        else
                        {
                            Log.WriteLine("FAIL; Kind nummer 3: GeboortedatumVeld is niet zichtbaar");
                        }
                        
                        if(input >= 4)
                        {
                            Log.WriteLine("Kind nummer 4 wordt gecheckt");
                            
                            if(Pages.InternTestAccept.NR_Kinderen_Kind4_GeslachtTitle.IsVisible())
                            {
                                Log.WriteLine("PASS; Kind nummer 4: GeslachtTitle is zichtbaar");
                            }
                            else
                            {
                                Log.WriteLine("FAIL; Kind nummer 4: GeslachtTitle is niet zichtbaar");
                            }
                            
                            if(Pages.InternTestAccept.NR_Kinderen_Kind4_GeslachtManTitle.IsVisible())
                            {
                                Log.WriteLine("PASS; Kind nummer 4: GeslachtManTitle is zichtbaar");
                            }
                            else
                            {
                                Log.WriteLine("FAIL; Kind nummer 4: GeslachtManTitle is niet zichtbaar");
                            }
                            
                            if(Pages.InternTestAccept.NR_Kinderen_Kind4_GeslachtManRadio.IsVisible())
                            {
                                Log.WriteLine("PASS; Kind nummer 4: GeslachtManRadio is zichtbaar");
                            }
                            else
                            {
                                Log.WriteLine("FAIL; Kind nummer 4: GeslachtManRadio is niet zichtbaar");
                            }
                            
                            if(Pages.InternTestAccept.NR_Kinderen_Kind4_GeslachtVrouwTitle.IsVisible())
                            {
                                Log.WriteLine("PASS; Kind nummer 4: GeslachtVrouwTitle is zichtbaar");
                            }
                            else
                            {
                                Log.WriteLine("FAIL; Kind nummer 4: GeslachtVrouwTitle is niet zichtbaar");
                            }
                            
                            if(Pages.InternTestAccept.NR_Kinderen_Kind4_GeslachtVrouwRadio.IsVisible())
                            {
                                Log.WriteLine("PASS; Kind nummer 4: GeslachtVrouwRadio is zichtbaar");
                            }
                            else
                            {
                                Log.WriteLine("FAIL; Kind nummer 4: GeslachtVrouwRadio is niet zichtbaar");
                            }
                            
                            if(Pages.InternTestAccept.NR_Kinderen_Kind4_VoorlettersTitle.IsVisible())
                            {
                                Log.WriteLine("PASS; Kind nummer 4: VoorlettersTitle is zichtbaar");
                            }
                            else
                            {
                                Log.WriteLine("FAIL; Kind nummer 4: VoorlettersTitle is niet zichtbaar");
                            }
                            
                            if(Pages.InternTestAccept.NR_Kinderen_Kind4_VoorlettersVeld.IsVisible())
                            {
                                Log.WriteLine("PASS; Kind nummer 4: VoorlettersVeld is zichtbaar");
                            }
                            else
                            {
                                Log.WriteLine("FAIL; Kind nummer 4: VoorlettersVeld is niet zichtbaar");
                            }
                            
                            if(Pages.InternTestAccept.NR_Kinderen_Kind4_AchternaamTitle.IsVisible())
                            {
                                Log.WriteLine("PASS; Kind nummer 4: AchternaamTitle is zichtbaar");
                            }
                            else
                            {
                                Log.WriteLine("FAIL; Kind nummer 4: AchternaamTitle is niet zichtbaar");
                            }
                            
                            if(Pages.InternTestAccept.NR_Kinderen_Kind4_AchternaamVeld.IsVisible())
                            {
                                Log.WriteLine("PASS; Kind nummer 4: AchternaamVeld is zichtbaar");
                            }
                            else
                            {
                                Log.WriteLine("FAIL; Kind nummer 4: AchternaamVeld is niet zichtbaar");
                            }
                            
                            if(Pages.InternTestAccept.NR_Kinderen_Kind4_GeboortedatumTitle.IsVisible())
                            {
                                Log.WriteLine("PASS; Kind nummer 4: GeboortedatumTitle is zichtbaar");
                            }
                            else
                            {
                                Log.WriteLine("FAIL; Kind nummer 4: GeboortedatumTitle is niet zichtbaar");
                            }
                            
                            if(Pages.InternTestAccept.NR_Kinderen_Kind4_GeboortedatumVeld.IsVisible())
                            {
                                Log.WriteLine("PASS; Kind nummer 4: GeboortedatumVeld is zichtbaar");
                            }
                            else
                            {
                                Log.WriteLine("FAIL; Kind nummer 4: GeboortedatumVeld is niet zichtbaar");
                            }
                            
                            if(input == 5)
                            {
                                Log.WriteLine("Kind nummer 5 wordt gecheckt");
                                
                                if(Pages.InternTestAccept.NR_Kinderen_Kind5_GeslachtTitle.IsVisible())
                                {
                                    Log.WriteLine("PASS; Kind nummer 5: GeslachtTitle is zichtbaar");
                                }
                                else
                                {
                                    Log.WriteLine("FAIL; Kind nummer 5: GeslachtTitle is niet zichtbaar");
                                }
                                
                                if(Pages.InternTestAccept.NR_Kinderen_Kind5_GeslachtManTitle.IsVisible())
                                {
                                    Log.WriteLine("PASS; Kind nummer 5: GeslachtManTitle is zichtbaar");
                                }
                                else
                                {
                                    Log.WriteLine("FAIL; Kind nummer 5: GeslachtManTitle is niet zichtbaar");
                                }
                                
                                if(Pages.InternTestAccept.NR_Kinderen_Kind5_GeslachtManRadio.IsVisible())
                                {
                                    Log.WriteLine("PASS; Kind nummer 5: GeslachtManRadio is zichtbaar");
                                }
                                else
                                {
                                    Log.WriteLine("FAIL; Kind nummer 5: GeslachtManRadio is niet zichtbaar");
                                }
                                
                                if(Pages.InternTestAccept.NR_Kinderen_Kind5_GeslachtVrouwTitle.IsVisible())
                                {
                                    Log.WriteLine("PASS; Kind nummer 5: GeslachtVrouwTitle is zichtbaar");
                                }
                                else
                                {
                                    Log.WriteLine("FAIL; Kind nummer 5: GeslachtVrouwTitle is niet zichtbaar");
                                }
                                
                                if(Pages.InternTestAccept.NR_Kinderen_Kind5_GeslachtVrouwRadio.IsVisible())
                                {
                                    Log.WriteLine("PASS; Kind nummer 5: GeslachtVrouwRadio is zichtbaar");
                                }
                                else
                                {
                                    Log.WriteLine("FAIL; Kind nummer 5: GeslachtVrouwRadio is niet zichtbaar");
                                }
                                
                                if(Pages.InternTestAccept.NR_Kinderen_Kind5_VoorlettersTitle.IsVisible())
                                {
                                    Log.WriteLine("PASS; Kind nummer 5: VoorlettersTitle is zichtbaar");
                                }
                                else
                                {
                                    Log.WriteLine("FAIL; Kind nummer 5: VoorlettersTitle is niet zichtbaar");
                                }
                                
                                if(Pages.InternTestAccept.NR_Kinderen_Kind5_VoorlettersVeld.IsVisible())
                                {
                                    Log.WriteLine("PASS; Kind nummer 5: VoorlettersVeld is zichtbaar");
                                }
                                else
                                {
                                    Log.WriteLine("FAIL; Kind nummer 5: VoorlettersVeld is niet zichtbaar");
                                }
                                
                                if(Pages.InternTestAccept.NR_Kinderen_Kind5_AchternaamTitle.IsVisible())
                                {
                                    Log.WriteLine("PASS; Kind nummer 5: AchternaamTitle is zichtbaar");
                                }
                                else
                                {
                                    Log.WriteLine("FAIL; Kind nummer 5: AchternaamTitle is niet zichtbaar");
                                }
                                
                                if(Pages.InternTestAccept.NR_Kinderen_Kind5_AchternaamVeld.IsVisible())
                                {
                                    Log.WriteLine("PASS; Kind nummer 5: AchternaamVeld is zichtbaar");
                                }
                                else
                                {
                                    Log.WriteLine("FAIL; Kind nummer 5: AchternaamVeld is niet zichtbaar");
                                }
                                
                                if(Pages.InternTestAccept.NR_Kinderen_Kind5_GeboortedatumTitle.IsVisible())
                                {
                                    Log.WriteLine("PASS; Kind nummer 5: GeboortedatumTitle is zichtbaar");
                                }
                                else
                                {
                                    Log.WriteLine("FAIL; Kind nummer 5: GeboortedatumTitle is niet zichtbaar");
                                }
                                
                                if(Pages.InternTestAccept.NR_Kinderen_Kind5_GeboortedatumVeld.IsVisible())
                                {
                                    Log.WriteLine("PASS; Kind nummer 5: GeboortedatumVeld is zichtbaar");
                                }
                                else
                                {
                                    Log.WriteLine("FAIL; Kind nummer 5: GeboortedatumVeld is niet zichtbaar");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
