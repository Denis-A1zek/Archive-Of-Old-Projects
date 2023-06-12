/*
 * logick_basic.h
 *
 * Created: 04-Jan-21 12:05:00 PM
 *  Author: den1s
 */ 


#ifndef LOGICK_BASIC_H_
#define LOGICK_BASIC_H_

#include <avr/io.h>
#include "util/delay.h"
#include <stdbool.h>

_Bool LogickElementAND (_Bool firstInput, _Bool secondInput);
_Bool LogickElementOR (_Bool firstInput, _Bool secondInput);
_Bool LogickElementNOT (_Bool firstInput);
_Bool LogickElementNAND (_Bool firstInput, _Bool secondInput);
_Bool LogickElementNOR (_Bool firstInput, _Bool secondInput);
_Bool LogickElementXOR (_Bool firstInput, _Bool secondInput);
_Bool LogickElementXNOR (_Bool firstInput, _Bool secondInput);


#endif /* LOGICK_BASIC_H_ */