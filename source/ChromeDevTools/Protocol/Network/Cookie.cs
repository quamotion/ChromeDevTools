using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Cookie object
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class Cookie
	{
		/// <summary>
		/// Gets or sets Cookie name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Cookie value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets Cookie domain.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Domain { get; set; }
		/// <summary>
		/// Gets or sets Cookie path.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Path { get; set; }
		/// <summary>
		/// Gets or sets Cookie expires.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Expires { get; set; }
		/// <summary>
		/// Gets or sets Cookie size.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Size { get; set; }
		/// <summary>
		/// Gets or sets True if cookie is http-only.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool HttpOnly { get; set; }
		/// <summary>
		/// Gets or sets True if cookie is secure.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Secure { get; set; }
		/// <summary>
		/// Gets or sets True in case of session cookie.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Session { get; set; }
	}
}
