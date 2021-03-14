using System;
using System.Collections.Generic;

namespace Learn.Kubernetes.MobileTypes.Persistence
{
    public static class MockHealthProbeData
    {

        public static List<HealthProbe> GetMockHealthProbeData() {

            return new List<HealthProbe> {

                new HealthProbe {
                    Id = 1,
                    Name ="Heart beat is Good",
                    Type = "HearBeatStatus"
                }
            };
        }
      
    }
}
