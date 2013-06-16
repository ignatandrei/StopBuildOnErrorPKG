// Guids.cs
// MUST match guids.h
using System;

namespace IAF.StopBuildOnErrorPKG
{
    static class GuidList
    {
        public const string guidStopBuildOnErrorPKGPkgString = "33236aef-cc53-40f2-9b01-050b754823ac";
        public const string guidStopBuildOnErrorPKGCmdSetString = "2e56c76b-d2af-4c07-a91e-0bf3ed111f1a";

        public static readonly Guid guidStopBuildOnErrorPKGCmdSet = new Guid(guidStopBuildOnErrorPKGCmdSetString);
    };
}