using Il2CppDummyDll;
using System;

namespace Csdk.GluCentralServices
{
	public class PayloadResult
	{
		[FieldOffset(Offset="0x10")]
		public readonly string TagName;

		[FieldOffset(Offset="0x18")]
		public readonly string PayloadName;

		[FieldOffset(Offset="0x20")]
		public readonly string PayloadMetadata;

		[FieldOffset(Offset="0x28")]
		public readonly string PayloadPath;

		[Address(RVA="0x21DE494", Offset="0x21DE494", VA="0x21DE494")]
		public PayloadResult(string tagName, string payloadName, string payloadMetadata, string payloadPath)
		{
		}
	}
}