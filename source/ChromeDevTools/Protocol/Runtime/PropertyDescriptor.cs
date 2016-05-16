using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Object property descriptor.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class PropertyDescriptor
	{
		/// <summary>
		/// Gets or sets Property name or symbol description.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets The value associated with the property.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RemoteObject Value { get; set; }
		/// <summary>
		/// Gets or sets True if the value associated with the property may be changed (data descriptors only).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Writable { get; set; }
		/// <summary>
		/// Gets or sets A function which serves as a getter for the property, or <code>undefined</code> if there is no getter (accessor descriptors only).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RemoteObject Get { get; set; }
		/// <summary>
		/// Gets or sets A function which serves as a setter for the property, or <code>undefined</code> if there is no setter (accessor descriptors only).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RemoteObject Set { get; set; }
		/// <summary>
		/// Gets or sets True if the type of this property descriptor may be changed and if the property may be deleted from the corresponding object.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Configurable { get; set; }
		/// <summary>
		/// Gets or sets True if this property shows up during enumeration of the properties on the corresponding object.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Enumerable { get; set; }
		/// <summary>
		/// Gets or sets True if the result was thrown during the evaluation.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool WasThrown { get; set; }
		/// <summary>
		/// Gets or sets True if the property is owned for the object.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IsOwn { get; set; }
		/// <summary>
		/// Gets or sets Property symbol object, if the property is of the <code>symbol</code> type.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RemoteObject Symbol { get; set; }
	}
}
