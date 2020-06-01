// Copyright (c) 2020 Sean Terry (seanterry@outlook.com).
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Guidify
{
    /// <summary>
    /// Hashing algorithms available for use with named GUIDs, per RFC 4122.
    /// <see cref="https://tools.ietf.org/html/rfc4122#section-4.3"/>
    /// </summary>

    public enum NamedGuidAlgorithm
    {
        /// <summary>
        /// Uses the SHA-1 hash algorithm to generate the identifier (UUIDv5).
        /// This is the default.
        /// </summary>

        SHA1,

        /// <summary>
        /// Uses the MD5 hash algorithm to generate the identifier (UUIDv3).
        /// </summary>

        MD5,
    }
}
