using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Accessibility
{
	/// <summary>
	/// A node in the accessibility tree.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class AXNode
	{
		/// <summary>
		/// Gets or sets Unique identifier for this node.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string NodeId { get; set; }
		/// <summary>
		/// Gets or sets This <code>Node</code>'s role, whether explicit or implicit.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AXValue Role { get; set; }
		/// <summary>
		/// Gets or sets The accessible name for this <code>Node</code>.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AXValue Name { get; set; }
		/// <summary>
		/// Gets or sets The accessible description for this <code>Node</code>.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AXValue Description { get; set; }
		/// <summary>
		/// Gets or sets The value for this <code>Node</code>.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AXValue Value { get; set; }
		/// <summary>
		/// Gets or sets Help.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AXValue Help { get; set; }
		/// <summary>
		/// Gets or sets All other properties
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AXProperty[] Properties { get; set; }
	}
}
