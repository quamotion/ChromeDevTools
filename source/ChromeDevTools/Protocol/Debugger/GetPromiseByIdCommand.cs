using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns <code>Promise</code> with specified ID.
	/// </summary>
	[Command(ProtocolName.Debugger.GetPromiseById)]
	[SupportedBy("Chrome-Tip")]
	public class GetPromiseByIdCommand
	{
		/// <summary>
		/// Gets or sets PromiseId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long PromiseId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name that can be used to release multiple objects.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ObjectGroup { get; set; }
	}
}
