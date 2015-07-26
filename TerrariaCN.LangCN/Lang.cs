using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace TerrariaCN.LangCN
{
    public class Lang
    {
        // Terraria.Lang
        public static string itemName(int l, bool english = false)
        {

            if (english)
            {
                switch (l)
                {
                    case -48:
                        return "Platinum Bow";
                    case -47:
                        return "Platinum Hammer";
                    case -46:
                        return "Platinum Axe";
                    case -45:
                        return "Platinum Shortsword";
                    case -44:
                        return "Platinum Broadsword";
                    case -43:
                        return "Platinum Pickaxe";
                    case -42:
                        return "Tungsten Bow";
                    case -41:
                        return "Tungsten Hammer";
                    case -40:
                        return "Tungsten Axe";
                    case -39:
                        return "Tungsten Shortsword";
                    case -38:
                        return "Tungsten Broadsword";
                    case -37:
                        return "Tungsten Pickaxe";
                    case -36:
                        return "Lead Bow";
                    case -35:
                        return "Lead Hammer";
                    case -34:
                        return "Lead Axe";
                    case -33:
                        return "Lead Shortsword";
                    case -32:
                        return "Lead Broadsword";
                    case -31:
                        return "Lead Pickaxe";
                    case -30:
                        return "Tin Bow";
                    case -29:
                        return "Tin Hammer";
                    case -28:
                        return "Tin Axe";
                    case -27:
                        return "Tin Shortsword";
                    case -26:
                        return "Tin Broadsword";
                    case -25:
                        return "Tin Pickaxe";
                    case -24:
                        return "Yellow Phasesaber";
                    case -23:
                        return "White Phasesaber";
                    case -22:
                        return "Purple Phasesaber";
                    case -21:
                        return "Green Phasesaber";
                    case -20:
                        return "Red Phasesaber";
                    case -19:
                        return "Blue Phasesaber";
                    case -18:
                        return "Copper Bow";
                    case -17:
                        return "Copper Hammer";
                    case -16:
                        return "Copper Axe";
                    case -15:
                        return "Copper Shortsword";
                    case -14:
                        return "Copper Broadsword";
                    case -13:
                        return "Copper Pickaxe";
                    case -12:
                        return "Silver Bow";
                    case -11:
                        return "Silver Hammer";
                    case -10:
                        return "Silver Axe";
                    case -9:
                        return "Silver Shortsword";
                    case -8:
                        return "Silver Broadsword";
                    case -7:
                        return "Silver Pickaxe";
                    case -6:
                        return "Gold Bow";
                    case -5:
                        return "Gold Hammer";
                    case -4:
                        return "Gold Axe";
                    case -3:
                        return "Gold Shortsword";
                    case -2:
                        return "Gold Broadsword";
                    case -1:
                        return "Gold Pickaxe";
                    case 1:
                        return "Iron Pickaxe";
                    case 2:
                        return "Dirt Block";
                    case 3:
                        return "Stone Block";
                    case 4:
                        return "Iron Broadsword";
                    case 5:
                        return "Mushroom";
                    case 6:
                        return "Iron Shortsword";
                    case 7:
                        return "Iron Hammer";
                    case 8:
                        return "Torch";
                    case 9:
                        return "Wood";
                    case 10:
                        return "Iron Axe";
                    case 11:
                        return "Iron Ore";
                    case 12:
                        return "Copper Ore";
                    case 13:
                        return "Gold Ore";
                    case 14:
                        return "Silver Ore";
                    case 15:
                        return "Copper Watch";
                    case 16:
                        return "Silver Watch";
                    case 17:
                        return "Gold Watch";
                    case 18:
                        return "Depth Meter";
                    case 19:
                        return "Gold Bar";
                    case 20:
                        return "Copper Bar";
                    case 21:
                        return "Silver Bar";
                    case 22:
                        return "Iron Bar";
                    case 23:
                        return "Gel";
                    case 24:
                        return "Wooden Sword";
                    case 25:
                        return "Wooden Door";
                    case 26:
                        return "Stone Wall";
                    case 27:
                        return "Acorn";
                    case 28:
                        return "Lesser Healing Potion";
                    case 29:
                        return "Life Crystal";
                    case 30:
                        return "Dirt Wall";
                    case 31:
                        return "Bottle";
                    case 32:
                        return "Wooden Table";
                    case 33:
                        return "Furnace";
                    case 34:
                        return "Wooden Chair";
                    case 35:
                        return "Iron Anvil";
                    case 36:
                        return "Work Bench";
                    case 37:
                        return "Goggles";
                    case 38:
                        return "Lens";
                    case 39:
                        return "Wooden Bow";
                    case 40:
                        return "Wooden Arrow";
                    case 41:
                        return "Flaming Arrow";
                    case 42:
                        return "Shuriken";
                    case 43:
                        return "Suspicious Looking Eye";
                    case 44:
                        return "Demon Bow";
                    case 45:
                        return "War Axe of the Night";
                    case 46:
                        return "Light's Bane";
                    case 47:
                        return "Unholy Arrow";
                    case 48:
                        return "Chest";
                    case 49:
                        return "Band of Regeneration";
                    case 50:
                        return "Magic Mirror";
                    case 51:
                        return "Jester's Arrow";
                    case 52:
                        return "Angel Statue";
                    case 53:
                        return "Cloud in a Bottle";
                    case 54:
                        return "Hermes Boots";
                    case 55:
                        return "Enchanted Boomerang";
                    case 56:
                        return "Demonite Ore";
                    case 57:
                        return "Demonite Bar";
                    case 58:
                        return "Heart";
                    case 59:
                        return "Corrupt Seeds";
                    case 60:
                        return "Vile Mushroom";
                    case 61:
                        return "Ebonstone Block";
                    case 62:
                        return "Grass Seeds";
                    case 63:
                        return "Sunflower";
                    case 64:
                        return "Vilethorn";
                    case 65:
                        return "Starfury";
                    case 66:
                        return "Purification Powder";
                    case 67:
                        return "Vile Powder";
                    case 68:
                        return "Rotten Chunk";
                    case 69:
                        return "Worm Tooth";
                    case 70:
                        return "Worm Food";
                    case 71:
                        return "Copper Coin";
                    case 72:
                        return "Silver Coin";
                    case 73:
                        return "Gold Coin";
                    case 74:
                        return "Platinum Coin";
                    case 75:
                        return "Fallen Star";
                    case 76:
                        return "Copper Greaves";
                    case 77:
                        return "Iron Greaves";
                    case 78:
                        return "Silver Greaves";
                    case 79:
                        return "Gold Greaves";
                    case 80:
                        return "Copper Chainmail";
                    case 81:
                        return "Iron Chainmail";
                    case 82:
                        return "Silver Chainmail";
                    case 83:
                        return "Gold Chainmail";
                    case 84:
                        return "Grappling Hook";
                    case 85:
                        return "Chain";
                    case 86:
                        return "Shadow Scale";
                    case 87:
                        return "Piggy Bank";
                    case 88:
                        return "Mining Helmet";
                    case 89:
                        return "Copper Helmet";
                    case 90:
                        return "Iron Helmet";
                    case 91:
                        return "Silver Helmet";
                    case 92:
                        return "Gold Helmet";
                    case 93:
                        return "Wood Wall";
                    case 94:
                        return "Wood Platform";
                    case 95:
                        return "Flintlock Pistol";
                    case 96:
                        return "Musket";
                    case 97:
                        return "Musket Ball";
                    case 98:
                        return "Minishark";
                    case 99:
                        return "Iron Bow";
                    case 100:
                        return "Shadow Greaves";
                    case 101:
                        return "Shadow Scalemail";
                    case 102:
                        return "Shadow Helmet";
                    case 103:
                        return "Nightmare Pickaxe";
                    case 104:
                        return "The Breaker";
                    case 105:
                        return "Candle";
                    case 106:
                        return "Copper Chandelier";
                    case 107:
                        return "Silver Chandelier";
                    case 108:
                        return "Gold Chandelier";
                    case 109:
                        return "Mana Crystal";
                    case 110:
                        return "Lesser Mana Potion";
                    case 111:
                        return "Band of Starpower";
                    case 112:
                        return "Flower of Fire";
                    case 113:
                        return "Magic Missile";
                    case 114:
                        return "Dirt Rod";
                    case 115:
                        return "Shadow Orb";
                    case 116:
                        return "Meteorite";
                    case 117:
                        return "Meteorite Bar";
                    case 118:
                        return "Hook";
                    case 119:
                        return "Flamarang";
                    case 120:
                        return "Molten Fury";
                    case 121:
                        return "Fiery Greatsword";
                    case 122:
                        return "Molten Pickaxe";
                    case 123:
                        return "Meteor Helmet";
                    case 124:
                        return "Meteor Suit";
                    case 125:
                        return "Meteor Leggings";
                    case 126:
                        return "Bottled Water";
                    case 127:
                        return "Space Gun";
                    case 128:
                        return "Rocket Boots";
                    case 129:
                        return "Gray Brick";
                    case 130:
                        return "Gray Brick Wall";
                    case 131:
                        return "Red Brick";
                    case 132:
                        return "Red Brick Wall";
                    case 133:
                        return "Clay Block";
                    case 134:
                        return "Blue Brick";
                    case 135:
                        return "Blue Brick Wall";
                    case 136:
                        return "Chain Lantern";
                    case 137:
                        return "Green Brick";
                    case 138:
                        return "Green Brick Wall";
                    case 139:
                        return "Pink Brick";
                    case 140:
                        return "Pink Brick Wall";
                    case 141:
                        return "Gold Brick";
                    case 142:
                        return "Gold Brick Wall";
                    case 143:
                        return "Silver Brick";
                    case 144:
                        return "Silver Brick Wall";
                    case 145:
                        return "Copper Brick";
                    case 146:
                        return "Copper Brick Wall";
                    case 147:
                        return "Spike";
                    case 148:
                        return "Water Candle";
                    case 149:
                        return "Book";
                    case 150:
                        return "Cobweb";
                    case 151:
                        return "Necro Helmet";
                    case 152:
                        return "Necro Breastplate";
                    case 153:
                        return "Necro Greaves";
                    case 154:
                        return "Bone";
                    case 155:
                        return "Muramasa";
                    case 156:
                        return "Cobalt Shield";
                    case 157:
                        return "Aqua Scepter";
                    case 158:
                        return "Lucky Horseshoe";
                    case 159:
                        return "Shiny Red Balloon";
                    case 160:
                        return "Harpoon";
                    case 161:
                        return "Spiky Ball";
                    case 162:
                        return "Ball O' Hurt";
                    case 163:
                        return "Blue Moon";
                    case 164:
                        return "Handgun";
                    case 165:
                        return "Water Bolt";
                    case 166:
                        return "Bomb";
                    case 167:
                        return "Dynamite";
                    case 168:
                        return "Grenade";
                    case 169:
                        return "Sand Block";
                    case 170:
                        return "Glass";
                    case 171:
                        return "Sign";
                    case 172:
                        return "Ash Block";
                    case 173:
                        return "Obsidian";
                    case 174:
                        return "Hellstone";
                    case 175:
                        return "Hellstone Bar";
                    case 176:
                        return "Mud Block";
                    case 177:
                        return "Sapphire";
                    case 178:
                        return "Ruby";
                    case 179:
                        return "Emerald";
                    case 180:
                        return "Topaz";
                    case 181:
                        return "Amethyst";
                    case 182:
                        return "Diamond";
                    case 183:
                        return "Glowing Mushroom";
                    case 184:
                        return "Star";
                    case 185:
                        return "Ivy Whip";
                    case 186:
                        return "Breathing Reed";
                    case 187:
                        return "Flipper";
                    case 188:
                        return "Healing Potion";
                    case 189:
                        return "Mana Potion";
                    case 190:
                        return "Blade of Grass";
                    case 191:
                        return "Thorn Chakram";
                    case 192:
                        return "Obsidian Brick";
                    case 193:
                        return "Obsidian Skull";
                    case 194:
                        return "Mushroom Grass Seeds";
                    case 195:
                        return "Jungle Grass Seeds";
                    case 196:
                        return "Wooden Hammer";
                    case 197:
                        return "Star Cannon";
                    case 198:
                        return "Blue Phaseblade";
                    case 199:
                        return "Red Phaseblade";
                    case 200:
                        return "Green Phaseblade";
                    case 201:
                        return "Purple Phaseblade";
                    case 202:
                        return "White Phaseblade";
                    case 203:
                        return "Yellow Phaseblade";
                    case 204:
                        return "Meteor Hamaxe";
                    case 205:
                        return "Empty Bucket";
                    case 206:
                        return "Water Bucket";
                    case 207:
                        return "Lava Bucket";
                    case 208:
                        return "Jungle Rose";
                    case 209:
                        return "Stinger";
                    case 210:
                        return "Vine";
                    case 211:
                        return "Feral Claws";
                    case 212:
                        return "Anklet of the Wind";
                    case 213:
                        return "Staff of Regrowth";
                    case 214:
                        return "Hellstone Brick";
                    case 215:
                        return "Whoopie Cushion";
                    case 216:
                        return "Shackle";
                    case 217:
                        return "Molten Hamaxe";
                    case 218:
                        return "Flamelash";
                    case 219:
                        return "Phoenix Blaster";
                    case 220:
                        return "Sunfury";
                    case 221:
                        return "Hellforge";
                    case 222:
                        return "Clay Pot";
                    case 223:
                        return "Nature's Gift";
                    case 224:
                        return "Bed";
                    case 225:
                        return "Silk";
                    case 226:
                        return "Lesser Restoration Potion";
                    case 227:
                        return "Restoration Potion";
                    case 228:
                        return "Jungle Hat";
                    case 229:
                        return "Jungle Shirt";
                    case 230:
                        return "Jungle Pants";
                    case 231:
                        return "Molten Helmet";
                    case 232:
                        return "Molten Breastplate";
                    case 233:
                        return "Molten Greaves";
                    case 234:
                        return "Meteor Shot";
                    case 235:
                        return "Sticky Bomb";
                    case 236:
                        return "Black Lens";
                    case 237:
                        return "Sunglasses";
                    case 238:
                        return "Wizard Hat";
                    case 239:
                        return "Top Hat";
                    case 240:
                        return "Tuxedo Shirt";
                    case 241:
                        return "Tuxedo Pants";
                    case 242:
                        return "Summer Hat";
                    case 243:
                        return "Bunny Hood";
                    case 244:
                        return "Plumber's Hat";
                    case 245:
                        return "Plumber's Shirt";
                    case 246:
                        return "Plumber's Pants";
                    case 247:
                        return "Hero's Hat";
                    case 248:
                        return "Hero's Shirt";
                    case 249:
                        return "Hero's Pants";
                    case 250:
                        return "Fish Bowl";
                    case 251:
                        return "Archaeologist's Hat";
                    case 252:
                        return "Archaeologist's Jacket";
                    case 253:
                        return "Archaeologist's Pants";
                    case 254:
                        return "Black Thread";
                    case 255:
                        return "Green Thread";
                    case 256:
                        return "Ninja Hood";
                    case 257:
                        return "Ninja Shirt";
                    case 258:
                        return "Ninja Pants";
                    case 259:
                        return "Leather";
                    case 260:
                        return "Red Hat";
                    case 261:
                        return "Goldfish";
                    case 262:
                        return "Robe";
                    case 263:
                        return "Robot Hat";
                    case 264:
                        return "Gold Crown";
                    case 265:
                        return "Hellfire Arrow";
                    case 266:
                        return "Sandgun";
                    case 267:
                        return "Guide Voodoo Doll";
                    case 268:
                        return "Diving Helmet";
                    case 269:
                        return "Familiar Shirt";
                    case 270:
                        return "Familiar Pants";
                    case 271:
                        return "Familiar Wig";
                    case 272:
                        return "Demon Scythe";
                    case 273:
                        return "Night's Edge";
                    case 274:
                        return "Dark Lance";
                    case 275:
                        return "Coral";
                    case 276:
                        return "Cactus";
                    case 277:
                        return "Trident";
                    case 278:
                        return "Silver Bullet";
                    case 279:
                        return "Throwing Knife";
                    case 280:
                        return "Spear";
                    case 281:
                        return "Blowpipe";
                    case 282:
                        return "Glowstick";
                    case 283:
                        return "Seed";
                    case 284:
                        return "Wooden Boomerang";
                    case 285:
                        return "Aglet";
                    case 286:
                        return "Sticky Glowstick";
                    case 287:
                        return "Poisoned Knife";
                    case 288:
                        return "Obsidian Skin Potion";
                    case 289:
                        return "Regeneration Potion";
                    case 290:
                        return "Swiftness Potion";
                    case 291:
                        return "Gills Potion";
                    case 292:
                        return "Ironskin Potion";
                    case 293:
                        return "Mana Regeneration Potion";
                    case 294:
                        return "Magic Power Potion";
                    case 295:
                        return "Featherfall Potion";
                    case 296:
                        return "Spelunker Potion";
                    case 297:
                        return "Invisibility Potion";
                    case 298:
                        return "Shine Potion";
                    case 299:
                        return "Night Owl Potion";
                    case 300:
                        return "Battle Potion";
                    case 301:
                        return "Thorns Potion";
                    case 302:
                        return "Water Walking Potion";
                    case 303:
                        return "Archery Potion";
                    case 304:
                        return "Hunter Potion";
                    case 305:
                        return "Gravitation Potion";
                    case 306:
                        return "Gold Chest";
                    case 307:
                        return "Daybloom Seeds";
                    case 308:
                        return "Moonglow Seeds";
                    case 309:
                        return "Blinkroot Seeds";
                    case 310:
                        return "Deathweed Seeds";
                    case 311:
                        return "Waterleaf Seeds";
                    case 312:
                        return "Fireblossom Seeds";
                    case 313:
                        return "Daybloom";
                    case 314:
                        return "Moonglow";
                    case 315:
                        return "Blinkroot";
                    case 316:
                        return "Deathweed";
                    case 317:
                        return "Waterleaf";
                    case 318:
                        return "Fireblossom";
                    case 319:
                        return "Shark Fin";
                    case 320:
                        return "Feather";
                    case 321:
                        return "Tombstone";
                    case 322:
                        return "Mime Mask";
                    case 323:
                        return "Antlion Mandible";
                    case 324:
                        return "Illegal Gun Parts";
                    case 325:
                        return "The Doctor's Shirt";
                    case 326:
                        return "The Doctor's Pants";
                    case 327:
                        return "Golden Key";
                    case 328:
                        return "Shadow Chest";
                    case 329:
                        return "Shadow Key";
                    case 330:
                        return "Obsidian Brick Wall";
                    case 331:
                        return "Jungle Spores";
                    case 332:
                        return "Loom";
                    case 333:
                        return "Piano";
                    case 334:
                        return "Dresser";
                    case 335:
                        return "Bench";
                    case 336:
                        return "Bathtub";
                    case 337:
                        return "Red Banner";
                    case 338:
                        return "Green Banner";
                    case 339:
                        return "Blue Banner";
                    case 340:
                        return "Yellow Banner";
                    case 341:
                        return "Lamp Post";
                    case 342:
                        return "Tiki Torch";
                    case 343:
                        return "Barrel";
                    case 344:
                        return "Chinese Lantern";
                    case 345:
                        return "Cooking Pot";
                    case 346:
                        return "Safe";
                    case 347:
                        return "Skull Lantern";
                    case 348:
                        return "Trash Can";
                    case 349:
                        return "Candelabra";
                    case 350:
                        return "Pink Vase";
                    case 351:
                        return "Mug";
                    case 352:
                        return "Keg";
                    case 353:
                        return "Ale";
                    case 354:
                        return "Bookcase";
                    case 355:
                        return "Throne";
                    case 356:
                        return "Bowl";
                    case 357:
                        return "Bowl of Soup";
                    case 358:
                        return "Toilet";
                    case 359:
                        return "Grandfather Clock";
                    case 360:
                        return "Armor Statue";
                    case 361:
                        return "Goblin Battle Standard";
                    case 362:
                        return "Tattered Cloth";
                    case 363:
                        return "Sawmill";
                    case 364:
                        return "Cobalt Ore";
                    case 365:
                        return "Mythril Ore";
                    case 366:
                        return "Adamantite Ore";
                    case 367:
                        return "Pwnhammer";
                    case 368:
                        return "Excalibur";
                    case 369:
                        return "Hallowed Seeds";
                    case 370:
                        return "Ebonsand Block";
                    case 371:
                        return "Cobalt Hat";
                    case 372:
                        return "Cobalt Helmet";
                    case 373:
                        return "Cobalt Mask";
                    case 374:
                        return "Cobalt Breastplate";
                    case 375:
                        return "Cobalt Leggings";
                    case 376:
                        return "Mythril Hood";
                    case 377:
                        return "Mythril Helmet";
                    case 378:
                        return "Mythril Hat";
                    case 379:
                        return "Mythril Chainmail";
                    case 380:
                        return "Mythril Greaves";
                    case 381:
                        return "Cobalt Bar";
                    case 382:
                        return "Mythril Bar";
                    case 383:
                        return "Cobalt Chainsaw";
                    case 384:
                        return "Mythril Chainsaw";
                    case 385:
                        return "Cobalt Drill";
                    case 386:
                        return "Mythril Drill";
                    case 387:
                        return "Adamantite Chainsaw";
                    case 388:
                        return "Adamantite Drill";
                    case 389:
                        return "Dao of Pow";
                    case 390:
                        return "Mythril Halberd";
                    case 391:
                        return "Adamantite Bar";
                    case 392:
                        return "Glass Wall";
                    case 393:
                        return "Compass";
                    case 394:
                        return "Diving Gear";
                    case 395:
                        return "GPS";
                    case 396:
                        return "Obsidian Horseshoe";
                    case 397:
                        return "Obsidian Shield";
                    case 398:
                        return "Tinkerer's Workshop";
                    case 399:
                        return "Cloud in a Balloon";
                    case 400:
                        return "Adamantite Headgear";
                    case 401:
                        return "Adamantite Helmet";
                    case 402:
                        return "Adamantite Mask";
                    case 403:
                        return "Adamantite Breastplate";
                    case 404:
                        return "Adamantite Leggings";
                    case 405:
                        return "Spectre Boots";
                    case 406:
                        return "Adamantite Glaive";
                    case 407:
                        return "Toolbelt";
                    case 408:
                        return "Pearlsand Block";
                    case 409:
                        return "Pearlstone Block";
                    case 410:
                        return "Mining Shirt";
                    case 411:
                        return "Mining Pants";
                    case 412:
                        return "Pearlstone Brick";
                    case 413:
                        return "Iridescent Brick";
                    case 414:
                        return "Mudstone Block";
                    case 415:
                        return "Cobalt Brick";
                    case 416:
                        return "Mythril Brick";
                    case 417:
                        return "Pearlstone Brick Wall";
                    case 418:
                        return "Iridescent Brick Wall";
                    case 419:
                        return "Mudstone Brick Wall";
                    case 420:
                        return "Cobalt Brick Wall";
                    case 421:
                        return "Mythril Brick Wall";
                    case 422:
                        return "Holy Water";
                    case 423:
                        return "Unholy Water";
                    case 424:
                        return "Silt Block";
                    case 425:
                        return "Fairy Bell";
                    case 426:
                        return "Breaker Blade";
                    case 427:
                        return "Blue Torch";
                    case 428:
                        return "Red Torch";
                    case 429:
                        return "Green Torch";
                    case 430:
                        return "Purple Torch";
                    case 431:
                        return "White Torch";
                    case 432:
                        return "Yellow Torch";
                    case 433:
                        return "Demon Torch";
                    case 434:
                        return "Clockwork Assault Rifle";
                    case 435:
                        return "Cobalt Repeater";
                    case 436:
                        return "Mythril Repeater";
                    case 437:
                        return "Dual Hook";
                    case 438:
                        return "Star Statue";
                    case 439:
                        return "Sword Statue";
                    case 440:
                        return "Slime Statue";
                    case 441:
                        return "Goblin Statue";
                    case 442:
                        return "Shield Statue";
                    case 443:
                        return "Bat Statue";
                    case 444:
                        return "Fish Statue";
                    case 445:
                        return "Bunny Statue";
                    case 446:
                        return "Skeleton Statue";
                    case 447:
                        return "Reaper Statue";
                    case 448:
                        return "Woman Statue";
                    case 449:
                        return "Imp Statue";
                    case 450:
                        return "Gargoyle Statue";
                    case 451:
                        return "Gloom Statue";
                    case 452:
                        return "Hornet Statue";
                    case 453:
                        return "Bomb Statue";
                    case 454:
                        return "Crab Statue";
                    case 455:
                        return "Hammer Statue";
                    case 456:
                        return "Potion Statue";
                    case 457:
                        return "Spear Statue";
                    case 458:
                        return "Cross Statue";
                    case 459:
                        return "Jellyfish Statue";
                    case 460:
                        return "Bow Statue";
                    case 461:
                        return "Boomerang Statue";
                    case 462:
                        return "Boot Statue";
                    case 463:
                        return "Chest Statue";
                    case 464:
                        return "Bird Statue";
                    case 465:
                        return "Axe Statue";
                    case 466:
                        return "Corrupt Statue";
                    case 467:
                        return "Tree Statue";
                    case 468:
                        return "Anvil Statue";
                    case 469:
                        return "Pickaxe Statue";
                    case 470:
                        return "Mushroom Statue";
                    case 471:
                        return "Eyeball Statue";
                    case 472:
                        return "Pillar Statue";
                    case 473:
                        return "Heart Statue";
                    case 474:
                        return "Pot Statue";
                    case 475:
                        return "Sunflower Statue";
                    case 476:
                        return "King Statue";
                    case 477:
                        return "Queen Statue";
                    case 478:
                        return "Piranha Statue";
                    case 479:
                        return "Planked Wall";
                    case 480:
                        return "Wooden Beam";
                    case 481:
                        return "Adamantite Repeater";
                    case 482:
                        return "Adamantite Sword";
                    case 483:
                        return "Cobalt Sword";
                    case 484:
                        return "Mythril Sword";
                    case 485:
                        return "Moon Charm";
                    case 486:
                        return "Ruler";
                    case 487:
                        return "Crystal Ball";
                    case 488:
                        return "Disco Ball";
                    case 489:
                        return "Sorcerer Emblem";
                    case 490:
                        return "Warrior Emblem";
                    case 491:
                        return "Ranger Emblem";
                    case 492:
                        return "Demon Wings";
                    case 493:
                        return "Angel Wings";
                    case 494:
                        return "Magical Harp";
                    case 495:
                        return "Rainbow Rod";
                    case 496:
                        return "Ice Rod";
                    case 497:
                        return "Neptune's Shell";
                    case 498:
                        return "Mannequin";
                    case 499:
                        return "Greater Healing Potion";
                    case 500:
                        return "Greater Mana Potion";
                    case 501:
                        return "Pixie Dust";
                    case 502:
                        return "Crystal Shard";
                    case 503:
                        return "Clown Hat";
                    case 504:
                        return "Clown Shirt";
                    case 505:
                        return "Clown Pants";
                    case 506:
                        return "Flamethrower";
                    case 507:
                        return "Bell";
                    case 508:
                        return "Harp";
                    case 509:
                        return "Wrench";
                    case 510:
                        return "Wire Cutter";
                    case 511:
                        return "Active Stone Block";
                    case 512:
                        return "Inactive Stone Block";
                    case 513:
                        return "Lever";
                    case 514:
                        return "Laser Rifle";
                    case 515:
                        return "Crystal Bullet";
                    case 516:
                        return "Holy Arrow";
                    case 517:
                        return "Magic Dagger";
                    case 518:
                        return "Crystal Storm";
                    case 519:
                        return "Cursed Flames";
                    case 520:
                        return "Soul of Light";
                    case 521:
                        return "Soul of Night";
                    case 522:
                        return "Cursed Flame";
                    case 523:
                        return "Cursed Torch";
                    case 524:
                        return "Adamantite Forge";
                    case 525:
                        return "Mythril Anvil";
                    case 526:
                        return "Unicorn Horn";
                    case 527:
                        return "Dark Shard";
                    case 528:
                        return "Light Shard";
                    case 529:
                        return "Red Pressure Plate";
                    case 530:
                        return "Wire";
                    case 531:
                        return "Spell Tome";
                    case 532:
                        return "Star Cloak";
                    case 533:
                        return "Megashark";
                    case 534:
                        return "Shotgun";
                    case 535:
                        return "Philosopher's Stone";
                    case 536:
                        return "Titan Glove";
                    case 537:
                        return "Cobalt Naginata";
                    case 538:
                        return "Switch";
                    case 539:
                        return "Dart Trap";
                    case 540:
                        return "Boulder";
                    case 541:
                        return "Green Pressure Plate";
                    case 542:
                        return "Gray Pressure Plate";
                    case 543:
                        return "Brown Pressure Plate";
                    case 544:
                        return "Mechanical Eye";
                    case 545:
                        return "Cursed Arrow";
                    case 546:
                        return "Cursed Bullet";
                    case 547:
                        return "Soul of Fright";
                    case 548:
                        return "Soul of Might";
                    case 549:
                        return "Soul of Sight";
                    case 550:
                        return "Gungnir";
                    case 551:
                        return "Hallowed Plate Mail";
                    case 552:
                        return "Hallowed Greaves";
                    case 553:
                        return "Hallowed Helmet";
                    case 554:
                        return "Cross Necklace";
                    case 555:
                        return "Mana Flower";
                    case 556:
                        return "Mechanical Worm";
                    case 557:
                        return "Mechanical Skull";
                    case 558:
                        return "Hallowed Headgear";
                    case 559:
                        return "Hallowed Mask";
                    case 560:
                        return "Slime Crown";
                    case 561:
                        return "Light Disc";
                    case 562:
                        return "Music Box (Overworld Day)";
                    case 563:
                        return "Music Box (Eerie)";
                    case 564:
                        return "Music Box (Night)";
                    case 565:
                        return "Music Box (Title)";
                    case 566:
                        return "Music Box (Underground)";
                    case 567:
                        return "Music Box (Boss 1)";
                    case 568:
                        return "Music Box (Jungle)";
                    case 569:
                        return "Music Box (Corruption)";
                    case 570:
                        return "Music Box (Underground Corruption)";
                    case 571:
                        return "Music Box (The Hallow)";
                    case 572:
                        return "Music Box (Boss 2)";
                    case 573:
                        return "Music Box (Underground Hallow)";
                    case 574:
                        return "Music Box (Boss 3)";
                    case 575:
                        return "Soul of Flight";
                    case 576:
                        return "Music Box";
                    case 577:
                        return "Demonite Brick";
                    case 578:
                        return "Hallowed Repeater";
                    case 579:
                        return "Drax";
                    case 580:
                        return "Explosives";
                    case 581:
                        return "Inlet Pump";
                    case 582:
                        return "Outlet Pump";
                    case 583:
                        return "1 Second Timer";
                    case 584:
                        return "3 Second Timer";
                    case 585:
                        return "5 Second Timer";
                    case 586:
                        return "Candy Cane Block";
                    case 587:
                        return "Candy Cane Wall";
                    case 588:
                        return "Santa Hat";
                    case 589:
                        return "Santa Shirt";
                    case 590:
                        return "Santa Pants";
                    case 591:
                        return "Green Candy Cane Block";
                    case 592:
                        return "Green Candy Cane Wall";
                    case 593:
                        return "Snow Block";
                    case 594:
                        return "Snow Brick";
                    case 595:
                        return "Snow Brick Wall";
                    case 596:
                        return "Blue Light";
                    case 597:
                        return "Red Light";
                    case 598:
                        return "Green Light";
                    case 599:
                        return "Blue Present";
                    case 600:
                        return "Green Present";
                    case 601:
                        return "Yellow Present";
                    case 602:
                        return "Snow Globe";
                    case 603:
                        return "Carrot";
                    case 604:
                        return "Adamantite Beam";
                    case 605:
                        return "Adamantite Beam Wall";
                    case 606:
                        return "Demonite Brick Wall";
                    case 607:
                        return "Sandstone Brick";
                    case 608:
                        return "Sandstone Brick Wall";
                    case 609:
                        return "Ebonstone Brick";
                    case 610:
                        return "Ebonstone Brick Wall";
                    case 611:
                        return "Red Stucco";
                    case 612:
                        return "Yellow Stucco";
                    case 613:
                        return "Green Stucco";
                    case 614:
                        return "Gray Stucco";
                    case 615:
                        return "Red Stucco Wall";
                    case 616:
                        return "Yellow Stucco Wall";
                    case 617:
                        return "Green Stucco Wall";
                    case 618:
                        return "Gray Stucco Wall";
                    case 619:
                        return "Ebonwood";
                    case 620:
                        return "Rich Mahogany";
                    case 621:
                        return "Pearlwood";
                    case 622:
                        return "Ebonwood Wall";
                    case 623:
                        return "Rich Mahogany Wall";
                    case 624:
                        return "Pearlwood Wall";
                    case 625:
                        return "Ebonwood Chest";
                    case 626:
                        return "Rich Mahogany Chest";
                    case 627:
                        return "Pearlwood Chest";
                    case 628:
                        return "Ebonwood Chair";
                    case 629:
                        return "Rich Mahogany Chair";
                    case 630:
                        return "Pearlwood Chair";
                    case 631:
                        return "Ebonwood Platform";
                    case 632:
                        return "Rich Mahogany Platform";
                    case 633:
                        return "Pearlwood Platform";
                    case 634:
                        return "Bone Platform";
                    case 635:
                        return "Ebonwood Work Bench";
                    case 636:
                        return "Rich Mahogany Work Bench";
                    case 637:
                        return "Pearlwood Work Bench";
                    case 638:
                        return "Ebonwood Table";
                    case 639:
                        return "Rich Mahogany Table";
                    case 640:
                        return "Pearlwood Table";
                    case 641:
                        return "Ebonwood Piano";
                    case 642:
                        return "Rich Mahogany Piano";
                    case 643:
                        return "Pearlwood Piano";
                    case 644:
                        return "Ebonwood Bed";
                    case 645:
                        return "Rich Mahogany Bed";
                    case 646:
                        return "Pearlwood Bed";
                    case 647:
                        return "Ebonwood Dresser";
                    case 648:
                        return "Rich Mahogany Dresser";
                    case 649:
                        return "Pearlwood Dresser";
                    case 650:
                        return "Ebonwood Door";
                    case 651:
                        return "Rich Mahogany Door";
                    case 652:
                        return "Pearlwood Door";
                    case 653:
                        return "Ebonwood Sword";
                    case 654:
                        return "Ebonwood Hammer";
                    case 655:
                        return "Ebonwood Bow";
                    case 656:
                        return "Rich Mahogany Sword";
                    case 657:
                        return "Rich Mahogany Hammer";
                    case 658:
                        return "Rich Mahogany Bow";
                    case 659:
                        return "Pearlwood Sword";
                    case 660:
                        return "Pearlwood Hammer";
                    case 661:
                        return "Pearlwood Bow";
                    case 662:
                        return "Rainbow Brick";
                    case 663:
                        return "Rainbow Brick Wall";
                    case 664:
                        return "Ice Block";
                    case 665:
                        return "Red's Wings";
                    case 666:
                        return "Red's Helmet";
                    case 667:
                        return "Red's Breastplate";
                    case 668:
                        return "Red's Leggings";
                    case 669:
                        return "Fish";
                    case 670:
                        return "Ice Boomerang";
                    case 671:
                        return "Keybrand";
                    case 672:
                        return "Cutlass";
                    case 673:
                        return "Boreal Wood Work Bench";
                    case 674:
                        return "True Excalibur";
                    case 675:
                        return "True Night's Edge";
                    case 676:
                        return "Frostbrand";
                    case 677:
                        return "Boreal Wood Table";
                    case 678:
                        return "Red Potion";
                    case 679:
                        return "Tactical Shotgun";
                    case 680:
                        return "Ivy Chest";
                    case 681:
                        return "Ice Chest";
                    case 682:
                        return "Marrow";
                    case 683:
                        return "Unholy Trident";
                    case 684:
                        return "Frost Helmet";
                    case 685:
                        return "Frost Breastplate";
                    case 686:
                        return "Frost Leggings";
                    case 687:
                        return "Tin Helmet";
                    case 688:
                        return "Tin Chainmail";
                    case 689:
                        return "Tin Greaves";
                    case 690:
                        return "Lead Helmet";
                    case 691:
                        return "Lead Chainmail";
                    case 692:
                        return "Lead Greaves";
                    case 693:
                        return "Tungsten Helmet";
                    case 694:
                        return "Tungsten Chainmail";
                    case 695:
                        return "Tungsten Greaves";
                    case 696:
                        return "Platinum Helmet";
                    case 697:
                        return "Platinum Chainmail";
                    case 698:
                        return "Platinum Greaves";
                    case 699:
                        return "Tin Ore";
                    case 700:
                        return "Lead Ore";
                    case 701:
                        return "Tungsten Ore";
                    case 702:
                        return "Platinum Ore";
                    case 703:
                        return "Tin Bar";
                    case 704:
                        return "Lead Bar";
                    case 705:
                        return "Tungsten Bar";
                    case 706:
                        return "Platinum Bar";
                    case 707:
                        return "Tin Watch";
                    case 708:
                        return "Tungsten Watch";
                    case 709:
                        return "Platinum Watch";
                    case 710:
                        return "Tin Chandelier";
                    case 711:
                        return "Tungsten Chandelier";
                    case 712:
                        return "Platinum Chandelier";
                    case 713:
                        return "Platinum Candle";
                    case 714:
                        return "Platinum Candelabra";
                    case 715:
                        return "Platinum Crown";
                    case 716:
                        return "Lead Anvil";
                    case 717:
                        return "Tin Brick";
                    case 718:
                        return "Tungsten Brick";
                    case 719:
                        return "Platinum Brick";
                    case 720:
                        return "Tin Brick Wall";
                    case 721:
                        return "Tungsten Brick Wall";
                    case 722:
                        return "Platinum Brick Wall";
                    case 723:
                        return "Beam Sword";
                    case 724:
                        return "Ice Blade";
                    case 725:
                        return "Ice Bow";
                    case 726:
                        return "Frost Staff";
                    case 727:
                        return "Wood Helmet";
                    case 728:
                        return "Wood Breastplate";
                    case 729:
                        return "Wood Greaves";
                    case 730:
                        return "Ebonwood Helmet";
                    case 731:
                        return "Ebonwood Breastplate";
                    case 732:
                        return "Ebonwood Greaves";
                    case 733:
                        return "Rich Mahogany Helmet";
                    case 734:
                        return "Rich Mahogany Breastplate";
                    case 735:
                        return "Rich Mahogany Greaves";
                    case 736:
                        return "Pearlwood Helmet";
                    case 737:
                        return "Pearlwood Breastplate";
                    case 738:
                        return "Pearlwood Greaves";
                    case 739:
                        return "Amethyst Staff";
                    case 740:
                        return "Topaz Staff";
                    case 741:
                        return "Sapphire Staff";
                    case 742:
                        return "Emerald Staff";
                    case 743:
                        return "Ruby Staff";
                    case 744:
                        return "Diamond Staff";
                    case 745:
                        return "Grass Wall";
                    case 746:
                        return "Jungle Wall";
                    case 747:
                        return "Flower Wall";
                    case 748:
                        return "Jetpack";
                    case 749:
                        return "Butterfly Wings";
                    case 750:
                        return "Cactus Wall";
                    case 751:
                        return "Cloud";
                    case 752:
                        return "Cloud Wall";
                    case 753:
                        return "Seaweed";
                    case 754:
                        return "Rune Hat";
                    case 755:
                        return "Rune Robe";
                    case 756:
                        return "Mushroom Spear";
                    case 757:
                        return "Terra Blade";
                    case 758:
                        return "Grenade Launcher";
                    case 759:
                        return "Rocket Launcher";
                    case 760:
                        return "Proximity Mine Launcher";
                    case 761:
                        return "Fairy Wings";
                    case 762:
                        return "Slime Block";
                    case 763:
                        return "Flesh Block";
                    case 764:
                        return "Mushroom Wall";
                    case 765:
                        return "Rain Cloud";
                    case 766:
                        return "Bone Block";
                    case 767:
                        return "Frozen Slime Block";
                    case 768:
                        return "Bone Block Wall";
                    case 769:
                        return "Slime Block Wall";
                    case 770:
                        return "Flesh Block Wall";
                    case 771:
                        return "Rocket I";
                    case 772:
                        return "Rocket II";
                    case 773:
                        return "Rocket III";
                    case 774:
                        return "Rocket IV";
                    case 775:
                        return "Asphalt Block";
                    case 776:
                        return "Cobalt Pickaxe";
                    case 777:
                        return "Mythril Pickaxe";
                    case 778:
                        return "Adamantite Pickaxe";
                    case 779:
                        return "Clentaminator";
                    case 780:
                        return "Green Solution";
                    case 781:
                        return "Blue Solution";
                    case 782:
                        return "Purple Solution";
                    case 783:
                        return "Dark Blue Solution";
                    case 784:
                        return "Red Solution";
                    case 785:
                        return "Harpy Wings";
                    case 786:
                        return "Bone Wings";
                    case 787:
                        return "Hammush";
                    case 788:
                        return "Nettle Burst";
                    case 789:
                        return "Ankh Banner";
                    case 790:
                        return "Snake Banner";
                    case 791:
                        return "Omega Banner";
                    case 792:
                        return "Crimson Helmet";
                    case 793:
                        return "Crimson Scalemail";
                    case 794:
                        return "Crimson Greaves";
                    case 795:
                        return "Blood Butcherer";
                    case 796:
                        return "Tendon Bow";
                    case 797:
                        return "Flesh Grinder";
                    case 798:
                        return "Deathbringer Pickaxe";
                    case 799:
                        return "Blood Lust Cluster";
                    case 800:
                        return "The Undertaker";
                    case 801:
                        return "The Meatball";
                    case 802:
                        return "The Rotted Fork";
                    case 803:
                        return "Eskimo Hood";
                    case 804:
                        return "Eskimo Coat";
                    case 805:
                        return "Eskimo Pants";
                    case 806:
                        return "Living Wood Chair";
                    case 807:
                        return "Cactus Chair";
                    case 808:
                        return "Bone Chair";
                    case 809:
                        return "Flesh Chair";
                    case 810:
                        return "Mushroom Chair";
                    case 811:
                        return "Bone Work Bench";
                    case 812:
                        return "Cactus Work Bench";
                    case 813:
                        return "Flesh Work Bench";
                    case 814:
                        return "Mushroom Work Bench";
                    case 815:
                        return "Slime Work Bench";
                    case 816:
                        return "Cactus Door";
                    case 817:
                        return "Flesh Door";
                    case 818:
                        return "Mushroom Door";
                    case 819:
                        return "Living Wood Door";
                    case 820:
                        return "Bone Door";
                    case 821:
                        return "Flame Wings";
                    case 822:
                        return "Frozen Wings";
                    case 823:
                        return "Spectre Wings";
                    case 824:
                        return "Sunplate Block";
                    case 825:
                        return "Disc Wall";
                    case 826:
                        return "Skyware Chair";
                    case 827:
                        return "Bone Table";
                    case 828:
                        return "Flesh Table";
                    case 829:
                        return "Living Wood Table";
                    case 830:
                        return "Skyware Table";
                    case 831:
                        return "Living Wood Chest";
                    case 832:
                        return "Living Wood Wand";
                    case 833:
                        return "Purple Ice Block";
                    case 834:
                        return "Pink Ice Block";
                    case 835:
                        return "Red Ice Block";
                    case 836:
                        return "Crimstone Block";
                    case 837:
                        return "Skyware Door";
                    case 838:
                        return "Skyware Chest";
                    case 839:
                        return "Steampunk Hat";
                    case 840:
                        return "Steampunk Shirt";
                    case 841:
                        return "Steampunk Pants";
                    case 842:
                        return "Bee Hat";
                    case 843:
                        return "Bee Shirt";
                    case 844:
                        return "Bee Pants";
                    case 845:
                        return "World Banner";
                    case 846:
                        return "Sun Banner";
                    case 847:
                        return "Gravity Banner";
                    case 848:
                        return "Pharaoh's Mask";
                    case 849:
                        return "Actuator";
                    case 850:
                        return "Blue Wrench";
                    case 851:
                        return "Green Wrench";
                    case 852:
                        return "Blue Pressure Plate";
                    case 853:
                        return "Yellow Pressure Plate";
                    case 854:
                        return "Discount Card";
                    case 855:
                        return "Lucky Coin";
                    case 856:
                        return "Unicorn on a Stick";
                    case 857:
                        return "Sandstorm in a Bottle";
                    case 858:
                        return "Boreal Wood Sofa";
                    case 859:
                        return "Beach Ball";
                    case 860:
                        return "Charm of Myths";
                    case 861:
                        return "Moon Shell";
                    case 862:
                        return "Star Veil";
                    case 863:
                        return "Water Walking Boots";
                    case 864:
                        return "Tiara";
                    case 865:
                        return "Princess Dress";
                    case 866:
                        return "Pharaoh's Robe";
                    case 867:
                        return "Green Cap";
                    case 868:
                        return "Mushroom Cap";
                    case 869:
                        return "Tam O' Shanter";
                    case 870:
                        return "Mummy Mask";
                    case 871:
                        return "Mummy Shirt";
                    case 872:
                        return "Mummy Pants";
                    case 873:
                        return "Cowboy Hat";
                    case 874:
                        return "Cowboy Jacket";
                    case 875:
                        return "Cowboy Pants";
                    case 876:
                        return "Pirate Hat";
                    case 877:
                        return "Pirate Shirt";
                    case 878:
                        return "Pirate Pants";
                    case 879:
                        return "Viking Helmet";
                    case 880:
                        return "Crimtane Ore";
                    case 881:
                        return "Cactus Sword";
                    case 882:
                        return "Cactus Pickaxe";
                    case 883:
                        return "Ice Brick";
                    case 884:
                        return "Ice Brick Wall";
                    case 885:
                        return "Adhesive Bandage";
                    case 886:
                        return "Armor Polish";
                    case 887:
                        return "Bezoar";
                    case 888:
                        return "Blindfold";
                    case 889:
                        return "Fast Clock";
                    case 890:
                        return "Megaphone";
                    case 891:
                        return "Nazar";
                    case 892:
                        return "Vitamins";
                    case 893:
                        return "Trifold Map";
                    case 894:
                        return "Cactus Helmet";
                    case 895:
                        return "Cactus Breastplate";
                    case 896:
                        return "Cactus Leggings";
                    case 897:
                        return "Power Glove";
                    case 898:
                        return "Lightning Boots";
                    case 899:
                        return "Sun Stone";
                    case 900:
                        return "Moon Stone";
                    case 901:
                        return "Armor Bracing";
                    case 902:
                        return "Medicated Bandage";
                    case 903:
                        return "The Plan";
                    case 904:
                        return "Countercurse Mantra";
                    case 905:
                        return "Coin Gun";
                    case 906:
                        return "Lava Charm";
                    case 907:
                        return "Obsidian Water Walking Boots";
                    case 908:
                        return "Lava Waders";
                    case 909:
                        return "Pure Water Fountain";
                    case 910:
                        return "Desert Water Fountain";
                    case 911:
                        return "Shadewood";
                    case 912:
                        return "Shadewood Door";
                    case 913:
                        return "Shadewood Platform";
                    case 914:
                        return "Shadewood Chest";
                    case 915:
                        return "Shadewood Chair";
                    case 916:
                        return "Shadewood Work Bench";
                    case 917:
                        return "Shadewood Table";
                    case 918:
                        return "Shadewood Dresser";
                    case 919:
                        return "Shadewood Piano";
                    case 920:
                        return "Shadewood Bed";
                    case 921:
                        return "Shadewood Sword";
                    case 922:
                        return "Shadewood Hammer";
                    case 923:
                        return "Shadewood Bow";
                    case 924:
                        return "Shadewood Helmet";
                    case 925:
                        return "Shadewood Breastplate";
                    case 926:
                        return "Shadewood Greaves";
                    case 927:
                        return "Shadewood Wall";
                    case 928:
                        return "Cannon";
                    case 929:
                        return "Cannonball";
                    case 930:
                        return "Flare Gun";
                    case 931:
                        return "Flare";
                    case 932:
                        return "Bone Wand";
                    case 933:
                        return "Leaf Wand";
                    case 934:
                        return "Flying Carpet";
                    case 935:
                        return "Avenger Emblem";
                    case 936:
                        return "Mechanical Glove";
                    case 937:
                        return "Land Mine";
                    case 938:
                        return "Paladin's Shield";
                    case 939:
                        return "Web Slinger";
                    case 940:
                        return "Jungle Water Fountain";
                    case 941:
                        return "Icy Water Fountain";
                    case 942:
                        return "Corrupt Water Fountain";
                    case 943:
                        return "Crimson Water Fountain";
                    case 944:
                        return "Hallowed Water Fountain";
                    case 945:
                        return "Blood Water Fountain";
                    case 946:
                        return "Umbrella";
                    case 947:
                        return "Chlorophyte Ore";
                    case 948:
                        return "Steampunk Wings";
                    case 949:
                        return "Snowball";
                    case 950:
                        return "Ice Skates";
                    case 951:
                        return "Snowball Launcher";
                    case 952:
                        return "Web Covered Chest";
                    case 953:
                        return "Climbing Claws";
                    case 954:
                        return "Ancient Iron Helmet";
                    case 955:
                        return "Ancient Gold Helmet";
                    case 956:
                        return "Ancient Shadow Helmet";
                    case 957:
                        return "Ancient Shadow Scalemail";
                    case 958:
                        return "Ancient Shadow Greaves";
                    case 959:
                        return "Ancient Necro Helmet";
                    case 960:
                        return "Ancient Cobalt Helmet";
                    case 961:
                        return "Ancient Cobalt Breastplate";
                    case 962:
                        return "Ancient Cobalt Leggings";
                    case 963:
                        return "Black Belt";
                    case 964:
                        return "Boomstick";
                    case 965:
                        return "Rope";
                    case 966:
                        return "Campfire";
                    case 967:
                        return "Marshmallow";
                    case 968:
                        return "Marshmallow on a Stick";
                    case 969:
                        return "Cooked Marshmallow";
                    case 970:
                        return "Red Rocket";
                    case 971:
                        return "Green Rocket";
                    case 972:
                        return "Blue Rocket";
                    case 973:
                        return "Yellow Rocket";
                    case 974:
                        return "Ice Torch";
                    case 975:
                        return "Shoe Spikes";
                    case 976:
                        return "Tiger Climbing Gear";
                    case 977:
                        return "Tabi";
                    case 978:
                        return "Pink Eskimo Hood";
                    case 979:
                        return "Pink Eskimo Coat";
                    case 980:
                        return "Pink Eskimo Pants";
                    case 981:
                        return "Pink Thread";
                    case 982:
                        return "Mana Regeneration Band";
                    case 983:
                        return "Sandstorm in a Balloon";
                    case 984:
                        return "Master Ninja Gear";
                    case 985:
                        return "Rope Coil";
                    case 986:
                        return "Blowgun";
                    case 987:
                        return "Blizzard in a Bottle";
                    case 988:
                        return "Frostburn Arrow";
                    case 989:
                        return "Enchanted Sword";
                    case 990:
                        return "Pickaxe Axe";
                    case 991:
                        return "Cobalt Waraxe";
                    case 992:
                        return "Mythril Waraxe";
                    case 993:
                        return "Adamantite Waraxe";
                    case 994:
                        return "Eater's Bone";
                    case 995:
                        return "Blend-O-Matic";
                    case 996:
                        return "Meat Grinder";
                    case 997:
                        return "Extractinator";
                    case 998:
                        return "Solidifier";
                    case 999:
                        return "Amber";
                    case 1000:
                        return "Confetti Gun";
                    case 1001:
                        return "Chlorophyte Mask";
                    case 1002:
                        return "Chlorophyte Helmet";
                    case 1003:
                        return "Chlorophyte Headgear";
                    case 1004:
                        return "Chlorophyte Plate Mail";
                    case 1005:
                        return "Chlorophyte Greaves";
                    case 1006:
                        return "Chlorophyte Bar";
                    case 1007:
                        return "Red Dye";
                    case 1008:
                        return "Orange Dye";
                    case 1009:
                        return "Yellow Dye";
                    case 1010:
                        return "Lime Dye";
                    case 1011:
                        return "Green Dye";
                    case 1012:
                        return "Teal Dye";
                    case 1013:
                        return "Cyan Dye";
                    case 1014:
                        return "Sky Blue Dye";
                    case 1015:
                        return "Blue Dye";
                    case 1016:
                        return "Purple Dye";
                    case 1017:
                        return "Violet Dye";
                    case 1018:
                        return "Pink Dye";
                    case 1019:
                        return "Red and Black Dye";
                    case 1020:
                        return "Orange and Black Dye";
                    case 1021:
                        return "Yellow and Black Dye";
                    case 1022:
                        return "Lime and Black Dye";
                    case 1023:
                        return "Green and Black Dye";
                    case 1024:
                        return "Teal and Black Dye";
                    case 1025:
                        return "Cyan and Black Dye";
                    case 1026:
                        return "Sky Blue and Black Dye";
                    case 1027:
                        return "Blue and Black Dye";
                    case 1028:
                        return "Purple and Black Dye";
                    case 1029:
                        return "Violet and Black Dye";
                    case 1030:
                        return "Pink and Black Dye";
                    case 1031:
                        return "Flame Dye";
                    case 1032:
                        return "Flame and Black Dye";
                    case 1033:
                        return "Green Flame Dye";
                    case 1034:
                        return "Green Flame and Black Dye";
                    case 1035:
                        return "Blue Flame Dye";
                    case 1036:
                        return "Blue Flame and Black Dye";
                    case 1037:
                        return "Silver Dye";
                    case 1038:
                        return "Bright Red Dye";
                    case 1039:
                        return "Bright Orange Dye";
                    case 1040:
                        return "Bright Yellow Dye";
                    case 1041:
                        return "Bright Lime Dye";
                    case 1042:
                        return "Bright Green Dye";
                    case 1043:
                        return "Bright Teal Dye";
                    case 1044:
                        return "Bright Cyan Dye";
                    case 1045:
                        return "Bright Sky Blue Dye";
                    case 1046:
                        return "Bright Blue Dye";
                    case 1047:
                        return "Bright Purple Dye";
                    case 1048:
                        return "Bright Violet Dye";
                    case 1049:
                        return "Bright Pink Dye";
                    case 1050:
                        return "Black Dye";
                    case 1051:
                        return "Red and Silver Dye";
                    case 1052:
                        return "Orange and Silver Dye";
                    case 1053:
                        return "Yellow and Silver Dye";
                    case 1054:
                        return "Lime and Silver Dye";
                    case 1055:
                        return "Green and Silver Dye";
                    case 1056:
                        return "Teal and Silver Dye";
                    case 1057:
                        return "Cyan and Silver Dye";
                    case 1058:
                        return "Sky Blue and Silver Dye";
                    case 1059:
                        return "Blue and Silver Dye";
                    case 1060:
                        return "Purple and Silver Dye";
                    case 1061:
                        return "Violet and Silver Dye";
                    case 1062:
                        return "Pink and Silver Dye";
                    case 1063:
                        return "Intense Flame Dye";
                    case 1064:
                        return "Intense Green Flame Dye";
                    case 1065:
                        return "Intense Blue Flame Dye";
                    case 1066:
                        return "Rainbow Dye";
                    case 1067:
                        return "Intense Rainbow Dye";
                    case 1068:
                        return "Yellow Gradient Dye";
                    case 1069:
                        return "Cyan Gradient Dye";
                    case 1070:
                        return "Violet Gradient Dye";
                    case 1071:
                        return "Paintbrush";
                    case 1072:
                        return "Paint Roller";
                    case 1073:
                        return "Red Paint";
                    case 1074:
                        return "Orange Paint";
                    case 1075:
                        return "Yellow Paint";
                    case 1076:
                        return "Lime Paint";
                    case 1077:
                        return "Green Paint";
                    case 1078:
                        return "Teal Paint";
                    case 1079:
                        return "Cyan Paint";
                    case 1080:
                        return "Sky Blue Paint";
                    case 1081:
                        return "Blue Paint";
                    case 1082:
                        return "Purple Paint";
                    case 1083:
                        return "Violet Paint";
                    case 1084:
                        return "Pink Paint";
                    case 1085:
                        return "Deep Red Paint";
                    case 1086:
                        return "Deep Orange Paint";
                    case 1087:
                        return "Deep Yellow Paint";
                    case 1088:
                        return "Deep Lime Paint";
                    case 1089:
                        return "Deep Green Paint";
                    case 1090:
                        return "Deep Teal Paint";
                    case 1091:
                        return "Deep Cyan Paint";
                    case 1092:
                        return "Deep Sky Blue Paint";
                    case 1093:
                        return "Deep Blue Paint";
                    case 1094:
                        return "Deep Purple Paint";
                    case 1095:
                        return "Deep Violet Paint";
                    case 1096:
                        return "Deep Pink Paint";
                    case 1097:
                        return "Black Paint";
                    case 1098:
                        return "White Paint";
                    case 1099:
                        return "Gray Paint";
                    case 1100:
                        return "Paint Scraper";
                    case 1101:
                        return "Lihzahrd Brick";
                    case 1102:
                        return "Lihzahrd Brick Wall";
                    case 1103:
                        return "Slush Block";
                    case 1104:
                        return "Palladium Ore";
                    case 1105:
                        return "Orichalcum Ore";
                    case 1106:
                        return "Titanium Ore";
                    case 1107:
                        return "Teal Mushroom";
                    case 1108:
                        return "Green Mushroom";
                    case 1109:
                        return "Sky Blue Flower";
                    case 1110:
                        return "Yellow Marigold";
                    case 1111:
                        return "Blue Berries";
                    case 1112:
                        return "Lime Kelp";
                    case 1113:
                        return "Pink Prickly Pear";
                    case 1114:
                        return "Orange Bloodroot";
                    case 1115:
                        return "Red Husk";
                    case 1116:
                        return "Cyan Husk";
                    case 1117:
                        return "Violet Husk";
                    case 1118:
                        return "Purple Mucos";
                    case 1119:
                        return "Black Ink";
                    case 1120:
                        return "Dye Vat";
                    case 1121:
                        return "Bee Gun";
                    case 1122:
                        return "Possessed Hatchet";
                    case 1123:
                        return "Bee Keeper";
                    case 1124:
                        return "Hive";
                    case 1125:
                        return "Honey Block";
                    case 1126:
                        return "Hive Wall";
                    case 1127:
                        return "Crispy Honey Block";
                    case 1128:
                        return "Honey Bucket";
                    case 1129:
                        return "Hive Wand";
                    case 1130:
                        return "Beenade";
                    case 1131:
                        return "Gravity Globe";
                    case 1132:
                        return "Honey Comb";
                    case 1133:
                        return "Abeemination";
                    case 1134:
                        return "Bottled Honey";
                    case 1135:
                        return "Rain Hat";
                    case 1136:
                        return "Rain Coat";
                    case 1137:
                        return "Lihzahrd Door";
                    case 1138:
                        return "Dungeon Door";
                    case 1139:
                        return "Lead Door";
                    case 1140:
                        return "Iron Door";
                    case 1141:
                        return "Temple Key";
                    case 1142:
                        return "Lihzahrd Chest";
                    case 1143:
                        return "Lihzahrd Chair";
                    case 1144:
                        return "Lihzahrd Table";
                    case 1145:
                        return "Lihzahrd Work Bench";
                    case 1146:
                        return "Super Dart Trap";
                    case 1147:
                        return "Flame Trap";
                    case 1148:
                        return "Spiky Ball Trap";
                    case 1149:
                        return "Spear Trap";
                    case 1150:
                        return "Wooden Spike";
                    case 1151:
                        return "Lihzahrd Pressure Plate";
                    case 1152:
                        return "Lihzahrd Statue";
                    case 1153:
                        return "Lihzahrd Watcher Statue";
                    case 1154:
                        return "Lihzahrd Guardian Statue";
                    case 1155:
                        return "Wasp Gun";
                    case 1156:
                        return "Piranha Gun";
                    case 1157:
                        return "Pygmy Staff";
                    case 1158:
                        return "Pygmy Necklace";
                    case 1159:
                        return "Tiki Mask";
                    case 1160:
                        return "Tiki Shirt";
                    case 1161:
                        return "Tiki Pants";
                    case 1162:
                        return "Leaf Wings";
                    case 1163:
                        return "Blizzard in a Balloon";
                    case 1164:
                        return "Bundle of Balloons";
                    case 1165:
                        return "Bat Wings";
                    case 1166:
                        return "Bone Sword";
                    case 1167:
                        return "Hercules Beetle";
                    case 1168:
                        return "Smoke Bomb";
                    case 1169:
                        return "Bone Key";
                    case 1170:
                        return "Nectar";
                    case 1171:
                        return "Tiki Totem";
                    case 1172:
                        return "Lizard Egg";
                    case 1173:
                        return "Grave Marker";
                    case 1174:
                        return "Cross Grave Marker";
                    case 1175:
                        return "Headstone";
                    case 1176:
                        return "Gravestone";
                    case 1177:
                        return "Obelisk";
                    case 1178:
                        return "Leaf Blower";
                    case 1179:
                        return "Chlorophyte Bullet";
                    case 1180:
                        return "Parrot Cracker";
                    case 1181:
                        return "Strange Glowing Mushroom";
                    case 1182:
                        return "Seedling";
                    case 1183:
                        return "Wisp in a Bottle";
                    case 1184:
                        return "Palladium Bar";
                    case 1185:
                        return "Palladium Sword";
                    case 1186:
                        return "Palladium Pike";
                    case 1187:
                        return "Palladium Repeater";
                    case 1188:
                        return "Palladium Pickaxe";
                    case 1189:
                        return "Palladium Drill";
                    case 1190:
                        return "Palladium Chainsaw";
                    case 1191:
                        return "Orichalcum Bar";
                    case 1192:
                        return "Orichalcum Sword";
                    case 1193:
                        return "Orichalcum Halberd";
                    case 1194:
                        return "Orichalcum Repeater";
                    case 1195:
                        return "Orichalcum Pickaxe";
                    case 1196:
                        return "Orichalcum Drill";
                    case 1197:
                        return "Orichalcum Chainsaw";
                    case 1198:
                        return "Titanium Bar";
                    case 1199:
                        return "Titanium Sword";
                    case 1200:
                        return "Titanium Trident";
                    case 1201:
                        return "Titanium Repeater";
                    case 1202:
                        return "Titanium Pickaxe";
                    case 1203:
                        return "Titanium Drill";
                    case 1204:
                        return "Titanium Chainsaw";
                    case 1205:
                        return "Palladium Mask";
                    case 1206:
                        return "Palladium Helmet";
                    case 1207:
                        return "Palladium Headgear";
                    case 1208:
                        return "Palladium Breastplate";
                    case 1209:
                        return "Palladium Leggings";
                    case 1210:
                        return "Orichalcum Mask";
                    case 1211:
                        return "Orichalcum Helmet";
                    case 1212:
                        return "Orichalcum Headgear";
                    case 1213:
                        return "Orichalcum Breastplate";
                    case 1214:
                        return "Orichalcum Leggings";
                    case 1215:
                        return "Titanium Mask";
                    case 1216:
                        return "Titanium Helmet";
                    case 1217:
                        return "Titanium Headgear";
                    case 1218:
                        return "Titanium Breastplate";
                    case 1219:
                        return "Titanium Leggings";
                    case 1220:
                        return "Orichalcum Anvil";
                    case 1221:
                        return "Titanium Forge";
                    case 1222:
                        return "Palladium Waraxe";
                    case 1223:
                        return "Orichalcum Waraxe";
                    case 1224:
                        return "Titanium Waraxe";
                    case 1225:
                        return "Hallowed Bar";
                    case 1226:
                        return "Chlorophyte Claymore";
                    case 1227:
                        return "Chlorophyte Saber";
                    case 1228:
                        return "Chlorophyte Partisan";
                    case 1229:
                        return "Chlorophyte Shotbow";
                    case 1230:
                        return "Chlorophyte Pickaxe";
                    case 1231:
                        return "Chlorophyte Drill";
                    case 1232:
                        return "Chlorophyte Chainsaw";
                    case 1233:
                        return "Chlorophyte Greataxe";
                    case 1234:
                        return "Chlorophyte Warhammer";
                    case 1235:
                        return "Chlorophyte Arrow";
                    case 1236:
                        return "Amethyst Hook";
                    case 1237:
                        return "Topaz Hook";
                    case 1238:
                        return "Sapphire Hook";
                    case 1239:
                        return "Emerald Hook";
                    case 1240:
                        return "Ruby Hook";
                    case 1241:
                        return "Diamond Hook";
                    case 1242:
                        return "Amber Mosquito";
                    case 1243:
                        return "Umbrella Hat";
                    case 1244:
                        return "Nimbus Rod";
                    case 1245:
                        return "Orange Torch";
                    case 1246:
                        return "Crimsand Block";
                    case 1247:
                        return "Bee Cloak";
                    case 1248:
                        return "Eye of the Golem";
                    case 1249:
                        return "Honey Balloon";
                    case 1250:
                        return "Blue Horseshoe Balloon";
                    case 1251:
                        return "White Horseshoe Balloon";
                    case 1252:
                        return "Yellow Horseshoe Balloon";
                    case 1253:
                        return "Frozen Turtle Shell";
                    case 1254:
                        return "Sniper Rifle";
                    case 1255:
                        return "Venus Magnum";
                    case 1256:
                        return "Crimson Rod";
                    case 1257:
                        return "Crimtane Bar";
                    case 1258:
                        return "Stynger";
                    case 1259:
                        return "Flower Pow";
                    case 1260:
                        return "Rainbow Gun";
                    case 1261:
                        return "Stynger Bolt";
                    case 1262:
                        return "Chlorophyte Jackhammer";
                    case 1263:
                        return "Teleporter";
                    case 1264:
                        return "Flower of Frost";
                    case 1265:
                        return "Uzi";
                    case 1266:
                        return "Magnet Sphere";
                    case 1267:
                        return "Purple Stained Glass";
                    case 1268:
                        return "Yellow Stained Glass";
                    case 1269:
                        return "Blue Stained Glass";
                    case 1270:
                        return "Green Stained Glass";
                    case 1271:
                        return "Red Stained Glass";
                    case 1272:
                        return "Multicolored Stained Glass";
                    case 1273:
                        return "Skeletron Hand";
                    case 1274:
                        return "Skull";
                    case 1275:
                        return "Balla Hat";
                    case 1276:
                        return "Gangsta Hat";
                    case 1277:
                        return "Sailor Hat";
                    case 1278:
                        return "Eye Patch";
                    case 1279:
                        return "Sailor Shirt";
                    case 1280:
                        return "Sailor Pants";
                    case 1281:
                        return "Skeletron Mask";
                    case 1282:
                        return "Amethyst Robe";
                    case 1283:
                        return "Topaz Robe";
                    case 1284:
                        return "Sapphire Robe";
                    case 1285:
                        return "Emerald Robe";
                    case 1286:
                        return "Ruby Robe";
                    case 1287:
                        return "Diamond Robe";
                    case 1288:
                        return "White Tuxedo Shirt";
                    case 1289:
                        return "White Tuxedo Pants";
                    case 1290:
                        return "Panic Necklace";
                    case 1291:
                        return "Life Fruit";
                    case 1292:
                        return "Lihzahrd Altar";
                    case 1293:
                        return "Lihzahrd Power Cell";
                    case 1294:
                        return "Picksaw";
                    case 1295:
                        return "Heat Ray";
                    case 1296:
                        return "Staff of Earth";
                    case 1297:
                        return "Golem Fist";
                    case 1298:
                        return "Water Chest";
                    case 1299:
                        return "Binoculars";
                    case 1300:
                        return "Rifle Scope";
                    case 1301:
                        return "Destroyer Emblem";
                    case 1302:
                        return "High Velocity Bullet";
                    case 1303:
                        return "Jellyfish Necklace";
                    case 1304:
                        return "Zombie Arm";
                    case 1305:
                        return "The Axe";
                    case 1306:
                        return "Ice Sickle";
                    case 1307:
                        return "Clothier Voodoo Doll";
                    case 1308:
                        return "Poison Staff";
                    case 1309:
                        return "Slime Staff";
                    case 1310:
                        return "Poison Dart";
                    case 1311:
                        return "Eye Spring";
                    case 1312:
                        return "Toy Sled";
                    case 1313:
                        return "Book of Skulls";
                    case 1314:
                        return "KO Cannon";
                    case 1315:
                        return "Pirate Map";
                    case 1316:
                        return "Turtle Helmet";
                    case 1317:
                        return "Turtle Scale Mail";
                    case 1318:
                        return "Turtle Leggings";
                    case 1319:
                        return "Snowball Cannon";
                    case 1320:
                        return "Bone Pickaxe";
                    case 1321:
                        return "Magic Quiver";
                    case 1322:
                        return "Magma Stone";
                    case 1323:
                        return "Obsidian Rose";
                    case 1324:
                        return "Bananarang";
                    case 1325:
                        return "Chain Knife";
                    case 1326:
                        return "Rod of Discord";
                    case 1327:
                        return "Death Sickle";
                    case 1328:
                        return "Turtle Shell";
                    case 1329:
                        return "Tissue Sample";
                    case 1330:
                        return "Vertebrae";
                    case 1331:
                        return "Bloody Spine";
                    case 1332:
                        return "Ichor";
                    case 1333:
                        return "Ichor Torch";
                    case 1334:
                        return "Ichor Arrow";
                    case 1335:
                        return "Ichor Bullet";
                    case 1336:
                        return "Golden Shower";
                    case 1337:
                        return "Bunny Cannon";
                    case 1338:
                        return "Explosive Bunny";
                    case 1339:
                        return "Vial of Venom";
                    case 1340:
                        return "Flask of Venom";
                    case 1341:
                        return "Venom Arrow";
                    case 1342:
                        return "Venom Bullet";
                    case 1343:
                        return "Fire Gauntlet";
                    case 1344:
                        return "Cog";
                    case 1345:
                        return "Confetti";
                    case 1346:
                        return "Nanites";
                    case 1347:
                        return "Explosive Powder";
                    case 1348:
                        return "Gold Dust";
                    case 1349:
                        return "Party Bullet";
                    case 1350:
                        return "Nano Bullet";
                    case 1351:
                        return "Exploding Bullet";
                    case 1352:
                        return "Golden Bullet";
                    case 1353:
                        return "Flask of Cursed Flames";
                    case 1354:
                        return "Flask of Fire";
                    case 1355:
                        return "Flask of Gold";
                    case 1356:
                        return "Flask of Ichor";
                    case 1357:
                        return "Flask of Nanites";
                    case 1358:
                        return "Flask of Party";
                    case 1359:
                        return "Flask of Poison";
                    case 1360:
                        return "Eye of Cthulhu Trophy";
                    case 1361:
                        return "Eater of Worlds Trophy";
                    case 1362:
                        return "Brain of Cthulhu Trophy";
                    case 1363:
                        return "Skeletron Trophy";
                    case 1364:
                        return "Queen Bee Trophy";
                    case 1365:
                        return "Wall of Flesh Trophy";
                    case 1366:
                        return "Destroyer Trophy";
                    case 1367:
                        return "Skeletron Prime Trophy";
                    case 1368:
                        return "Retinazer Trophy";
                    case 1369:
                        return "Spazmatism Trophy";
                    case 1370:
                        return "Plantera Trophy";
                    case 1371:
                        return "Golem Trophy";
                    case 1372:
                        return "Blood Moon Rising";
                    case 1373:
                        return "The Hanged Man";
                    case 1374:
                        return "Glory of the Fire";
                    case 1375:
                        return "Bone Warp";
                    case 1376:
                        return "Wall Skeleton";
                    case 1377:
                        return "Hanging Skeleton";
                    case 1378:
                        return "Blue Slab Wall";
                    case 1379:
                        return "Blue Tiled Wall";
                    case 1380:
                        return "Pink Slab Wall";
                    case 1381:
                        return "Pink Tiled Wall";
                    case 1382:
                        return "Green Slab Wall";
                    case 1383:
                        return "Green Tiled Wall";
                    case 1384:
                        return "Blue Brick Platform";
                    case 1385:
                        return "Pink Brick Platform";
                    case 1386:
                        return "Green Brick Platform";
                    case 1387:
                        return "Metal Shelf";
                    case 1388:
                        return "Brass Shelf";
                    case 1389:
                        return "Wood Shelf";
                    case 1390:
                        return "Brass Lantern";
                    case 1391:
                        return "Caged Lantern";
                    case 1392:
                        return "Carriage Lantern";
                    case 1393:
                        return "Alchemy Lantern";
                    case 1394:
                        return "Diabolist Lamp";
                    case 1395:
                        return "Oil Rag Sconse";
                    case 1396:
                        return "Blue Dungeon Chair";
                    case 1397:
                        return "Blue Dungeon Table";
                    case 1398:
                        return "Blue Dungeon Work Bench";
                    case 1399:
                        return "Green Dungeon Chair";
                    case 1400:
                        return "Green Dungeon Table";
                    case 1401:
                        return "Green Dungeon Work Bench";
                    case 1402:
                        return "Pink Dungeon Chair";
                    case 1403:
                        return "Pink Dungeon Table";
                    case 1404:
                        return "Pink Dungeon Work Bench";
                    case 1405:
                        return "Blue Dungeon Candle";
                    case 1406:
                        return "Green Dungeon Candle";
                    case 1407:
                        return "Pink Dungeon Candle";
                    case 1408:
                        return "Blue Dungeon Vase";
                    case 1409:
                        return "Green Dungeon Vase";
                    case 1410:
                        return "Pink Dungeon Vase";
                    case 1411:
                        return "Blue Dungeon Door";
                    case 1412:
                        return "Green Dungeon Door";
                    case 1413:
                        return "Pink Dungeon Door";
                    case 1414:
                        return "Blue Dungeon Bookcase";
                    case 1415:
                        return "Green Dungeon Bookcase";
                    case 1416:
                        return "Pink Dungeon Bookcase";
                    case 1417:
                        return "Catacomb";
                    case 1418:
                        return "Dungeon Shelf";
                    case 1419:
                        return "Skellington J Skellingsworth";
                    case 1420:
                        return "The Cursed Man";
                    case 1421:
                        return "The Eye Sees the End";
                    case 1422:
                        return "Something Evil is Watching You";
                    case 1423:
                        return "The Twins Have Awoken";
                    case 1424:
                        return "The Screamer";
                    case 1425:
                        return "Goblins Playing Poker";
                    case 1426:
                        return "Dryadisque";
                    case 1427:
                        return "Sunflowers";
                    case 1428:
                        return "Terrarian Gothic";
                    case 1429:
                        return "Beanie";
                    case 1430:
                        return "Imbuing Station";
                    case 1431:
                        return "Star in a Bottle";
                    case 1432:
                        return "Empty Bullet";
                    case 1433:
                        return "Impact";
                    case 1434:
                        return "Powered by Birds";
                    case 1435:
                        return "The Destroyer";
                    case 1436:
                        return "The Persistency of Eyes";
                    case 1437:
                        return "Unicorn Crossing the Hallows";
                    case 1438:
                        return "Great Wave";
                    case 1439:
                        return "Starry Night";
                    case 1440:
                        return "Guide Picasso";
                    case 1441:
                        return "The Guardian's Gaze";
                    case 1442:
                        return "Father of Someone";
                    case 1443:
                        return "Nurse Lisa";
                    case 1444:
                        return "Shadowbeam Staff";
                    case 1445:
                        return "Inferno Fork";
                    case 1446:
                        return "Spectre Staff";
                    case 1447:
                        return "Wooden Fence";
                    case 1448:
                        return "Lead Fence";
                    case 1449:
                        return "Bubble Machine";
                    case 1450:
                        return "Bubble Wand";
                    case 1451:
                        return "Marching Bones Banner";
                    case 1452:
                        return "Necromantic Sign";
                    case 1453:
                        return "Rusted Company Standard";
                    case 1454:
                        return "Ragged Brotherhood Sigil";
                    case 1455:
                        return "Molten Legion Flag";
                    case 1456:
                        return "Diabolic Sigil";
                    case 1457:
                        return "Obsidian Platform";
                    case 1458:
                        return "Obsidian Door";
                    case 1459:
                        return "Obsidian Chair";
                    case 1460:
                        return "Obsidian Table";
                    case 1461:
                        return "Obsidian Work Bench";
                    case 1462:
                        return "Obsidian Vase";
                    case 1463:
                        return "Obsidian Bookcase";
                    case 1464:
                        return "Hellbound Banner";
                    case 1465:
                        return "Hell Hammer Banner";
                    case 1466:
                        return "Helltower Banner";
                    case 1467:
                        return "Lost Hopes of Man Banner";
                    case 1468:
                        return "Obsidian Watcher Banner";
                    case 1469:
                        return "Lava Erupts Banner";
                    case 1470:
                        return "Blue Dungeon Bed";
                    case 1471:
                        return "Green Dungeon Bed";
                    case 1472:
                        return "Pink Dungeon Bed";
                    case 1473:
                        return "Obsidian Bed";
                    case 1474:
                        return "Waldo";
                    case 1475:
                        return "Darkness";
                    case 1476:
                        return "Dark Soul Reaper";
                    case 1477:
                        return "Land";
                    case 1478:
                        return "Trapped Ghost";
                    case 1479:
                        return "Demon's Eye";
                    case 1480:
                        return "Finding Gold";
                    case 1481:
                        return "First Encounter";
                    case 1482:
                        return "Good Morning";
                    case 1483:
                        return "Underground Reward";
                    case 1484:
                        return "Through the Window";
                    case 1485:
                        return "Place Above the Clouds";
                    case 1486:
                        return "Do Not Step on the Grass";
                    case 1487:
                        return "Cold Waters in the White Land";
                    case 1488:
                        return "Lightless Chasms";
                    case 1489:
                        return "The Land of Deceiving Looks";
                    case 1490:
                        return "Daylight";
                    case 1491:
                        return "Secret of the Sands";
                    case 1492:
                        return "Deadland Comes Alive";
                    case 1493:
                        return "Evil Presence";
                    case 1494:
                        return "Sky Guardian";
                    case 1495:
                        return "American Explosive";
                    case 1496:
                        return "Discover";
                    case 1497:
                        return "Hand Earth";
                    case 1498:
                        return "Old Miner";
                    case 1499:
                        return "Skelehead";
                    case 1500:
                        return "Facing the Cerebral Mastermind";
                    case 1501:
                        return "Lake of Fire";
                    case 1502:
                        return "Trio Super Heroes";
                    case 1503:
                        return "Spectre Hood";
                    case 1504:
                        return "Spectre Robe";
                    case 1505:
                        return "Spectre Pants";
                    case 1506:
                        return "Spectre Pickaxe";
                    case 1507:
                        return "Spectre Hamaxe";
                    case 1508:
                        return "Ectoplasm";
                    case 1509:
                        return "Gothic Chair";
                    case 1510:
                        return "Gothic Table";
                    case 1511:
                        return "Gothic Work Bench";
                    case 1512:
                        return "Gothic Bookcase";
                    case 1513:
                        return "Paladin's Hammer";
                    case 1514:
                        return "SWAT Helmet";
                    case 1515:
                        return "Bee Wings";
                    case 1516:
                        return "Giant Harpy Feather";
                    case 1517:
                        return "Bone Feather";
                    case 1518:
                        return "Fire Feather";
                    case 1519:
                        return "Ice Feather";
                    case 1520:
                        return "Broken Bat Wing";
                    case 1521:
                        return "Tattered Bee Wing";
                    case 1522:
                        return "Large Amethyst";
                    case 1523:
                        return "Large Topaz";
                    case 1524:
                        return "Large Sapphire";
                    case 1525:
                        return "Large Emerald";
                    case 1526:
                        return "Large Ruby";
                    case 1527:
                        return "Large Diamond";
                    case 1528:
                        return "Jungle Chest";
                    case 1529:
                        return "Corruption Chest";
                    case 1530:
                        return "Crimson Chest";
                    case 1531:
                        return "Hallowed Chest";
                    case 1532:
                        return "Frozen Chest";
                    case 1533:
                        return "Jungle Key";
                    case 1534:
                        return "Corruption Key";
                    case 1535:
                        return "Crimson Key";
                    case 1536:
                        return "Hallowed Key";
                    case 1537:
                        return "Frozen Key";
                    case 1538:
                        return "Imp Face";
                    case 1539:
                        return "Ominous Presence";
                    case 1540:
                        return "Shining Moon";
                    case 1541:
                        return "Living Gore";
                    case 1542:
                        return "Flowing Magma";
                    case 1543:
                        return "Spectre Paintbrush";
                    case 1544:
                        return "Spectre Paint Roller";
                    case 1545:
                        return "Spectre Paint Scraper";
                    case 1546:
                        return "Shroomite Headgear";
                    case 1547:
                        return "Shroomite Mask";
                    case 1548:
                        return "Shroomite Helmet";
                    case 1549:
                        return "Shroomite Breastplate";
                    case 1550:
                        return "Shroomite Leggings";
                    case 1551:
                        return "Autohammer";
                    case 1552:
                        return "Shroomite Bar";
                    case 1553:
                        return "S.D.M.G.";
                    case 1554:
                        return "Cenx's Tiara";
                    case 1555:
                        return "Cenx's Breastplate";
                    case 1556:
                        return "Cenx's Leggings";
                    case 1557:
                        return "Crowno's Mask";
                    case 1558:
                        return "Crowno's Breastplate";
                    case 1559:
                        return "Crowno's Leggings";
                    case 1560:
                        return "Will's Helmet";
                    case 1561:
                        return "Will's Breastplate";
                    case 1562:
                        return "Will's Leggings";
                    case 1563:
                        return "Jim's Helmet";
                    case 1564:
                        return "Jim's Breastplate";
                    case 1565:
                        return "Jim's Leggings";
                    case 1566:
                        return "Aaron's Helmet";
                    case 1567:
                        return "Aaron's Breastplate";
                    case 1568:
                        return "Aaron's Leggings";
                    case 1569:
                        return "Vampire Knives";
                    case 1570:
                        return "Broken Hero Sword";
                    case 1571:
                        return "Scourge of the Corruptor";
                    case 1572:
                        return "Staff of the Frost Hydra";
                    case 1573:
                        return "The Creation of the Guide";
                    case 1574:
                        return "The Merchant";
                    case 1575:
                        return "Crowno Devours His Lunch";
                    case 1576:
                        return "Rare Enchantment";
                    case 1577:
                        return "Glorious Night";
                    case 1578:
                        return "Sweetheart Necklace";
                    case 1579:
                        return "Flurry Boots";
                    case 1580:
                        return "D-Town's Helmet";
                    case 1581:
                        return "D-Town's Breastplate";
                    case 1582:
                        return "D-Town's Leggings";
                    case 1583:
                        return "D-Town's Wings";
                    case 1584:
                        return "Will's Wings";
                    case 1585:
                        return "Crowno's Wings";
                    case 1586:
                        return "Cenx's Wings";
                    case 1587:
                        return "Cenx's Dress";
                    case 1588:
                        return "Cenx's Dress Pants";
                    case 1589:
                        return "Palladium Column";
                    case 1590:
                        return "Palladium Column Wall";
                    case 1591:
                        return "Bubblegum Block";
                    case 1592:
                        return "Bubblegum Block Wall";
                    case 1593:
                        return "Titanstone Block";
                    case 1594:
                        return "Titanstone Block Wall";
                    case 1595:
                        return "Magic Cuffs";
                    case 1596:
                        return "Music Box (Snow)";
                    case 1597:
                        return "Music Box (Space)";
                    case 1598:
                        return "Music Box (Crimson)";
                    case 1599:
                        return "Music Box (Boss 4)";
                    case 1600:
                        return "Music Box (Alt Overworld Day)";
                    case 1601:
                        return "Music Box (Rain)";
                    case 1602:
                        return "Music Box (Ice)";
                    case 1603:
                        return "Music Box (Desert)";
                    case 1604:
                        return "Music Box (Ocean)";
                    case 1605:
                        return "Music Box (Dungeon)";
                    case 1606:
                        return "Music Box (Plantera)";
                    case 1607:
                        return "Music Box (Boss 5)";
                    case 1608:
                        return "Music Box (Temple)";
                    case 1609:
                        return "Music Box (Eclipse)";
                    case 1610:
                        return "Music Box (Mushrooms)";
                    case 1611:
                        return "Butterfly Dust";
                    case 1612:
                        return "Ankh Charm";
                    case 1613:
                        return "Ankh Shield";
                    case 1614:
                        return "Blue Flare";
                    case 1615:
                        return "Angler Fish Banner";
                    case 1616:
                        return "Angry Nimbus Banner";
                    case 1617:
                        return "Anomura Fungus Banner";
                    case 1618:
                        return "Antlion Banner";
                    case 1619:
                        return "Arapaima Banner";
                    case 1620:
                        return "Armored Skeleton Banner";
                    case 1621:
                        return "Cave Bat Banner";
                    case 1622:
                        return "Bird Banner";
                    case 1623:
                        return "Black Recluse Banner";
                    case 1624:
                        return "Blood Feeder Banner";
                    case 1625:
                        return "Blood Jelly Banner";
                    case 1626:
                        return "Blood Crawler Banner";
                    case 1627:
                        return "Bone Serpent Banner";
                    case 1628:
                        return "Bunny Banner";
                    case 1629:
                        return "Chaos Elemental Banner";
                    case 1630:
                        return "Mimic Banner";
                    case 1631:
                        return "Clown Banner";
                    case 1632:
                        return "Corrupt Bunny Banner";
                    case 1633:
                        return "Corrupt Goldfish Banner";
                    case 1634:
                        return "Crab Banner";
                    case 1635:
                        return "Crimera Banner";
                    case 1636:
                        return "Crimson Axe Banner";
                    case 1637:
                        return "Cursed Hammer Banner";
                    case 1638:
                        return "Demon Banner";
                    case 1639:
                        return "Demon Eye Banner";
                    case 1640:
                        return "Derpling Banner";
                    case 1641:
                        return "Eater of Souls Banner";
                    case 1642:
                        return "Enchanted Sword Banner";
                    case 1643:
                        return "Zombie Eskimo Banner";
                    case 1644:
                        return "Face Monster Banner";
                    case 1645:
                        return "Floaty Gross Banner";
                    case 1646:
                        return "Flying Fish Banner";
                    case 1647:
                        return "Flying Snake Banner";
                    case 1648:
                        return "Frankenstein Banner";
                    case 1649:
                        return "Fungi Bulb Banner";
                    case 1650:
                        return "Fungo Fish Banner";
                    case 1651:
                        return "Gastropod Banner";
                    case 1652:
                        return "Goblin Thief Banner";
                    case 1653:
                        return "Goblin Sorcerer Banner";
                    case 1654:
                        return "Goblin Peon Banner";
                    case 1655:
                        return "Goblin Scout Banner";
                    case 1656:
                        return "Goblin Warrior Banner";
                    case 1657:
                        return "Goldfish Banner";
                    case 1658:
                        return "Harpy Banner";
                    case 1659:
                        return "Hellbat Banner";
                    case 1660:
                        return "Herpling Banner";
                    case 1661:
                        return "Hornet Banner";
                    case 1662:
                        return "Ice Elemental Banner";
                    case 1663:
                        return "Icy Merman Banner";
                    case 1664:
                        return "Fire Imp Banner";
                    case 1665:
                        return "Blue Jellyfish Banner";
                    case 1666:
                        return "Jungle Creeper Banner";
                    case 1667:
                        return "Lihzahrd Banner";
                    case 1668:
                        return "Man Eater Banner";
                    case 1669:
                        return "Meteor Head Banner";
                    case 1670:
                        return "Moth Banner";
                    case 1671:
                        return "Mummy Banner";
                    case 1672:
                        return "Mushi Ladybug Banner";
                    case 1673:
                        return "Parrot Banner";
                    case 1674:
                        return "Pigron Banner";
                    case 1675:
                        return "Piranha Banner";
                    case 1676:
                        return "Pirate Deckhand Banner";
                    case 1677:
                        return "Pixie Banner";
                    case 1678:
                        return "Raincoat Zombie Banner";
                    case 1679:
                        return "Reaper Banner";
                    case 1680:
                        return "Shark Banner";
                    case 1681:
                        return "Skeleton Banner";
                    case 1682:
                        return "Dark Caster Banner";
                    case 1683:
                        return "Blue Slime Banner";
                    case 1684:
                        return "Snow Flinx Banner";
                    case 1685:
                        return "Wall Creeper Banner";
                    case 1686:
                        return "Spore Zombie Banner";
                    case 1687:
                        return "Swamp Thing Banner";
                    case 1688:
                        return "Giant Tortoise Banner";
                    case 1689:
                        return "Toxic Sludge Banner";
                    case 1690:
                        return "Umbrella Slime Banner";
                    case 1691:
                        return "Unicorn Banner";
                    case 1692:
                        return "Vampire Banner";
                    case 1693:
                        return "Vulture Banner";
                    case 1694:
                        return "Nymph Banner";
                    case 1695:
                        return "Werewolf Banner";
                    case 1696:
                        return "Wolf Banner";
                    case 1697:
                        return "World Feeder Banner";
                    case 1698:
                        return "Worm Banner";
                    case 1699:
                        return "Wraith Banner";
                    case 1700:
                        return "Wyvern Banner";
                    case 1701:
                        return "Zombie Banner";
                    case 1702:
                        return "Glass Platform";
                    case 1703:
                        return "Glass Chair";
                    case 1704:
                        return "Golden Chair";
                    case 1705:
                        return "Golden Toilet";
                    case 1706:
                        return "Bar Stool";
                    case 1707:
                        return "Honey Chair";
                    case 1708:
                        return "Steampunk Chair";
                    case 1709:
                        return "Glass Door";
                    case 1710:
                        return "Golden Door";
                    case 1711:
                        return "Honey Door";
                    case 1712:
                        return "Steampunk Door";
                    case 1713:
                        return "Glass Table";
                    case 1714:
                        return "Banquet Table";
                    case 1715:
                        return "Bar";
                    case 1716:
                        return "Golden Table";
                    case 1717:
                        return "Honey Table";
                    case 1718:
                        return "Steampunk Table";
                    case 1719:
                        return "Glass Bed";
                    case 1720:
                        return "Golden Bed";
                    case 1721:
                        return "Honey Bed";
                    case 1722:
                        return "Steampunk Bed";
                    case 1723:
                        return "Living Wood Wall";
                    case 1724:
                        return "Fart in a Jar";
                    case 1725:
                        return "Pumpkin";
                    case 1726:
                        return "Pumpkin Wall";
                    case 1727:
                        return "Hay";
                    case 1728:
                        return "Hay Wall";
                    case 1729:
                        return "Spooky Wood";
                    case 1730:
                        return "Spooky Wood Wall";
                    case 1731:
                        return "Pumpkin Helmet";
                    case 1732:
                        return "Pumpkin Breastplate";
                    case 1733:
                        return "Pumpkin Leggings";
                    case 1734:
                        return "Candy Apple";
                    case 1735:
                        return "Soul Cake";
                    case 1736:
                        return "Nurse Hat";
                    case 1737:
                        return "Nurse Shirt";
                    case 1738:
                        return "Nurse Pants";
                    case 1739:
                        return "Wizard's Hat";
                    case 1740:
                        return "Guy Fawkes Mask";
                    case 1741:
                        return "Dye Trader Robe";
                    case 1742:
                        return "Steampunk Goggles";
                    case 1743:
                        return "Cyborg Helmet";
                    case 1744:
                        return "Cyborg Shirt";
                    case 1745:
                        return "Cyborg Pants";
                    case 1746:
                        return "Creeper Mask";
                    case 1747:
                        return "Creeper Shirt";
                    case 1748:
                        return "Creeper Pants";
                    case 1749:
                        return "Cat Mask";
                    case 1750:
                        return "Cat Shirt";
                    case 1751:
                        return "Cat Pants";
                    case 1752:
                        return "Ghost Mask";
                    case 1753:
                        return "Ghost Shirt";
                    case 1754:
                        return "Pumpkin Mask";
                    case 1755:
                        return "Pumpkin Shirt";
                    case 1756:
                        return "Pumpkin Pants";
                    case 1757:
                        return "Robot Mask";
                    case 1758:
                        return "Robot Shirt";
                    case 1759:
                        return "Robot Pants";
                    case 1760:
                        return "Unicorn Mask";
                    case 1761:
                        return "Unicorn Shirt";
                    case 1762:
                        return "Unicorn Pants";
                    case 1763:
                        return "Vampire Mask";
                    case 1764:
                        return "Vampire Shirt";
                    case 1765:
                        return "Vampire Pants";
                    case 1766:
                        return "Witch Hat";
                    case 1767:
                        return "Leprechaun Hat";
                    case 1768:
                        return "Leprechaun Shirt";
                    case 1769:
                        return "Leprechaun Pants";
                    case 1770:
                        return "Pixie Shirt";
                    case 1771:
                        return "Pixie Pants";
                    case 1772:
                        return "Princess Hat";
                    case 1773:
                        return "Princess Dress";
                    case 1774:
                        return "Goodie Bag";
                    case 1775:
                        return "Witch Dress";
                    case 1776:
                        return "Witch Boots";
                    case 1777:
                        return "Bride of Frankenstein Mask";
                    case 1778:
                        return "Bride of Frankenstein Dress";
                    case 1779:
                        return "Karate Tortoise Mask";
                    case 1780:
                        return "Karate Tortoise Shirt";
                    case 1781:
                        return "Karate Tortoise Pants";
                    case 1782:
                        return "Candy Corn Rifle";
                    case 1783:
                        return "Candy Corn";
                    case 1784:
                        return "Jack 'O Lantern Launcher";
                    case 1785:
                        return "Explosive Jack 'O Lantern";
                    case 1786:
                        return "Sickle";
                    case 1787:
                        return "Pumpkin Pie";
                    case 1788:
                        return "Scarecrow Hat";
                    case 1789:
                        return "Scarecrow Shirt";
                    case 1790:
                        return "Scarecrow Pants";
                    case 1791:
                        return "Cauldron";
                    case 1792:
                        return "Pumpkin Chair";
                    case 1793:
                        return "Pumpkin Door";
                    case 1794:
                        return "Pumpkin Table";
                    case 1795:
                        return "Pumpkin Work Bench";
                    case 1796:
                        return "Pumpkin Platform";
                    case 1797:
                        return "Tattered Fairy Wings";
                    case 1798:
                        return "Spider Egg";
                    case 1799:
                        return "Magical Pumpkin Seed";
                    case 1800:
                        return "Bat Hook";
                    case 1801:
                        return "Bat Scepter";
                    case 1802:
                        return "Raven Staff";
                    case 1803:
                        return "Jungle Key Mold";
                    case 1804:
                        return "Corruption Key Mold";
                    case 1805:
                        return "Crimson Key Mold";
                    case 1806:
                        return "Hallowed Key Mold";
                    case 1807:
                        return "Frozen Key Mold";
                    case 1808:
                        return "Hanging Jack 'O Lantern";
                    case 1809:
                        return "Rotten Egg";
                    case 1810:
                        return "Unlucky Yarn";
                    case 1811:
                        return "Black Fairy Dust";
                    case 1812:
                        return "Jackelier";
                    case 1813:
                        return "Jack 'O Lantern";
                    case 1814:
                        return "Spooky Chair";
                    case 1815:
                        return "Spooky Door";
                    case 1816:
                        return "Spooky Table";
                    case 1817:
                        return "Spooky Work Bench";
                    case 1818:
                        return "Spooky Platform";
                    case 1819:
                        return "Reaper Hood";
                    case 1820:
                        return "Reaper Robe";
                    case 1821:
                        return "Fox Mask";
                    case 1822:
                        return "Fox Shirt";
                    case 1823:
                        return "Fox Pants";
                    case 1824:
                        return "Cat Ears";
                    case 1825:
                        return "Bloody Machete";
                    case 1826:
                        return "The Horseman's Blade";
                    case 1827:
                        return "Bladed Glove";
                    case 1828:
                        return "Pumpkin Seed";
                    case 1829:
                        return "Spooky Hook";
                    case 1830:
                        return "Spooky Wings";
                    case 1831:
                        return "Spooky Twig";
                    case 1832:
                        return "Spooky Helmet";
                    case 1833:
                        return "Spooky Breastplate";
                    case 1834:
                        return "Spooky Leggings";
                    case 1835:
                        return "Stake Launcher";
                    case 1836:
                        return "Stake";
                    case 1837:
                        return "Cursed Sapling";
                    case 1838:
                        return "Space Creature Mask";
                    case 1839:
                        return "Space Creature Shirt";
                    case 1840:
                        return "Space Creature Pants";
                    case 1841:
                        return "Wolf Mask";
                    case 1842:
                        return "Wolf Shirt";
                    case 1843:
                        return "Wolf Pants";
                    case 1844:
                        return "Pumpkin Moon Medallion";
                    case 1845:
                        return "Necromantic Scroll";
                    case 1846:
                        return "Jacking Skeletron";
                    case 1847:
                        return "Bitter Harvest";
                    case 1848:
                        return "Blood Moon Countess";
                    case 1849:
                        return "Hallow's Eve";
                    case 1850:
                        return "Morbid Curiosity";
                    case 1851:
                        return "Treasure Hunter Shirt";
                    case 1852:
                        return "Treasure Hunter Pants";
                    case 1853:
                        return "Dryad Coverings";
                    case 1854:
                        return "Dryad Loincloth";
                    case 1855:
                        return "Mourning Wood Trophy";
                    case 1856:
                        return "Pumpking Trophy";
                    case 1857:
                        return "Jack 'O Lantern Mask";
                    case 1858:
                        return "Sniper Scope";
                    case 1859:
                        return "Heart Lantern";
                    case 1860:
                        return "Jellyfish Diving Gear";
                    case 1861:
                        return "Arctic Diving Gear";
                    case 1862:
                        return "Frostspark Boots";
                    case 1863:
                        return "Fart in a Balloon";
                    case 1864:
                        return "Papyrus Scarab";
                    case 1865:
                        return "Celestial Stone";
                    case 1866:
                        return "Hoverboard";
                    case 1867:
                        return "Candy Cane";
                    case 1868:
                        return "Sugar Plum";
                    case 1869:
                        return "Present";
                    case 1870:
                        return "Red Ryder";
                    case 1871:
                        return "Festive Wings";
                    case 1872:
                        return "Pine Tree Block";
                    case 1873:
                        return "Christmas Tree";
                    case 1874:
                        return "Star Topper 1";
                    case 1875:
                        return "Star Topper 2";
                    case 1876:
                        return "Star Topper 3";
                    case 1877:
                        return "Bow Topper";
                    case 1878:
                        return "White Garland";
                    case 1879:
                        return "White and Red Garland";
                    case 1880:
                        return "Red Garland";
                    case 1881:
                        return "Red and Green Garland";
                    case 1882:
                        return "Green Garland";
                    case 1883:
                        return "Green and White Garland";
                    case 1884:
                        return "Multicolored Bulb";
                    case 1885:
                        return "Red Bulb";
                    case 1886:
                        return "Yellow Bulb";
                    case 1887:
                        return "Green Bulb";
                    case 1888:
                        return "Red and Green Bulb";
                    case 1889:
                        return "Yellow and Green Bulb";
                    case 1890:
                        return "Red and Yellow Bulb";
                    case 1891:
                        return "White Bulb";
                    case 1892:
                        return "White and Red Bulb";
                    case 1893:
                        return "White and Yellow Bulb";
                    case 1894:
                        return "White and Green Bulb";
                    case 1895:
                        return "Multicolored Lights";
                    case 1896:
                        return "Red Lights";
                    case 1897:
                        return "Green Lights";
                    case 1898:
                        return "Blue Lights";
                    case 1899:
                        return "Yellow Lights";
                    case 1900:
                        return "Red and Yellow Lights";
                    case 1901:
                        return "Red and Green Lights";
                    case 1902:
                        return "Yellow and Green Lights";
                    case 1903:
                        return "Blue and Green Lights";
                    case 1904:
                        return "Red and Blue Lights";
                    case 1905:
                        return "Blue and Yellow Lights";
                    case 1906:
                        return "Giant Bow";
                    case 1907:
                        return "Reindeer Antlers";
                    case 1908:
                        return "Holly";
                    case 1909:
                        return "Candy Cane Sword";
                    case 1910:
                        return "Elf Melter";
                    case 1911:
                        return "Christmas Pudding";
                    case 1912:
                        return "Eggnog";
                    case 1913:
                        return "Star Anise";
                    case 1914:
                        return "Reindeer Bells";
                    case 1915:
                        return "Candy Cane Hook";
                    case 1916:
                        return "Christmas Hook";
                    case 1917:
                        return "Candy Cane Pickaxe";
                    case 1918:
                        return "Fruitcake Chakram";
                    case 1919:
                        return "Sugar Cookie";
                    case 1920:
                        return "Gingerbread Cookie";
                    case 1921:
                        return "Hand Warmer";
                    case 1922:
                        return "Coal";
                    case 1923:
                        return "Toolbox";
                    case 1924:
                        return "Pine Door";
                    case 1925:
                        return "Pine Chair";
                    case 1926:
                        return "Pine Table";
                    case 1927:
                        return "Dog Whistle";
                    case 1928:
                        return "Christmas Tree Sword";
                    case 1929:
                        return "Chain Gun";
                    case 1930:
                        return "Razorpine";
                    case 1931:
                        return "Blizzard Staff";
                    case 1932:
                        return "Mrs. Claus Hat";
                    case 1933:
                        return "Mrs. Claus Shirt";
                    case 1934:
                        return "Mrs. Claus Heels";
                    case 1935:
                        return "Parka Hood";
                    case 1936:
                        return "Parka Coat";
                    case 1937:
                        return "Parka Pants";
                    case 1938:
                        return "Snow Hat";
                    case 1939:
                        return "Ugly Sweater";
                    case 1940:
                        return "Tree Mask";
                    case 1941:
                        return "Tree Shirt";
                    case 1942:
                        return "Tree Trunks";
                    case 1943:
                        return "Elf Hat";
                    case 1944:
                        return "Elf Shirt";
                    case 1945:
                        return "Elf Pants";
                    case 1946:
                        return "Snowman Cannon";
                    case 1947:
                        return "North Pole";
                    case 1948:
                        return "Christmas Tree Wallpaper";
                    case 1949:
                        return "Ornament Wallpaper";
                    case 1950:
                        return "Candy Cane Wallpaper";
                    case 1951:
                        return "Festive Wallpaper";
                    case 1952:
                        return "Stars Wallpaper";
                    case 1953:
                        return "Squiggles Wallpaper";
                    case 1954:
                        return "Snowflake Wallpaper";
                    case 1955:
                        return "Krampus Horn Wallpaper";
                    case 1956:
                        return "Bluegreen Wallpaper";
                    case 1957:
                        return "Grinch Finger Wallpaper";
                    case 1958:
                        return "Naughty Present";
                    case 1959:
                        return "Baby Grinch's Mischief Whistle";
                    case 1960:
                        return "Ice Queen Trophy";
                    case 1961:
                        return "Santa-NK1 Trophy";
                    case 1962:
                        return "Everscream Trophy";
                    case 1963:
                        return "Music Box (Pumpkin Moon)";
                    case 1964:
                        return "Music Box (Alt Underground)";
                    case 1965:
                        return "Music Box (Frost Moon)";
                    case 1966:
                        return "Brown Paint";
                    case 1967:
                        return "Shadow Paint";
                    case 1968:
                        return "Negative Paint";
                    case 1969:
                        return "Team Dye";
                    case 1970:
                        return "Amethyst Gemspark Block";
                    case 1971:
                        return "Topaz Gemspark Block";
                    case 1972:
                        return "Sapphire Gemspark Block";
                    case 1973:
                        return "Emerald Gemspark Block";
                    case 1974:
                        return "Ruby Gemspark Block";
                    case 1975:
                        return "Diamond Gemspark Block";
                    case 1976:
                        return "Amber Gemspark Block";
                    case 1977:
                        return "Life Hair Dye";
                    case 1978:
                        return "Mana Hair Dye";
                    case 1979:
                        return "Depth Hair Dye";
                    case 1980:
                        return "Money Hair Dye";
                    case 1981:
                        return "Time Hair Dye";
                    case 1982:
                        return "Team Hair Dye";
                    case 1983:
                        return "Biome Hair Dye";
                    case 1984:
                        return "Party Hair Dye";
                    case 1985:
                        return "Rainbow Hair Dye";
                    case 1986:
                        return "Speed Hair Dye";
                    case 1987:
                        return "Angel Halo";
                    case 1988:
                        return "Fez";
                    case 1989:
                        return "Womannequin";
                    case 1990:
                        return "Hair Dye Remover";
                    case 1991:
                        return "Bug Net";
                    case 1992:
                        return "Firefly";
                    case 1993:
                        return "Firefly in a Bottle";
                    case 1994:
                        return "Monarch Butterfly";
                    case 1995:
                        return "Purple Emperor Butterfly";
                    case 1996:
                        return "Red Admiral Butterfly";
                    case 1997:
                        return "Ulysses Butterfly";
                    case 1998:
                        return "Sulphur Butterfly";
                    case 1999:
                        return "Tree Nymph Butterfly";
                    case 2000:
                        return "Zebra Swallowtail Butterfly";
                    case 2001:
                        return "Julia Butterfly";
                    case 2002:
                        return "Worm";
                    case 2003:
                        return "Mouse";
                    case 2004:
                        return "Lightning Bug";
                    case 2005:
                        return "Lightning Bug in a Bottle";
                    case 2006:
                        return "Snail";
                    case 2007:
                        return "Glowing Snail";
                    case 2008:
                        return "Fancy Gray Wallpaper";
                    case 2009:
                        return "Ice Floe Wallpaper";
                    case 2010:
                        return "Music Wallpaper";
                    case 2011:
                        return "Purple Rain Wallpaper";
                    case 2012:
                        return "Rainbow Wallpaper";
                    case 2013:
                        return "Sparkle Stone Wallpaper";
                    case 2014:
                        return "Starlit Heaven Wallpaper";
                    case 2015:
                        return "Bird";
                    case 2016:
                        return "Blue Jay";
                    case 2017:
                        return "Cardinal";
                    case 2018:
                        return "Squirrel";
                    case 2019:
                        return "Bunny";
                    case 2020:
                        return "Cactus Bookcase";
                    case 2021:
                        return "Ebonwood Bookcase";
                    case 2022:
                        return "Flesh Bookcase";
                    case 2023:
                        return "Honey Bookcase";
                    case 2024:
                        return "Steampunk Bookcase";
                    case 2025:
                        return "Glass Bookcase";
                    case 2026:
                        return "Rich Mahogany Bookcase";
                    case 2027:
                        return "Pearlwood Bookcase";
                    case 2028:
                        return "Spooky Bookcase";
                    case 2029:
                        return "Skyware Bookcase";
                    case 2030:
                        return "Lihzahrd Bookcase";
                    case 2031:
                        return "Frozen Bookcase";
                    case 2032:
                        return "Cactus Lantern";
                    case 2033:
                        return "Ebonwood Lantern";
                    case 2034:
                        return "Flesh Lantern";
                    case 2035:
                        return "Honey Lantern";
                    case 2036:
                        return "Steampunk Lantern";
                    case 2037:
                        return "Glass Lantern";
                    case 2038:
                        return "Rich Mahogany Lantern";
                    case 2039:
                        return "Pearlwood Lantern";
                    case 2040:
                        return "Frozen Lantern";
                    case 2041:
                        return "Lihzahrd Lantern";
                    case 2042:
                        return "Skyware Lantern";
                    case 2043:
                        return "Spooky Lantern";
                    case 2044:
                        return "Frozen Door";
                    case 2045:
                        return "Cactus Candle";
                    case 2046:
                        return "Ebonwood Candle";
                    case 2047:
                        return "Flesh Candle";
                    case 2048:
                        return "Glass Candle";
                    case 2049:
                        return "Frozen Candle";
                    case 2050:
                        return "Rich Mahogany Candle";
                    case 2051:
                        return "Pearlwood Candle";
                    case 2052:
                        return "Lihzahrd Candle";
                    case 2053:
                        return "Skyware Candle";
                    case 2054:
                        return "Pumpkin Candle";
                    case 2055:
                        return "Cactus Chandelier";
                    case 2056:
                        return "Ebonwood Chandelier";
                    case 2057:
                        return "Flesh Chandelier";
                    case 2058:
                        return "Honey Chandelier";
                    case 2059:
                        return "Frozen Chandelier";
                    case 2060:
                        return "Rich Mahogany Chandelier";
                    case 2061:
                        return "Pearlwood Chandelier";
                    case 2062:
                        return "Lihzahrd Chandelier";
                    case 2063:
                        return "Skyware Chandelier";
                    case 2064:
                        return "Spooky Chandelier";
                    case 2065:
                        return "Glass Chandelier";
                    case 2066:
                        return "Cactus Bed";
                    case 2067:
                        return "Flesh Bed";
                    case 2068:
                        return "Frozen Bed";
                    case 2069:
                        return "Lihzahrd Bed";
                    case 2070:
                        return "Skyware Bed";
                    case 2071:
                        return "Spooky Bed";
                    case 2072:
                        return "Cactus Bathtub";
                    case 2073:
                        return "Ebonwood Bathtub";
                    case 2074:
                        return "Flesh Bathtub";
                    case 2075:
                        return "Glass Bathtub";
                    case 2076:
                        return "Frozen Bathtub";
                    case 2077:
                        return "Rich Mahogany Bathtub";
                    case 2078:
                        return "Pearlwood Bathtub";
                    case 2079:
                        return "Lihzahrd Bathtub";
                    case 2080:
                        return "Skyware Bathtub";
                    case 2081:
                        return "Spooky Bathtub";
                    case 2082:
                        return "Cactus Lamp";
                    case 2083:
                        return "Ebonwood Lamp";
                    case 2084:
                        return "Flesh Lamp";
                    case 2085:
                        return "Glass Lamp";
                    case 2086:
                        return "Frozen Lamp";
                    case 2087:
                        return "Rich Mahogany Lamp";
                    case 2088:
                        return "Pearlwood Lamp";
                    case 2089:
                        return "Lihzahrd Lamp";
                    case 2090:
                        return "Skyware Lamp";
                    case 2091:
                        return "Spooky Lamp";
                    case 2092:
                        return "Cactus Candelabra";
                    case 2093:
                        return "Ebonwood Candelabra";
                    case 2094:
                        return "Flesh Candelabra";
                    case 2095:
                        return "Honey Candelabra";
                    case 2096:
                        return "Steampunk Candelabra";
                    case 2097:
                        return "Glass Candelabra";
                    case 2098:
                        return "Rich Mahogany Candelabra";
                    case 2099:
                        return "Pearlwood Candelabra";
                    case 2100:
                        return "Frozen Candelabra";
                    case 2101:
                        return "Lihzahrd Candelabra";
                    case 2102:
                        return "Skyware Candelabra";
                    case 2103:
                        return "Spooky Candelabra";
                    case 2104:
                        return "Brain of Cthulhu Mask";
                    case 2105:
                        return "Wall of Flesh Mask";
                    case 2106:
                        return "Twin Mask";
                    case 2107:
                        return "Skeletron Prime Mask";
                    case 2108:
                        return "Queen Bee Mask";
                    case 2109:
                        return "Plantera Mask";
                    case 2110:
                        return "Golem Mask";
                    case 2111:
                        return "Eater of Worlds Mask";
                    case 2112:
                        return "Eye of Cthulhu Mask";
                    case 2113:
                        return "Destroyer Mask";
                    case 2114:
                        return "Blacksmith Rack";
                    case 2115:
                        return "Carpentry Rack";
                    case 2116:
                        return "Helmet Rack";
                    case 2117:
                        return "Spear Rack";
                    case 2118:
                        return "Sword Rack";
                    case 2119:
                        return "Stone Slab";
                    case 2120:
                        return "Sandstone Slab";
                    case 2121:
                        return "Frog";
                    case 2122:
                        return "Mallard Duck";
                    case 2123:
                        return "Duck";
                    case 2124:
                        return "Honey Bathtub";
                    case 2125:
                        return "Steampunk Bathtub";
                    case 2126:
                        return "Living Wood Bathtub";
                    case 2127:
                        return "Shadewood Bathtub";
                    case 2128:
                        return "Bone Bathtub";
                    case 2129:
                        return "Honey Lamp";
                    case 2130:
                        return "Steampunk Lamp";
                    case 2131:
                        return "Living Wood Lamp";
                    case 2132:
                        return "Shadewood Lamp";
                    case 2133:
                        return "Golden Lamp";
                    case 2134:
                        return "Bone Lamp";
                    case 2135:
                        return "Living Wood Bookcase";
                    case 2136:
                        return "Shadewood Bookcase";
                    case 2137:
                        return "Golden Bookcase";
                    case 2138:
                        return "Bone Bookcase";
                    case 2139:
                        return "Living Wood Bed";
                    case 2140:
                        return "Bone Bed";
                    case 2141:
                        return "Living Wood Chandelier";
                    case 2142:
                        return "Shadewood Chandelier";
                    case 2143:
                        return "Golden Chandelier";
                    case 2144:
                        return "Bone Chandelier";
                    case 2145:
                        return "Living Wood Lantern";
                    case 2146:
                        return "Shadewood Lantern";
                    case 2147:
                        return "Golden Lantern";
                    case 2148:
                        return "Bone Lantern";
                    case 2149:
                        return "Living Wood Candelabra";
                    case 2150:
                        return "Shadewood Candelabra";
                    case 2151:
                        return "Golden Candelabra";
                    case 2152:
                        return "Bone Candelabra";
                    case 2153:
                        return "Living Wood Candle";
                    case 2154:
                        return "Shadewood Candle";
                    case 2155:
                        return "Golden Candle";
                    case 2156:
                        return "Black Scorpion";
                    case 2157:
                        return "Scorpion";
                    case 2158:
                        return "Bubble Wallpaper";
                    case 2159:
                        return "Copper Pipe Wallpaper";
                    case 2160:
                        return "Ducky Wallpaper";
                    case 2161:
                        return "Frost Core";
                    case 2162:
                        return "Bunny Cage";
                    case 2163:
                        return "Squirrel Cage";
                    case 2164:
                        return "Mallard Duck Cage";
                    case 2165:
                        return "Duck Cage";
                    case 2166:
                        return "Bird Cage";
                    case 2167:
                        return "Blue Jay Cage";
                    case 2168:
                        return "Cardinal Cage";
                    case 2169:
                        return "Waterfall Wall";
                    case 2170:
                        return "Lavafall Wall";
                    case 2171:
                        return "Crimson Seeds";
                    case 2172:
                        return "Heavy Work Bench";
                    case 2173:
                        return "Copper Plating";
                    case 2174:
                        return "Snail Cage";
                    case 2175:
                        return "Glowing Snail Cage";
                    case 2176:
                        return "Shroomite Digging Claw";
                    case 2177:
                        return "Ammo Box";
                    case 2178:
                        return "Monarch Butterfly Jar";
                    case 2179:
                        return "Purple Emperor Butterfly Jar";
                    case 2180:
                        return "Red Admiral Butterfly Jar";
                    case 2181:
                        return "Ulysses Butterfly Jar";
                    case 2182:
                        return "Sulphur Butterfly Jar";
                    case 2183:
                        return "Tree Nymph Butterfly Jar";
                    case 2184:
                        return "Zebra Swallowtail Butterfly Jar";
                    case 2185:
                        return "Julia Butterfly Jar";
                    case 2186:
                        return "Scorpion Cage";
                    case 2187:
                        return "Black Scorpion Cage";
                    case 2188:
                        return "Venom Staff";
                    case 2189:
                        return "Spectre Mask";
                    case 2190:
                        return "Frog Cage";
                    case 2191:
                        return "Mouse Cage";
                    case 2192:
                        return "Bone Welder";
                    case 2193:
                        return "Flesh Cloning Vat";
                    case 2194:
                        return "Glass Kiln";
                    case 2195:
                        return "Lihzahrd Furnace";
                    case 2196:
                        return "Living Loom";
                    case 2197:
                        return "Sky Mill";
                    case 2198:
                        return "Ice Machine";
                    case 2199:
                        return "Beetle Helmet";
                    case 2200:
                        return "Beetle Scale Mail";
                    case 2201:
                        return "Beetle Shell";
                    case 2202:
                        return "Beetle Leggings";
                    case 2203:
                        return "Steampunk Boiler";
                    case 2204:
                        return "Honey Dispenser";
                    case 2205:
                        return "Penguin";
                    case 2206:
                        return "Penguin Cage";
                    case 2207:
                        return "Worm Cage";
                    case 2208:
                        return "Terrarium";
                    case 2209:
                        return "Super Mana Potion";
                    case 2210:
                        return "Ebonwood Fence";
                    case 2211:
                        return "Rich Mahogany Fence";
                    case 2212:
                        return "Pearlwood Fence";
                    case 2213:
                        return "Shadewood Fence";
                    case 2214:
                        return "Brick Layer";
                    case 2215:
                        return "Extendo Grip";
                    case 2216:
                        return "Paint Sprayer";
                    case 2217:
                        return "Portable Cement Mixer";
                    case 2218:
                        return "Beetle Husk";
                    case 2219:
                        return "Celestial Magnet";
                    case 2220:
                        return "Celestial Emblem";
                    case 2221:
                        return "Celestial Cuffs";
                    case 2222:
                        return "Peddler's Hat";
                    case 2223:
                        return "Pulse Bow";
                    case 2224:
                        return "Large Dynasty Lantern";
                    case 2225:
                        return "Dynasty Lamp";
                    case 2226:
                        return "Dynasty Lantern";
                    case 2227:
                        return "Large Dynasty Candle";
                    case 2228:
                        return "Dynasty Chair";
                    case 2229:
                        return "Dynasty Work Bench";
                    case 2230:
                        return "Dynasty Chest";
                    case 2231:
                        return "Dynasty Bed";
                    case 2232:
                        return "Dynasty Bathtub";
                    case 2233:
                        return "Dynasty Bookcase";
                    case 2234:
                        return "Dynasty Cup";
                    case 2235:
                        return "Dynasty Bowl";
                    case 2236:
                        return "Dynasty Candle";
                    case 2237:
                        return "Dynasty Clock";
                    case 2238:
                        return "Golden Clock";
                    case 2239:
                        return "Glass Clock";
                    case 2240:
                        return "Honey Clock";
                    case 2241:
                        return "Steampunk Clock";
                    case 2242:
                        return "Fancy Dishes";
                    case 2243:
                        return "Glass Bowl";
                    case 2244:
                        return "Wine Glass";
                    case 2245:
                        return "Living Wood Piano";
                    case 2246:
                        return "Flesh Piano";
                    case 2247:
                        return "Frozen Piano";
                    case 2248:
                        return "Frozen Table";
                    case 2249:
                        return "Honey Chest";
                    case 2250:
                        return "Steampunk Chest";
                    case 2251:
                        return "Honey Work Bench";
                    case 2252:
                        return "Frozen Work Bench";
                    case 2253:
                        return "Steampunk Work Bench";
                    case 2254:
                        return "Glass Piano";
                    case 2255:
                        return "Honey Piano";
                    case 2256:
                        return "Steampunk Piano";
                    case 2257:
                        return "Honey Cup";
                    case 2258:
                        return "Chalice";
                    case 2259:
                        return "Dynasty Table";
                    case 2260:
                        return "Dynasty Wood";
                    case 2261:
                        return "Red Dynasty Shingles";
                    case 2262:
                        return "Blue Dynasty Shingles";
                    case 2263:
                        return "White Dynasty Wall";
                    case 2264:
                        return "Blue Dynasty Wall";
                    case 2265:
                        return "Dynasty Door";
                    case 2266:
                        return "Sake";
                    case 2267:
                        return "Pad Thai";
                    case 2268:
                        return "Pho";
                    case 2269:
                        return "Revolver";
                    case 2270:
                        return "Gatligator";
                    case 2271:
                        return "Arcane Rune Wall";
                    case 2272:
                        return "Water Gun";
                    case 2273:
                        return "Katana";
                    case 2274:
                        return "Ultrabright Torch";
                    case 2275:
                        return "Magic Hat";
                    case 2276:
                        return "Diamond Ring";
                    case 2277:
                        return "Gi";
                    case 2278:
                        return "Kimono";
                    case 2279:
                        return "Gypsy Robe";
                    case 2280:
                        return "Beetle Wings";
                    case 2281:
                        return "Tiger Skin";
                    case 2282:
                        return "Leopard Skin";
                    case 2283:
                        return "Zebra Skin";
                    case 2284:
                        return "Crimson Cloak";
                    case 2285:
                        return "Mysterious Cape";
                    case 2286:
                        return "Red Cape";
                    case 2287:
                        return "Winter Cape";
                    case 2288:
                        return "Frozen Chair";
                    case 2289:
                        return "Wood Fishing Pole";
                    case 2290:
                        return "Bass";
                    case 2291:
                        return "Reinforced Fishing Pole";
                    case 2292:
                        return "Fiberglass Fishing Pole";
                    case 2293:
                        return "Fisher of Souls";
                    case 2294:
                        return "Golden Fishing Rod";
                    case 2295:
                        return "Mechanic's Rod";
                    case 2296:
                        return "Sitting Duck's Fishing Pole";
                    case 2297:
                        return "Trout";
                    case 2298:
                        return "Salmon";
                    case 2299:
                        return "Atlantic Cod";
                    case 2300:
                        return "Tuna";
                    case 2301:
                        return "Red Snapper";
                    case 2302:
                        return "Neon Tetra";
                    case 2303:
                        return "Armored Cavefish";
                    case 2304:
                        return "Damselfish";
                    case 2305:
                        return "Crimson Tigerfish";
                    case 2306:
                        return "Frost Minnow";
                    case 2307:
                        return "Princess Fish";
                    case 2308:
                        return "Golden Carp";
                    case 2309:
                        return "Specular Fish";
                    case 2310:
                        return "Prismite";
                    case 2311:
                        return "Variegated Lardfish";
                    case 2312:
                        return "Flarefin Koi";
                    case 2313:
                        return "Double Cod";
                    case 2314:
                        return "Honeyfin";
                    case 2315:
                        return "Obsidifish";
                    case 2316:
                        return "Shrimp";
                    case 2317:
                        return "Chaos Fish";
                    case 2318:
                        return "Ebonkoi";
                    case 2319:
                        return "Hemopiranha";
                    case 2320:
                        return "Rockfish";
                    case 2321:
                        return "Stinkfish";
                    case 2322:
                        return "Mining Potion";
                    case 2323:
                        return "Heartreach Potion";
                    case 2324:
                        return "Calming Potion";
                    case 2325:
                        return "Builder Potion";
                    case 2326:
                        return "Titan Potion";
                    case 2327:
                        return "Flipper Potion";
                    case 2328:
                        return "Summoning Potion";
                    case 2329:
                        return "Dangersense Potion";
                    case 2330:
                        return "Purple Clubberfish";
                    case 2331:
                        return "Obsidian Swordfish";
                    case 2332:
                        return "Swordfish";
                    case 2333:
                        return "Iron Fence";
                    case 2334:
                        return "Wooden Crate";
                    case 2335:
                        return "Iron Crate";
                    case 2336:
                        return "Golden Crate";
                    case 2337:
                        return "Old Shoe";
                    case 2338:
                        return "Seaweed";
                    case 2339:
                        return "Tin Can";
                    case 2340:
                        return "Minecart Track";
                    case 2341:
                        return "Reaver Shark";
                    case 2342:
                        return "Sawtooth Shark";
                    case 2343:
                        return "Minecart";
                    case 2344:
                        return "Ammo Reservation Potion";
                    case 2345:
                        return "Lifeforce Potion";
                    case 2346:
                        return "Endurance Potion";
                    case 2347:
                        return "Rage Potion";
                    case 2348:
                        return "Inferno Potion";
                    case 2349:
                        return "Wrath Potion";
                    case 2350:
                        return "Recall Potion";
                    case 2351:
                        return "Teleportation Potion";
                    case 2352:
                        return "Love Potion";
                    case 2353:
                        return "Stink Potion";
                    case 2354:
                        return "Fishing Potion";
                    case 2355:
                        return "Sonar Potion";
                    case 2356:
                        return "Crate Potion";
                    case 2357:
                        return "Shiverthorn Seeds";
                    case 2358:
                        return "Shiverthorn";
                    case 2359:
                        return "Warmth Potion";
                    case 2360:
                        return "Fish Hook";
                    case 2361:
                        return "Bee Headgear";
                    case 2362:
                        return "Bee Breastplate";
                    case 2363:
                        return "Bee Greaves";
                    case 2364:
                        return "Hornet Staff";
                    case 2365:
                        return "Imp Staff";
                    case 2366:
                        return "Queen Spider Staff";
                    case 2367:
                        return "Angler Hat";
                    case 2368:
                        return "Angler Vest";
                    case 2369:
                        return "Angler Pants";
                    case 2370:
                        return "Spider Mask";
                    case 2371:
                        return "Spider Breastplate";
                    case 2372:
                        return "Spider Greaves";
                    case 2373:
                        return "High Test Fishing Line";
                    case 2374:
                        return "Angler Earring";
                    case 2375:
                        return "Tackle Box";
                    case 2376:
                        return "Blue Dungeon Piano";
                    case 2377:
                        return "Green Dungeon Piano";
                    case 2378:
                        return "Pink Dungeon Piano";
                    case 2379:
                        return "Golden Piano";
                    case 2380:
                        return "Obsidian Piano";
                    case 2381:
                        return "Bone Piano";
                    case 2382:
                        return "Cactus Piano";
                    case 2383:
                        return "Spooky Piano";
                    case 2384:
                        return "Skyware Piano";
                    case 2385:
                        return "Lihzahrd Piano";
                    case 2386:
                        return "Blue Dungeon Dresser";
                    case 2387:
                        return "Green Dungeon Dresser";
                    case 2388:
                        return "Pink Dungeon Dresser";
                    case 2389:
                        return "Golden Dresser";
                    case 2390:
                        return "Obsidian Dresser";
                    case 2391:
                        return "Bone Dresser";
                    case 2392:
                        return "Cactus Dresser";
                    case 2393:
                        return "Spooky Dresser";
                    case 2394:
                        return "Skyware Dresser";
                    case 2395:
                        return "Honey Dresser";
                    case 2396:
                        return "Lihzahrd Dresser";
                    case 2397:
                        return "Sofa";
                    case 2398:
                        return "Ebonwood Sofa";
                    case 2399:
                        return "Rich Mahogany Sofa";
                    case 2400:
                        return "Pearlwood Sofa";
                    case 2401:
                        return "Shadewood Sofa";
                    case 2402:
                        return "Blue Dungeon Sofa";
                    case 2403:
                        return "Green Dungeon Sofa";
                    case 2404:
                        return "Pink Dungeon Sofa";
                    case 2405:
                        return "Golden Sofa";
                    case 2406:
                        return "Obsidian Sofa";
                    case 2407:
                        return "Bone Sofa";
                    case 2408:
                        return "Cactus Sofa";
                    case 2409:
                        return "Spooky Sofa";
                    case 2410:
                        return "Skyware Sofa";
                    case 2411:
                        return "Honey Sofa";
                    case 2412:
                        return "Steampunk Sofa";
                    case 2413:
                        return "Mushroom Sofa";
                    case 2414:
                        return "Glass Sofa";
                    case 2415:
                        return "Pumpkin Sofa";
                    case 2416:
                        return "Lihzahrd Sofa";
                    case 2417:
                        return "Seashell Hairpin";
                    case 2418:
                        return "Mermaid Adornment";
                    case 2419:
                        return "Mermaid Tail";
                    case 2420:
                        return "Zephyr Fish";
                    case 2421:
                        return "Fleshcatcher";
                    case 2422:
                        return "Hotline Fishing Hook";
                    case 2423:
                        return "Frog Leg";
                    case 2424:
                        return "Anchor";
                    case 2425:
                        return "Cooked Fish";
                    case 2426:
                        return "Cooked Shrimp";
                    case 2427:
                        return "Sashimi";
                    case 2428:
                        return "Fuzzy Carrot";
                    case 2429:
                        return "Scaly Truffle";
                    case 2430:
                        return "Slimy Saddle";
                    case 2431:
                        return "Bee Wax";
                    case 2432:
                        return "Copper Plating Wall";
                    case 2433:
                        return "Stone Slab Wall";
                    case 2434:
                        return "Sail";
                    case 2435:
                        return "Coralstone Block";
                    case 2436:
                        return "Blue Jellyfish";
                    case 2437:
                        return "Green Jellyfish";
                    case 2438:
                        return "Pink Jellyfish";
                    case 2439:
                        return "Blue Jellyfish Jar";
                    case 2440:
                        return "Green Jellyfish Jar";
                    case 2441:
                        return "Pink Jellyfish Jar";
                    case 2442:
                        return "Life Preserver";
                    case 2443:
                        return "Ship's Wheel";
                    case 2444:
                        return "Compass Rose";
                    case 2445:
                        return "Wall Anchor";
                    case 2446:
                        return "Goldfish Trophy";
                    case 2447:
                        return "Bunnyfish Trophy";
                    case 2448:
                        return "Swordfish Trophy";
                    case 2449:
                        return "Sharkteeth Trophy";
                    case 2450:
                        return "Batfish";
                    case 2451:
                        return "Bumblebee Tuna";
                    case 2452:
                        return "Catfish";
                    case 2453:
                        return "Cloudfish";
                    case 2454:
                        return "Cursedfish";
                    case 2455:
                        return "Dirtfish";
                    case 2456:
                        return "Dynamite Fish";
                    case 2457:
                        return "Eater of Plankton";
                    case 2458:
                        return "Fallen Starfish";
                    case 2459:
                        return "The Fish of Cthulhu";
                    case 2460:
                        return "Fishotron";
                    case 2461:
                        return "Harpyfish";
                    case 2462:
                        return "Hungerfish";
                    case 2463:
                        return "Ichorfish";
                    case 2464:
                        return "Jewelfish";
                    case 2465:
                        return "Mirage Fish";
                    case 2466:
                        return "Mutant Flinxfin";
                    case 2467:
                        return "Pengfish";
                    case 2468:
                        return "Pixiefish";
                    case 2469:
                        return "Spiderfish";
                    case 2470:
                        return "Tundra Trout";
                    case 2471:
                        return "Unicorn Fish";
                    case 2472:
                        return "Guide Voodoo Fish";
                    case 2473:
                        return "Wyverntail";
                    case 2474:
                        return "Zombie Fish";
                    case 2475:
                        return "Amanitia Fungifin";
                    case 2476:
                        return "Angelfish";
                    case 2477:
                        return "Bloody Manowar";
                    case 2478:
                        return "Bonefish";
                    case 2479:
                        return "Bunnyfish";
                    case 2480:
                        return "Cap'n Tunabeard";
                    case 2481:
                        return "Clownfish";
                    case 2482:
                        return "Demonic Hellfish";
                    case 2483:
                        return "Derpfish";
                    case 2484:
                        return "Fishron";
                    case 2485:
                        return "Infected Scabbardfish";
                    case 2486:
                        return "Mudfish";
                    case 2487:
                        return "Slimefish";
                    case 2488:
                        return "Tropical Barracuda";
                    case 2489:
                        return "King Slime Trophy";
                    case 2490:
                        return "Ship in a Bottle";
                    case 2491:
                        return "Hardy Saddle";
                    case 2492:
                        return "Pressure Plate Track";
                    case 2493:
                        return "King Slime Mask";
                    case 2494:
                        return "Fin Wings";
                    case 2495:
                        return "Treasure Map";
                    case 2496:
                        return "Seaweed Planter";
                    case 2497:
                        return "Pillagin Me Pixels";
                    case 2498:
                        return "Fish Costume Mask";
                    case 2499:
                        return "Fish Costume Shirt";
                    case 2500:
                        return "Fish Costume Finskirt";
                    case 2501:
                        return "Ginger Beard";
                    case 2502:
                        return "Honeyed Goggles";
                    case 2503:
                        return "Boreal Wood";
                    case 2504:
                        return "Palm Wood";
                    case 2505:
                        return "Boreal Wood Wall";
                    case 2506:
                        return "Palm Wood Wall";
                    case 2507:
                        return "Boreal Wood Fence";
                    case 2508:
                        return "Palm Wood Fence";
                    case 2509:
                        return "Boreal Wood Helmet";
                    case 2510:
                        return "Boreal Wood Breastplate";
                    case 2511:
                        return "Boreal Wood Greaves";
                    case 2512:
                        return "Palm Wood Helmet";
                    case 2513:
                        return "Palm Wood Breastplate";
                    case 2514:
                        return "Palm Wood Greaves";
                    case 2515:
                        return "Palm Wood Bow";
                    case 2516:
                        return "Palm Wood Hammer";
                    case 2517:
                        return "Palm Wood Sword";
                    case 2518:
                        return "Palm Wood Platform";
                    case 2519:
                        return "Palm Wood Bathtub";
                    case 2520:
                        return "Palm Wood Bed";
                    case 2521:
                        return "Palm Wood Bench";
                    case 2522:
                        return "Palm Wood Candelabra";
                    case 2523:
                        return "Palm Wood Candle";
                    case 2524:
                        return "Palm Wood Chair";
                    case 2525:
                        return "Palm Wood Chandelier";
                    case 2526:
                        return "Palm Wood Chest";
                    case 2527:
                        return "Palm Wood Sofa";
                    case 2528:
                        return "Palm Wood Door";
                    case 2529:
                        return "Palm Wood Dresser";
                    case 2530:
                        return "Palm Wood Lantern";
                    case 2531:
                        return "Palm Wood Piano";
                    case 2532:
                        return "Palm Wood Table";
                    case 2533:
                        return "Palm Wood Lamp";
                    case 2534:
                        return "Palm Wood Work Bench";
                    case 2535:
                        return "Optic Staff";
                    case 2536:
                        return "Palm Wood Bookcase";
                    case 2537:
                        return "Mushroom Bathtub";
                    case 2538:
                        return "Mushroom Bed";
                    case 2539:
                        return "Mushroom Bench";
                    case 2540:
                        return "Mushroom Bookcase";
                    case 2541:
                        return "Mushroom Candelabra";
                    case 2542:
                        return "Mushroom Candle";
                    case 2543:
                        return "Mushroom Chandelier";
                    case 2544:
                        return "Mushroom Chest";
                    case 2545:
                        return "Mushroom Dresser";
                    case 2546:
                        return "Mushroom Lantern";
                    case 2547:
                        return "Mushroom Lamp";
                    case 2548:
                        return "Mushroom Piano";
                    case 2549:
                        return "Mushroom Platform";
                    case 2550:
                        return "Mushroom Table";
                    case 2551:
                        return "Spider Staff";
                    case 2552:
                        return "Boreal Wood Bathtub";
                    case 2553:
                        return "Boreal Wood Bed";
                    case 2554:
                        return "Boreal Wood Bookcase";
                    case 2555:
                        return "Boreal Wood Candelabra";
                    case 2556:
                        return "Boreal Wood Candle";
                    case 2557:
                        return "Boreal Wood Chair";
                    case 2558:
                        return "Boreal Wood Chandelier";
                    case 2559:
                        return "Boreal Wood Chest";
                    case 2560:
                        return "Boreal Wood Clock";
                    case 2561:
                        return "Boreal Wood Door";
                    case 2562:
                        return "Boreal Wood Dresser";
                    case 2563:
                        return "Boreal Wood Lamp";
                    case 2564:
                        return "Boreal Wood Lantern";
                    case 2565:
                        return "Boreal Wood Piano";
                    case 2566:
                        return "Boreal Wood Platform";
                    case 2567:
                        return "Slime Bathtub";
                    case 2568:
                        return "Slime Bed";
                    case 2569:
                        return "Slime Bookcase";
                    case 2570:
                        return "Slime Candelabra";
                    case 2571:
                        return "Slime Candle";
                    case 2572:
                        return "Slime Chair";
                    case 2573:
                        return "Slime Chandelier";
                    case 2574:
                        return "Slime Chest";
                    case 2575:
                        return "Slime Clock";
                    case 2576:
                        return "Slime Door";
                    case 2577:
                        return "Slime Dresser";
                    case 2578:
                        return "Slime Lamp";
                    case 2579:
                        return "Slime Lantern";
                    case 2580:
                        return "Slime Piano";
                    case 2581:
                        return "Slime Platform";
                    case 2582:
                        return "Slime Sofa";
                    case 2583:
                        return "Slime Table";
                    case 2584:
                        return "Pirate Staff";
                    case 2585:
                        return "Slime Hook";
                    case 2586:
                        return "Sticky Grenade";
                    case 2587:
                        return "Tartar Sauce";
                    case 2588:
                        return "Duke Fishron Mask";
                    case 2589:
                        return "Duke Fishron Trophy";
                    case 2590:
                        return "Molotov Cocktail";
                    case 2591:
                        return "Bone Clock";
                    case 2592:
                        return "Cactus Clock";
                    case 2593:
                        return "Ebonwood Clock";
                    case 2594:
                        return "Frozen Clock";
                    case 2595:
                        return "Lihzahrd Clock";
                    case 2596:
                        return "Living Wood Clock";
                    case 2597:
                        return "Rich Mahogany Clock";
                    case 2598:
                        return "Flesh Clock";
                    case 2599:
                        return "Mushroom Clock";
                    case 2600:
                        return "Obsidian Clock";
                    case 2601:
                        return "Palm Wood Clock";
                    case 2602:
                        return "Pearlwood Clock";
                    case 2603:
                        return "Pumpkin Clock";
                    case 2604:
                        return "Shadewood Clock";
                    case 2605:
                        return "Spooky Clock";
                    case 2606:
                        return "Skyware Clock";
                    case 2607:
                        return "Spider Fang";
                    case 2608:
                        return "Falcon Blade";
                    case 2609:
                        return "Fishron Wings";
                    case 2610:
                        return "Slime Gun";
                    case 2611:
                        return "Flairon";
                    case 2612:
                        return "Green Dungeon Chest";
                    case 2613:
                        return "Pink Dungeon Chest";
                    case 2614:
                        return "Blue Dungeon Chest";
                    case 2615:
                        return "Bone Chest";
                    case 2616:
                        return "Cactus Chest";
                    case 2617:
                        return "Flesh Chest";
                    case 2618:
                        return "Obsidian Chest";
                    case 2619:
                        return "Pumpkin Chest";
                    case 2620:
                        return "Spooky Chest";
                    case 2621:
                        return "Tempest Staff";
                    case 2622:
                        return "Razorblade Typhoon";
                    case 2623:
                        return "Bubble Gun";
                    case 2624:
                        return "Tsunami";
                    case 2625:
                        return "Seashell";
                    case 2626:
                        return "Starfish";
                    case 2627:
                        return "Steampunk Platform";
                    case 2628:
                        return "Skyware Platform";
                    case 2629:
                        return "Living Wood Platform";
                    case 2630:
                        return "Honey Platform";
                    case 2631:
                        return "Skyware Work Bench";
                    case 2632:
                        return "Glass Work Bench";
                    case 2633:
                        return "Living Wood Work Bench";
                    case 2634:
                        return "Flesh Sofa";
                    case 2635:
                        return "Frozen Sofa";
                    case 2636:
                        return "Living Wood Sofa";
                    case 2637:
                        return "Pumpkin Dresser";
                    case 2638:
                        return "Steampunk Dresser";
                    case 2639:
                        return "Glass Dresser";
                    case 2640:
                        return "Flesh Dresser";
                    case 2641:
                        return "Pumpkin Lantern";
                    case 2642:
                        return "Obsidian Lantern";
                    case 2643:
                        return "Pumpkin Lamp";
                    case 2644:
                        return "Obsidian Lamp";
                    case 2645:
                        return "Blue Dungeon Lamp";
                    case 2646:
                        return "Green Dungeon Lamp";
                    case 2647:
                        return "Pink Dungeon Lamp";
                    case 2648:
                        return "Honey Candle";
                    case 2649:
                        return "Steampunk Candle";
                    case 2650:
                        return "Spooky Candle";
                    case 2651:
                        return "Obsidian Candle";
                    case 2652:
                        return "Blue Dungeon Chandelier";
                    case 2653:
                        return "Green Dungeon Chandelier";
                    case 2654:
                        return "Pink Dungeon Chandelier";
                    case 2655:
                        return "Steampunk Chandelier";
                    case 2656:
                        return "Pumpkin Chandelier";
                    case 2657:
                        return "Obsidian Chandelier";
                    case 2658:
                        return "Blue Dungeon Bathtub";
                    case 2659:
                        return "Green Dungeon Bathtub";
                    case 2660:
                        return "Pink Dungeon Bathtub";
                    case 2661:
                        return "Pumpkin Bathtub";
                    case 2662:
                        return "Obsidian Bathtub";
                    case 2663:
                        return "Golden Bathtub";
                    case 2664:
                        return "Blue Dungeon Candelabra";
                    case 2665:
                        return "Green Dungeon Candelabra";
                    case 2666:
                        return "Pink Dungeon Candelabra";
                    case 2667:
                        return "Obsidian Candelabra";
                    case 2668:
                        return "Pumpkin Candelabra";
                    case 2669:
                        return "Pumpkin Bed";
                    case 2670:
                        return "Pumpkin Bookcase";
                    case 2671:
                        return "Pumpkin Piano";
                    case 2672:
                        return "Shark Statue";
                    case 2673:
                        return "Truffle Worm";
                    case 2674:
                        return "Apprentice Bait";
                    case 2675:
                        return "Journeyman Bait";
                    case 2676:
                        return "Master Bait";
                    case 2677:
                        return "Amber Gemspark Wall";
                    case 2678:
                        return "Offline Amber Gemspark Wall";
                    case 2679:
                        return "Amethyst Gemspark Wall";
                    case 2680:
                        return "Offline Amethyst Gemspark Wall";
                    case 2681:
                        return "Diamond Gemspark Wall";
                    case 2682:
                        return "Offline Diamond Gemspark Wall";
                    case 2683:
                        return "Emerald Gemspark Wall";
                    case 2684:
                        return "Offline Emerald Gemspark Wall";
                    case 2685:
                        return "Ruby Gemspark Wall";
                    case 2686:
                        return "Offline Ruby Gemspark Wall";
                    case 2687:
                        return "Sapphire Gemspark Wall";
                    case 2688:
                        return "Offline Sapphire Gemspark Wall";
                    case 2689:
                        return "Topaz Gemspark Wall";
                    case 2690:
                        return "Offline Topaz Gemspark Wall";
                    case 2691:
                        return "Tin Plating Wall";
                    case 2692:
                        return "Tin Plating";
                    case 2693:
                        return "Waterfall Block";
                    case 2694:
                        return "Lavafall Block";
                    case 2695:
                        return "Confetti Block";
                    case 2696:
                        return "Confetti Wall";
                    case 2697:
                        return "Midnight Confetti Block";
                    case 2698:
                        return "Midnight Confetti Wall";
                    case 2699:
                        return "Weapon Rack";
                    case 2700:
                        return "Fireworks Box";
                    case 2701:
                        return "Living Fire Block";
                    case 2702:
                        return "'0' Statue";
                    case 2703:
                        return "'1' Statue";
                    case 2704:
                        return "'2' Statue";
                    case 2705:
                        return "'3' Statue";
                    case 2706:
                        return "'4' Statue";
                    case 2707:
                        return "'5' Statue";
                    case 2708:
                        return "'6' Statue";
                    case 2709:
                        return "'7' Statue";
                    case 2710:
                        return "'8' Statue";
                    case 2711:
                        return "'9' Statue";
                    case 2712:
                        return "'A' Statue";
                    case 2713:
                        return "'B' Statue";
                    case 2714:
                        return "'C' Statue";
                    case 2715:
                        return "'D' Statue";
                    case 2716:
                        return "'E' Statue";
                    case 2717:
                        return "'F' Statue";
                    case 2718:
                        return "'G' Statue";
                    case 2719:
                        return "'H' Statue";
                    case 2720:
                        return "'I' Statue";
                    case 2721:
                        return "'J' Statue";
                    case 2722:
                        return "'K' Statue";
                    case 2723:
                        return "'L' Statue";
                    case 2724:
                        return "'M' Statue";
                    case 2725:
                        return "'N' Statue";
                    case 2726:
                        return "'O' Statue";
                    case 2727:
                        return "'P' Statue";
                    case 2728:
                        return "'Q' Statue";
                    case 2729:
                        return "'R' Statue";
                    case 2730:
                        return "'S' Statue";
                    case 2731:
                        return "'T' Statue";
                    case 2732:
                        return "'U' Statue";
                    case 2733:
                        return "'V' Statue";
                    case 2734:
                        return "'W' Statue";
                    case 2735:
                        return "'X' Statue";
                    case 2736:
                        return "'Y' Statue";
                    case 2737:
                        return "'Z' Statue";
                    case 2738:
                        return "Firework Fountain";
                    case 2739:
                        return "Booster Track";
                    case 2740:
                        return "Grasshopper";
                    case 2741:
                        return "Grasshopper Cage";
                    case 2742:
                        return "Music Box (Underground Crimson)";
                    case 2743:
                        return "Cactus Table";
                    case 2744:
                        return "Cactus Platform";
                    case 2745:
                        return "Boreal Wood Sword";
                    case 2746:
                        return "Boreal Wood Hammer";
                    case 2747:
                        return "Boreal Wood Bow";
                    case 2748:
                        return "Glass Chest";
                    case 2749:
                        return "Xeno Staff";
                    case 2750:
                        return "Meteor Staff";
                    case 2751:
                        return "Living Cursed Fire Block";
                    case 2752:
                        return "Living Demon Fire Block";
                    case 2753:
                        return "Living Frost Fire Block";
                    case 2754:
                        return "Living Ichor Block";
                    case 2755:
                        return "Living Ultrabright Fire Block";
                    case 2756:
                        return "Gender Change Potion";
                    case 2757:
                        return "Vortex Helmet";
                    case 2758:
                        return "Vortex Breastplate";
                    case 2759:
                        return "Vortex Leggings";
                    case 2760:
                        return "Nebula Helmet";
                    case 2761:
                        return "Nebula Breastplate";
                    case 2762:
                        return "Nebula Leggings";
                    case 2763:
                        return "Solar Flare Helmet";
                    case 2764:
                        return "Solar Flare Breastplate";
                    case 2765:
                        return "Solar Flare Leggings";
                    case 2766:
                        return "Solar Tablet Fragment";
                    case 2767:
                        return "Solar Tablet";
                    case 2768:
                        return "Drill Containment Unit";
                    case 2769:
                        return "Cosmic Car Key";
                    case 2770:
                        return "Mothron Wings";
                    case 2771:
                        return "Brain Scrambler";
                    case 2772:
                        return "Vortex Axe";
                    case 2773:
                        return "Vortex Chainsaw";
                    case 2774:
                        return "Vortex Drill";
                    case 2775:
                        return "Vortex Hammer";
                    case 2776:
                        return "Vortex Pickaxe";
                    case 2777:
                        return "Nebula Axe";
                    case 2778:
                        return "Nebula Chainsaw";
                    case 2779:
                        return "Nebula Drill";
                    case 2780:
                        return "Nebula Hammer";
                    case 2781:
                        return "Nebula Pickaxe";
                    case 2782:
                        return "Solar Flare Axe";
                    case 2783:
                        return "Solar Flare Chainsaw";
                    case 2784:
                        return "Solar Flare Drill";
                    case 2785:
                        return "Solar Flare Hammer";
                    case 2786:
                        return "Solar Flare Pickaxe";
                    case 2787:
                        return "Honeyfall Block";
                    case 2788:
                        return "Honeyfall Wall";
                    case 2789:
                        return "Chlorophyte Brick Wall";
                    case 2790:
                        return "Crimtane Brick Wall";
                    case 2791:
                        return "Shroomite Plating Wall";
                    case 2792:
                        return "Chlorophyte Brick";
                    case 2793:
                        return "Crimtane Brick";
                    case 2794:
                        return "Shroomite Plating";
                    case 2795:
                        return "Laser Machinegun";
                    case 2796:
                        return "Electrosphere Launcher";
                    case 2797:
                        return "Xenopopper";
                    case 2798:
                        return "Laser Drill";
                    case 2799:
                        return "Mechanical Ruler";
                    case 2800:
                        return "Anti-Gravity Hook";
                    case 2801:
                        return "Moon Mask";
                    case 2802:
                        return "Sun Mask";
                    case 2803:
                        return "Martian Costume Mask";
                    case 2804:
                        return "Martian Costume Shirt";
                    case 2805:
                        return "Martian Costume Pants";
                    case 2806:
                        return "Martian Uniform Helmet";
                    case 2807:
                        return "Martian Uniform Torso";
                    case 2808:
                        return "Martian Uniform Pants";
                    case 2809:
                        return "Martian Astro Clock";
                    case 2810:
                        return "Martian Bathtub";
                    case 2811:
                        return "Martian Bed";
                    case 2812:
                        return "Martian Hover Chair";
                    case 2813:
                        return "Martian Chandelier";
                    case 2814:
                        return "Martian Chest";
                    case 2815:
                        return "Martian Door";
                    case 2816:
                        return "Martian Dresser";
                    case 2817:
                        return "Martian Holobookcase";
                    case 2818:
                        return "Martian Hover Candle";
                    case 2819:
                        return "Martian Lamppost";
                    case 2820:
                        return "Martian Lantern";
                    case 2821:
                        return "Martian Piano";
                    case 2822:
                        return "Martian Platform";
                    case 2823:
                        return "Martian Sofa";
                    case 2824:
                        return "Martian Table";
                    case 2825:
                        return "Martian Table Lamp";
                    case 2826:
                        return "Martian Work Bench";
                    case 2827:
                        return "Wooden Sink";
                    case 2828:
                        return "Ebonwood Sink";
                    case 2829:
                        return "Rich Mahogany Sink";
                    case 2830:
                        return "Pearlwood Sink";
                    case 2831:
                        return "Bone Sink";
                    case 2832:
                        return "Flesh Sink";
                    case 2833:
                        return "Living Wood Sink";
                    case 2834:
                        return "Skyware Sink";
                    case 2835:
                        return "Shadewood Sink";
                    case 2836:
                        return "Lihzahrd Sink";
                    case 2837:
                        return "Blue Dungeon Sink";
                    case 2838:
                        return "Green Dungeon Sink";
                    case 2839:
                        return "Pink Dungeon Sink";
                    case 2840:
                        return "Obsidian Sink";
                    case 2841:
                        return "Metal Sink";
                    case 2842:
                        return "Glass Sink";
                    case 2843:
                        return "Golden Sink";
                    case 2844:
                        return "Honey Sink";
                    case 2845:
                        return "Steampunk Sink";
                    case 2846:
                        return "Pumpkin Sink";
                    case 2847:
                        return "Spooky Sink";
                    case 2848:
                        return "Frozen Sink";
                    case 2849:
                        return "Dynasty Sink";
                    case 2850:
                        return "Palm Wood Sink";
                    case 2851:
                        return "Mushroom Sink";
                    case 2852:
                        return "Boreal Wood Sink";
                    case 2853:
                        return "Slime Sink";
                    case 2854:
                        return "Cactus Sink";
                    case 2855:
                        return "Martian Sink";
                    case 2856:
                        return "Solar Cultist Hood";
                    case 2857:
                        return "Lunar Cultist Hood";
                    case 2858:
                        return "Solar Cultist Robe";
                    case 2859:
                        return "Lunar Cultist Robe";
                    case 2860:
                        return "Martian Conduit Plating";
                    case 2861:
                        return "Martian Conduit Wall";
                    case 2862:
                        return "HiTek Sunglasses";
                    case 2863:
                        return "Martian Hair Dye";
                    case 2864:
                        return "Martian Dye";
                    case 2865:
                        return "Castle Marsberg";
                    case 2866:
                        return "Martia Lisa";
                    case 2867:
                        return "The Truth Is Up There";
                    case 2868:
                        return "Smoke Block";
                    case 2869:
                        return "Living Flame Dye";
                    case 2870:
                        return "Living Rainbow Dye";
                    case 2871:
                        return "Shadow Dye";
                    case 2872:
                        return "Negative Dye";
                    case 2873:
                        return "Living Ocean Dye";
                    case 2874:
                        return "Brown Dye";
                    case 2875:
                        return "Brown and Black Dye";
                    case 2876:
                        return "Bright Brown Dye";
                    case 2877:
                        return "Brown and Silver Dye";
                    case 2878:
                        return "Wisp Dye";
                    case 2879:
                        return "Pixie Dye";
                    case 2880:
                        return "Influx Waver";
                    case 2881:
                        return "Phasic Warp Ejector";
                    case 2882:
                        return "Charged Blaster Cannon";
                    case 2883:
                        return "Chlorophyte Dye";
                    case 2884:
                        return "Unicorn Wisp Dye";
                    case 2885:
                        return "Infernal Wisp Dye";
                    case 2886:
                        return "Vicious Powder";
                    case 2887:
                        return "Vicious Mushroom";
                    case 2888:
                        return "The Bee's Knees";
                    case 2889:
                        return "Gold Bird";
                    case 2890:
                        return "Gold Bunny";
                    case 2891:
                        return "Gold Butterfly";
                    case 2892:
                        return "Gold Frog";
                    case 2893:
                        return "Gold Grasshopper";
                    case 2894:
                        return "Gold Mouse";
                    case 2895:
                        return "Gold Worm";
                    case 2896:
                        return "Sticky Dynamite";
                    case 2897:
                        return "Angry Trapper Banner";
                    case 2898:
                        return "Armored Viking Banner";
                    case 2899:
                        return "Black Slime Banner";
                    case 2900:
                        return "Blue Armored Bones Banner";
                    case 2901:
                        return "Blue Cultist Archer Banner";
                    case 2902:
                        return "Blue Cultist Caster Banner";
                    case 2903:
                        return "Blue Cultist Fighter Banner";
                    case 2904:
                        return "Bone Lee Banner";
                    case 2905:
                        return "Clinger Banner";
                    case 2906:
                        return "Cochineal Beetle Banner";
                    case 2907:
                        return "Corrupt Penguin Banner";
                    case 2908:
                        return "Corrupt Slime Banner";
                    case 2909:
                        return "Corruptor Banner";
                    case 2910:
                        return "Crimslime Banner";
                    case 2911:
                        return "Cursed Skull Banner";
                    case 2912:
                        return "Cyan Beetle Banner";
                    case 2913:
                        return "Devourer Banner";
                    case 2914:
                        return "Diabolist Banner";
                    case 2915:
                        return "Doctor Bones Banner";
                    case 2916:
                        return "Dungeon Slime Banner";
                    case 2917:
                        return "Dungeon Spirit Banner";
                    case 2918:
                        return "Elf Archer Banner";
                    case 2919:
                        return "Elf Copter Banner";
                    case 2920:
                        return "Eyezor Banner";
                    case 2921:
                        return "Flocko Banner";
                    case 2922:
                        return "Ghost Banner";
                    case 2923:
                        return "Giant Bat Banner";
                    case 2924:
                        return "Giant Cursed Skull Banner";
                    case 2925:
                        return "Giant Flying Fox Banner";
                    case 2926:
                        return "Gingerbread Man Banner";
                    case 2927:
                        return "Goblin Archer Banner";
                    case 2928:
                        return "Green Slime Banner";
                    case 2929:
                        return "Headless Horseman Banner";
                    case 2930:
                        return "Hell Armored Bones Banner";
                    case 2931:
                        return "Hellhound Banner";
                    case 2932:
                        return "Hoppin' Jack Banner";
                    case 2933:
                        return "Ice Bat Banner";
                    case 2934:
                        return "Ice Golem Banner";
                    case 2935:
                        return "Ice Slime Banner";
                    case 2936:
                        return "Ichor Sticker Banner";
                    case 2937:
                        return "Illuminant Bat Banner";
                    case 2938:
                        return "Illuminant Slime Banner";
                    case 2939:
                        return "Jungle Bat Banner";
                    case 2940:
                        return "Jungle Slime Banner";
                    case 2941:
                        return "Krampus Banner";
                    case 2942:
                        return "Lac Beetle Banner";
                    case 2943:
                        return "Lava Bat Banner";
                    case 2944:
                        return "Lava Slime Banner";
                    case 2945:
                        return "Martian Brainscrambler Banner";
                    case 2946:
                        return "Martian Drone Banner";
                    case 2947:
                        return "Martian Engineer Banner";
                    case 2948:
                        return "Martian Gigazapper Banner";
                    case 2949:
                        return "Martian Gray Grunt Banner";
                    case 2950:
                        return "Martian Officer Banner";
                    case 2951:
                        return "Martian Ray Gunner Banner";
                    case 2952:
                        return "Martian Scutlix Gunner Banner";
                    case 2953:
                        return "Martian Tesla Turret Banner";
                    case 2954:
                        return "Mister Stabby Banner";
                    case 2955:
                        return "Mother Slime Banner";
                    case 2956:
                        return "Necromancer Banner";
                    case 2957:
                        return "Nutcracker Banner";
                    case 2958:
                        return "Paladin Banner";
                    case 2959:
                        return "Penguin Banner";
                    case 2960:
                        return "Pinky Banner";
                    case 2961:
                        return "Poltergeist Banner";
                    case 2962:
                        return "Possessed Armor Banner";
                    case 2963:
                        return "Present Mimic Banner";
                    case 2964:
                        return "Purple Slime Banner";
                    case 2965:
                        return "Ragged Caster Banner";
                    case 2966:
                        return "Rainbow Slime Banner";
                    case 2967:
                        return "Raven Banner";
                    case 2968:
                        return "Red Slime Banner";
                    case 2969:
                        return "Rune Wizard Banner";
                    case 2970:
                        return "Rusty Armored Bones Banner";
                    case 2971:
                        return "Scarecrow Banner";
                    case 2972:
                        return "Scutlix Banner";
                    case 2973:
                        return "Skeleton Archer Banner";
                    case 2974:
                        return "Skeleton Commando Banner";
                    case 2975:
                        return "Skeleton Sniper Banner";
                    case 2976:
                        return "Slimer Banner";
                    case 2977:
                        return "Snatcher Banner";
                    case 2978:
                        return "Snow Balla Banner";
                    case 2979:
                        return "Snowman Gangsta Banner";
                    case 2980:
                        return "Spiked Ice Slime Banner";
                    case 2981:
                        return "Spiked Jungle Slime Banner";
                    case 2982:
                        return "Splinterling Banner";
                    case 2983:
                        return "Squid Banner";
                    case 2984:
                        return "Tactical Skeleton Banner";
                    case 2985:
                        return "The Groom Banner";
                    case 2986:
                        return "Tim Banner";
                    case 2987:
                        return "Undead Miner Banner";
                    case 2988:
                        return "Undead Viking Banner";
                    case 2989:
                        return "White Cultist Archer Banner";
                    case 2990:
                        return "White Cultist Caster Banner";
                    case 2991:
                        return "White Cultist Fighter Banner";
                    case 2992:
                        return "Yellow Slime Banner";
                    case 2993:
                        return "Yeti Banner";
                    case 2994:
                        return "Zombie Elf Banner";
                    case 2995:
                        return "Sparky";
                    case 2996:
                        return "Vine Rope";
                    case 2997:
                        return "Wormhole Potion";
                    case 2998:
                        return "Summoner Emblem";
                    case 2999:
                        return "Bewitching Table";
                    case 3000:
                        return "Alchemy Table";
                    case 3001:
                        return "Strange Brew";
                    case 3002:
                        return "Spelunker Glowstick";
                    case 3003:
                        return "Bone Arrow";
                    case 3004:
                        return "Bone Torch";
                    case 3005:
                        return "Vine Rope Coil";
                    case 3006:
                        return "Life Drain";
                    case 3007:
                        return "Dart Pistol";
                    case 3008:
                        return "Dart Rifle";
                    case 3009:
                        return "Crystal Dart";
                    case 3010:
                        return "Cursed Dart";
                    case 3011:
                        return "Ichor Dart";
                    case 3012:
                        return "Chain Guillotines";
                    case 3013:
                        return "Fetid Baghnakhs";
                    case 3014:
                        return "Clinger Staff";
                    case 3015:
                        return "Putrid Scent";
                    case 3016:
                        return "Flesh Knuckles";
                    case 3017:
                        return "Flower Boots";
                    case 3018:
                        return "Seedler";
                    case 3019:
                        return "Hellwing Bow";
                    case 3020:
                        return "Tendon Hook";
                    case 3021:
                        return "Thorn Hook";
                    case 3022:
                        return "Illuminant Hook";
                    case 3023:
                        return "Worm Hook";
                    case 3024:
                        return "Skiphs's Blood";
                    case 3025:
                        return "Purple Ooze Dye";
                    case 3026:
                        return "Reflective Silver Dye";
                    case 3027:
                        return "Reflective Gold Dye";
                    case 3028:
                        return "Blue Acid Dye";
                    case 3029:
                        return "Daedalus Stormbow";
                    case 3030:
                        return "Flying Knife";
                    case 3031:
                        return "Bottomless Water Bucket";
                    case 3032:
                        return "Super Absorbant Sponge";
                    case 3033:
                        return "Gold Ring";
                    case 3034:
                        return "Coin Ring";
                    case 3035:
                        return "Greedy Ring";
                    case 3036:
                        return "Fish Finder";
                    case 3037:
                        return "Weather Radio";
                    case 3038:
                        return "Hades Dye";
                    case 3039:
                        return "Twilight Dye";
                    case 3040:
                        return "Acid Dye";
                    case 3041:
                        return "Glowing Mushroom Dye";
                    case 3042:
                        return "Phase Dye";
                    case 3043:
                        return "Magic Lantern";
                    case 3044:
                        return "Music Box (Lunar Boss)";
                    case 3045:
                        return "Rainbow Torch";
                    case 3046:
                        return "Cursed Campfire";
                    case 3047:
                        return "Demon Campfire";
                    case 3048:
                        return "Frozen Campfire";
                    case 3049:
                        return "Ichor Campfire";
                    case 3050:
                        return "Rainbow Campfire";
                    case 3051:
                        return "Crystal Vile Shard";
                    case 3052:
                        return "Shadowflame Bow";
                    case 3053:
                        return "Shadowflame Hex Doll";
                    case 3054:
                        return "Shadowflame Knife";
                    case 3055:
                        return "Acorns";
                    case 3056:
                        return "Cold Snap";
                    case 3057:
                        return "Cursed Saint";
                    case 3058:
                        return "Snowfellas";
                    case 3059:
                        return "The Season";
                    case 3060:
                        return "Bone Rattle";
                    case 3061:
                        return "Architect Gizmo Pack";
                    case 3062:
                        return "Crimson Heart";
                    case 3063:
                        return "Meowmere";
                    case 3064:
                        return "Enchanted Sundial";
                    case 3065:
                        return "Star Wrath";
                    case 3066:
                        return "Smooth Marble Block";
                    case 3067:
                        return "Hellstone Brick Wall";
                    case 3068:
                        return "Guide to Plant Fiber Cordage";
                    case 3069:
                        return "Wand of Sparking";
                    case 3070:
                        return "Gold Bird Cage";
                    case 3071:
                        return "Gold Bunny Cage";
                    case 3072:
                        return "Gold Butterfly Jar";
                    case 3073:
                        return "Gold Frog Cage";
                    case 3074:
                        return "Gold Grasshopper Cage";
                    case 3075:
                        return "Gold Mouse Cage";
                    case 3076:
                        return "Gold Worm Cage";
                    case 3077:
                        return "Silk Rope";
                    case 3078:
                        return "Web Rope";
                    case 3079:
                        return "Silk Rope Coil";
                    case 3080:
                        return "Web Rope Coil";
                    case 3081:
                        return "Marble Block";
                    case 3082:
                        return "Marble Wall";
                    case 3083:
                        return "Smooth Marble Wall";
                    case 3084:
                        return "Radar";
                    case 3085:
                        return "Golden Lock Box";
                    case 3086:
                        return "Granite Block";
                    case 3087:
                        return "Smooth Granite Block";
                    case 3088:
                        return "Granite Wall";
                    case 3089:
                        return "Smooth Granite Wall";
                    case 3090:
                        return "Royal Gel";
                    case 3091:
                        return "Key of Night";
                    case 3092:
                        return "Key of Light";
                    case 3093:
                        return "Herb Bag";
                    case 3094:
                        return "Javelin";
                    case 3095:
                        return "Tally Counter";
                    case 3096:
                        return "Sextant";
                    case 3097:
                        return "Shield of Cthulhu";
                    case 3098:
                        return "Butcher's Chainsaw";
                    case 3099:
                        return "Stopwatch";
                    case 3100:
                        return "Meteorite Brick";
                    case 3101:
                        return "Meteorite Brick Wall";
                    case 3102:
                        return "Metal Detector";
                    case 3103:
                        return "Endless Quiver";
                    case 3104:
                        return "Endless Musket Pouch";
                    case 3105:
                        return "Toxic Flask";
                    case 3106:
                        return "Psycho Knife";
                    case 3107:
                        return "Nail Gun";
                    case 3108:
                        return "Nail";
                    case 3109:
                        return "Night Vision Helmet";
                    case 3110:
                        return "Celestial Shell";
                    case 3111:
                        return "Pink Gel";
                    case 3112:
                        return "Bouncy Glowstick";
                    case 3113:
                        return "Pink Slime Block";
                    case 3114:
                        return "Pink Torch";
                    case 3115:
                        return "Bouncy Bomb";
                    case 3116:
                        return "Bouncy Grenade";
                    case 3117:
                        return "Peace Candle";
                    case 3118:
                        return "Lifeform Analyzer";
                    case 3119:
                        return "DPS Meter";
                    case 3120:
                        return "Fisherman's Pocket Guide";
                    case 3121:
                        return "Goblin Tech";
                    case 3122:
                        return "R.E.K. 3000";
                    case 3123:
                        return "PDA";
                    case 3124:
                        return "Cell Phone";
                    case 3125:
                        return "Granite Chest";
                    case 3126:
                        return "Meteorite Clock";
                    case 3127:
                        return "Marble Clock";
                    case 3128:
                        return "Granite Clock";
                    case 3129:
                        return "Meteorite Door";
                    case 3130:
                        return "Marble Door";
                    case 3131:
                        return "Granite Door";
                    case 3132:
                        return "Meteorite Dresser";
                    case 3133:
                        return "Marble Dresser";
                    case 3134:
                        return "Granite Dresser";
                    case 3135:
                        return "Meteorite Lamp";
                    case 3136:
                        return "Marble Lamp";
                    case 3137:
                        return "Granite Lamp";
                    case 3138:
                        return "Meteorite Lantern";
                    case 3139:
                        return "Marble Lantern";
                    case 3140:
                        return "Granite Lantern";
                    case 3141:
                        return "Meteorite Piano";
                    case 3142:
                        return "Marble Piano";
                    case 3143:
                        return "Granite Piano";
                    case 3144:
                        return "Meteorite Platform";
                    case 3145:
                        return "Marble Platform";
                    case 3146:
                        return "Granite Platform";
                    case 3147:
                        return "Meteorite Sink";
                    case 3148:
                        return "Marble Sink";
                    case 3149:
                        return "Granite Sink";
                    case 3150:
                        return "Meteorite Sofa";
                    case 3151:
                        return "Marble Sofa";
                    case 3152:
                        return "Granite Sofa";
                    case 3153:
                        return "Meteorite Table";
                    case 3154:
                        return "Marble Table";
                    case 3155:
                        return "Granite Table";
                    case 3156:
                        return "Meteorite Work Bench";
                    case 3157:
                        return "Marble Work Bench";
                    case 3158:
                        return "Granite Work Bench";
                    case 3159:
                        return "Meteorite Bathtub";
                    case 3160:
                        return "Marble Bathtub";
                    case 3161:
                        return "Granite Bathtub";
                    case 3162:
                        return "Meteorite Bed";
                    case 3163:
                        return "Marble Bed";
                    case 3164:
                        return "Granite Bed";
                    case 3165:
                        return "Meteorite Bookcase";
                    case 3166:
                        return "Marble Bookcase";
                    case 3167:
                        return "Granite Bookcase";
                    case 3168:
                        return "Meteorite Candelabra";
                    case 3169:
                        return "Marble Candelabra";
                    case 3170:
                        return "Granite Candelabra";
                    case 3171:
                        return "Meteorite Candle";
                    case 3172:
                        return "Marble Candle";
                    case 3173:
                        return "Granite Candle";
                    case 3174:
                        return "Meteorite Chair";
                    case 3175:
                        return "Marble Chair";
                    case 3176:
                        return "Granite Chair";
                    case 3177:
                        return "Meteorite Chandelier";
                    case 3178:
                        return "Marble Chandelier";
                    case 3179:
                        return "Granite Chandelier";
                    case 3180:
                        return "Meteorite Chest";
                    case 3181:
                        return "Marble Chest";
                    case 3182:
                        return "Magic Water Dropper";
                    case 3183:
                        return "Golden Bug Net";
                    case 3184:
                        return "Magic Lava Dropper";
                    case 3185:
                        return "Magic Honey Dropper";
                    case 3186:
                        return "Empty Dropper";
                    case 3187:
                        return "Gladiator Helmet";
                    case 3188:
                        return "Gladiator Breastplate";
                    case 3189:
                        return "Gladiator Leggings";
                    case 3190:
                        return "Reflective Dye";
                    case 3191:
                        return "Enchanted Nightcrawler";
                    case 3192:
                        return "Grubby";
                    case 3193:
                        return "Sluggy";
                    case 3194:
                        return "Buggy";
                    case 3195:
                        return "Grub Soup";
                    case 3196:
                        return "Bomb Fish";
                    case 3197:
                        return "Frost Daggerfish";
                    case 3198:
                        return "Sharpening Station";
                    case 3199:
                        return "Ice Mirror";
                    case 3200:
                        return "Sailfish Boots";
                    case 3201:
                        return "Tsunami in a Bottle";
                    case 3202:
                        return "Target Dummy";
                    case 3203:
                        return "Corrupt Crate";
                    case 3204:
                        return "Crimson Crate";
                    case 3205:
                        return "Dungeon Crate";
                    case 3206:
                        return "Sky Crate";
                    case 3207:
                        return "Hallowed Crate";
                    case 3208:
                        return "Jungle Crate";
                    case 3209:
                        return "Crystal Serpent";
                    case 3210:
                        return "Toxikarp";
                    case 3211:
                        return "Bladetongue";
                    case 3212:
                        return "Shark Tooth Necklace";
                    case 3213:
                        return "Money Trough";
                    case 3214:
                        return "Bubble";
                    case 3215:
                        return "Daybloom Planter Box";
                    case 3216:
                        return "Moonglow Planter Box";
                    case 3217:
                        return "Deathweed Planter Box";
                    case 3218:
                        return "Deathweed Planter Box";
                    case 3219:
                        return "Blinkroot Planter Box";
                    case 3220:
                        return "Waterleaf Planter Box";
                    case 3221:
                        return "Shiverthorn Planter Box";
                    case 3222:
                        return "Fireblossom Planter Box";
                    case 3223:
                        return "Brain of Confusion";
                    case 3224:
                        return "Worm Scarf";
                    case 3225:
                        return "Balloon Pufferfish";
                    case 3226:
                        return "Lazure's Valkyrie Circlet";
                    case 3227:
                        return "Lazure's Valkyrie Cloak";
                    case 3228:
                        return "Lazure's Barrier Platform";
                    case 3229:
                        return "Golden Cross Grave Marker";
                    case 3230:
                        return "Golden Tombstone";
                    case 3231:
                        return "Golden Grave Marker";
                    case 3232:
                        return "Golden Gravestone";
                    case 3233:
                        return "Golden Headstone";
                    case 3234:
                        return "Crystal Block";
                    case 3235:
                        return "Music Box (Martian Madness)";
                    case 3236:
                        return "Music Box (Pirate Invasion)";
                    case 3237:
                        return "Music Box (Hell)";
                    case 3238:
                        return "Crystal Block Wall";
                    case 3239:
                        return "Trap Door";
                    case 3240:
                        return "Tall Gate";
                    case 3241:
                        return "Sharkron Balloon";
                    case 3242:
                        return "Tax Collector's Hat";
                    case 3243:
                        return "Tax Collector's Suit";
                    case 3244:
                        return "Tax Collector's Pants";
                    case 3245:
                        return "Bone Glove";
                    case 3246:
                        return "Clothier's Jacket";
                    case 3247:
                        return "Clothier's Pants";
                    case 3248:
                        return "Dye Trader's Turban";
                    case 3249:
                        return "Deadly Sphere Staff";
                    case 3250:
                        return "Green Horseshoe Balloon";
                    case 3251:
                        return "Amber Horseshoe Balloon";
                    case 3252:
                        return "Pink Horseshoe Balloon";
                    case 3253:
                        return "Lava Lamp";
                    case 3254:
                        return "Enchanted Nightcrawler Cage";
                    case 3255:
                        return "Buggy Cage";
                    case 3256:
                        return "Grubby Cage";
                    case 3257:
                        return "Sluggy Cage";
                    case 3258:
                        return "Slap Hand";
                    case 3259:
                        return "Twilight Hair Dye";
                    case 3260:
                        return "Blessed Apple";
                    case 3261:
                        return "Spectre Bar";
                    case 3262:
                        return "Code 1";
                    case 3263:
                        return "Buccaneer Bandana";
                    case 3264:
                        return "Buccaneer Tunic";
                    case 3265:
                        return "Buccaneer Pantaloons";
                    case 3266:
                        return "Obsidian Outlaw Hat";
                    case 3267:
                        return "Obsidian Longcoat";
                    case 3268:
                        return "Obsidian Pants";
                    case 3269:
                        return "Medusa Head";
                    case 3270:
                        return "Item Frame";
                    case 3271:
                        return "Sandstone Block";
                    case 3272:
                        return "Hardened Sand Block";
                    case 3273:
                        return "Sandstone Wall";
                    case 3274:
                        return "Hardened Ebonsand Block";
                    case 3275:
                        return "Hardened Crimsand Block";
                    case 3276:
                        return "Ebonsandstone Block";
                    case 3277:
                        return "Crimsandstone Block";
                    case 3278:
                        return "Wooden Yoyo";
                    case 3279:
                        return "Malaise";
                    case 3280:
                        return "Artery";
                    case 3281:
                        return "Amazon";
                    case 3282:
                        return "Cascade";
                    case 3283:
                        return "Chik";
                    case 3284:
                        return "Code 2";
                    case 3285:
                        return "Rally";
                    case 3286:
                        return "Yelets";
                    case 3287:
                        return "Red's Throw";
                    case 3288:
                        return "Valkyrie Yoyo";
                    case 3289:
                        return "Amarok";
                    case 3290:
                        return "Hel-Fire";
                    case 3291:
                        return "Kraken";
                    case 3292:
                        return "The Eye of Cthulhu";
                    case 3293:
                        return "Red String";
                    case 3294:
                        return "Orange String";
                    case 3295:
                        return "Yellow String";
                    case 3296:
                        return "Lime String";
                    case 3297:
                        return "Green String";
                    case 3298:
                        return "Teal String";
                    case 3299:
                        return "Cyan String";
                    case 3300:
                        return "Sky Blue String";
                    case 3301:
                        return "Blue String";
                    case 3302:
                        return "Purple String";
                    case 3303:
                        return "Violet String";
                    case 3304:
                        return "Pink String";
                    case 3305:
                        return "Brown String";
                    case 3306:
                        return "White String";
                    case 3307:
                        return "Rainbow String";
                    case 3308:
                        return "Black String";
                    case 3309:
                        return "Black Counterweight";
                    case 3310:
                        return "Blue Counterweight";
                    case 3311:
                        return "Green Counterweight";
                    case 3312:
                        return "Purple Counterweight";
                    case 3313:
                        return "Red Counterweight";
                    case 3314:
                        return "Yellow Counterweight";
                    case 3315:
                        return "Format:C";
                    case 3316:
                        return "Gradient";
                    case 3317:
                        return "Valor";
                    case 3318:
                        return "Treasure Bag";
                    case 3319:
                        return "Treasure Bag";
                    case 3320:
                        return "Treasure Bag";
                    case 3321:
                        return "Treasure Bag";
                    case 3322:
                        return "Treasure Bag";
                    case 3323:
                        return "Treasure Bag";
                    case 3324:
                        return "Treasure Bag";
                    case 3325:
                        return "Treasure Bag";
                    case 3326:
                        return "Treasure Bag";
                    case 3327:
                        return "Treasure Bag";
                    case 3328:
                        return "Treasure Bag";
                    case 3329:
                        return "Treasure Bag";
                    case 3330:
                        return "Treasure Bag";
                    case 3331:
                        return "Treasure Bag";
                    case 3332:
                        return "Treasure Bag";
                    case 3333:
                        return "Hive Pack";
                    case 3334:
                        return "Yoyo Glove";
                    case 3335:
                        return "Demon Heart";
                    case 3336:
                        return "Spore Sac";
                    case 3337:
                        return "Shiny Stone";
                    case 3338:
                        return "Hardened Pearlsand Block";
                    case 3339:
                        return "Pearlsandstone Block";
                    case 3340:
                        return "Hardened Sand Wall";
                    case 3341:
                        return "Hardened Ebonsand Wall";
                    case 3342:
                        return "Hardened Crimsand Wall";
                    case 3343:
                        return "Hardened Pearlsand Wall";
                    case 3344:
                        return "Ebonsandstone Wall";
                    case 3345:
                        return "Crimsandstone Wall";
                    case 3346:
                        return "Pearlsandstone Wall";
                    case 3347:
                        return "Desert Fossil";
                    case 3348:
                        return "Desert Fossil Wall";
                    case 3349:
                        return "Exotic Scimitar";
                    case 3350:
                        return "Paintball Gun";
                    case 3351:
                        return "Classy Cane";
                    case 3352:
                        return "Stylish Scissors";
                    case 3353:
                        return "Mechanical Cart";
                    case 3354:
                        return "Mechanical Wheel Piece";
                    case 3355:
                        return "Mechanical Wagon Piece";
                    case 3356:
                        return "Mechanical Battery Piece";
                    case 3357:
                        return "Ancient Cultist Trophy";
                    case 3358:
                        return "Martian Saucer Trophy";
                    case 3359:
                        return "Flying Dutchman Trophy";
                    case 3360:
                        return "Living Mahogany Wand";
                    case 3361:
                        return "Rich Mahogany Leaf Wand";
                    case 3362:
                        return "Fallen Tuxedo Shirt";
                    case 3363:
                        return "Fallen Tuxedo Pants";
                    case 3364:
                        return "Fireplace";
                    case 3365:
                        return "Chimney";
                    case 3366:
                        return "Yoyo Bag";
                    case 3367:
                        return "Shrimpy Truffle";
                    case 3368:
                        return "Arkhalis";
                    case 3369:
                        return "Confetti Cannon";
                    case 3370:
                        return "Music Box (The Towers)";
                    case 3371:
                        return "Music Box (Goblin Invasion)";
                    case 3372:
                        return "Ancient Cultist Mask";
                    case 3373:
                        return "Moon Lord Mask";
                    case 3374:
                        return "Fossil Helmet";
                    case 3375:
                        return "Fossil Plate";
                    case 3376:
                        return "Fossil Greaves";
                    case 3377:
                        return "Amber Staff";
                    case 3378:
                        return "Bone Javelin";
                    case 3379:
                        return "Bone Throwing Knife";
                    case 3380:
                        return "Sturdy Fossil";
                    case 3381:
                        return "Stardust Helmet";
                    case 3382:
                        return "Stardust Plate";
                    case 3383:
                        return "Stardust Leggings";
                    case 3384:
                        return "Portal Gun";
                    case 3385:
                    case 3386:
                    case 3387:
                    case 3388:
                        return "Strange Plant";
                    case 3389:
                        return "Terrarian";
                    case 3390:
                        return "Goblin Summoner Banner";
                    case 3391:
                        return "Salamander Banner";
                    case 3392:
                        return "Giant Shelly Banner";
                    case 3393:
                        return "Crawdad Banner";
                    case 3394:
                        return "Fritz Banner";
                    case 3395:
                        return "Creature From The Deep Banner";
                    case 3396:
                        return "Dr. Man Fly Banner";
                    case 3397:
                        return "Mothron Banner";
                    case 3398:
                        return "Severed Hand Banner";
                    case 3399:
                        return "The Possessed Banner";
                    case 3400:
                        return "Butcher Banner";
                    case 3401:
                        return "Psycho Banner";
                    case 3402:
                        return "Deadly Sphere Banner";
                    case 3403:
                        return "Nailhead Banner";
                    case 3404:
                        return "Poisonous Spore Banner";
                    case 3405:
                        return "Medusa Banner";
                    case 3406:
                        return "Hoplite Banner";
                    case 3407:
                        return "Granite Elemental Banner";
                    case 3408:
                        return "Grolem Banner";
                    case 3409:
                        return "Blood Zombie Banner";
                    case 3410:
                        return "Drippler Banner";
                    case 3411:
                        return "Tomb Crawler Banner";
                    case 3412:
                        return "Dune Splicer Banner";
                    case 3413:
                        return "Antlion Swarmer Banner";
                    case 3414:
                        return "Antlion Charger Banner";
                    case 3415:
                        return "Ghoul Banner";
                    case 3416:
                        return "Lamia Banner";
                    case 3417:
                        return "Desert Spirit Banner";
                    case 3418:
                        return "Basilisk Banner";
                    case 3419:
                        return "Ravager Scorpion Banner";
                    case 3420:
                        return "Stargazer Banner";
                    case 3421:
                        return "Milkyway Weaver Banner";
                    case 3422:
                        return "Flow Invader Banner";
                    case 3423:
                        return "Twinkle Popper Banner";
                    case 3424:
                        return "Small Star Cell Banner";
                    case 3425:
                        return "Star Cell Banner";
                    case 3426:
                        return "Corite Banner";
                    case 3427:
                        return "Sroller Banner";
                    case 3428:
                        return "Crawltipede Banner";
                    case 3429:
                        return "Drakomire Rider Banner";
                    case 3430:
                        return "Drakomire Banner";
                    case 3431:
                        return "Selenian Banner";
                    case 3432:
                        return "Predictor Banner";
                    case 3433:
                        return "Brain Suckler Banner";
                    case 3434:
                        return "Nebula Floater Banner";
                    case 3435:
                        return "Evolution Beast Banner";
                    case 3436:
                        return "Alien Larva Banner";
                    case 3437:
                        return "Alien Queen Banner";
                    case 3438:
                        return "Alien Hornet Banner";
                    case 3439:
                        return "Vortexian Banner";
                    case 3440:
                        return "Storm Diver Banner";
                    case 3441:
                        return "Pirate Captain Banner";
                    case 3442:
                        return "Pirate Deadeye Banner";
                    case 3443:
                        return "Pirate Corsair Banner";
                    case 3444:
                        return "Pirate Crossbower Banner";
                    case 3445:
                        return "Martian Walker Banner";
                    case 3446:
                        return "Red Devil Banner";
                    case 3447:
                        return "Pink Jellyfish Banner";
                    case 3448:
                        return "Green Jellyfish Banner";
                    case 3449:
                        return "Dark Mummy Banner";
                    case 3450:
                        return "Light Mummy Banner";
                    case 3451:
                        return "Angry Bones Banner";
                    case 3452:
                        return "Ice Tortoise Banner";
                    case 3453:
                        return "Damage Booster";
                    case 3454:
                        return "Life Booster";
                    case 3455:
                        return "Mana Booster";
                    case 3456:
                        return "Vortex Fragment";
                    case 3457:
                        return "Nebula Fragment";
                    case 3458:
                        return "Solar Fragment";
                    case 3459:
                        return "Stardust Fragment";
                    case 3460:
                        return "Luminite";
                    case 3461:
                        return "Luminite Brick";
                    case 3462:
                        return "Stardust Axe";
                    case 3463:
                        return "Stardust Chainsaw";
                    case 3464:
                        return "Stardust Drill";
                    case 3465:
                        return "Stardust Hammer";
                    case 3466:
                        return "Stardust Pickaxe";
                    case 3467:
                        return "Luminite Bar";
                    case 3468:
                        return "Solar Wings";
                    case 3469:
                        return "Vortex Booster";
                    case 3470:
                        return "Nebula Mantle";
                    case 3471:
                        return "Stardust Wings";
                    case 3472:
                        return "Luminite Brick Wall";
                    case 3473:
                        return "Solar Eruption";
                    case 3474:
                        return "Stardust Cell Staff";
                    case 3475:
                        return "Vortex Beater";
                    case 3476:
                        return "Nebula Arcanum";
                    case 3477:
                        return "Blood Water";
                    case 3478:
                        return "Wedding Veil";
                    case 3479:
                        return "Wedding Dress";
                    case 3480:
                        return "Platinum Bow";
                    case 3481:
                        return "Platinum Hammer";
                    case 3482:
                        return "Platinum Axe";
                    case 3483:
                        return "Platinum Shortsword";
                    case 3484:
                        return "Platinum Broadsword";
                    case 3485:
                        return "Platinum Pickaxe";
                    case 3486:
                        return "Tungsten Bow";
                    case 3487:
                        return "Tungsten Hammer";
                    case 3488:
                        return "Tungsten Axe";
                    case 3489:
                        return "Tungsten Shortsword";
                    case 3490:
                        return "Tungsten Broadsword";
                    case 3491:
                        return "Tungsten Pickaxe";
                    case 3492:
                        return "Lead Bow";
                    case 3493:
                        return "Lead Hammer";
                    case 3494:
                        return "Lead Axe";
                    case 3495:
                        return "Lead Shortsword";
                    case 3496:
                        return "Lead Broadsword";
                    case 3497:
                        return "Lead Pickaxe";
                    case 3498:
                        return "Tin Bow";
                    case 3499:
                        return "Tin Hammer";
                    case 3500:
                        return "Tin Axe";
                    case 3501:
                        return "Tin Shortsword";
                    case 3502:
                        return "Tin Broadsword";
                    case 3503:
                        return "Tin Pickaxe";
                    case 3504:
                        return "Copper Bow";
                    case 3505:
                        return "Copper Hammer";
                    case 3506:
                        return "Copper Axe";
                    case 3507:
                        return "Copper Shortsword";
                    case 3508:
                        return "Copper Broadsword";
                    case 3509:
                        return "Copper Pickaxe";
                    case 3510:
                        return "Silver Bow";
                    case 3511:
                        return "Silver Hammer";
                    case 3512:
                        return "Silver Axe";
                    case 3513:
                        return "Silver Shortsword";
                    case 3514:
                        return "Silver Broadsword";
                    case 3515:
                        return "Silver Pickaxe";
                    case 3516:
                        return "Gold Bow";
                    case 3517:
                        return "Gold Hammer";
                    case 3518:
                        return "Gold Axe";
                    case 3519:
                        return "Gold Shortsword";
                    case 3520:
                        return "Gold Broadsword";
                    case 3521:
                        return "Gold Pickaxe";
                    case 3522:
                        return "Solar Flare Hamaxe";
                    case 3523:
                        return "Vortex Hamaxe";
                    case 3524:
                        return "Nebula Hamaxe";
                    case 3525:
                        return "Stardust Hamaxe";
                    case 3526:
                        return "Solar Dye";
                    case 3527:
                        return "Nebula Dye";
                    case 3528:
                        return "Vortex Dye";
                    case 3529:
                        return "Stardust Dye";
                    case 3530:
                        return "Void Dye";
                    case 3531:
                        return "Stardust Dragon Staff";
                    case 3532:
                        return "Bacon";
                    case 3533:
                        return "Shifting Sands Dye";
                    case 3534:
                        return "Mirage Dye";
                    case 3535:
                        return "Shifting Pearlsands Dye";
                    case 3536:
                        return "Vortex Monolith";
                    case 3537:
                        return "Nebula Monolith";
                    case 3538:
                        return "Stardust Monolith";
                    case 3539:
                        return "Solar Monolith";
                    case 3540:
                        return "Phantasm";
                    case 3541:
                        return "Last Prism";
                    case 3542:
                        return "Nebula Blaze";
                    case 3543:
                        return "Daybreak";
                    case 3544:
                        return "Super Healing Potion";
                    case 3545:
                        return "Detonator";
                    case 3546:
                        return "Celebration";
                    case 3547:
                        return "Bouncy Dynamite";
                    case 3548:
                        return "Happy Grenade";
                    case 3549:
                        return "Ancient Manipulator";
                    case 3550:
                        return "Flame and Silver Dye";
                    case 3551:
                        return "Green Flame and Silver Dye";
                    case 3552:
                        return "Blue Flame and Silver Dye";
                    case 3553:
                        return "Reflective Copper Dye";
                    case 3554:
                        return "Reflective Obsidian Dye";
                    case 3555:
                        return "Reflective Metal Dye";
                    case 3556:
                        return "Midnight Rainbow Dye";
                    case 3557:
                        return "Black and White Dye";
                    case 3558:
                        return "Bright Silver Dye";
                    case 3559:
                        return "Silver and Black Dye";
                    case 3560:
                        return "Red Acid Dye";
                    case 3561:
                        return "Gel Dye";
                    case 3562:
                        return "Pink Gel Dye";
                    case 3563:
                        return "Red Squirrel";
                    case 3564:
                        return "Gold Squirrel";
                    case 3565:
                        return "Red Squirrel Cage";
                    case 3566:
                        return "Gold Squirrel Cage";
                    case 3567:
                        return "Luminite Bullet";
                    case 3568:
                        return "Luminite Arrow";
                    case 3569:
                        return "Lunar Portal Staff";
                    case 3570:
                        return "Lunar Flare";
                    case 3571:
                        return "Rainbow Crystal Staff";
                    case 3572:
                        return "Lunar Hook";
                    case 3573:
                        return "Solar Fragment Block";
                    case 3574:
                        return "Vortex Fragment Block";
                    case 3575:
                        return "Nebula Fragment Block";
                    case 3576:
                        return "Stardust Fragment Block";
                    case 3577:
                        return "Suspicious Looking Tentacle";
                    case 3578:
                        return "Yoraiz0r's Uniform";
                    case 3579:
                        return "Yoraiz0r's Skirt";
                    case 3580:
                        return "Yoraiz0r's Spell";
                    case 3581:
                        return "Yoraiz0r's Scowl";
                    case 3582:
                        return "Jim's Wings";
                    case 3583:
                        return "Yoraiz0r's Recolored Goggles";
                    case 3584:
                        return "Living Leaf Wall";
                    case 3585:
                        return "Skiphs's Mask";
                    case 3586:
                        return "Skiphs's Skin";
                    case 3587:
                        return "Skiphs's Bear Butt";
                    case 3588:
                        return "Skiphs's Paws";
                    case 3589:
                        return "Loki's Helmet";
                    case 3590:
                        return "Loki's Breastplate";
                    case 3591:
                        return "Loki's Greaves";
                    case 3592:
                        return "Loki's Wings";
                    case 3593:
                        return "Sand Slime Banner";
                    case 3594:
                        return "Sea Snail Banner";
                    case 3595:
                        return "Moon Lord Trophy";
                    case 3596:
                        return "Not a Kid, nor a Squid";
                    case 3597:
                        return "Burning Hades Dye";
                    case 3598:
                        return "Grim Dye";
                    case 3599:
                        return "Loki's Dye";
                    case 3600:
                        return "Shadowflame Hades Dye";
                    case 3601:
                        return "Celestial Sigil";
                }
            }
            switch(l)
            {
                case -48:
                    return "铂金短弓";
                case -47:
                    return "铂金大锤";
                case -46:
                    return "铂金斧头";
                case -45:
                    return "铂金短剑";
                case -44:
                    return "铂金宽刃剑";
                case -43:
                    return "铂金锄头";
                case -42:
                    return "钨金短弓";
                case -41:
                    return "钨金大锤";
                case -40:
                    return "钨金斧头";
                case -39:
                    return "钨金短剑";
                case -38:
                    return "钨金宽刃剑";
                case -37:
                    return "钨金锄头";
                case -36:
                    return "铅质短弓";
                case -35:
                    return "铅质大锤";
                case -34:
                    return "铅质斧头";
                case -33:
                    return "铅质短剑";
                case -32:
                    return "铅质宽刃剑";
                case -31:
                    return "铅质锄头";
                case -30:
                    return "锡质短弓";
                case -29:
                    return "锡质大锤";
                case -28:
                    return "锡质斧头";
                case -27:
                    return "锡质短剑";
                case -26:
                    return "锡质宽刃剑";
                case -25:
                    return "锡质锄头";
                case -24:
                    return "黄昏光刃";
                case -23:
                    return "苍白光刃";
                case -22:
                    return "紫晶光刃";
                case -21:
                    return "翠绿光刃";
                case -20:
                    return "真红光刃";
                case -19:
                    return "冰蓝光刃";
                case -18:
                    return "铜质短弓";
                case -17:
                    return "铜质大锤";
                case -16:
                    return "铜质斧头";
                case -15:
                    return "铜质短剑";
                case -14:
                    return "铜质宽刃剑";
                case -13:
                    return "铜质锄头";
                case -12:
                    return "白银短弓";
                case -11:
                    return "白银大锤";
                case -10:
                    return "白银斧头";
                case -9:
                    return "白银短剑";
                case -8:
                    return "白银宽刃剑";
                case -7:
                    return "白银锄头";
                case -6:
                    return "黄金短弓";
                case -5:
                    return "黄金大锤";
                case -4:
                    return "黄金斧头";
                case -3:
                    return "黄金短剑";
                case -2:
                    return "黄金宽刃剑";
                case -1:
                    return "黄金锄头";
                case 1:
                    return "铁质锄头";
                case 2:
                    return "泥土块";
                case 3:
                    return "岩石块";
                case 4:
                    return "铁质宽刃剑";
                case 5:
                    return "蘑菇";
                case 6:
                    return "铁质短剑";
                case 7:
                    return "铁质大锤";
                case 8:
                    return "火把";
                case 9:
                    return "木材";
                case 10:
                    return "铁质斧头";
                case 11:
                    return "铁矿石";
                case 12:
                    return "铜矿石";
                case 13:
                    return "金矿石";
                case 14:
                    return "银矿石";
                case 15:
                    return "铜怀表";
                case 16:
                    return "银怀表";
                case 17:
                    return "金怀表";
                case 18:
                    return "深度计";
                case 19:
                    return "金锭";
                case 20:
                    return "铜锭";
                case 21:
                    return "银锭";
                case 22:
                    return "铁锭";
                case 23:
                    return "凝胶";
                case 24:
                    return "木剑";
                case 25:
                    return "木门";
                case 26:
                    return "岩石墙壁";
                case 27:
                    return "橡树果实";
                case 28:
                    return "弱效治疗药水";
                case 29:
                    return "生命水晶";
                case 30:
                    return "泥土墙壁";
                case 31:
                    return "空瓶";
                case 32:
                    return "木桌";
                case 33:
                    return "熔炉";
                case 34:
                    return "木椅";
                case 35:
                    return "铁砧";
                case 36:
                    return "工作台";
                case 37:
                    return "护目镜";
                case 38:
                    return "晶状体";
                case 39:
                    return "木弓";
                case 40:
                    return "木箭";
                case 41:
                    return "燃烧箭";
                case 42:
                    return "手里剑";
                case 43:
                    return "可疑的眼球";
                case 44:
                    return "恶魔长弓";
                case 45:
                    return "暗夜战斧";
                case 46:
                    return "光之驱逐";
                case 47:
                    return "邪影箭";
                case 48:
                    return "木箱";
                case 49:
                    return "再生饰带";
                case 50:
                    return "魔镜";
                case 51:
                    return "小丑之箭";
                case 52:
                    return "天使雕像";
                case 53:
                    return "云瓶";
                case 54:
                    return "赫尔墨斯之靴";
                case 55:
                    return "魔化回旋镖";
                case 56:
                    return "魔金矿石";
                case 57:
                    return "魔金锭";
                case 58:
                    return "红心";
                case 59:
                    return "污染之种";
                case 60:
                    return "邪恶蘑菇";
                case 61:
                    return "黑檀石块";
                case 62:
                    return "草种";
                case 63:
                    return "向日葵";
                case 64:
                    return "邪恶荆棘";
                case 65:
                    return "群星之怒";
                case 66:
                    return "净化粉末";
                case 67:
                    return "邪恶粉末";
                case 68:
                    return "腐肉";
                case 69:
                    return "蠕虫毒牙";
                case 70:
                    return "蠕虫诱饵";
                case 71:
                    return "铜币";
                case 72:
                    return "银币";
                case 73:
                    return "金币";
                case 74:
                    return "铂金币";
                case 75:
                    return "落星";
                case 76:
                    return "铜质护胫";
                case 77:
                    return "铁质护胫";
                case 78:
                    return "白银护胫";
                case 79:
                    return "黄金护胫";
                case 80:
                    return "铜质链甲";
                case 81:
                    return "铁质链甲";
                case 82:
                    return "白银链甲";
                case 83:
                    return "黄金链甲";
                case 84:
                    return "钩爪";
                case 85:
                    return "锁链";
                case 86:
                    return "暗影鳞片";
                case 87:
                    return "猪猪储蓄罐";
                case 88:
                    return "采矿头盔";
                case 89:
                    return "铜质头盔";
                case 90:
                    return "铁质头盔";
                case 91:
                    return "白银头盔";
                case 92:
                    return "黄金头盔";
                case 93:
                    return "木墙";
                case 94:
                    return "木质平台";
                case 95:
                    return "燧发枪";
                case 96:
                    return "滑膛枪";
                case 97:
                    return "枪弹";
                case 98:
                    return "迷你鲨";
                case 99:
                    return "铁质短弓";
                case 100:
                    return "暗影护胫";
                case 101:
                    return "暗影鳞甲";
                case 102:
                    return "暗影头盔";
                case 103:
                    return "噩梦镐";
                case 104:
                    return "破坏者巨锤";
                case 105:
                    return "蜡烛";
                case 106:
                    return "铜质吊灯";
                case 107:
                    return "白银吊灯";
                case 108:
                    return "黄金吊灯";
                case 109:
                    return "魔法水晶";
                case 110:
                    return "弱效魔力药水";
                case 111:
                    return "星能饰带";
                case 112:
                    return "火花魔杖";
                case 113:
                    return "魔法飞弹";
                case 114:
                    return "泥土魔杖";
                case 115:
                    return "暗影光球";
                case 116:
                    return "陨铁矿石";
                case 117:
                    return "陨铁锭";
                case 118:
                    return "钩子";
                case 119:
                    return "破空之炎";
                case 120:
                    return "熔火之怒";
                case 121:
                    return "炽焰巨剑";
                case 122:
                    return "熔岩镐";
                case 123:
                    return "陨星面甲";
                case 124:
                    return "陨星胸甲";
                case 125:
                    return "陨星护腿";
                case 126:
                    return "瓶装水";
                case 127:
                    return "空间枪";
                case 128:
                    return "火箭靴";
                case 129:
                    return "灰色砖块";
                case 130:
                    return "灰色砖墙";
                case 131:
                    return "红色砖块";
                case 132:
                    return "红色砖墙";
                case 133:
                    return "粘土块";
                case 134:
                    return "蓝色砖块";
                case 135:
                    return "蓝色砖墙";
                case 136:
                    return "挂链吊灯";
                case 137:
                    return "绿色砖块";
                case 138:
                    return "绿色砖墙";
                case 139:
                    return "粉红砖块";
                case 140:
                    return "粉红砖墙";
                case 141:
                    return "黄金砖块";
                case 142:
                    return "黄金砖墙";
                case 143:
                    return "白银砖块";
                case 144:
                    return "白银砖墙";
                case 145:
                    return "铜砖块";
                case 146:
                    return "铜砖墙";
                case 147:
                    return "金属尖刺";
                case 148:
                    return "水蜡烛";
                case 149:
                    return "书";
                case 150:
                    return "蜘蛛网";
                case 151:
                    return "死灵头盔";
                case 152:
                    return "死灵胸甲";
                case 153:
                    return "死灵胫甲";
                case 154:
                    return "骨头";
                case 155:
                    return "妖刀村正";
                case 156:
                    return "钴盾";
                case 157:
                    return "海蓝权杖";
                case 158:
                    return "幸运马掌";
                case 159:
                    return "闪亮红气球";
                case 160:
                    return "鱼叉链枪";
                case 161:
                    return "尖钉球";
                case 162:
                    return "伤害链球";
                case 163:
                    return "蓝月";
                case 164:
                    return "手枪";
                case 165:
                    return "水箭魔法书";
                case 166:
                    return "炸弹";
                case 167:
                    return "矿用雷管";
                case 168:
                    return "手榴弹";
                case 169:
                    return "沙块";
                case 170:
                    return "玻璃";
                case 171:
                    return "标牌";
                case 172:
                    return "灰烬块";
                case 173:
                    return "黑曜石";
                case 174:
                    return "狱岩石";
                case 175:
                    return "狱岩锭";
                case 176:
                    return "淤泥块";
                case 177:
                    return "蓝宝石";
                case 178:
                    return "红宝石";
                case 179:
                    return "祖母绿";
                case 180:
                    return "黄晶玉";
                case 181:
                    return "紫水晶";
                case 182:
                    return "钻石";
                case 183:
                    return "夜光蘑菇";
                case 184:
                    return "魔力星";
                case 185:
                    return "常春藤鞭";
                case 186:
                    return "芦苇杆";
                case 187:
                    return "脚蹼";
                case 188:
                    return "治疗药水";
                case 189:
                    return "魔力药水";
                case 190:
                    return "草薙";
                case 191:
                    return "荆棘旋刃";
                case 192:
                    return "黑曜石砖块";
                case 193:
                    return "黑曜石头颅";
                case 194:
                    return "夜光蘑菇孢子";
                case 195:
                    return "丛林草种";
                case 196:
                    return "木锤";
                case 197:
                    return "星辰炮";
                case 198:
                    return "蓝相位剑";
                case 199:
                    return "红相位剑";
                case 200:
                    return "绿相位剑";
                case 201:
                    return "紫相位剑";
                case 202:
                    return "白相位剑";
                case 203:
                    return "黄相位剑";
                case 204:
                    return "陨星锤斧";
                case 205:
                    return "空桶";
                case 206:
                    return "装满水的桶";
                case 207:
                    return "装满岩浆的桶";
                case 208:
                    return "丛林玫瑰";
                case 209:
                    return "蜂刺";
                case 210:
                    return "藤条";
                case 211:
                    return "狂野之爪";
                case 212:
                    return "疾风脚镯";
                case 213:
                    return "绿化法杖";
                case 214:
                    return "狱岩砖";
                case 215:
                    return "整人坐垫";
                case 216:
                    return "镣铐";
                case 217:
                    return "熔岩锤斧";
                case 218:
                    return "烈焰火鞭";
                case 219:
                    return "凤凰冲击波";
                case 220:
                    return "日曜之怒";
                case 221:
                    return "地狱熔炉";
                case 222:
                    return "粘土花盆";
                case 223:
                    return "自然的恩赐";
                case 224:
                    return "木床";
                case 225:
                    return "丝绸";
                case 226:
                    return "弱效回复药水";
                case 227:
                    return "回复药水";
                case 228:
                    return "丛林帽";
                case 229:
                    return "丛林上衣";
                case 230:
                    return "丛林裤";
                case 231:
                    return "熔岩头盔";
                case 232:
                    return "熔岩胸甲";
                case 233:
                    return "熔岩护胫";
                case 234:
                    return "陨星弹";
                case 235:
                    return "粘性炸弹";
                case 236:
                    return "黑色晶状体";
                case 237:
                    return "墨镜";
                case 238:
                    return "巫师帽";
                case 239:
                    return "黑礼帽";
                case 240:
                    return "黑礼服";
                case 241:
                    return "礼服裤";
                case 242:
                    return "太阳帽";
                case 243:
                    return "兔子兜帽";
                case 244:
                    return "马里奥帽子";
                case 245:
                    return "马里奥上衣";
                case 246:
                    return "马里奥背带裤";
                case 247:
                    return "林克的帽子";
                case 248:
                    return "林克的上衣";
                case 249:
                    return "林克的裤子";
                case 250:
                    return "鱼缸";
                case 251:
                    return "考古学家的帽子";
                case 252:
                    return "考古学家的上衣";
                case 253:
                    return "考古学家的裤子";
                case 254:
                    return "黑色丝线";
                case 255:
                    return "绿色丝线";
                case 256:
                    return "忍者面罩";
                case 257:
                    return "忍者夜行衣";
                case 258:
                    return "忍者紧身裤";
                case 259:
                    return "皮革";
                case 260:
                    return "红帽";
                case 261:
                    return "金鱼";
                case 262:
                    return "长袍";
                case 263:
                    return "库特的机械帽";
                case 264:
                    return "王冠";
                case 265:
                    return "狱炎箭";
                case 266:
                    return "沙枪";
                case 267:
                    return "向导巫毒玩偶";
                case 268:
                    return "潜水头盔";
                case 269:
                    return "眼熟的上衣";
                case 270:
                    return "眼熟的裤子";
                case 271:
                    return "眼熟的假发";
                case 272:
                    return "恶魔之镰";
                case 273:
                    return "永夜之刃";
                case 274:
                    return "暗黑长矛";
                case 275:
                    return "珊瑚";
                case 276:
                    return "仙人掌";
                case 277:
                    return "三叉戟";
                case 278:
                    return "银弹";
                case 279:
                    return "飞刀";
                case 280:
                    return "长矛";
                case 281:
                    return "吹管";
                case 282:
                    return "荧光棒";
                case 283:
                    return "种子";
                case 284:
                    return "木制回旋镖";
                case 285:
                    return "敏捷扣链";
                case 286:
                    return "粘性荧光棒";
                case 287:
                    return "剧毒飞刀";
                case 288:
                    return "黑曜石皮肤药剂";
                case 289:
                    return "再生药剂";
                case 290:
                    return "敏捷药剂";
                case 291:
                    return "鱼鳃药剂";
                case 292:
                    return "铁皮药剂";
                case 293:
                    return "魔力恢复药剂";
                case 294:
                    return "魔能药剂";
                case 295:
                    return "羽落药剂";
                case 296:
                    return "勘探药剂";
                case 297:
                    return "隐身药剂";
                case 298:
                    return "光芒药剂";
                case 299:
                    return "夜视药剂";
                case 300:
                    return "战争药剂";
                case 301:
                    return "荆棘药剂";
                case 302:
                    return "水上行走药剂";
                case 303:
                    return "箭术药剂";
                case 304:
                    return "狩猎药剂";
                case 305:
                    return "重力药剂";
                case 306:
                    return "黄金箱子";
                case 307:
                    return "太阳花种";
                case 308:
                    return "月光草种";
                case 309:
                    return "闪耀根种";
                case 310:
                    return "死亡草种";
                case 311:
                    return "波浪叶种";
                case 312:
                    return "火焰花种";
                case 313:
                    return "太阳花";
                case 314:
                    return "月光草";
                case 315:
                    return "闪耀根";
                case 316:
                    return "死亡草";
                case 317:
                    return "波浪叶";
                case 318:
                    return "火焰花";
                case 319:
                    return "鲨鱼鳍";
                case 320:
                    return "羽毛";
                case 321:
                    return "墓碑";
                case 322:
                    return "丑角面具";
                case 323:
                    return "蚁狮上颚";
                case 324:
                    return "非法枪械部件";
                case 325:
                    return "博士上衣";
                case 326:
                    return "博士长裤";
                case 327:
                    return "黄金钥匙";
                case 328:
                    return "暗影宝箱";
                case 329:
                    return "暗影钥匙";
                case 330:
                    return "黑曜石砖";
                case 331:
                    return "丛林孢子";
                case 332:
                    return "织布机";
                case 333:
                    return "钢琴";
                case 334:
                    return "梳妆台";
                case 335:
                    return "长椅";
                case 336:
                    return "浴缸";
                case 337:
                    return "红色旗帜";
                case 338:
                    return "绿色旗帜";
                case 339:
                    return "蓝色旗帜";
                case 340:
                    return "黄色旗帜";
                case 341:
                    return "路灯";
                case 342:
                    return "提基火炬";
                case 343:
                    return "木桶";
                case 344:
                    return "灯笼";
                case 345:
                    return "烹饪锅";
                case 346:
                    return "保险箱";
                case 347:
                    return "颅骨烛台";
                case 348:
                    return "垃圾箱";
                case 349:
                    return "大烛台";
                case 350:
                    return "粉红花瓶";
                case 351:
                    return "酒杯";
                case 352:
                    return "酒桶";
                case 353:
                    return "麦酒";
                case 354:
                    return "书架";
                case 355:
                    return "王座";
                case 356:
                    return "空碗";
                case 357:
                    return "蘑菇鱼汤";
                case 358:
                    return "马桶";
                case 359:
                    return "老式摆钟";
                case 360:
                    return "装甲雕像";
                case 361:
                    return "哥布林战旗";
                case 362:
                    return "破布";
                case 363:
                    return "锯木台";
                case 364:
                    return "钴蓝矿石";
                case 365:
                    return "秘银矿石";
                case 366:
                    return "精金矿石";
                case 367:
                    return "星云之锤";
                case 368:
                    return "神圣之剑";
                case 369:
                    return "神圣之种";
                case 370:
                    return "黑檀沙块";
                case 371:
                    return "钴蓝罩帽";
                case 372:
                    return "钴蓝轻盔";
                case 373:
                    return "钴蓝面罩";
                case 374:
                    return "钴蓝胸甲";
                case 375:
                    return "钴蓝护腿";
                case 376:
                    return "秘银兜帽";
                case 377:
                    return "秘银重盔";
                case 378:
                    return "秘银护帽";
                case 379:
                    return "秘银链甲";
                case 380:
                    return "秘银腿甲";
                case 381:
                    return "钴蓝锭";
                case 382:
                    return "秘银锭";
                case 383:
                    return "钴蓝链锯";
                case 384:
                    return "秘银链锯";
                case 385:
                    return "钴蓝钻头";
                case 386:
                    return "秘银钻头";
                case 387:
                    return "精金链锯";
                case 388:
                    return "精金钻头";
                case 389:
                    return "无极";
                case 390:
                    return "秘银长戟";
                case 391:
                    return "精金锭";
                case 392:
                    return "玻璃幕墙";
                case 393:
                    return "罗盘";
                case 394:
                    return "潜水装置";
                case 395:
                    return "GPS";
                case 396:
                    return "黑曜石马掌";
                case 397:
                    return "黑曜石盾";
                case 398:
                    return "工匠作坊";
                case 399:
                    return "云气球";
                case 400:
                    return "精金头饰";
                case 401:
                    return "精金战盔";
                case 402:
                    return "精金面罩";
                case 403:
                    return "精金胸甲";
                case 404:
                    return "精金胫甲";
                case 405:
                    return "风火靴";
                case 406:
                    return "精金长刀";
                case 407:
                    return "工具包";
                case 408:
                    return "珍珠沙块";
                case 409:
                    return "珍珠岩块";
                case 410:
                    return "矿工衬衫";
                case 411:
                    return "矿工长裤";
                case 412:
                    return "珍珠岩砖";
                case 413:
                    return "荧光砖块";
                case 414:
                    return "淤泥石块";
                case 415:
                    return "钴蓝砖块";
                case 416:
                    return "秘银砖块";
                case 417:
                    return "珍珠岩墙";
                case 418:
                    return "荧光砖墙";
                case 419:
                    return "淤泥石墙";
                case 420:
                    return "钴蓝砖墙";
                case 421:
                    return "秘银砖墙";
                case 422:
                    return "圣洁水瓶";
                case 423:
                    return "邪恶水瓶";
                case 424:
                    return "泥砂块";
                case 425:
                    return "妖精铃铛";
                case 426:
                    return "破坏者之刃";
                case 427:
                    return "蓝色火把";
                case 428:
                    return "红色火把";
                case 429:
                    return "绿色火把";
                case 430:
                    return "紫色火把";
                case 431:
                    return "白色火把";
                case 432:
                    return "黄色火把";
                case 433:
                    return "恶魔火把";
                case 434:
                    return "发条式突击步枪";
                case 435:
                    return "钴蓝连发弩";
                case 436:
                    return "秘银连发弩";
                case 437:
                    return "双钩爪";
                case 438:
                    return "星辰雕像";
                case 439:
                    return "剑雕像";
                case 440:
                    return "史莱姆雕像";
                case 441:
                    return "哥布林雕像";
                case 442:
                    return "盾牌雕像";
                case 443:
                    return "蝙蝠雕像";
                case 444:
                    return "金鱼雕像";
                case 445:
                    return "兔子雕像";
                case 446:
                    return "骷髅雕像";
                case 447:
                    return "死神雕像";
                case 448:
                    return "女性雕像";
                case 449:
                    return "魔精雕像";
                case 450:
                    return "石像鬼雕像";
                case 451:
                    return "阴森雕像";
                case 452:
                    return "毒蜂雕像";
                case 453:
                    return "炸弹雕像";
                case 454:
                    return "螃蟹雕像";
                case 455:
                    return "锤子雕像";
                case 456:
                    return "药瓶雕像";
                case 457:
                    return "长矛雕像";
                case 458:
                    return "十字架雕像";
                case 459:
                    return "水母雕像";
                case 460:
                    return "短弓雕像";
                case 461:
                    return "回旋镖雕像";
                case 462:
                    return "靴子雕像";
                case 463:
                    return "宝箱雕像";
                case 464:
                    return "小鸟雕像";
                case 465:
                    return "斧头雕像";
                case 466:
                    return "腐化雕像";
                case 467:
                    return "树木雕像";
                case 468:
                    return "铁砧雕像";
                case 469:
                    return "锄头雕像";
                case 470:
                    return "蘑菇雕像";
                case 471:
                    return "眼球雕像";
                case 472:
                    return "石柱雕像";
                case 473:
                    return "心形雕像";
                case 474:
                    return "陶罐雕像";
                case 475:
                    return "向日葵雕像";
                case 476:
                    return "国王雕像";
                case 477:
                    return "王后雕像";
                case 478:
                    return "食人鱼雕像";
                case 479:
                    return "板条墙";
                case 480:
                    return "木梁";
                case 481:
                    return "精金连发弩";
                case 482:
                    return "精金斩杀剑";
                case 483:
                    return "钴蓝轻剑";
                case 484:
                    return "秘银重剑";
                case 485:
                    return "月光咒符";
                case 486:
                    return "标尺";
                case 487:
                    return "水晶球";
                case 488:
                    return "镭射球灯";
                case 489:
                    return "咒术纹章";
                case 490:
                    return "勇士纹章";
                case 491:
                    return "游侠纹章";
                case 492:
                    return "恶魔翅膀";
                case 493:
                    return "天使翅膀";
                case 494:
                    return "魔法竖琴";
                case 495:
                    return "彩虹魔杖";
                case 496:
                    return "寒冰魔杖";
                case 497:
                    return "海神贝壳";
                case 498:
                    return "木质模型";
                case 499:
                    return "强效治疗药水";
                case 500:
                    return "强效魔力药水";
                case 501:
                    return "精灵尘";
                case 502:
                    return "碎魔晶";
                case 503:
                    return "小丑帽";
                case 504:
                    return "小丑服";
                case 505:
                    return "小丑裤";
                case 506:
                    return "火焰喷射器";
                case 507:
                    return "铃铛";
                case 508:
                    return "竖琴";
                case 509:
                    return "红色扳手";
                case 510:
                    return "剪线钳";
                case 511:
                    return "机关石块";
                case 512:
                    return "机关石墙";
                case 513:
                    return "控制杆";
                case 514:
                    return "光束枪";
                case 515:
                    return "魔晶弹";
                case 516:
                    return "神怒之箭";
                case 517:
                    return "魔法飞刀";
                case 518:
                    return "魔晶风暴";
                case 519:
                    return "诅咒魔焰";
                case 520:
                    return "光明之魂";
                case 521:
                    return "暗影之魂";
                case 522:
                    return "诅咒火焰";
                case 523:
                    return "诅咒火把";
                case 524:
                    return "精金熔炉";
                case 525:
                    return "秘银砧";
                case 526:
                    return "独角兽的角";
                case 527:
                    return "太阴";
                case 528:
                    return "纯阳";
                case 529:
                    return "红色压力盘";
                case 530:
                    return "导线";
                case 531:
                    return "空白魔法书";
                case 532:
                    return "星辰披风";
                case 533:
                    return "巨兽鲨";
                case 534:
                    return "霰弹枪";
                case 535:
                    return "炼金石";
                case 536:
                    return "泰坦手套";
                case 537:
                    return "钴蓝薙刀";
                case 538:
                    return "开关";
                case 539:
                    return "毒箭机关";
                case 540:
                    return "巨石";
                case 541:
                    return "绿色压力盘";
                case 542:
                    return "灰色压力盘";
                case 543:
                    return "棕色压力盘";
                case 544:
                    return "机械魔眼";
                case 545:
                    return "咒火箭";
                case 546:
                    return "咒火弹";
                case 547:
                    return "恐惧之魂";
                case 548:
                    return "力量之魂";
                case 549:
                    return "视域之魂";
                case 550:
                    return "永恒之枪";
                case 551:
                    return "神圣板甲";
                case 552:
                    return "神圣腿甲";
                case 553:
                    return "神圣头盔";
                case 554:
                    return "十字架项链";
                case 555:
                    return "魔法的礼物";
                case 556:
                    return "机械蠕虫";
                case 557:
                    return "机械颅骨";
                case 558:
                    return "神圣头饰";
                case 559:
                    return "神圣面罩";
                case 560:
                    return "史莱姆王冠";
                case 561:
                    return "光辉飞盘";
                case 562:
                    return "八音盒（地表清晨）";
                case 563:
                    return "八音盒（恐惧）";
                case 564:
                    return "八音盒（黑夜）";
                case 565:
                    return "八音盒（世界初始）";
                case 566:
                    return "八音盒（地底）";
                case 567:
                    return "八音盒（全能窥视者）";
                case 568:
                    return "八音盒（丛林）";
                case 569:
                    return "八音盒（腐化蔓延）";
                case 570:
                    return "八音盒（黑暗地底）";
                case 571:
                    return "八音盒（圣域之歌）";
                case 572:
                    return "八音盒（世界毁灭者）";
                case 573:
                    return "八音盒（地底之光）";
                case 574:
                    return "八音盒（深渊之主）";
                case 575:
                    return "飞翔之魂";
                case 576:
                    return "八音盒";
                case 577:
                    return "魔金砖块";
                case 578:
                    return "神圣连发弩";
                case 579:
                    return "神金钻头";
                case 580:
                    return "TNT";
                case 581:
                    return "入水泵";
                case 582:
                    return "出水泵";
                case 583:
                    return "1秒触发器";
                case 584:
                    return "3秒触发器";
                case 585:
                    return "5秒触发器";
                case 586:
                    return "红色糖块";
                case 587:
                    return "红色糖墙";
                case 588:
                    return "圣诞帽";
                case 589:
                    return "圣诞外套";
                case 590:
                    return "圣诞绒裤";
                case 591:
                    return "绿色糖块";
                case 592:
                    return "绿色糖墙";
                case 593:
                    return "雪块";
                case 594:
                    return "雪砖块";
                case 595:
                    return "雪砖墙";
                case 596:
                    return "蓝灯";
                case 597:
                    return "红灯";
                case 598:
                    return "绿灯";
                case 599:
                    return "蓝色圣诞礼物";
                case 600:
                    return "绿色圣诞礼物";
                case 601:
                    return "黄色圣诞礼物";
                case 602:
                    return "雪球仪";
                case 603:
                    return "胡萝卜";
                case 604:
                    return "精金柱";
                case 605:
                    return "精金柱墙";
                case 606:
                    return "魔金砖墙";
                case 607:
                    return "砂石砖块";
                case 608:
                    return "砂石砖墙";
                case 609:
                    return "黑檀砖块";
                case 610:
                    return "黑檀砖墙";
                case 611:
                    return "红色泥灰块";
                case 612:
                    return "黄色泥灰块";
                case 613:
                    return "绿色泥灰块";
                case 614:
                    return "灰色泥灰块";
                case 615:
                    return "红色泥灰墙";
                case 616:
                    return "黄色泥灰墙";
                case 617:
                    return "绿色泥灰墙";
                case 618:
                    return "灰色泥灰墙";
                case 619:
                    return "乌木";
                case 620:
                    return "红木";
                case 621:
                    return "珍珠木";
                case 622:
                    return "乌木墙";
                case 623:
                    return "红木墙";
                case 624:
                    return "珍珠木墙";
                case 625:
                    return "乌木箱";
                case 626:
                    return "红木箱";
                case 627:
                    return "珍珠木箱";
                case 628:
                    return "乌木椅";
                case 629:
                    return "红木椅";
                case 630:
                    return "珍珠木椅";
                case 631:
                    return "乌木平台";
                case 632:
                    return "红木平台";
                case 633:
                    return "珍珠木平台";
                case 634:
                    return "骨质平台";
                case 635:
                    return "乌木工作台";
                case 636:
                    return "红木工作台";
                case 637:
                    return "珍珠木工作台";
                case 638:
                    return "乌木桌";
                case 639:
                    return "红木桌";
                case 640:
                    return "珍珠木桌";
                case 641:
                    return "乌木钢琴";
                case 642:
                    return "红木钢琴";
                case 643:
                    return "珍珠木钢琴";
                case 644:
                    return "乌木床";
                case 645:
                    return "红木床";
                case 646:
                    return "珍珠木床";
                case 647:
                    return "乌木梳妆台";
                case 648:
                    return "红木梳妆台";
                case 649:
                    return "珍珠木梳妆台";
                case 650:
                    return "乌木门";
                case 651:
                    return "红木门";
                case 652:
                    return "珍珠木门";
                case 653:
                    return "乌木剑";
                case 654:
                    return "乌木锤";
                case 655:
                    return "乌木短弓";
                case 656:
                    return "红木剑";
                case 657:
                    return "红木锤";
                case 658:
                    return "红木短弓";
                case 659:
                    return "珍珠木剑";
                case 660:
                    return "珍珠木锤";
                case 661:
                    return "珍珠木短弓";
                case 662:
                    return "彩虹砖块";
                case 663:
                    return "彩虹砖墙";
                case 664:
                    return "冰块";
                case 665:
                    return "瑞德之翼";
                case 666:
                    return "瑞德战盔";
                case 667:
                    return "瑞德战甲";
                case 668:
                    return "瑞德护胫";
                case 669:
                    return "鱼饵";
                case 670:
                    return "回旋冰刃";
                case 671:
                    return "巨战匙刃";
                case 672:
                    return "海盗弯刀";
                case 673:
                    return "北地木工作台";
                case 674:
                    return "觉醒·神圣之剑";
                case 675:
                    return "觉醒·永夜之刃";
                case 676:
                    return "冰霜巨剑";
                case 677:
                    return "北地木桌子";
                case 678:
                    return "猎魂之镰";
                case 679:
                    return "战术霰弹枪";
                case 680:
                    return "常春藤箱";
                case 681:
                    return "冰晶宝箱";
                case 682:
                    return "骸骨魔弓";
                case 683:
                    return "邪恶三叉戟";
                case 684:
                    return "冰霜头盔";
                case 685:
                    return "冰霜战甲";
                case 686:
                    return "冰霜胫甲";
                case 687:
                    return "锡质头盔";
                case 688:
                    return "锡质链甲";
                case 689:
                    return "锡质护胫";
                case 690:
                    return "铅质头盔";
                case 691:
                    return "铅质链甲";
                case 692:
                    return "铅质护胫";
                case 693:
                    return "钨金头盔";
                case 694:
                    return "钨金链甲";
                case 695:
                    return "钨金护胫";
                case 696:
                    return "铂金头盔";
                case 697:
                    return "铂金链甲";
                case 698:
                    return "铂金护胫";
                case 699:
                    return "锡矿石";
                case 700:
                    return "铅矿石";
                case 701:
                    return "钨金矿石";
                case 702:
                    return "铂金矿石";
                case 703:
                    return "锡锭";
                case 704:
                    return "铅锭";
                case 705:
                    return "钨金锭";
                case 706:
                    return "铂金锭";
                case 707:
                    return "锡质怀表";
                case 708:
                    return "钨金怀表";
                case 709:
                    return "铂金怀表";
                case 710:
                    return "锡质吊灯";
                case 711:
                    return "铅质吊灯";
                case 712:
                    return "铂金吊灯";
                case 713:
                    return "铂金蜡烛";
                case 714:
                    return "铂金烛台";
                case 715:
                    return "铂金王冠";
                case 716:
                    return "铅砧";
                case 717:
                    return "锡砖块";
                case 718:
                    return "钨金砖块";
                case 719:
                    return "铂金砖块";
                case 720:
                    return "锡砖墙";
                case 721:
                    return "钨金砖墙";
                case 722:
                    return "铂金砖墙";
                case 723:
                    return "光刃波动剑";
                case 724:
                    return "寒冰之刃";
                case 725:
                    return "寒冰组合弓";
                case 726:
                    return "极冰魔杖";
                case 727:
                    return "木制头盔";
                case 728:
                    return "木制胸甲";
                case 729:
                    return "木制护腿";
                case 730:
                    return "乌木头盔";
                case 731:
                    return "乌木胸甲";
                case 732:
                    return "乌木护腿";
                case 733:
                    return "红木头盔";
                case 734:
                    return "红木胸甲";
                case 735:
                    return "红木护腿";
                case 736:
                    return "珍珠木头盔";
                case 737:
                    return "珍珠木胸甲";
                case 738:
                    return "珍珠木护腿";
                case 739:
                    return "紫晶魔杖";
                case 740:
                    return "黄玉魔杖";
                case 741:
                    return "冰蓝魔杖";
                case 742:
                    return "翠绿魔杖";
                case 743:
                    return "真红魔杖";
                case 744:
                    return "钻石魔杖";
                case 745:
                    return "草墙";
                case 746:
                    return "丛林墙";
                case 747:
                    return "花墙";
                case 748:
                    return "喷气背包";
                case 749:
                    return "蝶翼";
                case 750:
                    return "仙人掌墙";
                case 751:
                    return "白云";
                case 752:
                    return "白云墙";
                case 753:
                    return "海草";
                case 754:
                    return "符文法帽";
                case 755:
                    return "符文法袍";
                case 756:
                    return "蘑菇长枪";
                case 757:
                    return "泰拉之刃";
                case 758:
                    return "榴弹发射器";
                case 759:
                    return "火箭发射器";
                case 760:
                    return "智能地雷发射器";
                case 761:
                    return "精灵羽翼";
                case 762:
                    return "史莱姆块";
                case 763:
                    return "血肉块";
                case 764:
                    return "蘑菇墙";
                case 765:
                    return "积雨云";
                case 766:
                    return "骸骨块";
                case 767:
                    return "冰霜史莱姆块";
                case 768:
                    return "骸骨墙壁";
                case 769:
                    return "史莱姆墙";
                case 770:
                    return "血肉墙";
                case 771:
                    return "火箭弹 I型";
                case 772:
                    return "火箭弹 II型";
                case 773:
                    return "火箭弹 III型";
                case 774:
                    return "火箭弹 IV型";
                case 775:
                    return "沥青";
                case 776:
                    return "钴蓝镐";
                case 777:
                    return "秘银镐";
                case 778:
                    return "精金镐";
                case 779:
                    return "环境改造器";
                case 780:
                    return "绿色溶剂";
                case 781:
                    return "蓝色溶剂";
                case 782:
                    return "紫色溶剂";
                case 783:
                    return "深蓝溶剂";
                case 784:
                    return "红色溶剂";
                case 785:
                    return "女妖之翼";
                case 786:
                    return "骸骨之翼";
                case 787:
                    return "粉碎之锤";
                case 788:
                    return "爆裂刺棘";
                case 789:
                    return "圣十字旗帜";
                case 790:
                    return "蝮蛇旗帜";
                case 791:
                    return "欧米加旗帜";
                case 792:
                    return "血腥头盔";
                case 793:
                    return "血腥鳞甲";
                case 794:
                    return "血腥胫甲";
                case 795:
                    return "血腥屠戮者";
                case 796:
                    return "血筋角弓";
                case 797:
                    return "碎肉机";
                case 798:
                    return "死亡代言人";
                case 799:
                    return "嗜血战斧";
                case 800:
                    return "送葬者";
                case 801:
                    return "血肉之球";
                case 802:
                    return "腐朽之刃";
                case 803:
                    return "爱斯基摩兜帽";
                case 804:
                    return "爱斯基摩外套";
                case 805:
                    return "爱斯基摩绒裤";
                case 806:
                    return "生命木椅";
                case 807:
                    return "仙人掌椅";
                case 808:
                    return "骸骨椅";
                case 809:
                    return "血肉椅";
                case 810:
                    return "蘑菇椅";
                case 811:
                    return "白骨工作台";
                case 812:
                    return "仙人掌工作台";
                case 813:
                    return "血肉工作台";
                case 814:
                    return "蘑菇工作台";
                case 815:
                    return "史莱姆工作台";
                case 816:
                    return "仙人掌门";
                case 817:
                    return "血肉门";
                case 818:
                    return "蘑菇门";
                case 819:
                    return "生命木门";
                case 820:
                    return "骸骨门";
                case 821:
                    return "炽焰之翼";
                case 822:
                    return "冰晶之翼";
                case 823:
                    return "幽魂之翼";
                case 824:
                    return "日耀砖块";
                case 825:
                    return "舞厅彩墙";
                case 826:
                    return "天空椅";
                case 827:
                    return "骸骨桌";
                case 828:
                    return "血肉桌";
                case 829:
                    return "生命木桌";
                case 830:
                    return "天空桌";
                case 831:
                    return "生命木箱";
                case 832:
                    return "生命之树魔杖";
                case 833:
                    return "紫色冰块";
                case 834:
                    return "粉红冰块";
                case 835:
                    return "血红冰块";
                case 836:
                    return "血腥石块";
                case 837:
                    return "天空门";
                case 838:
                    return "天空宝箱";
                case 839:
                    return "蒸汽朋克帽";
                case 840:
                    return "蒸汽朋克外套";
                case 841:
                    return "蒸汽朋克长裤";
                case 842:
                    return "蜜蜂帽";
                case 843:
                    return "蜜蜂外套";
                case 844:
                    return "蜜蜂裤";
                case 845:
                    return "世界旗帜";
                case 846:
                    return "太阳旗帜";
                case 847:
                    return "重力旗帜";
                case 848:
                    return "法老面具";
                case 849:
                    return "促动器";
                case 850:
                    return "蓝色扳手";
                case 851:
                    return "绿色扳手";
                case 852:
                    return "蓝色压力板";
                case 853:
                    return "黄色压力板";
                case 854:
                    return "打折卡";
                case 855:
                    return "幸运硬币";
                case 856:
                    return "独角兽的头";
                case 857:
                    return "沙暴之瓶";
                case 858:
                    return "北地木沙发";
                case 859:
                    return "沙滩球";
                case 860:
                    return "传说坠饰";
                case 861:
                    return "月光贝壳";
                case 862:
                    return "星辰项链";
                case 863:
                    return "水上行走靴";
                case 864:
                    return "三重冠";
                case 865:
                    return "公主裙";
                case 866:
                    return "法老长袍";
                case 867:
                    return "绿帽子";
                case 868:
                    return "蘑菇软帽";
                case 869:
                    return "苏格兰圆帽";
                case 870:
                    return "木乃伊面罩";
                case 871:
                    return "木乃伊绑身";
                case 872:
                    return "木乃伊绑腿";
                case 873:
                    return "牛仔皮帽";
                case 874:
                    return "牛仔夹克衫";
                case 875:
                    return "牛仔皮裤";
                case 876:
                    return "海盗帽";
                case 877:
                    return "海盗大衣";
                case 878:
                    return "海盗裤子";
                case 879:
                    return "维京战盔";
                case 880:
                    return "血腥矿石";
                case 881:
                    return "仙人掌剑";
                case 882:
                    return "仙人掌镐";
                case 883:
                    return "冰砖块";
                case 884:
                    return "冰砖墙";
                case 885:
                    return "粘性绷带";
                case 886:
                    return "盔甲抛光剂";
                case 887:
                    return "牛黄";
                case 888:
                    return "眼罩";
                case 889:
                    return "快速时钟";
                case 890:
                    return "超大话筒";
                case 891:
                    return "贡品";
                case 892:
                    return "维生素";
                case 893:
                    return "折叠地图";
                case 894:
                    return "仙人掌头盔";
                case 895:
                    return "仙人掌胸甲";
                case 896:
                    return "仙人掌护腿";
                case 897:
                    return "力量手套";
                case 898:
                    return "闪电靴";
                case 899:
                    return "日曜石戒指";
                case 900:
                    return "月曜石戒指";
                case 901:
                    return "助推器";
                case 902:
                    return "治疗绷带";
                case 903:
                    return "计划书";
                case 904:
                    return "驱咒圣诗";
                case 905:
                    return "硬币枪";
                case 906:
                    return "熔岩咒符";
                case 907:
                    return "黑曜石水行靴";
                case 908:
                    return "熔岩漫步者";
                case 909:
                    return "纯净喷泉";
                case 910:
                    return "沙漠喷泉";
                case 911:
                    return "阴影木";
                case 912:
                    return "阴影木门";
                case 913:
                    return "阴影木平台";
                case 914:
                    return "阴影木箱";
                case 915:
                    return "阴影木椅";
                case 916:
                    return "阴影木工作台";
                case 917:
                    return "阴影木桌";
                case 918:
                    return "阴影木梳妆台";
                case 919:
                    return "阴影木钢琴";
                case 920:
                    return "阴影木床";
                case 921:
                    return "阴影木剑";
                case 922:
                    return "阴影木锤";
                case 923:
                    return "阴影木短弓";
                case 924:
                    return "阴影木头盔";
                case 925:
                    return "阴影木胸甲";
                case 926:
                    return "阴影木护腿";
                case 927:
                    return "阴影木墙";
                case 928:
                    return "加农炮";
                case 929:
                    return "加农炮弹";
                case 930:
                    return "信号枪";
                case 931:
                    return "信号弹";
                case 932:
                    return "骸骨魔杖";
                case 933:
                    return "绿叶魔杖";
                case 934:
                    return "飞翔魔毯";
                case 935:
                    return "复仇者纹章";
                case 936:
                    return "机械手套";
                case 937:
                    return "地雷";
                case 938:
                    return "圣骑士之盾";
                case 939:
                    return "蛛网悬索";
                case 940:
                    return "丛林喷泉";
                case 941:
                    return "冰雪喷泉";
                case 942:
                    return "腐化喷泉";
                case 943:
                    return "深红喷泉";
                case 944:
                    return "神圣喷泉";
                case 945:
                    return "鲜血喷泉";
                case 946:
                    return "雨伞";
                case 947:
                    return "叶绿矿石";
                case 948:
                    return "蒸汽朋克翅膀";
                case 949:
                    return "雪球";
                case 950:
                    return "冰鞋";
                case 951:
                    return "雪球发射器";
                case 952:
                    return "蛛网宝箱";
                case 953:
                    return "攀爬爪";
                case 954:
                    return "古代铁盔";
                case 955:
                    return "古代金盔";
                case 956:
                    return "古代暗影头盔";
                case 957:
                    return "古代暗影鳞甲";
                case 958:
                    return "古代暗影护胫";
                case 959:
                    return "古代死灵头盔";
                case 960:
                    return "古代钴蓝头盔";
                case 961:
                    return "古代钴蓝胸甲";
                case 962:
                    return "古代钴蓝胫甲";
                case 963:
                    return "黑色腰带";
                case 964:
                    return "三管猎枪";
                case 965:
                    return "绳子";
                case 966:
                    return "篝火";
                case 967:
                    return "棉花糖";
                case 968:
                    return "棉花糖串";
                case 969:
                    return "烤棉花糖";
                case 970:
                    return "红色火箭烟花";
                case 971:
                    return "绿色火箭烟花";
                case 972:
                    return "蓝色火箭烟花";
                case 973:
                    return "黄色火箭烟花";
                case 974:
                    return "冰火把";
                case 975:
                    return "鞋钉";
                case 976:
                    return "虎爪";
                case 977:
                    return "忍者缠足";
                case 978:
                    return "粉色爱斯基摩兜帽";
                case 979:
                    return "粉色爱斯基摩外套";
                case 980:
                    return "粉色爱斯基摩绒裤";
                case 981:
                    return "粉色丝线";
                case 982:
                    return "魔力恢复饰带";
                case 983:
                    return "沙暴气球";
                case 984:
                    return "忍者的极意";
                case 985:
                    return "绳圈";
                case 986:
                    return "吹箭";
                case 987:
                    return "暴雪之瓶";
                case 988:
                    return "冰焰箭";
                case 989:
                    return "魔化之刃";
                case 990:
                    return "斧镐";
                case 991:
                    return "钴蓝战斧";
                case 992:
                    return "秘银战斧";
                case 993:
                    return "精金战斧";
                case 994:
                    return "噬魂之骨";
                case 995:
                    return "自动搅拌机";
                case 996:
                    return "绞肉机";
                case 997:
                    return "精炼机";
                case 998:
                    return "凝固机";
                case 999:
                    return "琥珀";
                case 1000:
                    return "彩纸枪";
                case 1001:
                    return "叶绿刺盔";
                case 1002:
                    return "叶绿翼盔";
                case 1003:
                    return "叶绿权冠";
                case 1004:
                    return "叶绿板甲";
                case 1005:
                    return "叶绿胫甲";
                case 1006:
                    return "叶绿锭";
                case 1007:
                    return "红色染料";
                case 1008:
                    return "橙色染料";
                case 1009:
                    return "黄色染料";
                case 1010:
                    return "橙绿染料";
                case 1011:
                    return "绿色染料";
                case 1012:
                    return "青色染料";
                case 1013:
                    return "靛青染料";
                case 1014:
                    return "淡蓝染料";
                case 1015:
                    return "蓝色染料";
                case 1016:
                    return "紫色染料";
                case 1017:
                    return "淡紫染料";
                case 1018:
                    return "粉色染料";
                case 1019:
                    return "红间黑染料";
                case 1020:
                    return "橙间黑染料";
                case 1021:
                    return "黄间黑染料";
                case 1022:
                    return "橙绿间黑染料";
                case 1023:
                    return "绿间黑染料";
                case 1024:
                    return "青间黑染料";
                case 1025:
                    return "靛间黑染料";
                case 1026:
                    return "淡蓝间黑染料";
                case 1027:
                    return "蓝间黑染料";
                case 1028:
                    return "紫间黑染料";
                case 1029:
                    return "淡紫间染料";
                case 1030:
                    return "粉间黑染料";
                case 1031:
                    return "焰色染料";
                case 1032:
                    return "黑焰染料";
                case 1033:
                    return "绿焰染料";
                case 1034:
                    return "绿间黑焰染料";
                case 1035:
                    return "蓝焰染料";
                case 1036:
                    return "蓝间黑焰染料";
                case 1037:
                    return "银色染料";
                case 1038:
                    return "亮红染料";
                case 1039:
                    return "亮橙染料";
                case 1040:
                    return "亮黄染料";
                case 1041:
                    return "亮橙绿染料";
                case 1042:
                    return "亮绿染料";
                case 1043:
                    return "亮青染料";
                case 1044:
                    return "亮靛青染料";
                case 1045:
                    return "亮天蓝染料";
                case 1046:
                    return "亮蓝染料";
                case 1047:
                    return "亮紫染料";
                case 1048:
                    return "亮淡紫染料";
                case 1049:
                    return "亮粉染料";
                case 1050:
                    return "黑色染料";
                case 1051:
                    return "红间银染料";
                case 1052:
                    return "橙间银染料";
                case 1053:
                    return "黄间银染料";
                case 1054:
                    return "橙绿间银染料";
                case 1055:
                    return "绿间银染料";
                case 1056:
                    return "青间银染料";
                case 1057:
                    return "靛青间银染料";
                case 1058:
                    return "天蓝间银染料";
                case 1059:
                    return "蓝间银染料";
                case 1060:
                    return "紫间银染料";
                case 1061:
                    return "淡紫间银染料";
                case 1062:
                    return "粉间银染料";
                case 1063:
                    return "烈焰染料";
                case 1064:
                    return "绿色烈焰染料";
                case 1065:
                    return "蓝色烈焰染料";
                case 1066:
                    return "彩虹染料";
                case 1067:
                    return "亮丽彩虹染料";
                case 1068:
                    return "黄色渐变染料";
                case 1069:
                    return "青色渐变染料";
                case 1070:
                    return "淡紫渐变染料";
                case 1071:
                    return "涂料刷";
                case 1072:
                    return "涂料滚筒";
                case 1073:
                    return "红色涂料";
                case 1074:
                    return "橙色涂料";
                case 1075:
                    return "黄色涂料";
                case 1076:
                    return "橙绿涂料";
                case 1077:
                    return "绿色涂料";
                case 1078:
                    return "青色涂料";
                case 1079:
                    return "靛青涂料";
                case 1080:
                    return "天蓝涂料";
                case 1081:
                    return "蓝色涂料";
                case 1082:
                    return "紫色涂料";
                case 1083:
                    return "浅紫涂料";
                case 1084:
                    return "粉色涂料";
                case 1085:
                    return "深红涂料";
                case 1086:
                    return "深橙涂料";
                case 1087:
                    return "深黄涂料";
                case 1088:
                    return "深橙绿涂料";
                case 1089:
                    return "深绿涂料";
                case 1090:
                    return "深青涂料";
                case 1091:
                    return "深靛青涂料";
                case 1092:
                    return "深天蓝涂料";
                case 1093:
                    return "深蓝涂料";
                case 1094:
                    return "深紫涂料";
                case 1095:
                    return "暗紫涂料";
                case 1096:
                    return "暗粉涂料";
                case 1097:
                    return "黑色涂料";
                case 1098:
                    return "白色涂料";
                case 1099:
                    return "灰色涂料";
                case 1100:
                    return "涂料刮刀";
                case 1101:
                    return "神庙蜥蜴砖";
                case 1102:
                    return "神庙蜥蜴砖墙";
                case 1103:
                    return "雪砂块";
                case 1104:
                    return "钯金矿石";
                case 1105:
                    return "山铜矿石";
                case 1106:
                    return "钛金矿";
                case 1107:
                    return "青色蘑菇";
                case 1108:
                    return "绿色蘑菇";
                case 1109:
                    return "天蓝花";
                case 1110:
                    return "黄万寿菊";
                case 1111:
                    return "蓝莓";
                case 1112:
                    return "橙绿海藻";
                case 1113:
                    return "粉色仙人掌花";
                case 1114:
                    return "橙血根";
                case 1115:
                    return "红色甲壳";
                case 1116:
                    return "靛青甲壳";
                case 1117:
                    return "浅紫甲壳";
                case 1118:
                    return "紫粘液";
                case 1119:
                    return "黑墨水";
                case 1120:
                    return "染缸";
                case 1121:
                    return "蜜蜂枪";
                case 1122:
                    return "魔化飞斧";
                case 1123:
                    return "养蜂人";
                case 1124:
                    return "蜂巢";
                case 1125:
                    return "蜂蜜块";
                case 1126:
                    return "蜂巢墙";
                case 1127:
                    return "易碎蜂蜜块";
                case 1128:
                    return "装满蜂蜜的桶";
                case 1129:
                    return "蜂巢魔杖";
                case 1130:
                    return "蜜蜂手榴弹";
                case 1131:
                    return "重力球";
                case 1132:
                    return "蜂窝";
                case 1133:
                    return "蜜蜂分泌物";
                case 1134:
                    return "瓶装蜂蜜";
                case 1135:
                    return "雨帽";
                case 1136:
                    return "雨衣";
                case 1137:
                    return "神庙门";
                case 1138:
                    return "地牢门";
                case 1139:
                    return "铅门";
                case 1140:
                    return "铁门";
                case 1141:
                    return "神庙钥匙";
                case 1142:
                    return "神庙宝箱";
                case 1143:
                    return "神庙椅";
                case 1144:
                    return "神庙桌";
                case 1145:
                    return "神庙工作台";
                case 1146:
                    return "神庙毒箭机关";
                case 1147:
                    return "火焰机关";
                case 1148:
                    return "刺球机关";
                case 1149:
                    return "长矛机关";
                case 1150:
                    return "木制尖刺";
                case 1151:
                    return "神庙压力板";
                case 1152:
                    return "蜥蜴雕像";
                case 1153:
                    return "蜥蜴侦察兵雕像";
                case 1154:
                    return "蜥蜴守卫雕像";
                case 1155:
                    return "黄蜂枪";
                case 1156:
                    return "钢铁食人鱼";
                case 1157:
                    return "俾格米召唤法杖";
                case 1158:
                    return "俾格米骨链";
                case 1159:
                    return "提基面罩";
                case 1160:
                    return "提基衬衫";
                case 1161:
                    return "提基裤子";
                case 1162:
                    return "绿叶翅膀";
                case 1163:
                    return "暴雪气球";
                case 1164:
                    return "气球束";
                case 1165:
                    return "暗黑蝠翼";
                case 1166:
                    return "白骨之剑";
                case 1167:
                    return "力神甲虫";
                case 1168:
                    return "烟雾弹";
                case 1169:
                    return "白骨钥匙";
                case 1170:
                    return "花蜜";
                case 1171:
                    return "提基图腾柱";
                case 1172:
                    return "蜥蜴卵";
                case 1173:
                    return "墓牌";
                case 1174:
                    return "十字墓牌";
                case 1175:
                    return "十字墓碑";
                case 1176:
                    return "墓碑";
                case 1177:
                    return "方尖碑";
                case 1178:
                    return "飞叶枪";
                case 1179:
                    return "叶绿弹";
                case 1180:
                    return "鹦鹉饼干";
                case 1181:
                    return "怪异夜光蘑菇";
                case 1182:
                    return "树苗";
                case 1183:
                    return "瓶中精灵";
                case 1184:
                    return "钯金锭";
                case 1185:
                    return "钯金波刃剑";
                case 1186:
                    return "钯金钩刃";
                case 1187:
                    return "钯金连发弩";
                case 1188:
                    return "钯金镐";
                case 1189:
                    return "钯金钻头";
                case 1190:
                    return "钯金链锯";
                case 1191:
                    return "山铜锭";
                case 1192:
                    return "山铜紫刃";
                case 1193:
                    return "山铜长戟";
                case 1194:
                    return "山铜连发弩";
                case 1195:
                    return "山铜镐";
                case 1196:
                    return "山铜钻头";
                case 1197:
                    return "山铜链锯";
                case 1198:
                    return "钛金锭";
                case 1199:
                    return "钛金破刃剑";
                case 1200:
                    return "钛金三叉戟";
                case 1201:
                    return "钛金连发弩";
                case 1202:
                    return "钛金镐";
                case 1203:
                    return "钛金钻头";
                case 1204:
                    return "钛金链锯";
                case 1205:
                    return "钯金面罩";
                case 1206:
                    return "钯金战盔";
                case 1207:
                    return "钯金翼盔";
                case 1208:
                    return "钯金胸甲";
                case 1209:
                    return "钯金护胫";
                case 1210:
                    return "山铜面罩";
                case 1211:
                    return "山铜角盔";
                case 1212:
                    return "山铜头冠";
                case 1213:
                    return "山铜胸甲";
                case 1214:
                    return "山铜胫甲";
                case 1215:
                    return "钛金面罩";
                case 1216:
                    return "钛金战盔";
                case 1217:
                    return "钛金刺盔";
                case 1218:
                    return "钛金胸甲";
                case 1219:
                    return "钛金护胫";
                case 1220:
                    return "山铜砧";
                case 1221:
                    return "钛金熔炉";
                case 1222:
                    return "钯金战斧";
                case 1223:
                    return "山铜战斧";
                case 1224:
                    return "钛金战斧";
                case 1225:
                    return "神圣锭";
                case 1226:
                    return "叶绿巨剑";
                case 1227:
                    return "叶绿军刀";
                case 1228:
                    return "叶绿帕提森钩刃";
                case 1229:
                    return "叶绿连发弩";
                case 1230:
                    return "叶绿镐";
                case 1231:
                    return "叶绿钻头";
                case 1232:
                    return "叶绿链锯";
                case 1233:
                    return "叶绿巨斧";
                case 1234:
                    return "叶绿战锤";
                case 1235:
                    return "叶绿箭";
                case 1236:
                    return "紫水晶钩爪";
                case 1237:
                    return "黄晶玉钩爪";
                case 1238:
                    return "蓝宝石钩爪";
                case 1239:
                    return "祖母绿钩爪";
                case 1240:
                    return "红宝石钩爪";
                case 1241:
                    return "钻石钩爪";
                case 1242:
                    return "琥珀蚊";
                case 1243:
                    return "雨伞帽";
                case 1244:
                    return "雷云法杖";
                case 1245:
                    return "橙火把";
                case 1246:
                    return "血腥沙块";
                case 1247:
                    return "蜜蜂披风";
                case 1248:
                    return "巨人之眼";
                case 1249:
                    return "蜂蜜气球";
                case 1250:
                    return "蓝马掌气球";
                case 1251:
                    return "白马掌气球";
                case 1252:
                    return "黄马掌气球";
                case 1253:
                    return "冰霜龟甲";
                case 1254:
                    return "狙击步枪";
                case 1255:
                    return "金星马格南";
                case 1256:
                    return "血云魔杖";
                case 1257:
                    return "血腥锭";
                case 1258:
                    return "毒刺发射器";
                case 1259:
                    return "锦绣花团";
                case 1260:
                    return "彩虹枪";
                case 1261:
                    return "毒刺";
                case 1262:
                    return "叶绿冲击锤";
                case 1263:
                    return "传送器";
                case 1264:
                    return "冰霜之花";
                case 1265:
                    return "乌兹冲锋枪";
                case 1266:
                    return "磁暴之球";
                case 1267:
                    return "紫色玻璃墙";
                case 1268:
                    return "黄色玻璃墙";
                case 1269:
                    return "蓝色玻璃墙";
                case 1270:
                    return "绿色玻璃墙";
                case 1271:
                    return "红色玻璃墙";
                case 1272:
                    return "多彩玻璃墙";
                case 1273:
                    return "骷髅爪";
                case 1274:
                    return "白骨头颅";
                case 1275:
                    return "巴拉帽";
                case 1276:
                    return "摇滚帽";
                case 1277:
                    return "水手帽";
                case 1278:
                    return "眼罩";
                case 1279:
                    return "水手服";
                case 1280:
                    return "水手裤";
                case 1281:
                    return "骷髅面具";
                case 1282:
                    return "紫水晶法袍";
                case 1283:
                    return "黄晶玉法袍";
                case 1284:
                    return "蓝宝石法袍";
                case 1285:
                    return "祖母绿法袍";
                case 1286:
                    return "红宝石法袍";
                case 1287:
                    return "钻石法袍";
                case 1288:
                    return "白礼服";
                case 1289:
                    return "白礼服裤";
                case 1290:
                    return "恐慌项链";
                case 1291:
                    return "生命之果";
                case 1292:
                    return "蜥蜴祭坛";
                case 1293:
                    return "蜥蜴能量组件";
                case 1294:
                    return "链锯镐";
                case 1295:
                    return "热能射线";
                case 1296:
                    return "大地法杖";
                case 1297:
                    return "巨人之拳";
                case 1298:
                    return "水华宝箱";
                case 1299:
                    return "双筒望远镜";
                case 1300:
                    return "步枪瞄准镜";
                case 1301:
                    return "毁灭者纹章";
                case 1302:
                    return "高速弹";
                case 1303:
                    return "水母项链";
                case 1304:
                    return "僵尸之爪";
                case 1305:
                    return "电音吉他";
                case 1306:
                    return "寒冰之镰";
                case 1307:
                    return "裁缝巫毒玩偶";
                case 1308:
                    return "剧毒法杖";
                case 1309:
                    return "史莱姆法杖";
                case 1310:
                    return "剧毒吹箭";
                case 1311:
                    return "弹簧眼球";
                case 1312:
                    return "玩具雪橇";
                case 1313:
                    return "骷髅之书";
                case 1314:
                    return "KO之拳";
                case 1315:
                    return "藏宝图";
                case 1316:
                    return "玄武战盔";
                case 1317:
                    return "玄武鳞甲";
                case 1318:
                    return "玄武护胫";
                case 1319:
                    return "雪球炮";
                case 1320:
                    return "骸骨镐";
                case 1321:
                    return "魔法箭袋";
                case 1322:
                    return "熔岩之石";
                case 1323:
                    return "黑曜石玫瑰";
                case 1324:
                    return "香蕉回旋镖";
                case 1325:
                    return "链刃";
                case 1326:
                    return "传送法杖";
                case 1327:
                    return "死亡镰刀";
                case 1328:
                    return "龟甲";
                case 1329:
                    return "组织样本";
                case 1330:
                    return "脊椎骨";
                case 1331:
                    return "血腥脊柱";
                case 1332:
                    return "脓血";
                case 1333:
                    return "金血火把";
                case 1334:
                    return "脓血之箭";
                case 1335:
                    return "脓血子弹";
                case 1336:
                    return "黄金喷头";
                case 1337:
                    return "兔子大炮";
                case 1338:
                    return "爆炸兔子";
                case 1339:
                    return "小瓶毒液";
                case 1340:
                    return "恶毒之瓶";
                case 1341:
                    return "恶毒之箭";
                case 1342:
                    return "恶毒子弹";
                case 1343:
                    return "火焰手套";
                case 1344:
                    return "齿轮";
                case 1345:
                    return "彩纸";
                case 1346:
                    return "纳米材料";
                case 1347:
                    return "炸药粉";
                case 1348:
                    return "砂金";
                case 1349:
                    return "彩纸弹";
                case 1350:
                    return "纳米子弹";
                case 1351:
                    return "高爆弹";
                case 1352:
                    return "金弹";
                case 1353:
                    return "魔焰之瓶";
                case 1354:
                    return "火焰之瓶";
                case 1355:
                    return "黄金之瓶";
                case 1356:
                    return "腐蚀之瓶";
                case 1357:
                    return "混乱之瓶";
                case 1358:
                    return "彩纸之瓶";
                case 1359:
                    return "毒素之瓶";
                case 1360:
                    return "荣耀之证（克苏鲁之眼）";
                case 1361:
                    return "荣耀之证（世界吞噬者）";
                case 1362:
                    return "荣耀之证（克苏鲁之脑）";
                case 1363:
                    return "荣耀之证（骷髅王）";
                case 1364:
                    return "荣耀之证（蜂后）";
                case 1365:
                    return "荣耀之证（血肉之墙）";
                case 1366:
                    return "荣耀之证（钢铁破坏者）";
                case 1367:
                    return "荣耀之证（骷髅总理）";
                case 1368:
                    return "荣耀之证（镭射之眼）";
                case 1369:
                    return "荣耀之证（魔焰之眼）";
                case 1370:
                    return "荣耀之证（世纪之花）";
                case 1371:
                    return "荣耀之证（石巨人）";
                case 1372:
                    return "血月升起";
                case 1373:
                    return "倒吊人";
                case 1374:
                    return "火之荣耀";
                case 1375:
                    return "碎骨";
                case 1376:
                    return "悬挂骷髅";
                case 1377:
                    return "倒吊骷髅";
                case 1378:
                    return "蓝色板墙";
                case 1379:
                    return "蓝色瓷墙";
                case 1380:
                    return "粉色板墙";
                case 1381:
                    return "粉色瓷墙";
                case 1382:
                    return "绿色板墙";
                case 1383:
                    return "绿色瓷墙";
                case 1384:
                    return "蓝砖平台";
                case 1385:
                    return "粉砖平台";
                case 1386:
                    return "绿砖平台";
                case 1387:
                    return "金属架";
                case 1388:
                    return "黄铜架";
                case 1389:
                    return "木架";
                case 1390:
                    return "黄铜吊灯";
                case 1391:
                    return "笼灯";
                case 1392:
                    return "提灯";
                case 1393:
                    return "炼金吊灯";
                case 1394:
                    return "符文灯";
                case 1395:
                    return "骨质烛台";
                case 1396:
                    return "蓝色地牢椅";
                case 1397:
                    return "蓝色地牢桌";
                case 1398:
                    return "蓝色地牢工作台";
                case 1399:
                    return "绿色地牢椅";
                case 1400:
                    return "绿色地牢桌";
                case 1401:
                    return "绿色地牢工作台";
                case 1402:
                    return "粉色地牢椅";
                case 1403:
                    return "粉色地牢桌";
                case 1404:
                    return "粉色地牢工作台";
                case 1405:
                    return "蓝色地牢蜡烛";
                case 1406:
                    return "绿色地牢蜡烛";
                case 1407:
                    return "粉色地牢蜡烛";
                case 1408:
                    return "蓝色地牢花瓶";
                case 1409:
                    return "绿色地牢花瓶";
                case 1410:
                    return "粉色地牢花瓶";
                case 1411:
                    return "蓝色地牢门";
                case 1412:
                    return "绿色地牢门";
                case 1413:
                    return "粉色地牢门";
                case 1414:
                    return "蓝色地牢书架";
                case 1415:
                    return "绿色地牢书架";
                case 1416:
                    return "粉色地牢书架";
                case 1417:
                    return "地下墓场";
                case 1418:
                    return "地牢石架";
                case 1419:
                    return "碎骨头颅";
                case 1420:
                    return "被诅咒的人";
                case 1421:
                    return "邪眼的末日";
                case 1422:
                    return "邪恶窥视";
                case 1423:
                    return "双子魔眼的苏醒";
                case 1424:
                    return "尖叫者";
                case 1425:
                    return "玩扑克的哥布林";
                case 1426:
                    return "树妖";
                case 1427:
                    return "向日葵";
                case 1428:
                    return "哥特式泰拉";
                case 1429:
                    return "便帽";
                case 1430:
                    return "药水灌输器";
                case 1431:
                    return "星瓶";
                case 1432:
                    return "弹壳";
                case 1433:
                    return "冲击";
                case 1434:
                    return "由鸟驱动";
                case 1435:
                    return "钢铁毁灭者";
                case 1436:
                    return "眼球的执着";
                case 1437:
                    return "穿过圣域的独角兽";
                case 1438:
                    return "巨浪";
                case 1439:
                    return "星光之夜";
                case 1440:
                    return "向导";
                case 1441:
                    return "守护者的凝视";
                case 1442:
                    return "父亲";
                case 1443:
                    return "丽莎护士";
                case 1444:
                    return "暗影射线法杖";
                case 1445:
                    return "地狱火之叉";
                case 1446:
                    return "幽魂法杖";
                case 1447:
                    return "木质栅栏";
                case 1448:
                    return "金属栅栏";
                case 1449:
                    return "泡泡机";
                case 1450:
                    return "泡泡杖";
                case 1451:
                    return "天灾军团旗帜";
                case 1452:
                    return "死灵法师标志";
                case 1453:
                    return "锈骨战团旗帜";
                case 1454:
                    return "钙帮帮徽";
                case 1455:
                    return "燃烧军团战旗";
                case 1456:
                    return "恶魔印章";
                case 1457:
                    return "黑曜石平台";
                case 1458:
                    return "黑曜石门";
                case 1459:
                    return "黑曜石椅";
                case 1460:
                    return "黑曜石桌";
                case 1461:
                    return "黑曜石工作台";
                case 1462:
                    return "黑曜石花瓶";
                case 1463:
                    return "黑曜石书架";
                case 1464:
                    return "地狱边界旗帜";
                case 1465:
                    return "地狱锤旗帜";
                case 1466:
                    return "地狱瞭望塔旗帜";
                case 1467:
                    return "绝望旗帜";
                case 1468:
                    return "黑曜石守望者旗帜";
                case 1469:
                    return "岩浆喷发旗帜";
                case 1470:
                    return "蓝色地牢床";
                case 1471:
                    return "绿色地牢床";
                case 1472:
                    return "红色地牢床";
                case 1473:
                    return "黑曜石床";
                case 1474:
                    return "规则";
                case 1475:
                    return "黑暗";
                case 1476:
                    return "暗魂收割者";
                case 1477:
                    return "大地";
                case 1478:
                    return "被困的幽灵";
                case 1479:
                    return "恶魔之眼";
                case 1480:
                    return "黄金的发现";
                case 1481:
                    return "第一次相遇";
                case 1482:
                    return "清爽的早晨";
                case 1483:
                    return "地底宝藏";
                case 1484:
                    return "窗外";
                case 1485:
                    return "云外苍天";
                case 1486:
                    return "别踩草坪";
                case 1487:
                    return "冰原之河";
                case 1488:
                    return "幽暗裂缝";
                case 1489:
                    return "梦幻假象";
                case 1490:
                    return "日光";
                case 1491:
                    return "沙的秘辛";
                case 1492:
                    return "活死人之地";
                case 1493:
                    return "邪恶凝视";
                case 1494:
                    return "天空守护者";
                case 1495:
                    return "美洲炸药";
                case 1496:
                    return "新发现";
                case 1497:
                    return "顽强";
                case 1498:
                    return "老矿工";
                case 1499:
                    return "骷髅头";
                case 1500:
                    return "面对克苏鲁之脑";
                case 1501:
                    return "火焰之湖";
                case 1502:
                    return "三英雄";
                case 1503:
                    return "幽魂兜帽";
                case 1504:
                    return "幽魂法衣";
                case 1505:
                    return "幽魂法裤";
                case 1506:
                    return "幽魂镐";
                case 1507:
                    return "幽魂锤斧";
                case 1508:
                    return "星魂";
                case 1509:
                    return "哥特式木椅";
                case 1510:
                    return "哥特式方桌";
                case 1511:
                    return "哥特工作台";
                case 1512:
                    return "哥特式书柜";
                case 1513:
                    return "圣骑士之锤";
                case 1514:
                    return "特警头盔";
                case 1515:
                    return "蜂翅";
                case 1516:
                    return "女妖羽毛";
                case 1517:
                    return "白骨羽毛";
                case 1518:
                    return "炽焰羽毛";
                case 1519:
                    return "冰晶羽毛";
                case 1520:
                    return "破损蝠翼";
                case 1521:
                    return "破损蜂翅";
                case 1522:
                    return "大紫水晶";
                case 1523:
                    return "大黄晶玉";
                case 1524:
                    return "大蓝宝石";
                case 1525:
                    return "大祖母绿";
                case 1526:
                    return "大红宝石";
                case 1527:
                    return "大钻石";
                case 1528:
                    return "丛林宝箱";
                case 1529:
                    return "腐化宝箱";
                case 1530:
                    return "血红宝箱";
                case 1531:
                    return "神圣宝箱";
                case 1532:
                    return "冰霜宝箱";
                case 1533:
                    return "丛林钥匙";
                case 1534:
                    return "腐化钥匙";
                case 1535:
                    return "血腥钥匙";
                case 1536:
                    return "神圣钥匙";
                case 1537:
                    return "冰霜钥匙";
                case 1538:
                    return "火魔精";
                case 1539:
                    return "不祥之兆";
                case 1540:
                    return "耀月";
                case 1541:
                    return "鲜活之血";
                case 1542:
                    return "流动的岩浆";
                case 1543:
                    return "幽魂涂料刷";
                case 1544:
                    return "幽魂涂料滚筒";
                case 1545:
                    return "幽魂涂料刮刀";
                case 1546:
                    return "蓝光头饰";
                case 1547:
                    return "蓝光面具";
                case 1548:
                    return "蓝光头盔";
                case 1549:
                    return "蓝光胸甲";
                case 1550:
                    return "蓝光护腿";
                case 1551:
                    return "自动锻造机";
                case 1552:
                    return "蘑菇锭";
                case 1553:
                    return "S.D.M.G.";
                case 1554:
                    return "Cenx的三重冠";
                case 1555:
                    return "Cenx的胸甲";
                case 1556:
                    return "Cenx的胫甲";
                case 1557:
                    return "Crowno的面罩";
                case 1558:
                    return "Crowno的胸甲";
                case 1559:
                    return "Crowno的胫甲";
                case 1560:
                    return "Will的头盔";
                case 1561:
                    return "Will的胸甲";
                case 1562:
                    return "Will的胫甲";
                case 1563:
                    return "Jim的头盔";
                case 1564:
                    return "Jim的胸甲";
                case 1565:
                    return "Jim的胫甲";
                case 1566:
                    return "艾伦战盔";
                case 1567:
                    return "艾伦胸甲";
                case 1568:
                    return "艾伦胫甲";
                case 1569:
                    return "吸血飞刀";
                case 1570:
                    return "英雄断剑";
                case 1571:
                    return "腐蚀咒怨";
                case 1572:
                    return "冰霜龙头杖";
                case 1573:
                    return "向导的诞生";
                case 1574:
                    return "大商人";
                case 1575:
                    return "克罗诺的午餐";
                case 1576:
                    return "稀有魔物";
                case 1577:
                    return "荣耀之夜";
                case 1578:
                    return "甜心项链";
                case 1579:
                    return "冰雪之靴";
                case 1580:
                    return "D-Town的头盔";
                case 1581:
                    return "D-Town的胸甲";
                case 1582:
                    return "D-Town的胫甲";
                case 1583:
                    return "D-Town的翅膀";
                case 1584:
                    return "威尔之翼";
                case 1585:
                    return "克罗诺之翼";
                case 1586:
                    return "森斯之翼";
                case 1587:
                    return "森斯之裙";
                case 1588:
                    return "森斯之裤";
                case 1589:
                    return "钯金柱";
                case 1590:
                    return "钯金墙壁";
                case 1591:
                    return "泡泡糖块";
                case 1592:
                    return "泡泡糖墙";
                case 1593:
                    return "钛金石块";
                case 1594:
                    return "钛金墙壁";
                case 1595:
                    return "魔法手铐";
                case 1596:
                    return "八音盒（风雪）";
                case 1597:
                    return "八音盒（虚空）";
                case 1598:
                    return "八音盒（血腥之地）";
                case 1599:
                    return "八音盒 (石巨人)";
                case 1600:
                    return "八音盒 (白天)";
                case 1601:
                    return "八音盒（暴雨）";
                case 1602:
                    return "八音盒（冰原）";
                case 1603:
                    return "八音盒（沙漠）";
                case 1604:
                    return "八音盒（海洋）";
                case 1605:
                    return "八音盒（幽闭地牢）";
                case 1606:
                    return "八音盒（世纪之花）";
                case 1607:
                    return "八音盒 (蜂后)";
                case 1608:
                    return "八音盒（丛林神庙）";
                case 1609:
                    return "八音盒 (日食)";
                case 1610:
                    return "八音盒（夜光蘑菇园）";
                case 1611:
                    return "蝴蝶尘";
                case 1612:
                    return "圣十字护符";
                case 1613:
                    return "圣十字护盾";
                case 1614:
                    return "蓝色信号弹";
                case 1615:
                    return "琵琶鱼旗帜";
                case 1616:
                    return "狂怒之灵旗帜";
                case 1617:
                    return "真菌爬虫旗帜";
                case 1618:
                    return "蚁狮旗帜";
                case 1619:
                    return "巨骨舌鱼旗帜";
                case 1620:
                    return "装甲骷髅旗帜";
                case 1621:
                    return "蝙蝠旗帜";
                case 1622:
                    return "小鸟旗帜";
                case 1623:
                    return "黑隐者旗帜";
                case 1624:
                    return "鲜血哺育者旗帜";
                case 1625:
                    return "鲜血水母旗帜";
                case 1626:
                    return "鲜血蜘蛛旗帜";
                case 1627:
                    return "骨蛇旗帜";
                case 1628:
                    return "兔子旗帜";
                case 1629:
                    return "混沌元素旗帜";
                case 1630:
                    return "模仿者旗帜";
                case 1631:
                    return "小丑旗帜";
                case 1632:
                    return "腐化兔旗帜";
                case 1633:
                    return "腐化金鱼旗帜";
                case 1634:
                    return "螃蟹旗帜";
                case 1635:
                    return "血肉之虫旗帜";
                case 1636:
                    return "血腥之斧旗帜";
                case 1637:
                    return "血腥之锤旗帜";
                case 1638:
                    return "恶魔旗帜";
                case 1639:
                    return "恶魔之眼旗帜";
                case 1640:
                    return "巨眼虫旗帜";
                case 1641:
                    return "灵魂吞噬者旗帜";
                case 1642:
                    return "魔化圣剑旗帜";
                case 1643:
                    return "爱斯基摩僵尸旗帜";
                case 1644:
                    return "巨脸怪旗帜";
                case 1645:
                    return "浮空血魂旗帜";
                case 1646:
                    return "飞鱼旗帜";
                case 1647:
                    return "羽蛇旗帜";
                case 1648:
                    return "科学怪人旗帜";
                case 1649:
                    return "真菌囊泡旗帜";
                case 1650:
                    return "真菌水母旗帜";
                case 1651:
                    return "神圣蜗牛旗帜";
                case 1652:
                    return "哥布林弓箭手旗帜";
                case 1653:
                    return "哥布林法师旗帜";
                case 1654:
                    return "哥布林斥候旗帜";
                case 1655:
                    return "哥布林盗贼旗帜";
                case 1656:
                    return "哥布林战士旗帜";
                case 1657:
                    return "金鱼旗帜";
                case 1658:
                    return "鹰身女妖旗帜";
                case 1659:
                    return "地狱蝙蝠旗帜";
                case 1660:
                    return "鲜血棘虫旗帜";
                case 1661:
                    return "毒蜂旗帜";
                case 1662:
                    return "冰元素旗帜";
                case 1663:
                    return "寒冰鱼人旗帜";
                case 1664:
                    return "火魔精旗帜";
                case 1665:
                    return "水母旗帜";
                case 1666:
                    return "丛林爬行者旗帜";
                case 1667:
                    return "蜥蜴旗帜";
                case 1668:
                    return "食人花旗帜";
                case 1669:
                    return "陨石怪旗帜";
                case 1670:
                    return "毒蛾旗帜";
                case 1671:
                    return "木乃伊旗帜";
                case 1672:
                    return "真菌甲虫旗帜";
                case 1673:
                    return "鹦鹉旗帜";
                case 1674:
                    return "剑齿亚龙旗帜";
                case 1675:
                    return "食人鱼旗帜";
                case 1676:
                    return "海盗旗帜";
                case 1677:
                    return "小精灵旗帜";
                case 1678:
                    return "雨衣僵尸旗帜";
                case 1679:
                    return "收割者旗帜";
                case 1680:
                    return "鲨鱼旗帜";
                case 1681:
                    return "骷髅旗帜";
                case 1682:
                    return "骷髅魔法师旗帜";
                case 1683:
                    return "史莱姆旗帜";
                case 1684:
                    return "雪球怪旗帜";
                case 1685:
                    return "蜘蛛旗帜";
                case 1686:
                    return "孢子僵尸旗帜";
                case 1687:
                    return "沼泽魔怪旗帜";
                case 1688:
                    return "乌龟旗帜";
                case 1689:
                    return "污泥怪旗帜";
                case 1690:
                    return "雨伞史莱姆旗帜";
                case 1691:
                    return "独角兽旗帜";
                case 1692:
                    return "吸血鬼旗帜";
                case 1693:
                    return "秃鹫旗帜";
                case 1694:
                    return "染血女神旗帜";
                case 1695:
                    return "狼人旗帜";
                case 1696:
                    return "雪狼旗帜";
                case 1697:
                    return "世界哺育者旗帜";
                case 1698:
                    return "蠕虫旗帜";
                case 1699:
                    return "幽灵旗帜";
                case 1700:
                    return "翼龙旗帜";
                case 1701:
                    return "僵尸旗帜";
                case 1702:
                    return "玻璃平台";
                case 1703:
                    return "玻璃椅";
                case 1704:
                    return "黄金椅";
                case 1705:
                    return "黄金马桶";
                case 1706:
                    return "酒吧圆凳";
                case 1707:
                    return "蜂蜜椅";
                case 1708:
                    return "蒸汽朋克椅";
                case 1709:
                    return "玻璃门";
                case 1710:
                    return "黄金门";
                case 1711:
                    return "蜂蜜门";
                case 1712:
                    return "蒸汽朋克门";
                case 1713:
                    return "玻璃桌";
                case 1714:
                    return "宴会桌";
                case 1715:
                    return "门闩";
                case 1716:
                    return "黄金桌";
                case 1717:
                    return "蜂蜜桌";
                case 1718:
                    return "蒸汽朋克桌";
                case 1719:
                    return "玻璃床";
                case 1720:
                    return "黄金床";
                case 1721:
                    return "蜂蜜床";
                case 1722:
                    return "蒸汽朋克床";
                case 1723:
                    return "生命木墙";
                case 1724:
                    return "屁瓶";
                case 1725:
                    return "南瓜";
                case 1726:
                    return "南瓜墙";
                case 1727:
                    return "干草";
                case 1728:
                    return "干草墙";
                case 1729:
                    return "幽灵木";
                case 1730:
                    return "幽灵木墙";
                case 1731:
                    return "南瓜头盔";
                case 1732:
                    return "南瓜胸甲";
                case 1733:
                    return "南瓜护胫";
                case 1734:
                    return "糖苹果";
                case 1735:
                    return "灵魂蛋糕";
                case 1736:
                    return "护士帽";
                case 1737:
                    return "护士服";
                case 1738:
                    return "护士裤";
                case 1739:
                    return "魔法师之帽";
                case 1740:
                    return "欺诈者面具";
                case 1741:
                    return "染料商长袍";
                case 1742:
                    return "蒸汽朋克护目镜";
                case 1743:
                    return "电子人头盔";
                case 1744:
                    return "电子人上衣";
                case 1745:
                    return "电子人裤子";
                case 1746:
                    return "苦力怕面罩";
                case 1747:
                    return "苦力怕外套";
                case 1748:
                    return "苦力怕外裤";
                case 1749:
                    return "猫面罩";
                case 1750:
                    return "猫变装衣";
                case 1751:
                    return "猫变装裤";
                case 1752:
                    return "幽灵面罩";
                case 1753:
                    return "幽灵裤";
                case 1754:
                    return "南瓜面罩";
                case 1755:
                    return "南瓜衣";
                case 1756:
                    return "南瓜裤";
                case 1757:
                    return "机器人帽子";
                case 1758:
                    return "机器人上衣";
                case 1759:
                    return "机器人裤子";
                case 1760:
                    return "独角兽面罩";
                case 1761:
                    return "独角兽上衣";
                case 1762:
                    return "独角兽裤子";
                case 1763:
                    return "吸血鬼面罩";
                case 1764:
                    return "吸血鬼西服";
                case 1765:
                    return "吸血鬼西裤";
                case 1766:
                    return "女巫帽";
                case 1767:
                    return "妖精帽";
                case 1768:
                    return "妖精上衣";
                case 1769:
                    return "妖精裤";
                case 1770:
                    return "精灵上衣";
                case 1771:
                    return "精灵裤子";
                case 1772:
                    return "公主帽";
                case 1773:
                    return "公主裙";
                case 1774:
                    return "福袋";
                case 1775:
                    return "女巫连衣裙";
                case 1776:
                    return "女巫之靴";
                case 1777:
                    return "科学怪人新娘面罩";
                case 1778:
                    return "科学怪人新娘婚纱";
                case 1779:
                    return "忍者神龟面具";
                case 1780:
                    return "忍者神龟龟甲";
                case 1781:
                    return "忍者神龟裤子";
                case 1782:
                    return "糖豆机枪";
                case 1783:
                    return "糖豆";
                case 1784:
                    return "杰克爆弹发射器";
                case 1785:
                    return "杰克爆弹";
                case 1786:
                    return "镰刀";
                case 1787:
                    return "南瓜派";
                case 1788:
                    return "稻草人帽子";
                case 1789:
                    return "稻草人上衣";
                case 1790:
                    return "稻草人裤子";
                case 1791:
                    return "大烹饪锅";
                case 1792:
                    return "南瓜椅";
                case 1793:
                    return "南瓜门";
                case 1794:
                    return "南瓜桌子";
                case 1795:
                    return "南瓜工作台";
                case 1796:
                    return "南瓜平台";
                case 1797:
                    return "残破精灵之翼";
                case 1798:
                    return "蜘蛛卵";
                case 1799:
                    return "魔法南瓜种子";
                case 1800:
                    return "蝙蝠钩";
                case 1801:
                    return "蝙蝠权杖";
                case 1802:
                    return "黑鸦法杖";
                case 1803:
                    return "丛林钥匙模具";
                case 1804:
                    return "腐化钥匙模具";
                case 1805:
                    return "血腥钥匙模具";
                case 1806:
                    return "神圣钥匙模具";
                case 1807:
                    return "冰霜钥匙模具";
                case 1808:
                    return "倒吊南瓜杰克";
                case 1809:
                    return "腐烂鸡蛋";
                case 1810:
                    return "厄运线团";
                case 1811:
                    return "黑色精灵尘";
                case 1812:
                    return "南瓜吊灯";
                case 1813:
                    return "南瓜杰克灯笼";
                case 1814:
                    return "幽灵木椅";
                case 1815:
                    return "幽灵木门";
                case 1816:
                    return "幽灵木桌";
                case 1817:
                    return "幽灵木工作台";
                case 1818:
                    return "幽灵木平台";
                case 1819:
                    return "死神兜帽";
                case 1820:
                    return "死神长袍";
                case 1821:
                    return "狐狸面罩";
                case 1822:
                    return "狐狸皮衣";
                case 1823:
                    return "狐狸皮裤";
                case 1824:
                    return "猫耳";
                case 1825:
                    return "鲜血屠刀";
                case 1826:
                    return "无头骑士之刃";
                case 1827:
                    return "拳刃";
                case 1828:
                    return "南瓜种子";
                case 1829:
                    return "幽灵钩爪";
                case 1830:
                    return "幽灵之翼";
                case 1831:
                    return "幽灵细枝";
                case 1832:
                    return "幽灵木头盔";
                case 1833:
                    return "幽灵木胸甲";
                case 1834:
                    return "幽灵木护胫";
                case 1835:
                    return "木桩发射器";
                case 1836:
                    return "尖木桩";
                case 1837:
                    return "诅咒树苗";
                case 1838:
                    return "异形面罩";
                case 1839:
                    return "异形上衣";
                case 1840:
                    return "异形裤子";
                case 1841:
                    return "狼人面罩";
                case 1842:
                    return "狼人皮衣";
                case 1843:
                    return "狼人皮裤";
                case 1844:
                    return "万圣节奖章";
                case 1845:
                    return "死灵卷轴";
                case 1846:
                    return "南瓜骷髅杰克";
                case 1847:
                    return "苦涩的收获";
                case 1848:
                    return "血月女伯爵";
                case 1849:
                    return "神圣之夜";
                case 1850:
                    return "致命好奇心";
                case 1851:
                    return "寻宝者上衣";
                case 1852:
                    return "寻宝者裤子";
                case 1853:
                    return "树妖饰带";
                case 1854:
                    return "树妖缠带";
                case 1855:
                    return "荣耀之证（万圣树妖）";
                case 1856:
                    return "荣耀之证（南瓜）";
                case 1857:
                    return "南瓜杰克面罩";
                case 1858:
                    return "狙击镜";
                case 1859:
                    return "心形吊灯";
                case 1860:
                    return "水母潜水装置";
                case 1861:
                    return "极地潜水装置";
                case 1862:
                    return "冰霜火花之靴";
                case 1863:
                    return "屁之气球";
                case 1864:
                    return "圣甲虫卷轴";
                case 1865:
                    return "上界之石";
                case 1866:
                    return "悬浮飞板";
                case 1867:
                    return "棒棒糖";
                case 1868:
                    return "甜梅";
                case 1869:
                    return "圣诞礼物";
                case 1870:
                    return "红色BB枪";
                case 1871:
                    return "节日之翼";
                case 1872:
                    return "松树块";
                case 1873:
                    return "圣诞树";
                case 1874:
                    return "圣诞星";
                case 1875:
                    return "圣诞星";
                case 1876:
                    return "圣诞星";
                case 1877:
                    return "蝴蝶结顶花";
                case 1878:
                    return "白色花环";
                case 1879:
                    return "红白花环";
                case 1880:
                    return "红色花环";
                case 1881:
                    return "红绿花环";
                case 1882:
                    return "绿色花环";
                case 1883:
                    return "白绿花环";
                case 1884:
                    return "彩色灯泡";
                case 1885:
                    return "红色灯泡";
                case 1886:
                    return "黄色灯泡";
                case 1887:
                    return "绿色灯泡";
                case 1888:
                    return "红绿灯泡";
                case 1889:
                    return "黄绿灯泡";
                case 1890:
                    return "红黄灯泡";
                case 1891:
                    return "白色灯泡";
                case 1892:
                    return "红白灯泡";
                case 1893:
                    return "黄白灯泡";
                case 1894:
                    return "白绿灯泡";
                case 1895:
                    return "彩色彩灯";
                case 1896:
                    return "红色彩灯";
                case 1897:
                    return "绿色彩灯";
                case 1898:
                    return "蓝色彩灯";
                case 1899:
                    return "黄色彩灯";
                case 1900:
                    return "红黄彩灯";
                case 1901:
                    return "红绿彩灯";
                case 1902:
                    return "黄绿彩灯";
                case 1903:
                    return "蓝绿彩灯";
                case 1904:
                    return "红蓝彩灯";
                case 1905:
                    return "蓝黄彩灯";
                case 1906:
                    return "蝴蝶结头饰";
                case 1907:
                    return "驯鹿角";
                case 1908:
                    return "冬青花环";
                case 1909:
                    return "棒棒糖剑";
                case 1910:
                    return "精灵喷火器";
                case 1911:
                    return "圣诞布丁";
                case 1912:
                    return "蛋奶酒";
                case 1913:
                    return "八角茴香";
                case 1914:
                    return "驯鹿铃铛";
                case 1915:
                    return "棒棒糖钩";
                case 1916:
                    return "圣诞钩爪";
                case 1917:
                    return "棒棒糖镐";
                case 1918:
                    return "水果蛋糕旋刃";
                case 1919:
                    return "甜曲奇";
                case 1920:
                    return "姜饼曲奇";
                case 1921:
                    return "暖手宝";
                case 1922:
                    return "煤";
                case 1923:
                    return "工具箱";
                case 1924:
                    return "松树木门";
                case 1925:
                    return "松树木椅";
                case 1926:
                    return "松树木桌";
                case 1927:
                    return "狗哨";
                case 1928:
                    return "圣诞树剑";
                case 1929:
                    return "链条枪";
                case 1930:
                    return "松叶快刀";
                case 1931:
                    return "暴雪魔杖";
                case 1932:
                    return "圣诞女士帽";
                case 1933:
                    return "圣诞女士上衣";
                case 1934:
                    return "圣诞女士高跟鞋";
                case 1935:
                    return "防风兜帽";
                case 1936:
                    return "防风外套";
                case 1937:
                    return "防风绒裤";
                case 1938:
                    return "雪帽";
                case 1939:
                    return "难看毛衣";
                case 1940:
                    return "圣诞树顶";
                case 1941:
                    return "圣诞树叶";
                case 1942:
                    return "圣诞树干";
                case 1943:
                    return "精灵帽";
                case 1944:
                    return "精灵衬衫";
                case 1945:
                    return "精灵裤子";
                case 1946:
                    return "雪人大炮";
                case 1947:
                    return "北极";
                case 1948:
                    return "圣诞树墙纸";
                case 1949:
                    return "装饰墙纸";
                case 1950:
                    return "棒棒糖墙纸";
                case 1951:
                    return "节日墙纸";
                case 1952:
                    return "星星墙纸";
                case 1953:
                    return "波浪墙纸";
                case 1954:
                    return "雪花墙纸";
                case 1955:
                    return "坎普斯喇叭墙纸";
                case 1956:
                    return "蓝绿墙纸";
                case 1957:
                    return "圣诞精灵墙纸";
                case 1958:
                    return "淘气礼物";
                case 1959:
                    return "圣诞精灵宝宝的恶作剧口哨";
                case 1960:
                    return "荣耀之证（冰雪女王）";
                case 1961:
                    return "荣耀之证（圣诞坦克）";
                case 1962:
                    return "荣耀之证（尖叫圣诞树）";
                case 1963:
                    return "音乐盒 (南瓜月)";
                case 1964:
                    return "音乐盒 (精灵大陆)";
                case 1965:
                    return "音乐盒 (霜月)";
                case 1966:
                    return "棕色涂料";
                case 1967:
                    return "阴影涂料";
                case 1968:
                    return "反色涂料";
                case 1969:
                    return "组别染料";
                case 1970:
                    return "紫水晶砖";
                case 1971:
                    return "黄晶玉砖";
                case 1972:
                    return "蓝宝石砖";
                case 1973:
                    return "绿宝石砖";
                case 1974:
                    return "红宝石砖";
                case 1975:
                    return "钻石砖";
                case 1976:
                    return "琥珀砖";
                case 1977:
                    return "生命染发剂";
                case 1978:
                    return "法力染发剂";
                case 1979:
                    return "深度染发剂";
                case 1980:
                    return "土豪染发剂";
                case 1981:
                    return "时间染发剂";
                case 1982:
                    return "组别染发剂";
                case 1983:
                    return "环境染发剂";
                case 1984:
                    return "派对染发剂";
                case 1985:
                    return "彩虹染发剂";
                case 1986:
                    return "速度染发剂";
                case 1987:
                    return "天使光环";
                case 1988:
                    return "毡帽";
                case 1989:
                    return "木质模特（女）";
                case 1990:
                    return "洗发水";
                case 1991:
                    return "捕虫网";
                case 1992:
                    return "萤火虫";
                case 1993:
                    return "瓶中的萤火虫";
                case 1994:
                    return "帝王蝶";
                case 1995:
                    return "紫色帝王蝶";
                case 1996:
                    return "赤蛱蝶";
                case 1997:
                    return "天堂凤蝶";
                case 1998:
                    return "菜粉蝶";
                case 1999:
                    return "树若虫蝴蝶";
                case 2000:
                    return "斑马燕尾蝶";
                case 2001:
                    return "茱莉亚蝶";
                case 2002:
                    return "蠕虫";
                case 2003:
                    return "老鼠";
                case 2004:
                    return "闪电萤火虫";
                case 2005:
                    return "瓶中的闪电萤火虫";
                case 2006:
                    return "蜗牛";
                case 2007:
                    return "荧光蜗牛";
                case 2008:
                    return "灰墙纸";
                case 2009:
                    return "浮冰墙纸";
                case 2010:
                    return "音乐墙纸";
                case 2011:
                    return "紫雨墙纸";
                case 2012:
                    return "彩虹墙纸";
                case 2013:
                    return "闪光石墙纸";
                case 2014:
                    return "星空墙纸";
                case 2015:
                    return "鸟";
                case 2016:
                    return "蓝鸟";
                case 2017:
                    return "红鸟";
                case 2018:
                    return "松鼠";
                case 2019:
                    return "兔子";
                case 2020:
                    return "仙人掌书架";
                case 2021:
                    return "乌木书架";
                case 2022:
                    return "血肉书架";
                case 2023:
                    return "蜂蜜书架";
                case 2024:
                    return "蒸汽朋克书架";
                case 2025:
                    return "玻璃书架";
                case 2026:
                    return "红木书架";
                case 2027:
                    return "珍珠木书架";
                case 2028:
                    return "幽灵木书架";
                case 2029:
                    return "空岛书架";
                case 2030:
                    return "神庙书架";
                case 2031:
                    return "冰书架";
                case 2032:
                    return "仙人掌灯笼";
                case 2033:
                    return "乌木灯笼";
                case 2034:
                    return "血肉灯笼";
                case 2035:
                    return "蜂蜜灯笼";
                case 2036:
                    return "蒸汽朋克灯笼";
                case 2037:
                    return "玻璃灯笼";
                case 2038:
                    return "红木灯笼";
                case 2039:
                    return "珍珠木灯笼";
                case 2040:
                    return "冰灯笼";
                case 2041:
                    return "神庙灯笼";
                case 2042:
                    return "空岛灯笼";
                case 2043:
                    return "幽灵木灯笼";
                case 2044:
                    return "冰门";
                case 2045:
                    return "仙人掌蜡烛";
                case 2046:
                    return "乌木蜡烛";
                case 2047:
                    return "血肉蜡烛";
                case 2048:
                    return "玻璃蜡烛";
                case 2049:
                    return "冰蜡烛";
                case 2050:
                    return "红木蜡烛";
                case 2051:
                    return "珍珠木蜡烛";
                case 2052:
                    return "神庙蜡烛";
                case 2053:
                    return "空岛蜡烛";
                case 2054:
                    return "南瓜蜡烛";
                case 2055:
                    return "仙人掌吊灯";
                case 2056:
                    return "乌木吊灯";
                case 2057:
                    return "血肉吊灯";
                case 2058:
                    return "蜂蜜吊灯";
                case 2059:
                    return "冰吊灯";
                case 2060:
                    return "红木吊灯";
                case 2061:
                    return "珍珠木吊灯";
                case 2062:
                    return "神庙吊灯";
                case 2063:
                    return "空岛吊灯";
                case 2064:
                    return "幽灵木吊灯";
                case 2065:
                    return "玻璃吊灯";
                case 2066:
                    return "仙人掌床";
                case 2067:
                    return "血肉床";
                case 2068:
                    return "冰床";
                case 2069:
                    return "神庙床";
                case 2070:
                    return "空岛床";
                case 2071:
                    return "幽灵木床";
                case 2072:
                    return "仙人掌浴缸";
                case 2073:
                    return "乌木浴缸";
                case 2074:
                    return "血肉浴缸";
                case 2075:
                    return "玻璃浴缸";
                case 2076:
                    return "冰浴缸";
                case 2077:
                    return "红木浴缸";
                case 2078:
                    return "珍珠木浴缸";
                case 2079:
                    return "神庙浴缸";
                case 2080:
                    return "空岛浴缸";
                case 2081:
                    return "幽灵木浴缸";
                case 2082:
                    return "仙人掌灯";
                case 2083:
                    return "乌木灯";
                case 2084:
                    return "血肉灯";
                case 2085:
                    return "玻璃灯";
                case 2086:
                    return "冰灯";
                case 2087:
                    return "红木灯";
                case 2088:
                    return "珍珠木灯";
                case 2089:
                    return "神庙灯";
                case 2090:
                    return "空岛灯";
                case 2091:
                    return "幽灵木灯";
                case 2092:
                    return "仙人掌烛台";
                case 2093:
                    return "乌木烛台";
                case 2094:
                    return "血肉烛台";
                case 2095:
                    return "蜂蜜烛台";
                case 2096:
                    return "蒸汽朋克烛台";
                case 2097:
                    return "玻璃烛台";
                case 2098:
                    return "红木烛台";
                case 2099:
                    return "珍珠木烛台";
                case 2100:
                    return "冰烛台";
                case 2101:
                    return "神庙烛台";
                case 2102:
                    return "空岛烛台";
                case 2103:
                    return "幽灵木烛台";
                case 2104:
                    return "克苏鲁之脑面具";
                case 2105:
                    return "血肉之墙面具";
                case 2106:
                    return "双子魔眼面具";
                case 2107:
                    return "骷髅总理面具";
                case 2108:
                    return "蜂后面具";
                case 2109:
                    return "世纪之花面具";
                case 2110:
                    return "石巨人面具";
                case 2111:
                    return "世界吞噬者面具";
                case 2112:
                    return "克苏鲁之眼面具";
                case 2113:
                    return "钢铁破坏者面具";
                case 2114:
                    return "铁匠架子";
                case 2115:
                    return "木工架子";
                case 2116:
                    return "头盔架子";
                case 2117:
                    return "长矛架子";
                case 2118:
                    return "宝剑架子";
                case 2119:
                    return "石板";
                case 2120:
                    return "沙石板";
                case 2121:
                    return "青蛙";
                case 2122:
                    return "野鸭";
                case 2123:
                    return "鸭子";
                case 2124:
                    return "蜂蜜浴缸";
                case 2125:
                    return "蒸汽朋克浴缸";
                case 2126:
                    return "生命之树浴缸";
                case 2127:
                    return "阴影木浴缸";
                case 2128:
                    return "骸骨浴缸";
                case 2129:
                    return "蜂蜜灯";
                case 2130:
                    return "蒸汽朋克灯";
                case 2131:
                    return "生命之树灯";
                case 2132:
                    return "阴影木灯";
                case 2133:
                    return "黄金灯";
                case 2134:
                    return "骸骨灯";
                case 2135:
                    return "生命之树书架";
                case 2136:
                    return "阴影木书架";
                case 2137:
                    return "黄金书架";
                case 2138:
                    return "骸骨书架";
                case 2139:
                    return "生命之树床";
                case 2140:
                    return "骸骨床";
                case 2141:
                    return "生命之树吊灯";
                case 2142:
                    return "阴影木吊灯";
                case 2143:
                    return "黄金吊灯";
                case 2144:
                    return "骸骨吊灯";
                case 2145:
                    return "生命之树灯笼";
                case 2146:
                    return "阴影木灯笼";
                case 2147:
                    return "黄金灯笼";
                case 2148:
                    return "骸骨灯笼";
                case 2149:
                    return "生命之树烛台";
                case 2150:
                    return "阴影木烛台";
                case 2151:
                    return "黄金烛台";
                case 2152:
                    return "骸骨烛台";
                case 2153:
                    return "生命之树蜡烛";
                case 2154:
                    return "阴影木蜡烛";
                case 2155:
                    return "黄金蜡烛";
                case 2156:
                    return "黑蝎子";
                case 2157:
                    return "蝎子";
                case 2158:
                    return "泡泡墙纸";
                case 2159:
                    return "铜管墙纸";
                case 2160:
                    return "小黄鸭墙纸";
                case 2161:
                    return "冰冻核心";
                case 2162:
                    return "兔子笼";
                case 2163:
                    return "松鼠笼";
                case 2164:
                    return "野鸭笼";
                case 2165:
                    return "鸭笼";
                case 2166:
                    return "鸟笼";
                case 2167:
                    return "蓝鸟笼";
                case 2168:
                    return "红鸲笼";
                case 2169:
                    return "瀑布墙";
                case 2170:
                    return "岩浆瀑布墙";
                case 2171:
                    return "血腥种子";
                case 2172:
                    return "重型工作台";
                case 2173:
                    return "镀铜砖";
                case 2174:
                    return "蜗牛箱";
                case 2175:
                    return "荧光蜗牛箱";
                case 2176:
                    return "蘑菇挖掘爪";
                case 2177:
                    return "弹药箱";
                case 2178:
                    return "帝王蝶罐";
                case 2179:
                    return "紫色帝王蝶罐";
                case 2180:
                    return "赤蛱蝶罐";
                case 2181:
                    return "天堂凤蝶罐";
                case 2182:
                    return "黄粉蝶罐";
                case 2183:
                    return "树若虫蝴蝶罐";
                case 2184:
                    return "斑纹燕尾蝶罐";
                case 2185:
                    return "茱莉亚蝶罐";
                case 2186:
                    return "蝎箱";
                case 2187:
                    return "黑蝎箱";
                case 2188:
                    return "猛毒法杖";
                case 2189:
                    return "幽灵面具";
                case 2190:
                    return "青蛙箱";
                case 2191:
                    return "老鼠箱";
                case 2192:
                    return "骸骨焊接机";
                case 2193:
                    return "血肉培养基";
                case 2194:
                    return "玻璃窑";
                case 2195:
                    return "神庙熔炉";
                case 2196:
                    return "生命织布机";
                case 2197:
                    return "锯云台";
                case 2198:
                    return "刨冰机";
                case 2199:
                    return "甲虫头盔";
                case 2200:
                    return "甲虫胸甲";
                case 2201:
                    return "甲虫壳";
                case 2202:
                    return "甲虫护胫";
                case 2203:
                    return "蒸汽朋克锅炉";
                case 2204:
                    return "蜂蜜分选器";
                case 2205:
                    return "企鹅";
                case 2206:
                    return "装着企鹅的笼子";
                case 2207:
                    return "装着蠕虫的笼子";
                case 2208:
                    return "空笼子";
                case 2209:
                    return "超级法力药剂";
                case 2210:
                    return "乌木栅栏";
                case 2211:
                    return "红木栅栏";
                case 2212:
                    return "珍珠木栅栏";
                case 2213:
                    return "阴影木栅栏";
                case 2214:
                    return "砖块摆放器";
                case 2215:
                    return "加长握爪";
                case 2216:
                    return "油漆喷雾器";
                case 2217:
                    return "便携式水泥搅拌器";
                case 2218:
                    return "甲虫鞘翅";
                case 2219:
                    return "星体磁铁";
                case 2220:
                    return "星体纹章";
                case 2221:
                    return "星体手铐";
                case 2222:
                    return "游商的帽子";
                case 2223:
                    return "脉冲弓";
                case 2224:
                    return "大号皇家木灯笼";
                case 2225:
                    return "皇家木灯";
                case 2226:
                    return "皇家木灯笼";
                case 2227:
                    return "大号皇家木蜡烛";
                case 2228:
                    return "皇家木椅子";
                case 2229:
                    return "皇家木工作台";
                case 2230:
                    return "皇家木箱子";
                case 2231:
                    return "皇家木床";
                case 2232:
                    return "皇家木浴缸";
                case 2233:
                    return "皇家木书架";
                case 2234:
                    return "皇家木杯子";
                case 2235:
                    return "皇家木碗";
                case 2236:
                    return "皇家木蜡烛";
                case 2237:
                    return "皇家木老爷钟";
                case 2238:
                    return "黄金老爷钟";
                case 2239:
                    return "玻璃老爷钟";
                case 2240:
                    return "蜂蜜老爷钟";
                case 2241:
                    return "蒸汽朋克老爷钟";
                case 2242:
                    return "精致的碟子";
                case 2243:
                    return "玻璃碗";
                case 2244:
                    return "高脚杯";
                case 2245:
                    return "生命之树钢琴";
                case 2246:
                    return "血肉钢琴";
                case 2247:
                    return "冰钢琴";
                case 2248:
                    return "冰桌子";
                case 2249:
                    return "蜂蜜箱子";
                case 2250:
                    return "蒸汽朋克箱子";
                case 2251:
                    return "蜂蜜工作台";
                case 2252:
                    return "冰工作台";
                case 2253:
                    return "蒸汽朋克工作台";
                case 2254:
                    return "玻璃钢琴";
                case 2255:
                    return "蜂蜜钢琴";
                case 2256:
                    return "蒸汽朋克钢琴";
                case 2257:
                    return "蜂蜜杯子";
                case 2258:
                    return "金杯";
                case 2259:
                    return "皇家木桌子";
                case 2260:
                    return "皇家木";
                case 2261:
                    return "红皇家木瓦片";
                case 2262:
                    return "蓝皇家木瓦片";
                case 2263:
                    return "白皇家木墙";
                case 2264:
                    return "蓝皇家木墙";
                case 2265:
                    return "皇家木门";
                case 2266:
                    return "清酒";
                case 2267:
                    return "泰国河粉";
                case 2268:
                    return "河粉";
                case 2269:
                    return "左轮手枪";
                case 2270:
                    return "鳄鱼枪";
                case 2271:
                    return "符文墙";
                case 2272:
                    return "水枪";
                case 2273:
                    return "武士刀";
                case 2274:
                    return "超亮火炬";
                case 2275:
                    return "魔术帽";
                case 2276:
                    return "钻石镯";
                case 2277:
                    return "夜行衣";
                case 2278:
                    return "和服";
                case 2279:
                    return "吉卜赛长袍";
                case 2280:
                    return "甲虫翼";
                case 2281:
                    return "虎皮";
                case 2282:
                    return "豹皮";
                case 2283:
                    return "斑马皮";
                case 2284:
                    return "血腥斗篷";
                case 2285:
                    return "神秘斗篷";
                case 2286:
                    return "红斗篷";
                case 2287:
                    return "保暖斗篷";
                case 2288:
                    return "冰椅子";
                case 2289:
                    return "木质鱼竿";
                case 2290:
                    return "鲈鱼";
                case 2291:
                    return "强力鱼竿";
                case 2292:
                    return "玻璃纤维鱼竿";
                case 2293:
                    return "钓魂者";
                case 2294:
                    return "黄金鱼竿";
                case 2295:
                    return "机械鱼竿";
                case 2296:
                    return "愿者上钩";
                case 2297:
                    return "鳟鱼";
                case 2298:
                    return "大马哈鱼";
                case 2299:
                    return "大西洋鳕鱼";
                case 2300:
                    return "金枪鱼";
                case 2301:
                    return "红鲷";
                case 2302:
                    return "霓虹脂鲤";
                case 2303:
                    return "装甲洞穴鱼";
                case 2304:
                    return "雀鲷";
                case 2305:
                    return "深红虎鱼";
                case 2306:
                    return "冰霜米诺鱼";
                case 2307:
                    return "公主鱼";
                case 2308:
                    return "金鲤";
                case 2309:
                    return "镜鱼";
                case 2310:
                    return "棱鱼";
                case 2311:
                    return "斑斓脂鱼";
                case 2312:
                    return "闪光锦鲤";
                case 2313:
                    return "双头鳕鱼";
                case 2314:
                    return "蜂蜜鱼";
                case 2315:
                    return "黑曜石鱼";
                case 2316:
                    return "小虾";
                case 2317:
                    return "混沌鱼";
                case 2318:
                    return "黑檀锦鲤";
                case 2319:
                    return "血腥食人鱼";
                case 2320:
                    return "岩石鱼";
                case 2321:
                    return "臭臭鱼";
                case 2322:
                    return "采矿药剂";
                case 2323:
                    return "心之彼端";
                case 2324:
                    return "镇静药剂";
                case 2325:
                    return "建筑药剂";
                case 2326:
                    return "泰坦药剂";
                case 2327:
                    return "脚蹼药剂";
                case 2328:
                    return "召唤药剂";
                case 2329:
                    return "危险感知药剂";
                case 2330:
                    return "紫色棒鱼";
                case 2331:
                    return "黑曜石剑鱼";
                case 2332:
                    return "剑鱼";
                case 2333:
                    return "铁栅栏";
                case 2334:
                    return "木制板条箱";
                case 2335:
                    return "铁制板条箱";
                case 2336:
                    return "金制板条箱";
                case 2337:
                    return "旧鞋子";
                case 2338:
                    return "海草";
                case 2339:
                    return "锡罐";
                case 2340:
                    return "矿车轨道";
                case 2341:
                    return "掠夺鲨";
                case 2342:
                    return "锯齿鲨";
                case 2343:
                    return "矿车";
                case 2344:
                    return "军火药剂";
                case 2345:
                    return "生命之力药剂";
                case 2346:
                    return "忍耐药剂";
                case 2347:
                    return "狂暴药剂";
                case 2348:
                    return "地狱降临药剂";
                case 2349:
                    return "暴怒药剂";
                case 2350:
                    return "回城药剂";
                case 2351:
                    return "随机传送药剂";
                case 2352:
                    return "爱情药剂";
                case 2353:
                    return "恶臭药剂";
                case 2354:
                    return "钓鱼药剂";
                case 2355:
                    return "声呐药剂";
                case 2356:
                    return "板条箱药剂";
                case 2357:
                    return "颤栗荆棘种子";
                case 2358:
                    return "颤栗荆棘";
                case 2359:
                    return "温暖药剂";
                case 2360:
                    return "鱼钩";
                case 2361:
                    return "蜜蜂头饰";
                case 2362:
                    return "蜜蜂胸甲";
                case 2363:
                    return "蜜蜂护胫";
                case 2364:
                    return "毒蜂法杖";
                case 2365:
                    return "魔精法杖";
                case 2366:
                    return "蜘蛛女皇法杖";
                case 2367:
                    return "渔人帽";
                case 2368:
                    return "渔人背心";
                case 2369:
                    return "渔人裤";
                case 2370:
                    return "蜘蛛面罩";
                case 2371:
                    return "蜘蛛胸甲";
                case 2372:
                    return "蜘蛛胫甲";
                case 2373:
                    return "高质渔线";
                case 2374:
                    return "渔人耳环";
                case 2375:
                    return "垂钓装备";
                case 2376:
                    return "蓝色地牢钢琴";
                case 2377:
                    return "绿色地牢钢琴";
                case 2378:
                    return "粉红地牢钢琴";
                case 2379:
                    return "黄金钢琴";
                case 2380:
                    return "黑曜石钢琴";
                case 2381:
                    return "骨质钢琴";
                case 2382:
                    return "仙人掌钢琴";
                case 2383:
                    return "幽灵木钢琴";
                case 2384:
                    return "天空钢琴";
                case 2385:
                    return "神庙钢琴";
                case 2386:
                    return "蓝色地牢梳妆台";
                case 2387:
                    return "绿色地牢梳妆台";
                case 2388:
                    return "粉色地牢梳妆台";
                case 2389:
                    return "黄金梳妆台";
                case 2390:
                    return "黑曜石梳妆台";
                case 2391:
                    return "骨质梳妆台";
                case 2392:
                    return "仙人掌梳妆台";
                case 2393:
                    return "幽灵木梳妆台";
                case 2394:
                    return "天空梳妆台";
                case 2395:
                    return "蜂蜜梳妆台";
                case 2396:
                    return "神庙梳妆台";
                case 2397:
                    return "沙发";
                case 2398:
                    return "乌木沙发";
                case 2399:
                    return "红木沙发";
                case 2400:
                    return "珍珠木沙发";
                case 2401:
                    return "阴影木沙发";
                case 2402:
                    return "蓝色地牢沙发";
                case 2403:
                    return "绿色地牢沙发";
                case 2404:
                    return "粉色地牢沙发";
                case 2405:
                    return "黄金沙发";
                case 2406:
                    return "黑曜石沙发";
                case 2407:
                    return "骨质沙发";
                case 2408:
                    return "仙人掌沙发";
                case 2409:
                    return "幽灵木沙发";
                case 2410:
                    return "天空沙发";
                case 2411:
                    return "蜂蜜沙发";
                case 2412:
                    return "蒸汽朋克沙发";
                case 2413:
                    return "蘑菇沙发";
                case 2414:
                    return "玻璃沙发";
                case 2415:
                    return "南瓜沙发";
                case 2416:
                    return "神庙沙发";
                case 2417:
                    return "贝壳发夹";
                case 2418:
                    return "人鱼饰衣";
                case 2419:
                    return "人鱼尾巴";
                case 2420:
                    return "微风鱼";
                case 2421:
                    return "血肉捕获者";
                case 2422:
                    return "热线鱼竿";
                case 2423:
                    return "蛙腿";
                case 2424:
                    return "铁锚";
                case 2425:
                    return "红烧鱼";
                case 2426:
                    return "油焖虾";
                case 2427:
                    return "生鱼片";
                case 2428:
                    return "绒毛胡萝卜";
                case 2429:
                    return "鳞片松露";
                case 2430:
                    return "史莱姆鞍";
                case 2431:
                    return "蜜蜡";
                case 2432:
                    return "铜板墙";
                case 2433:
                    return "石板墙";
                case 2434:
                    return "帆布";
                case 2435:
                    return "珊瑚块";
                case 2436:
                    return "蓝水母";
                case 2437:
                    return "绿水母";
                case 2438:
                    return "粉水母";
                case 2439:
                    return "蓝水母缸";
                case 2440:
                    return "绿水母缸";
                case 2441:
                    return "粉水母缸";
                case 2442:
                    return "救生圈";
                case 2443:
                    return "船舵";
                case 2444:
                    return "罗经刻度盘";
                case 2445:
                    return "墙锚";
                case 2446:
                    return "金鱼挂饰";
                case 2447:
                    return "兔鱼挂饰";
                case 2448:
                    return "剑鱼挂饰";
                case 2449:
                    return "荣耀之证（鲨齿）";
                case 2450:
                    return "蝙蝠鱼";
                case 2451:
                    return "黄蜂鱼";
                case 2452:
                    return "猫鱼";
                case 2453:
                    return "白云鱼";
                case 2454:
                    return "咒火鱼";
                case 2455:
                    return "泥土鱼";
                case 2456:
                    return "雷管鱼";
                case 2457:
                    return "吞噬鱼";
                case 2458:
                    return "落星鱼";
                case 2459:
                    return "克苏鲁之鱼";
                case 2460:
                    return "骸骨鱼";
                case 2461:
                    return "鹰身女妖鱼";
                case 2462:
                    return "饥饿鱼";
                case 2463:
                    return "脓血鱼";
                case 2464:
                    return "水母鱼";
                case 2465:
                    return "幻影鱼";
                case 2466:
                    return "变种雪球鱼";
                case 2467:
                    return "海豚鱼";
                case 2468:
                    return "精灵鱼";
                case 2469:
                    return "蜘蛛鱼";
                case 2470:
                    return "冻土鳟鱼";
                case 2471:
                    return "独角兽鱼";
                case 2472:
                    return "向导巫毒鱼";
                case 2473:
                    return "龙尾鱼";
                case 2474:
                    return "僵尸鱼";
                case 2475:
                    return "毒菌鱼";
                case 2476:
                    return "天使鱼";
                case 2477:
                    return "鲜血水母";
                case 2478:
                    return "骸骨鱼";
                case 2479:
                    return "兔鱼";
                case 2480:
                    return "海盗鱼";
                case 2481:
                    return "小丑鱼";
                case 2482:
                    return "地狱恶魔鱼";
                case 2483:
                    return "巨眼鱼";
                case 2484:
                    return "猪鲨";
                case 2485:
                    return "被感染的带鱼";
                case 2486:
                    return "淤泥鱼";
                case 2487:
                    return "史莱姆鱼";
                case 2488:
                    return "热带梭鱼";
                case 2489:
                    return "荣耀之证（史莱姆王）";
                case 2490:
                    return "瓶中船";
                case 2491:
                    return "海龟鞍";
                case 2492:
                    return "压力板轨道";
                case 2493:
                    return "史莱姆王面具";
                case 2494:
                    return "鱼鳍翅膀";
                case 2495:
                    return "藏宝图";
                case 2496:
                    return "海草花坛";
                case 2497:
                    return "给我去抢像素";
                case 2498:
                    return "鱼面具";
                case 2499:
                    return "鱼衬衫";
                case 2500:
                    return "鱼鳍裤";
                case 2501:
                    return "橙黄胡须";
                case 2502:
                    return "蜂蜜护目镜";
                case 2503:
                    return "北地之木";
                case 2504:
                    return "棕榈木";
                case 2505:
                    return "北地木墙";
                case 2506:
                    return "棕榈木墙";
                case 2507:
                    return "北地木栅栏";
                case 2508:
                    return "棕榈木栅栏";
                case 2509:
                    return "北地木头盔";
                case 2510:
                    return "北地木胸甲";
                case 2511:
                    return "北地木护胫";
                case 2512:
                    return "棕榈木头盔";
                case 2513:
                    return "棕榈木胸甲";
                case 2514:
                    return "棕榈木护胫";
                case 2515:
                    return "棕榈木弓";
                case 2516:
                    return "棕榈木锤";
                case 2517:
                    return "棕榈木剑";
                case 2518:
                    return "棕榈木平台";
                case 2519:
                    return "棕榈木浴缸";
                case 2520:
                    return "棕榈木床";
                case 2521:
                    return "棕榈木长椅";
                case 2522:
                    return "棕榈木烛台";
                case 2523:
                    return "棕榈木蜡烛";
                case 2524:
                    return "棕榈木椅";
                case 2525:
                    return "棕榈木吊灯";
                case 2526:
                    return "棕榈木箱";
                case 2527:
                    return "棕榈木沙发";
                case 2528:
                    return "棕榈木门";
                case 2529:
                    return "棕榈木梳妆台";
                case 2530:
                    return "棕榈木灯笼";
                case 2531:
                    return "棕榈木钢琴";
                case 2532:
                    return "棕榈木桌";
                case 2533:
                    return "棕榈木路灯";
                case 2534:
                    return "棕榈木工作台";
                case 2535:
                    return "魔眼法杖";
                case 2536:
                    return "棕榈木书柜";
                case 2537:
                    return "蘑菇浴缸";
                case 2538:
                    return "蘑菇床";
                case 2539:
                    return "蘑菇长椅";
                case 2540:
                    return "蘑菇书架";
                case 2541:
                    return "蘑菇烛台";
                case 2542:
                    return "蘑菇蜡烛";
                case 2543:
                    return "蘑菇吊灯";
                case 2544:
                    return "蘑菇箱";
                case 2545:
                    return "蘑菇梳妆台";
                case 2546:
                    return "蘑菇灯笼";
                case 2547:
                    return "蘑菇路灯";
                case 2548:
                    return "蘑菇钢琴";
                case 2549:
                    return "蘑菇平台";
                case 2550:
                    return "蘑菇桌";
                case 2551:
                    return "蜘蛛魔杖";
                case 2552:
                    return "北地木浴缸";
                case 2553:
                    return "北地木床";
                case 2554:
                    return "北地木书柜";
                case 2555:
                    return "北地木烛台";
                case 2556:
                    return "北地木蜡烛";
                case 2557:
                    return "北地木椅";
                case 2558:
                    return "北地木吊灯";
                case 2559:
                    return "北地木箱";
                case 2560:
                    return "北地木时钟";
                case 2561:
                    return "北地木门";
                case 2562:
                    return "北地木梳妆台";
                case 2563:
                    return "北地木路灯";
                case 2564:
                    return "北地灯笼";
                case 2565:
                    return "北地木钢琴";
                case 2566:
                    return "北地木平台";
                case 2567:
                    return "史莱姆浴缸";
                case 2568:
                    return "史莱姆床";
                case 2569:
                    return "史莱姆书架";
                case 2570:
                    return "史莱姆烛台";
                case 2571:
                    return "史莱姆蜡烛";
                case 2572:
                    return "史莱姆椅";
                case 2573:
                    return "史莱姆吊灯";
                case 2574:
                    return "史莱姆箱";
                case 2575:
                    return "史莱姆时钟";
                case 2576:
                    return "史莱姆门";
                case 2577:
                    return "史莱姆梳妆台";
                case 2578:
                    return "史莱姆路灯";
                case 2579:
                    return "史莱姆灯笼";
                case 2580:
                    return "史莱姆钢琴";
                case 2581:
                    return "史莱姆平台";
                case 2582:
                    return "史莱姆沙发";
                case 2583:
                    return "史莱姆桌子";
                case 2584:
                    return "海盗法杖";
                case 2585:
                    return "史莱姆";
                case 2586:
                    return "粘性手雷";
                case 2587:
                    return "鞑靼酱汁";
                case 2588:
                    return "猪鲨公爵面具";
                case 2589:
                    return "荣耀之证（猪鲨公爵）";
                case 2590:
                    return "莫洛托夫鸡尾酒";
                case 2591:
                    return "白骨时钟";
                case 2592:
                    return "仙人掌时钟";
                case 2593:
                    return "乌木时钟";
                case 2594:
                    return "冰霜时钟";
                case 2595:
                    return "神庙时钟";
                case 2596:
                    return "生命木时钟";
                case 2597:
                    return "红木时钟";
                case 2598:
                    return "血肉时钟";
                case 2599:
                    return "蘑菇时钟";
                case 2600:
                    return "黑曜石时钟";
                case 2601:
                    return "棕榈木时钟";
                case 2602:
                    return "珍珠木时钟";
                case 2603:
                    return "南瓜时钟";
                case 2604:
                    return "阴影木时钟";
                case 2605:
                    return "幽灵木时钟";
                case 2606:
                    return "日曜时钟";
                case 2607:
                    return "蜘蛛毒牙";
                case 2608:
                    return "猎鹰之刃";
                case 2609:
                    return "猪鲨翅膀";
                case 2610:
                    return "史莱姆枪";
                case 2611:
                    return "猪鲨链球";
                case 2612:
                    return "绿色地牢箱";
                case 2613:
                    return "粉色地牢箱";
                case 2614:
                    return "蓝色地牢箱";
                case 2615:
                    return "白骨箱";
                case 2616:
                    return "仙人掌箱";
                case 2617:
                    return "血肉箱";
                case 2618:
                    return "黑曜石箱";
                case 2619:
                    return "南瓜箱";
                case 2620:
                    return "幽灵木箱";
                case 2621:
                    return "风暴法杖";
                case 2622:
                    return "水刃龙卷";
                case 2623:
                    return "泡泡枪";
                case 2624:
                    return "海啸";
                case 2625:
                    return "贝壳";
                case 2626:
                    return "海星";
                case 2627:
                    return "蒸汽朋克平台";
                case 2628:
                    return "天空平台";
                case 2629:
                    return "生命木平台";
                case 2630:
                    return "蜂蜜平台";
                case 2631:
                    return "天空工作台";
                case 2632:
                    return "玻璃工作台";
                case 2633:
                    return "生命木工作台";
                case 2634:
                    return "血肉沙发";
                case 2635:
                    return "冰霜沙发";
                case 2636:
                    return "生命木沙发";
                case 2637:
                    return "南瓜梳妆台";
                case 2638:
                    return "蒸汽朋克梳妆台";
                case 2639:
                    return "玻璃梳妆台";
                case 2640:
                    return "血肉梳妆台";
                case 2641:
                    return "南瓜灯笼";
                case 2642:
                    return "黑曜石灯笼";
                case 2643:
                    return "南瓜路灯";
                case 2644:
                    return "黑曜石路灯";
                case 2645:
                    return "蓝色地牢路灯";
                case 2646:
                    return "绿色地牢路灯";
                case 2647:
                    return "粉色地牢路灯";
                case 2648:
                    return "蜂蜜蜡烛";
                case 2649:
                    return "蒸汽朋克蜡烛";
                case 2650:
                    return "幽灵木蜡烛";
                case 2651:
                    return "黑曜石蜡烛";
                case 2652:
                    return "蓝色地牢灯笼";
                case 2653:
                    return "绿色地牢灯笼";
                case 2654:
                    return "粉色地牢灯笼";
                case 2655:
                    return "蒸汽朋克灯笼";
                case 2656:
                    return "南瓜灯笼";
                case 2657:
                    return "黑曜石灯笼";
                case 2658:
                    return "蓝色地牢浴缸";
                case 2659:
                    return "绿色地牢浴缸";
                case 2660:
                    return "粉色地牢浴缸";
                case 2661:
                    return "南瓜浴缸";
                case 2662:
                    return "黑曜石浴缸";
                case 2663:
                    return "黄金浴缸";
                case 2664:
                    return "蓝色地牢烛台";
                case 2665:
                    return "绿色地牢烛台";
                case 2666:
                    return "粉色地牢烛台";
                case 2667:
                    return "黑曜石烛台";
                case 2668:
                    return "南瓜烛台";
                case 2669:
                    return "南瓜床";
                case 2670:
                    return "南瓜书架";
                case 2671:
                    return "南瓜钢琴";
                case 2672:
                    return "鲨鱼雕像";
                case 2673:
                    return "松露虫";
                case 2674:
                    return "学徒鱼饵";
                case 2675:
                    return "旅人鱼饵";
                case 2676:
                    return "大师鱼饵";
                case 2677:
                    return "琥珀墙";
                case 2678:
                    return "暗淡琥珀墙";
                case 2679:
                    return "紫水晶墙";
                case 2680:
                    return "暗淡紫水晶墙";
                case 2681:
                    return "钻石墙";
                case 2682:
                    return "暗淡钻石墙";
                case 2683:
                    return "祖母绿墙";
                case 2684:
                    return "暗淡祖母绿墙";
                case 2685:
                    return "红宝石墙";
                case 2686:
                    return "暗淡红宝石墙";
                case 2687:
                    return "蓝宝石墙";
                case 2688:
                    return "暗淡蓝宝石墙";
                case 2689:
                    return "黄晶玉墙";
                case 2690:
                    return "暗淡黄晶玉墙";
                case 2691:
                    return "锡板墙";
                case 2692:
                    return "锡板";
                case 2693:
                    return "瀑布块";
                case 2694:
                    return "岩浆瀑布块";
                case 2695:
                    return "彩纸块";
                case 2696:
                    return "彩纸墙";
                case 2697:
                    return "黑夜彩纸块";
                case 2698:
                    return "黑夜彩纸墙";
                case 2699:
                    return "武器架";
                case 2700:
                    return "焰火盒";
                case 2701:
                    return "灵火块";
                case 2702:
                    return "雕像'0'";
                case 2703:
                    return "雕像'1'";
                case 2704:
                    return "雕像'2'";
                case 2705:
                    return "雕像'3'";
                case 2706:
                    return "雕像'4'";
                case 2707:
                    return "雕像'5'";
                case 2708:
                    return "雕像'6'";
                case 2709:
                    return "雕像'7'";
                case 2710:
                    return "雕像'8'";
                case 2711:
                    return "雕像'9'";
                case 2712:
                    return "雕像'A'";
                case 2713:
                    return "雕像'B'";
                case 2714:
                    return "雕像'C'";
                case 2715:
                    return "雕像'D'";
                case 2716:
                    return "雕像'E'";
                case 2717:
                    return "雕像'F'";
                case 2718:
                    return "雕像'G'";
                case 2719:
                    return "雕像'H'";
                case 2720:
                    return "雕像'I'";
                case 2721:
                    return "雕像'J'";
                case 2722:
                    return "雕像'K'";
                case 2723:
                    return "雕像'L'";
                case 2724:
                    return "雕像'M'";
                case 2725:
                    return "雕像'N'";
                case 2726:
                    return "雕像'O'";
                case 2727:
                    return "雕像'P'";
                case 2728:
                    return "雕像'Q'";
                case 2729:
                    return "雕像'R'";
                case 2730:
                    return "雕像'S'";
                case 2731:
                    return "雕像'T'";
                case 2732:
                    return "雕像'U'";
                case 2733:
                    return "雕像'V'";
                case 2734:
                    return "雕像'W'";
                case 2735:
                    return "雕像'X'";
                case 2736:
                    return "雕像'Y'";
                case 2737:
                    return "雕像'Z'";
                case 2738:
                    return "焰火喷泉";
                case 2739:
                    return "加速轨道";
                case 2740:
                    return "蚱蜢";
                case 2741:
                    return "蚱蜢笼";
                case 2742:
                    return "音乐盒（血色地底）";
                case 2743:
                    return "仙人掌桌";
                case 2744:
                    return "仙人掌平台";
                case 2745:
                    return "北地木剑";
                case 2746:
                    return "北地木锤";
                case 2747:
                    return "北地木弓";
                case 2748:
                    return "玻璃箱子";
                case 2749:
                    return "外星法杖";
                case 2750:
                    return "流星杖";
                case 2751:
                    return "灵咒火块";
                case 2752:
                    return "灵魔火块";
                case 2753:
                    return "灵霜火块";
                case 2754:
                    return "灵脓水块";
                case 2755:
                    return "超亮灵火块";
                case 2756:
                    return "性别转换药剂";
                case 2757:
                    return "漩涡头盔";
                case 2758:
                    return "漩涡胸甲";
                case 2759:
                    return "漩涡腿甲";
                case 2760:
                    return "星云之盔";
                case 2761:
                    return "星云胸甲";
                case 2762:
                    return "星云腿甲";
                case 2763:
                    return "太阳耀斑头盔";
                case 2764:
                    return "太阳耀斑胸甲";
                case 2765:
                    return "太阳耀斑腿甲";
                case 2766:
                    return "日光石碑碎片";
                case 2767:
                    return "日光石碑";
                case 2768:
                    return "挖掘机说明书";
                case 2769:
                    return "宇宙车钥匙";
                case 2770:
                    return "蜂蛾之翼";
                case 2771:
                    return "大脑遥控器";
                case 2772:
                    return "";
                case 2773:
                    return "";
                case 2774:
                    return "";
                case 2775:
                    return "";
                case 2776:
                    return "漩涡镐";
                case 2777:
                    return "";
                case 2778:
                    return "";
                case 2779:
                    return "";
                case 2780:
                    return "";
                case 2781:
                    return "星云镐";
                case 2782:
                    return "";
                case 2783:
                    return "";
                case 2784:
                    return "";
                case 2785:
                    return "";
                case 2786:
                    return "太阳耀斑镐";
                case 2787:
                    return "蜂蜜瀑布块";
                case 2788:
                    return "蜂蜜瀑布墙";
                case 2789:
                    return "叶绿砖墙";
                case 2790:
                    return "血腥石砖墙";
                case 2791:
                    return "蓝光板墙";
                case 2792:
                    return "叶绿砖";
                case 2793:
                    return "血腥石砖";
                case 2794:
                    return "蓝光 Pla锡制g";
                case 2795:
                    return "镭射枪";
                case 2796:
                    return "电子层发射器";
                case 2797:
                    return "外星枪";
                case 2798:
                    return "激光钻头";
                case 2799:
                    return "机械尺子";
                case 2800:
                    return "反重力钩爪";
                case 2801:
                    return "月亮面具";
                case 2802:
                    return "太阳面具";
                case 2803:
                    return "火星戏服面具";
                case 2804:
                    return "火星戏服衬衫";
                case 2805:
                    return "火星戏服裤子";
                case 2806:
                    return "火星制服头盔";
                case 2807:
                    return "火星制服躯干";
                case 2808:
                    return "火星制服裤子";
                case 2809:
                    return "火星天文钟";
                case 2810:
                    return "火星浴缸";
                case 2811:
                    return "火星床";
                case 2812:
                    return "火星悬空椅子";
                case 2813:
                    return "火星吊灯";
                case 2814:
                    return "火星箱";
                case 2815:
                    return "火星门";
                case 2816:
                    return "火星梳妆台";
                case 2817:
                    return "火星全息书架";
                case 2818:
                    return "火星悬浮蜡烛";
                case 2819:
                    return "火星灯柱";
                case 2820:
                    return "火星灯";
                case 2821:
                    return "火星钢琴";
                case 2822:
                    return "火星平台";
                case 2823:
                    return "火星沙发";
                case 2824:
                    return "火星桌子";
                case 2825:
                    return "火星桌子灯";
                case 2826:
                    return "火星工作台";
                case 2827:
                    return "木制洗手池";
                case 2828:
                    return "黑檀木洗手池";
                case 2829:
                    return "皇家红木洗手池";
                case 2830:
                    return "珍珠木洗手池";
                case 2831:
                    return "骨头洗手池";
                case 2832:
                    return "血肉洗手池";
                case 2833:
                    return "生命木洗手池";
                case 2834:
                    return "天空洗手池";
                case 2835:
                    return "阴影木洗手池";
                case 2836:
                    return "神庙洗手池";
                case 2837:
                    return "蓝色地牢洗手池";
                case 2838:
                    return "绿色地牢洗手池";
                case 2839:
                    return "粉色地牢洗手池";
                case 2840:
                    return "黑曜石洗手池";
                case 2841:
                    return "金属洗手池";
                case 2842:
                    return "玻璃洗手池";
                case 2843:
                    return "黄金洗手池";
                case 2844:
                    return "蜂蜜洗手池";
                case 2845:
                    return "蒸汽朋克洗手池";
                case 2846:
                    return "南瓜洗手池";
                case 2847:
                    return "幽灵木洗手池";
                case 2848:
                    return "冰封洗手池";
                case 2849:
                    return "王朝洗手池";
                case 2850:
                    return "棕榈木洗手池";
                case 2851:
                    return "蘑菇洗手池";
                case 2852:
                    return "北地木洗手池";
                case 2853:
                    return "史莱姆洗手池";
                case 2854:
                    return "仙人掌洗手池";
                case 2855:
                    return "火星洗手池";
                case 2856:
                    return "日光教徒面罩";
                case 2857:
                    return "狂信教徒面罩";
                case 2858:
                    return "日光教徒杖";
                case 2859:
                    return "狂信教徒杖";
                case 2860:
                    return "火星管道板";
                case 2861:
                    return "火星管道墙";
                case 2862:
                    return "高科技太阳镜";
                case 2863:
                    return "火星染发剂";
                case 2864:
                    return "火星染料";
                case 2865:
                    return "马尔斯贝格城堡";
                case 2866:
                    return "马蒂亚丽莎";
                case 2867:
                    return "真相就在那里";
                case 2868:
                    return "烟雾块";
                case 2869:
                    return "灵火染料";
                case 2870:
                    return "生命彩虹染料";
                case 2871:
                    return "暗影染料";
                case 2872:
                    return "消极染料";
                case 2873:
                    return "生命之海染料";
                case 2874:
                    return "棕色染料";
                case 2875:
                    return "棕黑染料";
                case 2876:
                    return "亮棕色染料";
                case 2877:
                    return "棕银染料";
                case 2878:
                    return "妖精染料";
                case 2879:
                    return "小精灵染料";
                case 2880:
                    return "波动之刃";
                case 2881:
                    return "";
                case 2882:
                    return "蓄电激光炮";
                case 2883:
                    return "叶绿染料";
                case 2884:
                    return "独角兽妖精染料";
                case 2885:
                    return "地狱妖精染料";
                case 2886:
                    return "邪恶粉末";
                case 2887:
                    return "邪恶蘑菇";
                case 2888:
                    return "蜜蜂腿";
                case 2889:
                    return "金鸟";
                case 2890:
                    return "金兔子";
                case 2891:
                    return "金蝴蝶";
                case 2892:
                    return "金青蛙";
                case 2893:
                    return "金蚱蜢";
                case 2894:
                    return "金老鼠";
                case 2895:
                    return "金毛虫";
                case 2896:
                    return "粘性炸药";
                case 2897:
                    return "愤怒捕猎者旗帜";
                case 2898:
                    return "盔甲维京人旗帜";
                case 2899:
                    return "黑史莱姆旗帜";
                case 2900:
                    return "蓝色装甲骷髅旗帜";
                case 2901:
                    return "蓝色教徒弓手旗帜";
                case 2902:
                    return "蓝色教徒法师旗帜";
                case 2903:
                    return "蓝色教徒战士旗帜";
                case 2904:
                    return "李小龙之骸旗帜";
                case 2905:
                    return "粘附者旗帜";
                case 2906:
                    return "红色甲虫旗帜";
                case 2907:
                    return "腐化企鹅旗帜";
                case 2908:
                    return "腐化史莱姆旗帜";
                case 2909:
                    return "腐化者旗帜";
                case 2910:
                    return "血腥史莱姆旗帜";
                case 2911:
                    return "诅咒头骨旗帜";
                case 2912:
                    return "青色甲虫旗帜";
                case 2913:
                    return "吞噬者旗帜";
                case 2914:
                    return "着魔者旗帜";
                case 2915:
                    return "骷髅医生旗帜";
                case 2916:
                    return "地牢史莱姆旗帜";
                case 2917:
                    return "地牢幽魂旗帜";
                case 2918:
                    return "精灵弓箭手旗帜";
                case 2919:
                    return "精灵直升机旗帜";
                case 2920:
                    return "魔眼僵尸旗帜";
                case 2921:
                    return "雪花怪旗帜";
                case 2922:
                    return "幽灵旗帜";
                case 2923:
                    return "巨型蝙蝠旗帜";
                case 2924:
                    return "巨型诅咒头骨旗帜";
                case 2925:
                    return "巨大飞狐旗帜";
                case 2926:
                    return "姜饼人旗帜";
                case 2927:
                    return "哥布林弓箭手旗帜";
                case 2928:
                    return "绿色 史莱姆旗帜";
                case 2929:
                    return "无头骑士旗帜";
                case 2930:
                    return "地狱装甲骷髅旗帜";
                case 2931:
                    return "地狱犬旗帜";
                case 2932:
                    return "希望杰克旗帜";
                case 2933:
                    return "冰霜蝙蝠旗帜";
                case 2934:
                    return "寒冰巨人旗帜";
                case 2935:
                    return "冰霜史莱姆旗帜";
                case 2936:
                    return "脓血乌贼旗帜";
                case 2937:
                    return "夜光蝙蝠旗帜";
                case 2938:
                    return "夜光史莱姆旗帜";
                case 2939:
                    return "丛林蝙蝠旗帜";
                case 2940:
                    return "丛林史莱姆旗帜";
                case 2941:
                    return "圣诞怪人旗帜";
                case 2942:
                    return "紫甲虫旗帜";
                case 2943:
                    return "熔岩蝙蝠旗帜";
                case 2944:
                    return "熔岩史莱姆旗帜";
                case 2945:
                    return "火星大脑遥控器旗帜";
                case 2946:
                    return "火星无人机旗帜";
                case 2947:
                    return "火星工程师旗帜";
                case 2948:
                    return "火星千兆遥控器旗帜";
                case 2949:
                    return "火星灰色咕噜旗帜";
                case 2950:
                    return "火星军官旗帜";
                case 2951:
                    return "火星镭射枪手旗帜";
                case 2952:
                    return "火星蛞蝓枪手旗帜";
                case 2953:
                    return "火星特斯拉炮塔旗帜";
                case 2954:
                    return "怪先生旗帜";
                case 2955:
                    return "史莱姆之母旗帜";
                case 2956:
                    return "死灵法师旗帜";
                case 2957:
                    return "胡桃夹子旗帜";
                case 2958:
                    return "圣骑士旗帜";
                case 2959:
                    return "企鹅旗帜";
                case 2960:
                    return "粉红酱旗帜";
                case 2961:
                    return "鬼魂旗帜";
                case 2962:
                    return "诅咒铠甲旗帜";
                case 2963:
                    return "宝箱怪旗帜";
                case 2964:
                    return "紫色史莱姆旗帜";
                case 2965:
                    return "破碎投掷者旗帜";
                case 2966:
                    return "彩虹 史莱姆旗帜";
                case 2967:
                    return "乌鸦旗帜";
                case 2968:
                    return "红色史莱姆旗帜";
                case 2969:
                    return "符文法师旗帜";
                case 2970:
                    return "锈蚀装甲骷髅旗帜";
                case 2971:
                    return "稻草人旗帜";
                case 2972:
                    return "蛞蝓旗帜";
                case 2973:
                    return "骷髅弓手旗帜";
                case 2974:
                    return "骷髅突击队员旗帜";
                case 2975:
                    return "骷髅狙击手旗帜";
                case 2976:
                    return "史莱姆r旗帜";
                case 2977:
                    return "掠夺者旗帜";
                case 2978:
                    return "雪怪旗帜";
                case 2979:
                    return "雪人黑手党旗帜";
                case 2980:
                    return "冰刺史莱姆旗帜";
                case 2981:
                    return "毒刺史莱姆旗帜";
                case 2982:
                    return "幽灵树妖旗帜";
                case 2983:
                    return "鱿鱼旗帜";
                case 2984:
                    return "战术骷髅旗帜";
                case 2985:
                    return "新郎旗帜";
                case 2986:
                    return "Tim旗帜";
                case 2987:
                    return "不死矿工旗帜";
                case 2988:
                    return "维京亡灵旗帜";
                case 2989:
                    return "白色邪教徒弓手旗帜";
                case 2990:
                    return "白色邪教徒法师旗帜";
                case 2991:
                    return "白色邪教徒战士旗帜";
                case 2992:
                    return "黄色史莱姆旗帜";
                case 2993:
                    return "雪男旗帜";
                case 2994:
                    return "僵尸精灵旗帜";
                case 2995:
                    return "活力";
                case 2996:
                    return "藤绳";
                case 2997:
                    return "虫洞药水";
                case 2998:
                    return "召唤师徽章";
                case 2999:
                    return "迷人的桌子";
                case 3000:
                    return "炼金术桌子";
                case 3001:
                    return "奇怪的酿造厂";
                case 3002:
                    return "洞穴探险荧光棒";
                case 3003:
                    return "骨头箭";
                case 3004:
                    return "骨头火把";
                case 3005:
                    return "藤绳圈";
                case 3006:
                    return "生命汲取";
                case 3007:
                    return "毒箭手枪";
                case 3008:
                    return "毒箭来复枪";
                case 3009:
                    return "水晶飞箭";
                case 3010:
                    return "诅咒飞箭";
                case 3011:
                    return "脓血飞箭";
                case 3012:
                    return "锁链断头台";
                case 3013:
                    return "邪恶之爪";
                case 3014:
                    return "黏着者杖";
                case 3015:
                    return "邪恶之粉";
                case 3016:
                    return "血肉指套";
                case 3017:
                    return "花之靴";
                case 3018:
                    return "种子弯刀";
                case 3019:
                    return "地狱之翼弓";
                case 3020:
                    return "肉筋钩爪";
                case 3021:
                    return "荆棘钩爪";
                case 3022:
                    return "发光钩爪";
                case 3023:
                    return "蠕虫钩爪";
                case 3024:
                    return "Skiphs之血";
                case 3025:
                    return "紫色软泥染料";
                case 3026:
                    return "反光银色染料";
                case 3027:
                    return "反光金色染料";
                case 3028:
                    return "蓝色酸性染料";
                case 3029:
                    return "代达罗斯风暴弓";
                case 3030:
                    return "飞刀";
                case 3031:
                    return "无底水桶";
                case 3032:
                    return "超级吸水海绵";
                case 3033:
                    return "金戒指";
                case 3034:
                    return "硬币戒指";
                case 3035:
                    return "贪婪指环";
                case 3036:
                    return "寻鱼者";
                case 3037:
                    return "气象广播";
                case 3038:
                    return "冥王染料";
                case 3039:
                    return "暮光染料";
                case 3040:
                    return "酸性染料";
                case 3041:
                    return "发光蘑菇染料";
                case 3042:
                    return "相位染料";
                case 3043:
                    return "魔法灯";
                case 3044:
                    return "音乐盒(月球BOSS)";
                case 3045:
                    return "彩虹火把";
                case 3046:
                    return "诅咒篝火";
                case 3047:
                    return "恶魔篝火";
                case 3048:
                    return "冰封篝火";
                case 3049:
                    return "脓血篝火";
                case 3050:
                    return "彩虹篝火";
                case 3051:
                    return "恶俗的水晶碎片";
                case 3052:
                    return "暗影之炎弓";
                case 3053:
                    return "暗影之炎六角娃娃";
                case 3054:
                    return "暗影之炎小刀";
                case 3055:
                    return "橡子";
                case 3056:
                    return "寒流";
                case 3057:
                    return "被诅咒的圣人";
                case 3058:
                    return "雪人小伙伴";
                case 3059:
                    return "季节";
                case 3060:
                    return "骨头拨浪鼓";
                case 3061:
                    return "建筑工具包";
                case 3062:
                    return "血腥之心";
                case 3063:
                    return "喵星人之刃";
                case 3064:
                    return "魔法日晷";
                case 3065:
                    return "星辰之怒";
                case 3066:
                    return "光滑的大理石块";
                case 3067:
                    return "狱炎砖墙";
                case 3068:
                    return "植物纤维编绳入门";
                case 3069:
                    return "闪光魔杖";
                case 3070:
                    return "金鸟笼";
                case 3071:
                    return "金兔子笼";
                case 3072:
                    return "金蝴蝶罐";
                case 3073:
                    return "金青蛙笼";
                case 3074:
                    return "金蚱蜢笼";
                case 3075:
                    return "金老鼠笼";
                case 3076:
                    return "金毛虫笼";
                case 3077:
                    return "丝质绳子";
                case 3078:
                    return "网织绳子";
                case 3079:
                    return "丝绳圈";
                case 3080:
                    return "网绳圈";
                case 3081:
                    return "大理石块";
                case 3082:
                    return "大理石墙";
                case 3083:
                    return "光滑的大理石墙";
                case 3084:
                    return "雷达";
                case 3085:
                    return "黄金保险箱";
                case 3086:
                    return "花岗岩块";
                case 3087:
                    return "光滑的花岗岩块";
                case 3088:
                    return "花岗岩墙";
                case 3089:
                    return "光滑的花岗岩墙";
                case 3090:
                    return "皇家凝胶";
                case 3091:
                    return "夜之钥匙";
                case 3092:
                    return "昼之钥匙";
                case 3093:
                    return "草药袋";
                case 3094:
                    return "标枪";
                case 3095:
                    return "检尺计数器";
                case 3096:
                    return "六分仪";
                case 3097:
                    return "克苏鲁之盾";
                case 3098:
                    return "屠夫的链锯";
                case 3099:
                    return "秒表";
                case 3100:
                    return "陨铁砖";
                case 3101:
                    return "陨铁砖墙";
                case 3102:
                    return "金属探测器";
                case 3103:
                    return "无限箭袋";
                case 3104:
                    return "无限弹药袋";
                case 3105:
                    return "毒剂烧瓶";
                case 3106:
                    return "精神之刃";
                case 3107:
                    return "射钉机";
                case 3108:
                    return "钉子";
                case 3109:
                    return "夜视头盔";
                case 3110:
                    return "天体贝壳";
                case 3111:
                    return "粉色凝胶";
                case 3112:
                    return "弹性荧光棒";
                case 3113:
                    return "粉色史莱姆块";
                case 3114:
                    return "粉色火炬";
                case 3115:
                    return "弹性炸弹";
                case 3116:
                    return "弹性手雷";
                case 3117:
                    return "和平蜡烛";
                case 3118:
                    return "生命体分析仪";
                case 3119:
                    return "DPS计量器";
                case 3120:
                    return "渔人袖珍指南";
                case 3121:
                    return "哥布林科技";
                case 3122:
                    return "R.E.K. 3000（杀怪计量器）";
                case 3123:
                    return "PDA（数据统计器）";
                case 3124:
                    return "手机";
                case 3125:
                    return "花岗岩箱";
                case 3126:
                    return "陨铁钟";
                case 3127:
                    return "大理石钟";
                case 3128:
                    return "花岗岩钟";
                case 3129:
                    return "陨铁门";
                case 3130:
                    return "大理石门";
                case 3131:
                    return "花岗岩门";
                case 3132:
                    return "陨铁梳妆台";
                case 3133:
                    return "大理石梳妆台";
                case 3134:
                    return "花岗岩梳妆台";
                case 3135:
                    return "陨铁灯";
                case 3136:
                    return "大理石灯";
                case 3137:
                    return "花岗岩灯";
                case 3138:
                    return "陨铁灯";
                case 3139:
                    return "大理石灯";
                case 3140:
                    return "花岗岩灯";
                case 3141:
                    return "陨铁钢琴";
                case 3142:
                    return "大理石钢琴";
                case 3143:
                    return "花岗岩钢琴";
                case 3144:
                    return "陨铁平台";
                case 3145:
                    return "大理石平台";
                case 3146:
                    return "花岗岩平台";
                case 3147:
                    return "陨铁洗手池";
                case 3148:
                    return "大理石洗手池";
                case 3149:
                    return "花岗岩洗手池";
                case 3150:
                    return "陨铁沙发";
                case 3151:
                    return "大理石沙发";
                case 3152:
                    return "花岗岩沙发";
                case 3153:
                    return "陨铁桌子";
                case 3154:
                    return "大理石桌子";
                case 3155:
                    return "花岗岩桌子";
                case 3156:
                    return "陨铁工作台";
                case 3157:
                    return "大理石工作台";
                case 3158:
                    return "花岗岩工作台";
                case 3159:
                    return "陨铁浴缸";
                case 3160:
                    return "大理石浴缸";
                case 3161:
                    return "花岗岩浴缸";
                case 3162:
                    return "陨铁床";
                case 3163:
                    return "大理石床";
                case 3164:
                    return "花岗岩床";
                case 3165:
                    return "陨铁书架";
                case 3166:
                    return "大理石书架";
                case 3167:
                    return "花岗岩书架";
                case 3168:
                    return "陨铁烛台";
                case 3169:
                    return "大理石烛台";
                case 3170:
                    return "花岗岩烛台";
                case 3171:
                    return "陨铁蜡烛";
                case 3172:
                    return "大理石蜡烛";
                case 3173:
                    return "花岗岩蜡烛";
                case 3174:
                    return "陨铁椅子";
                case 3175:
                    return "大理石椅子";
                case 3176:
                    return "花岗岩椅子";
                case 3177:
                    return "陨铁吊灯";
                case 3178:
                    return "大理石吊灯";
                case 3179:
                    return "花岗岩吊灯";
                case 3180:
                    return "陨铁箱";
                case 3181:
                    return "大理石箱";
                case 3182:
                    return "魔法滴管";
                case 3183:
                    return "黄金捕虫网";
                case 3184:
                    return "魔法熔岩滴管";
                case 3185:
                    return "魔法蜂蜜滴管";
                case 3186:
                    return "空滴管";
                case 3187:
                    return "角斗士盔";
                case 3188:
                    return "角斗士胸甲";
                case 3189:
                    return "角斗士腿甲";
                case 3190:
                    return "反光染料";
                case 3191:
                    return "魔法夜行者";
                case 3192:
                    return "浊鱼";
                case 3193:
                    return "蛞蝓";
                case 3194:
                    return "甲壳虫";
                case 3195:
                    return "幼虫汤";
                case 3196:
                    return "炸弹鱼";
                case 3197:
                    return "冰霜短剑鱼";
                case 3198:
                    return "锐化站";
                case 3199:
                    return "冰镜";
                case 3200:
                    return "旗鱼靴";
                case 3201:
                    return "海啸瓶";
                case 3202:
                    return "练习用假人";
                case 3203:
                    return "腐化板条箱";
                case 3204:
                    return "血腥板条箱";
                case 3205:
                    return "地牢板条箱";
                case 3206:
                    return "天空板条箱";
                case 3207:
                    return "神圣板条箱";
                case 3208:
                    return "丛林板条箱";
                case 3209:
                    return "水晶蛇";
                case 3210:
                    return "毒刺鱼";
                case 3211:
                    return "舌刃";
                case 3212:
                    return "尖牙项链";
                case 3213:
                    return "金钱槽";
                case 3214:
                    return "泡泡";
                case 3215:
                    return "太阳花种植箱";
                case 3216:
                    return "月光草种植箱";
                case 3217:
                    return "死亡草种植箱";
                case 3218:
                    return "死亡草种植箱";
                case 3219:
                    return "闪耀根种植箱";
                case 3220:
                    return "波浪叶种植箱";
                case 3221:
                    return "颤栗荆棘种植箱";
                case 3222:
                    return "火焰花种植箱";
                case 3223:
                    return "混乱之脑";
                case 3224:
                    return "毛虫围巾";
                case 3225:
                    return "气球河豚";
                case 3226:
                    return "拉泽尔的女武神头饰";
                case 3227:
                    return "拉泽尔的女武神斗篷";
                case 3228:
                    return "拉泽尔的女武神长靴";
                case 3229:
                    return "黄金十字墓标";
                case 3230:
                    return "黄金墓石";
                case 3231:
                    return "黄金幕标";
                case 3232:
                    return "黄金墓碑";
                case 3233:
                    return "黄金方尖碑";
                case 3234:
                    return "水晶块";
                case 3235:
                    return "音乐盒(火星的疯狂)";
                case 3236:
                    return "音乐盒(海盗入侵)";
                case 3237:
                    return "音乐盒(地狱)";
                case 3238:
                    return "水晶块墙";
                case 3239:
                    return "陷阱门";
                case 3240:
                    return "很高的门";
                case 3241:
                    return "猪鲨气球";
                case 3242:
                    return "讨税人帽子";
                case 3243:
                    return "讨税人制服";
                case 3244:
                    return "讨税人裤子";
                case 3245:
                    return "骨头手套";
                case 3246:
                    return "裁缝的夹克";
                case 3247:
                    return "裁缝的裤子";
                case 3248:
                    return "染料商的头巾";
                case 3249:
                    return "致命之球法杖";
                case 3250:
                    return "绿色马掌气球";
                case 3251:
                    return "琥珀马掌气球";
                case 3252:
                    return "粉色马掌气球";
                case 3253:
                    return "熔岩灯";
                case 3254:
                    return "魔法夜行者笼";
                case 3255:
                    return "甲壳虫笼";
                case 3256:
                    return "幼虫笼";
                case 3257:
                    return "蛞蝓笼";
                case 3258:
                    return "巴掌";
                case 3259:
                    return "暮光之城染发剂";
                case 3260:
                    return "祝福苹果";
                case 3261:
                    return "幽灵锭";
                case 3262:
                    return "Code 1";
                case 3263:
                    return "强盗头巾";
                case 3264:
                    return "强盗外衣";
                case 3265:
                    return "强盗马裤";
                case 3266:
                    return "黑曜石逃犯帽子";
                case 3267:
                    return "黑曜石长衫";
                case 3268:
                    return "黑曜石裤子";
                case 3269:
                    return "美杜莎之首";
                case 3270:
                    return "物品框";
                case 3271:
                    return "砂石块";
                case 3272:
                    return "硬砂块";
                case 3273:
                    return "";
                case 3274:
                    return "坚硬黑檀砂块";
                case 3275:
                    return "坚硬血腥砂块";
                case 3276:
                    return "黑檀砂石块";
                case 3277:
                    return "血腥砂石块";
                case 3278:
                    return "木制悠悠球";
                case 3279:
                    return "萎靡不振";
                case 3280:
                    return "动脉";
                case 3281:
                    return "亚马逊";
                case 3282:
                    return "倾泻物";
                case 3283:
                    return "雏鸟";
                case 3284:
                    return "Code 2";
                case 3285:
                    return "集合";
                case 3286:
                    return "叶列茨悠悠球";
                case 3287:
                    return "瑞德之投掷";
                case 3288:
                    return "女武神悠悠球";
                case 3289:
                    return "Amarok";
                case 3290:
                    return "地狱火";
                case 3291:
                    return "海怪";
                case 3292:
                    return "克苏鲁之眼";
                case 3293:
                    return "红色字符串";
                case 3294:
                    return "橙色字符串";
                case 3295:
                    return "黄色字符串";
                case 3296:
                    return "柠檬色字符串";
                case 3297:
                    return "绿色字符串";
                case 3298:
                    return "蓝绿色字符串";
                case 3299:
                    return "青色字符串";
                case 3300:
                    return "天蓝色字符串";
                case 3301:
                    return "蓝色字符串";
                case 3302:
                    return "紫色字符串";
                case 3303:
                    return "紫罗兰色字符串";
                case 3304:
                    return "粉色字符串";
                case 3305:
                    return "棕色字符串";
                case 3306:
                    return "白色字符串";
                case 3307:
                    return "彩虹字符串";
                case 3308:
                    return "黑色字符串";
                case 3309:
                    return "黑色称锤";
                case 3310:
                    return "蓝色称锤";
                case 3311:
                    return "绿色称锤";
                case 3312:
                    return "紫色称锤";
                case 3313:
                    return "红色称锤";
                case 3314:
                    return "黄色称锤";
                case 3315:
                    return "格式化C盘";
                case 3316:
                    return "偏斜";
                case 3317:
                    return "英勇";
                case 3318:
                    return "银财宝袋";
                case 3319:
                    return "银财宝袋";
                case 3320:
                    return "银财宝袋";
                case 3321:
                    return "银财宝袋";
                case 3322:
                    return "银财宝袋";
                case 3323:
                    return "银财宝袋";
                case 3324:
                    return "银财宝袋";
                case 3325:
                    return "银财宝袋";
                case 3326:
                    return "银财宝袋";
                case 3327:
                    return "银财宝袋";
                case 3328:
                    return "银财宝袋";
                case 3329:
                    return "银财宝袋";
                case 3330:
                    return "银财宝袋";
                case 3331:
                    return "银财宝袋";
                case 3332:
                    return "银财宝袋";
                case 3333:
                    return "蜂窝袋";
                case 3334:
                    return "悠悠手套";
                case 3335:
                    return "恶魔之心";
                case 3336:
                    return "孢子囊";
                case 3337:
                    return "闪光石";
                case 3338:
                    return "坚硬珍珠砂块";
                case 3339:
                    return "珍珠砂石块";
                case 3340:
                    return "";
                case 3341:
                    return "";
                case 3342:
                    return "";
                case 3343:
                    return "";
                case 3344:
                    return "";
                case 3345:
                    return "";
                case 3346:
                    return "";
                case 3347:
                    return "沙漠化石";
                case 3348:
                    return "沙漠化石墙";
                case 3349:
                    return "异域弯刀";
                case 3350:
                    return "彩弹枪";
                case 3351:
                    return "优雅手杖";
                case 3352:
                    return "时尚剪刀";
                case 3353:
                    return "机械车";
                case 3354:
                    return "机械轮胎碎片";
                case 3355:
                    return "机械货车碎片";
                case 3356:
                    return "机械电池碎片";
                case 3357:
                    return "荣耀之证-远古教徒";
                case 3358:
                    return "荣耀之证-火星飞碟";
                case 3359:
                    return "荣耀之证-飞翔荷兰人号";
                case 3360:
                    return "生命红木杖";
                case 3361:
                    return "皇家红木叶子手杖";
                case 3362:
                    return "堕落燕尾服衬衫";
                case 3363:
                    return "堕落燕尾服裤子";
                case 3364:
                    return "壁炉";
                case 3365:
                    return "烟囱";
                case 3366:
                    return "悠悠球袋";
                case 3367:
                    return "矮松露";
                case 3368:
                    return "弧光剑";
                case 3369:
                    return "彩纸炮";
                case 3370:
                    return "音乐盒(塔)";
                case 3371:
                    return "音乐盒(哥布林入侵)";
                case 3372:
                    return "远古教徒面具";
                case 3373:
                    return "潮汐之月面具";
                case 3374:
                    return "化石头盔";
                case 3375:
                    return "化石板甲";
                case 3376:
                    return "化石护腿";
                case 3377:
                    return "琥珀魔杖";
                case 3378:
                    return "骨头标枪";
                case 3379:
                    return "骨头飞刀";
                case 3380:
                    return "坚固化石";
                case 3381:
                    return "星尘头盔";
                case 3382:
                    return "星尘板甲";
                case 3383:
                    return "星尘腿甲";
                case 3384:
                    return "传送枪";
                case 3385:
                    return "奇怪的植物";
                case 3386:
                    return "奇怪的植物";
                case 3387:
                    return "奇怪的植物";
                case 3388:
                    return "奇怪的植物";
                case 3389:
                    return "泰拉瑞亚悠悠球";
                case 3390:
                    return "哥布林召唤师旗帜";
                case 3391:
                    return "火蜥蜴旗帜";
                case 3392:
                    return "巨贝旗帜";
                case 3393:
                    return "龙虾旗帜";
                case 3394:
                    return "弗里茨旗帜";
                case 3395:
                    return "深邃生物旗帜";
                case 3396:
                    return "苍蝇人博士旗帜";
                case 3397:
                    return "蜂蛾旗帜";
                case 3398:
                    return "断手旗帜";
                case 3399:
                    return "妖婆旗帜";
                case 3400:
                    return "屠夫旗帜";
                case 3401:
                    return "疯子旗帜";
                case 3402:
                    return "致命之球旗帜";
                case 3403:
                    return "钉子头旗帜";
                case 3404:
                    return "毒孢子旗帜";
                case 3405:
                    return "美杜莎旗帜";
                case 3406:
                    return "重装步兵旗帜";
                case 3407:
                    return "花岗岩元素旗帜";
                case 3408:
                    return "Grolem旗帜";
                case 3409:
                    return "鲜血僵尸旗帜";
                case 3410:
                    return "滴落者旗帜";
                case 3411:
                    return "墓穴之爪旗帜";
                case 3412:
                    return "掘砂者旗帜";
                case 3413:
                    return "蚁狮群旗帜";
                case 3414:
                    return "蚁狮蓄力者旗帜";
                case 3415:
                    return "食尸鬼旗帜";
                case 3416:
                    return "拉弥亚旗帜";
                case 3417:
                    return "沙漠幽魂旗帜";
                case 3418:
                    return "蛇怪旗帜";
                case 3419:
                    return "破坏者蝎子旗帜";
                case 3420:
                    return "星尘士兵旗帜";
                case 3421:
                    return "银河织女旗帜";
                case 3422:
                    return "激流入侵者旗帜";
                case 3423:
                    return "闪烁射击者旗帜";
                case 3424:
                    return "小星形细胞旗帜";
                case 3425:
                    return "星形细胞旗帜";
                case 3426:
                    return "太空头骨旗帜";
                case 3427:
                    return "太空士兵旗帜";
                case 3428:
                    return "太空蠕虫旗帜";
                case 3429:
                    return "太空骑士旗帜";
                case 3430:
                    return "太空蜥蜴旗帜";
                case 3431:
                    return "日光住民旗帜";
                case 3432:
                    return "星云士兵旗帜";
                case 3433:
                    return "星云猎头蟹旗帜";
                case 3434:
                    return "星云浮游物旗帜";
                case 3435:
                    return "星云野兽旗帜";
                case 3436:
                    return "外星幼虫旗帜";
                case 3437:
                    return "外星女王旗帜";
                case 3438:
                    return "空间黄蜂旗帜";
                case 3439:
                    return "漩涡士兵旗帜";
                case 3440:
                    return "漩涡步枪兵旗帜";
                case 3441:
                    return "海盗船长旗帜";
                case 3442:
                    return "海盗枪手旗帜";
                case 3443:
                    return "海盗船旗帜";
                case 3444:
                    return "海盗十字弓手旗帜";
                case 3445:
                    return "火星漫步者旗帜";
                case 3446:
                    return "红恶魔旗帜";
                case 3447:
                    return "粉色水母旗帜";
                case 3448:
                    return "绿色水母旗帜";
                case 3449:
                    return "暗之木乃伊旗帜";
                case 3450:
                    return "光之木乃伊旗帜";
                case 3451:
                    return "愤怒骷髅旗帜";
                case 3452:
                    return "寒冰乌龟旗帜";
                case 3453:
                    return "伤害星能";
                case 3454:
                    return "生命星能";
                case 3455:
                    return "魔力星能";
                case 3456:
                    return "漩涡碎片";
                case 3457:
                    return "星云碎片";
                case 3458:
                    return "日光碎片";
                case 3459:
                    return "星尘碎片";
                case 3460:
                    return "夜明珠";
                case 3461:
                    return "夜明砖";
                case 3462:
                    return "";
                case 3463:
                    return "";
                case 3464:
                    return "";
                case 3465:
                    return "";
                case 3466:
                    return "星尘镐";
                case 3467:
                    return "夜明锭";
                case 3468:
                    return "日光翼";
                case 3469:
                    return "漩涡喷射";
                case 3470:
                    return "星云地幔";
                case 3471:
                    return "星尘翼";
                case 3472:
                    return "夜明砖墙";
                case 3473:
                    return "太阳能喷发";
                case 3474:
                    return "星尘碎片杖";
                case 3475:
                    return "漩涡击碎者";
                case 3476:
                    return "星云奥秘";
                case 3477:
                    return "血水";
                case 3478:
                    return "婚纱";
                case 3479:
                    return "婚礼服";
                case 3480:
                    return "铂金弓";
                case 3481:
                    return "铂金锤";
                case 3482:
                    return "铂金斧";
                case 3483:
                    return "铂金短剑";
                case 3484:
                    return "铂金宽剑";
                case 3485:
                    return "铂金镐";
                case 3486:
                    return "钨制弓";
                case 3487:
                    return "钨制锤";
                case 3488:
                    return "钨制斧";
                case 3489:
                    return "钨制短剑";
                case 3490:
                    return "钨制宽剑";
                case 3491:
                    return "钨制镐";
                case 3492:
                    return "铅制弓";
                case 3493:
                    return "铅制锤";
                case 3494:
                    return "铅制斧";
                case 3495:
                    return "铅制短剑";
                case 3496:
                    return "铅制宽剑";
                case 3497:
                    return "铅制镐";
                case 3498:
                    return "锡制弓";
                case 3499:
                    return "锡制锤";
                case 3500:
                    return "锡制斧";
                case 3501:
                    return "锡制短剑";
                case 3502:
                    return "锡制宽剑";
                case 3503:
                    return "锡制镐";
                case 3504:
                    return "黄铜弓";
                case 3505:
                    return "黄铜锤";
                case 3506:
                    return "黄铜斧";
                case 3507:
                    return "黄铜短剑";
                case 3508:
                    return "黄铜宽剑";
                case 3509:
                    return "黄铜镐";
                case 3510:
                    return "银弓";
                case 3511:
                    return "银锤";
                case 3512:
                    return "银斧";
                case 3513:
                    return "银短剑";
                case 3514:
                    return "银宽剑";
                case 3515:
                    return "银镐";
                case 3516:
                    return "金弓";
                case 3517:
                    return "金锤";
                case 3518:
                    return "金斧";
                case 3519:
                    return "金短剑";
                case 3520:
                    return "金宽剑";
                case 3521:
                    return "金镐";
                case 3522:
                    return "日光 Flare斧锤";
                case 3523:
                    return "漩涡斧锤";
                case 3524:
                    return "星云斧锤";
                case 3525:
                    return "星尘斧锤";
                case 3526:
                    return "日光染料";
                case 3527:
                    return "星云染料";
                case 3528:
                    return "漩涡染料";
                case 3529:
                    return "星尘染料";
                case 3530:
                    return "虚空染料";
                case 3531:
                    return "星辰之龙杖";
                case 3532:
                    return "培根";
                case 3533:
                    return "流沙染料";
                case 3534:
                    return "海市蜃楼染料";
                case 3535:
                    return "流动珍珠沙染料";
                case 3536:
                    return "漩涡巨石柱";
                case 3537:
                    return "星云巨石柱";
                case 3538:
                    return "星辰巨石柱";
                case 3539:
                    return "日光巨石柱";
                case 3540:
                    return "幻象";
                case 3541:
                    return "最终棱镜";
                case 3542:
                    return "星云火焰";
                case 3543:
                    return "黎明";
                case 3544:
                    return "超级治疗药水";
                case 3545:
                    return "雷管";
                case 3546:
                    return "庆典";
                case 3547:
                    return "弹性炸药";
                case 3548:
                    return "欢乐手雷";
                case 3549:
                    return "远古操纵器";
                case 3550:
                    return "焰色和银色染料";
                case 3551:
                    return "绿焰色和银色染料";
                case 3552:
                    return "蓝焰色和银色染料";
                case 3553:
                    return "反光黄铜染料";
                case 3554:
                    return "反光黑曜石染料";
                case 3555:
                    return "反光金属染料";
                case 3556:
                    return "午夜彩虹染料";
                case 3557:
                    return "黑白染料";
                case 3558:
                    return "亮银染料";
                case 3559:
                    return "银黑染料";
                case 3560:
                    return "红色酸性染料";
                case 3561:
                    return "凝胶染料";
                case 3562:
                    return "粉色凝胶染料";
                case 3563:
                    return "红色松鼠";
                case 3564:
                    return "金色松鼠";
                case 3565:
                    return "红色松鼠笼";
                case 3566:
                    return "金色松鼠笼";
                case 3567:
                    return "夜光弹";
                case 3568:
                    return "夜光箭";
                case 3569:
                    return "月光入口杖";
                case 3570:
                    return "月之耀斑";
                case 3571:
                    return "彩虹水晶杖";
                case 3572:
                    return "月球钩爪";
                case 3573:
                    return "日光碎片块";
                case 3574:
                    return "漩涡碎片块";
                case 3575:
                    return "星云碎片块";
                case 3576:
                    return "星辰碎片块";
                case 3577:
                    return "可疑的触手";
                case 3578:
                    return "Yoraiz0r的制服";
                case 3579:
                    return "Yoraiz0r的衬衫";
                case 3580:
                    return "Yoraiz0r的咒文";
                case 3581:
                    return "Yoraiz0r的怒容";
                case 3582:
                    return "吉姆之翼";
                case 3583:
                    return "Yoraiz0r的上色眼镜";
                case 3584:
                    return "生命叶墙";
                case 3585:
                    return "Skiphs的面具";
                case 3586:
                    return "Skiphs的皮肤";
                case 3587:
                    return "Skiphs的空桶";
                case 3588:
                    return "Skiphs的爪子";
                case 3589:
                    return "洛基之盔";
                case 3590:
                    return "洛基的胸甲";
                case 3591:
                    return "洛基的护腿";
                case 3592:
                    return "洛基之翼";
                case 3593:
                    return "沙地史莱姆旗帜";
                case 3594:
                    return "海螺旗帜";
                case 3595:
                    return "荣誉之证-潮汐之月";
                case 3596:
                    return "不是羊，也不是乌贼";
                case 3597:
                    return "烈焰冥王染料";
                case 3598:
                    return "残忍之染料";
                case 3599:
                    return "洛基的染料";
                case 3600:
                    return "暗影之火冥王染料";
               
            }
            return typeof(Terraria.Lang).GetMethod("itemNameOro").Invoke(null, new object[] { l, english }).ToString();
          // return itemName(l,true);
        }

        

    }
}
