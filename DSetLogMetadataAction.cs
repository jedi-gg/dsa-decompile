using Il2CppDummyDll;
using System;

public struct DSetLogMetadataAction
{
	[FieldOffset(Offset="0x0")]
	public readonly string Key;

	[FieldOffset(Offset="0x8")]
	public readonly string Value;

	[FieldOffset(Offset="0x10")]
	public readonly bool IsPersistent;

	[Address(RVA="0xEFF318", Offset="0xEFF318", VA="0xEFF318")]
	public DSetLogMetadataAction(string key, string value, bool isPersistent = false)
	{
	}
}