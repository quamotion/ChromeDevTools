using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Represents a browser side file or directory.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class Entry
	{
		/// <summary>
		/// Gets or sets filesystem: URL for the entry.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets The name of the file or directory.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets True if the entry is a directory.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IsDirectory { get; set; }
		/// <summary>
		/// Gets or sets MIME type of the entry, available for a file only.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string MimeType { get; set; }
		/// <summary>
		/// Gets or sets ResourceType of the entry, available for a file only.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Page.ResourceType ResourceType { get; set; }
		/// <summary>
		/// Gets or sets True if the entry is a text file.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IsTextFile { get; set; }
	}
}
