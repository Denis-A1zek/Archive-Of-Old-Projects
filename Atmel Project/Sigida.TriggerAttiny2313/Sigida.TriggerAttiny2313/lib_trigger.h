/*
 * lib_trigger.h
 *
 * Created: 01.05.2021 7:22:38
 *  Author: Denis Work
 */ 


#ifndef LIB_TRIGGER_H_
#define LIB_TRIGGER_H_

#include <avr/io.h>
#include <util/delay.h>
#include "lib_trigger.h"

int CallTriigerRS (_Bool firstInput, _Bool secondInput, char firstOutput, char secondOutput, char* portState);
int CallTriigerJK (_Bool firstInput, _Bool secondInput, char firstOutput, char secondOutput, char* portState);
int CallTriigerD (_Bool firstInput, _Bool secondInput, char firstOutput, char secondOutput, char* portState);
int CallTriigerT (_Bool firstInput, char firstOutput, char secondOutput, char* portState);

#endif /* LIB_TRIGGER_H_ */