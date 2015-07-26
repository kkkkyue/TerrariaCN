using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumpCNConsoleApplication
{
    class setBonus
    {
        public static string en(int l)
        {
            switch (l)
            {
                case 0:
                    return "2 defense";
                case 1:
                    return "3 defense";
                case 2:
                    return "15% increased movement speed";
                case 3:
                    return "Space Gun costs 0 mana";
                case 4:
                    return "20% chance to not consume ammo";
                case 5:
                    return "16% reduced mana usage";
                case 6:
                    return "17% extra melee damage";
                case 7:
                    return "30% increased mining speed";
                case 8:
                    return "14% reduced mana usage";
                case 9:
                    return "15% increased melee speed";
                case 10:
                    return "20% chance to not consume ammo";
                case 11:
                    return "17% reduced mana usage";
                case 12:
                    return "5% increased melee critical strike chance";
                case 13:
                    return "20% chance to not consume ammo";
                case 14:
                    return "19% reduced mana usage";
                case 15:
                    return "18% increased melee and movement speed";
                case 16:
                    return "25% chance to not consume ammo";
                case 17:
                    return "20% reduced mana usage";
                case 18:
                    return "19% increased melee and movement speed";
                case 19:
                    return "25% chance to not consume ammo";
                case 20:
                    return "1 defense";
                case 21:
                    return "Greatly increased life regen";
                case 22:
                    return "Melee and ranged attacks cause frostburn";
                case 23:
                    return "Increases your max number of minions";
                case 24:
                    return "Greatly increases life regeneration after striking an enemy";
                case 25:
                    return "Flower petals will fall on your target for extra damage";
                case 26:
                    return "Become immune after striking an enemy";
                case 27:
                    return "Summons a powerful leaf crystal to shoot at nearby enemies";
                case 28:
                    return "10% increased magic critical strike chance";
                case 29:
                    return "Attackers also take full damage";
                case 30:
                    return "Magic damage done to enemies heals the player with lowest health";
                case 31:
                    return "Not moving puts you in stealth,\nincreasing ranged ability and reducing chance for enemies to target you";
                case 32:
                    return "4 defense";
                case 33:
                    return "10% increased damage";
                case 34:
                    return "Increases minion damage by 25%";
                case 35:
                    return "Magic damage done will hurt extra nearby enemies";
                case 36:
                    return "Increases maximum mana by 60";
                case 37:
                    return "Beetles protect you from damage";
                case 38:
                    return "Beetles increase your melee damage and speed";
                case 39:
                    return "Increases minion damage by 10%";
                case 40:
                    return "Increases minion damage by 12%";
                case 41:
                    return "33% chance to not consume thrown item";
                case 42:
                    return "50% chance to not consume thrown item";
                case 43:
                    return "Solar shields generate over time protecting you,\nconsume the shield power to dash, damaging enemies";
                case 44:
                    return "Double tap ";
                case 45:
                    return "Hurting enemies has a chance to spawn buff boosters,\npick boosters up to get stacking buffs";
                case 46:
                    return " to direct your guardian to a location";
                case 47:
                    return "UP";
                case 48:
                    return "DOWN";
                case 49:
                    return " to toggle stealth,\nincreasing ranged ability and reducing chance for enemies to target you but slowing movement speed";
            }
            return "";
        }
        public static string cn(int l)
        {
            switch (l)
            {
                case 0:
                    return "增加2防御";
                case 1:
                    return "增加3防御";
                case 2:
                    return "增加15%的移动速度";
                case 3:
                    return "空间枪不再消耗魔力";
                case 4:
                    return "20%几率不消耗弹药";
                case 5:
                    return "降低16%魔力消耗";
                case 6:
                    return "增加17%近战伤害";
                case 7:
                    return "增加30%采矿速度";
                case 8:
                    return "降低14%魔力消耗";
                case 9:
                    return "增加15%近战速度";
                case 10:
                    return "20%几率不消耗弹药";
                case 11:
                    return "降低17%魔力消耗";
                case 12:
                    return "增加5%暴击率";
                case 13:
                    return "20%几率不消耗弹药";
                case 14:
                    return "降低19%魔力消耗";
                case 15:
                    return "增加18%的近战速度和移动速度";
                case 16:
                    return "25%的几率不消耗弹药";
                case 17:
                    return "降低20%魔力消耗";
                case 18:
                    return "增加19%的近战速度和移动速度";
                case 19:
                    return "25%的几率不消耗弹药";
                case 20:
                    return "增加1防御";
                case 21:
                    return "生命快速回复";
                case 22:
                    return "近战或远程攻击会造成冰焰伤害";
                case 23:
                    return "增加最大召唤物数量";
                case 24:
                    return "攻击敌人后大量增加生命回复速度";
                case 25:
                    return "花瓣将落在你的敌人身上并造成伤害";
                case 26:
                    return "攻击敌人后短暂无敌";
                case 27:
                    return "召唤叶绿晶体攻击敌人";
                case 28:
                    return "增加10%魔法暴击率";
                case 29:
                    return "反弹对方的伤害";
                case 30:
                    return "法术伤害可以吸取敌人生命";
                case 31:
                    return "不移动将让你潜行，增加远程攻击力，并更不易被敌人发现";
                case 32:
                    return "增加4防御";
                case 33:
                    return "增加10%伤害";
                case 34:
                    return "增加25%召唤物伤害";
                case 35:
                    return "魔法造成额外溅射伤害";
                case 36:
                    return "增加60最大法力值";
                case 37:
                    return "甲虫保护你免受伤害";
                case 38:
                    return "甲虫增加你的近战伤害和攻速";
                case 39:
                    return "增加10%召唤物伤害";
                case 40:
                    return "增加10%召唤物伤害";
                case 41:
                    return "33% 不消耗投掷物.";
                case 42:
                    return "50% 不消耗投掷物.";
                case 43:
                    return "产生一个持续一段时间的保护盾,冲撞或伤害敌人会消耗盾的能量.";
                case 44:
                    return "按两次";
                case 45:
                    return "伤害敌人有概率生成带buff的道具，捡起道具可以获得叠加的buff.";
                case 46:
                    return "指引你的保护者到下一个地点.";
                case 47:
                    return "上";
                case 48:
                    return "下";
                case 49:
                    return "切换隐身,增加射程同时降低敌人瞄准你的几率,但是你的移速会下降.";
            }
            return "";
        }
    }
}
