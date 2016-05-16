using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMStorage
{
	[Command(ProtocolName.DOMStorage.SetDOMStorageItem)]
	[SupportedBy("Chrome-Tip")]
	public class SetDOMStorageItemCommand
	{
		/// <summary>
		/// Gets or sets StorageId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public StorageId StorageId { get; set; }
		/// <summary>
		/// Gets or sets Key
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Key { get; set; }
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Value { get; set; }
	}
}
