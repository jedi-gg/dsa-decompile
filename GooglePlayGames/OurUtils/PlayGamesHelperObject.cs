using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GooglePlayGames.OurUtils
{
	public class PlayGamesHelperObject : MonoBehaviour
	{
		[FieldOffset(Offset="0x0")]
		private static PlayGamesHelperObject instance;

		[FieldOffset(Offset="0x8")]
		private static bool sIsDummy;

		[FieldOffset(Offset="0x10")]
		private static List<Action> sQueue;

		[FieldOffset(Offset="0x18")]
		private List<Action> localQueue;

		[FieldOffset(Offset="0x18")]
		private static bool sQueueEmpty;

		[FieldOffset(Offset="0x20")]
		private static List<Action<bool>> sPauseCallbackList;

		[FieldOffset(Offset="0x28")]
		private static List<Action<bool>> sFocusCallbackList;

		[Address(RVA="0x12D65C4", Offset="0x12D65C4", VA="0x12D65C4")]
		static PlayGamesHelperObject()
		{
		}

		[Address(RVA="0x12D57FC", Offset="0x12D57FC", VA="0x12D57FC")]
		public PlayGamesHelperObject()
		{
		}

		[Address(RVA="0x12D62CC", Offset="0x12D62CC", VA="0x12D62CC")]
		public static void AddFocusCallback(Action<bool> callback)
		{
		}

		[Address(RVA="0x12D6448", Offset="0x12D6448", VA="0x12D6448")]
		public static void AddPauseCallback(Action<bool> callback)
		{
		}

		[Address(RVA="0x12D586C", Offset="0x12D586C", VA="0x12D586C")]
		public void Awake()
		{
		}

		[Address(RVA="0x12D5668", Offset="0x12D5668", VA="0x12D5668")]
		public static void CreateObject()
		{
		}

		[Address(RVA="0x12D5D6C", Offset="0x12D5D6C", VA="0x12D5D6C")]
		public void OnApplicationFocus(bool focused)
		{
		}

		[Address(RVA="0x12D601C", Offset="0x12D601C", VA="0x12D601C")]
		public void OnApplicationPause(bool paused)
		{
		}

		[Address(RVA="0x12D58E8", Offset="0x12D58E8", VA="0x12D58E8")]
		public void OnDisable()
		{
		}

		[Address(RVA="0x12D63BC", Offset="0x12D63BC", VA="0x12D63BC")]
		public static bool RemoveFocusCallback(Action<bool> callback)
		{
			return new bool();
		}

		[Address(RVA="0x12D6538", Offset="0x12D6538", VA="0x12D6538")]
		public static bool RemovePauseCallback(Action<bool> callback)
		{
			return new bool();
		}

		[Address(RVA="0x12D59B8", Offset="0x12D59B8", VA="0x12D59B8")]
		public static void RunCoroutine(IEnumerator action)
		{
		}

		[Address(RVA="0x12D4094", Offset="0x12D4094", VA="0x12D4094")]
		public static void RunOnGameThread(Action action)
		{
		}

		[Address(RVA="0x12D5AF0", Offset="0x12D5AF0", VA="0x12D5AF0")]
		public void Update()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ED38", Offset="0x104ED38")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset="0x10")]
			public IEnumerator action;

			[Address(RVA="0x12D5AE8", Offset="0x12D5AE8", VA="0x12D5AE8")]
			public <>c__DisplayClass10_0()
			{
			}

			[Address(RVA="0x12D66BC", Offset="0x12D66BC", VA="0x12D66BC")]
			internal void <RunCoroutine>b__0()
			{
			}
		}
	}
}