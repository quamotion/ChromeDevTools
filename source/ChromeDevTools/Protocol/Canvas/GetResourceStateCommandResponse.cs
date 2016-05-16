using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	[CommandResponse(ProtocolName.Canvas.GetResourceState)]
	[SupportedBy("Chrome-Tip")]
	public class GetResourceStateCommandResponse
	{
		/// <summary>
		/// Gets or sets ResourceState
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ResourceState ResourceState { get; set; }
	}
}
