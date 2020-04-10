using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesUserProfile : IUserProfile
	{
		[FieldOffset(Offset="0x10")]
		private string mDisplayName;

		[FieldOffset(Offset="0x18")]
		private string mPlayerId;

		[FieldOffset(Offset="0x20")]
		private string mAvatarUrl;

		[FieldOffset(Offset="0x28")]
		private bool mImageLoading;

		[FieldOffset(Offset="0x30")]
		private Texture2D mImage;

		public string AvatarURL
		{
			[Address(RVA="0x12DF6D0", Offset="0x12DF6D0", VA="0x12DF6D0")]
			get
			{
				return null;
			}
		}

		public string gameId
		{
			[Address(RVA="0x12DF590", Offset="0x12DF590", VA="0x12DF590")]
			get
			{
				return null;
			}
		}

		public string id
		{
			[Address(RVA="0x12D94EC", Offset="0x12D94EC", VA="0x12D94EC", Slot="4")]
			get
			{
				return null;
			}
		}

		public Texture2D image
		{
			[Address(RVA="0x12DF5A8", Offset="0x12DF5A8", VA="0x12DF5A8", Slot="8")]
			get
			{
				return null;
			}
		}

		public bool isFriend
		{
			[Address(RVA="0x12DF598", Offset="0x12DF598", VA="0x12DF598", Slot="6")]
			get
			{
				return new bool();
			}
		}

		public UserState state
		{
			[Address(RVA="0x12DF5A0", Offset="0x12DF5A0", VA="0x12DF5A0", Slot="7")]
			get
			{
				return new UserState();
			}
		}

		public string userName
		{
			[Address(RVA="0x12D9198", Offset="0x12D9198", VA="0x12D9198", Slot="5")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x12D87F8", Offset="0x12D87F8", VA="0x12D87F8")]
		internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl)
		{
		}

		[Address(RVA="0x12DF778", Offset="0x12DF778", VA="0x12DF778", Slot="0")]
		public override bool Equals(object obj)
		{
			return new bool();
		}

		[Address(RVA="0x12DF884", Offset="0x12DF884", VA="0x12DF884", Slot="2")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x12DF6D8", Offset="0x12DF6D8", VA="0x12DF6D8")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10750C8", Offset="0x10750C8")]
		internal IEnumerator LoadImage()
		{
			return null;
		}

		[Address(RVA="0x12D93B0", Offset="0x12D93B0", VA="0x12D93B0")]
		protected void ResetIdentity(string displayName, string playerId, string avatarUrl)
		{
		}

		[Address(RVA="0x12DF940", Offset="0x12DF940", VA="0x12DF940", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E6F8", Offset="0x104E6F8")]
		private sealed class <LoadImage>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private object <>2__current;

			[FieldOffset(Offset="0x20")]
			public PlayGamesUserProfile <>4__this;

			[FieldOffset(Offset="0x28")]
			private UnityWebRequest <www>5__2;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA="0x12DFBB8", Offset="0x12DFBB8", VA="0x12DFBB8", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x12DFC28", Offset="0x12DFC28", VA="0x12DFC28", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x12DF74C", Offset="0x12DF74C", VA="0x12DF74C")]
			[DebuggerHidden]
			public <LoadImage>d__21(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x12DF998", Offset="0x12DF998", VA="0x12DF998", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x12DFBC0", Offset="0x12DFBC0", VA="0x12DFBC0", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x12DF994", Offset="0x12DF994", VA="0x12DF994", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}