using Il2CppDummyDll;
using System;

namespace BattleLib
{
	public struct DBattleLibMetrics
	{
		[FieldOffset(Offset="0x0")]
		public readonly DateTime Time;

		[FieldOffset(Offset="0x8")]
		public readonly uint TotalMem;

		[FieldOffset(Offset="0xC")]
		public readonly float UpdateTimeMs;

		[FieldOffset(Offset="0x10")]
		public readonly int PayloadSize;

		[FieldOffset(Offset="0x14")]
		public bool Dispatched;

		[Address(RVA="0xEFCE48", Offset="0xEFCE48", VA="0xEFCE48")]
		public DBattleLibMetrics(uint totalMem, float updateTimeMs, int payloadSize)
		{
		}
	}
}