using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Fenderrio.ImageWarp
{
	[Serializable]
	public class WarpManager
	{
		[FieldOffset(Offset="0x0")]
		private readonly static Vector2[] DEFAULT_UV_VEC2S;

		[FieldOffset(Offset="0x10")]
		private Vector2 m_xUvDiffVec;

		[FieldOffset(Offset="0x18")]
		private Vector2 m_yUvDiffVec;

		[FieldOffset(Offset="0x20")]
		private Vector3 m_cornerPositionBL;

		[FieldOffset(Offset="0x2C")]
		private Vector3 m_cornerPositionTL;

		[FieldOffset(Offset="0x38")]
		private Vector3 m_cornerPositionTR;

		[FieldOffset(Offset="0x44")]
		private Vector3 m_cornerPositionBR;

		[FieldOffset(Offset="0x50")]
		[SerializeField]
		private float m_width;

		[FieldOffset(Offset="0x54")]
		[SerializeField]
		private float m_height;

		[FieldOffset(Offset="0x58")]
		[SerializeField]
		private float m_preWarpWidth;

		[FieldOffset(Offset="0x5C")]
		[SerializeField]
		private float m_preWarpHeight;

		[FieldOffset(Offset="0x60")]
		private int m_vertRowLength;

		[FieldOffset(Offset="0x64")]
		private int m_numVertices;

		[FieldOffset(Offset="0x68")]
		private bool m_bezierEdges;

		[FieldOffset(Offset="0x6C")]
		private int m_vertIndex;

		[FieldOffset(Offset="0x70")]
		private int m_quadIndex;

		[FieldOffset(Offset="0x74")]
		private float m_progressX;

		[FieldOffset(Offset="0x78")]
		private float m_progressY;

		[FieldOffset(Offset="0x7C")]
		private Vector3 m_leftPoint;

		[FieldOffset(Offset="0x88")]
		private Vector3 m_rightPoint;

		[FieldOffset(Offset="0x98")]
		private BezierCurve m_topCurve;

		[FieldOffset(Offset="0xA0")]
		private BezierCurve m_leftCurve;

		[FieldOffset(Offset="0xA8")]
		private BezierCurve m_rightCurve;

		[FieldOffset(Offset="0xB0")]
		private BezierCurve m_bottomCurve;

		[FieldOffset(Offset="0xB8")]
		private Vector3[] m_topCurveVertOffsets;

		[FieldOffset(Offset="0xC0")]
		private Vector3[] m_leftCurveVertOffsets;

		[FieldOffset(Offset="0xC8")]
		private Vector3[] m_rightCurveVertOffsets;

		[FieldOffset(Offset="0xD0")]
		private Vector3[] m_bottomCurveVertOffsets;

		[FieldOffset(Offset="0xD8")]
		private Vector2[] m_tempMeshUvs;

		public float Height
		{
			[Address(RVA="0x12BFEDC", Offset="0x12BFEDC", VA="0x12BFEDC")]
			get
			{
				return new float();
			}
		}

		public float Width
		{
			[Address(RVA="0x12BFED4", Offset="0x12BFED4", VA="0x12BFED4")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0x12C6060", Offset="0x12C6060", VA="0x12C6060")]
		static WarpManager()
		{
		}

		[Address(RVA="0x12BD980", Offset="0x12BD980", VA="0x12BD980")]
		public WarpManager()
		{
		}

		[Address(RVA="0x12C5BA0", Offset="0x12C5BA0", VA="0x12C5BA0")]
		private void InitialiseBezierCurves()
		{
		}

		[Address(RVA="0x12C2DFC", Offset="0x12C2DFC", VA="0x12C2DFC")]
		public void PopulateMesh(Vector3[] a_meshVerts, WarpManager.WarpManagerInstanceData a_instanceData, ref WarpManager.WarpManagerMeshData a_meshData)
		{
		}

		[Address(RVA="0x12BDD74", Offset="0x12BDD74", VA="0x12BDD74")]
		public void PopulateMesh(Vector3[] a_meshVerts, Vector2[] a_meshUvs, WarpManager.WarpManagerInstanceData a_instanceData, ref WarpManager.WarpManagerMeshData a_meshData)
		{
		}

		[Address(RVA="0x12BFF44", Offset="0x12BFF44", VA="0x12BFF44")]
		public void ResetAll(IWarp a_warp)
		{
		}

		[Address(RVA="0x12C0510", Offset="0x12C0510", VA="0x12C0510")]
		public void ResetBezierHandlesToDefault(IWarp a_warp)
		{
		}

		[Address(RVA="0x12C0214", Offset="0x12C0214", VA="0x12C0214")]
		public void ResetCornerOffsets(IWarp a_warp)
		{
		}

		[Address(RVA="0x12BFFBC", Offset="0x12BFFBC", VA="0x12BFFBC")]
		public void ResetCropping(IWarp a_warp)
		{
		}

		private bool SetStruct<T>(ref T currentValue, T newValue)
		where T : struct
		{
			return new bool();
		}

		public class WarpManagerInstanceData
		{
			[FieldOffset(Offset="0x10")]
			public bool m_flipX;

			[FieldOffset(Offset="0x11")]
			public bool m_flipY;

			[FieldOffset(Offset="0x14")]
			public Vector3 m_cornerOffsetBL;

			[FieldOffset(Offset="0x20")]
			public Vector3 m_cornerOffsetTL;

			[FieldOffset(Offset="0x2C")]
			public Vector3 m_cornerOffsetTR;

			[FieldOffset(Offset="0x38")]
			public Vector3 m_cornerOffsetBR;

			[FieldOffset(Offset="0x44")]
			public int m_numSubdivisions;

			[FieldOffset(Offset="0x48")]
			public bool m_bezierEdges;

			[FieldOffset(Offset="0x4C")]
			public Vector3 m_topCurveHandleA;

			[FieldOffset(Offset="0x58")]
			public Vector3 m_topCurveHandleB;

			[FieldOffset(Offset="0x64")]
			public Vector3 m_leftCurveHandleA;

			[FieldOffset(Offset="0x70")]
			public Vector3 m_leftCurveHandleB;

			[FieldOffset(Offset="0x7C")]
			public Vector3 m_rightCurveHandleA;

			[FieldOffset(Offset="0x88")]
			public Vector3 m_rightCurveHandleB;

			[FieldOffset(Offset="0x94")]
			public Vector3 m_bottomCurveHandleA;

			[FieldOffset(Offset="0xA0")]
			public Vector3 m_bottomCurveHandleB;

			[FieldOffset(Offset="0xAC")]
			public float m_cropLeft;

			[FieldOffset(Offset="0xB0")]
			public float m_cropTop;

			[FieldOffset(Offset="0xB4")]
			public float m_cropRight;

			[FieldOffset(Offset="0xB8")]
			public float m_cropBottom;

			[Address(RVA="0x12BFEE4", Offset="0x12BFEE4", VA="0x12BFEE4")]
			public WarpManagerInstanceData()
			{
			}
		}

		public class WarpManagerMeshData
		{
			[FieldOffset(Offset="0x10")]
			public Vector3[] m_positions;

			[FieldOffset(Offset="0x18")]
			public Vector2[] m_uvs;

			[FieldOffset(Offset="0x20")]
			public int[] m_indices;

			[Address(RVA="0x12BDA38", Offset="0x12BDA38", VA="0x12BDA38")]
			public WarpManagerMeshData()
			{
			}
		}
	}
}