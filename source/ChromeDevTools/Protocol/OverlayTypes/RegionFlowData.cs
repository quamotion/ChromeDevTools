using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.OverlayTypes
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class RegionFlowData
	{
		/// <summary>
		/// Gets or sets Regions
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public Region[] Regions { get; set; }
		/// <summary>
		/// Gets or sets Name
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Name { get; set; }
	}
}
