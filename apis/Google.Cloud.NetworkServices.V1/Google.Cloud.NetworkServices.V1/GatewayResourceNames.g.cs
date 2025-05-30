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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcnv = Google.Cloud.NetworkServices.V1;
using sys = System;

namespace Google.Cloud.NetworkServices.V1
{
    /// <summary>Resource name for the <c>Gateway</c> resource.</summary>
    public sealed partial class GatewayName : gax::IResourceName, sys::IEquatable<GatewayName>
    {
        /// <summary>The possible contents of <see cref="GatewayName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
            /// </summary>
            ProjectLocationGateway = 1,
        }

        private static gax::PathTemplate s_projectLocationGateway = new gax::PathTemplate("projects/{project}/locations/{location}/gateways/{gateway}");

        /// <summary>Creates a <see cref="GatewayName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GatewayName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GatewayName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GatewayName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GatewayName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GatewayName"/> constructed from the provided ids.</returns>
        public static GatewayName FromProjectLocationGateway(string projectId, string locationId, string gatewayId) =>
            new GatewayName(ResourceNameType.ProjectLocationGateway, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gatewayId: gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string gatewayId) =>
            FormatProjectLocationGateway(projectId, locationId, gatewayId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </returns>
        public static string FormatProjectLocationGateway(string projectId, string locationId, string gatewayId) =>
            s_projectLocationGateway.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)));

        /// <summary>Parses the given resource name string into a new <see cref="GatewayName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/gateways/{gateway}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="gatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GatewayName"/> if successful.</returns>
        public static GatewayName Parse(string gatewayName) => Parse(gatewayName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GatewayName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/gateways/{gateway}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GatewayName"/> if successful.</returns>
        public static GatewayName Parse(string gatewayName, bool allowUnparsed) =>
            TryParse(gatewayName, allowUnparsed, out GatewayName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GatewayName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/gateways/{gateway}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="gatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GatewayName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gatewayName, out GatewayName result) => TryParse(gatewayName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GatewayName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/gateways/{gateway}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GatewayName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gatewayName, bool allowUnparsed, out GatewayName result)
        {
            gax::GaxPreconditions.CheckNotNull(gatewayName, nameof(gatewayName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGateway.TryParseName(gatewayName, out resourceName))
            {
                result = FromProjectLocationGateway(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(gatewayName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GatewayName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string gatewayId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GatewayId = gatewayId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GatewayName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        public GatewayName(string projectId, string locationId, string gatewayId) : this(ResourceNameType.ProjectLocationGateway, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gatewayId: gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Gateway</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string GatewayId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationGateway: return s_projectLocationGateway.Expand(ProjectId, LocationId, GatewayId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GatewayName);

        /// <inheritdoc/>
        public bool Equals(GatewayName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GatewayName a, GatewayName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GatewayName a, GatewayName b) => !(a == b);
    }

    public partial class Gateway
    {
        /// <summary>
        /// <see cref="gcnv::GatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::GatewayName GatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::GatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGatewaysRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetGatewayRequest
    {
        /// <summary>
        /// <see cref="gcnv::GatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::GatewayName GatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::GatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGatewayRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGatewayRequest
    {
        /// <summary>
        /// <see cref="gcnv::GatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::GatewayName GatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::GatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
