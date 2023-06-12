#include <avr/io.h>
#include <util/delay.h>

char buffer;

char mode = 0;
char flagButton = 0;


#define R_BUTTON (PIND&0x01)==0
#define S_BUTTON (PIND&0x02)==0
#define RESET_BUTTON (PIND&0x04)==0


void Output(char value)
{
	_delay_ms(100);
	PORTB = value;
	InicializationButton();
}

void InicializationButton()
{
	if(RESET_BUTTON && flagButton == 0)
	{
		mode++;
		flagButton = 1;
		
		if(mode > 4)
		mode = 0;
		
		_delay_ms(500);
	}else
	flagButton = 0;
}


int main(void)
{
	PORTD=0xFF;
	DDRD=0x00;
	PORTB=0x00;
	DDRB=0xFF;
	
	while (1)
	{
		InicializationButton();
		switch (mode)
		{
			case 1:
			Output(0b00000100);
			buffer = 0b00000100;
			while(mode == 1)
			{
				if(R_BUTTON && S_BUTTON)
				{
					Output(0b00000111);
				}
				else if(!R_BUTTON && !S_BUTTON)
				{
					Output(buffer);
					buffer = buffer;
					
				}
				else if(!R_BUTTON && S_BUTTON)
				{
					Output(0b00000101);
					buffer = 0b00000101;
					
				}
				else if(R_BUTTON && !S_BUTTON)
				{
					Output(0b00000110);
					buffer = 0b00000110;
				}else Output(0b00000100);
			}
			break;
			case 2:
			Output(0b00001000);
			buffer = 0b00001000;
			while(mode == 2)
			{
				if(R_BUTTON && S_BUTTON)
				{
					_delay_ms(100);
					PORTB = 0b00001001;
					_delay_ms(100);
					PORTB = 0b00001000;
					_delay_ms(100);
					PORTB = 0b00001010;
					_delay_ms(100);
					PORTB = 0b00001000;
					_delay_ms(100);
					InicializationButton();
				}
				else if(!R_BUTTON && !S_BUTTON)
				{
					Output(buffer);
					buffer = buffer;
				}
				else if(!R_BUTTON && S_BUTTON)
				{
					Output(0b00001001);
					buffer = 0b00001001;
				}
				else if(R_BUTTON && !S_BUTTON)
				{
					Output(0b00001010);
					buffer = 0b00001010;
				}else Output(0b0001000);
			}
			break;
			case 3:
			Output(0b00010000);
			while(mode == 3)
			{
				if(R_BUTTON && !S_BUTTON)
				{
					Output(0b000010010);
					buffer = 0b000010010;
				}
				else if(!R_BUTTON && !S_BUTTON)
				{
					Output(0b00010001);
					buffer = 0b00010001;
				}else Output(buffer);
			}
			break;
			case 4:
			Output(0b00100000);
			while(mode == 4)
			{
				if(!R_BUTTON)
				Output(0b00100001);
				else
				Output(0b00100010);
			}
			break;
			default:
			PORTB = 0x00;
			break;
		}
		
	}
}

