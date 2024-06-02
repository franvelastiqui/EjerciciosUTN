using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrapame_si_puedes
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException(string message) : base(message)
        {
        }

        public ParametrosVaciosException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
