using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.OverlayTypes
{
	/// <summary>
	/// Data that describes an element to be highlighted.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class ElementData
	{
		/// <summary>
		/// Gets or sets TagName
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string TagName { get; set; }
		/// <summary>
		/// Gets or sets The value of the element's 'id' attribute.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string IdValue { get; set; }
		/// <summary>
		/// Gets or sets ClassName
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string ClassName { get; set; }
		/// <summary>
		/// Gets or sets Size
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public Size Size { get; set; }
		/// <summary>
		/// Gets or sets Computed accessibility role for the element.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Role { get; set; }
		/// <summary>
		/// Gets or sets RegionFlowData
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public RegionFlowData RegionFlowData { get; set; }
		/// <summary>
		/// Gets or sets ContentFlowData
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public ContentFlowData ContentFlowData { get; set; }
		/// <summary>
		/// Gets or sets ShapeOutsideData
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public ShapeOutsideData ShapeOutsideData { get; set; }
	}
}
