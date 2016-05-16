using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Returns event listeners of the given object.
	/// </summary>
	[Command(ProtocolName.Runtime.GetEventListeners)]
	[SupportedBy("Chrome-Tip")]
	public class GetEventListenersCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the object to return listeners for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name for handler value. Handler value is not returned without this parameter specified.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ObjectGroup { get; set; }
	}
}
