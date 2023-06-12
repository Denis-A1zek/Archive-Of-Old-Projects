/*
 * lib_trigger.c
 *
 * Created: 01.05.2021 7:23:15
 *  Author: Denis Work
 */ 

#include "lib_trigger.h"

int CallTriigerRS (_Bool firstInput, _Bool secondInput, char firstOutput, char secondOutput, char* portState){
	
	if (firstInput && secondInput)
		*portState = *portState;
	else if (!firstInput && !secondInput)
	{
		*portState = 0b00110000;

	}
	else if (firstInput && !secondInput)
		*portState = firstOutput;
	else if (!firstInput && secondInput)
		*portState = secondOutput;
}

int CallTriigerJK (_Bool firstInput, _Bool secondInput, char firstOutput, char secondOutput, char* portState){
	if (firstInput && secondInput) 
		*portState = *portState;
	else if (!firstInput && !secondInput)
	{
		*portState = firstOutput;
		_delay_ms(500);
		*portState = secondOutput;
		_delay_ms(500);
		
	}
	else if (firstInput && !secondInput) 
		*portState = firstOutput;
	else if (!firstInput && secondInput) 
		*portState = secondOutput;
}

int CallTriigerD (_Bool firstInput, _Bool secondInput, char firstOutput, char secondOutput, char* portState){
	if (firstInput && secondInput) 
		*portState = *portState;
	else if (!firstInput && !secondInput) 
		*portState = firstOutput;
	else if (firstInput && !secondInput) 
		*portState = secondOutput;
	else if (!firstInput && secondInput) 
		*portState = *portState;
}

int CallTriigerT (_Bool firstInput, char firstOutput, char secondOutput, char* portState){
	if(firstInput) 
		*portState = firstOutput;
	else 
		*portState = secondOutput;
}

 