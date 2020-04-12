using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using ExileCore.Shared.Attributes;

using System.Windows.Forms;

namespace CoPilot
{
    public class CoPilotSettings : ISettings
    {
        [Menu("Debug Mode", 2, 1)]
        public ToggleNode debugMode { get; set; }


        #region Auto Quit
        [Menu("Enable", 1001, 1000)]
        public ToggleNode autoQuitEnabled { get; set; }

        [Menu("Hotkey:", 1002, 1000)]
        public HotkeyNode forcedAutoQuit { get; set; }
        [Menu("%Life Quit", 1003, 1000)]
        public RangeNode<float> hpPctQuit { get; set; }

        [Menu("%ES Quit", 1004, 1000)]
        public RangeNode<float> esPctQuit { get; set; }
        #endregion

        #region Phaserun
        [Menu("Enable", 4, 3)]
        public ToggleNode phaserunEnabled { get; set; }

        [Menu("Cooldown", 6, 3)]
        public RangeNode<int> phaserunDelay { get; set; }
        #endregion

        #region Molten Shell
        [Menu("Enable", 11, 10)]
        public ToggleNode moltenShellEnabled { get; set; }

        [Menu("Cooldown", 13, 10)]
        public RangeNode<int> moltenShellDelay { get; set; }

        [Menu("Trigger Range", 14, 10)]
        public RangeNode<int> moltenShellRange { get; set; }
        #endregion

        #region War Cry
        [Menu("Enable", 21, 20)]
        public ToggleNode enduringCryEnabled { get; set; }

        [Menu("Cooldown", 22, 20)]
        public RangeNode<int> warCryDelay { get; set; }

        [Menu("Trigger Range", 24, 20)]
        public RangeNode<int> enduringCryRange { get; set; }

        [Menu("Enable", 26, 25)]
        public ToggleNode rallyingCryEnabled { get; set; }

        [Menu("Trigger Range", 28, 25)]
        public RangeNode<int> rallyingCryRange { get; set; }

        [Menu("Keep Rage")]
        public ToggleNode warCryKeepRage { get; set; }
        #endregion

        #region Divine Ire / Blade Flurry / Scourge Arrow
        [Menu("Enable", 31, 30)]
        public ToggleNode divineIreEnabled { get; set; }

        [Menu("Stacks", 34, 30)]
        public RangeNode<int> divineIreStacks { get; set; }
        [Menu("Wait for Infused Channelling Support", 35, 30)]
        public ToggleNode divineIreWaitForInfused { get; set; }
        #endregion

        #region Delve Flare
        [Menu("Enable", 41, 40)]
        public ToggleNode delveFlareEnabled { get; set; }

        [Menu("Key:", 42, 40)]
        public HotkeyNode delveFlareKey { get; set; }

        [Menu("Delve Debuff Stacks", 43, 40)]
        public RangeNode<int> delveFlareDebuffStacks { get; set; }

        [Menu("min. Hp%", 44, 40)]
        public RangeNode<float> delveFlareHpBelow { get; set; }

        [Menu("min. Es%", 45, 40)]
        public RangeNode<float> delveFlareEsBelow { get; set; }
        #endregion

        #region Vortex
        [Menu("Enable", 51, 50)]
        public ToggleNode vortexEnabled { get; set; }

        [Menu("Cooldown", 52, 50)]
        public RangeNode<int> vortexDelay { get; set; }

        [Menu("Trigger Range", 54, 50)]
        public RangeNode<int> vortexRange { get; set; }
        #endregion

        #region BloodRage
        [Menu("Enable", 61, 60)]
        public ToggleNode bloodRageEnabled { get; set; }

        [Menu("Cooldown", 62, 60)]
        public RangeNode<int> bloodRageDelay { get; set; }

        [Menu("Trigger Range", 64, 60)]
        public RangeNode<int> bloodRageRange { get; set; }
        #endregion

        #region Offerings
        [Menu("Enable", 71, 70)]
        public ToggleNode offeringsEnabled { get; set; }
        #endregion

        #region Doedre Effigy
        [Menu("Enable", 81, 80)]
        public ToggleNode doedreEffigyEnabled { get; set; }

        [Menu("Cooldown", 84, 80)]
        public RangeNode<int> doedreEffigyDelay { get; set; }
        #endregion

        #region Flask
        [Menu("Enable Slot 4", 91, 90)]
        public ToggleNode useSpeed4 { get; set; }
        [Menu("Enable Slot 5", 92, 90)]
        public ToggleNode useSpeed5 { get; set; }
        [Menu("Use when Moving", 93, 90)]
        public ToggleNode useSpeedMoving { get; set; }
        [Menu("Use when Attacking", 94, 90)]
        public ToggleNode useSpeedAttack { get; set; }

