using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class EmoteViewer : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	public EmoteData emoteDataObject;

	[FieldOffset(Offset="0x20")]
	private Texture[] sprites;

	[FieldOffset(Offset="0x28")]
	private float animationSpeed;

	[FieldOffset(Offset="0x2C")]
	private float internalSpeed;

	[FieldOffset(Offset="0x30")]
	private RawImage image;

	[FieldOffset(Offset="0x38")]
	private bool playing;

	[FieldOffset(Offset="0x40")]
	private string state;

	[FieldOffset(Offset="0x48")]
	private Color bgCol1;

	[FieldOffset(Offset="0x58")]
	private Color bgCol2;

	[FieldOffset(Offset="0x68")]
	private int uniqueSprites;

	[FieldOffset(Offset="0x6C")]
	private float percent;

	[Address(RVA="0x120C720", Offset="0x120C720", VA="0x120C720")]
	public EmoteViewer()
	{
	}

	[Address(RVA="0x120BED8", Offset="0x120BED8", VA="0x120BED8")]
	private void Awake()
	{
	}

	[Address(RVA="0x120C0C0", Offset="0x120C0C0", VA="0x120C0C0")]
	private Texture[] GrabSprites()
	{
		return null;
	}

	[Address(RVA="0x120C0EC", Offset="0x120C0EC", VA="0x120C0EC")]
	private void OnGUI()
	{
	}

	[Address(RVA="0x120C538", Offset="0x120C538", VA="0x120C538")]
	[Attribute(Name="IteratorStateMachineAttribute", RVA="0x106DC20", Offset="0x106DC20")]
	private IEnumerator PlayEmote()
	{
		return null;
	}

	[Address(RVA="0x120C5AC", Offset="0x120C5AC", VA="0x120C5AC")]
	private void Reload()
	{
	}

	[Address(RVA="0x120C67C", Offset="0x120C67C", VA="0x120C67C")]
	private void Update()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AD2C", Offset="0x104AD2C")]
	private sealed class <PlayEmote>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset="0x10")]
		private int <>1__state;

		[FieldOffset(Offset="0x18")]
		private object <>2__current;

		[FieldOffset(Offset="0x20")]
		public EmoteViewer <>4__this;

		[FieldOffset(Offset="0x28")]
		private int <i>5__2;

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA="0x120C9A8", Offset="0x120C9A8", VA="0x120C9A8", Slot="4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA="0x120CA18", Offset="0x120CA18", VA="0x120CA18", Slot="7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x120C6F4", Offset="0x120C6F4", VA="0x120C6F4")]
		[DebuggerHidden]
		public <PlayEmote>d__14(int u003cu003e1__state)
		{
		}

		[Address(RVA="0x120C818", Offset="0x120C818", VA="0x120C818", Slot="6")]
		private bool MoveNext()
		{
			return new bool();
		}

		[Address(RVA="0x120C9B0", Offset="0x120C9B0", VA="0x120C9B0", Slot="8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA="0x120C814", Offset="0x120C814", VA="0x120C814", Slot="5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}
	}
}