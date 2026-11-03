// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GAM415_Project : ModuleRules
{
	public GAM415_Project(ReadOnlyTargetRules Target) : base(Target)
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
			"GAM415_Project",
			"GAM415_Project/Variant_Horror",
			"GAM415_Project/Variant_Horror/UI",
			"GAM415_Project/Variant_Shooter",
			"GAM415_Project/Variant_Shooter/AI",
			"GAM415_Project/Variant_Shooter/UI",
			"GAM415_Project/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
