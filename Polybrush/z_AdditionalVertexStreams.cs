using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Polybrush
{
	[Attribute(Name="ExecuteInEditMode", RVA="0x1049770", Offset="0x1049770")]
	public class z_AdditionalVertexStreams : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		public Mesh m_AdditionalVertexStreamMesh;

		[FieldOffset(Offset="0x20")]
		private MeshRenderer _meshRenderer;

		private MeshRenderer meshRenderer
		{
			[Address(RVA="0x1345850", Offset="0x1345850", VA="0x1345850")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1345944", Offset="0x1345944", VA="0x1345944")]
		public z_AdditionalVertexStreams()
		{
		}

		[Address(RVA="0x1345908", Offset="0x1345908", VA="0x1345908")]
		public void SetAdditionalVertexStreamsMesh(Mesh mesh)
		{
		}

		[Address(RVA="0x1345900", Offset="0x1345900", VA="0x1345900")]
		private void Start()
		{
		}
	}
}