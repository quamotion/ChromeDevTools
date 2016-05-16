using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Returns a list of basic blocks for the given sourceID with information about their text ranges and whether or not they have executed.
	/// </summary>
	[Command(ProtocolName.Runtime.GetBasicBlocks)]
	[SupportedBy("iOS-9.3")]
	public class GetBasicBlocksCommand
	{
		/// <summary>
		/// Gets or sets Indicates which sourceID information is requested for.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string SourceID { get; set; }
	}
}
