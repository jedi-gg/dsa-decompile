using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class MaterialPropertyStack : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	public static int INVALID_STACK_ID;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FB00", Offset="0x105FB00")]
	[FieldOffset(Offset="0x18")]
	private MaterialPropertyStack.StackContainerFloat <Floats>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FB10", Offset="0x105FB10")]
	[FieldOffset(Offset="0x20")]
	private MaterialPropertyStack.StackContainerColor <Colors>k__BackingField;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Renderer[] _presetRenderers;

	[FieldOffset(Offset="0x30")]
	private bool _initialized;

	public MaterialPropertyStack.StackContainerColor Colors
	{
		[Address(RVA="0x11DAD34", Offset="0x11DAD34", VA="0x11DAD34")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107119C", Offset="0x107119C")]
		get
		{
			return null;
		}
		[Address(RVA="0x11DAD3C", Offset="0x11DAD3C", VA="0x11DAD3C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10711AC", Offset="0x10711AC")]
		private set
		{
		}
	}

	public MaterialPropertyStack.StackContainerFloat Floats
	{
		[Address(RVA="0x11DAD24", Offset="0x11DAD24", VA="0x11DAD24")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107117C", Offset="0x107117C")]
		get
		{
			return null;
		}
		[Address(RVA="0x11DAD2C", Offset="0x11DAD2C", VA="0x11DAD2C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107118C", Offset="0x107118C")]
		private set
		{
		}
	}

	[Address(RVA="0x11DAF98", Offset="0x11DAF98", VA="0x11DAF98")]
	static MaterialPropertyStack()
	{
	}

	[Address(RVA="0x11DAF90", Offset="0x11DAF90", VA="0x11DAF90")]
	public MaterialPropertyStack()
	{
	}

	[Address(RVA="0x11DAD44", Offset="0x11DAD44", VA="0x11DAD44")]
	public void Initialize(List<Renderer> renderers = // 
	// Current member / type: System.Void MaterialPropertyStack::Initialize(System.Collections.Generic.List`1<UnityEngine.Renderer>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void Initialize(System.Collections.Generic.List<UnityEngine.Renderer>)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	public abstract class StackContainer<T>
	{
		[FieldOffset(Offset="0x0")]
		private const int INITIAL_STACK_MAP_SIZE = 2;

		[FieldOffset(Offset="0x0")]
		private const int INITIAL_STACK_SIZE = 5;

		[FieldOffset(Offset="0x0")]
		private const int INITIAL_VALUE_POOL_SIZE = 5;

		[FieldOffset(Offset="0x0")]
		private int _currentStackId;

		[FieldOffset(Offset="0x0")]
		private List<Renderer> _renderers;

		[FieldOffset(Offset="0x0")]
		private Dictionary<Renderer, Dictionary<int, T>> _initialValues;

		[FieldOffset(Offset="0x0")]
		private Dictionary<int, List<MaterialPropertyStack.StackedValue<T>>> _stacks;

		[FieldOffset(Offset="0x0")]
		private Queue<MaterialPropertyStack.StackedValue<T>> _svPool;

		[Address(RVA="0x1D8F4C8", Offset="0x1D8F4C8", VA="0x1D8F4C8")]
		public StackContainer(List<Renderer> renderers)
		{
		}

		[Address(RVA="0x1D8FB48", Offset="0x1D8FB48", VA="0x1D8FB48")]
		public void End(int stackId, int propertyId)
		{
		}

		[Address(RVA="0x1D8F648", Offset="0x1D8F648", VA="0x1D8F648")]
		public T Get(int propertyId)
		{
			return null;
		}

		protected abstract T GetProperty(Material mat, int propertyId);

		[Address(RVA="0x1D8FF64", Offset="0x1D8FF64", VA="0x1D8FF64")]
		private List<MaterialPropertyStack.StackedValue<T>> GetStack(int propertyId)
		{
			return null;
		}

		[Address(RVA="0x1D8F728", Offset="0x1D8F728", VA="0x1D8F728")]
		public void Set(ref int stackId, int propertyId, T value)
		{
		}

		protected abstract void SetProperty(Material mat, int propertyId, T value);
	}

	public class StackContainerColor : MaterialPropertyStack.StackContainer<Color>
	{
		[Address(RVA="0x11DAF30", Offset="0x11DAF30", VA="0x11DAF30")]
		public StackContainerColor(List<Renderer> renderers)
		{
		}

		[Address(RVA="0x11DB004", Offset="0x11DB004", VA="0x11DB004", Slot="5")]
		protected override Color GetProperty(Material mat, int propertyId)
		{
			return new Color();
		}

		[Address(RVA="0x11DAF9C", Offset="0x11DAF9C", VA="0x11DAF9C", Slot="4")]
		protected override void SetProperty(Material mat, int propertyId, Color value)
		{
		}
	}

	public class StackContainerFloat : MaterialPropertyStack.StackContainer<float>
	{
		[Address(RVA="0x11DAED0", Offset="0x11DAED0", VA="0x11DAED0")]
		public StackContainerFloat(List<Renderer> renderers)
		{
		}

		[Address(RVA="0x11DB084", Offset="0x11DB084", VA="0x11DB084", Slot="5")]
		protected override float GetProperty(Material mat, int propertyId)
		{
			return new float();
		}

		[Address(RVA="0x11DB03C", Offset="0x11DB03C", VA="0x11DB03C", Slot="4")]
		protected override void SetProperty(Material mat, int propertyId, float value)
		{
		}
	}

	private class StackedValue<T>
	{
		[FieldOffset(Offset="0x0")]
		public int Id;

		[FieldOffset(Offset="0x0")]
		public T Value;

		[Address(RVA="0x1D91FF8", Offset="0x1D91FF8", VA="0x1D91FF8")]
		public StackedValue()
		{
		}
	}
}