using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Object containing abbreviated remote object value.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ObjectPreview
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
		/// Gets or sets String representation of the object.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Description { get; set; }
		/// <summary>
		/// Gets or sets Determines whether preview is lossless (contains all information of the original object).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Lossless { get; set; }
		/// <summary>
		/// Gets or sets True iff some of the properties or entries of the original object did not fit.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Overflow { get; set; }
		/// <summary>
		/// Gets or sets List of the properties.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public PropertyPreview[] Properties { get; set; }
		/// <summary>
		/// Gets or sets List of the entries. Specified for <code>map</code> and <code>set</code> subtype values only.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public EntryPreview[] Entries { get; set; }
	}
}
