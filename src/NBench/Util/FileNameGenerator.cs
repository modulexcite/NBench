﻿using System;
using System.IO;

namespace NBench.Util
{
    public class FileNameGenerator
    {
        public static string GenerateFileName(string benchmarkName, string fileExtension)
        {
            return GenerateFileName(benchmarkName, fileExtension, DateTime.UtcNow);
        }

        public static string GenerateFileName(string benchmarkName, string fileExtension, DateTime utcNow)
        {
            return string.Format("{0}-{1}{2}", benchmarkName, utcNow.Ticks, fileExtension);
        }

        public static string GenerateFileName(string folderPath, string benchmarkName, string fileExtension, DateTime utcNow)
        {
            if (string.IsNullOrEmpty(folderPath))
                return GenerateFileName(benchmarkName, fileExtension, utcNow);
            return Path.Combine(folderPath, GenerateFileName(benchmarkName, fileExtension, utcNow));
        }
    }
}
