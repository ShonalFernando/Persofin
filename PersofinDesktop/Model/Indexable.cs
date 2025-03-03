using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model
{
    public class Indexable
    {
        public int ID { get; set; }
        public Guid GUID { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
