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
		[SupportedBy("iOS-9.3")]
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
		[SupportedBy("iOS-9.3")]
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
		/// <summary>
		/// Gets or sets The id for the node associated with this layer.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Bounds of the layer in absolute page coordinates.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public IntRect Bounds { get; set; }
		/// <summary>
		/// Gets or sets Estimated memory used by this layer.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long Memory { get; set; }
		/// <summary>
		/// Gets or sets The bounds of the composited layer.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public IntRect CompositedBounds { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether this layer is associated with an element hosted in a shadow tree.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsInShadowTree { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether this layer was used to provide a reflection for the element.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsReflection { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether the layer is attached to a pseudo element that is CSS generated content.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsGeneratedContent { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether the layer was created for a CSS anonymous block or box.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsAnonymous { get; set; }
		/// <summary>
		/// Gets or sets The id for the pseudo element associated with this layer.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string PseudoElementId { get; set; }
		/// <summary>
		/// Gets or sets The name of the CSS pseudo-element that prompted the layer to be generated.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string PseudoElement { get; set; }
	}
}
