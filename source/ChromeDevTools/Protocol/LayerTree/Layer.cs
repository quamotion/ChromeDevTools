using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Information about a compositing layer.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class Layer
	{
		/// <summary>
		/// Gets or sets The unique id for this layer.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string LayerId { get; set; }
		/// <summary>
		/// Gets or sets The id of parent (not present for root).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ParentLayerId { get; set; }
		/// <summary>
		/// Gets or sets The backend id for the node associated with this layer.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets Offset from parent layer, X coordinate.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double OffsetX { get; set; }
		/// <summary>
		/// Gets or sets Offset from parent layer, Y coordinate.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double OffsetY { get; set; }
		/// <summary>
		/// Gets or sets Layer width.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Width { get; set; }
		/// <summary>
		/// Gets or sets Layer height.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Height { get; set; }
		/// <summary>
		/// Gets or sets Transformation matrix for layer, default is identity matrix
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double[] Transform { get; set; }
		/// <summary>
		/// Gets or sets Transform anchor point X, absent if no transform specified
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double AnchorX { get; set; }
		/// <summary>
		/// Gets or sets Transform anchor point Y, absent if no transform specified
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double AnchorY { get; set; }
		/// <summary>
		/// Gets or sets Transform anchor point Z, absent if no transform specified
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double AnchorZ { get; set; }
		/// <summary>
		/// Gets or sets Indicates how many time this layer has painted.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long PaintCount { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether this layer hosts any content, rather than being used for transform/scrolling purposes only.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool DrawsContent { get; set; }
		/// <summary>
		/// Gets or sets Set if layer is not visible.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Invisible { get; set; }
		/// <summary>
		/// Gets or sets Rectangles scrolling on main thread only.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ScrollRect[] ScrollRects { get; set; }
	}
}