        #endregion

        #region Mines
        [Menu("Enable", 101, 100)]
        public ToggleNode minesEnabled { get; set; }
        [Menu("Cooldown", 102, 100)]
        public RangeNode<int> minesDelay { get; set; }
        [Menu("min. Mines", 103, 100)]
        public RangeNode<int> minesMin { get; set; }
        [Menu("Detonate Range", 103, 100)]
        public RangeNode<int> minesDetonateRange { get; set; }


        #endregion

        #region AutoAttack Cyclone / Nova etc.
        [Menu("Enable", 111, 110)]
        public ToggleNode autoAttackEnabled { get; set; }

        [Menu("Dont use on Left Mouse Pressed", 112, 110)]
        public ToggleNode autoAttackLeftMouseCheck { get; set; }

        [Menu("PickIt Key:", 114, 110)]
        public HotkeyNode autoAttackPickItKey { get; set; }

        [Menu("Trigger Range", 115, 110)]
        public RangeNode<int> autoAttackRange { get; set; }


        #endregion

        #region Auto Golem
        [Menu("Enable", 121, 120)]
        public ToggleNode autoGolemEnabled { get; set; }

        [Menu("Max. Golems", 123, 120)]
        public RangeNode<int> autoGolemMax { get; set; }

        #endregion

        #region Any Vaal Skill
        [Menu("Enable")]
        public ToggleNode anyVaalEnabled { get; set; }

        [Menu("Range")]
        public RangeNode<int> anyVaalTriggerRange { get; set; }

        [Menu("Enemys")]
        public RangeNode<int> anyVaalMinEnemys { get; set; }

        [Menu("%Life Quit")]
        public RangeNode<float> anyVaalHpPct { get; set; }

        [Menu("%ES Quit")]
        public RangeNode<float> anyVaalEsPct { get; set; }
        #endregion

        #region Custom Skill
        public ToggleNode customEnabled { get; set; }
        public RangeNode<int> customTriggerRange { get; set; }
        public RangeNode<int> customMinEnemys { get; set; }
        public RangeNode<float> customHpPct { get; set; }
        public RangeNode<float> customEsPct { get; set; }
        public RangeNode<int> customCooldown { get; set; }
        public HotkeyNode customKey { get; set; }
        #endregion

        #region Storm Brand
        [Menu("Enable", 131, 130)]
        public ToggleNode stormBrandEnabled { get; set; }
        [Menu("Max. Brands", 132, 130)]
        public RangeNode<int> brandStacks { get; set; }
        #endregion

        #region Input Keys
        [Menu("boundSkill2:")]
        public HotkeyNode InputKey1 { get; set; }

        [Menu("boundSkill4:")]
        public HotkeyNode InputKey3 { get; set; }

        [Menu("boundSkill5:")]
        public HotkeyNode InputKey4 { get; set; }

        [Menu("boundSkill6:")]
        public HotkeyNode InputKey5 { get; set; }

        [Menu("boundSkill7:")]
        public HotkeyNode InputKey6 { get; set; }

        [Menu("boundSkill8:")]
        public HotkeyNode InputKey7 { get; set; }

        [Menu("boundSkill9:")]
        public HotkeyNode InputKey8 { get; set; }

        [Menu("boundSkill10:")]
        public HotkeyNode InputKey9 { get; set; }

        [Menu("boundSkill11:")]
        public HotkeyNode InputKey10 { get; set; }

        [Menu("boundSkill12:")]
        public HotkeyNode InputKey11 { get; set; }

        [Menu("boundSkill13:")]
        public HotkeyNode InputKey12 { get; set; }
        #endregion

        #region Confirm
        [Menu("Confirm")]
        public ToggleNode confirm1 { get; set; }
        [Menu("Confirm")]
        public ToggleNode confirm2 { get; set; }
        [Menu("Confirm")]
        public ToggleNode confirm3 { get; set; }
        [Menu("Confirm")]
        public ToggleNode confirm4 { get; set; }
        [Menu("Confirm")]
        public ToggleNode confirm5 { get; set; }
        #endregion

