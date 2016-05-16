using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class PropertyPreview
	{
		/// <summary>
		/// Gets or sets Property name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Object type. Accessor means that the property itself is an accessor property.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets User-friendly property value string.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets Nested value preview.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public ObjectPreview ValuePreview { get; set; }
		/// <summary>
		/// Gets or sets Object subtype hint. Specified for <code>object</code> type values only.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Subtype { get; set; }
		/// <summary>
		/// Gets or sets True if this is an internal property.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool Internal { get; set; }
	}
}
