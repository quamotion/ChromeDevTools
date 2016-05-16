using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Mirror object referencing original JavaScript object.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class RemoteObject
	{
		/// <summary>
		/// Gets or sets Object type.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Object subtype hint. Specified for <code>object</code> type values only.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Subtype { get; set; }
		/// <summary>
		/// Gets or sets Object class (constructor) name. Specified for <code>object</code> type values only.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ClassName { get; set; }
		/// <summary>
		/// Gets or sets Remote object value in case of primitive values or JSON values (if it was requested), or description string if the value can not be JSON-stringified (like NaN, Infinity, -Infinity, -0).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public object Value { get; set; }
		/// <summary>
		/// Gets or sets String representation of the object.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Description { get; set; }
		/// <summary>
		/// Gets or sets Unique object identifier (for non-primitive values).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets Preview containing abbreviated property values. Specified for <code>object</code> type values only.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ObjectPreview Preview { get; set; }
		/// <summary>
		/// Gets or sets CustomPreview
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CustomPreview CustomPreview { get; set; }
	}
}
