#include "main.h"
#include <stdlib.h>
//----------------------------------------
void port_ini(void)
{
	PORTD=0x00;
	DDRD=0xFF;
	PORTB=0x0F;
	DDRB=0xF0;
}
//----------------------------------------

void button_Update();

char flagFirstButton = 0;
char flagSecondButton = 0;
char flag3 = 0;

char mode = 0;
int i = 10;

char buffer[1];
char buffer_i[1];

void generate_title()
{
	clearlcd();
	setpos(0,0);
	str_lcd("Timer by Titkov");
	setpos(0,1);
	str_lcd("Time:");
	setpos(9,1);
	str_lcd("min.");
}

//Main
int main(void)
{
	port_ini(); //Инициализируем порты
	LCD_ini();  //Инициализируем дисплей
	clearlcd();
	setpos(0,0);
	str_lcd("Timer by Titkov");
	setpos(0,1);
	str_lcd("Time:");
	setpos(9,1);
	str_lcd("min.");
	
	while(1)
	{
		button_Update();
		setpos(7,1);
		str_lcd(itoa(mode, buffer, 10));
	}
}

//Обработчик кнопок
void button_Update()
{
	if((PINB&0x01) == 0 && flagFirstButton == 0)
	{
		mode++;
		flagFirstButton = 1;
		
		if(mode > 99 || mode <= 0)
		mode = 0;
		
		_delay_ms(15);
		

	}
	else if((PINB&0x02) == 0 && flagSecondButton == 0)
	{
		mode--;
		flagSecondButton = 1;
		
		if(mode <= 0 || mode > 99)
		mode = 0;
		
		_delay_ms(15);
		

	}
	else if ((PINB&0x04) == 0)
	{
		timer_start(mode);
		_delay_ms(15);
	}
	else
	{
		flagFirstButton = 0;
		flagSecondButton = 0;
	}
}

void timer_start(char time)
{

	for (i = time; i >= 0; i--)
	{		
		setpos(7, 1);
		
		if(i == 9)
		{
			setpos(8,1);
			str_lcd(" ");
			setpos(7, 1);
		}

		str_lcd(itoa(i, buffer_i, 10));
		_delay_ms(3750);
		
		if(!((PINB&0x04) == 0))
		{
			setpos(7,1);
			mode = 0;
			generate_title();
			break;
		}
	}
	
	setpos(7,1);
	mode = 0;
	generate_title();
	button_Update();
}