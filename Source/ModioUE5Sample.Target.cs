// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ModioUE5SampleTarget : TargetRules
{
	public ModioUE5SampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

#if UE_5_3_OR_LATER
		DefaultBuildSettings = BuildSettingsVersion.V4;
#else
		DefaultBuildSettings = BuildSettingsVersion.V2;
#endif

		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

        ExtraModuleNames.AddRange( new string[] { "ModioUE5Sample" } );
	}
}
