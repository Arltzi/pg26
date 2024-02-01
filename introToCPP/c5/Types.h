#pragma once
struct Colour
{
	float red;
	float green;
	float blue;
	float alpha;
};

enum class OperatingSystem
{
	Windows, 
	Linux, 
	MacOS, 
	Android, 
	IOS
};

enum class CharacterClass
{
	Sniper,
	Berserker,
	Healer,
	Tank,
	Mage,
	Fairy
};