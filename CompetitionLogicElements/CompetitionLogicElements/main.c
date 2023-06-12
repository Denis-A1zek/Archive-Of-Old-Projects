/*
 * CompetitionLogicElements.c
 *
 * Created: 13.05.2021 16:21:28
 * Author : Denis Work
 */ 

#include <avr/io.h>
#include "lcd_display.h"
#include "logic_basic.h"
#include <util/delay.h>
#include <stdio.h>
#include <stdlib.h>

enum LogickElement
{
	AND = 1,
	OR,
	NAND,
	NOR,
	XOR,
	XNOR
};

char mode = 0;
char flagButton = 0;

#define BUTTONX1 (PINB&0x02)==0
#define BUTTONX2 (PINB&0x04)==0

void ShowInfo(char info)
{
	if((PINB&0x08)==0)
	{
		_delay_ms(30);
		clearlcd();
		str_lcd(info);
	}
}

void InicializationButton()
{
	if((PINB&0x01) == 0 && flagButton == 0)
	{
		mode++;
		flagButton = 1;
		
		if(mode > 6)
		mode = 0;
		
		_delay_ms(500);
	}else
	flagButton = 0;
}

void BlockInfo()
{
	clearlcd();
	str_lcd("Info block");
}

void GetResult(int boolState, char logicElement)
{
	if (boolState)
	PORTD |= (1<<0);
	else
	PORTD &= ~(1<<0);
	
	ShowInfo(logicElement);
}

int main(void)
{
    PORTD = 0x00;
    DDRD = 0xFF;
    PORTB = 0xFF;
    DDRB = 0x00;
    
    LCD_ini();  
    clearlcd();
    setpos(0,0);
    str_lcd("Select element");

	
    while (1) 
    {
		InicializationButton();		
		switch (mode)
		{
			case AND:
				BlockInfo();
				while(mode == AND)
				{
					GetResult(LogicElementAND(BUTTONX1,BUTTONX2), "Selected:AND");
					InicializationButton();
				}
			break;
			case OR:
			BlockInfo();
			while(mode == OR)
				{
					GetResult(LogicElementOR(BUTTONX1,BUTTONX2), "Selected:OR");
					InicializationButton();
				}
			break;
			case NAND:
			BlockInfo();
				while(mode == NAND)
				{
					GetResult(LogicElementNAND(BUTTONX1,BUTTONX2), "Selected:NAND");
					InicializationButton();
				}
			break;
			case NOR:
				BlockInfo();
				while(mode == NOR)
				{
					GetResult(LogicElementNOR(BUTTONX1,BUTTONX2), "Selected:NOR");
					InicializationButton();
				}
			break;
			case XOR:
			BlockInfo();
				while(mode == XOR)
				{
					GetResult(LogicElementXOR(BUTTONX1,BUTTONX2), "Selected:XOR");
					InicializationButton();
				}
			break;	
			case XNOR:
				BlockInfo();
				while(mode == XNOR)
				{
					GetResult(LogicElementXNOR(BUTTONX1,BUTTONX2), "Selected:XNOR");
					InicializationButton();
				}				
			break;	
		}		
    }
}

