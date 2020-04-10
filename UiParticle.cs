using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Attribute(Name="ExecuteAlways", RVA="0x1048EE8", Offset="0x1048EE8")]
public class UiParticle : MaskableGraphic
{
	[FieldOffset(Offset="0x0")]
	public readonly static int s_idMainTex;

	[FieldOffset(Offset="0x8")]
	private readonly static List<Vector3> s_vertices;

	[FieldOffset(Offset="0x10")]
	private readonly static List<UiParticle> s_tempRelatables;

	[FieldOffset(Offset="0x18")]
	private readonly static List<UiParticle> s_activeParticles;

	[FieldOffset(Offset="0xB0")]
	private Mesh _mesh;

	[FieldOffset(Offset="0xB8")]
	private ParticleSystemRenderer _renderer;

	[FieldOffset(Offset="0xC0")]
	private UiParticle _parent;

	[FieldOffset(Offset="0xC8")]
	private List<UiParticle> _children;

	[FieldOffset(Offset="0xD0")]
	private Matrix4x4 _scaleMatrix;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	private ParticleSystem _particleSystem;

	[FieldOffset(Offset="0x118")]
	[SerializeField]
	private UiParticle _trailParticle;

	[Attribute(Name="HideInInspector", RVA="0x105E410", Offset="0x105E410")]
	[FieldOffset(Offset="0x120")]
	[SerializeField]
	private bool _isTrail;

	[FieldOffset(Offset="0x124")]
	[SerializeField]
	private float _scale;

	[FieldOffset(Offset="0x128")]
	[SerializeField]
	private bool _ignoreParent;

	public bool IgnoreParent
	{
		[Address(RVA="0x158793C", Offset="0x158793C", VA="0x158793C")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x1587944", Offset="0x1587944", VA="0x1587944")]
		set
		{
		}
	}

	public bool IsRoot
	{
		[Address(RVA="0x1587970", Offset="0x1587970", VA="0x1587970")]
		get
		{
			return new bool();
		}
	}

	public override Texture mainTexture
	{
		[Address(RVA="0x1587450", Offset="0x1587450", VA="0x1587450", Slot="35")]
		get
		{
			return null;
		}
	}

	public override bool raycastTarget
	{
		[Address(RVA="0x1587444", Offset="0x1587444", VA="0x1587444", Slot="24")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x158744C", Offset="0x158744C", VA="0x158744C", Slot="25")]
		set
		{
		}
	}

	public float Scale
	{
		[Address(RVA="0x1587890", Offset="0x1587890", VA="0x1587890")]
		get
		{
			return new float();
		}
		[Address(RVA="0x1587934", Offset="0x1587934", VA="0x1587934")]
		set
		{
		}
	}

	[Address(RVA="0x1589298", Offset="0x1589298", VA="0x1589298")]
	static UiParticle()
	{
	}

	[Address(RVA="0x1589220", Offset="0x1589220", VA="0x1589220")]
	public UiParticle()
	{
	}

	[Address(RVA="0x15879E8", Offset="0x15879E8", VA="0x15879E8", Slot="4")]
	protected override void Awake()
	{
	}

	[Address(RVA="0x1587EC8", Offset="0x1587EC8", VA="0x1587EC8")]
	private void CheckTrail()
	{
	}

	[Address(RVA="0x15877B0", Offset="0x15877B0", VA="0x15877B0", Slot="57")]
	public override Material GetModifiedMaterial(Material baseMaterial)
	{
		return null;
	}

	[Address(RVA="0x1587718", Offset="0x1587718", VA="0x1587718")]
	public ParticleSystem GetParticleSystem()
	{
		return null;
	}

	[Address(RVA="0x158888C", Offset="0x158888C", VA="0x158888C", Slot="13")]
	protected override void OnDidApplyAnimationProperties()
	{
	}

	[Address(RVA="0x158823C", Offset="0x158823C", VA="0x158823C", Slot="7")]
	protected override void OnDisable()
	{
	}

	[Address(RVA="0x1587B80", Offset="0x1587B80", VA="0x1587B80", Slot="5")]
	protected override void OnEnable()
	{
	}

	[Address(RVA="0x1588714", Offset="0x1588714", VA="0x1588714", Slot="12")]
	protected override void OnTransformParentChanged()
	{
	}

	[Address(RVA="0x1588418", Offset="0x1588418", VA="0x1588418")]
	private void SetParent(UiParticle newParent)
	{
	}

	[Address(RVA="0x1588890", Offset="0x1588890", VA="0x1588890", Slot="41")]
	protected override void UpdateGeometry()
	{
	}

	[Address(RVA="0x1588A14", Offset="0x1588A14", VA="0x1588A14")]
	private void UpdateMesh()
	{
	}

	[Address(RVA="0x1588894", Offset="0x1588894", VA="0x1588894")]
	private static void UpdateMeshes()
	{
	}
}