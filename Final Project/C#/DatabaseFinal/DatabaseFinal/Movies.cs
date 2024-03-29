﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFinal
{
    //Inherits Table and gets all column information from SQL server
    public class Movies : Table
    {
        public string type = "Movies";
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public int ReviewRating { get; set; }
        public int ReleaseDate { get; set; }
        public bool IsRemoved { get; set; }

        //Print string for all information in the table
        public string FullInfo
        {
            get
            {
                return $"{MovieId}: {MovieName} ({Genre}) [{ReviewRating}] {ReleaseDate} {IsRemoved}";
            }
        }

    }
}
