using Il2CppDummyDll;
using System;

namespace Cinemachine.Utility
{
	internal abstract class GaussianWindow1d<T>
	{
		[FieldOffset(Offset="0x0")]
		protected T[] mData;

		[FieldOffset(Offset="0x0")]
		protected float[] mKernel;

		[FieldOffset(Offset="0x0")]
		protected float mKernelSum;

		[FieldOffset(Offset="0x0")]
		protected int mCurrentPos;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10694D4", Offset="0x10694D4")]
		[FieldOffset(Offset="0x0")]
		private float <Sigma>k__BackingField;

		public int KernelSize
		{
			[Address(RVA="0x211F734", Offset="0x211F734", VA="0x211F734")]
			get
			{
				return new int();
			}
		}

		public float Sigma
		{
			[Address(RVA="0x211F724", Offset="0x211F724", VA="0x211F724")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AF94", Offset="0x108AF94")]
			get
			{
				return new float();
			}
			[Address(RVA="0x211F72C", Offset="0x211F72C", VA="0x211F72C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AFA4", Offset="0x108AFA4")]
			private set
			{
			}
		}

		[Address(RVA="0x211F9EC", Offset="0x211F9EC", VA="0x211F9EC")]
		public GaussianWindow1d(float sigma, int maxKernelRadius = 10)
		{
		}

		[Address(RVA="0x211FA8C", Offset="0x211FA8C", VA="0x211FA8C")]
		public void AddValue(T v)
		{
		}

		protected abstract T Compute(int windowPos);

		[Address(RVA="0x211FC84", Offset="0x211FC84", VA="0x211FC84")]
		public T Filter(T v)
		{
			return null;
		}

		[Address(RVA="0x211F760", Offset="0x211F760", VA="0x211F760")]
		private void GenerateKernel(float sigma, int maxKernelRadius)
		{
		}

		[Address(RVA="0x211FA7C", Offset="0x211FA7C", VA="0x211FA7C")]
		public bool IsEmpty()
		{
			return new bool();
		}

		[Address(RVA="0x211FA74", Offset="0x211FA74", VA="0x211FA74")]
		public void Reset()
		{
		}

		[Address(RVA="0x211FD50", Offset="0x211FD50", VA="0x211FD50")]
		public T Value()
		{
			return null;
		}
	}
}