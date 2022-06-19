using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.FormKeys.SkyrimSE;

namespace GDOPatcher
{
    public class Program
    {
        private static readonly ModKey KeyGDO = ModKey.FromNameAndExtension("Guard Dialogue Overhaul.esp");
        private static readonly ModKey KeyUpdate = ModKey.FromNameAndExtension("Update.esm");


        public static readonly FormLink<IKeywordGetter> SPIKEArmorAssassin = new(KeyUpdate.MakeFormKey(0xDA0101));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorBrigand = new(KeyUpdate.MakeFormKey(0xDA0103));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorDragonBone = new(KeyUpdate.MakeFormKey(0xDA0105));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorDragonScale = new(KeyUpdate.MakeFormKey(0xDA0107));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorDwarven = new(KeyUpdate.MakeFormKey(0xDA0109));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorEbony = new(KeyUpdate.MakeFormKey(0xDA010B));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorFancyBlack = new(KeyUpdate.MakeFormKey(0xDA010D));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorImperial = new(KeyUpdate.MakeFormKey(0xDA010F));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorImperialScout = new(KeyUpdate.MakeFormKey(0xDA0111));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorImperialSecurity = new(KeyUpdate.MakeFormKey(0xDA0113));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorIron = new(KeyUpdate.MakeFormKey(0xDA0115));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorLeather = new(KeyUpdate.MakeFormKey(0xDA0117));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorMerc = new(KeyUpdate.MakeFormKey(0xDA0119));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorOrcish = new(KeyUpdate.MakeFormKey(0xDA011B)); 
        public static readonly FormLink<IKeywordGetter> SPIKEArmorScaleShiny = new(KeyUpdate.MakeFormKey(0xDA011D));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorSons = new(KeyUpdate.MakeFormKey(0xDA011F));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorSonsBear = new(KeyUpdate.MakeFormKey(0xDA0121));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorSteel = new(KeyUpdate.MakeFormKey(0xDA0123));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorSteelPlate = new(KeyUpdate.MakeFormKey(0xDA0125));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorStinksDeath = new(KeyUpdate.MakeFormKey(0xDA0127));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorThievesGuild = new(KeyUpdate.MakeFormKey(0xDA0129));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorTrueNord = new(KeyUpdate.MakeFormKey(0xDA012B));
        public static readonly FormLink<IKeywordGetter> SPIKEArmorWeak = new(KeyUpdate.MakeFormKey(0xDA012D));
        public static readonly FormLink<IKeywordGetter> SPIKEGodsBlessings = new(KeyUpdate.MakeFormKey(0xDA012F));
        public static readonly FormLink<IKeywordGetter> SPIKEGodsPraised = new(KeyUpdate.MakeFormKey(0xDA0131));
        public static readonly FormLink<IKeywordGetter> SPIKEImperialAuxiliary = new(KeyUpdate.MakeFormKey(0xDA0133));
        public static readonly FormLink<IKeywordGetter> SPIKEImperialLegate = new(KeyUpdate.MakeFormKey(0xDA0135));
        public static readonly FormLink<IKeywordGetter> SPIKEImperialPraefect = new(KeyUpdate.MakeFormKey(0xDA0137));
        public static readonly FormLink<IKeywordGetter> SPIKEImperialQuaestor = new(KeyUpdate.MakeFormKey(0xDA0139));
        public static readonly FormLink<IKeywordGetter> SPIKEImperialTribune = new(KeyUpdate.MakeFormKey(0xDA013B));
        public static readonly FormLink<IKeywordGetter> SPIKERedguardMerc = new(KeyUpdate.MakeFormKey(0xDA013D));
        public static readonly FormLink<IKeywordGetter> SPIKEShieldFancyDwarven = new(KeyUpdate.MakeFormKey(0xDA013F));
        public static readonly FormLink<IKeywordGetter> SPIKESonsBoneBreaker = new(KeyUpdate.MakeFormKey(0xDA0141));
        public static readonly FormLink<IKeywordGetter> SPIKESonsIceVeins = new(KeyUpdate.MakeFormKey(0xDA0143));
        public static readonly FormLink<IKeywordGetter> SPIKESonsSnowHammer = new(KeyUpdate.MakeFormKey(0xDA0145));
        public static readonly FormLink<IKeywordGetter> SPIKESonsStormblade = new(KeyUpdate.MakeFormKey(0xDA0147));
        public static readonly FormLink<IKeywordGetter> SPIKESonsUnblooded = new(KeyUpdate.MakeFormKey(0xDA0149));
        public static readonly FormLink<IKeywordGetter> SPIKEStaffHorror = new(KeyUpdate.MakeFormKey(0xDA014B));
        public static readonly FormLink<IKeywordGetter> SPIKEWeapBigHammer = new(KeyUpdate.MakeFormKey(0xDA014D));
        public static readonly FormLink<IKeywordGetter> SPIKEWeapElvenBlade = new(KeyUpdate.MakeFormKey(0xDA014F));
        public static readonly FormLink<IKeywordGetter> SPIKEWeapFancySwordBlack = new(KeyUpdate.MakeFormKey(0xDA0151));
        public static readonly FormLink<IKeywordGetter> SPIKEWeapFoul = new(KeyUpdate.MakeFormKey(0xDA0153));
        public static readonly FormLink<IKeywordGetter> SPIKEWeapIronSword = new(KeyUpdate.MakeFormKey(0xDA0155));
        public static readonly FormLink<IKeywordGetter> SPIKEWeapKillerBlade = new(KeyUpdate.MakeFormKey(0xDA0157));
        public static readonly FormLink<IKeywordGetter> SPIKEWeapPigsticker = new(KeyUpdate.MakeFormKey(0xDA0159));
        public static readonly FormLink<IKeywordGetter> SPIKEWeapScaryMace = new(KeyUpdate.MakeFormKey(0xDA015B));
        public static readonly FormLink<IKeywordGetter> SPIKEWeapSteelSword = new(KeyUpdate.MakeFormKey(0xDA015D));
        public static readonly FormLink<IKeywordGetter> SPIKEWeapWickedAxe = new(KeyUpdate.MakeFormKey(0xDA015F));




