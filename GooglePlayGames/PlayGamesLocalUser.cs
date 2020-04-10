using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using System;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesLocalUser : PlayGamesUserProfile, ILocalUser, IUserProfile
	{
		[FieldOffset(Offset="0x38")]
		internal PlayGamesPlatform mPlatform;

		[FieldOffset(Offset="0x40")]
		private string emailAddress;

		[FieldOffset(Offset="0x48")]
		private PlayerStats mStats;

		public bool authenticated
		{
			[Address(RVA="0x12D8E9C", Offset="0x12D8E9C", VA="0x12D8E9C", Slot="10")]
			get
			{
				return new bool();
			}
		}

		public new string AvatarURL
		{
			[Address(RVA="0x12D9504", Offset="0x12D9504", VA="0x12D9504")]
			get
			{
				return null;
			}
		}

		public string Email
		{
			[Address(RVA="0x12D95F8", Offset="0x12D95F8", VA="0x12D95F8")]
			get
			{
				return null;
			}
		}

		public IUserProfile[] friends
		{
			[Address(RVA="0x12D8C44", Offset="0x12D8C44", VA="0x12D8C44", Slot="13")]
			get
			{
				return null;
			}
		}

		public new string id
		{
			[Address(RVA="0x12D93F8", Offset="0x12D93F8", VA="0x12D93F8", Slot="4")]
			get
			{
				return null;
			}
		}

		public new bool isFriend
		{
			[Address(RVA="0x12D94F4", Offset="0x12D94F4", VA="0x12D94F4", Slot="16")]
			get
			{
				return new bool();
			}
		}

		public new UserState state
		{
			[Address(RVA="0x12D94FC", Offset="0x12D94FC", VA="0x12D94FC", Slot="17")]
			get
			{
				return new UserState();
			}
		}

		public bool underage
		{
			[Address(RVA="0x12D8F88", Offset="0x12D8F88", VA="0x12D8F88", Slot="14")]
			get
			{
				return new bool();
			}
		}

		public new string userName
		{
			[Address(RVA="0x12D8F90", Offset="0x12D8F90", VA="0x12D8F90", Slot="15")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x12D8768", Offset="0x12D8768", VA="0x12D8768")]
		internal PlayGamesLocalUser(PlayGamesPlatform plaf)
		{
		}

		[Address(RVA="0x12D8840", Offset="0x12D8840", VA="0x12D8840", Slot="11")]
		public void Authenticate(Action<bool> callback)
		{
		}

		[Address(RVA="0x12D8880", Offset="0x12D8880", VA="0x12D8880", Slot="9")]
		public void Authenticate(Action<bool, string> callback)
		{
		}

		[Address(RVA="0x12D88C0", Offset="0x12D88C0", VA="0x12D88C0")]
		public void Authenticate(Action<bool> callback, bool silent)
		{
		}

		[Address(RVA="0x12D89C0", Offset="0x12D89C0", VA="0x12D89C0")]
		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		[Address(RVA="0x12D8D80", Offset="0x12D8D80", VA="0x12D8D80")]
		public string GetIdToken()
		{
			return null;
		}

		[Address(RVA="0x12D976C", Offset="0x12D976C", VA="0x12D976C")]
		public void GetStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		[Address(RVA="0x12D8AD4", Offset="0x12D8AD4", VA="0x12D8AD4", Slot="12")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E5F8", Offset="0x104E5F8")]
		private sealed class <>c__DisplayClass28_0
		{
			[FieldOffset(Offset="0x10")]
			public PlayGamesLocalUser <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action<CommonStatusCodes, PlayerStats> callback;

			[Address(RVA="0x12D988C", Offset="0x12D988C", VA="0x12D988C")]
			public <>c__DisplayClass28_0()
			{
			}

			[Address(RVA="0x12D9A50", Offset="0x12D9A50", VA="0x12D9A50")]
			internal void <GetStats>b__0(CommonStatusCodes rc, PlayerStats stats)
			{
			}
		}
	}
}