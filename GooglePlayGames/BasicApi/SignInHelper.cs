using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi
{
	public class SignInHelper
	{
		[FieldOffset(Offset="0x0")]
		private static int True;

		[FieldOffset(Offset="0x4")]
		private static int False;

		[FieldOffset(Offset="0x0")]
		private const string PromptSignInKey = "prompt_sign_in";

		[Address(RVA="0x12D2E80", Offset="0x12D2E80", VA="0x12D2E80")]
		static SignInHelper()
		{
		}

		[Address(RVA="0x12D2E78", Offset="0x12D2E78", VA="0x12D2E78")]
		public SignInHelper()
		{
		}

		[Address(RVA="0x12D2D3C", Offset="0x12D2D3C", VA="0x12D2D3C")]
		public static void SetPromptUiSignIn(bool value)
		{
		}

		[Address(RVA="0x12D2DE8", Offset="0x12D2DE8", VA="0x12D2DE8")]
		public static bool ShouldPromptUiSignIn()
		{
			return new bool();
		}

		[Address(RVA="0x12D2A50", Offset="0x12D2A50", VA="0x12D2A50")]
		public static SignInStatus ToSignInStatus(int code)
		{
			return new SignInStatus();
		}
	}
}