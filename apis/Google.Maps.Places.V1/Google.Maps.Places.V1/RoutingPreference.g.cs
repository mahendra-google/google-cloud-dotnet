// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/places/v1/routing_preference.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Maps.Places.V1 {

  /// <summary>Holder for reflection information generated from google/maps/places/v1/routing_preference.proto</summary>
  public static partial class RoutingPreferenceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/places/v1/routing_preference.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoutingPreferenceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvbWFwcy9wbGFjZXMvdjEvcm91dGluZ19wcmVmZXJlbmNlLnBy",
            "b3RvEhVnb29nbGUubWFwcy5wbGFjZXMudjEqegoRUm91dGluZ1ByZWZlcmVu",
            "Y2USIgoeUk9VVElOR19QUkVGRVJFTkNFX1VOU1BFQ0lGSUVEEAASEwoPVFJB",
            "RkZJQ19VTkFXQVJFEAESEQoNVFJBRkZJQ19BV0FSRRACEhkKFVRSQUZGSUNf",
            "QVdBUkVfT1BUSU1BTBADQqcBChljb20uZ29vZ2xlLm1hcHMucGxhY2VzLnYx",
            "QhZSb3V0aW5nUHJlZmVyZW5jZVByb3RvUAFaN2Nsb3VkLmdvb2dsZS5jb20v",
            "Z28vbWFwcy9wbGFjZXMvYXBpdjEvcGxhY2VzcGI7cGxhY2VzcGKiAgZHTVBT",
            "VjGqAhVHb29nbGUuTWFwcy5QbGFjZXMuVjHKAhVHb29nbGVcTWFwc1xQbGFj",
            "ZXNcVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Maps.Places.V1.RoutingPreference), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// A set of values that specify factors to take into consideration when
  /// calculating the route.
  /// </summary>
  public enum RoutingPreference {
    /// <summary>
    /// No routing preference specified. Default to `TRAFFIC_UNAWARE`.
    /// </summary>
    [pbr::OriginalName("ROUTING_PREFERENCE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Computes routes without taking live traffic conditions into consideration.
    /// Suitable when traffic conditions don't matter or are not applicable.
    /// Using this value produces the lowest latency.
    /// Note: For [`TravelMode`][google.maps.places.v1.TravelMode]
    /// `DRIVE` and `TWO_WHEELER`, the route and duration chosen are based on road
    /// network and average time-independent traffic conditions, not current road
    /// conditions. Consequently, routes may include roads that are temporarily
    /// closed. Results for a given
    /// request may vary over time due to changes in the road network, updated
    /// average traffic conditions, and the distributed nature of the service.
    /// Results may also vary between nearly-equivalent routes at any time or
    /// frequency.
    /// </summary>
    [pbr::OriginalName("TRAFFIC_UNAWARE")] TrafficUnaware = 1,
    /// <summary>
    /// Calculates routes taking live traffic conditions into consideration.
    /// In contrast to `TRAFFIC_AWARE_OPTIMAL`, some optimizations are applied to
    /// significantly reduce latency.
    /// </summary>
    [pbr::OriginalName("TRAFFIC_AWARE")] TrafficAware = 2,
    /// <summary>
    /// Calculates the routes taking live traffic conditions into consideration,
    /// without applying most performance optimizations. Using this value produces
    /// the highest latency.
    /// </summary>
    [pbr::OriginalName("TRAFFIC_AWARE_OPTIMAL")] TrafficAwareOptimal = 3,
  }

  #endregion

}

#endregion Designer generated code
