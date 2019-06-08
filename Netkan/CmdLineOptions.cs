using CommandLine;

namespace CKAN.NetKAN
{
    /// <summary>
    /// Options for the NetKAN client.
    /// </summary>
    internal class CmdLineOptions
    {
        [Option('v', "verbose", Default = false, HelpText = "Show more of what's going on when running")]
        public bool Verbose { get; set; }

        [Option('d', "debug", Default = false, HelpText = "Show debugging level messages. Implies verbose")]
        public bool Debug { get; set; }

        [Option("debugger", HelpText = "Launch the debugger at start")]
        public bool Debugger { get; set; }

        [Option("outputdir", Default = ".", HelpText = "Output directory")]
        public string OutputDir { get; set; }

        [Option("cachedir", HelpText = "Cache directory for downloaded mods")]
        public string CacheDir { get; set; }

        [Option("github-token", HelpText = "GitHub OAuth token for API access")]
        public string GitHubToken { get; set; }

        [Option("net-useragent", Default = null, HelpText = "Set the default User-Agent string for HTTP requests")]
        public string NetUserAgent { get; set; }

        [Option("releases", Default = "1", HelpText = "Number of releases to inflate, or 'all'")]
        public string Releases { get; set; }

        [Option("prerelease", HelpText = "Index GitHub prereleases")]
        public bool PreRelease { get; set; }

        [Option("overwrite-cache", HelpText = "Overwrite cached files")]
        public bool OverwriteCache { get; set; }

        [Option("version", HelpText = "Display the netkan version number and exit")]
        public bool Version { get; set; }

        // TODO: How do we mark this as required?
        [Value(0)]
        public string File { get; set; }
    }
}
