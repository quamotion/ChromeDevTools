using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Assign a saved result index to this value.
	/// </summary>
	[Command(ProtocolName.Runtime.SaveResult)]
	[SupportedBy("iOS-9.3")]
	public class SaveResultCommand
	{
		/// <summary>
		/// Gets or sets Id or value of the object to save.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public CallArgument Value { get; set; }
		/// <summary>
		/// Gets or sets Unique id of the execution context. To specify in which execution context script evaluation should be performed. If not provided, determine from the CallArgument's objectId.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long ContextId { get; set; }
	}
}
