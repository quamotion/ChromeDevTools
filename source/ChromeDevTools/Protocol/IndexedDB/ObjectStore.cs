using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Object store.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ObjectStore
	{
		/// <summary>
		/// Gets or sets Object store name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Object store key path.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public KeyPath KeyPath { get; set; }
		/// <summary>
		/// Gets or sets If true, object store has auto increment flag set.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool AutoIncrement { get; set; }
		/// <summary>
		/// Gets or sets Indexes in this object store.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ObjectStoreIndex[] Indexes { get; set; }
	}
}
