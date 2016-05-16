using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns detailed information on given generator object.
	/// </summary>
	[Command(ProtocolName.Debugger.GetGeneratorObjectDetails)]
	[SupportedBy("Chrome-Tip")]
	public class GetGeneratorObjectDetailsCommand
	{
		/// <summary>
		/// Gets or sets Id of the generator object to get details for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ObjectId { get; set; }
	}
}
