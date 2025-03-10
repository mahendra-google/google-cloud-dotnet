// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/accelerator_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/accelerator_type.proto</summary>
  public static partial class AcceleratorTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/accelerator_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AcceleratorTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9hY2NlbGVyYXRvcl90eXBl",
            "LnByb3RvEhpnb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MSrOAgoPQWNjZWxl",
            "cmF0b3JUeXBlEiAKHEFDQ0VMRVJBVE9SX1RZUEVfVU5TUEVDSUZJRUQQABIY",
            "ChBOVklESUFfVEVTTEFfSzgwEAEaAggBEhUKEU5WSURJQV9URVNMQV9QMTAw",
            "EAISFQoRTlZJRElBX1RFU0xBX1YxMDAQAxITCg9OVklESUFfVEVTTEFfUDQQ",
            "BBITCg9OVklESUFfVEVTTEFfVDQQBRIVChFOVklESUFfVEVTTEFfQTEwMBAI",
            "EhQKEE5WSURJQV9BMTAwXzgwR0IQCRINCglOVklESUFfTDQQCxIUChBOVklE",
            "SUFfSDEwMF84MEdCEA0SGQoVTlZJRElBX0gxMDBfTUVHQV84MEdCEA4SCgoG",
            "VFBVX1YyEAYSCgoGVFBVX1YzEAcSDgoKVFBVX1Y0X1BPRBAKEhIKDlRQVV9W",
            "NV9MSVRFUE9EEAxC0gEKHmNvbS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52",
            "MUIUQWNjZWxlcmF0b3JUeXBlUHJvdG9QAVo+Y2xvdWQuZ29vZ2xlLmNvbS9n",
            "by9haXBsYXRmb3JtL2FwaXYxL2FpcGxhdGZvcm1wYjthaXBsYXRmb3JtcGKq",
            "AhpHb29nbGUuQ2xvdWQuQUlQbGF0Zm9ybS5WMcoCGkdvb2dsZVxDbG91ZFxB",
            "SVBsYXRmb3JtXFYx6gIdR29vZ2xlOjpDbG91ZDo6QUlQbGF0Zm9ybTo6VjFi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.AIPlatform.V1.AcceleratorType), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Represents a hardware accelerator type.
  /// </summary>
  public enum AcceleratorType {
    /// <summary>
    /// Unspecified accelerator type, which means no accelerator.
    /// </summary>
    [pbr::OriginalName("ACCELERATOR_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Deprecated: Nvidia Tesla K80 GPU has reached end of support,
    /// see https://cloud.google.com/compute/docs/eol/k80-eol.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [pbr::OriginalName("NVIDIA_TESLA_K80")] NvidiaTeslaK80 = 1,
    /// <summary>
    /// Nvidia Tesla P100 GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_TESLA_P100")] NvidiaTeslaP100 = 2,
    /// <summary>
    /// Nvidia Tesla V100 GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_TESLA_V100")] NvidiaTeslaV100 = 3,
    /// <summary>
    /// Nvidia Tesla P4 GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_TESLA_P4")] NvidiaTeslaP4 = 4,
    /// <summary>
    /// Nvidia Tesla T4 GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_TESLA_T4")] NvidiaTeslaT4 = 5,
    /// <summary>
    /// Nvidia Tesla A100 GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_TESLA_A100")] NvidiaTeslaA100 = 8,
    /// <summary>
    /// Nvidia A100 80GB GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_A100_80GB")] NvidiaA10080Gb = 9,
    /// <summary>
    /// Nvidia L4 GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_L4")] NvidiaL4 = 11,
    /// <summary>
    /// Nvidia H100 80Gb GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_H100_80GB")] NvidiaH10080Gb = 13,
    /// <summary>
    /// Nvidia H100 Mega 80Gb GPU.
    /// </summary>
    [pbr::OriginalName("NVIDIA_H100_MEGA_80GB")] NvidiaH100Mega80Gb = 14,
    /// <summary>
    /// TPU v2.
    /// </summary>
    [pbr::OriginalName("TPU_V2")] TpuV2 = 6,
    /// <summary>
    /// TPU v3.
    /// </summary>
    [pbr::OriginalName("TPU_V3")] TpuV3 = 7,
    /// <summary>
    /// TPU v4.
    /// </summary>
    [pbr::OriginalName("TPU_V4_POD")] TpuV4Pod = 10,
    /// <summary>
    /// TPU v5.
    /// </summary>
    [pbr::OriginalName("TPU_V5_LITEPOD")] TpuV5Litepod = 12,
  }

  #endregion

}

#endregion Designer generated code
