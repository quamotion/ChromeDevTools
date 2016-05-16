using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMStorage
{
	[CommandResponse(ProtocolName.DOMStorage.RemoveDOMStorageItem)]
	[SupportedBy("Chrome-Tip")]
	public class RemoveDOMStorageItemCommandResponse
	{
	}
}
