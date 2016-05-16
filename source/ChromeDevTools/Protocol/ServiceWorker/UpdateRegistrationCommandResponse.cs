using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[CommandResponse(ProtocolName.ServiceWorker.UpdateRegistration)]
	[SupportedBy("Chrome-Tip")]
	public class UpdateRegistrationCommandResponse
	{
	}
}
