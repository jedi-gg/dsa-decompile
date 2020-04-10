using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Glunies
{
	public abstract class AAssetLoader : ILoggable<LogCategory>
	{
		[Attribute(Name="InjectAttribute", RVA="0x1063DCC", Offset="0x1063DCC")]
		[FieldOffset(Offset="0x10")]
		protected AssetIdCache _assetIdCache;

		[Attribute(Name="InjectAttribute", RVA="0x1063DDC", Offset="0x1063DDC")]
		[FieldOffset(Offset="0x18")]
		protected Procrastinator _procrastinator;

		[FieldOffset(Offset="0x20")]
		protected AssetHandle.Factory _assetHandleFactory;

		[FieldOffset(Offset="0x28")]
		private AsyncOperator<LoadResourceOp> _loadFallbackOperator;

		[FieldOffset(Offset="0x30")]
		private int _lockRefCount;

		[FieldOffset(Offset="0x38")]
		private List<Action> _lockedCallbacks;

		protected bool IsLocked
		{
			[Address(RVA="0x14F3E78", Offset="0x14F3E78", VA="0x14F3E78")]
			get
			{
				return new bool();
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x14F3C98", Offset="0x14F3C98", VA="0x14F3C98", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		protected virtual int NumActiveRequests
		{
			[Address(RVA="0x14F469C", Offset="0x14F469C", VA="0x14F469C", Slot="9")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x14F3CA0", Offset="0x14F3CA0", VA="0x14F3CA0")]
		public AAssetLoader()
		{
		}

		[Address(RVA="0x14F4574", Offset="0x14F4574", VA="0x14F4574")]
		protected void CloseRequest(AssetLoadRequest request)
		{
		}

		public abstract IAsyncRequest LoadAssetAsync(string assetId, bool persistent, Action<AssetHandle> finished);

		[Address(RVA="0x14F3E88", Offset="0x14F3E88", VA="0x14F3E88")]
		public IAsyncRequest LoadFallbackAsync(string assetId, bool persistent, Action<AssetHandle> finished)
		{
			return null;
		}

		[Address(RVA="0x14F4300", Offset="0x14F4300", VA="0x14F4300")]
		private void LoadFallbackOpFinished(LoadResourceOp operation)
		{
		}

		[Address(RVA="0x14F41D0", Offset="0x14F41D0", VA="0x14F41D0")]
		public void Lock(Action locked)
		{
		}

		[Address(RVA="0x14F4120", Offset="0x14F4120", VA="0x14F4120")]
		protected void RequestFallback(AssetLoadRequest request)
		{
		}

		[Address(RVA="0x14F3DA4", Offset="0x14F3DA4", VA="0x14F3DA4", Slot="5")]
		public virtual void Shutdown()
		{
		}

		[Address(RVA="0x14F42A0", Offset="0x14F42A0", VA="0x14F42A0", Slot="8")]
		public virtual void TickUpdate()
		{
		}

		public abstract void UnloadAsset(AssetHandle asset);

		[Address(RVA="0x14F4290", Offset="0x14F4290", VA="0x14F4290")]
		public void Unlock()
		{
		}
	}
}