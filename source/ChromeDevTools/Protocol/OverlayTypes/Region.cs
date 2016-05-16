using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.OverlayTypes
{
	/// <summary>
	/// A single region in a flow thread.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class Region
	{
		/// <summary>
		/// Gets or sets BorderQuad
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public Point[] BorderQuad { get; set; }
		/// <summary>
		/// Gets or sets IncomingQuad
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public Point[] IncomingQuad { get; set; }
		/// <summary>
		/// Gets or sets OutgoingQuad
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public Point[] OutgoingQuad { get; set; }
		/// <summary>
		/// Gets or sets IsHighlighted
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsHighlighted { get; set; }
	}
}
