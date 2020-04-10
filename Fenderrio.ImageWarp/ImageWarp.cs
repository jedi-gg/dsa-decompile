using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Fenderrio.ImageWarp
{
	[Attribute(Name="AddComponentMenu", RVA="0x10497D8", Offset="0x10497D8")]
	public class ImageWarp : Image, IWarp
	{
		[FieldOffset(Offset="0xE0")]
		[SerializeField]
		private Vector3 m_cornerOffsetTL;

		[FieldOffset(Offset="0xEC")]
		[SerializeField]
		private Vector3 m_cornerOffsetTR;

		[FieldOffset(Offset="0xF8")]
		[SerializeField]
		private Vector3 m_cornerOffsetBR;

		[FieldOffset(Offset="0x104")]
		[SerializeField]
		private Vector3 m_cornerOffsetBL;

		[FieldOffset(Offset="0x110")]
		[SerializeField]
		private int m_numSubdivisions;

		[FieldOffset(Offset="0x114")]
		[SerializeField]
		private bool m_bezierEdges;

		[FieldOffset(Offset="0x118")]
		[SerializeField]
		private Vector3 m_topBezierHandleA;

		[FieldOffset(Offset="0x124")]
		[SerializeField]
		private Vector3 m_topBezierHandleB;

		[FieldOffset(Offset="0x130")]
		[SerializeField]
		private Vector3 m_leftBezierHandleA;

		[FieldOffset(Offset="0x13C")]
		[SerializeField]
		private Vector3 m_leftBezierHandleB;

		[FieldOffset(Offset="0x148")]
		[SerializeField]
		private Vector3 m_rightBezierHandleA;

		[FieldOffset(Offset="0x154")]
		[SerializeField]
		private Vector3 m_rightBezierHandleB;

		[FieldOffset(Offset="0x160")]
		[SerializeField]
		private Vector3 m_bottomBezierHandleA;

		[FieldOffset(Offset="0x16C")]
		[SerializeField]
		private Vector3 m_bottomBezierHandleB;

		[FieldOffset(Offset="0x178")]
		[SerializeField]
		private float m_cropLeft;

		[FieldOffset(Offset="0x17C")]
		[SerializeField]
		private float m_cropRight;

		[FieldOffset(Offset="0x180")]
		[SerializeField]
		private float m_cropTop;

		[FieldOffset(Offset="0x184")]
		[SerializeField]
		private float m_cropBottom;

		[FieldOffset(Offset="0x188")]
		[SerializeField]
		private WarpManager m_warpManager;

		[FieldOffset(Offset="0x190")]
		private List<UIVertex> m_meshVerts;

		[FieldOffset(Offset="0x198")]
		private Vector3[] m_meshVertsVec3;

		[FieldOffset(Offset="0x1A0")]
		private Vector2[] m_meshUvsVec2;

		[FieldOffset(Offset="0x1A8")]
		private WarpManager.WarpManagerInstanceData m_warpManagerData;

		[FieldOffset(Offset="0x1B0")]
		private WarpManager.WarpManagerMeshData m_warpedMeshData;

		[FieldOffset(Offset="0x1B8")]
		private RectTransform m_rectTransform;

		[FieldOffset(Offset="0x1C0")]
		private Transform m_transform;

		[Attribute(Name="HideInInspector", RVA="0x1060EE4", Offset="0x1060EE4")]
		[FieldOffset(Offset="0x1C8")]
		[SerializeField]
		private bool m_initialised;

		public bool bezierEdges
		{
			[Address(RVA="0x12BC604", Offset="0x12BC604", VA="0x12BC604", Slot="97")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x12BC60C", Offset="0x12BC60C", VA="0x12BC60C", Slot="98")]
			set
			{
			}
		}

		public Vector3 bottomBezierHandleA
		{
			[Address(RVA="0x12BCAE8", Offset="0x12BCAE8", VA="0x12BCAE8", Slot="107")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12BCAF8", Offset="0x12BCAF8", VA="0x12BCAF8", Slot="108")]
			set
			{
			}
		}

		public Vector3 bottomBezierHandleB
		{
			[Address(RVA="0x12BCBA0", Offset="0x12BCBA0", VA="0x12BCBA0", Slot="109")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12BCBB0", Offset="0x12BCBB0", VA="0x12BCBB0", Slot="110")]
			set
			{
			}
		}

		public Vector3 cornerOffsetBL
		{
			[Address(RVA="0x12BC4B8", Offset="0x12BC4B8", VA="0x12BC4B8", Slot="91")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12BC4C8", Offset="0x12BC4C8", VA="0x12BC4C8", Slot="92")]
			set
			{
			}
		}

		public Vector3 cornerOffsetBR
		{
			[Address(RVA="0x12BC404", Offset="0x12BC404", VA="0x12BC404", Slot="93")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12BC410", Offset="0x12BC410", VA="0x12BC410", Slot="94")]
			set
			{
			}
		}

		public Vector3 cornerOffsetTL
		{
			[Address(RVA="0x12BC29C", Offset="0x12BC29C", VA="0x12BC29C", Slot="87")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12BC2A8", Offset="0x12BC2A8", VA="0x12BC2A8", Slot="88")]
			set
			{
			}
		}

		public Vector3 cornerOffsetTR
		{
			[Address(RVA="0x12BC350", Offset="0x12BC350", VA="0x12BC350", Slot="89")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12BC35C", Offset="0x12BC35C", VA="0x12BC35C", Slot="90")]
			set
			{
			}
		}

		public float cropBottom
		{
			[Address(RVA="0x12BCE14", Offset="0x12BCE14", VA="0x12BCE14", Slot="121")]
			get
			{
				return new float();
			}
			[Address(RVA="0x12BCE1C", Offset="0x12BCE1C", VA="0x12BCE1C", Slot="122")]
			set
			{
			}
		}

		public float cropLeft
		{
			[Address(RVA="0x12BCC58", Offset="0x12BCC58", VA="0x12BCC58", Slot="115")]
			get
			{
				return new float();
			}
			[Address(RVA="0x12BCC60", Offset="0x12BCC60", VA="0x12BCC60", Slot="116")]
			set
			{
			}
		}

		public float cropRight
		{
			[Address(RVA="0x12BCCEC", Offset="0x12BCCEC", VA="0x12BCCEC", Slot="119")]
			get
			{
				return new float();
			}
			[Address(RVA="0x12BCCF4", Offset="0x12BCCF4", VA="0x12BCCF4", Slot="120")]
			set
			{
			}
		}

		public float cropTop
		{
			[Address(RVA="0x12BCD80", Offset="0x12BCD80", VA="0x12BCD80", Slot="117")]
			get
			{
				return new float();
			}
			[Address(RVA="0x12BCD88", Offset="0x12BCD88", VA="0x12BCD88", Slot="118")]
			set
			{
			}
		}

		public Vector3 leftBezierHandleA
		{
			[Address(RVA="0x12BC808", Offset="0x12BC808", VA="0x12BC808", Slot="111")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12BC818", Offset="0x12BC818", VA="0x12BC818", Slot="112")]
			set
			{
			}
		}

		public Vector3 leftBezierHandleB
		{
			[Address(RVA="0x12BC8C0", Offset="0x12BC8C0", VA="0x12BC8C0", Slot="113")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12BC8D0", Offset="0x12BC8D0", VA="0x12BC8D0", Slot="114")]
			set
			{
			}
		}

		public int numSubdivisions
		{
			[Address(RVA="0x12BC570", Offset="0x12BC570", VA="0x12BC570", Slot="95")]
			get
			{
				return new int();
			}
			[Address(RVA="0x12BC578", Offset="0x12BC578", VA="0x12BC578", Slot="96")]
			set
			{
			}
		}

		public RectTransform RectTransformComponent
		{
			[Address(RVA="0x12BCEB0", Offset="0x12BCEB0", VA="0x12BCEB0")]
			get
			{
				return null;
			}
		}

		public Vector3 rightBezierHandleA
		{
			[Address(RVA="0x12BC978", Offset="0x12BC978", VA="0x12BC978", Slot="103")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12BC988", Offset="0x12BC988", VA="0x12BC988", Slot="104")]
			set
			{
			}
		}

		public Vector3 rightBezierHandleB
		{
			[Address(RVA="0x12BCA30", Offset="0x12BCA30", VA="0x12BCA30", Slot="105")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12BCA40", Offset="0x12BCA40", VA="0x12BCA40", Slot="106")]
			set
			{
			}
		}

		public Vector3 topBezierHandleA
		{
			[Address(RVA="0x12BC698", Offset="0x12BC698", VA="0x12BC698", Slot="99")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12BC6A8", Offset="0x12BC6A8", VA="0x12BC6A8", Slot="100")]
			set
			{
			}
		}

		public Vector3 topBezierHandleB
		{
			[Address(RVA="0x12BC750", Offset="0x12BC750", VA="0x12BC750", Slot="101")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x12BC760", Offset="0x12BC760", VA="0x12BC760", Slot="102")]
			set
			{
			}
		}

		public Transform TransformComponent
		{
			[Address(RVA="0x12BCF40", Offset="0x12BCF40", VA="0x12BCF40")]
			get
			{
				return null;
			}
		}

		public WarpManager warpManager
		{
			[Address(RVA="0x12BCEA8", Offset="0x12BCEA8", VA="0x12BCEA8")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x12C0CC4", Offset="0x12C0CC4", VA="0x12C0CC4")]
		public ImageWarp()
		{
		}

		[Address(RVA="0x12BFEEC", Offset="0x12BFEEC", VA="0x12BFEEC")]
		public void ForceUpdateGeometry()
		{
		}

		[Address(RVA="0x12BCFD0", Offset="0x12BCFD0", VA="0x12BCFD0", Slot="44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Address(RVA="0x12BDACC", Offset="0x12BDACC", VA="0x12BDACC")]
		private void PopulateWarpManagerData()
		{
		}

		[Address(RVA="0x12BFEFC", Offset="0x12BFEFC", VA="0x12BFEFC", Slot="123")]
		public void ResetAll()
		{
		}

		[Address(RVA="0x12C04C8", Offset="0x12C04C8", VA="0x12C04C8", Slot="126")]
		public void ResetBezierHandlesToDefault()
		{
		}

		[Address(RVA="0x12C01D0", Offset="0x12C01D0", VA="0x12C01D0", Slot="125")]
		public void ResetCornerOffsets()
		{
		}

		[Address(RVA="0x12BFF78", Offset="0x12BFF78", VA="0x12BFF78", Slot="124")]
		public void ResetCropping()
		{
		}

		[Address(RVA="0x1F640CC", Offset="0x1F640CC", VA="0x1F640CC")]
		private bool SetStruct<T>(ref T currentValue, T newValue)
		where T : struct
		{
			return new bool();
		}
	}
}