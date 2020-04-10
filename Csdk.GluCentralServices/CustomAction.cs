using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluCentralServices
{
	public struct CustomAction
	{
		[FieldOffset(Offset="0x0")]
		public string Action;

		[FieldOffset(Offset="0x8")]
		public IDictionary<string, string> Data;
	}
}