using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Fenderrio.ImageWarp
{
	[Attribute(Name="AddComponentMenu", RVA="0x1049810", Offset="0x1049810")]
	public class NativeImageWarp : NativeTextureRenderer, IWarp
	{
		[FieldOffset(Offset="0x80")]
		[SerializeField]
		private Vector3 m_cornerOffsetTL;

		[FieldOffset(Offset="0x8C")]
		private Vector3 m_cornerOffsetTLCache;

		[FieldOffset(Offset="0x98")]
		[SerializeField]
		private Vector3 m_cornerOffsetTR;

		[FieldOffset(Offset="0xA4")]
		private Vector3 m_cornerOffsetTRCache;

		[FieldOffset(Offset="0xB0")]
		[SerializeField]
		private Vector3 m_cornerOffsetBR;

		[FieldOffset(Offset="0xBC")]
		private Vector3 m_cornerOffsetBRCache;

		[FieldOffset(Offset="0xC8")]
		[SerializeField]
		private Vector3 m_cornerOffsetBL;

		[FieldOffset(Offset="0xD4")]
		private Vector3 m_cornerOffsetBLCache;

		[FieldOffset(Offset="0xE0")]
		[SerializeField]
		private int m_numSubdivisions;

		[FieldOffset(Offset="0xE4")]
		private int m_numSubdivisionsCache;

		[FieldOffset(Offset="0xE8")]
		[SerializeField]
		private bool m_bezierEdges;

		[FieldOffset(Offset="0xE9")]
		private bool m_bezierEdgesCache;

		[FieldOffset(Offset="0xEC")]
		[SerializeField]
		private Vector3 m_topBezierHandleA;

		[FieldOffset(Offset="0xF8")]
		private Vector3 m_topBezierHandleACache;

		[FieldOffset(Offset="0x104")]
		[SerializeField]
		private Vector3 m_topBezierHandleB;

		[FieldOffset(Offset="0x110")]
		private Vector3 m_topBezierHandleBCache;

		[FieldOffset(Offset="0x11C")]
		[SerializeField]
		private Vector3 m_leftBezierHandleA;

		[FieldOffset(Offset="0x128")]
		private Vector3 m_leftBezierHandleACache;

		[FieldOffset(Offset="0x134")]
		[SerializeField]
		private Vector3 m_leftBezierHandleB;

		[FieldOffset(Offset="0x140")]
		private Vector3 m_leftBezierHandleBCache;

		[FieldOffset(Offset="0x14C")]
		[SerializeField]
		private Vector3 m_rightBezierHandleA;

		[FieldOffset(Offset="0x158")]
		private Vector3 m_rightBezierHandleACache;

		[FieldOffset(Offset="0x164")]
		[SerializeField]
		private Vector3 m_rightBezierHandleB;

		[FieldOffset(Offset="0x170")]
		private Vector3 m_rightBezierHandleBCache;

		[FieldOffset(Offset="0x17C")]
		[SerializeField]
		private Vector3 m_bottomBezierHandleA;

		[FieldOffset(Offset="0x188")]
		private Vector3 m_bottomBezierHandleACache;

		[FieldOffset(Offset="0x194")]
		[SerializeField]
		private Vector3 m_bottomBezierHandleB;

		[FieldOffset(Offset="0x1A0")]
		private Vector3 m_bottomBezierHandleBCache;

		[FieldOffset(Offset="0x1AC")]
		[SerializeField]
		private float m_cropLeft;

		[FieldOffset(Offset="0x1B0")]
		private float m_cropLeftCache;

		[FieldOffset(Offset="0x1B4")]
		[SerializeField]
		private float m_cropRight;

		[FieldOffset(Offset="0x1B8")]
		private float m_cropRightCache;

		[FieldOffset(Offset="0x1BC")]
		[SerializeField]
		private float m_cropTop;

		[FieldOffset(Offset="0x1C0")]
		private float m_cropTopCache;

		[FieldOffset(Offset="0x1C4")]
		[SerializeField]
		private float m_cropBottom;

		[FieldOffset(Offset="0x1C8")]
		private float m_cropBottomCache;

		[FieldOffset(Offset="0x1D0")]
		[SerializeField]
		private WarpManager m_warpManager;

		[FieldOffset(Offset="0x1D8")]
		private WarpManager.WarpManagerInstanceData m_warpManagerData;

		[FieldOffset(Offset="0x1E0")]
		private WarpManager.WarpManagerMeshData m_warpedMeshData;

		[FieldOffset(Offset="0x1E8")]
		private Color[] m_meshColours;

		[FieldOffset(Offset="0x1F0")]
		private Transform m_transform;

		[Attribute(Name="HideInInspector", RVA="0x106104C", Offset="0x106104C")]
		[FieldOffset(Offset="0x1F8")]
		[SerializeField]
		private bool m_initialised;

		public bool bezierEdges
		{
			[Address(RVA="0x12C1098", Offset="0x12C1098", VA="0x12C1098", Slot="15")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x12C10A0", Offset="0x12C10A0", VA="0x12C10A0", Slot="16")]
			set
			{
			}
		}

		public Vector3 bottomBezierHandleA
		{
			[Address(RVA="0x12C1578", Offset="0x12C1578", VA="0x12C1578", Slot="25")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C1588", Offset="0x12C1588", VA="0x12C1588", Slot="26")]
			set
			{
			}
		}

		public Vector3 bottomBezierHandleB
		{
			[Address(RVA="0x12C1630", Offset="0x12C1630", VA="0x12C1630", Slot="27")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C1640", Offset="0x12C1640", VA="0x12C1640", Slot="28")]
			set
			{
			}
		}

		public Vector3 cornerOffsetBL
		{
			[Address(RVA="0x12C0F50", Offset="0x12C0F50", VA="0x12C0F50", Slot="9")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C0F5C", Offset="0x12C0F5C", VA="0x12C0F5C", Slot="10")]
			set
			{
			}
		}

		public Vector3 cornerOffsetBR
		{
			[Address(RVA="0x12C0E9C", Offset="0x12C0E9C", VA="0x12C0E9C", Slot="11")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C0EA8", Offset="0x12C0EA8", VA="0x12C0EA8", Slot="12")]
			set
			{
			}
		}

		public Vector3 cornerOffsetTL
		{
			[Address(RVA="0x12C0D34", Offset="0x12C0D34", VA="0x12C0D34", Slot="5")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C0D40", Offset="0x12C0D40", VA="0x12C0D40", Slot="6")]
			set
			{
			}
		}

		public Vector3 cornerOffsetTR
		{
			[Address(RVA="0x12C0DE8", Offset="0x12C0DE8", VA="0x12C0DE8", Slot="7")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C0DF4", Offset="0x12C0DF4", VA="0x12C0DF4", Slot="8")]
			set
			{
			}
		}

		public float cropBottom
		{
			[Address(RVA="0x12C18A4", Offset="0x12C18A4", VA="0x12C18A4", Slot="39")]
			get
			{
				return new float();
			}
			[Address(RVA="0x12C18AC", Offset="0x12C18AC", VA="0x12C18AC", Slot="40")]
			set
			{
			}
		}

		public float cropLeft
		{
			[Address(RVA="0x12C16E8", Offset="0x12C16E8", VA="0x12C16E8", Slot="33")]
			get
			{
				return new float();
			}
			[Address(RVA="0x12C16F0", Offset="0x12C16F0", VA="0x12C16F0", Slot="34")]
			set
			{
			}
		}

		public float cropRight
		{
			[Address(RVA="0x12C177C", Offset="0x12C177C", VA="0x12C177C", Slot="37")]
			get
			{
				return new float();
			}
			[Address(RVA="0x12C1784", Offset="0x12C1784", VA="0x12C1784", Slot="38")]
			set
			{
			}
		}

		public float cropTop
		{
			[Address(RVA="0x12C1810", Offset="0x12C1810", VA="0x12C1810", Slot="35")]
			get
			{
				return new float();
			}
			[Address(RVA="0x12C1818", Offset="0x12C1818", VA="0x12C1818", Slot="36")]
			set
			{
			}
		}

		public Vector3 leftBezierHandleA
		{
			[Address(RVA="0x12C1298", Offset="0x12C1298", VA="0x12C1298", Slot="29")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C12A8", Offset="0x12C12A8", VA="0x12C12A8", Slot="30")]
			set
			{
			}
		}

		public Vector3 leftBezierHandleB
		{
			[Address(RVA="0x12C1350", Offset="0x12C1350", VA="0x12C1350", Slot="31")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C1360", Offset="0x12C1360", VA="0x12C1360", Slot="32")]
			set
			{
			}
		}

		public int numSubdivisions
		{
			[Address(RVA="0x12C1004", Offset="0x12C1004", VA="0x12C1004", Slot="13")]
			get
			{
				return new int();
			}
			[Address(RVA="0x12C100C", Offset="0x12C100C", VA="0x12C100C", Slot="14")]
			set
			{
			}
		}

		public Vector3 rightBezierHandleA
		{
			[Address(RVA="0x12C1408", Offset="0x12C1408", VA="0x12C1408", Slot="21")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C1418", Offset="0x12C1418", VA="0x12C1418", Slot="22")]
			set
			{
			}
		}

		public Vector3 rightBezierHandleB
		{
			[Address(RVA="0x12C14C0", Offset="0x12C14C0", VA="0x12C14C0", Slot="23")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C14D0", Offset="0x12C14D0", VA="0x12C14D0", Slot="24")]
			set
			{
			}
		}

		public Vector3 topBezierHandleA
		{
			[Address(RVA="0x12C112C", Offset="0x12C112C", VA="0x12C112C", Slot="17")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C1138", Offset="0x12C1138", VA="0x12C1138", Slot="18")]
			set
			{
			}
		}

		public Vector3 topBezierHandleB
		{
			[Address(RVA="0x12C11E0", Offset="0x12C11E0", VA="0x12C11E0", Slot="19")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12C11F0", Offset="0x12C11F0", VA="0x12C11F0", Slot="20")]
			set
			{
			}
		}

		public Transform TransformComponent
		{
			[Address(RVA="0x12C1940", Offset="0x12C1940", VA="0x12C1940")]
			get
			{
				return null;
			}
		}

		public WarpManager warpManager
		{
			[Address(RVA="0x12C1938", Offset="0x12C1938", VA="0x12C1938")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x12C31F8", Offset="0x12C31F8", VA="0x12C31F8")]
		public NativeImageWarp()
		{
		}

		[Address(RVA="0x12C312C", Offset="0x12C312C", VA="0x12C312C")]
		public void ForceUpdateGeometry()
		{
		}

		[Address(RVA="0x12C2B24", Offset="0x12C2B24", VA="0x12C2B24")]
		private void PopulateWarpManagerData()
		{
		}

		[Address(RVA="0x12C3130", Offset="0x12C3130", VA="0x12C3130", Slot="41")]
		public void ResetAll()
		{
		}

		[Address(RVA="0x12C31C4", Offset="0x12C31C4", VA="0x12C31C4", Slot="44")]
		public void ResetBezierHandlesToDefault()
		{
		}

		[Address(RVA="0x12C3194", Offset="0x12C3194", VA="0x12C3194", Slot="43")]
		public void ResetCornerOffsets()
		{
		}

		[Address(RVA="0x12C3164", Offset="0x12C3164", VA="0x12C3164", Slot="42")]
		public void ResetCropping()
		{
		}

		[Address(RVA="0x1F642BC", Offset="0x1F642BC", VA="0x1F642BC")]
		private bool SetStruct<T>(ref T currentValue, T newValue)
		where T : struct
		{
			return new bool();
		}

		[Address(RVA="0x12C2EBC", Offset="0x12C2EBC", VA="0x12C2EBC")]
		private void SetupBezierHandlesInResetPose()
		{
		}

		[Address(RVA="0x12C19D0", Offset="0x12C19D0", VA="0x12C19D0")]
		private void Update()
		{
		}

		[Address(RVA="0x12C1C50", Offset="0x12C1C50", VA="0x12C1C50", Slot="4")]
		public override void UpdateMesh(bool a_changeMesh = true)
		{
		}
	}
}