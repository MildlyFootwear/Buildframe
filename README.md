## Buildframe

Buildframe is an indevelopment open source theory crafting utility for Warframe.  

Its intent is to make it easy to create presets and custom effect templates representing ingame effects, making it easy to customize and combine them to calculate and display derived stats.
Reload time, sustained DPS, burst DPS, average critical hit, and more can be calculated with any number of combinations of weapon mods, warframe arcanes, abilities, and more.


### How To Use

Several editors have been built in to facilitate the creation of weapons, mods, arcanes, and other effects. Some instructions have been included in the appropriate editors but to get the best use out of them you will need at least some understanding of how various effects overlay onto eachother.
Most current and future weapons should be able to be roughly represented, as well as current and future mods, arcanes, and warframe abilities.  
A reasonable amount of weapons, firemodes, arcanes, mods, and abilities have been included and can be viewed in the editors to get an understanding of how to create your own.  

Several effects have been hardcoded, such as the arcane Secondary Enervate as well as the incarnon perk Devouring/Devastating Attrition found on the Phenmor, Laetum, and Felarx. These can still be manually replicated on the users end, however these should be a more accurate representation of their effects ingame as of the time of writing.

#### Hardcoded Effects

To use; add the tag when appropriate, i.e. Secondary Enervate to an arcane or the multishot damage increase to a firemode. These tags are meant to be added to effects (firemodes, mods, misc), not the weapon itself.  

Multishot_Exclusive_Damage_Mult - makes it so the Final Damage Percentage for a given stat applies to multishot only. Use to represent effects like the multishot perk on the Braton Incarnon.  

Multishot_Consumes_Reserve_Ammo - typically paired with the above effect, sets it to consume reserve ammo for multishot. Mostly going to effect firemodes such as Braton's incarnon fire.

Multishot_Locked - tag designed for Acuity mods and certain incarnon fire modes that have a hitscan AoE effect.

Firerate_Locked - Cannonade mods.

ExcludeRadialFire - will exclude an effect from applying to radial firemodes.

Secondary_Enervate_Rank_0 - applies the effects of the Secondary Enervate arcane. Valid tags for Rank_0 through Rank_5.  

Semi_Auto_Fire - Caps fire rate at 10. Use for weapons with the fire-mode semi.

NoIncarnonMode - stats containing this tag will still be selectable but won't be applied to incarnon firemodes, i.e. Oraxia's Silken Stride or Cyte's resupply.

WeaponName_(insert text) - stats with this tag will show as valid for any weapon whose name starts with the given text.


### License

The license as of writing is MIT. You can take my code and do whatever you want with it. All code included in this project is my own work unless otherwise noted.  
If you would like to contribute or create a fork to maintain on your own, you are more than welcome to. All I really ask is not to put anything behind a pay wall.