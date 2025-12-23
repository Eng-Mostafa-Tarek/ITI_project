using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_windows
{
    public class Book
    {
        public int BookID { get; set; }
        public string? Title  { get; set; }
        public string? Author  { get; set; }
        public int PublishYear { get; set; }
        public bool Available { get; set; }
        public int CategoryID { get; set; }

    }
}
