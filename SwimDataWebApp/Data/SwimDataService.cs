using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SwimDataWebApp.Data
{
    public class SwimDataService
    {

        public Task<SwimDataRecord[]> GetSwimDataAsync()
        {
            SwimDataRecord[] allData = JsonConvert.DeserializeObject<SwimDataRecord[]>(File.ReadAllText("./Data/data.json"));
            return Task.FromResult(allData);
        }


    }
}
