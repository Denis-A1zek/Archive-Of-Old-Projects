/*
 * ProjectLogickLiza.c
 *
 * Created: 04-Jan-21 12:01:40 PM
 * Author : den1s
 */ 

#include <avr/io.h>
#include "util/delay.h"
#include <stdbool.h>

#define WAIT _delay_ms(100)

#define AND_LOGICK (PINB&0x01)==0

#define BUTTON1 (PIND&0x01)==0
#define BUTTON2 (PIND&0x02)==0
#define BUTTON3 (PIND&0x04)==0
#define BUTTON4 (PIND&0x08)==0
#define BUTTON5 (PIND&0x10)==0
#define BUTTON6 (PIND&0x20)==0
#define BUTTON7 (PIND&0x40)==0

enum LogickElement
{
	AND,
	OR,
	NAND,
	NOR,
	XOR,
	XNOR	
};

int main(void)
{
	
	PORTB=0x00;
	DDRB=0xFF;
	PORTD=0xFF;
	DDRD=0x00;
	
    /* Replace with your application code */
    while (1) 
    {
			PORTB = LogickElementXOR(BUTTON1, BUTTON2);
    }
}

int Decorder()
{
	if(PORTC=)
}