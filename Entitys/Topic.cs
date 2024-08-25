using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Entitys
{
    internal class Topic
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Course Course { get; set; }
    }
}
