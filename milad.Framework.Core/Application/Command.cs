using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.Framework.Core.Application
{
    public class Command
    {
        public Command()
        {
            TimeStamp = DateTime.Now;
        }
        public DateTime TimeStamp { get; set; }
    }
}
