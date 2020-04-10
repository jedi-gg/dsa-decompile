using Csdk.GluMarketing.Implementation;
using Il2CppDummyDll;
using System;

namespace Csdk.GluMarketing
{
	public class DynamicLinkEvent : ISerializableJsonObject
	{
		[FieldOffset(Offset="0x10")]
		public readonly Url LaunchLink;

		[FieldOffset(Offset="0x18")]
		public readonly Url DeepLink;

		[FieldOffset(Offset="0x20")]
		public readonly Exception Error;

		[Address(RVA="0x21EB5F0", Offset="0x21EB5F0", VA="0x21EB5F0")]
		public DynamicLinkEvent(Url launchLink, Url deepLink, Exception error)
		{
		}

		[Address(RVA="0x21EB630", Offset="0x21EB630", VA="0x21EB630", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x21EB6A8", Offset="0x21EB6A8", VA="0x21EB6A8", Slot="4")]
		public void WriteObject(JsonStringer json)
		{
		}
	}
}