using UnrealBuildTool;

public class PotionGameTarget : TargetRules
{
	public PotionGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("PotionGame");
	}
}
