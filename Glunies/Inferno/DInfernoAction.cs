using Il2CppDummyDll;
using System;

namespace Glunies.Inferno
{
	public struct DInfernoAction
	{
		[FieldOffset(Offset="0x0")]
		public DInfernoAction.Type ActionType;

		[Address(RVA="0xF01E9C", Offset="0xF01E9C", VA="0xF01E9C")]
		public DInfernoAction(DInfernoAction.Type actionType)
		{
		}

		public enum Type
		{
			[FieldOffset(Offset="0x0")]
			ReloadAssets
		}
	}
}