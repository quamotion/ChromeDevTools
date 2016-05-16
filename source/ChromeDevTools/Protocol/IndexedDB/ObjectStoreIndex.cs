using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Object store index.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ObjectStoreIndex
	{
		/// <summary>
		/// Gets or sets Index name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Index key path.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public KeyPath KeyPath { get; set; }
		/// <summary>
		/// Gets or sets If true, index is unique.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Unique { get; set; }
		/// <summary>
		/// Gets or sets If true, index allows multiple entries for a key.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool MultiEntry { get; set; }
	}
}
