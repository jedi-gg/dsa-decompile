using Il2CppDummyDll;
using Serverproto;
using System;

public struct DDailyActivityListItemAction
{
	[FieldOffset(Offset="0x0")]
	public readonly PlayerActivity Activity;

	[Address(RVA="0xF04A2C", Offset="0xF04A2C", VA="0xF04A2C")]
	public DDailyActivityListItemAction(PlayerActivity activity)
	{
	}
}