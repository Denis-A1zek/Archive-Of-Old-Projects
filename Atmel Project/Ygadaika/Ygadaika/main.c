/*
 * Ygadaika.c
 *
 * Created: 16.09.2021 17:10:27
 * Author : Denis Work
 */ 

#include <avr/io.h>
#include <stdio.h>
#include <time.h>
#include <util/delay.h>



char get_rand_range_int(char min, char max) {
	return rand() % (max - min + 1) + min;
}

char win = 0;

int main(void)
{
	PORTD=0xFF;
	DDRD=0x00;
	PORTB=0x00;
	DDRB=0xFF;
	
	char segmentStates[] = {0b0000000, 0b0000110,0b1011011, 0b1001111, 0b1100110, 0b1101101, 0b1111101, 0b0000111, 0b1111111, 0b1101111};
    /* Replace with your application code */
    while (1) 
    {
		win = 0;
		if((PIND&0x40) == 0)
		{
			_delay_ms(500);
			
			int random = get_rand_range_int(1,9);
			
			PORTB = segmentStates[random];
			
			char randomHex = random;
			
			for (int i = 0; i < 10; i++)
			{
				int temp = PIND&0x0F;
				
				if(temp == randomHex)
				{
					win = 1;
					PORTB = 0b1110111;
					_delay_ms(200);
					PORTB = 0x00;
					_delay_ms(200);
					PORTB = 0b1110111;
					_delay_ms(200);
					PORTB = 0x00;
					_delay_ms(200);
					PORTB = 0b1110111;
					_delay_ms(200);
					PORTB = 0x00;
					_delay_ms(200);
					break;
				}
			_delay_ms(300);
			}
			
			if(win == 1)
				continue;
			
			PORTB = 0b0001110;
			_delay_ms(200);
			PORTB = 0x00;
			_delay_ms(200);
			PORTB = 0b0001110;
			_delay_ms(200);
			PORTB = 0x00;
			_delay_ms(200);
			PORTB = 0b0001110;
			_delay_ms(200);
			PORTB = 0x00;
			_delay_ms(200);
			

		}
		

    }
}

