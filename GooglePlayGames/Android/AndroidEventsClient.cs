using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidEventsClient : IEventsClient
	{
		[FieldOffset(Offset="0x10")]
		private AndroidJavaObject mEventsClient;

		[Address(RVA="0x1621CD8", Offset="0x1621CD8", VA="0x1621CD8")]
		public AndroidEventsClient(AndroidJavaObject account)
		{
		}

		[Address(RVA="0x16280B8", Offset="0x16280B8", VA="0x16280B8")]
		private static GooglePlayGames.BasicApi.Events.Event CreateEvent(AndroidJavaObject eventJava)
		{
			return null;
		}

		[Address(RVA="0x16278BC", Offset="0x16278BC", VA="0x16278BC", Slot="4")]
		public void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback)
		{
		}

		[Address(RVA="0x1627BB4", Offset="0x1627BB4", VA="0x1627BB4", Slot="5")]
		public void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback)
		{
		}

		[Address(RVA="0x1627F60", Offset="0x1627F60", VA="0x1627F60", Slot="6")]
		public void IncrementEvent(string eventId, uint stepsToIncrement)
		{
		}

		[Address(RVA="0x1F5CA58", Offset="0x1F5CA58", VA="0x1F5CA58")]
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E858", Offset="0x104E858")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<ResponseStatus, List<IEvent>> callback;

			[Address(RVA="0x1627BAC", Offset="0x1627BAC", VA="0x1627BAC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x16282D8", Offset="0x16282D8", VA="0x16282D8")]
			internal void <FetchAllEvents>b__0(AndroidJavaObject annotatedData)
			{
			}

			[Address(RVA="0x16287EC", Offset="0x16287EC", VA="0x16287EC")]
			internal void <FetchAllEvents>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E868", Offset="0x104E868")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<ResponseStatus, IEvent> callback;

			[Address(RVA="0x1627F58", Offset="0x1627F58", VA="0x1627F58")]
			public <>c__DisplayClass3_0()
			{
			}

			[Address(RVA="0x1628888", Offset="0x1628888", VA="0x1628888")]
			internal void <FetchEvent>b__0(AndroidJavaObject annotatedData)
			{
			}

			[Address(RVA="0x1628D58", Offset="0x1628D58", VA="0x1628D58")]
			internal void <FetchEvent>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E878", Offset="0x104E878")]
		private sealed class <>c__DisplayClass5_0<T1, T2>
		{
			[FieldOffset(Offset="0x0")]
			public Action<T1, T2> toConvert;

			[Address(RVA="0x1D8C528", Offset="0x1D8C528", VA="0x1D8C528")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x1D8C554", Offset="0x1D8C554", VA="0x1D8C554")]
			internal void <ToOnGameThread>b__0(T1 val1, T2 val2)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E888", Offset="0x104E888")]
		private sealed class <>c__DisplayClass5_1<T1, T2>
		{
			[FieldOffset(Offset="0x0")]
			public T1 val1;

			[FieldOffset(Offset="0x0")]
			public T2 val2;

			[FieldOffset(Offset="0x0")]
			public AndroidEventsClient.<>c__DisplayClass5_0<T1, T2> CS$<>8__locals1;

			[Address(RVA="0x1D8C7D0", Offset="0x1D8C7D0", VA="0x1D8C7D0")]
			public <>c__DisplayClass5_1()
			{
			}

			[Address(RVA="0x1D8C7FC", Offset="0x1D8C7FC", VA="0x1D8C7FC")]
			internal void <ToOnGameThread>b__1()
			{
			}
		}
	}
}