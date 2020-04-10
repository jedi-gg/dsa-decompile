using GooglePlayGames.BasicApi.Multiplayer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace GooglePlayGames.BasicApi
{
	public struct PlayGamesClientConfiguration
	{
		[FieldOffset(Offset="0x0")]
		public readonly static PlayGamesClientConfiguration DefaultConfiguration;

		[FieldOffset(Offset="0x0")]
		private readonly bool mEnableSavedGames;

		[FieldOffset(Offset="0x8")]
		private readonly string[] mScopes;

		[FieldOffset(Offset="0x10")]
		private readonly bool mRequestAuthCode;

		[FieldOffset(Offset="0x11")]
		private readonly bool mForceRefresh;

		[FieldOffset(Offset="0x12")]
		private readonly bool mHidePopups;

		[FieldOffset(Offset="0x13")]
		private readonly bool mRequestEmail;

		[FieldOffset(Offset="0x14")]
		private readonly bool mRequestIdToken;

		[FieldOffset(Offset="0x18")]
		private readonly string mAccountName;

		[FieldOffset(Offset="0x20")]
		private readonly InvitationReceivedDelegate mInvitationDelegate;

		[FieldOffset(Offset="0x28")]
		private readonly GooglePlayGames.BasicApi.Multiplayer.MatchDelegate mMatchDelegate;

		public string AccountName
		{
			[Address(RVA="0xF2FF80", Offset="0xF2FF80", VA="0xF2FF80")]
			get
			{
				return null;
			}
		}

		public bool EnableSavedGames
		{
			[Address(RVA="0xF2FF50", Offset="0xF2FF50", VA="0xF2FF50")]
			get
			{
				return new bool();
			}
		}

		public InvitationReceivedDelegate InvitationDelegate
		{
			[Address(RVA="0xF2FF90", Offset="0xF2FF90", VA="0xF2FF90")]
			get
			{
				return null;
			}
		}

		public bool IsForcingRefresh
		{
			[Address(RVA="0xF2FF68", Offset="0xF2FF68", VA="0xF2FF68")]
			get
			{
				return new bool();
			}
		}

		public bool IsHidingPopups
		{
			[Address(RVA="0xF2FF58", Offset="0xF2FF58", VA="0xF2FF58")]
			get
			{
				return new bool();
			}
		}

		public bool IsRequestingAuthCode
		{
			[Address(RVA="0xF2FF60", Offset="0xF2FF60", VA="0xF2FF60")]
			get
			{
				return new bool();
			}
		}

		public bool IsRequestingEmail
		{
			[Address(RVA="0xF2FF70", Offset="0xF2FF70", VA="0xF2FF70")]
			get
			{
				return new bool();
			}
		}

		public bool IsRequestingIdToken
		{
			[Address(RVA="0xF2FF78", Offset="0xF2FF78", VA="0xF2FF78")]
			get
			{
				return new bool();
			}
		}

		public GooglePlayGames.BasicApi.Multiplayer.MatchDelegate MatchDelegate
		{
			[Address(RVA="0xF2FF98", Offset="0xF2FF98", VA="0xF2FF98")]
			get
			{
				return null;
			}
		}

		public string[] Scopes
		{
			[Address(RVA="0xF2FF88", Offset="0xF2FF88", VA="0xF2FF88")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EC713C", Offset="0x1EC713C", VA="0x1EC713C")]
		static PlayGamesClientConfiguration()
		{
		}

		[Address(RVA="0xF2FF48", Offset="0xF2FF48", VA="0xF2FF48")]
		private PlayGamesClientConfiguration(PlayGamesClientConfiguration.Builder builder)
		{
		}

		[Address(RVA="0xF2FFA8", Offset="0xF2FFA8", VA="0xF2FFA8", Slot="0")]
		public override bool Equals(object obj)
		{
			return new bool();
		}

		[Address(RVA="0xF2FFA0", Offset="0xF2FFA0", VA="0xF2FFA0", Slot="2")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EC6C44", Offset="0x1EC6C44", VA="0x1EC6C44")]
		public static bool operator ==(PlayGamesClientConfiguration c1, PlayGamesClientConfiguration c2)
		{
			return new bool();
		}

		[Address(RVA="0x1EC6D6C", Offset="0x1EC6D6C", VA="0x1EC6D6C")]
		public static bool operator !=(PlayGamesClientConfiguration c1, PlayGamesClientConfiguration c2)
		{
			return new bool();
		}

		public class Builder
		{
			[FieldOffset(Offset="0x10")]
			private bool mEnableSaveGames;

			[FieldOffset(Offset="0x18")]
			private List<string> mScopes;

			[FieldOffset(Offset="0x20")]
			private bool mHidePopups;

			[FieldOffset(Offset="0x21")]
			private bool mRequestAuthCode;

			[FieldOffset(Offset="0x22")]
			private bool mForceRefresh;

			[FieldOffset(Offset="0x23")]
			private bool mRequestEmail;

			[FieldOffset(Offset="0x24")]
			private bool mRequestIdToken;

			[FieldOffset(Offset="0x28")]
			private string mAccountName;

			[FieldOffset(Offset="0x30")]
			private InvitationReceivedDelegate mInvitationDelegate;

			[FieldOffset(Offset="0x38")]
			private GooglePlayGames.BasicApi.Multiplayer.MatchDelegate mMatchDelegate;

			[Address(RVA="0x12D16EC", Offset="0x12D16EC", VA="0x12D16EC")]
			public Builder()
			{
			}

			[Address(RVA="0x12D14A0", Offset="0x12D14A0", VA="0x12D14A0")]
			public PlayGamesClientConfiguration.Builder AddOauthScope(string scope)
			{
				return null;
			}

			[Address(RVA="0x12D1614", Offset="0x12D1614", VA="0x12D1614")]
			public PlayGamesClientConfiguration Build()
			{
				return new PlayGamesClientConfiguration();
			}

			[Address(RVA="0x12D1460", Offset="0x12D1460", VA="0x12D1460")]
			public PlayGamesClientConfiguration.Builder EnableHidePopups()
			{
				return null;
			}

			[Address(RVA="0x12D1454", Offset="0x12D1454", VA="0x12D1454")]
			public PlayGamesClientConfiguration.Builder EnableSavedGames()
			{
				return null;
			}

			[Address(RVA="0x12D1664", Offset="0x12D1664", VA="0x12D1664")]
			internal string GetAccountName()
			{
				return null;
			}

			[Address(RVA="0x12D16E4", Offset="0x12D16E4", VA="0x12D16E4")]
			internal InvitationReceivedDelegate GetInvitationDelegate()
			{
				return null;
			}

			[Address(RVA="0x12D16DC", Offset="0x12D16DC", VA="0x12D16DC")]
			internal GooglePlayGames.BasicApi.Multiplayer.MatchDelegate GetMatchDelegate()
			{
				return null;
			}

			[Address(RVA="0x12D166C", Offset="0x12D166C", VA="0x12D166C")]
			internal string[] getScopes()
			{
				return null;
			}

			[Address(RVA="0x12D1634", Offset="0x12D1634", VA="0x12D1634")]
			internal bool HasEnableSaveGames()
			{
				return new bool();
			}

			[Address(RVA="0x12D164C", Offset="0x12D164C", VA="0x12D164C")]
			internal bool IsForcingRefresh()
			{
				return new bool();
			}

			[Address(RVA="0x12D1644", Offset="0x12D1644", VA="0x12D1644")]
			internal bool IsHidingPopups()
			{
				return new bool();
			}

			[Address(RVA="0x12D163C", Offset="0x12D163C", VA="0x12D163C")]
			internal bool IsRequestingAuthCode()
			{
				return new bool();
			}

			[Address(RVA="0x12D1654", Offset="0x12D1654", VA="0x12D1654")]
			internal bool IsRequestingEmail()
			{
				return new bool();
			}

			[Address(RVA="0x12D165C", Offset="0x12D165C", VA="0x12D165C")]
			internal bool IsRequestingIdToken()
			{
				return new bool();
			}

			[Address(RVA="0x12D1480", Offset="0x12D1480", VA="0x12D1480")]
			public PlayGamesClientConfiguration.Builder RequestEmail()
			{
				return null;
			}

			[Address(RVA="0x12D148C", Offset="0x12D148C", VA="0x12D148C")]
			public PlayGamesClientConfiguration.Builder RequestIdToken()
			{
				return null;
			}

			[Address(RVA="0x12D146C", Offset="0x12D146C", VA="0x12D146C")]
			public PlayGamesClientConfiguration.Builder RequestServerAuthCode(bool forceRefresh)
			{
				return null;
			}

			[Address(RVA="0x12D1498", Offset="0x12D1498", VA="0x12D1498")]
			public PlayGamesClientConfiguration.Builder SetAccountName(string accountName)
			{
				return null;
			}

			[Address(RVA="0x12D1544", Offset="0x12D1544", VA="0x12D1544")]
			public PlayGamesClientConfiguration.Builder WithInvitationDelegate(InvitationReceivedDelegate invitationDelegate)
			{
				return null;
			}

			[Address(RVA="0x12D15AC", Offset="0x12D15AC", VA="0x12D15AC")]
			public PlayGamesClientConfiguration.Builder WithMatchDelegate(GooglePlayGames.BasicApi.Multiplayer.MatchDelegate matchDelegate)
			{
				return null;
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051658", Offset="0x1051658")]
			[Serializable]
			private sealed class <>c
			{
				[FieldOffset(Offset="0x0")]
				public readonly static PlayGamesClientConfiguration.Builder.<>c <>9;

				[FieldOffset(Offset="0x8")]
				public static InvitationReceivedDelegate <>9__30_0;

				[FieldOffset(Offset="0x10")]
				public static GooglePlayGames.BasicApi.Multiplayer.MatchDelegate <>9__30_1;

				[Address(RVA="0x12D1860", Offset="0x12D1860", VA="0x12D1860")]
				static <>c()
				{
				}

				[Address(RVA="0x12D18C4", Offset="0x12D18C4", VA="0x12D18C4")]
				public <>c()
				{
				}

				[Address(RVA="0x12D18CC", Offset="0x12D18CC", VA="0x12D18CC")]
				internal void <.ctor>b__30_0(Invitation u003cp0u003e, bool u003cp1u003e)
				{
				}

				[Address(RVA="0x12D18D0", Offset="0x12D18D0", VA="0x12D18D0")]
				internal void <.ctor>b__30_1(TurnBasedMatch u003cp0u003e, bool u003cp1u003e)
				{
				}
			}
		}
	}
}