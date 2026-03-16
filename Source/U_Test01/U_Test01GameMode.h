// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "U_Test01GameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AU_Test01GameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AU_Test01GameMode();
};



