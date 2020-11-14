// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Desert_storm : ModuleRules
{
	public Desert_storm(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
