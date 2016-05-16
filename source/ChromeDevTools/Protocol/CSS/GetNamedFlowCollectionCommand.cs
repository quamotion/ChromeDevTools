using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns the Named Flows from the document.
	/// </summary>
	[Command(ProtocolName.CSS.GetNamedFlowCollection)]
	[SupportedBy("iOS-9.3")]
	public class GetNamedFlowCollectionCommand
	{
		/// <summary>
		/// Gets or sets The document node id for which to get the Named Flow Collection.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long DocumentNodeId { get; set; }
	}
}
