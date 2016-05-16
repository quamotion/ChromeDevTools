using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Represents metadata of a file or entry.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class Metadata
	{
		/// <summary>
		/// Gets or sets Modification time.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ModificationTime { get; set; }
		/// <summary>
		/// Gets or sets File size. This field is always zero for directories.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Size { get; set; }
	}
}
