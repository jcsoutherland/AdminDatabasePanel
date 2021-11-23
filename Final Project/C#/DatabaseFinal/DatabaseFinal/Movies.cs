using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFinal
{
    public class Movies
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public int ReviewRating { get; set; }
        public int ReleaseDate { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{MovieId}: {MovieName} ({Genre}) [{ReviewRating}] {ReleaseDate}";
            }
        }

    }
}
