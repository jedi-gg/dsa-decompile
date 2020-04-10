using Il2CppDummyDll;
using ModestTree.Util;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class GuiRenderableManager
	{
		[FieldOffset(Offset="0x10")]
		private List<GuiRenderableManager.RenderableInfo> _renderables;

		[Address(RVA="0x1838198", Offset="0x1838198", VA="0x1838198")]
		public GuiRenderableManager([Attribute(Name="InjectAttribute", RVA="0x10913E0", Offset="0x10913E0")] List<IGuiRenderable> renderables, [Attribute(Name="InjectAttribute", RVA="0x1091428", Offset="0x1091428")] List<ValuePair<Type, int>> priorities)
		{
		}

		[Address(RVA="0x1838618", Offset="0x1838618", VA="0x1838618")]
		public void OnGui()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E128", Offset="0x104E128")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GuiRenderableManager.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<ValuePair<Type, int>, int> <>9__1_2;

			[FieldOffset(Offset="0x10")]
			public static Func<GuiRenderableManager.RenderableInfo, int> <>9__1_0;

			[Address(RVA="0x183893C", Offset="0x183893C", VA="0x183893C")]
			static <>c()
			{
			}

			[Address(RVA="0x18389A0", Offset="0x18389A0", VA="0x18389A0")]
			public <>c()
			{
			}

			[Address(RVA="0x18389D4", Offset="0x18389D4", VA="0x18389D4")]
			internal int <.ctor>b__1_0(GuiRenderableManager.RenderableInfo x)
			{
				return new int();
			}

			[Address(RVA="0x18389A8", Offset="0x18389A8", VA="0x18389A8")]
			internal int <.ctor>b__1_2(ValuePair<Type, int> x)
			{
				return new int();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E118", Offset="0x104E118")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x10")]
			public IGuiRenderable renderable;

			[Address(RVA="0x18385D4", Offset="0x18385D4", VA="0x18385D4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x1838A00", Offset="0x1838A00", VA="0x1838A00")]
			internal bool <.ctor>b__1(ValuePair<Type, int> x)
			{
				return new bool();
			}
		}

		private class RenderableInfo
		{
			[FieldOffset(Offset="0x10")]
			public IGuiRenderable Renderable;

			[FieldOffset(Offset="0x18")]
			public int Priority;

			[Address(RVA="0x18385DC", Offset="0x18385DC", VA="0x18385DC")]
			public RenderableInfo(IGuiRenderable renderable, int priority)
			{
			}
		}
	}
}