using System;
using System.Collections.Generic;
using Learn.Kubernetes.MobileTypes.Persistence;

namespace Learn.Kubernetes.MobileTypes.Service
{
    public interface IMobileTypeService
    {
        List<MobileType> GetMobileTypes();

        MobileType GetMobileTypesById(int mobileTypeId);

        MobileType GetMobileTypesByName(string name);

    }
}
