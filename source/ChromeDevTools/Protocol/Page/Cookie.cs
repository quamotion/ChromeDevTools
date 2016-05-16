using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Cookie object
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class Cookie
	{
		/// <summary>
		/// Gets or sets Cookie name.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Cookie value.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets Cookie domain.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Domain { get; set; }
		/// <summary>
		/// Gets or sets Cookie path.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Path { get; set; }
		/// <summary>
		/// Gets or sets Cookie expires.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double Expires { get; set; }
		/// <summary>
		/// Gets or sets Cookie size.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long Size { get; set; }
		/// <summary>
		/// Gets or sets True if cookie is http-only.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool HttpOnly { get; set; }
		/// <summary>
		/// Gets or sets True if cookie is secure.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool Secure { get; set; }
		/// <summary>
		/// Gets or sets True in case of session cookie.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool Session { get; set; }
	}
}
