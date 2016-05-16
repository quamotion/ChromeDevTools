using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Database with an array of object stores.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class DatabaseWithObjectStores
	{
		/// <summary>
		/// Gets or sets Database name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Deprecated string database version.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Version { get; set; }
		/// <summary>
		/// Gets or sets Integer database version.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long IntVersion { get; set; }
		/// <summary>
		/// Gets or sets Object stores in this database.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ObjectStore[] ObjectStores { get; set; }
	}
}
