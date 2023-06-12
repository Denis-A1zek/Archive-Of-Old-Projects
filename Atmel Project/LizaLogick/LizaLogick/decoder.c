#include <avr/io.h>

enum LogickElement
{
	AND = 1,
	OR,
	NAND,
	NOR,
	XOR,
	XNOR
};

void DecoderSend(int element)
{
	switch (element)
	{
		case AND:
		PORTD &=~ (1<<5);
		PORTD &=~ (1<<6);
		PORTD |= (1<<7);
		break;
		case OR:
		PORTD &=~ (1<<5);
		PORTD |= (1<<6);
		PORTD &=~ (1<<7);
		break;
		case NAND:
		PORTD &=~ (1<<5);
		PORTD |= (1<<6);
		PORTD |= (1<<7);
		break;
		case NOR:
		PORTD |= (1<<5);
		PORTD &=~ (1<<6);
		PORTD &=~ (1<<7);
		break;
		case XOR:
		PORTD |= (1<<5);
		PORTD &=~ (1<<6);
		PORTD |= (1<<7);
		break;
		case XNOR:
		PORTD |= (1<<5);
		PORTD |= (1<<6);
		PORTD |= (1<<7);
		break;
		default:
			Clean();
		break;
	}
}

void Clean()
{
	PORTD &=~ (1<<5);
	PORTD &=~ (1<<6);
	PORTD &=~ (1<<7);
}