/*
 * lcd_display.h
 *
 * Created: 13.05.2021 14:28:06
 *  Author: Denis Work
 */ 


#ifndef LCD_DISPLAY_H_
#define LCD_DISPLAY_H_

#include <avr/io.h>
#include <avr/interrupt.h>
#include <util/delay.h>
#include <stdio.h>
#include <stdlib.h>

#define e1    PORTD|=0b00000100 // установка линии E в 1
#define e0    PORTD&=0b11111011 // установка линии E в 0
#define rs1    PORTD|=0b00000010 // установка линии RS в 1 (данные)
#define rs0    PORTD&=0b11111101 // установка линии RS в 0 (команда)

void LCD_ini(void);
void setpos(unsigned char x, unsigned y);
void str_lcd (char str1[]);
void clearlcd(void);
void sendcharlcd(unsigned char c);

#endif /* LCD_DISPLAY_H_ */