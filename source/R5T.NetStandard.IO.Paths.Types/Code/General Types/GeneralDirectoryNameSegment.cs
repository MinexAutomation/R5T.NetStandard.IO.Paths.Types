﻿using System;


namespace R5T.NetStandard.IO.Paths
{
    /// <summary>
    /// Usually directory name segments will be strongly-typed to communicate some specific piece of information and derive from <see cref="DirectoryNameSegment"/>.
    /// But a client may want to create segmented directory names without deriving their own directory name segment type. This generic directory name segment type allows that.
    /// </summary>
    /// <remarks>
    /// The class is sealed. To create your own directory name segment type, derive from <see cref="DirectoryNameSegment"/>.
    /// </remarks>
    public sealed class GeneralDirectoryNameSegment : DirectoryNameSegment
    {
        public GeneralDirectoryNameSegment(string value)
            : base(value)
        {
        }
    }
}
