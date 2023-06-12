

#include <avr/io.h>
#include "util/delay.h"
#include <stdbool.h>
#include "logic_basic.h"

#define AND (PIND&0x10)==0 && (PIND&0x20)==0 && !(PIND&0x40)==0 //001
#define OR (PIND&0x10)==0 && !(PIND&0x20)==0 && (PIND&0x40)==0 //010
#define NAND (PIND&0x10)==0 && !(PIND&0x20)==0 && !(PIND&0x40)==0 //011
#define NOR !(PIND&0x10)==0 && (PIND&0x20)==0 && (PIND&0x40)==0 //100
#define XOR !(PIND&0x10)==0 && (PIND&0x20)==0 && !(PIND&0x40)==0 //101
#define XNOR !(PIND&0x10)==0 && !(PIND&0x20)==0 && (PIND&0x40)==0 //110
#define OFF_ON (PIND&0x10)==0 && (PIND&0x20)==0 && (PIND&0x40)==0 //001

#define NAND_ONE_BUTTON (PINB&0x01)==0
#define NAND_TWO_BUTTON (PINB&0x02)==0
#define NOR_ONE_BUTTON (PINB&0x04)==0
#define NOR_TWO_BUTTON (PINB&0x08)==0
#define XOR_ONE_BUTTON (PINB&0x10)==0
#define XOR_TWO_BUTTON (PINB&0x20)==0
#define XNOR_ONE_BUTTON (PINB&0x40)==0
#define XNOR_TWO_BUTTON (PINB&0x80)==0

#define AND_ONE_BUTTON (PIND&0x01)==0
#define AND_TWO_BUTTON (PIND&0x02)==0
#define OR_ONE_BUTTON (PIND&0x04)==0
#define OR_TWO_BUTTON (PIND&0x08)==0




int main(void)
{
	
	PORTC=0x00;
	DDRC=0xFF;
	PORTB=0xFF;
	DDRB=0x00;
	PORTD=0xFF;
	DDRD=0x00;
	
    /* Replace with your application code */
    while (1) 
    {
		if (AND)
		{
			PORTC = LogicElementAND(AND_ONE_BUTTON, AND_TWO_BUTTON);
		}else if (OR)
		{
			PORTC = (LogicElementOR(OR_ONE_BUTTON, OR_TWO_BUTTON) << 1);
		}else if (NAND)
		{
			PORTC = (LogicElementNAND(NAND_ONE_BUTTON,NAND_TWO_BUTTON) << 2);
		}else if (NOR)
		{
			PORTC = (LogicElementNOR(NOR_ONE_BUTTON, NOR_TWO_BUTTON) << 3);
		}else if (XOR)
		{
			PORTC = (LogicElementXOR(XOR_ONE_BUTTON,XOR_TWO_BUTTON) << 4);
		}else if (XNOR)
		{
			PORTC = (LogicElementXNOR(XNOR_ONE_BUTTON, XNOR_TWO_BUTTON) << 5);
		}else PORTC = 0x00;
		
		
    }
}



