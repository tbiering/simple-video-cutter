using FFmpeg.NET;
using FFmpeg.NET.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVideoCutter.FFmpegNET
{
    internal class FFmpegArgumentBuilder
    {
        public static string BuildArgumentsCutOperation(string inputFileFullPath, string outputFileFullPath,
            TimeSpan seekStart, TimeSpan seekEnd, string customArguments)
        {
            var commandBuilder = new StringBuilder();
            
            commandBuilder.AppendFormat(" -i \"{0}\" ", inputFileFullPath);
            commandBuilder.AppendFormat(CultureInfo.InvariantCulture, " -ss {0} ", seekStart);
            commandBuilder.AppendFormat(" -to {0} ", seekEnd);
            commandBuilder.AppendFormat(" {0}", customArguments);
            
            return commandBuilder.AppendFormat(" \"{0}\" ", outputFileFullPath).ToString();
        }

    }
}