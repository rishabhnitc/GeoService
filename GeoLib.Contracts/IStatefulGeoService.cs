﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GeoLib.Contracts
{
    [ServiceContract]
    public interface IStatefulGeoService
    {
        [OperationContract]
        void PushZip(string zip);
        [OperationContract]
        ZipCodeData GetZipcodeInfo();
        
        [OperationContract(Name = "GetZipsForRange")]
        IEnumerable<ZipCodeData> GetZips( int range);
    }
}
