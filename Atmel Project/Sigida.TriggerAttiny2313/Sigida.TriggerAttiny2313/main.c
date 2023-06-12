//*****************************
//Автор: Сигида Д.А.          *
//Дата: 10.02.2020			  *
//Группа: 1КСК-17			  *
//Имя файла: Sigida.Trigger's *
//для AVR: ATTINY2313		  *
//*****************************
//Тема дипломного проекта: Проектирование стенда для моделирования работы триггеров
//Разработать стенд для моделирования работы триггеров. Прибор подключить к сети 220В, частотой 50 Гц. 
//Установить на стенд модели триггеров: RS, JK, D, T. Каждый триггер вы-брать с помощью специальных кнопок: SRS ,SJK SD ,ST 
//На входе триггеров установить кнопки выбора режима триггера. На выходе триггера установить светодиоды, которые 
//отображают прямой и инверсный сигнал. Программно управляет триггерами микро
//контроллер. Написать программу на языке СИ.

//---------------------------Подключаемые библиотеки--------------------------
#include <avr/io.h>
#include <util/delay.h>
#include "lib_trigger.h"

//---------------------------Инициализация макрасов (кнопки выбора)---------------------------
#define  RSTRIGGER (PINB&0x01)==0
#define  JKTRIGGER (PINB&0x02)==0
#define  DTRIGGER (PINB&0x04)==0
#define  TTRIGGER (PINB&0x08)==0

//---------------------------Инициализация макрасов (коды дешифратора)---------------------------
#define LED_R 0b00010000
#define LED_S 0b00100000
#define LED_J 0b01000000
#define LED_K 0b01100000
#define LED_D 0b10000000
#define LED_C 0b10100000
#define LED_T 0b11000000
#define LED_T2 0b11100000

//---------------------------Инициализация макрасов (кнопки логического состояния)-----------------
#define S_BUTTON (PIND&0x02)==0
#define J_BUTTON (PIND&0x04)==0
#define K_BUTTON (PIND&0x08)==0
#define D_BUTTON (PIND&0x10)==0
#define C_BUTTON (PIND&0x20)==0
#define T_BUTTON (PIND&0x40)==0

//----------------------------Основной код программы--------------------------
int main(void)
{
	PORTD=0xFF;
	DDRD=0x00;
	PORTB=0x0F;
	DDRB=0xF0;

	while (1)
	{
		char chooseTrigger;
		
		while (trigger_selection(&chooseTrigger) && CheckButtonTriggres())       //Пока хоть один из траггеров выбран и они не конфликтуют друг с другом -> выполняем
		{
			if (chooseTrigger=="RS"){                                            //Если выбран RS-триггер то вызываем функцию, которая по таблице истинности имитирует работы триггеров
				CallTriigerRS(R_BUTTON,S_BUTTON,LED_R,LED_S,&PORTB);             //В параметры функции подаем логические сигналы с кнопок отвечающие за определенный триггер и коды дешифратора
				}else if (chooseTrigger=="JK"){                                  //Дальнейшая работа, аналогично коду RS триггера
				CallTriigerJK(J_BUTTON,K_BUTTON,LED_J, LED_K,&PORTB);
				}else if (chooseTrigger=="D"){
				CallTriigerD(D_BUTTON,C_BUTTON,LED_D,LED_C,&PORTB);
				}else if (chooseTrigger=="T"){
				CallTriigerT(T_BUTTON, LED_T,LED_T2,&PORTB);
			}else PORTB = 0x00;                                                  //Сброс параметров для очистки светодиодов
		}
		
		PORTB = 0x00;                                                            //Если ни один из триггеров не выбра, то выключаем индикацию
	}

}

//--------------------Проверка кнопок выбора и определения какой триггер выбра-------------------
int trigger_selection (int * nameTrigger)
{
	do
	{
		if(RSTRIGGER) {*nameTrigger = "RS"; return 1;}
		else if(JKTRIGGER) {*nameTrigger = "JK"; return 1;}
		else if(DTRIGGER) {*nameTrigger = "D"; return 1;}
		else if(TTRIGGER) {*nameTrigger = "T"; return 1;}
		else return 0;
	} while (RSTRIGGER&JKTRIGGER&DTRIGGER&TTRIGGER==1);
}

//-------------------Обработка ошибки когда выбрано более двух триггеров для работы-------------------
int CheckButtonTriggres ()
{
	
	while ((RSTRIGGER) && (JKTRIGGER) || (TTRIGGER) && (DTRIGGER) || (JKTRIGGER) && (TTRIGGER) || (RSTRIGGER) && (DTRIGGER) || (DTRIGGER) && (JKTRIGGER))
	{
		PORTB=0xFF;
		_delay_ms(150);
		PORTB=0x00;
		_delay_ms(150);
		PORTB=0xFF;
		_delay_ms(150);
	}
	
	return 1;
}

