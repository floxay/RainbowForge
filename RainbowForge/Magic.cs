﻿namespace RainbowForge
{
	public enum Magic : ulong
	{
		Unknown = 0,
		FileContainer = 0x1014FA99,
		CompiledMeshObject = 0xABEB2DFB,
		CompiledMesh = 0xFC9E1595,
		CompiledTextureMap = 0x13237FE9,
		CompiledLowResolutionTextureMap = 0xD7B5C478,
		CompiledMediumResolutionTextureMap = 0xF9C80707,
		CompiledHighResolutionTextureMap = 0x59CE4D13,
		CompiledUltraResolutionTextureMap = 0x9F492D22,
		CompiledFutureResolutionTextureMap = 0x3876CCDF,
		TextureGui1 = 0x9468B9E2,
		TextureGui2 = 0x05A61FAD,
		WemSound = 0x427411A3,
		BuildTable = 0x22ECBE63,
		EntityBuilder = 0x971A842E,
		WeaponData = 0xADBAB640,
		GameBootstrap = 0xE5A83560,
		LocalizationPackage = 0x6E3C9C6F,
		FlatArchive6 = 0xAE88DE65,
		World = 0xFBB63E47,
		LoadUnit = 0x943945C4,
		WorldMetaData = 0x3E237DA3,
		GIStream = 0xD16E3EBE,
		CompiledMeshShapeDataObject = 0x9231EE0F,
		FlatArchive12 = 0x82688E42,
		ShaderCodeModuleUserMaterial = 0x1C9A0555,
		Material = 0x85C817C3,
		TextureMapSpec = 0x989DC6B2,
		TextureMap = 0xA2B7E917,
		Mesh = 0x415D9568,
		Skeleton = 0x24AECB7C,
		CollisionMaterial = 0x74F7311D,
		Entity = 0x0984415E,
		SpotLight = 0x80320FB8,
		FacialPoseGroup = 0xE640B4DA,
		FX = 0x824A23BA,
		SplashFX = 0x755ACE14,
		BallJointCommonData = 0x460DD209,
		LiteRagdoll = 0x891043D5,
		BoxShape = 0x4EC68E98,
		BuildRow = 0x348B28D6
	}

	public enum ContainerMagic : uint
	{
		Descriptor = 1,
		Hash = 6,
		File = 0x57FBAA34
	}

	public enum AssetType
	{
		Unknown,
		Mesh,
		Texture,
		Sound,
		FlatArchive
	}
}