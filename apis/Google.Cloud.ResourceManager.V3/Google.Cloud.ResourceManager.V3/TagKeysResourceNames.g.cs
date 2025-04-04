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
using gax = Google.Api.Gax;
using gcrv = Google.Cloud.ResourceManager.V3;
using sys = System;

namespace Google.Cloud.ResourceManager.V3
{
    /// <summary>Resource name for the <c>TagKey</c> resource.</summary>
    public sealed partial class TagKeyName : gax::IResourceName, sys::IEquatable<TagKeyName>
    {
        /// <summary>The possible contents of <see cref="TagKeyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>tagKeys/{tag_key}</c>.</summary>
            TagKey = 1,
        }

        private static gax::PathTemplate s_tagKey = new gax::PathTemplate("tagKeys/{tag_key}");

        /// <summary>Creates a <see cref="TagKeyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TagKeyName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TagKeyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TagKeyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="TagKeyName"/> with the pattern <c>tagKeys/{tag_key}</c>.</summary>
        /// <param name="tagKeyId">The <c>TagKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TagKeyName"/> constructed from the provided ids.</returns>
        public static TagKeyName FromTagKey(string tagKeyId) =>
            new TagKeyName(ResourceNameType.TagKey, tagKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagKeyId, nameof(tagKeyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagKeyName"/> with pattern
        /// <c>tagKeys/{tag_key}</c>.
        /// </summary>
        /// <param name="tagKeyId">The <c>TagKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagKeyName"/> with pattern <c>tagKeys/{tag_key}</c>.
        /// </returns>
        public static string Format(string tagKeyId) => FormatTagKey(tagKeyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagKeyName"/> with pattern
        /// <c>tagKeys/{tag_key}</c>.
        /// </summary>
        /// <param name="tagKeyId">The <c>TagKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagKeyName"/> with pattern <c>tagKeys/{tag_key}</c>.
        /// </returns>
        public static string FormatTagKey(string tagKeyId) =>
            s_tagKey.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(tagKeyId, nameof(tagKeyId)));

        /// <summary>Parses the given resource name string into a new <see cref="TagKeyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tagKeys/{tag_key}</c></description></item></list>
        /// </remarks>
        /// <param name="tagKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TagKeyName"/> if successful.</returns>
        public static TagKeyName Parse(string tagKeyName) => Parse(tagKeyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TagKeyName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tagKeys/{tag_key}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TagKeyName"/> if successful.</returns>
        public static TagKeyName Parse(string tagKeyName, bool allowUnparsed) =>
            TryParse(tagKeyName, allowUnparsed, out TagKeyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagKeyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tagKeys/{tag_key}</c></description></item></list>
        /// </remarks>
        /// <param name="tagKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagKeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagKeyName, out TagKeyName result) => TryParse(tagKeyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagKeyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tagKeys/{tag_key}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagKeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagKeyName, bool allowUnparsed, out TagKeyName result)
        {
            gax::GaxPreconditions.CheckNotNull(tagKeyName, nameof(tagKeyName));
            gax::TemplatedResourceName resourceName;
            if (s_tagKey.TryParseName(tagKeyName, out resourceName))
            {
                result = FromTagKey(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tagKeyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TagKeyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string tagKeyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            TagKeyId = tagKeyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TagKeyName"/> class from the component parts of pattern
        /// <c>tagKeys/{tag_key}</c>
        /// </summary>
        /// <param name="tagKeyId">The <c>TagKey</c> ID. Must not be <c>null</c> or empty.</param>
        public TagKeyName(string tagKeyId) : this(ResourceNameType.TagKey, tagKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagKeyId, nameof(tagKeyId)))
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
        /// The <c>TagKey</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TagKeyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.TagKey: return s_tagKey.Expand(TagKeyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TagKeyName);

        /// <inheritdoc/>
        public bool Equals(TagKeyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TagKeyName a, TagKeyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TagKeyName a, TagKeyName b) => !(a == b);
    }

    public partial class TagKey
    {
        /// <summary>
        /// <see cref="gcrv::TagKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::TagKeyName TagKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::TagKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTagKeysRequest
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gax::UnparsedResourceName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTagKeyRequest
    {
        /// <summary>
        /// <see cref="gcrv::TagKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::TagKeyName TagKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::TagKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetNamespacedTagKeyRequest
    {
        /// <summary>
        /// <see cref="gcrv::TagKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::TagKeyName TagKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::TagKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTagKeyRequest
    {
        /// <summary>
        /// <see cref="gcrv::TagKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::TagKeyName TagKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::TagKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
