/*
 * logick_basic.c
 *
 * Created: 04-Jan-21 12:05:14 PM
 *  Author: den1s
 */ 

#include "logick_basic.h"

_Bool LogickElementAND (_Bool firstInput, _Bool secondInput)
{
	return firstInput && secondInput;
}

_Bool LogickElementOR (_Bool firstInput, _Bool secondInput)
{
	return firstInput || secondInput;
}

_Bool LogickElementNOT (_Bool firstInput)
{
	return !firstInput;
}

_Bool LogickElementNAND (_Bool firstInput, _Bool secondInput)
{
	return !(firstInput && secondInput);
}

_Bool LogickElementNOR (_Bool firstInput, _Bool secondInput)
{
	return !(firstInput || secondInput);
}

_Bool LogickElementXOR (_Bool firstInput, _Bool secondInput)
{
	return ((!firstInput && secondInput)||(!secondInput && firstInput));
}

_Bool LogickElementXNOR (_Bool firstInput, _Bool secondInput)
{
	return (firstInput && secondInput) || !(firstInput && secondInput);
}