using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Releases remote object with given id.
	/// </summary>
	[Command(ProtocolName.Runtime.ReleaseObject)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class ReleaseObjectCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the object to release.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string ObjectId { get; set; }
	}
}
