using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace DomainDrivenDesign.Dekra
{
    public class DekraAdaptor : IDekraAdaptor
    {
        public DekraAdaptor(IOptions<DekraAdaptorOptions> options)
        {

        }

        public async Task<RawDekraCalculationResult> GetDekraCalculationAsync(string zip)
        {
            if(string.IsNullOrWhiteSpace(zip))
                throw new ArgumentException(nameof(zip));

            var url = $"https://www.dekra.de/search?fl=id,drs1p,drs2p,drslp,drs1l,drs2l,drsll,zip_code,location&fq=zip_code:{zip}.type:drs";

            using (var httpClient = new HttpClient())
            {
                var content = await httpClient.GetFromJsonAsync<RawDekraCalculationResult>(url);
                return content;
            }

        }

        //public void GetDekraCalculation(string zip)
        //{
        //    //WebClient c = new WebClient();
        //    HttpClient test = new HttpClient();

        //    var client = new HttpClient
        //    {
        //        BaseAddress = new Uri(""),
        //        Timeout = TimeSpan.FromSeconds(5)
        //    };
        //    client.GetFromJsonAsync
        //}
    }
}
