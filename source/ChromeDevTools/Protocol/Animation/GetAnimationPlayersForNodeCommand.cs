using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Returns animation players relevant to the node.
	/// </summary>
	[Command(ProtocolName.Animation.GetAnimationPlayersForNode)]
	[SupportedBy("Chrome-Tip")]
	public class GetAnimationPlayersForNodeCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to get animation players for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Include animations from elements subtree.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IncludeSubtreeAnimations { get; set; }
	}
}
