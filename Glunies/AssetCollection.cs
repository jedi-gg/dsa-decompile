using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Glunies
{
	public class AssetCollection : ILoggable<LogCategory>
	{
		[FieldOffset(Offset="0x10")]
		private List<AssetHandle> _handles;

		[FieldOffset(Offset="0x18")]
		private Dictionary<string, Stack<AssetHandle>> _available;

		[FieldOffset(Offset="0x20")]
		private List<AssetHandle> _inUse;

		public LogCategory LogCategory
		{
			[Address(RVA="0x14FC1C4", Offset="0x14FC1C4", VA="0x14FC1C4", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		public int NumAssets
		{
			[Address(RVA="0x14FC1CC", Offset="0x14FC1CC", VA="0x14FC1CC")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x14FC22C", Offset="0x14FC22C", VA="0x14FC22C")]
		private AssetCollection(IEnumerable<AssetHandle> handles)
		{
		}

		[Address(RVA="0x14FC5D4", Offset="0x14FC5D4", VA="0x14FC5D4")]
		public AssetHandle Get(string assetId, bool logError = true)
		{
			return null;
		}

		[Address(RVA="0x14FC518", Offset="0x14FC518", VA="0x14FC518")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x108A060", Offset="0x108A060")]
		public IEnumerable<AssetHandle> GetAssetHandles()
		{
			return null;
		}

		[Address(RVA="0x14FC750", Offset="0x14FC750", VA="0x14FC750")]
		public AssetHandle GetUnpooledHandle(string assetId)
		{
			return null;
		}

		[Address(RVA="0x14FC3DC", Offset="0x14FC3DC", VA="0x14FC3DC")]
		private void MakeAvailable(AssetHandle assetHandle)
		{
		}

		[Address(RVA="0x14FC8B8", Offset="0x14FC8B8", VA="0x14FC8B8")]
		public void Return(AssetHandle assetHandle)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050DC8", Offset="0x1050DC8")]
		private sealed class <GetAssetHandles>d__5 : IEnumerable<AssetHandle>, IEnumerable, IEnumerator<AssetHandle>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private AssetHandle <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			public AssetCollection <>4__this;

			[FieldOffset(Offset="0x30")]
			private List<AssetHandle>.Enumerator <>7__wrap1;

			private AssetHandle System.Collections.Generic.IEnumerator<Glunies.AssetHandle>.Current
			{
				[Address(RVA="0x14FCB6C", Offset="0x14FCB6C", VA="0x14FCB6C", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x14FCBDC", Offset="0x14FCBDC", VA="0x14FCBDC", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x14FC59C", Offset="0x14FC59C", VA="0x14FC59C")]
			[DebuggerHidden]
			public <GetAssetHandles>d__5(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x14FC9A0", Offset="0x14FC9A0", VA="0x14FC9A0")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x14FC9F8", Offset="0x14FC9F8", VA="0x14FC9F8", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x14FCBE4", Offset="0x14FCBE4", VA="0x14FCBE4", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<AssetHandle> System.Collections.Generic.IEnumerable<Glunies.AssetHandle>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x14FCC94", Offset="0x14FCC94", VA="0x14FCC94", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x14FCB74", Offset="0x14FCB74", VA="0x14FCB74", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x14FC984", Offset="0x14FC984", VA="0x14FC984", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		public class Factory
		{
			[Address(RVA="0x14FCCF8", Offset="0x14FCCF8", VA="0x14FCCF8")]
			public Factory()
			{
			}

			[Address(RVA="0x14FCC98", Offset="0x14FCC98", VA="0x14FCC98")]
			public AssetCollection Create(IEnumerable<AssetHandle> handles)
			{
				return null;
			}
		}
	}
}