using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMStorage
{
	/// <summary>
	/// DOM Storage identifier.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class StorageId
	{
		/// <summary>
		/// Gets or sets Security origin for the storage.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets Whether the storage is local storage (not session storage).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IsLocalStorage { get; set; }
	}
}
