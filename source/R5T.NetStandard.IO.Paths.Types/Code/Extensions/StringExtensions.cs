﻿using System;


namespace R5T.NetStandard.IO.Paths.Extensions
{
    public static class StringExtensions
    {
        public static AbsolutePath AsAbsolutePath(this string value)
        {
            var absolutePath = new GeneralAbsolutePath(value);
            return absolutePath;
        }

        public static DirectoryName AsDirectoryName(this string value)
        {
            var directoryName = new DirectoryName(value);
            return directoryName;
        }

        public static DirectoryNameSegment AsDirectoryNameSegment(this string value)
        {
            var directoryNameSegment = new GeneralDirectoryNameSegment(value);
            return directoryNameSegment;
        }

        public static DirectoryPath AsDirectoryPath(this string value)
        {
            var directoryPath = new DirectoryPath(value);
            return directoryPath;
        }

        public static DirectorySeparator AsDirectorySeparator(this string value)
        {
            var directorySeparator = new DirectorySeparator(value);
            return directorySeparator;
        }

        public static DirectoryRelativePath AsDirectoryRelativePath(this string value)
        {
            var directoryRelativePath = new DirectoryRelativePath(value);
            return directoryRelativePath;
        }

        public static FileExtension AsFileExtension(this string value)
        {
            var fileExtension = new FileExtension(value);
            return fileExtension;
        }

        public static FileName AsFileName(this string value)
        {
            var fileName = new FileName(value);
            return fileName;
        }

        public static FileNameSegment AsFileNameSegment(this string value)
        {
            var fileNameSegment = new GeneralFileNameSegment(value);
            return fileNameSegment;
        }

        public static FileNameSegmentSeparator AsFileNameSegmentSeparator(this string value)
        {
            var fileNameSegmentSeparator = new FileNameSegmentSeparator(value);
            return fileNameSegmentSeparator;
        }

        public static FileNameWithoutExtension AsFileNameWithoutExtension(this string value)
        {
            var fileNameWithoutExtension = new FileNameWithoutExtension(value);
            return fileNameWithoutExtension;
        }

        public static FilePath AsFilePath(this string value)
        {
            var filePath = new FilePath(value);
            return filePath;
        }

        public static FileRelativePath AsFileRelativePath(this string value)
        {
            var fileRelativePath = new FileRelativePath(value);
            return fileRelativePath;
        }

        public static PathSegment AsPathSegment(this string value)
        {
            var pathSegment = new GeneralPathSegment(value);
            return pathSegment;
        }

        public static Root AsRoot(this string value)
        {
            var root = new Root(value);
            return root;
        }
    }
}
