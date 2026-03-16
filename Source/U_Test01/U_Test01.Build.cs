// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class U_Test01 : ModuleRules
{
	public U_Test01(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"U_Test01",
			"U_Test01/Variant_Platforming",
			"U_Test01/Variant_Platforming/Animation",
			"U_Test01/Variant_Combat",
			"U_Test01/Variant_Combat/AI",
			"U_Test01/Variant_Combat/Animation",
			"U_Test01/Variant_Combat/Gameplay",
			"U_Test01/Variant_Combat/Interfaces",
			"U_Test01/Variant_Combat/UI",
			"U_Test01/Variant_SideScrolling",
			"U_Test01/Variant_SideScrolling/AI",
			"U_Test01/Variant_SideScrolling/Gameplay",
			"U_Test01/Variant_SideScrolling/Interfaces",
			"U_Test01/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
