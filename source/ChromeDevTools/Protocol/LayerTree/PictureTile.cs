using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Serialized fragment of layer picture along with its offset within the layer.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class PictureTile
	{
		/// <summary>
		/// Gets or sets Offset from owning layer left boundary
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double X { get; set; }
		/// <summary>
		/// Gets or sets Offset from owning layer top boundary
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Y { get; set; }
		/// <summary>
		/// Gets or sets Base64-encoded snapshot data.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Picture { get; set; }
	}
}
