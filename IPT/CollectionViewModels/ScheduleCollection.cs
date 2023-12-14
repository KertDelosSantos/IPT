using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IPT.Models;

namespace IPT.CollectionViewModels
{
    public class ScheduleCollection
    {
        public Schedule Schedule { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
    }
}