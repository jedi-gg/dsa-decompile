using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public enum AbilityShape : sbyte
	{
		[FieldOffset(Offset="0x0")]
		Invalid,
		[FieldOffset(Offset="0x0")]
		Single,
		[FieldOffset(Offset="0x0")]
		Circle,
		[FieldOffset(Offset="0x0")]
		Line,
		[FieldOffset(Offset="0x0")]
		LineCircle,
		[FieldOffset(Offset="0x0")]
		CustomPreview,
		[FieldOffset(Offset="0x0")]
		FixedLengthLine,
		[FieldOffset(Offset="0x0")]
		SinglePlusColumn,
		[FieldOffset(Offset="0x0")]
		SinglePlusRow,
		[FieldOffset(Offset="0x0")]
		Column,
		[FieldOffset(Offset="0x0")]
		Row,
		[FieldOffset(Offset="0x0")]
		Cross,
		[FieldOffset(Offset="0x0")]
		GridSquare,
		[FieldOffset(Offset="0x0")]
		RowInFrontOfCaster,
		[FieldOffset(Offset="0x0")]
		Plus
	}
}