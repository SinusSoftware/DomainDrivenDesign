using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace DomainDrivenDesign.Dekra
{
    internal class DekraAdaptor : IDekraAdaptor
    {
        public DekraAdaptor(IOptions<DekraAdaptorOptions> options)
        {
          
        }
    }
}
