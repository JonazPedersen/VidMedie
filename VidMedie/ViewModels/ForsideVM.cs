using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VMRepo;

namespace VidMedie.ViewModels
{
    public class ForsideVM
    {
        public Velkommen velkommentext { get; set; }
        public Uddannelse uddannelsetext { get; set; }
        public VejledningOgStotte Vejledningogstottetext { get; set; }
        public KontaktLaereren kontaktlaererentext { get; set; }
    }
}