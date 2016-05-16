using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMStorage
{
	[CommandResponse(ProtocolName.DOMStorage.GetDOMStorageItems)]
	[SupportedBy("Chrome-Tip")]
	public class GetDOMStorageItemsCommandResponse
	{
		/// <summary>
		/// Gets or sets Entries
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string[][] Entries { get; set; }
	}
}
