using MelonLoader;
using FF;
using UnityEngine;
using UnityEngine.InputSystem;

#pragma warning disable CS0618 // Type or member is obsolete
[assembly: MelonInfo(typeof(Mod), "Flyout Fixes", "0.0.1", "MeowserLJC", "https://github.com/MeowserLJC/Flyout-Fixes")]
[assembly: MelonGame("Stonext Games", "Flyout")]
[assembly: MelonColor(ConsoleColor.Yellow)]
[assembly: MelonAuthorColor(ConsoleColor.Cyan)]
[assembly: MelonPlatformDomain(MelonPlatformDomainAttribute.CompatibleDomains.IL2CPP)]
[assembly: MelonPlatform(MelonPlatformAttribute.CompatiblePlatforms.WINDOWS_X64)]
[assembly: VerifyLoaderVersion(0, 6, 0, true)]
#pragma warning restore CS0618 // Type or member is obsolete

namespace FF
{
    public class Mod : MelonMod
    {
        private MelonPreferences_Category ff_settings;

        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Flyout Fixes Initialized.");
            ff_settings = MelonPreferences.CreateCategory("ff_settings");
        }
    }
}
