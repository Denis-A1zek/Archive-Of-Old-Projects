
#include "logic_basic.h"

_Bool LogicElementAND (_Bool firstInput, _Bool secondInput)
{
	return firstInput && secondInput;
}

_Bool LogicElementOR (_Bool firstInput, _Bool secondInput)
{
	return firstInput || secondInput;
}

_Bool LogicElementNOT (_Bool firstInput)
{
	return !firstInput;
}

_Bool LogicElementNAND (_Bool firstInput, _Bool secondInput)
{
	return !(firstInput && secondInput);
}

_Bool LogicElementNOR (_Bool firstInput, _Bool secondInput)
{
	return !(firstInput || secondInput);
}

_Bool LogicElementXOR (_Bool firstInput, _Bool secondInput)
{
	return ((!firstInput && secondInput)||(!secondInput && firstInput));
}

_Bool LogicElementXNOR (_Bool firstInput, _Bool secondInput)
{
	return (firstInput || !secondInput) && (!firstInput || secondInput);
}