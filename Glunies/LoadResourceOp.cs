using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies
{
	public class LoadResourceOp : AAsyncOperation
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063F3C", Offset="0x1063F3C")]
		[FieldOffset(Offset="0x20")]
		private AssetLoadRequest <Request>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1063F4C", Offset="0x1063F4C")]
		[FieldOffset(Offset="0x28")]
		private UnityEngine.Object <Asset>k__BackingField;

		[FieldOffset(Offset="0x30")]
		private Procrastinator _procrastinator;

		public UnityEngine.Object Asset
		{
			[Address(RVA="0x1526C50", Offset="0x1526C50", VA="0x1526C50")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A234", Offset="0x108A234")]
			get
			{
				return null;
			}
			[Address(RVA="0x1526C58", Offset="0x1526C58", VA="0x1526C58")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A244", Offset="0x108A244")]
			private set
			{
			}
		}

		public Glunies.AssetId AssetId
		{
			[Address(RVA="0x1526C60", Offset="0x1526C60", VA="0x1526C60")]
			get
			{
				return null;
			}
		}

		public AssetLoadRequest Request
		{
			[Address(RVA="0x1526C40", Offset="0x1526C40", VA="0x1526C40")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A214", Offset="0x108A214")]
			get
			{
				return null;
			}
			[Address(RVA="0x1526C48", Offset="0x1526C48", VA="0x1526C48")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A224", Offset="0x108A224")]
			private set
			{
			}
		}

		[Address(RVA="0x1526C90", Offset="0x1526C90", VA="0x1526C90")]
		public LoadResourceOp(AssetLoadRequest request, Procrastinator procrastinator)
		{
		}

		[Address(RVA="0x1526EBC", Offset="0x1526EBC", VA="0x1526EBC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A254", Offset="0x108A254")]
		private void <StartOperation>b__11_0(AsyncOperation asyncOp)
		{
		}

		[Address(RVA="0x1526EB8", Offset="0x1526EB8", VA="0x1526EB8", Slot="8")]
		protected override void OnAbort()
		{
		}

		[Address(RVA="0x1526E14", Offset="0x1526E14", VA="0x1526E14", Slot="7")]
		protected override void OnUpdate()
		{
		}

		[Address(RVA="0x1526DE8", Offset="0x1526DE8", VA="0x1526DE8", Slot="6")]
		public override void Shutdown()
		{
		}

		[Address(RVA="0x1526D0C", Offset="0x1526D0C", VA="0x1526D0C")]
		public void StartOperation()
		{
		}
	}
}