using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Capture a snapshot of the page within the specified rectangle and coordinate system.
	/// </summary>
	[Command(ProtocolName.Page.SnapshotRect)]
	[SupportedBy("iOS-9.3")]
	public class SnapshotRectCommand
	{
		/// <summary>
		/// Gets or sets X coordinate
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long Y { get; set; }
		/// <summary>
		/// Gets or sets Rectangle width
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long Width { get; set; }
		/// <summary>
		/// Gets or sets Rectangle height
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long Height { get; set; }
		/// <summary>
		/// Gets or sets Indicates the coordinate system of the supplied rectangle.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string CoordinateSystem { get; set; }
	}
}
