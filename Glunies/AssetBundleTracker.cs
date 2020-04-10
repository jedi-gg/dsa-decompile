using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Glunies
{
	public class AssetBundleTracker : ScriptableObject
	{
		[FieldOffset(Offset="0x18")]
		public string[] TrackedBundles;

		[FieldOffset(Offset="0x0")]
		private static HashSet<string> s_trackedBundles;

		public static int NumBundlesTracked
		{
			[Address(RVA="0x14FBBF8", Offset="0x14FBBF8", VA="0x14FBBF8")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x14FBE40", Offset="0x14FBE40", VA="0x14FBE40")]
		static AssetBundleTracker()
		{
		}

		[Address(RVA="0x14FBE38", Offset="0x14FBE38", VA="0x14FBE38")]
		public AssetBundleTracker()
		{
		}

		[Address(RVA="0x14FBDA8", Offset="0x14FBDA8", VA="0x14FBDA8")]
		public static void BundleRequested(string bundleName)
		{
		}

		[Address(RVA="0x14FBD24", Offset="0x14FBD24", VA="0x14FBD24")]
		public static void ClearTrackedBundles()
		{
		}

		[Address(RVA="0x14FBC7C", Offset="0x14FBC7C", VA="0x14FBC7C")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1089FFC", Offset="0x1089FFC")]
		public static IEnumerable<string> GetTrackedBundles()
		{
			return null;
		}

		[Address(RVA="0x14FBE34", Offset="0x14FBE34", VA="0x14FBE34")]
		public static void SaveToAsset(string assetPath)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050DB8", Offset="0x1050DB8")]
		private sealed class <GetTrackedBundles>d__3 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private string <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			private HashSet<string>.Enumerator <>7__wrap1;

			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Address(RVA="0x14FC0B0", Offset="0x14FC0B0", VA="0x14FC0B0", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x14FC120", Offset="0x14FC120", VA="0x14FC120", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x14FBCEC", Offset="0x14FBCEC", VA="0x14FBCEC")]
			[DebuggerHidden]
			public <GetTrackedBundles>d__3(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x14FBED0", Offset="0x14FBED0", VA="0x14FBED0")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x14FBF28", Offset="0x14FBF28", VA="0x14FBF28", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x14FC128", Offset="0x14FC128", VA="0x14FC128", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x14FC1C0", Offset="0x14FC1C0", VA="0x14FC1C0", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x14FC0B8", Offset="0x14FC0B8", VA="0x14FC0B8", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x14FBEB4", Offset="0x14FBEB4", VA="0x14FBEB4", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}