#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Diagnostics.CodeAnalysis;

namespace stgen_demo_data
{
    public enum Sex 
    {
        Male,
        Female
    }

    public enum Status
    {
        Active,
        Inactive
    }

    public enum Breed
    {
        Angus,
        Brahma,
        Holstein,
        Simmental

    }


    public class StatusData
    {
        public int StatusID {get; set;}
        public string Status {get; set;}

    }



}


  
  