using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platinum
{
    public class GotoActionResult : ActionResult
    {
        public int TargetActionNumber { get; set; }
    }
}
