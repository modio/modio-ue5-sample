/*
 *  Copyright (C) 2024 mod.io Pty Ltd. <https://mod.io>
 *
 *  This file is part of the mod.io UE Sample Project.
 */

using UnrealBuildTool;
using System.Collections.Generic;

public class ModioUE5SampleTarget : TargetRules
{
	public ModioUE5SampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange( new string[] { "ModioUE5Sample" } );
	}
}
