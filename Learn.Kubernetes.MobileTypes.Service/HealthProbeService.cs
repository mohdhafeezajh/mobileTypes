using System;
using System.Linq;
using Learn.Kubernetes.MobileTypes.Persistence;

namespace Learn.Kubernetes.MobileTypes.Service
{
    public class HealthProbeService: IHealthProbeService
    {
        public bool HealthProbe()
        {
            try
            {
                return MockMobileTypeData.GenerateMobileTypeMockData()
                    .Where(h=>h.MobileTypeId == 1)
                    .Count() > 0
                    ? true : false;

            }
            catch (Exception)
            {

                return false;
            }
         }
    }
}
