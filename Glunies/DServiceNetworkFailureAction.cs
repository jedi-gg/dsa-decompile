using Il2CppDummyDll;
using System;

namespace Glunies
{
	public struct DServiceNetworkFailureAction
	{
		[FieldOffset(Offset="0x0")]
		public readonly string Reason;

		[Address(RVA="0xF00CB4", Offset="0xF00CB4", VA="0xF00CB4")]
		public DServiceNetworkFailureAction(string reason)
		{
		}
	}
}