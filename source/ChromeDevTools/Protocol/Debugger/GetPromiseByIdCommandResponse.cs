using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns <code>Promise</code> with specified ID.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetPromiseById)]
	[SupportedBy("Chrome-Tip")]
	public class GetPromiseByIdCommandResponse
	{
		/// <summary>
		/// Gets or sets Object wrapper for <code>Promise</code> with specified ID, if any.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Runtime.RemoteObject Promise { get; set; }
	}
}
