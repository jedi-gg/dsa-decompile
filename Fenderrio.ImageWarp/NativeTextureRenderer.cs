using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Fenderrio.ImageWarp
{
	[Attribute(Name="ExecuteInEditMode", RVA="0x1049848", Offset="0x1049848")]
	[Attribute(Name="RequireComponent", RVA="0x1049848", Offset="0x1049848")]
	[Attribute(Name="RequireComponent", RVA="0x1049848", Offset="0x1049848")]
	public class NativeTextureRenderer : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		protected Mesh m_mesh;

		[FieldOffset(Offset="0x20")]
		private MeshFilter m_meshFilter;

		[FieldOffset(Offset="0x28")]
		private MeshRenderer m_meshRenderer;

		[FieldOffset(Offset="0x30")]
		private float m_width;

		[FieldOffset(Offset="0x34")]
		private float m_height;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		protected Texture2D m_texture;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		protected Color m_colour;

		[FieldOffset(Offset="0x50")]
		[SerializeField]
		protected bool m_flipX;

		[FieldOffset(Offset="0x51")]
		[SerializeField]
		protected bool m_flipY;

		[FieldOffset(Offset="0x58")]
		private Vector3[] m_verts;

		[FieldOffset(Offset="0x60")]
		private int[] m_indices;

		[FieldOffset(Offset="0x68")]
		private Vector2[] m_uvs;

		[FieldOffset(Offset="0x70")]
		private Color[] m_colours;

		[FieldOffset(Offset="0x78")]
		private Texture2D m_textureReference;

		public Color color
		{
			[Address(RVA="0x12C37A0", Offset="0x12C37A0", VA="0x12C37A0")]
			get
			{
				return new Color();
			}
			[Address(RVA="0x12C37AC", Offset="0x12C37AC", VA="0x12C37AC")]
			set
			{
			}
		}

		public Vector2 Dimensions
		{
			[Address(RVA="0x12C3770", Offset="0x12C3770", VA="0x12C3770")]
			get
			{
				return new Vector2();
			}
		}

		public bool flipX
		{
			[Address(RVA="0x12C37B8", Offset="0x12C37B8", VA="0x12C37B8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x12C37C0", Offset="0x12C37C0", VA="0x12C37C0")]
			set
			{
			}
		}

		public bool flipY
		{
			[Address(RVA="0x12C37CC", Offset="0x12C37CC", VA="0x12C37CC")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x12C37D4", Offset="0x12C37D4", VA="0x12C37D4")]
			set
			{
			}
		}

		public MeshFilter MeshFilterCache
		{
			[Address(RVA="0x12C3640", Offset="0x12C3640", VA="0x12C3640")]
			get
			{
				return null;
			}
		}

		public MeshRenderer MeshRendererCache
		{
			[Address(RVA="0x12C36D8", Offset="0x12C36D8", VA="0x12C36D8")]
			get
			{
				return null;
			}
		}

		public Vector3[] MeshVerts
		{
			[Address(RVA="0x12C2DF4", Offset="0x12C2DF4", VA="0x12C2DF4")]
			get
			{
				return null;
			}
		}

		public Texture2D texture
		{
			[Address(RVA="0x12C37E0", Offset="0x12C37E0", VA="0x12C37E0")]
			get
			{
				return null;
			}
			[Address(RVA="0x12C37E8", Offset="0x12C37E8", VA="0x12C37E8")]
			set
			{
			}
		}

		[Address(RVA="0x12C3204", Offset="0x12C3204", VA="0x12C3204")]
		public NativeTextureRenderer()
		{
		}

		[Address(RVA="0x12C37F0", Offset="0x12C37F0", VA="0x12C37F0")]
		private void OnEnable()
		{
		}

		[Address(RVA="0x12C2224", Offset="0x12C2224", VA="0x12C2224", Slot="4")]
		public virtual void UpdateMesh(bool a_changeMesh = true)
		{
		}
	}
}