// Copyright (c) 2020 Sean Terry (seanterry@outlook.com).
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Guidify
{
    /// <summary>
    /// Values of the version fields for standard variant GUIDs.
    /// </summary>

    public static class GuidVersions
    {
        /// <summary>
        /// Version 1, based on system time.
        /// </summary>

        public const byte UUIDv1 = 0x10;

        /// <summary>
        /// Version 3, based on an MD5 hash.
        /// </summary>

        public const byte UUIDv3 = 0x30;

        /// <summary>
        /// Version 5, based on an SHA1 hash.
        /// </summary>

        public const byte UUIDv5 = 0x50;
    }
}
