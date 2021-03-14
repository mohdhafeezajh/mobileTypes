using System.Collections.Generic;
using System.Linq;
using Learn.Kubernetes.MobileTypes.Persistence;

namespace Learn.Kubernetes.MobileTypes.Service
{
    public class MobileTypeService : IMobileTypeService
    {
        public List<MobileType> GetMobileTypes()
        {
            return MockMobileTypeData.GenerateMobileTypeMockData();
        }

        public MobileType GetMobileTypesById(int mobileTypeId)
        {
            return MockMobileTypeData.GenerateMobileTypeMockData()
                .Where(m => m.MobileTypeId == mobileTypeId)
                .FirstOrDefault();
        }

        public MobileType GetMobileTypesByName(string name)
        {
            return MockMobileTypeData.GenerateMobileTypeMockData()
                          .Where(m => m.Name == name)
                          .FirstOrDefault();
        }
    }
}
