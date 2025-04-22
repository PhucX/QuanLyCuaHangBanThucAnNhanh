using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDemo.Models
{
    public class RegistrationCompleteEventArgs : EventArgs
    {
        public bool Success { get; }
        public RegistrationCompleteEventArgs(bool success) { Success = success; }
    }
}
