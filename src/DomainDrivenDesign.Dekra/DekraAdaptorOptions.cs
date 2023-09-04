using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Dekra
{
    public class DekraAdaptorOptions
    {
        public Uri DekraUrl { get; set; } = new Uri("https://www.dekra.de/");
        public string DekraSearch { get; set; } = "search?fl=id,drs1p,drs2p,drslp,drs1l,drs2l,drsll,zip_code,location&fq=zip_code:{{PLZ}}.type:drs";
        //test
        //"https://www.dekra.de/search?fl=id,drs1p,drs2p,drslp,drs1l,drs2l,drsll,zip_code,location&fq=zip_code:XXXXX.type:drs"
    }
}
