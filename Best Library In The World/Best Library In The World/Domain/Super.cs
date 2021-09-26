using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Best_Library_In_The_World.Domain
{
    public class Super
    {
        public int id { get; set; } // Primary key for all sub classes
        [JsonIgnore] //
        public DateTime deletedAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

    }
}
