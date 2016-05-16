using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.OverlayTypes
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class Point
	{
		/// <summary>
		/// Gets or sets X
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double X { get; set; }
		/// <summary>
		/// Gets or sets Y
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double Y { get; set; }
	}
}
