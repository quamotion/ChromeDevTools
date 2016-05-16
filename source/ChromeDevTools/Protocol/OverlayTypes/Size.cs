using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.OverlayTypes
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class Size
	{
		/// <summary>
		/// Gets or sets Width
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long Width { get; set; }
		/// <summary>
		/// Gets or sets Height
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long Height { get; set; }
	}
}
