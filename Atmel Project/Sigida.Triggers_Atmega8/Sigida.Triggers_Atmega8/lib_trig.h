/*
 * lib_trig.h
 *
 * Created: 16-Dec-20 9:17:05 AM
 *  Author: den1s
 */ 


#ifndef LIB_TRIG_H_
#define LIB_TRIG_H_

#include <avr/io.h>
#include <util/delay.h>
#include <stdbool.h>

_Bool CallTriigerRS (_Bool firstInput, _Bool secondInput);
int CallTriigerJK (_Bool firstInput, _Bool secondInput, char firstOutput, char secondOutput, char* portState);
int CallTriigerD (_Bool firstInput, _Bool secondInput, char firstOutput, char secondOutput, char* portState);
int CallTriigerT (_Bool firstInput, char firstOutput, char secondOutput, char* portState);
void reload ();

#endif /* LIB_TRIG_H_ */