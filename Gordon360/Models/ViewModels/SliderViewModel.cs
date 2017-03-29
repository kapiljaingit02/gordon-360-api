﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gordon360.Models.ViewModels
{
    public class SliderViewModel
    {
        public string ImagePath { get; set; }
        public string AltTag { get; set; }
        public string SliderTitle { get; set; }
        public string SliderSubTitle { get; set; }
        public string SliderAction { get; set; }
        public string ActionLink { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Height { get; set; }
        public int SortOrder { get; set; }

        public static implicit operator SliderViewModel(C360_SLIDER s)
        {
            SliderViewModel svm = new SliderViewModel
            {
                ImagePath = "https://wwwtrain.gordon.edu" + s.strFileName,
                AltTag = s.strAltTag,
                SliderTitle = s.strSliderTitle,
                SliderSubTitle = s.strSliderSubTitle,
                SliderAction = s.strSliderAction,
                ActionLink = s.strLinkURL,
                Width = s.iWidth,
                Height = s.iHeight,
                SortOrder = s.sortOrder
            };

            return svm;
        }
    }
}