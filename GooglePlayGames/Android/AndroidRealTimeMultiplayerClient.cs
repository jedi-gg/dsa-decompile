using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Multiplayer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidRealTimeMultiplayerClient : IRealTimeMultiplayerClient
	{
		[FieldOffset(Offset="0x10")]
		private readonly object mSessionLock;

		[FieldOffset(Offset="0x18")]
		private int mMinPlayersToStart;

		[FieldOffset(Offset="0x20")]
		private AndroidClient mAndroidClient;

		[FieldOffset(Offset="0x28")]
		private AndroidJavaObject mRtmpClient;

		[FieldOffset(Offset="0x30")]
		private AndroidJavaObject mInvitationsClient;

		[FieldOffset(Offset="0x38")]
		private AndroidJavaObject mRoom;

		[FieldOffset(Offset="0x40")]
		private AndroidJavaObject mRoomConfig;

		[FieldOffset(Offset="0x48")]
		private AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener mListener;

		[FieldOffset(Offset="0x50")]
		private Invitation mInvitation;

		[Address(RVA="0x1621F28", Offset="0x1621F28", VA="0x1621F28")]
		public AndroidRealTimeMultiplayerClient(AndroidClient androidClient, AndroidJavaObject account)
		{
		}

		[Address(RVA="0x16349E0", Offset="0x16349E0", VA="0x16349E0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107512C", Offset="0x107512C")]
		private void <ShowWaitingRoomUI>b__15_0(AndroidHelperFragment.WaitingRoomUIStatus response, AndroidJavaObject room)
		{
		}

		[Address(RVA="0x1632D64", Offset="0x1632D64", VA="0x1632D64", Slot="9")]
		public void AcceptFromInbox(RealTimeMultiplayerListener listener)
		{
		}

		[Address(RVA="0x1632F94", Offset="0x1632F94", VA="0x1632F94", Slot="10")]
		public void AcceptInvitation(string invitationId, RealTimeMultiplayerListener listener)
		{
		}

		[Address(RVA="0x1634790", Offset="0x1634790", VA="0x1634790")]
		private void CleanSession()
		{
		}

		[Address(RVA="0x1631118", Offset="0x1631118", VA="0x1631118", Slot="4")]
		public void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, RealTimeMultiplayerListener listener)
		{
		}

		[Address(RVA="0x1631128", Offset="0x1631128", VA="0x1631128", Slot="5")]
		public void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitMask, RealTimeMultiplayerListener listener)
		{
		}

		[Address(RVA="0x16325B0", Offset="0x16325B0", VA="0x16325B0", Slot="6")]
		public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, RealTimeMultiplayerListener listener)
		{
		}

		[Address(RVA="0x1634858", Offset="0x1634858", VA="0x1634858", Slot="21")]
		public void DeclineInvitation(string invitationId)
		{
		}

		[Address(RVA="0x163320C", Offset="0x163320C", VA="0x163320C")]
		private void FindInvitation(string invitationId, Action<bool> fail, Action<Invitation> callback)
		{
		}

		[Address(RVA="0x1632AE4", Offset="0x1632AE4", VA="0x1632AE4", Slot="8")]
		public void GetAllInvitations(Action<Invitation[]> callback)
		{
		}

		[Address(RVA="0x16328AC", Offset="0x16328AC", VA="0x16328AC", Slot="15")]
		public List<Participant> GetConnectedParticipants()
		{
			return null;
		}

		[Address(RVA="0x1634558", Offset="0x1634558", VA="0x1634558", Slot="18")]
		public Invitation GetInvitation()
		{
			return null;
		}

		[Address(RVA="0x1633C6C", Offset="0x1633C6C", VA="0x1633C6C", Slot="17")]
		public Participant GetParticipant(string participantId)
		{
			return null;
		}

		[Address(RVA="0x1633F3C", Offset="0x1633F3C", VA="0x1633F3C")]
		private List<Participant> GetParticipantList()
		{
			return null;
		}

		[Address(RVA="0x16327EC", Offset="0x16327EC", VA="0x16327EC")]
		private float GetPercentComplete()
		{
			return new float();
		}

		[Address(RVA="0x1632528", Offset="0x1632528", VA="0x1632528")]
		private AndroidRealTimeMultiplayerClient.RoomStatus GetRoomStatus()
		{
			return new AndroidRealTimeMultiplayerClient.RoomStatus();
		}

		[Address(RVA="0x163437C", Offset="0x163437C", VA="0x163437C", Slot="16")]
		public Participant GetSelf()
		{
			return null;
		}

		[Address(RVA="0x163483C", Offset="0x163483C", VA="0x163483C", Slot="20")]
		public bool IsRoomConnected()
		{
			return new bool();
		}

		[Address(RVA="0x1634560", Offset="0x1634560", VA="0x1634560", Slot="19")]
		public void LeaveRoom()
		{
		}

		[Address(RVA="0x16337AC", Offset="0x16337AC", VA="0x16337AC", Slot="13")]
		public void SendMessage(bool reliable, string participantId, byte[] data)
		{
		}

		[Address(RVA="0x1633EEC", Offset="0x1633EEC", VA="0x1633EEC", Slot="14")]
		public void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length)
		{
		}

		[Address(RVA="0x1633468", Offset="0x1633468", VA="0x1633468", Slot="11")]
		public void SendMessageToAll(bool reliable, byte[] data)
		{
		}

		[Address(RVA="0x1633C2C", Offset="0x1633C2C", VA="0x1633C2C", Slot="12")]
		public void SendMessageToAll(bool reliable, byte[] data, int offset, int length)
		{
		}

		[Address(RVA="0x1632A34", Offset="0x1632A34", VA="0x1632A34", Slot="7")]
		public void ShowWaitingRoomUI()
		{
		}

		[Address(RVA="0x1F5C2B4", Offset="0x1F5C2B4", VA="0x1F5C2B4")]
		private static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E9D8", Offset="0x104E9D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AndroidRealTimeMultiplayerClient.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Action<bool> <>9__31_0;

			[Address(RVA="0x1EAA6F8", Offset="0x1EAA6F8", VA="0x1EAA6F8")]
			static <>c()
			{
			}

			[Address(RVA="0x1EAA75C", Offset="0x1EAA75C", VA="0x1EAA75C")]
			public <>c()
			{
			}

			[Address(RVA="0x1EAA764", Offset="0x1EAA764", VA="0x1EAA764")]
			internal void <DeclineInvitation>b__31_0(bool fail)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E978", Offset="0x104E978")]
		private sealed class <>c__DisplayClass12_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listenerOnGameThread;

			[FieldOffset(Offset="0x18")]
			public AndroidRealTimeMultiplayerClient <>4__this;

			[Address(RVA="0x1EAA768", Offset="0x1EAA768", VA="0x1EAA768")]
			public <>c__DisplayClass12_0()
			{
			}

			[Address(RVA="0x1EAA770", Offset="0x1EAA770", VA="0x1EAA770")]
			internal void <CreateQuickGame>b__0(AndroidJavaObject e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E988", Offset="0x104E988")]
		private sealed class <>c__DisplayClass13_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidRealTimeMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listenerOnGameThread;

			[FieldOffset(Offset="0x20")]
			public uint variant;

			[FieldOffset(Offset="0x28")]
			public Action <>9__1;

			[FieldOffset(Offset="0x30")]
			public Action<AndroidJavaObject> <>9__2;

			[Address(RVA="0x1EAA8A8", Offset="0x1EAA8A8", VA="0x1EAA8A8")]
			public <>c__DisplayClass13_0()
			{
			}

			[Address(RVA="0x1EAA8B0", Offset="0x1EAA8B0", VA="0x1EAA8B0")]
			internal void <CreateWithInvitationScreen>b__0(UIStatus status, AndroidHelperFragment.InvitationResultHolder result)
			{
			}

			[Address(RVA="0x1EAC1F0", Offset="0x1EAC1F0", VA="0x1EAC1F0")]
			internal void <CreateWithInvitationScreen>b__1()
			{
			}

			[Address(RVA="0x1EAC240", Offset="0x1EAC240", VA="0x1EAC240")]
			internal void <CreateWithInvitationScreen>b__2(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E998", Offset="0x104E998")]
		private sealed class <>c__DisplayClass16_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<Invitation[]> callback;

			[Address(RVA="0x1EAC290", Offset="0x1EAC290", VA="0x1EAC290")]
			public <>c__DisplayClass16_0()
			{
			}

			[Address(RVA="0x1EAC298", Offset="0x1EAC298", VA="0x1EAC298")]
			internal void <GetAllInvitations>b__0(AndroidJavaObject annotatedData)
			{
			}

			[Address(RVA="0x1EAC734", Offset="0x1EAC734", VA="0x1EAC734")]
			internal void <GetAllInvitations>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E9A8", Offset="0x104E9A8")]
		private sealed class <>c__DisplayClass17_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidRealTimeMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listenerOnGameThread;

			[FieldOffset(Offset="0x20")]
			public RealTimeMultiplayerListener listener;

			[FieldOffset(Offset="0x28")]
			public Action <>9__1;

			[Address(RVA="0x1EAC798", Offset="0x1EAC798", VA="0x1EAC798")]
			public <>c__DisplayClass17_0()
			{
			}

			[Address(RVA="0x1EAC7A0", Offset="0x1EAC7A0", VA="0x1EAC7A0")]
			internal void <AcceptFromInbox>b__0(UIStatus status, Invitation invitation)
			{
			}

			[Address(RVA="0x1EAC928", Offset="0x1EAC928", VA="0x1EAC928")]
			internal void <AcceptFromInbox>b__1()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E9B8", Offset="0x104E9B8")]
		private sealed class <>c__DisplayClass18_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listenerOnGameThread;

			[FieldOffset(Offset="0x18")]
			public AndroidRealTimeMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x20")]
			public string invitationId;

			[FieldOffset(Offset="0x28")]
			public Action<AndroidJavaObject> <>9__2;

			[Address(RVA="0x1EAC958", Offset="0x1EAC958", VA="0x1EAC958")]
			public <>c__DisplayClass18_0()
			{
			}

			[Address(RVA="0x1EAC960", Offset="0x1EAC960", VA="0x1EAC960")]
			internal void <AcceptInvitation>b__0(bool fail)
			{
			}

			[Address(RVA="0x1EAC990", Offset="0x1EAC990", VA="0x1EAC990")]
			internal void <AcceptInvitation>b__1(Invitation invitation)
			{
			}

			[Address(RVA="0x1EAD8CC", Offset="0x1EAD8CC", VA="0x1EAD8CC")]
			internal void <AcceptInvitation>b__2(AndroidJavaObject e)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E9C8", Offset="0x104E9C8")]
		private sealed class <>c__DisplayClass31_0
		{
			[FieldOffset(Offset="0x10")]
			public AndroidRealTimeMultiplayerClient <>4__this;

			[FieldOffset(Offset="0x18")]
			public string invitationId;

			[Address(RVA="0x1EAD91C", Offset="0x1EAD91C", VA="0x1EAD91C")]
			public <>c__DisplayClass31_0()
			{
			}

			[Address(RVA="0x1EAD924", Offset="0x1EAD924", VA="0x1EAD924")]
			internal void <DeclineInvitation>b__1(Invitation invitation)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E9E8", Offset="0x104E9E8")]
		private sealed class <>c__DisplayClass32_0
		{
			[FieldOffset(Offset="0x10")]
			public string invitationId;

			[FieldOffset(Offset="0x18")]
			public Action<Invitation> callback;

			[FieldOffset(Offset="0x20")]
			public Action<bool> fail;

			[Address(RVA="0x1EADAA0", Offset="0x1EADAA0", VA="0x1EADAA0")]
			public <>c__DisplayClass32_0()
			{
			}

			[Address(RVA="0x1EADAA8", Offset="0x1EADAA8", VA="0x1EADAA8")]
			internal void <FindInvitation>b__0(AndroidJavaObject annotatedData)
			{
			}

			[Address(RVA="0x1EADF98", Offset="0x1EADF98", VA="0x1EADF98")]
			internal void <FindInvitation>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E9F8", Offset="0x104E9F8")]
		private sealed class <>c__DisplayClass38_0<T>
		{
			[FieldOffset(Offset="0x0")]
			public Action<T> toConvert;

			[Address(RVA="0x1D8D0AC", Offset="0x1D8D0AC", VA="0x1D8D0AC")]
			public <>c__DisplayClass38_0()
			{
			}

			[Address(RVA="0x1D8D0D8", Offset="0x1D8D0D8", VA="0x1D8D0D8")]
			internal void <ToOnGameThread>b__0(T val)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EA08", Offset="0x104EA08")]
		private sealed class <>c__DisplayClass38_1<T>
		{
			[FieldOffset(Offset="0x0")]
			public T val;

			[FieldOffset(Offset="0x0")]
			public AndroidRealTimeMultiplayerClient.<>c__DisplayClass38_0<T> CS$<>8__locals1;

			[Address(RVA="0x1D8D1E0", Offset="0x1D8D1E0", VA="0x1D8D1E0")]
			public <>c__DisplayClass38_1()
			{
			}

			[Address(RVA="0x1D8D20C", Offset="0x1D8D20C", VA="0x1D8D20C")]
			internal void <ToOnGameThread>b__1()
			{
			}
		}

		private class MessageReceivedListenerProxy : AndroidJavaProxy
		{
			[FieldOffset(Offset="0x20")]
			private AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener mListener;

			[Address(RVA="0x1EABF54", Offset="0x1EABF54", VA="0x1EABF54")]
			public MessageReceivedListenerProxy(AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listener)
			{
			}

			[Address(RVA="0x1EAE030", Offset="0x1EAE030", VA="0x1EAE030")]
			public void onRealTimeMessageReceived(bool isReliable, string senderId, byte[] data)
			{
			}
		}

		private class OnGameThreadForwardingListener
		{
			[FieldOffset(Offset="0x10")]
			private readonly RealTimeMultiplayerListener mListener;

			[Address(RVA="0x1EAE1A0", Offset="0x1EAE1A0", VA="0x1EAE1A0")]
			internal OnGameThreadForwardingListener(RealTimeMultiplayerListener listener)
			{
			}

			[Address(RVA="0x1EAE664", Offset="0x1EAE664", VA="0x1EAE664")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108DD7C", Offset="0x108DD7C")]
			private void <OnLeftRoom>b__4_0()
			{
			}

			[Address(RVA="0x1EAE304", Offset="0x1EAE304", VA="0x1EAE304")]
			public void OnLeftRoom()
			{
			}

			[Address(RVA="0x1EAE578", Offset="0x1EAE578", VA="0x1EAE578")]
			public void OnParticipantLeft(Participant participant)
			{
			}

			[Address(RVA="0x1EAE398", Offset="0x1EAE398", VA="0x1EAE398")]
			public void OnPeersConnected(string[] participantIds)
			{
			}

			[Address(RVA="0x1EAE484", Offset="0x1EAE484", VA="0x1EAE484")]
			public void OnPeersDisconnected(string[] participantIds)
			{
			}

			[Address(RVA="0x1EAE07C", Offset="0x1EAE07C", VA="0x1EAE07C")]
			public void OnRealTimeMessageReceived(bool isReliable, string senderId, byte[] data)
			{
			}

			[Address(RVA="0x1EAA7C0", Offset="0x1EAA7C0", VA="0x1EAA7C0")]
			public void OnRoomConnected(bool success)
			{
			}

			[Address(RVA="0x1EAE210", Offset="0x1EAE210", VA="0x1EAE210")]
			public void OnRoomSetupProgress(float percent)
			{
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10515E8", Offset="0x10515E8")]
			private sealed class <>c__DisplayClass2_0
			{
				[FieldOffset(Offset="0x10")]
				public AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener <>4__this;

				[FieldOffset(Offset="0x18")]
				public float percent;

				[Address(RVA="0x1EAE2F4", Offset="0x1EAE2F4", VA="0x1EAE2F4")]
				public <>c__DisplayClass2_0()
				{
				}

				[Address(RVA="0x1EAE71C", Offset="0x1EAE71C", VA="0x1EAE71C")]
				internal void <OnRoomSetupProgress>b__0()
				{
				}
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10515F8", Offset="0x10515F8")]
			private sealed class <>c__DisplayClass3_0
			{
				[FieldOffset(Offset="0x10")]
				public AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener <>4__this;

				[FieldOffset(Offset="0x18")]
				public bool success;

				[Address(RVA="0x1EAE2FC", Offset="0x1EAE2FC", VA="0x1EAE2FC")]
				public <>c__DisplayClass3_0()
				{
				}

				[Address(RVA="0x1EAE7F0", Offset="0x1EAE7F0", VA="0x1EAE7F0")]
				internal void <OnRoomConnected>b__0()
				{
				}
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051608", Offset="0x1051608")]
			private sealed class <>c__DisplayClass5_0
			{
				[FieldOffset(Offset="0x10")]
				public AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener <>4__this;

				[FieldOffset(Offset="0x18")]
				public string[] participantIds;

				[Address(RVA="0x1EAE47C", Offset="0x1EAE47C", VA="0x1EAE47C")]
				public <>c__DisplayClass5_0()
				{
				}

				[Address(RVA="0x1EAE8C4", Offset="0x1EAE8C4", VA="0x1EAE8C4")]
				internal void <OnPeersConnected>b__0()
				{
				}
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051618", Offset="0x1051618")]
			private sealed class <>c__DisplayClass6_0
			{
				[FieldOffset(Offset="0x10")]
				public AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener <>4__this;

				[FieldOffset(Offset="0x18")]
				public string[] participantIds;

				[Address(RVA="0x1EAE568", Offset="0x1EAE568", VA="0x1EAE568")]
				public <>c__DisplayClass6_0()
				{
				}

				[Address(RVA="0x1EAE994", Offset="0x1EAE994", VA="0x1EAE994")]
				internal void <OnPeersDisconnected>b__0()
				{
				}
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051628", Offset="0x1051628")]
			private sealed class <>c__DisplayClass7_0
			{
				[FieldOffset(Offset="0x10")]
				public AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener <>4__this;

				[FieldOffset(Offset="0x18")]
				public bool isReliable;

				[FieldOffset(Offset="0x20")]
				public string senderId;

				[FieldOffset(Offset="0x28")]
				public byte[] data;

				[Address(RVA="0x1EAE570", Offset="0x1EAE570", VA="0x1EAE570")]
				public <>c__DisplayClass7_0()
				{
				}

				[Address(RVA="0x1EAEA64", Offset="0x1EAEA64", VA="0x1EAEA64")]
				internal void <OnRealTimeMessageReceived>b__0()
				{
				}
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051638", Offset="0x1051638")]
			private sealed class <>c__DisplayClass8_0
			{
				[FieldOffset(Offset="0x10")]
				public AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener <>4__this;

				[FieldOffset(Offset="0x18")]
				public Participant participant;

				[Address(RVA="0x1EAE65C", Offset="0x1EAE65C", VA="0x1EAE65C")]
				public <>c__DisplayClass8_0()
				{
				}

				[Address(RVA="0x1EAEB50", Offset="0x1EAEB50", VA="0x1EAEB50")]
				internal void <OnParticipantLeft>b__0()
				{
				}
			}
		}

		private enum RoomStatus
		{
			[FieldOffset(Offset="0x0")]
			NotCreated = -1,
			[FieldOffset(Offset="0x0")]
			Inviting = 0,
			[FieldOffset(Offset="0x0")]
			AutoMatching = 1,
			[FieldOffset(Offset="0x0")]
			Connecting = 2,
			[FieldOffset(Offset="0x0")]
			Active = 3,
			[FieldOffset(Offset="0x0")]
			Deleted = 4
		}

		private class RoomStatusUpdateCallbackProxy : AndroidJavaProxy
		{
			[FieldOffset(Offset="0x20")]
			private AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener mListener;

			[FieldOffset(Offset="0x28")]
			private AndroidRealTimeMultiplayerClient mParent;

			[Address(RVA="0x1EABFDC", Offset="0x1EABFDC", VA="0x1EABFDC")]
			public RoomStatusUpdateCallbackProxy(AndroidRealTimeMultiplayerClient parent, AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listener)
			{
			}

			[Address(RVA="0x1EAEFC8", Offset="0x1EAEFC8", VA="0x1EAEFC8")]
			private void handleConnectedSetChanged(AndroidJavaObject room)
			{
			}

			[Address(RVA="0x1EAEC84", Offset="0x1EAEC84", VA="0x1EAEC84")]
			private void handleParticipantStatusChanged(AndroidJavaObject room, AndroidJavaObject participantIds)
			{
			}

			[Address(RVA="0x1EAEF50", Offset="0x1EAEF50", VA="0x1EAEF50")]
			public void onConnectedToRoom(AndroidJavaObject room)
			{
			}

			[Address(RVA="0x1EAF5D0", Offset="0x1EAF5D0", VA="0x1EAF5D0")]
			public void onDisconnectedFromRoom(AndroidJavaObject room)
			{
			}

			[Address(RVA="0x1EAF85C", Offset="0x1EAF85C", VA="0x1EAF85C")]
			public void onP2PConnected(string participantId)
			{
			}

			[Address(RVA="0x1EAF860", Offset="0x1EAF860", VA="0x1EAF860")]
			public void onP2PDisconnected(string participantId)
			{
			}

			[Address(RVA="0x1EAEF3C", Offset="0x1EAEF3C", VA="0x1EAEF3C")]
			public void onPeerDeclined(AndroidJavaObject room, AndroidJavaObject participantIds)
			{
			}

			[Address(RVA="0x1EAEC80", Offset="0x1EAEC80", VA="0x1EAEC80")]
			public void onPeerInvitedToRoom(AndroidJavaObject room, AndroidJavaObject participantIds)
			{
			}

			[Address(RVA="0x1EAEF40", Offset="0x1EAEF40", VA="0x1EAEF40")]
			public void onPeerJoined(AndroidJavaObject room, AndroidJavaObject participantIds)
			{
			}

			[Address(RVA="0x1EAEF44", Offset="0x1EAEF44", VA="0x1EAEF44")]
			public void onPeerLeft(AndroidJavaObject room, AndroidJavaObject participantIds)
			{
			}

			[Address(RVA="0x1EAF664", Offset="0x1EAF664", VA="0x1EAF664")]
			public void onPeersConnected(AndroidJavaObject room, AndroidJavaObject participantIds)
			{
			}

			[Address(RVA="0x1EAF75C", Offset="0x1EAF75C", VA="0x1EAF75C")]
			public void onPeersDisconnected(AndroidJavaObject room, AndroidJavaObject participantIds)
			{
			}

			[Address(RVA="0x1EAEC50", Offset="0x1EAEC50", VA="0x1EAEC50")]
			public void onRoomAutoMatching(AndroidJavaObject room)
			{
			}

			[Address(RVA="0x1EAEC20", Offset="0x1EAEC20", VA="0x1EAEC20")]
			public void onRoomConnecting(AndroidJavaObject room)
			{
			}
		}

		private class RoomUpdateCallbackProxy : AndroidJavaProxy
		{
			[FieldOffset(Offset="0x20")]
			private AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener mListener;

			[FieldOffset(Offset="0x28")]
			private AndroidRealTimeMultiplayerClient mParent;

			[Address(RVA="0x1EABEC8", Offset="0x1EABEC8", VA="0x1EABEC8")]
			public RoomUpdateCallbackProxy(AndroidRealTimeMultiplayerClient parent, AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listener)
			{
			}

			[Address(RVA="0x1EAF90C", Offset="0x1EAF90C", VA="0x1EAF90C")]
			public void onJoinedRoom(int statusCode, AndroidJavaObject room)
			{
			}

			[Address(RVA="0x1EAFD48", Offset="0x1EAFD48", VA="0x1EAFD48")]
			public void onLeftRoom(int statusCode, string roomId)
			{
			}

			[Address(RVA="0x1EAFD94", Offset="0x1EAFD94", VA="0x1EAFD94")]
			public void onRoomConnected(int statusCode, AndroidJavaObject room)
			{
			}

			[Address(RVA="0x1EAF864", Offset="0x1EAF864", VA="0x1EAF864")]
			public void onRoomCreated(int statusCode, AndroidJavaObject room)
			{
			}
		}
	}
}