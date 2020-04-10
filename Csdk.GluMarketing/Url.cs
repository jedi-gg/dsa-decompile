using Csdk.GluMarketing.Implementation;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluMarketing
{
	public class Url : ISerializableJsonObject
	{
		[FieldOffset(Offset="0x10")]
		public readonly string FullUrl;

		[FieldOffset(Offset="0x18")]
		public readonly string Scheme;

		[FieldOffset(Offset="0x20")]
		public readonly string Host;

		[FieldOffset(Offset="0x28")]
		public readonly string Path;

		[FieldOffset(Offset="0x30")]
		public readonly Dictionary<string, string> Query;

		[Address(RVA="0x153A490", Offset="0x153A490", VA="0x153A490")]
		public Url(string fullUrl, string scheme, string host, string path, Dictionary<string, string> query)
		{
		}

		[Address(RVA="0x153A600", Offset="0x153A600", VA="0x153A600", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x153A674", Offset="0x153A674", VA="0x153A674", Slot="4")]
		public void WriteObject(JsonStringer json)
		{
		}
	}
}