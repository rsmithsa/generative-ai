#if NET472_OR_GREATER || NETSTANDARD2_0
using System;
using System.Collections.Generic;
#endif
using System.Diagnostics;

namespace Mscc.GenerativeAI
{
    /// <summary>
    /// Response from ListFiles method containing a paginated list of Files.
    /// </summary>
    public class ListFilesResponse
    {
        /// <summary>
        /// The list of Files.
        /// </summary>
        public List<FileResource>? Files { get; set; }
        /// <summary>
        /// A token, which can be sent as pageToken to retrieve the next page.
        /// If this field is omitted, there are no more pages.
        /// </summary>
        public string? NextPageToken { get; set; }
    }

    /// <summary>
    /// A file uploaded to the API.
    /// </summary>
    [DebuggerDisplay("{Name} ({MimeType})")]
    public class FileResponse : FileResource { }
}