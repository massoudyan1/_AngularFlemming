using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Library_In_The_World.Domain
{
    public class Author : Super
    {

        public string firstname { get; set; }
        public string lastname { get; set; }
        public List<Book> books { get; set; }


    }
}
