/*
 * lib_trig.c
 *
 * Created: 16-Dec-20 9:17:49 AM
 *  Author: den1s
 */ 

#include "lib_trig.h"


_Bool CallTriigerRS (_Bool firstInput, _Bool secondInput){
	
	//
	return (!(firstInput&(!(secondInput&&firstInput)))&(!(secondInput&(!(firstInput&&secondInput)))));
}

int CallTriigerJK (_Bool firstInput, _Bool secondInput, char firstOutput, char secondOutput, char* portState){
	//????? ??????????
	if (firstInput && secondInput) *portState = *portState;
	//????? ???????
	else if (!firstInput && !secondInput)
	{
		*portState = firstOutput;
		_delay_ms(1000);
		*portState = secondOutput;
		_delay_ms(1000);
		
	}
	//????? ?????????
	else if (firstInput && !secondInput) *portState = firstOutput;
	//????? ??????
	else if (!firstInput && secondInput) *portState = secondOutput;
}

int CallTriigerD (_Bool firstInput, _Bool secondInput, char firstOutput, char secondOutput, char* portState){
	//????? ??????????
	if (firstInput && secondInput) *portState = *portState;
	//????? ?????????
	else if (!firstInput && !secondInput) *portState = firstOutput;
	//????? ??????
	else if (firstInput && !secondInput) *portState = secondOutput;
	//????? ??????????
	else if (!firstInput && secondInput) *portState = *portState;
}

int CallTriigerT (_Bool firstInput, char firstOutput, char secondOutput, char* portState){
	//????? ?????????
	if(firstInput) *portState = firstOutput;
	//????? ??????
	else *portState = secondOutput;
}

void reload ()
{
	PORTB=0x00;
}
