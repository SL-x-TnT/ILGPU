using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILGPU.Runtime.Cuda
{
    public enum CudaFuncAttribute
    {
        MaxThreadsPerBlock,
        SharedSizeBytes,
        ConstSizeBytes,
        LocalSizeBytes,
        NumRegs,
        PTXVersion,
        BinaryVersion,
        CacheModeCA,
        MaxDynamicSharedSizeBytes,
        PreferredSharedMemoryCarveOut,
        ClusterSizeMustBeSet,
        RequiredClusterWidth,
        RequiredCluserHeight,
        RequiredClusterDepth,
        NonPortableClusterSizeAllowed,
        ClusterSchedulingPolictyPreference

    }
}
