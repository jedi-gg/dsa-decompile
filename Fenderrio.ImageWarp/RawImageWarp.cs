using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Fenderrio.ImageWarp
{
	[Attribute(Name="AddComponentMenu", RVA="0x10498E4", Offset="0x10498E4")]
	public class RawImageWarp : RawImage, IWarp
	{
		[FieldOffset(Offset="0xC8")]
		[SerializeField]
		private Vector3 m_cornerOffsetTL;

		[FieldOffset(Offset="0xD4")]
		[SerializeField]
		private Vector3 m_cornerOffsetTR;

		[FieldOffset(Offset="0xE0")]
		[SerializeField]
		private Vector3 m_cornerOffsetBR;

		[FieldOffset(Offset="0xEC")]
		[SerializeField]
		private Vector3 m_cornerOffsetBL;

		[FieldOffset(Offset="0xF8")]
		[SerializeField]
		private int m_numSubdivisions;

		[FieldOffset(Offset="0xFC")]
		[SerializeField]
		private bool m_bezierEdges;

		[FieldOffset(Offset="0x100")]
		[SerializeField]
		private Vector3 m_topBezierHandleA;

		[FieldOffset(Offset="0x10C")]
		[SerializeField]
		private Vector3 m_topBezierHandleB;

		[FieldOffset(Offset="0x118")]
		[SerializeField]
		private Vector3 m_leftBezierHandleA;

		[FieldOffset(Offset="0x124")]
		[SerializeField]
		private Vector3 m_leftBezierHandleB;

		[FieldOffset(Offset="0x130")]
		[SerializeField]
		private Vector3 m_rightBezierHandleA;

		[FieldOffset(Offset="0x13C")]
		[SerializeField]
		private Vector3 m_rightBezierHandleB;

		[FieldOffset(Offset="0x148")]
		[SerializeField]
		private Vector3 m_bottomBezierHandleA;

		[FieldOffset(Offset="0x154")]
		[SerializeField]
		private Vector3 m_bottomBezierHandleB;

		[FieldOffset(Offset="0x160")]
		[SerializeField]
		private float m_cropLeft;

		[FieldOffset(Offset="0x164")]
		[SerializeField]
		private float m_cropRight;

		[FieldOffset(Offset="0x168")]
		[SerializeField]
		private float m_cropTop;

		[FieldOffset(Offset="0x16C")]
		[SerializeField]
		private float m_cropBottom;

		[FieldOffset(Offset="0x170")]
		[SerializeField]
		private WarpManager m_warpManager;

		[FieldOffset(Offset="0x178")]
		private WarpManager.WarpManagerInstanceData m_warpManagerData;

		[FieldOffset(Offset="0x180")]
		private WarpManager.WarpManagerMeshData m_warpedMeshData;

		[FieldOffset(Offset="0x188")]
		private List<UIVertex> m_meshVerts;

		[FieldOffset(Offset="0x190")]
		private Vector3[] m_meshVertsVec3;

		[FieldOffset(Offset="0x198")]
		private Vector2[] m_meshUvsVec2;

		[FieldOffset(Offset="0x1A0")]
		private RectTransform m_rectTransform;

		[FieldOffset(Offset="0x1A8")]
		private Transform m_transform;

		[Attribute(Name="HideInInspector", RVA="0x10611F4", Offset="0x10611F4")]
		[FieldOffset(Offset="0x1B0")]
		[SerializeField]
		private bool m_initialised;

		public bool bezierEdges
		{
			[Address(RVA="0x12C3C70", Offset="0x12C3C70", VA="0x12C3C70", Slot="73")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x12C3C78", Offset="0x12C3C78", VA="0x12C3C78", Slot="74")]
			set
			{
			}
		}

		public Vector3 bottomBezierHandleA
		{
			[Address(RVA="0x12C4154", Offset="0x12C4154", VA="0x12C4154", Slot="83")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C4164", Offset="0x12C4164", VA="0x12C4164", Slot="84")]
			set
			{
			}
		}

		public Vector3 bottomBezierHandleB
		{
			[Address(RVA="0x12C420C", Offset="0x12C420C", VA="0x12C420C", Slot="85")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C421C", Offset="0x12C421C", VA="0x12C421C", Slot="86")]
			set
			{
			}
		}

		public Vector3 cornerOffsetBL
		{
			[Address(RVA="0x12C3B28", Offset="0x12C3B28", VA="0x12C3B28", Slot="67")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C3B34", Offset="0x12C3B34", VA="0x12C3B34", Slot="68")]
			set
			{
			}
		}

		public Vector3 cornerOffsetBR
		{
			[Address(RVA="0x12C3A74", Offset="0x12C3A74", VA="0x12C3A74", Slot="69")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C3A80", Offset="0x12C3A80", VA="0x12C3A80", Slot="70")]
			set
			{
			}
		}

		public Vector3 cornerOffsetTL
		{
			[Address(RVA="0x12C390C", Offset="0x12C390C", VA="0x12C390C", Slot="63")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C3918", Offset="0x12C3918", VA="0x12C3918", Slot="64")]
			set
			{
			}
		}

		public Vector3 cornerOffsetTR
		{
			[Address(RVA="0x12C39C0", Offset="0x12C39C0", VA="0x12C39C0", Slot="65")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C39CC", Offset="0x12C39CC", VA="0x12C39CC", Slot="66")]
			set
			{
			}
		}

		public float cropBottom
		{
			[Address(RVA="0x12C4480", Offset="0x12C4480", VA="0x12C4480", Slot="97")]
			get
			{
				return new float();
			}
			[Address(RVA="0x12C4488", Offset="0x12C4488", VA="0x12C4488", Slot="98")]
			set
			{
			}
		}

		public float cropLeft
		{
			[Address(RVA="0x12C42C4", Offset="0x12C42C4", VA="0x12C42C4", Slot="91")]
			get
			{
				return new float();
			}
			[Address(RVA="0x12C42CC", Offset="0x12C42CC", VA="0x12C42CC", Slot="92")]
			set
			{
			}
		}

		public float cropRight
		{
			[Address(RVA="0x12C4358", Offset="0x12C4358", VA="0x12C4358", Slot="95")]
			get
			{
				return new float();
			}
			[Address(RVA="0x12C4360", Offset="0x12C4360", VA="0x12C4360", Slot="96")]
			set
			{
			}
		}

		public float cropTop
		{
			[Address(RVA="0x12C43EC", Offset="0x12C43EC", VA="0x12C43EC", Slot="93")]
			get
			{
				return new float();
			}
			[Address(RVA="0x12C43F4", Offset="0x12C43F4", VA="0x12C43F4", Slot="94")]
			set
			{
			}
		}

		public Vector3 leftBezierHandleA
		{
			[Address(RVA="0x12C3E74", Offset="0x12C3E74", VA="0x12C3E74", Slot="87")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C3E84", Offset="0x12C3E84", VA="0x12C3E84", Slot="88")]
			set
			{
			}
		}

		public Vector3 leftBezierHandleB
		{
			[Address(RVA="0x12C3F2C", Offset="0x12C3F2C", VA="0x12C3F2C", Slot="89")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C3F3C", Offset="0x12C3F3C", VA="0x12C3F3C", Slot="90")]
			set
			{
			}
		}

		public int numSubdivisions
		{
			[Address(RVA="0x12C3BDC", Offset="0x12C3BDC", VA="0x12C3BDC", Slot="71")]
			get
			{
				return new int();
			}
			[Address(RVA="0x12C3BE4", Offset="0x12C3BE4", VA="0x12C3BE4", Slot="72")]
			set
			{
			}
		}

		public RectTransform RectTransformComponent
		{
			[Address(RVA="0x12C451C", Offset="0x12C451C", VA="0x12C451C")]
			get
			{
				return null;
			}
		}

		public Vector3 rightBezierHandleA
		{
			[Address(RVA="0x12C3FE4", Offset="0x12C3FE4", VA="0x12C3FE4", Slot="79")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C3FF4", Offset="0x12C3FF4", VA="0x12C3FF4", Slot="80")]
			set
			{
			}
		}

		public Vector3 rightBezierHandleB
		{
			[Address(RVA="0x12C409C", Offset="0x12C409C", VA="0x12C409C", Slot="81")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C40AC", Offset="0x12C40AC", VA="0x12C40AC", Slot="82")]
			set
			{
			}
		}

		public Vector3 topBezierHandleA
		{
			[Address(RVA="0x12C3D04", Offset="0x12C3D04", VA="0x12C3D04", Slot="75")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C3D14", Offset="0x12C3D14", VA="0x12C3D14", Slot="76")]
			set
			{
			}
		}

		public Vector3 topBezierHandleB
		{
			[Address(RVA="0x12C3DBC", Offset="0x12C3DBC", VA="0x12C3DBC", Slot="77")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C3DCC", Offset="0x12C3DCC", VA="0x12C3DCC", Slot="78")]
			set
			{
			}
		}

		public Transform TransformComponent
		{
			[Address(RVA="0x12C45AC", Offset="0x12C45AC", VA="0x12C45AC")]
			get
			{
				return null;
			}
		}

		public WarpManager warpManager
		{
			[Address(RVA="0x12C4514", Offset="0x12C4514", VA="0x12C4514")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x12C5400", Offset="0x12C5400", VA="0x12C5400")]
		public RawImageWarp()
		{
		}

		[Address(RVA="0x12C52D8", Offset="0x12C52D8", VA="0x12C52D8")]
		public void ForceUpdateGeometry()
		{
		}

		[Address(RVA="0x12C463C", Offset="0x12C463C", VA="0x12C463C", Slot="44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Address(RVA="0x12C5034", Offset="0x12C5034", VA="0x12C5034")]
		private void PopulateWarpManagerData()
		{
		}

		[Address(RVA="0x12C52E8", Offset="0x12C52E8", VA="0x12C52E8", Slot="99")]
		public void ResetAll()
		{
		}

		[Address(RVA="0x12C53B8", Offset="0x12C53B8", VA="0x12C53B8", Slot="102")]
		public void ResetBezierHandlesToDefault()
		{
		}

		[Address(RVA="0x12C5374", Offset="0x12C5374", VA="0x12C5374", Slot="101")]
		public void ResetCornerOffsets()
		{
		}

		[Address(RVA="0x12C5330", Offset="0x12C5330", VA="0x12C5330", Slot="100")]
		public void ResetCropping()
		{
		}

		[Address(RVA="0x1F644AC", Offset="0x1F644AC", VA="0x1F644AC")]
		private bool SetStruct<T>(ref T currentValue, T newValue)
		where T : struct
		{
			return new bool();
		}
	}
}