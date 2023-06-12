#include <avr/io.h>
#include <avr/interrupt.h>

#define BAUDRATE 9600 // Скорость обмена данными
#define F_CPU 8000000UL // Рабочая частота контроллера

unsigned char NUM = 0;  
unsigned char count = 0;
unsigned char byte_receive = 0;
unsigned char i = 1;


void _delay_us(unsigned char time_us)
{ register unsigned char i;

	for(i = 0; i < time_us; i++)
	{
		asm volatile(" PUSH  R0 ");
		asm volatile(" POP   R0 ");
	}
}


void _delay_ms(unsigned int time_ms)
{ register unsigned int i;

	for(i = 0; i < time_ms; i++)
	{ 
		_delay_us(250);
		_delay_us(250);
		_delay_us(250);
		_delay_us(250);
	}
}

	#define RS PD2 
	#define EN PD3

// Функция передачи данных по USART
void uart_send(char data)
{
	while(!( UCSRA & (1 << UDRE)));	// Ожидаем когда очистится буфер передачи
	UDR = data; // Помещаем данные в буфер, начинаем передачу
}

// Функция передачи строки по USART
void str_uart_send(char *string)
{
	while(*string != '\0')
	{
		uart_send(*string);
		string++;
	}
}

// Функция приема данных по USART
int uart_receive(void)
{
	while(!(UCSRA & (1 << RXC)));// Ожидаем, когда данные будут получены
	return UDR; // Читаем данные из буфера и возвращаем их при выходе из подпрограммы
}

// Инициализация USART
void uart_init(void)
{
// Параметры соединения: 8 бит данные, 1 стоповый бит, нет контроля четности
// USART Приемник: Включен
// USART Передатчик: Включен
// USART Режим: Асинхронный
// USART Скорость обмена: 9600

	UBRRL = (F_CPU/BAUDRATE/16-1); // Вычисляем скорость обмена данными  
	UBRRH = (F_CPU/BAUDRATE/16-1) >> 8;

	UCSRB |= (1 << RXCIE)| // Разрешаем прерывание по завершению приема данных
          (1 << RXEN)|(1 << TXEN); // Включаем приемник и передатчик
                                                
	UCSRC |= (1 << URSEL)| // Для доступа к регистру UCSRC выставляем бит URSEL
         (1 << UCSZ1)|(1 << UCSZ0);  // Размер посылки в кадре 8 бит
}

// Прерывание по окончанию приема данных по USART
ISR(USART_RXC_vect)
{
	NUM = UDR; // Принимаем символ по USART
	byte_receive = 1;
	uart_send(NUM); // Посылаем символ по USART
	
	switch (NUM)
	{
		case '1':
			PORTB |= (1 << PB0);
		break;
		case '2':
			PORTB |= (1 << PB1);
		break;
		case '3':
			PORTB |= (1 << PB2);
		break;
		case '4':
			PORTB |= (1 << PB3);
		break;
		case '5':
			PORTB |= (1 << PB4);
		break;
		case '6':
			PORTB |= (1 << PB5);
		break;
		case '7':
			PORTB |= (1 << PB6);
		break;
		case '8':
			PORTB |= (1 << PB7);
		break;
		case '9':
		PORTB = 0x00;
		break;
	}
}

// ������� �������
int main(void)
{
	DDRB = 0xFF;
	PORTB = 0x00;        			

	DDRC  = 0x00;	
	PORTC = 0xFF;
	
	DDRD  = 0b11111110;
	PORTD = 0x00;
	
	uart_init(); // Инициализация USART
	
	sei(); // Разрешаем глобальные прерывания

	str_uart_send("Initialization system\r\n"); // Передаем строку по USART
	str_uart_send("UART V0.1.1 Izvarin Dima\r\n"); // Передаем строку по USART
	_delay_ms(2500);
	
	while(1)
	{

		if(byte_receive)
		{
			byte_receive = 0;
			count++;
			if(count > 16) //Если строка заполнена
			{
			count = 0;
			}
		}
	}
}