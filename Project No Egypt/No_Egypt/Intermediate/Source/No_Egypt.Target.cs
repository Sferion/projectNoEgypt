using UnrealBuildTool;

public class No_EgyptTarget : TargetRules
{
	public No_EgyptTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("No_Egypt");
	}
}
