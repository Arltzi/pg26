#include "Utility.h"
#include "Predator.h"
#include "Alien.h"
#include "Types.h"
#include "Wall.h"

int main()
{
	LivingOrganism* Virus = new LivingOrganism("ecoli", 0.25f);
	Alien* Dalek = new Alien("Dalek", 200.0f, Colour{0.0f, 0.0f, 0.0f, 1.0f}, 8.0f);
	void* test = new LivingOrganism("test ecoli", 1.0f);
	
	PRINT_LINE(Dalek->GetBloodColor().alpha);

	Virus->Breathe();
	Dalek->Breathe();

	Predator* TheOne = new Predator("The One", 4000, true, 200.0f);

	TheOne->Breathe();
	TheOne->TakeDamage();

	Wall* NewWall = new Wall();
	
	OperatingSystem RohitsOS = OperatingSystem::Windows;
	CharacterClass Jacob = CharacterClass::Fairy;

	switch (Jacob)
	{
	case CharacterClass::Sniper:
		break;
	case CharacterClass::Berserker:
		break;
	case CharacterClass::Healer:
		break;
	case CharacterClass::Tank:
		break;
	case CharacterClass::Mage:
		break;
	case CharacterClass::Fairy:
		break;
	default:
		break;
	}

	delete Virus, Dalek, TheOne;
}
