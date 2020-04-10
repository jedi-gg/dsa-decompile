using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Multiplayer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidTurnBasedMultiplayerClient : ITurnBasedMultiplayerClient
	{
		[FieldOffset(Offset="0x10")]
		private AndroidJavaObject mClient;

		[FieldOffset(Offset="0x18")]
		private AndroidClient mAndroidClient;

		[FieldOffset(Offset="0x20")]
		private Action<TurnBasedMatch, bool> mMatchDelegate;

		public Action<TurnBasedMatch, bool> MatchDelegate
		{
			[Address(RVA="0x1EB98C4", Offset="0x1EB98C4", VA="0x1EB98C4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EB73FC", Offset="0x1EB73FC", VA="0x1EB73FC")]
		public AndroidTurnBasedMultiplayerClient(AndroidClient androidClient, AndroidJavaObject account)
		{
		}

		[Address(RVA="0x1EB9048", Offset="0x1EB9048", VA="0x1EB9048", Slot="11")]
		public void AcceptFromInbox(Action<bool, TurnBasedMatch> callback)
		{
		}

		[Address(RVA="0x1EB916C", Offset="0x1EB916C", VA="0x1EB916C", Slot="12")]
		public void AcceptInvitation(string invitationId, Action<bool, TurnBasedMatch> callback)
		{
		}

		[Address(RVA="0x1EB9D3C", Offset="0x1EB9D3C", VA="0x1EB9D3C", Slot="17")]
		public void AcknowledgeFinished(TurnBasedMatch match, Action<bool> callback)
		{
		}

		[Address(RVA="0x1EBA248", Offset="0x1EBA248", VA="0x1EBA248", Slot="20")]
		public void Cancel(TurnBasedMatch match, Action<bool> callback)
		{
		}

		[Address(RVA="0x1EBA6D0", Offset="0x1EBA6D0", VA="0x1EBA6D0")]
		private Participant CreateAutomatchingSentinel()
		{
			return null;
		}

		[Address(RVA="0x1EB765C", Offset="0x1EB765C", VA="0x1EB765C", Slot="4")]
		public void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, Action<bool, TurnBasedMatch> callback)
		{
		}

		[Address(RVA="0x1EB766C", Offset="0x1EB766C", VA="0x1EB766C", Slot="5")]
		public void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitmask, Action<bool, TurnBasedMatch> callback)
		{
		}

		[Address(RVA="0x1EBA82C", Offset="0x1EBA82C", VA="0x1EBA82C")]
		private List<TurnBasedMatch> CreateTurnBasedMatchList(AndroidJavaObject turnBasedMatchBuffer)
		{
			return null;
		}

		[Address(RVA="0x1EB8090", Offset="0x1EB8090", VA="0x1EB8090", Slot="6")]
		public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<bool, TurnBasedMatch> callback)
		{
		}

		[Address(RVA="0x1EB816C", Offset="0x1EB816C", VA="0x1EB816C", Slot="7")]
		public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, Action<UIStatus, TurnBasedMatch> callback)
		{
		}

		[Address(RVA="0x1EBA5D0", Offset="0x1EBA5D0", VA="0x1EBA5D0", Slot="23")]
		public void DeclineInvitation(string invitationId)
		{
		}

		[Address(RVA="0x1EBA398", Offset="0x1EBA398", VA="0x1EBA398", Slot="21")]
		public void Dismiss(TurnBasedMatch match)
		{
		}

		[Address(RVA="0x1EB9E70", Offset="0x1EB9E70", VA="0x1EB9E70")]
		private void FindEqualVersionMatch(TurnBasedMatch match, Action<bool, TurnBasedMatch> callback)
		{
		}

		[Address(RVA="0x1EB9A68", Offset="0x1EB9A68", VA="0x1EB9A68")]
		private void FindEqualVersionMatchWithParticipant(TurnBasedMatch match, string participantId, Action<bool> onFailure, Action<Participant, TurnBasedMatch> onFoundParticipantAndMatch)
		{
		}

		[Address(RVA="0x1EB92BC", Offset="0x1EB92BC", VA="0x1EB92BC")]
		private void FindInvitationWithId(string invitationId, Action<Invitation> callback)
		{
		}

		[Address(RVA="0x1EB9B9C", Offset="0x1EB9B9C", VA="0x1EB9B9C", Slot="16")]
		public void Finish(TurnBasedMatch match, byte[] data, MatchOutcome outcome, Action<bool> callback)
		{
		}

		[Address(RVA="0x1EB846C", Offset="0x1EB846C", VA="0x1EB846C", Slot="8")]
		public void GetAllInvitations(Action<Invitation[]> callback)
		{
		}

		[Address(RVA="0x1EB8774", Offset="0x1EB8774", VA="0x1EB8774", Slot="9")]
		public void GetAllMatches(Action<TurnBasedMatch[]> callback)
		{
		}

		[Address(RVA="0x1EB8A90", Offset="0x1EB8A90", VA="0x1EB8A90", Slot="10")]
		public void GetMatch(string matchId, Action<bool, TurnBasedMatch> callback)
		{
		}

		[Address(RVA="0x1EB8D94", Offset="0x1EB8D94", VA="0x1EB8D94")]
		private void GetMatchAndroidJavaObject(string matchId, Action<bool, AndroidJavaObject> callback)
		{
		}

		[Address(RVA="0x1EB9B94", Offset="0x1EB9B94", VA="0x1EB9B94", Slot="15")]
		public int GetMaxMatchDataSize()
		{
			return new int();
		}

		[Address(RVA="0x1EB9F68", Offset="0x1EB9F68", VA="0x1EB9F68", Slot="18")]
		public void Leave(TurnBasedMatch match, Action<bool> callback)
		{
		}

		[Address(RVA="0x1EBA0B8", Offset="0x1EBA0B8", VA="0x1EBA0B8", Slot="19")]
		public void LeaveDuringTurn(TurnBasedMatch match, string pendingParticipantId, Action<bool> callback)
		{
		}

		[Address(RVA="0x1EB9584", Offset="0x1EB9584", VA="0x1EB9584", Slot="13")]
		public void RegisterMatchDelegate(GooglePlayGames.BasicApi.Multiplayer.MatchDelegate del)
		{
		}

		[Address(RVA="0x1EBA480", Offset="0x1EBA480", VA="0x1EBA480", Slot="22")]
		public void Rematch(TurnBasedMatch match, Action<bool, TurnBasedMatch> callback)
		{
		}

		[Address(RVA="0x1EB82C8", Offset="0x1EB82C8", VA="0x1EB82C8")]
		private AndroidJavaObject StringListToAndroidJavaObject(List<string> list)
		{
			return null;
		}

		[Address(RVA="0x1EB98E8", Offset="0x1EB98E8", VA="0x1EB98E8", Slot="14")]
		public void TakeTurn(TurnBasedMatch match, byte[] data, string pendingParticipantId, Action<bool> callback)
		{
		}

		[Address(RVA="0x1F5C40C", Offset="0x1F5C40C", VA="0x1F5C40C")]
		private static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}

		[Address(RVA="0x1F5CF0C", Offset="0x1F5CF0C", VA="0x1F5CF0C")]
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EB48", Offset="0x104EB48")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidTurnBasedMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action<TurnBasedMatch[]> callback;

			[Address(RVA="0x1EB8A88", Offset="0x1EB8A88", VA="0x1EB8A88")]
			public <>c__DisplayClass10_0()
			{
			}

			[Address(RVA="0x1EBAA08", Offset="0x1EBAA08", VA="0x1EBAA08")]
			internal void <GetAllMatches>b__0(AndroidJavaObject annotatedData)
			{
			}

			[Address(RVA="0x1EBB05C", Offset="0x1EBB05C", VA="0x1EBB05C")]
			internal void <GetAllMatches>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EB58", Offset="0x104EB58")]
		private sealed class <>c__DisplayClass11_0
		{
			[FieldOffset(Offset="0x10")]
			public string matchId;

			[FieldOffset(Offset="0x18")]
			public Action<bool, TurnBasedMatch> callback;

			[Address(RVA="0x1EB8D8C", Offset="0x1EB8D8C", VA="0x1EB8D8C")]
			public <>c__DisplayClass11_0()
			{
			}

			[Address(RVA="0x1EBB0C0", Offset="0x1EBB0C0", VA="0x1EBB0C0")]
			internal void <GetMatch>b__0(AndroidJavaObject annotatedData)
			{
			}

			[Address(RVA="0x1EBB304", Offset="0x1EBB304", VA="0x1EBB304")]
			internal void <GetMatch>b__1(AndroidJavaObject e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EB68", Offset="0x104EB68")]
		private sealed class <>c__DisplayClass12_0
		{
			[FieldOffset(Offset="0x10")]
			public string matchId;

			[FieldOffset(Offset="0x18")]
			public Action<bool, AndroidJavaObject> callback;

			[Address(RVA="0x1EB9040", Offset="0x1EB9040", VA="0x1EB9040")]
			public <>c__DisplayClass12_0()
			{
			}

			[Address(RVA="0x1EBB36C", Offset="0x1EBB36C", VA="0x1EBB36C")]
			internal void <GetMatchAndroidJavaObject>b__0(AndroidJavaObject annotatedData)
			{
			}

			[Address(RVA="0x1EBB59C", Offset="0x1EBB59C", VA="0x1EBB59C")]
			internal void <GetMatchAndroidJavaObject>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EB78", Offset="0x104EB78")]
		private sealed class <>c__DisplayClass13_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidTurnBasedMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action<bool, TurnBasedMatch> callback;

			[FieldOffset(Offset="0x20")]
			public Action <>9__1;

			[Address(RVA="0x1EB9164", Offset="0x1EB9164", VA="0x1EB9164")]
			public <>c__DisplayClass13_0()
			{
			}

			[Address(RVA="0x1EBB604", Offset="0x1EBB604", VA="0x1EBB604")]
			internal void <AcceptFromInbox>b__0(UIStatus status, TurnBasedMatch turnBasedMatch)
			{
			}

			[Address(RVA="0x1EBB780", Offset="0x1EBB780", VA="0x1EBB780")]
			internal void <AcceptFromInbox>b__1()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EB88", Offset="0x104EB88")]
		private sealed class <>c__DisplayClass14_0
		{
			[FieldOffset(Offset="0x10")]
			public string invitationId;

			[FieldOffset(Offset="0x18")]
			public Action<bool, TurnBasedMatch> callback;

			[FieldOffset(Offset="0x20")]
			public AndroidTurnBasedMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x28")]
			public Action<AndroidJavaObject> <>9__1;

			[FieldOffset(Offset="0x30")]
			public Action<AndroidJavaObject> <>9__2;

			[Address(RVA="0x1EB92B4", Offset="0x1EB92B4", VA="0x1EB92B4")]
			public <>c__DisplayClass14_0()
			{
			}

			[Address(RVA="0x1EBB7E8", Offset="0x1EBB7E8", VA="0x1EBB7E8")]
			internal void <AcceptInvitation>b__0(Invitation invitation)
			{
			}

			[Address(RVA="0x1EBBAE4", Offset="0x1EBBAE4", VA="0x1EBBAE4")]
			internal void <AcceptInvitation>b__1(AndroidJavaObject turnBasedMatch)
			{
			}

			[Address(RVA="0x1EBBB68", Offset="0x1EBBB68", VA="0x1EBBB68")]
			internal void <AcceptInvitation>b__2(AndroidJavaObject e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EB98", Offset="0x104EB98")]
		private sealed class <>c__DisplayClass15_0
		{
			[FieldOffset(Offset="0x10")]
			public GooglePlayGames.BasicApi.Multiplayer.MatchDelegate del;

			[Address(RVA="0x1EB9834", Offset="0x1EB9834", VA="0x1EB9834")]
			public <>c__DisplayClass15_0()
			{
			}

			[Address(RVA="0x1EBBBD0", Offset="0x1EBBBD0", VA="0x1EBBBD0")]
			internal void <RegisterMatchDelegate>b__0(TurnBasedMatch turnBasedMatch, bool autoAccept)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EBA8", Offset="0x104EBA8")]
		private sealed class <>c__DisplayClass18_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidTurnBasedMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public byte[] data;

			[FieldOffset(Offset="0x20")]
			public string pendingParticipantId;

			[FieldOffset(Offset="0x28")]
			public Action<bool> callback;

			[FieldOffset(Offset="0x30")]
			public Action<AndroidJavaObject> <>9__1;

			[FieldOffset(Offset="0x38")]
			public Action<AndroidJavaObject> <>9__2;

			[Address(RVA="0x1EB9A60", Offset="0x1EB9A60", VA="0x1EB9A60")]
			public <>c__DisplayClass18_0()
			{
			}

			[Address(RVA="0x1EBC394", Offset="0x1EBC394", VA="0x1EBC394")]
			internal void <TakeTurn>b__0(Participant pendingParticipant, TurnBasedMatch foundMatch)
			{
			}

			[Address(RVA="0x1EBC6B0", Offset="0x1EBC6B0", VA="0x1EBC6B0")]
			internal void <TakeTurn>b__1(AndroidJavaObject turnBasedMatch)
			{
			}

			[Address(RVA="0x1EBC714", Offset="0x1EBC714", VA="0x1EBC714")]
			internal void <TakeTurn>b__2(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EBB8", Offset="0x104EBB8")]
		private sealed class <>c__DisplayClass20_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<bool> callback;

			[FieldOffset(Offset="0x18")]
			public MatchOutcome outcome;

			[FieldOffset(Offset="0x20")]
			public AndroidTurnBasedMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x28")]
			public TurnBasedMatch match;

			[FieldOffset(Offset="0x30")]
			public byte[] data;

			[FieldOffset(Offset="0x38")]
			public Action<AndroidJavaObject> <>9__1;

			[FieldOffset(Offset="0x40")]
			public Action<AndroidJavaObject> <>9__2;

			[Address(RVA="0x1EB9D2C", Offset="0x1EB9D2C", VA="0x1EB9D2C")]
			public <>c__DisplayClass20_0()
			{
			}

			[Address(RVA="0x1EBC7AC", Offset="0x1EBC7AC", VA="0x1EBC7AC")]
			internal void <Finish>b__0(bool status, AndroidJavaObject foundMatch)
			{
			}

			[Address(RVA="0x1EBD9CC", Offset="0x1EBD9CC", VA="0x1EBD9CC")]
			internal void <Finish>b__1(AndroidJavaObject turnBasedMatch)
			{
			}

			[Address(RVA="0x1EBDA30", Offset="0x1EBDA30", VA="0x1EBDA30")]
			internal void <Finish>b__2(AndroidJavaObject e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EBC8", Offset="0x104EBC8")]
		private sealed class <>c__DisplayClass21_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<bool> callback;

			[FieldOffset(Offset="0x18")]
			public AndroidTurnBasedMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x20")]
			public Action<AndroidJavaObject> <>9__1;

			[FieldOffset(Offset="0x28")]
			public Action<AndroidJavaObject> <>9__2;

			[Address(RVA="0x1EB9E68", Offset="0x1EB9E68", VA="0x1EB9E68")]
			public <>c__DisplayClass21_0()
			{
			}

			[Address(RVA="0x1EBDA94", Offset="0x1EBDA94", VA="0x1EBDA94")]
			internal void <AcknowledgeFinished>b__0(bool success, TurnBasedMatch foundMatch)
			{
			}

			[Address(RVA="0x1EBDD54", Offset="0x1EBDD54", VA="0x1EBDD54")]
			internal void <AcknowledgeFinished>b__1(AndroidJavaObject v)
			{
			}

			[Address(RVA="0x1EBDDB8", Offset="0x1EBDDB8", VA="0x1EBDDB8")]
			internal void <AcknowledgeFinished>b__2(AndroidJavaObject e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EBD8", Offset="0x104EBD8")]
		private sealed class <>c__DisplayClass22_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<bool> callback;

			[FieldOffset(Offset="0x18")]
			public AndroidTurnBasedMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x20")]
			public TurnBasedMatch match;

			[FieldOffset(Offset="0x28")]
			public Action<AndroidJavaObject> <>9__1;

			[FieldOffset(Offset="0x30")]
			public Action<AndroidJavaObject> <>9__2;

			[Address(RVA="0x1EBA0B0", Offset="0x1EBA0B0", VA="0x1EBA0B0")]
			public <>c__DisplayClass22_0()
			{
			}

			[Address(RVA="0x1EBDE1C", Offset="0x1EBDE1C", VA="0x1EBDE1C")]
			internal void <Leave>b__0(bool success, TurnBasedMatch foundMatch)
			{
			}

			[Address(RVA="0x1EBE0D0", Offset="0x1EBE0D0", VA="0x1EBE0D0")]
			internal void <Leave>b__1(AndroidJavaObject v)
			{
			}

			[Address(RVA="0x1EBE134", Offset="0x1EBE134", VA="0x1EBE134")]
			internal void <Leave>b__2(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EBE8", Offset="0x104EBE8")]
		private sealed class <>c__DisplayClass23_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidTurnBasedMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public TurnBasedMatch match;

			[FieldOffset(Offset="0x20")]
			public string pendingParticipantId;

			[FieldOffset(Offset="0x28")]
			public Action<bool> callback;

			[FieldOffset(Offset="0x30")]
			public Action<AndroidJavaObject> <>9__1;

			[FieldOffset(Offset="0x38")]
			public Action<AndroidJavaObject> <>9__2;

			[Address(RVA="0x1EBA240", Offset="0x1EBA240", VA="0x1EBA240")]
			public <>c__DisplayClass23_0()
			{
			}

			[Address(RVA="0x1EBE198", Offset="0x1EBE198", VA="0x1EBE198")]
			internal void <LeaveDuringTurn>b__0(Participant pendingParticipant, TurnBasedMatch foundMatch)
			{
			}

			[Address(RVA="0x1EBE468", Offset="0x1EBE468", VA="0x1EBE468")]
			internal void <LeaveDuringTurn>b__1(AndroidJavaObject v)
			{
			}

			[Address(RVA="0x1EBE4CC", Offset="0x1EBE4CC", VA="0x1EBE4CC")]
			internal void <LeaveDuringTurn>b__2(AndroidJavaObject e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EBF8", Offset="0x104EBF8")]
		private sealed class <>c__DisplayClass24_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<bool> callback;

			[FieldOffset(Offset="0x18")]
			public AndroidTurnBasedMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x20")]
			public TurnBasedMatch match;

			[FieldOffset(Offset="0x28")]
			public Action<string> <>9__1;

			[FieldOffset(Offset="0x30")]
			public Action<AndroidJavaObject> <>9__2;

			[Address(RVA="0x1EBA390", Offset="0x1EBA390", VA="0x1EBA390")]
			public <>c__DisplayClass24_0()
			{
			}

			[Address(RVA="0x1EBE530", Offset="0x1EBE530", VA="0x1EBE530")]
			internal void <Cancel>b__0(bool success, TurnBasedMatch foundMatch)
			{
			}

			[Address(RVA="0x1EBE7F0", Offset="0x1EBE7F0", VA="0x1EBE7F0")]
			internal void <Cancel>b__1(string v)
			{
			}

			[Address(RVA="0x1EBE854", Offset="0x1EBE854", VA="0x1EBE854")]
			internal void <Cancel>b__2(AndroidJavaObject e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EC08", Offset="0x104EC08")]
		private sealed class <>c__DisplayClass25_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidTurnBasedMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public TurnBasedMatch match;

			[Address(RVA="0x1EBA478", Offset="0x1EBA478", VA="0x1EBA478")]
			public <>c__DisplayClass25_0()
			{
			}

			[Address(RVA="0x1EBE8B8", Offset="0x1EBE8B8", VA="0x1EBE8B8")]
			internal void <Dismiss>b__0(bool success, TurnBasedMatch foundMatch)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EC18", Offset="0x104EC18")]
		private sealed class <>c__DisplayClass26_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<bool, TurnBasedMatch> callback;

			[FieldOffset(Offset="0x18")]
			public AndroidTurnBasedMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x20")]
			public TurnBasedMatch match;

			[FieldOffset(Offset="0x28")]
			public Action<AndroidJavaObject> <>9__1;

			[FieldOffset(Offset="0x30")]
			public Action<AndroidJavaObject> <>9__2;

			[Address(RVA="0x1EBA5C8", Offset="0x1EBA5C8", VA="0x1EBA5C8")]
			public <>c__DisplayClass26_0()
			{
			}

			[Address(RVA="0x1EBEA48", Offset="0x1EBEA48", VA="0x1EBEA48")]
			internal void <Rematch>b__0(bool success, TurnBasedMatch foundMatch)
			{
			}

			[Address(RVA="0x1EBED0C", Offset="0x1EBED0C", VA="0x1EBED0C")]
			internal void <Rematch>b__1(AndroidJavaObject turnBasedMatch)
			{
			}

			[Address(RVA="0x1EBED90", Offset="0x1EBED90", VA="0x1EBED90")]
			internal void <Rematch>b__2(AndroidJavaObject e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EC28", Offset="0x104EC28")]
		private sealed class <>c__DisplayClass27_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidTurnBasedMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public string invitationId;

			[Address(RVA="0x1EBA6B0", Offset="0x1EBA6B0", VA="0x1EBA6B0")]
			public <>c__DisplayClass27_0()
			{
			}

			[Address(RVA="0x1EBEDF8", Offset="0x1EBEDF8", VA="0x1EBEDF8")]
			internal void <DeclineInvitation>b__0(Invitation invitation)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EC38", Offset="0x104EC38")]
		private sealed class <>c__DisplayClass28_0
		{
			[FieldOffset(Offset="0x10")]
			public string invitationId;

			[FieldOffset(Offset="0x18")]
			public Action<Invitation> callback;

			[Address(RVA="0x1EBA6B8", Offset="0x1EBA6B8", VA="0x1EBA6B8")]
			public <>c__DisplayClass28_0()
			{
			}

			[Address(RVA="0x1EBEF74", Offset="0x1EBEF74", VA="0x1EBEF74")]
			internal void <FindInvitationWithId>b__0(AndroidJavaObject annotatedData)
			{
			}

			[Address(RVA="0x1EBF424", Offset="0x1EBF424", VA="0x1EBF424")]
			internal void <FindInvitationWithId>b__1(AndroidJavaObject e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EC48", Offset="0x104EC48")]
		private sealed class <>c__DisplayClass29_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<bool, TurnBasedMatch> callback;

			[FieldOffset(Offset="0x18")]
			public TurnBasedMatch match;

			[Address(RVA="0x1EBA6C0", Offset="0x1EBA6C0", VA="0x1EBA6C0")]
			public <>c__DisplayClass29_0()
			{
			}

			[Address(RVA="0x1EBF488", Offset="0x1EBF488", VA="0x1EBF488")]
			internal void <FindEqualVersionMatch>b__0(bool success, TurnBasedMatch foundMatch)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EC58", Offset="0x104EC58")]
		private sealed class <>c__DisplayClass30_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<bool> onFailure;

			[FieldOffset(Offset="0x18")]
			public string participantId;

			[FieldOffset(Offset="0x20")]
			public Action<Participant, TurnBasedMatch> onFoundParticipantAndMatch;

			[FieldOffset(Offset="0x28")]
			public AndroidTurnBasedMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x30")]
			public TurnBasedMatch match;

			[Address(RVA="0x1EBA6C8", Offset="0x1EBA6C8", VA="0x1EBA6C8")]
			public <>c__DisplayClass30_0()
			{
			}

			[Address(RVA="0x1EBF640", Offset="0x1EBF640", VA="0x1EBF640")]
			internal void <FindEqualVersionMatchWithParticipant>b__0(bool success, TurnBasedMatch foundMatch)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EC68", Offset="0x104EC68")]
		private sealed class <>c__DisplayClass33_0<T>
		{
			[FieldOffset(Offset="0x0")]
			public Action<T> toConvert;

			[Address(RVA="0x1D8DE08", Offset="0x1D8DE08", VA="0x1D8DE08")]
			public <>c__DisplayClass33_0()
			{
			}

			[Address(RVA="0x1D8DE34", Offset="0x1D8DE34", VA="0x1D8DE34")]
			internal void <ToOnGameThread>b__0(T val)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EC78", Offset="0x104EC78")]
		private sealed class <>c__DisplayClass33_1<T>
		{
			[FieldOffset(Offset="0x0")]
			public T val;

			[FieldOffset(Offset="0x0")]
			public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass33_0<T> CS$<>8__locals1;

			[Address(RVA="0x1D8E074", Offset="0x1D8E074", VA="0x1D8E074")]
			public <>c__DisplayClass33_1()
			{
			}

			[Address(RVA="0x1D8E0A0", Offset="0x1D8E0A0", VA="0x1D8E0A0")]
			internal void <ToOnGameThread>b__1()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EC88", Offset="0x104EC88")]
		private sealed class <>c__DisplayClass34_0<T1, T2>
		{
			[FieldOffset(Offset="0x0")]
			public Action<T1, T2> toConvert;

			[Address(RVA="0x1D8E198", Offset="0x1D8E198", VA="0x1D8E198")]
			public <>c__DisplayClass34_0()
			{
			}

			[Address(RVA="0x1D8E1C4", Offset="0x1D8E1C4", VA="0x1D8E1C4")]
			internal void <ToOnGameThread>b__0(T1 val1, T2 val2)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EC98", Offset="0x104EC98")]
		private sealed class <>c__DisplayClass34_1<T1, T2>
		{
			[FieldOffset(Offset="0x0")]
			public T1 val1;

			[FieldOffset(Offset="0x0")]
			public T2 val2;

			[FieldOffset(Offset="0x0")]
			public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass34_0<T1, T2> CS$<>8__locals1;

			[Address(RVA="0x1D8E6F4", Offset="0x1D8E6F4", VA="0x1D8E6F4")]
			public <>c__DisplayClass34_1()
			{
			}

			[Address(RVA="0x1D8E720", Offset="0x1D8E720", VA="0x1D8E720")]
			internal void <ToOnGameThread>b__1()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EAF8", Offset="0x104EAF8")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<bool, TurnBasedMatch> callback;

			[Address(RVA="0x1EB8088", Offset="0x1EB8088", VA="0x1EB8088")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x1EBF978", Offset="0x1EBF978", VA="0x1EBF978")]
			internal void <CreateQuickMatch>b__0(AndroidJavaObject turnBasedMatch)
			{
			}

			[Address(RVA="0x1EBF9FC", Offset="0x1EBF9FC", VA="0x1EBF9FC")]
			internal void <CreateQuickMatch>b__1(AndroidJavaObject e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EB08", Offset="0x104EB08")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<bool, TurnBasedMatch> callback;

			[Address(RVA="0x1EB8164", Offset="0x1EB8164", VA="0x1EB8164")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x1EBFA64", Offset="0x1EBFA64", VA="0x1EBFA64")]
			internal void <CreateWithInvitationScreen>b__0(UIStatus status, TurnBasedMatch match)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EB18", Offset="0x104EB18")]
		private sealed class <>c__DisplayClass7_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidTurnBasedMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action<UIStatus, TurnBasedMatch> callback;

			[FieldOffset(Offset="0x20")]
			public uint variant;

			[FieldOffset(Offset="0x28")]
			public Action<AndroidJavaObject> <>9__2;

			[FieldOffset(Offset="0x30")]
			public Action<AndroidJavaObject> <>9__3;

			[Address(RVA="0x1EB82C0", Offset="0x1EB82C0", VA="0x1EB82C0")]
			public <>c__DisplayClass7_0()
			{
			}

			[Address(RVA="0x1EBFAE0", Offset="0x1EBFAE0", VA="0x1EBFAE0")]
			internal void <CreateWithInvitationScreen>b__0(UIStatus status, AndroidHelperFragment.InvitationResultHolder result)
			{
			}

			[Address(RVA="0x1EC0C30", Offset="0x1EC0C30", VA="0x1EC0C30")]
			internal void <CreateWithInvitationScreen>b__2(AndroidJavaObject turnBasedMatch)
			{
			}

			[Address(RVA="0x1EC0CB4", Offset="0x1EC0CB4", VA="0x1EC0CB4")]
			internal void <CreateWithInvitationScreen>b__3(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EB28", Offset="0x104EB28")]
		private sealed class <>c__DisplayClass7_1
		{
			[FieldOffset(Offset="0x10")]
			public UIStatus status;

			[FieldOffset(Offset="0x18")]
			public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass7_0 CS$<>8__locals1;

			[Address(RVA="0x1EC0C28", Offset="0x1EC0C28", VA="0x1EC0C28")]
			public <>c__DisplayClass7_1()
			{
			}

			[Address(RVA="0x1EC0D1C", Offset="0x1EC0D1C", VA="0x1EC0D1C")]
			internal void <CreateWithInvitationScreen>b__1()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EB38", Offset="0x104EB38")]
		private sealed class <>c__DisplayClass9_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<Invitation[]> callback;

			[Address(RVA="0x1EB876C", Offset="0x1EB876C", VA="0x1EB876C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Address(RVA="0x1EC0D98", Offset="0x1EC0D98", VA="0x1EC0D98")]
			internal void <GetAllInvitations>b__0(AndroidJavaObject annotatedData)
			{
			}

			[Address(RVA="0x1EC1378", Offset="0x1EC1378", VA="0x1EC1378")]
			internal void <GetAllInvitations>b__1(AndroidJavaObject e)
			{
			}
		}

		private class TurnBasedMatchUpdateCallbackProxy : AndroidJavaProxy
		{
			[FieldOffset(Offset="0x20")]
			private Action<TurnBasedMatch, bool> mMatchDelegate;

			[Address(RVA="0x1EB983C", Offset="0x1EB983C", VA="0x1EB983C")]
			public TurnBasedMatchUpdateCallbackProxy(Action<TurnBasedMatch, bool> matchDelegate)
			{
			}

			[Address(RVA="0x1EC13DC", Offset="0x1EC13DC", VA="0x1EC13DC")]
			public void onTurnBasedMatchReceived(AndroidJavaObject turnBasedMatch)
			{
			}

			[Address(RVA="0x1EC1460", Offset="0x1EC1460", VA="0x1EC1460")]
			public void onTurnBasedMatchRemoved(string invitationId)
			{
			}
		}
	}
}