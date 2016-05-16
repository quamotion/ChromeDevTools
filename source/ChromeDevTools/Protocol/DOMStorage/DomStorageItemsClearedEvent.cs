using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOMStorage
{
	[Event(ProtocolName.DOMStorage.DomStorageItemsCleared)]
	[SupportedBy("Chrome-Tip")]
	public class DomStorageItemsClearedEvent
	{
		/// <summary>
		/// Gets or sets StorageId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public StorageId StorageId { get; set; }
	}
}
