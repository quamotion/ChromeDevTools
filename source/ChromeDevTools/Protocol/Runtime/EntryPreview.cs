using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class EntryPreview
	{
		/// <summary>
		/// Gets or sets Preview of the key. Specified for map-like collection entries.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ObjectPreview Key { get; set; }
		/// <summary>
		/// Gets or sets Preview of the value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ObjectPreview Value { get; set; }
	}
}
