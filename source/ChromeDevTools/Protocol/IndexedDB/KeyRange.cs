using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IndexedDB
{
	/// <summary>
	/// Key range.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class KeyRange
	{
		/// <summary>
		/// Gets or sets Lower bound.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Key Lower { get; set; }
		/// <summary>
		/// Gets or sets Upper bound.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Key Upper { get; set; }
		/// <summary>
		/// Gets or sets If true lower bound is open.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool LowerOpen { get; set; }
		/// <summary>
		/// Gets or sets If true upper bound is open.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool UpperOpen { get; set; }
	}
}
