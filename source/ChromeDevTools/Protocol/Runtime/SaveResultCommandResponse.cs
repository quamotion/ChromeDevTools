using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Assign a saved result index to this value.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.SaveResult)]
	[SupportedBy("iOS-9.3")]
	public class SaveResultCommandResponse
	{
		/// <summary>
		/// Gets or sets If the value was saved, this is the $n index that can be used to access the value.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long SavedResultIndex { get; set; }
	}
}
