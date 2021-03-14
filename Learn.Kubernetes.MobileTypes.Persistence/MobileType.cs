using System;

namespace Learn.Kubernetes.MobileTypes.Persistence
{
    public class MobileType
    {
        public int MobileTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string AdditionalDetails { get; set; }

    }
}
