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
        // private static readonly ModKey KeyRequiem = ModKey.FromNameAndExtension("Requiem.esp");


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
                    state.LoadOrder.AssertListsMod(KeyGDO, "\n\nGuard Dialogue Overhaul.esp missing!\n\n");
                })
                .Run(args);
        }

        public static void RunPatch(IPatcherState<ISkyrimMod, ISkyrimModGetter> state)
        {
            var GDOESP = state.LoadOrder.GetIfEnabled(KeyGDO);
            var armorCount = 0;
            var weaponCount = 0;
            // var RequiemESP = state.LoadOrder.GetIfEnabled(KeyRequiem);
            if (GDOESP.Mod == null) return;
            // if (RequiemESP.Mod != null) Console.WriteLine("Requiem is is installed, patching additional armor sets");


            foreach (var armor in state.LoadOrder.PriorityOrder.OnlyEnabled().Armor().WinningOverrides())
            {
                if (armor != null && armor.BodyTemplate != null && !armor.BodyTemplate.FirstPersonFlags.HasFlag(BipedObjectFlag.Body)) continue;

                //Removing Non-Playable Armors
                if (armor != null && armor.MajorFlags.HasFlag(Armor.MajorFlag.NonPlayable)) continue;

                //Removing Templated Armors
                if (armor != null && !armor.TemplateArmor.IsNull) continue;

                //Removing Patched Armors
                if (armor != null && (armor.HasKeyword(SPIKEArmorAssassin) || armor.HasKeyword(SPIKEArmorBrigand) || armor.HasKeyword(SPIKEArmorDragonBone) || armor.HasKeyword(SPIKEArmorDragonScale) || armor.HasKeyword(SPIKEArmorDwarven) || armor.HasKeyword(SPIKEArmorEbony) || armor.HasKeyword(SPIKEArmorFancyBlack) || armor.HasKeyword(SPIKEArmorImperial) || armor.HasKeyword(SPIKEArmorImperialScout) || armor.HasKeyword(SPIKEArmorImperialSecurity) || armor.HasKeyword(SPIKEArmorIron) || armor.HasKeyword(SPIKEArmorLeather) || armor.HasKeyword(SPIKEArmorMerc) || armor.HasKeyword(SPIKEArmorOrcish) || armor.HasKeyword(SPIKEArmorScaleShiny) || armor.HasKeyword(SPIKEArmorSons) || armor.HasKeyword(SPIKEArmorSonsBear) || armor.HasKeyword(SPIKEArmorSteel) || armor.HasKeyword(SPIKEArmorSteelPlate) || armor.HasKeyword(SPIKEArmorStinksDeath) || armor.HasKeyword(SPIKEArmorThievesGuild) || armor.HasKeyword(SPIKEArmorTrueNord) || armor.HasKeyword(SPIKEArmorWeak) || armor.HasKeyword(SPIKEGodsBlessings) || armor.HasKeyword(SPIKEGodsPraised) || armor.HasKeyword(SPIKEImperialAuxiliary) || armor.HasKeyword(SPIKEImperialLegate) || armor.HasKeyword(SPIKEImperialPraefect) || armor.HasKeyword(SPIKEImperialQuaestor) || armor.HasKeyword(SPIKEImperialTribune) || armor.HasKeyword(SPIKERedguardMerc) || armor.HasKeyword(SPIKEShieldFancyDwarven) || armor.HasKeyword(SPIKESonsBoneBreaker) || armor.HasKeyword(SPIKESonsIceVeins) || armor.HasKeyword(SPIKESonsSnowHammer) || armor.HasKeyword(SPIKESonsStormblade) || armor.HasKeyword(SPIKESonsUnblooded) || armor.HasKeyword(SPIKEStaffHorror) || armor.HasKeyword(SPIKEWeapBigHammer) || armor.HasKeyword(SPIKEWeapElvenBlade) || armor.HasKeyword(SPIKEWeapFancySwordBlack) || armor.HasKeyword(SPIKEWeapFoul) || armor.HasKeyword(SPIKEWeapIronSword) || armor.HasKeyword(SPIKEWeapKillerBlade) || armor.HasKeyword(SPIKEWeapPigsticker) || armor.HasKeyword(SPIKEWeapScaryMace) || armor.HasKeyword(SPIKEWeapSteelSword) || armor.HasKeyword(SPIKEWeapWickedAxe))) continue;

                //Aetherium
                /*if (RequiemESP.Mod != null)
                {
                    FormLink<IKeywordGetter> REQ_ArmorSet_Aetherium = new(KeyRequiem.MakeFormKey(0xAD39BD));
                    if (armor != null && armor.HasKeyword(REQ_ArmorSet_Aetherium))
                    {

                        var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                        if (armorPatch.Keywords != null)
                        {
                            armorPatch.Keywords.Add(SPIKEArmorDwarven.FormKey);
                            armorCount++;
                        }
                    }
                }

                //Ancient Nord
                if (RequiemESP.Mod != null)
                {
                    FormLink<IKeywordGetter> REQ_ArmorSet_AncientNord = new(KeyRequiem.MakeFormKey(0xAD39BE));
                    if (armor != null && armor.HasKeyword(REQ_ArmorSet_AncientNord))
                    {

                        var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                        if (armorPatch.Keywords != null)
                        {
                            armorPatch.Keywords.Add(SPIKEArmorStinksDeath.FormKey);
                            armorCount++;
                        }
                    }
                }

                //Ancient Shrouded
                if (RequiemESP.Mod != null)
                {
                    FormLink<IKeywordGetter> REQ_ArmorSet_AncientShrouded = new(KeyRequiem.MakeFormKey(0xAD39C4));
                    if (armor != null && armor.HasKeyword(REQ_ArmorSet_AncientShrouded))
                    {

                        var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                        if (armorPatch.Keywords != null)
                        {
                            armorPatch.Keywords.Add(SPIKEArmorAssassin.FormKey);
                            armorCount++;
                        }
                    }
                }*/

                //Dark Brotherhood Armor
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorDarkBrotherhood.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorAssassin.FormKey);
                        armorCount++;
                    }
                }

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

                //Falmer Light Armor
                if (armor != null && armor.HasKeyword(Update.Keyword.ArmorMaterialFalmer.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorStinksDeath.FormKey);
                        armorCount++;
                    }
                }

                //Falmer Heavy Armor
                if (armor != null && (armor.HasKeyword(Dawnguard.Keyword.DLC1ArmorMaterielFalmerHeavy.FormKey) || armor.HasKeyword(Dawnguard.Keyword.DLC1ArmorMaterielFalmerHeavyOriginal.FormKey)))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorStinksDeath.FormKey);
                        armorCount++;
                    }
                }

                //Falmer Hardened Armor
                if (armor != null && armor.HasKeyword(Dawnguard.Keyword.DLC1ArmorMaterialFalmerHardened.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorStinksDeath.FormKey);
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

                //Fur
                /*if (RequiemESP.Mod != null)
                {
                    FormLink<IKeywordGetter> REQ_ArmorSet_Fur = new(KeyRequiem.MakeFormKey(0xAD3ADE));
                    if (armor != null && armor.HasKeyword(REQ_ArmorSet_Fur))
                    {

                        var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                        if (armorPatch.Keywords != null)
                        {
                            armorPatch.Keywords.Add(SPIKEArmorWeak.FormKey);
                            armorCount++;
                        }
                    }
                }*/

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

                //Imperial Legate
                /*if (RequiemESP.Mod != null)
                {
                    FormLink<IKeywordGetter> REQ_ArmorSet_ImperialLegate = new(KeyRequiem.MakeFormKey(0xAD39C5));
                    if (armor != null && armor.HasKeyword(REQ_ArmorSet_ImperialLegate))
                    {

                        var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                        if (armorPatch.Keywords != null)
                        {
                            armorPatch.Keywords.Add(SPIKEArmorImperial.FormKey);
                            armorCount++;
                        }
                    }
                }*/

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

                //Morag Tong Armor
                if (armor != null && armor.HasKeyword(Dragonborn.Keyword.DLC2ArmorMaterialMoragTong.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorAssassin.FormKey);
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

                //Redguard
                /*if (RequiemESP.Mod != null)
                {
                    FormLink<IKeywordGetter> REQ_ArmorSet_Hammerfell = new(KeyRequiem.MakeFormKey(0xAD39C2));
                    if (armor != null && armor.HasKeyword(REQ_ArmorSet_Hammerfell))
                    {

                        var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                        if (armorPatch.Keywords != null)
                        {
                            armorPatch.Keywords.Add(SPIKERedguardMerc.FormKey);
                            armorCount++;
                        }
                    }
                }*/
                //else
                //{
                    if (armor != null && (armor.NamedFieldsContain("Redguard") || armor.NamedFieldsContain("Hammerfell") || armor.NamedFieldsContain("Alik'r")))
                    {

                        var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                        if (armorPatch.Keywords != null)
                        {
                            armorPatch.Keywords.Add(SPIKERedguardMerc.FormKey);
                            armorCount++;
                        }
                    }
                //}
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

                //Studded
                if (armor != null && armor.HasKeyword(Skyrim.Keyword.ArmorMaterialStudded.FormKey))
                {

                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorBrigand.FormKey);
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

                //Wolf
                /*if (RequiemESP.Mod != null)
                {
                    FormLink<IKeywordGetter> REQ_ArmorSet_Wolf = new(KeyRequiem.MakeFormKey(0xAD3A3F));
                    if (armor != null && armor.HasKeyword(REQ_ArmorSet_Wolf))
                    {

                        var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                        if (armorPatch.Keywords != null)
                        {
                            armorPatch.Keywords.Add(SPIKEArmorTrueNord.FormKey);
                            armorCount++;
                        }
                    }
                }*/

                //Special Cases
                //Non Vampire Lord Armor
                if (armor!= null && (armor.FormKey.Equals(Dawnguard.Armor.DLC1ArmorVampireArmorGray) || armor.FormKey.Equals(Dawnguard.Armor.DLC1ArmorVampireArmorGrayLight) || armor.FormKey.Equals(Dawnguard.Armor.DLC1ArmorVampireArmorRed)))
                {
                    var armorPatch = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    if (armorPatch.Keywords != null)
                    {
                        armorPatch.Keywords.Add(SPIKEArmorStinksDeath.FormKey);
                        armorCount++;
                    }
                }
            }
            Console.WriteLine(armorCount + " Armors Patched");

            foreach (var weapon in state.LoadOrder.PriorityOrder.OnlyEnabled().Weapon().WinningOverrides())
            {
                if (weapon == null) continue;

                //Removing Non-Playable Weapons
                if (weapon != null && weapon.MajorFlags.HasFlag(Weapon.MajorFlag.NonPlayable)) continue;

                //Removing Templated Weapons
                if (weapon != null && !weapon.Template.IsNull) continue;

                //Removing Patched Weapons
                if (weapon != null && (weapon.HasKeyword(SPIKEArmorAssassin) || weapon.HasKeyword(SPIKEArmorBrigand) || weapon.HasKeyword(SPIKEArmorDragonBone) || weapon.HasKeyword(SPIKEArmorDragonScale) || weapon.HasKeyword(SPIKEArmorDwarven) || weapon.HasKeyword(SPIKEArmorEbony) || weapon.HasKeyword(SPIKEArmorFancyBlack) || weapon.HasKeyword(SPIKEArmorImperial) || weapon.HasKeyword(SPIKEArmorImperialScout) || weapon.HasKeyword(SPIKEArmorImperialSecurity) || weapon.HasKeyword(SPIKEArmorIron) || weapon.HasKeyword(SPIKEArmorLeather) || weapon.HasKeyword(SPIKEArmorMerc) || weapon.HasKeyword(SPIKEArmorOrcish) || weapon.HasKeyword(SPIKEArmorScaleShiny) || weapon.HasKeyword(SPIKEArmorSons) || weapon.HasKeyword(SPIKEArmorSonsBear) || weapon.HasKeyword(SPIKEArmorSteel) || weapon.HasKeyword(SPIKEArmorSteelPlate) || weapon.HasKeyword(SPIKEArmorStinksDeath) || weapon.HasKeyword(SPIKEArmorThievesGuild) || weapon.HasKeyword(SPIKEArmorTrueNord) || weapon.HasKeyword(SPIKEArmorWeak) || weapon.HasKeyword(SPIKEGodsBlessings) || weapon.HasKeyword(SPIKEGodsPraised) || weapon.HasKeyword(SPIKEImperialAuxiliary) || weapon.HasKeyword(SPIKEImperialLegate) || weapon.HasKeyword(SPIKEImperialPraefect) || weapon.HasKeyword(SPIKEImperialQuaestor) || weapon.HasKeyword(SPIKEImperialTribune) || weapon.HasKeyword(SPIKERedguardMerc) || weapon.HasKeyword(SPIKEShieldFancyDwarven) || weapon.HasKeyword(SPIKESonsBoneBreaker) || weapon.HasKeyword(SPIKESonsIceVeins) || weapon.HasKeyword(SPIKESonsSnowHammer) || weapon.HasKeyword(SPIKESonsStormblade) || weapon.HasKeyword(SPIKESonsUnblooded) || weapon.HasKeyword(SPIKEStaffHorror) || weapon.HasKeyword(SPIKEWeapBigHammer) || weapon.HasKeyword(SPIKEWeapElvenBlade) || weapon.HasKeyword(SPIKEWeapFancySwordBlack) || weapon.HasKeyword(SPIKEWeapFoul) || weapon.HasKeyword(SPIKEWeapIronSword) || weapon.HasKeyword(SPIKEWeapKillerBlade) || weapon.HasKeyword(SPIKEWeapPigsticker) || weapon.HasKeyword(SPIKEWeapScaryMace) || weapon.HasKeyword(SPIKEWeapSteelSword) || weapon.HasKeyword(SPIKEWeapWickedAxe))) continue;

                //Daedric Greatsword
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialDaedric) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeGreatsword))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapFancySwordBlack);
                        weaponCount++;
                    }
                }

                //Daedric Sword
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialDaedric) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeSword))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        //Removing Miraak's Sword
                        if (weapon.FormKey.Equals(Dragonborn.Weapon.DLC2MKMiraakSword1) || weapon.FormKey.Equals(Dragonborn.Weapon.DLC2MKMiraakSword2) || weapon.FormKey.Equals(Dragonborn.Weapon.DLC2MKMiraakSword3)) continue;

                        weaponPatch.Keywords.Add(SPIKEWeapFancySwordBlack);
                        weaponCount++;
                    }
                }

                //Ebony Greatsword
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialEbony) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeGreatsword))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapFancySwordBlack);
                        weaponCount++;
                    }
                }

                //Ebony Sword
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialEbony) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeSword))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapFancySwordBlack);
                        weaponCount++;
                    }
                }

                //Elven Dagger
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialElven) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeDagger))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapElvenBlade);
                        weaponCount++;
                    }
                }

                //Elven Greatsword
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialElven) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeGreatsword))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapElvenBlade);
                        weaponCount++;
                    }
                }

                //Elven Sword
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialElven) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeSword))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapElvenBlade);
                        weaponCount++;
                    }
                }

                //Imperial Dagger
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialImperial) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeDagger))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapSteelSword);
                        weaponPatch.Keywords.Add(SPIKEWeapPigsticker);
                        weaponCount++;
                    }
                }

                //Imperial Greatsword
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialImperial) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeGreatsword))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapSteelSword);
                        weaponCount++;
                    }
                }

                //Imperial Sword
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialImperial) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeSword))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapSteelSword);
                        weaponCount++;
                    }
                }

                //Iron Dagger
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialIron) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeDagger))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapIronSword);
                        weaponPatch.Keywords.Add(SPIKEWeapPigsticker);
                        weaponCount++;
                    }
                }

                //Iron Greatsword
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialIron) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeGreatsword))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapIronSword);
                        weaponCount++;
                    }
                }

                //Iron Sword
                if (weapon!= null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialIron) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeSword))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapIronSword);
                        weaponPatch.Keywords.Add(SPIKEWeapPigsticker);
                        weaponCount++;
                    }
                }

                //Steel Dagger
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialSteel) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeDagger))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapSteelSword);
                        weaponPatch.Keywords.Add(SPIKEWeapPigsticker);
                        weaponCount++;
                    }
                }

                //Steel Greatsword
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialSteel) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeGreatsword))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapSteelSword);
                        weaponCount++;
                    }
                }

                //Steel Sword
                if (weapon != null && weapon.HasKeyword(Skyrim.Keyword.WeapMaterialSteel) && weapon.HasKeyword(Skyrim.Keyword.WeapTypeSword))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapSteelSword);
                        weaponCount++;
                    }
                }

                //Special Weapons
                if (weapon != null && (weapon.FormKey.Equals(Dragonborn.Weapon.DLC2MKMiraakSword1) || weapon.FormKey.Equals(Dragonborn.Weapon.DLC2MKMiraakSword2) || weapon.FormKey.Equals(Dragonborn.Weapon.DLC2MKMiraakSword3)))
                {
                    var weaponPatch = state.PatchMod.Weapons.GetOrAddAsOverride(weapon);
                    if (weaponPatch.Keywords != null)
                    {
                        weaponPatch.Keywords.Add(SPIKEWeapFoul);
                        weaponCount++;
                    }
                }


            }
            Console.WriteLine(weaponCount + " Weapons Patched");
        }
    }
}