        public ToggleNode Enable { get; set; }
        public CoPilotSettings()
        {
            Enable = new ToggleNode(false);
            debugMode = new ToggleNode(false);

            autoQuitEnabled = new ToggleNode(false);
            hpPctQuit = new RangeNode<float>(35f, 0f, 100f);
            esPctQuit = new RangeNode<float>(0f, 0f, 100f);
            forcedAutoQuit = Keys.F4;

            phaserunEnabled = new ToggleNode(false);
            phaserunDelay = new RangeNode<int>(4000, 100, 4100);

            moltenShellEnabled = new ToggleNode(false);
            moltenShellDelay = new RangeNode<int>(4000, 100, 4100);           
            moltenShellRange = new RangeNode<int>(550, 100, 1000);

            enduringCryEnabled = new ToggleNode(false);
            enduringCryRange = new RangeNode<int>(550, 100, 1000);
            warCryDelay = new RangeNode<int>(4000, 3330, 4100);
            warCryKeepRage = new ToggleNode(false);

            rallyingCryEnabled = new ToggleNode(false);
            rallyingCryRange = new RangeNode<int>(300, 100, 1000);

            divineIreEnabled = new ToggleNode(false);
            divineIreStacks = new RangeNode<int>(20, 1, 20);
            divineIreWaitForInfused = new ToggleNode(false);

            delveFlareEnabled = new ToggleNode(false);
            delveFlareKey = Keys.D6;
            delveFlareDebuffStacks = new RangeNode<int>(12, 1, 1000);
            delveFlareHpBelow = new RangeNode<float>(75, 0, 100);
            delveFlareEsBelow = new RangeNode<float>(0, 0, 100);

            vortexEnabled = new ToggleNode(false);
            vortexDelay = new RangeNode<int>(1800, 500, 1900);
            vortexRange = new RangeNode<int>(300, 100, 1000);

            bloodRageEnabled = new ToggleNode(false);
            bloodRageDelay = new RangeNode<int>(1000, 1000, 10100);
            bloodRageRange = new RangeNode<int>(300, 800, 3000);

            offeringsEnabled = new ToggleNode(false);

            doedreEffigyEnabled = new ToggleNode(false);
            doedreEffigyDelay = new RangeNode<int>(600, 500, 2000);

            
            useSpeed4 = new ToggleNode(false);
            useSpeed5 = new ToggleNode(false);
            useSpeedAttack = new ToggleNode(false);
            useSpeedMoving = new ToggleNode(false);

            minesEnabled = new ToggleNode(false);
            minesDelay = new RangeNode<int>(1000, 250, 3000);
            minesMin = new RangeNode<int>(1, 1, 20);
            minesDetonateRange = new RangeNode<int>(50, 10, 200);

            autoAttackEnabled = new ToggleNode(false);
            autoAttackLeftMouseCheck = new ToggleNode(true);
            autoAttackPickItKey = new HotkeyNode(Keys.Space);
            autoAttackRange = new RangeNode<int>(500, 100, 2000);

            autoGolemEnabled = new ToggleNode(false);
            autoGolemMax = new RangeNode<int>(1, 1, 15);

            anyVaalEnabled = new ToggleNode(false);
            anyVaalTriggerRange = new RangeNode<int>(500, 100, 2000);
            anyVaalMinEnemys = new RangeNode<int>(0, 0, 50);
            anyVaalHpPct = new RangeNode<float>(35f, 0f, 100f);
            anyVaalEsPct = new RangeNode<float>(0f, 0f, 100f);

            customEnabled = new ToggleNode(false);
            customTriggerRange = new RangeNode<int>(500, 100, 2000);
            customMinEnemys = new RangeNode<int>(1, 0, 50);
            customHpPct = new RangeNode<float>(100, 0f, 100f);
            customEsPct = new RangeNode<float>(0f, 0f, 100f);
            customCooldown = new RangeNode<int>(4000, 1000, 10000);
            customKey = new HotkeyNode(Keys.T);

            stormBrandEnabled = new ToggleNode(false);
            brandStacks = new RangeNode<int>(5, 0, 10);

            InputKey1 = new HotkeyNode(Keys.Z);
            InputKey3 = new HotkeyNode(Keys.Q);
            InputKey4 = new HotkeyNode(Keys.W);
            InputKey5 = new HotkeyNode(Keys.E);
            InputKey6 = new HotkeyNode(Keys.R);
            InputKey7 = new HotkeyNode(Keys.T);
            InputKey8 = new HotkeyNode(Keys.NumPad1);
            InputKey9 = new HotkeyNode(Keys.NumPad2);
            InputKey10 = new HotkeyNode(Keys.NumPad3);
            InputKey11 = new HotkeyNode(Keys.NumPad4);
            InputKey12= new HotkeyNode(Keys.NumPad5);

            confirm1 = new ToggleNode(false);
            confirm2 = new ToggleNode(false);
            confirm3 = new ToggleNode(false);
            confirm4 = new ToggleNode(false);
            confirm5 = new ToggleNode(false);


        }
    }
}
