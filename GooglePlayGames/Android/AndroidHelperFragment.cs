using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidHelperFragment
	{
		[FieldOffset(Offset="0x0")]
		private const string HelperFragmentClass = "com.google.games.bridge.HelperFragment";

		[Address(RVA="0x162A708", Offset="0x162A708", VA="0x162A708")]
		public AndroidHelperFragment()
		{
		}

		[Address(RVA="0x162A530", Offset="0x162A530", VA="0x162A530")]
		private static List<string> CreatePlayerIdsToInvite(AndroidJavaObject playerIdsObject)
		{
			return null;
		}

		[Address(RVA="0x1622670", Offset="0x1622670", VA="0x1622670")]
		public static AndroidJavaObject GetActivity()
		{
			return null;
		}

		[Address(RVA="0x1623B40", Offset="0x1623B40", VA="0x1623B40")]
		public static AndroidJavaObject GetDefaultPopupView()
		{
			return null;
		}

		[Address(RVA="0x161EC2C", Offset="0x161EC2C", VA="0x161EC2C")]
		public static void ShowAchievementsUI(Action<UIStatus> cb)
		{
		}

		[Address(RVA="0x161F0AC", Offset="0x161F0AC", VA="0x161F0AC")]
		public static void ShowAllLeaderboardsUI(Action<UIStatus> cb)
		{
		}

		[Address(RVA="0x1628DFC", Offset="0x1628DFC", VA="0x1628DFC")]
		public static void ShowCaptureOverlayUI()
		{
		}

		[Address(RVA="0x1629E00", Offset="0x1629E00", VA="0x1629E00")]
		public static void ShowInboxUI(Action<UIStatus, TurnBasedMatch> cb)
		{
		}

		[Address(RVA="0x162A198", Offset="0x162A198", VA="0x162A198")]
		public static void ShowInvitationInboxUI(Action<UIStatus, Invitation> cb)
		{
		}

		[Address(RVA="0x161F440", Offset="0x161F440", VA="0x161F440")]
		public static void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan timeSpan, Action<UIStatus> cb)
		{
		}

		[Address(RVA="0x1629510", Offset="0x1629510", VA="0x1629510")]
		public static void ShowRtmpSelectOpponentsUI(uint minOpponents, uint maxOpponents, Action<UIStatus, AndroidHelperFragment.InvitationResultHolder> cb)
		{
		}

		[Address(RVA="0x1629520", Offset="0x1629520", VA="0x1629520")]
		private static void ShowSelectOpponentsUI(uint minOpponents, uint maxOpponents, bool isRealTime, Action<UIStatus, AndroidHelperFragment.InvitationResultHolder> cb)
		{
		}

		[Address(RVA="0x1628FD8", Offset="0x1628FD8", VA="0x1628FD8")]
		public static void ShowSelectSnapshotUI(bool showCreateSaveUI, bool showDeleteSaveUI, int maxDisplayedSavedGames, string uiTitle, Action<SelectUIStatus, ISavedGameMetadata> cb)
		{
		}

		[Address(RVA="0x1629998", Offset="0x1629998", VA="0x1629998")]
		public static void ShowTbmpSelectOpponentsUI(uint minOpponents, uint maxOpponents, Action<UIStatus, AndroidHelperFragment.InvitationResultHolder> cb)
		{
		}

		[Address(RVA="0x16299B0", Offset="0x16299B0", VA="0x16299B0")]
		public static void ShowWaitingRoomUI(AndroidJavaObject room, int minParticipantsToStart, Action<AndroidHelperFragment.WaitingRoomUIStatus, AndroidJavaObject> cb)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E8D8", Offset="0x104E8D8")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<UIStatus, AndroidHelperFragment.InvitationResultHolder> cb;

			[Address(RVA="0x16299A8", Offset="0x16299A8", VA="0x16299A8")]
			public <>c__DisplayClass10_0()
			{
			}

			[Address(RVA="0x162A710", Offset="0x162A710", VA="0x162A710")]
			internal void <ShowSelectOpponentsUI>b__0(AndroidJavaObject result)
			{
			}

			[Address(RVA="0x162A9B8", Offset="0x162A9B8", VA="0x162A9B8")]
			internal void <ShowSelectOpponentsUI>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E8E8", Offset="0x104E8E8")]
		private sealed class <>c__DisplayClass12_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<AndroidHelperFragment.WaitingRoomUIStatus, AndroidJavaObject> cb;

			[Address(RVA="0x1629DF8", Offset="0x1629DF8", VA="0x1629DF8")]
			public <>c__DisplayClass12_0()
			{
			}

			[Address(RVA="0x162AA54", Offset="0x162AA54", VA="0x162AA54")]
			internal void <ShowWaitingRoomUI>b__0(AndroidJavaObject result)
			{
			}

			[Address(RVA="0x162AB4C", Offset="0x162AB4C", VA="0x162AB4C")]
			internal void <ShowWaitingRoomUI>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E8F8", Offset="0x104E8F8")]
		private sealed class <>c__DisplayClass13_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<UIStatus, TurnBasedMatch> cb;

			[Address(RVA="0x162A190", Offset="0x162A190", VA="0x162A190")]
			public <>c__DisplayClass13_0()
			{
			}

			[Address(RVA="0x162ABE8", Offset="0x162ABE8", VA="0x162ABE8")]
			internal void <ShowInboxUI>b__0(AndroidJavaObject result)
			{
			}

			[Address(RVA="0x162ADCC", Offset="0x162ADCC", VA="0x162ADCC")]
			internal void <ShowInboxUI>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E908", Offset="0x104E908")]
		private sealed class <>c__DisplayClass14_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<UIStatus, Invitation> cb;

			[Address(RVA="0x162A528", Offset="0x162A528", VA="0x162A528")]
			public <>c__DisplayClass14_0()
			{
			}

			[Address(RVA="0x162AE68", Offset="0x162AE68", VA="0x162AE68")]
			internal void <ShowInvitationInboxUI>b__0(AndroidJavaObject result)
			{
			}

			[Address(RVA="0x162B04C", Offset="0x162B04C", VA="0x162B04C")]
			internal void <ShowInvitationInboxUI>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E898", Offset="0x104E898")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<UIStatus> cb;

			[Address(RVA="0x1628DF4", Offset="0x1628DF4", VA="0x1628DF4")]
			public <>c__DisplayClass3_0()
			{
			}

			[Address(RVA="0x162B0E8", Offset="0x162B0E8", VA="0x162B0E8")]
			internal void <ShowAchievementsUI>b__0(int uiCode)
			{
			}

			[Address(RVA="0x162B1C4", Offset="0x162B1C4", VA="0x162B1C4")]
			internal void <ShowAchievementsUI>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E8A8", Offset="0x104E8A8")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<UIStatus> cb;

			[Address(RVA="0x1628FC8", Offset="0x1628FC8", VA="0x1628FC8")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x162B25C", Offset="0x162B25C", VA="0x162B25C")]
			internal void <ShowAllLeaderboardsUI>b__0(int uiCode)
			{
			}

			[Address(RVA="0x162B338", Offset="0x162B338", VA="0x162B338")]
			internal void <ShowAllLeaderboardsUI>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E8B8", Offset="0x104E8B8")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<UIStatus> cb;

			[Address(RVA="0x1628FD0", Offset="0x1628FD0", VA="0x1628FD0")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x162B3D0", Offset="0x162B3D0", VA="0x162B3D0")]
			internal void <ShowLeaderboardUI>b__0(int uiCode)
			{
			}

			[Address(RVA="0x162B4AC", Offset="0x162B4AC", VA="0x162B4AC")]
			internal void <ShowLeaderboardUI>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E8C8", Offset="0x104E8C8")]
		private sealed class <>c__DisplayClass7_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<SelectUIStatus, ISavedGameMetadata> cb;

			[Address(RVA="0x1629508", Offset="0x1629508", VA="0x1629508")]
			public <>c__DisplayClass7_0()
			{
			}

			[Address(RVA="0x162B544", Offset="0x162B544", VA="0x162B544")]
			internal void <ShowSelectSnapshotUI>b__0(AndroidJavaObject result)
			{
			}

			[Address(RVA="0x162B6C0", Offset="0x162B6C0", VA="0x162B6C0")]
			internal void <ShowSelectSnapshotUI>b__1(AndroidJavaObject exception)
			{
			}
		}

		public class InvitationResultHolder
		{
			[FieldOffset(Offset="0x10")]
			public int MinAutomatchingPlayers;

			[FieldOffset(Offset="0x14")]
			public int MaxAutomatchingPlayers;

			[FieldOffset(Offset="0x18")]
			public List<string> PlayerIdsToInvite;

			[Address(RVA="0x162A978", Offset="0x162A978", VA="0x162A978")]
			public InvitationResultHolder(int MinAutomatchingPlayers, int MaxAutomatchingPlayers, List<string> PlayerIdsToInvite)
			{
			}
		}

		public enum WaitingRoomUIStatus
		{
			[FieldOffset(Offset="0x0")]
			InternalError = -2,
			[FieldOffset(Offset="0x0")]
			Busy = -1,
			[FieldOffset(Offset="0x0")]
			Valid = 1,
			[FieldOffset(Offset="0x0")]
			Cancelled = 2,
			[FieldOffset(Offset="0x0")]
			LeftRoom = 3,
			[FieldOffset(Offset="0x0")]
			InvalidRoom = 4
		}
	}
}