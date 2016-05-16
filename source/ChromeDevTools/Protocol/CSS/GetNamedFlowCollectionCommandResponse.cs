using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns the Named Flows from the document.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetNamedFlowCollection)]
	[SupportedBy("iOS-9.3")]
	public class GetNamedFlowCollectionCommandResponse
	{
		/// <summary>
		/// Gets or sets An array containing the Named Flows in the document.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public NamedFlow[] NamedFlows { get; set; }
	}
}
