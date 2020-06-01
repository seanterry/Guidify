// Copyright (c) 2020 Sean Terry (seanterry@outlook.com).
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Guidify
{
    /// <summary>
    /// Variant options for time-based GUIDs.
    /// </summary>

    public enum TimeGuidVariant
    {
        /// <summary>
        /// Standard GUID variant as described in RFC 4122 Section 4.1.2.
        /// https://tools.ietf.org/html/rfc4122#section-4.1.2
        /// </summary>
        
        Standard = 1,

        /// <summary>
        /// Non-standard variant optimized for use in SQL Server clustered indexes.
        /// The values used for these identifiers are transposed so that the time component occupies
        /// the most-significant bytes used by SQL Server.
        /// </summary>
        /// <remarks>
        /// Identifiers in this layout will identify as Variant 0 to avoid collisions with standard 
        /// variant GUIDs.
        /// </remarks>
        
        SqlServer,
    }
}
