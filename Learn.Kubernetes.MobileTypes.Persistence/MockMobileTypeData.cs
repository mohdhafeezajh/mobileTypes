using System;
using System.Collections.Generic;

namespace Learn.Kubernetes.MobileTypes.Persistence
{
    public static class MockMobileTypeData
    {

        public static List<MobileType> GenerateMobileTypeMockData()
        {

            var mockMobileType = new List<MobileType>
            {
                new MobileType{
                    MobileTypeId = 1,
                    Name = "Basic",
                    Description = "",
                    IsActive = true

                },
                new MobileType {
                     MobileTypeId = 2,
                    Name = "Featured",
                    Description = "",
                    IsActive = true

                },
                new MobileType {
                     MobileTypeId = 3,
                    Name = "SmartPhone",
                    Description = "",
                    IsActive = true


                }

            };
            return mockMobileType;
        }
     
    }
}
