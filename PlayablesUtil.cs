using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public static class PlayablesUtil
{
	[Address(RVA="0x135DA3C", Offset="0x135DA3C", VA="0x135DA3C")]
	[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10711CC", Offset="0x10711CC")]
	public static IEnumerable<TimelineClip> GetClipsOnTracks<T>(PlayableDirector director)
	where T : TrackAsset
	{
		return null;
	}

	[Address(RVA="0x138E4D4", Offset="0x138E4D4", VA="0x138E4D4")]
	public static void SetGenericBindings<T>(PlayableDirector director, T boundObject)
	where T : Object
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D1DC", Offset="0x104D1DC")]
	private sealed class <GetClipsOnTracks>d__1<T> : IEnumerable<TimelineClip>, IEnumerable, IEnumerator<TimelineClip>, IEnumerator, IDisposable
	where T : TrackAsset
	{
		[FieldOffset(Offset="0x0")]
		private int <>1__state;

		[FieldOffset(Offset="0x0")]
		private TimelineClip <>2__current;

		[FieldOffset(Offset="0x0")]
		private int <>l__initialThreadId;

		[FieldOffset(Offset="0x0")]
		private PlayableDirector director;

		[FieldOffset(Offset="0x0")]
		public PlayableDirector <>3__director;

		[FieldOffset(Offset="0x0")]
		private IEnumerator<PlayableBinding> <>7__wrap1;

		[FieldOffset(Offset="0x0")]
		private IEnumerator<TimelineClip> <>7__wrap2;

		private TimelineClip System.Collections.Generic.IEnumerator<UnityEngine.Timeline.TimelineClip>.Current
		{
			[Address(RVA="0x2193B0C", Offset="0x2193B0C", VA="0x2193B0C", Slot="6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA="0x2193B7C", Offset="0x2193B7C", VA="0x2193B7C", Slot="9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2193314", Offset="0x2193314", VA="0x2193314")]
		[DebuggerHidden]
		public <GetClipsOnTracks>d__1(int u003cu003e1__state)
		{
		}

		[Address(RVA="0x219398C", Offset="0x219398C", VA="0x219398C")]
		private void <>m__Finally1()
		{
		}

		[Address(RVA="0x2193A4C", Offset="0x2193A4C", VA="0x2193A4C")]
		private void <>m__Finally2()
		{
		}

		[Address(RVA="0x21933F4", Offset="0x21933F4", VA="0x21933F4", Slot="8")]
		private bool MoveNext()
		{
			return new bool();
		}

		[Address(RVA="0x2193B84", Offset="0x2193B84", VA="0x2193B84", Slot="4")]
		[DebuggerHidden]
		private IEnumerator<TimelineClip> System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x2193C30", Offset="0x2193C30", VA="0x2193C30", Slot="5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x2193B14", Offset="0x2193B14", VA="0x2193B14", Slot="10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA="0x2193358", Offset="0x2193358", VA="0x2193358", Slot="7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}
	}
}