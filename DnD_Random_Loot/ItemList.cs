﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DnD_Random_Loot
{
    class ItemList
    {
        int[] items = new int[] { };
       public string[] items1 = new string[] {"candle", "torch", "lamp", "jug of ale", "pich of wine", "rations", "tankard", "vial", "water skin", "sack", "scroll case", "iron pot", "jug", "basket", "backpack", "barrel", "bottle", "crossbow bolt case", "chest", "flask", "bucket", "quiver", "pouch", "pitcher", "turkey leg", "meat chunk", "hunk of cheese", "apple", "bread loaf", "feed", "gallon of ale", "common clothes", "travelers clothes", "robe", "parchment", "paper", "bit & bridle", "oil", "chalk", "whetstone", "ink pen", "blanket", "sealing wax", "portable ram", "manacles", "abacus", "fishing tackle", "piton", "iron spike", "tent", "signal whistle", "tinderbox", "soap", "bell", "block & tackle", "bedroll", "ball bearings", "3 dragon ante set", "playing card set", "dragonchess set", "dice set", "mess kit", "weavers tools", "woodcarver's tools", "cooks utensils", "crowbar", "shovel", "pole", "miner's pick", "grappling hook", "hammer", "hempen rope", "sledgehammer", "ladder", "shawm", "flute", "sickle", "net", "light hammer", "spear",
"dart", "pike", "dagger", "greatclub", "javelin", "club", "whip", "quarterstaff", "sling", "arrows", "blowgun needles", "crossbow bolts", "totem", "sling bullets", "sprig mistletoe", "gold piece", "hooded lantern", "costume clothes", "saddlebags", "pack saddle", "signet ring", "steel mirror", "hunting trap", "merchants scale", "perfume", "calligrapher's supplies", "herbalism kit", "healers kit", "leatherworker's tools", "cobbler's tools", "chain", "drum", "mace", "war pick", "hand axe", "trident", "reliquary", "staff", "holy amulet", "holy emblem", "wooden staff", "padded armor", "silver fork", "silver spoon", "silver knife", "5 gold pieces", "carpenter's tools", "bullsete lantern", "ink vial", "fine wine", "ridding saddle", "dungeoneer's pack", "explorer's pack", "painter's supplies", "mason's tools", "potter's tools", "silk rope", "pan flute", "blowgun", "flail", "shortsword", "battleaxe", "lance", "lock", "maul", "rod", "yew wand", "leather armor", "hide armor", "shield", "ship in a bottle", "moss agate",
"blue quarts", "obsidian", "hematite", "turquoise", "tiger eye", "rhodochrosite", "eye agate", "banded agate", "malachite", "lapis lazuli", "azurite", "wand", "10 gold pieces", "priest's pack", "fine clothes", "cart", "burglar's pack", "forgery kit", "cartographer's tools", "morningstar", "warhammer", "longsword", "gold spoon", "gold fork", "gold knife", "gold pawn", "bone dice", "gold locket", "golden bracelet", "20 gold pieces", "bone statuette", "gold knight", "silk handkerchief", "orb", "crystal", "hourglass", "book", "holy water", "acid vial", "smith's tools", "sled", "military saddle", "dwarven candelabra", "component pouch", "glaive", "thieve's tools", "copper chalice", "brewer's supplies", "climber's kit", "copper candelabra", "silver ewer", "black velvet mask", "rapier", "navigator's tools", "dulcimer", "shortbow", "light crossbow", "halberd", "mirror", "disguise kit", "silver platter", "scimitar", "golden vestment", "ring mail", "great axe", "bagpipes", "viol", "lute", "glassblower's tools", "lyre",
"diplomat's pack", "wagon", "studded leather armor", "scholar's pack", "entertainer's pack", "potion of healing", "antitoxin", "alchemist fire", "chrysoprase", "zircon", "star rose quartz", "jasper", "citrine", "sardonyx", "onyx", "moonstone", "carnelian", "chalcedony", "quartz", "50 gold pieces", "bloodstone", "poisoner's kit", "alchemist supplies", "rowboat", "spellbook", "treasure hoard", "greatsword", "longbow", "heavy crossbow", "chain shirt", "scale mail", "silver candelabra", "exotic saddle", "chain mail", "hand crossbow", "magnifying glass", /*Magic items*/"yellow diamond elemental gem", "eyes of minuet seeing", "boots of elvenkind", "helm of telepathy", "dust of sneezing & choking", "wand of magic detection", "dust of dryness", "eyes of charming", "ring of swimming", "bag of holding", "medallion of thoughts", "boots of striding and sprinting", "keogthom's ointment", "periapt of health", "ring of warmth", "winged boots", "stone of goodluck", "wind fan", "circlet of blasting", "pearl of power",
"ring of water walking", "brooch of shielding", "periapt of wounds closure", "eyes of the eagle", "wand of war mage", "boots of winterlands", "dust of disappearance", "gloves of swimming & climbing", "eversmoking bottle", "broom of flying", "emerald elemental gem", "goggles of night", "javelin of lightning", "immovable rod", "blue sapphire elemental gem", "trident of fish command", "helm of comprehending languages", "adamantine armor", "mariner's armor", "rust bag of tricks", "cloak of the manta ray", "driftglobe", "headband of intellect", "slippers of spider climbing", "red corundum elemental gem", "lantern of revealing", "wand of web", "tan bag of tricks", "gem of brightness", "gray bag of tricks", "gloves of missile snaring", "alchemy jug", "necklace of adaption", "ring of mind shielding", "ring of jumping", "hat of disguises", "quiver of ehlonna", "bracers of archery", "magic ammunition", "magic shield", "mithral armor", "gloves of thievery", "wand of magic missiles", "magic weapon",
"gauntlets of ogre power", "cloak of protection", "cloak of elvenkind", "wand of secrets", "oil of slipperiness", "philter of love", "potion of water breathing", "potion of growth", "potion of animal friendship", "potion of climbing", "potion of fire breath", "potion of poison", "potion of hill giant strength", "potion of stone giant strength", "potion of heroism", "potion of diminution", "potion of gaseous form", "potion of vitality", "oil of sharpness", "potion of longevity", "potion of speed", "elixir of health", "potion of invisibility", "ivory candelabra", "bronze crown", "turquose figurines", "gold birdcage", "ivory statue", "100 gold pieces", "garnet", "amethyst", "jade", "jet", "coral pipe", "chrysobryl", "spinel", "pearl", "tourmaline", "coral", "amber", "gold platter", "ivory pipe", "thorn circlet", "gold bishop", "silver necklace", "gold bracelet", "brass mug", "gold rook", "silk robe", "gold ring", "tapestry", "poison vial", "potion of greater healing", "potion of superior healing", "chariot",
"carriage", "silvered weapon", "splint", "breastplate", "treasure hoard", "silver chalice", "gold ewer", "gold gavel", "obsidian statuette", "silver horn", "gold idol", "silver plated longsword", "ceremonial dagger", "exotic harp", "dragon comb", "half plate", "treasure hoard+", "war mask", "brooch", "bottle stopper", "gold pipe", "gold candelabra", "alexandrite", "topaz", "aquamarine", "blue spinel", "peridot", "black pearl", "1000 gold pieces", "black opal", "emerald", "fire opal", "star sapphire", "star ruby", "opal", "yellow sapphire", "blue sapphire", "gold compass", "elven crown", "skull cup", "mantle", "gold queen", "gold king", "gold chain necklace", "embroidered gloves", "eye patch", "gold circlet", "spyglass", "decorative shield", "collapsible spyglass", "platinum goblet", "sword plaque", "jeweled anklet", "platinum bracelet", "jade chess board", "gold music box", "masterpiece painting", "plate armor", "keelboat", "pearl necklace", "potion of mind reading", "potion of invulnerability",
"potion of frost giant strength", "potion of fire giant strength", "oil of etherealness", "potion of clairvoyance", "potion of flying", "potion of storm giant strength", "shield of missile attraction", "rod of rulership", "ring of psychic resistance", "ring of free action", "ring of cold resistance", "ring of x-ray vision", "ring of thunder resistance", "ring of the ram", "ring spell storing", "ring of radiant resistance", "ring of protection", "ring of force resistance", "ring of animal influence", "ring of poison resistance", "ring of necrotic resistance", "ring of acid resistance", "ring of lightning resistance", "ring of feather falling", "periapt of proof against poison", "ring of evasion", "necklace of fireballs", "ring of fire resistance", "boots of levitation", "armor of cold resistance", "bag of beans", "wand of war mage", "vicious weapon", "stone of controlling earth elements", "cape of the mountebank", "armor radiant resistance", "wings of flying", "magic weapon", "wand of paralysis",
            "tentacle rod", "staff of withering", "wand of lightning bolts", "wand of fireballs", "wand of enemy detection", "sword of wounding", "staff of healing", "sword of life stealing", "sun blade", "magic shield", "shield of missile attraction", "armor of thunder resistance", "armor of acid resistance", "magic ammunition * 2", "armor of poison resistance", "armor necroticresistance", "chime of opening", "amulet of health", "armor of psychic resistance", "bowl of commanding water elementals", "armor of force resistance", "cloak of displacement", "bracers of defense", "boots of speed", "armor of lightning resistance", "armor of vulnerability", "censer of controlling air elementals", "belt of hill giant strength", "arrow catching shield", "bead of force", "armor of fire resistance", "armor of vulnerability", "amulet of proof against detection & location", "horseshoes of speed", "mantle of spell resistance", "gem of seeing", "helm of teleportation", "flame tongue", "elven chain", "dragon slayer", "dimensional shackles",
"brass horn of valhalla", "horn of blasting", "cloak of the bat", "mace of disruption", "brazier of commanding fire elementals", "mace of smithing", "belt of darvenkind", "magic armor", "silver horn of valhalla", "giant slayer", "dagger of venom", "glamoured studded leather", "bronze horn of valhalla", "horseshoes of a zephyr", "manual of bodily health", "manual of gainful exercise", "manual of golems", "manual of quickness of action", "frost band", "efreeti bottle", "dwarven thrower", "dwarven plate", "magic armor", "carpet of flying", "candle of invocation", "wand of polymorph", "staff of striking", "scimitar of speed", "dancing sword", "crystal ball", "carpet of flying", "amulet of the planes", "belt of stone giant strength", "cloak of arachnida", "carpet of flying+", "bag of devouring", "magic ammunition * 3", "animated shield", "animated shield", "tome of the understanding", "staff of frost", "ring of telekinesis", "arrow of slaying", "belt of fire giant strength", "carpet of flying++", "belt of frost giant strength",
            "tome of leadership & influence", "staff of fire", "ring of regeneration", "magic weapon++", "wand of war mage", "tome of clear thought", "spellguard shield", "oathbow", "sword of sharpness", "magic shield++", "nine lives stealer", "jacinth", "diamond", "ruby", "black sapphire", "platinum urn", "gold statuette", "gold cup", "platinum ring", "gold crown", "crystal ball of true seeing", "hammer of thunderbolts", "decorative helmet", "ivory drinking horn", "jewelry box", "royal chess set", "child's sarcophagus", "galley", "airship", "longship", "sailing ship", "warship", "iron horn of valhalla", "luck blade", "holy avenger", "crystal ball of telepathy", "magic armor", "defender", "universal solvent", "well of many worlds", "crystal ball of mind reading", "belt of cloud giant strength", "sovereign glue", "scarab of protection", "ring of spell turning", "ring of invisibility", "armor of invulnerability", "cloak of invisibility", "vorpal sword", "belt of storm giant strength", "talisman of the sphere", "cubic gate", "ring of three wishes", "plate armor of etherealness","1M gold coins"};
    }
}