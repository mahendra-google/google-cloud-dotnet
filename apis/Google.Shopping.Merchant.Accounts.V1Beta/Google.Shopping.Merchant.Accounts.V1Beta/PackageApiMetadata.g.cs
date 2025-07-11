// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Shopping.Merchant.Accounts.V1Beta", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true);

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AccessrightReflection.Descriptor;
            yield return AccountTaxReflection.Descriptor;
            yield return AccountissueReflection.Descriptor;
            yield return AccountsReflection.Descriptor;
            yield return AccountservicesReflection.Descriptor;
            yield return AutofeedsettingsReflection.Descriptor;
            yield return AutomaticimprovementsReflection.Descriptor;
            yield return BusinessidentityReflection.Descriptor;
            yield return BusinessinfoReflection.Descriptor;
            yield return CheckoutsettingsReflection.Descriptor;
            yield return CustomerserviceReflection.Descriptor;
            yield return EmailpreferencesReflection.Descriptor;
            yield return GbpaccountsReflection.Descriptor;
            yield return HomepageReflection.Descriptor;
            yield return LfpprovidersReflection.Descriptor;
            yield return OmnichannelsettingsReflection.Descriptor;
            yield return OnlineReturnPolicyReflection.Descriptor;
            yield return PhoneverificationstateReflection.Descriptor;
            yield return ProgramsReflection.Descriptor;
            yield return RegionsReflection.Descriptor;
            yield return ShippingsettingsReflection.Descriptor;
            yield return TaxRuleReflection.Descriptor;
            yield return TermsofserviceReflection.Descriptor;
            yield return TermsofserviceagreementstateReflection.Descriptor;
            yield return TermsofservicekindReflection.Descriptor;
            yield return UserReflection.Descriptor;
        }
    }
}
