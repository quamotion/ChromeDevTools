using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Inspector
{
	/// <summary>
	/// Sent by the frontend after all initialization messages have been sent.
	/// </summary>
	[Command(ProtocolName.Inspector.Initialized)]
	[SupportedBy("iOS-9.3")]
	public class InitializedCommand
	{
	}
}