        public static async Task<int> Main(string[] args)
        {
            return await SynthesisPipeline.Instance
                .AddPatch<ISkyrimMod, ISkyrimModGetter>(RunPatch)
                .SetTypicalOpen(GameRelease.SkyrimSE, "GDOPatcher.esp").AddRunnabilityCheck(state =>
                {
                    state.LoadOrder.AssertHasMod(KeyGDO, true, "\n\nGuard Dialogue Overhaul.esp missing!\n\n");
                })
                .Run(args);
        }

        public static void RunPatch(IPatcherState<ISkyrimMod, ISkyrimModGetter> state)
        {
            var GDOESP = state.LoadOrder.GetIfEnabled(KeyGDO);
            var armorCount = 0;
            var weaponCount = 0;
            if (GDOESP.Mod == null) return;

            foreach (var armor in state.LoadOrder.PriorityOrder.OnlyEnabled().Armor().WinningOverrides())
            {
                if (armor != null && armor.BodyTemplate != null && !armor.BodyTemplate.FirstPersonFlags.HasFlag(BipedObjectFlag.Body)) continue;

                //Removing Templated Armors
                if (armor != null && !armor.TemplateArmor.IsNull) continue;

                //Removing Patched Armors
                if (armor != null && (armor.HasKeyword(SPIKEArmorAssassin) || armor.HasKeyword(SPIKEArmorBrigand) || armor.HasKeyword(SPIKEArmorDragonBone) || armor.HasKeyword(SPIKEArmorDragonScale) || armor.HasKeyword(SPIKEArmorDwarven) || armor.HasKeyword(SPIKEArmorEbony) || armor.HasKeyword(SPIKEArmorFancyBlack) || armor.HasKeyword(SPIKEArmorImperial) || armor.HasKeyword(SPIKEArmorImperialScout) || armor.HasKeyword(SPIKEArmorImperialSecurity) || armor.HasKeyword(SPIKEArmorIron) || armor.HasKeyword(SPIKEArmorLeather) || armor.HasKeyword(SPIKEArmorMerc) || armor.HasKeyword(SPIKEArmorOrcish) || armor.HasKeyword(SPIKEArmorScaleShiny) || armor.HasKeyword(SPIKEArmorSons) || armor.HasKeyword(SPIKEArmorSonsBear) || armor.HasKeyword(SPIKEArmorSteel) || armor.HasKeyword(SPIKEArmorSteelPlate) || armor.HasKeyword(SPIKEArmorStinksDeath) || armor.HasKeyword(SPIKEArmorThievesGuild) || armor.HasKeyword(SPIKEArmorTrueNord) || armor.HasKeyword(SPIKEArmorWeak) || armor.HasKeyword(SPIKEGodsBlessings) || armor.HasKeyword(SPIKEGodsPraised) || armor.HasKeyword(SPIKEImperialAuxiliary) || armor.HasKeyword(SPIKEImperialLegate) || armor.HasKeyword(SPIKEImperialPraefect) || armor.HasKeyword(SPIKEImperialQuaestor) || armor.HasKeyword(SPIKEImperialTribune) || armor.HasKeyword(SPIKERedguardMerc) || armor.HasKeyword(SPIKEShieldFancyDwarven) || armor.HasKeyword(SPIKESonsBoneBreaker) || armor.HasKeyword(SPIKESonsIceVeins) || armor.HasKeyword(SPIKESonsSnowHammer) || armor.HasKeyword(SPIKESonsStormblade) || armor.HasKeyword(SPIKESonsUnblooded) || armor.HasKeyword(SPIKEStaffHorror) || armor.HasKeyword(SPIKEWeapBigHammer) || armor.HasKeyword(SPIKEWeapElvenBlade) || armor.HasKeyword(SPIKEWeapFancySwordBlack) || armor.HasKeyword(SPIKEWeapFoul) || armor.HasKeyword(SPIKEWeapIronSword) || armor.HasKeyword(SPIKEWeapKillerBlade) || armor.HasKeyword(SPIKEWeapPigsticker) || armor.HasKeyword(SPIKEWeapScaryMace) || armor.HasKeyword(SPIKEWeapSteelSword) || armor.HasKeyword(SPIKEWeapWickedAxe))) continue;

                //Dragonplate Armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialDragonplate.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorDragonBone.FormKey);
                        armorCount++;
                    }
                }

