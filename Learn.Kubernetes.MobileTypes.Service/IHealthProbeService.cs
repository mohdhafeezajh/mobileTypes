using System;
namespace Learn.Kubernetes.MobileTypes.Service
{
    public interface IHealthProbeService
    {
        bool HealthProbe();
    }
}
