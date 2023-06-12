

#ifndef LOGIC_BASIC_H_
#define LOGIC_BASIC_H_

#include <avr/io.h>
#include "util/delay.h"
#include <stdbool.h>

_Bool LogicElementAND (_Bool firstInput, _Bool secondInput);
_Bool LogicElementOR (_Bool firstInput, _Bool secondInput);
_Bool LogicElementNOT (_Bool firstInput);
_Bool LogicElementNAND (_Bool firstInput, _Bool secondInput);
_Bool LogicElementNOR (_Bool firstInput, _Bool secondInput);
_Bool LogicElementXOR (_Bool firstInput, _Bool secondInput);
_Bool LogicElementXNOR (_Bool firstInput, _Bool secondInput);

#endif /* LOGIC_BASIC_H_ */