                //Dragonscale Armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialDragonscale.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorDragonScale.FormKey);
                        armorCount++;
                    }
                }

                //Dwarven Armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialDwarven.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorDwarven.FormKey);
                        armorCount++;
                    }
                }

                //Ebony Armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialEbony.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorEbony.FormKey);
                        armorCount++;
                    }
                }

                //Fancy Black Armor (Daedric)
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialDaedric.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorFancyBlack.FormKey);
                        armorCount++;
                    }
                }

                //Hide Armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialHide.FormKey) && !armor.HasKeyword(Skyrim.Keyword.ArmorMaterialScaled))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorLeather.FormKey);
                        armorCount++;
                    }
                }

                //Imperial Heavy Armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialImperialHeavy.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorImperial.FormKey);
                        armorCount++;
                    }
                }

                //Imperial Light Armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialImperialLight.FormKey) && !armor.HasKeyword(Skyrim.Keyword.ArmorMaterialImperialStudded.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorImperialScout.FormKey);
                        armorCount++;
                    }
                }

                //Imperial Studded Armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialImperialStudded.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorImperial.FormKey);
                        armorCount++;
                    }
                }

                //Iron Armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialIron.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorIron.FormKey);
                        armorCount++;
                    }
                }

                //Leather Armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialLeather.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorLeather.FormKey);
                        armorCount++;
                    }
                }

                //Orcish armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialOrcish.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorOrcish.FormKey);
                        armorCount++;
                    }
                }

                //Scaled armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialScaled.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorScaleShiny.FormKey);
                        armorCount++;
                    }
                }

                //Steel armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialSteel.FormKey))
                {
                    //Blacklisting Specific Armors
                    if (armor.FormKey.Equals(Skyrim.Armor.ArmorCompanionsCuirass)) continue;
                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorSteel.FormKey);
                        armorCount++;
                    }
                }

                //Steel Plate armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialSteelPlate.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorSteelPlate.FormKey);
                        armorCount++;
                    }
                }

                //Stormcloak
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialStormcloak.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorSons.FormKey);
                        armorCount++;
                    }
                }

                //Stormcloak Officer
                if (armor != null && armor.HasKeyword(Update.Keyword.ArmorMaterialBearStormcloak.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorSonsBear.FormKey);
                        armorCount++;
                    }
                }

                //Thieves Guild
                if (armor != null && (armor.HasKeyword(Update.Keyword.ArmorMaterialThievesGuild.FormKey) || armor.HasKeyword(Update.Keyword.ArmorMaterialThievesGuildLeader)))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorThievesGuild.FormKey);
                        armorCount++;
                    }
                }

                //True Nord
                if (armor != null && armor.HasKeyword(Dragonborn.Keyword.DLC2ArmorMaterialNordicHeavy.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorTrueNord.FormKey);
                        armorCount++;
                    }
                }
            }
            Console.WriteLine(armorCount + " Armors Patched");
        }
    }
}
