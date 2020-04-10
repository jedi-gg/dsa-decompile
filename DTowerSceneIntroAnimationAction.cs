using Il2CppDummyDll;
using System;

public struct DTowerSceneIntroAnimationAction
{
	[FieldOffset(Offset="0x0")]
	public DTowerSceneIntroAnimationAction.State PlayState;

	[Address(RVA="0xEFFAA0", Offset="0xEFFAA0", VA="0xEFFAA0")]
	public DTowerSceneIntroAnimationAction(DTowerSceneIntroAnimationAction.State playState)
	{
	}

	public enum State
	{
		[FieldOffset(Offset="0x0")]
		Started,
		[FieldOffset(Offset="0x0")]
		Ended
	}
}