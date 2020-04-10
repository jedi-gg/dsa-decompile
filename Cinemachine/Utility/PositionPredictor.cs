using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine.Utility
{
	internal class PositionPredictor
	{
		[FieldOffset(Offset="0x10")]
		private Vector3 m_Position;

		[FieldOffset(Offset="0x0")]
		private const float kSmoothingDefault = 10f;

		[FieldOffset(Offset="0x1C")]
		private float mSmoothing;

		[FieldOffset(Offset="0x20")]
		private GaussianWindow1D_Vector3 m_Velocity;

		[FieldOffset(Offset="0x28")]
		private GaussianWindow1D_Vector3 m_Accel;

		public bool IsEmpty
		{
			[Address(RVA="0x1461F70", Offset="0x1461F70", VA="0x1461F70")]
			get
			{
				return new bool();
			}
		}

		public float Smoothing
		{
			[Address(RVA="0x1461E74", Offset="0x1461E74", VA="0x1461E74")]
			get
			{
				return new float();
			}
			[Address(RVA="0x1461E7C", Offset="0x1461E7C", VA="0x1461E7C")]
			set
			{
			}
		}

		[Address(RVA="0x14625AC", Offset="0x14625AC", VA="0x14625AC")]
		public PositionPredictor()
		{
		}

		[Address(RVA="0x1462054", Offset="0x1462054", VA="0x1462054")]
		public void AddPosition(Vector3 pos)
		{
		}

		[Address(RVA="0x1462274", Offset="0x1462274", VA="0x1462274")]
		public Vector3 PredictPosition(float lookaheadTime)
		{
			return new Vector3();
		}

		[Address(RVA="0x1461FD0", Offset="0x1461FD0", VA="0x1461FD0")]
		public void Reset()
		{
		}
	}
}