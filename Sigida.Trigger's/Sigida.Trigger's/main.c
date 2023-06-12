//*****************************
//�����: ������ �.�.          *
//����: 10.02.2020			  *
//������: 1���-17			  *
//��� �����: Sigida.Trigger's *
//��� AVR: ATTINY2313		  *
//*****************************
//���� ���������: �������������� ������ ��� �������� ������ ���������
//����������� ����� ��� �������� ������ ���������. ������ ���������� � ���� 220�, �������� 50 ��. 
//���������� �� ����� ������ ���������: RS, JK, D, T. ������ ������� ������� � ������� ����������� ������: SRS ,SJK SD ,ST 
//�� ����� ��������� ���������� ������ ������ ������ ��������. �� ������ ����-���� ���������� ����������, ������� 
//���������� ������ � ��������� ������. ���������� ��������� ���������� ���������������. �������� ��������� �� ����� ��.

//------------------------------------������������ ����������----------------------------------------
#include <avr/io.h>
#include <util/delay.h>

//------------------------------------������������� ��������-----------------------------------------
#define RSTRIGGER (PIND&0x01)==0
#define JKTRIGGER (PIND&0x02)==0
#define DTRIGGER (PIND&0x04)==0
#define TTRIGGER (PIND&0x08)==0
#define FIRST_BUTTON (PIND&0x10)==0
#define SECOND_BUTTON (PIND&0x20)==0


//------------------------------------�������� ��� ���������------------------------------------------
int main(void)
{
//------------------------------------������������� ������ I/0----------------------------------------
    PORTB=0x00;
    DDRB=0xFF;
	PORTD=0xFF;
	DDRD=0x00;

    while (1) 
    {
//------------------------------------���� ������ RS - ��������----------------------------------------
		//���� ������ RS ������, �� �� ��������� ����������� ���� ������ ���� ������
		//���������� ��� ������ �� ������� ���������� 
		if (RSTRIGGER)
		{
			while (RSTRIGGER)
			{
				//�������� ������ ������ ��������
				CheckButtonTriggres();
				
				if (!FIRST_BUTTON && !SECOND_BUTTON)                 
				{
					PORTB=0x03;
				}
				else if (FIRST_BUTTON && !SECOND_BUTTON)          
				{
					PORTB=0x02;
				}
				else if (!FIRST_BUTTON && SECOND_BUTTON)     
				{
					PORTB=0x01;
				}
				else if (FIRST_BUTTON && SECOND_BUTTON)  
				{
					PORTB=PINB;
				}
				else PORTB=0x00;					  
			}
		}
//------------------------------------���� ������ JK - ��������----------------------------------------
		//���� ������ JK ������, �� �� ��������� ����������� ���� ������ ���� ������
		//���������� ��� ������ �� ������� ���������� 
		else if (JKTRIGGER) 
		{
			
			while (JKTRIGGER)
			{
				//�������� ������ ������ ��������
				CheckButtonTriggres();
				
				if (!FIRST_BUTTON && !SECOND_BUTTON)
				{
					PORTB=0x01;
					_delay_ms(250);
					PORTB=0x02;
					_delay_ms(250);
					PORTB=0x01;
					_delay_ms(250);
				}
				else if (FIRST_BUTTON && !SECOND_BUTTON)
				{
					PORTB=0x02;
				}
				else if (!FIRST_BUTTON && SECOND_BUTTON)
				{
					PORTB=0x01;
				}
				else if (FIRST_BUTTON && SECOND_BUTTON)
				{
					PORTB=PINB;
				}
				else PORTB=0x00;
			}
		}
//------------------------------------���� ������ D - ��������----------------------------------------
        //���� ������ D ������, �� �� ��������� ����������� ���� ������ ���� ������
		//���������� ��� ������ �� ������� ���������� 
		else if (DTRIGGER) 
		{
			while (DTRIGGER)
			{
				//�������� ������ ������ ��������
				CheckButtonTriggres();
				
				if (!FIRST_BUTTON && !SECOND_BUTTON)
				{
					PORTB=PINB;
				}
				else if (FIRST_BUTTON && !SECOND_BUTTON)
				{
					PORTB=PINB;
				}
				else if (!FIRST_BUTTON && SECOND_BUTTON)
				{
					PORTB=0x01;
				}
				else if (FIRST_BUTTON && SECOND_BUTTON)
				{
					PORTB=0x00;
				}
				else PORTB=0x00;
			}
		}
//------------------------------------���� ������ T - ��������----------------------------------------
		//���� ������ T ������, �� �� ��������� ����������� ���� ������ ���� ������
		//���������� ��� ������ �� ������� ���������� 
		else if (TTRIGGER) 
		{
			while (TTRIGGER)
			{
				//�������� ������ ������ ��������
				CheckButtonTriggres();
				
				if (!FIRST_BUTTON)
				{
					PORTB=0x01;
				}
				else if (FIRST_BUTTON)
				{
					PORTB=0x02;
				}
				else PORTB=0x00;
			}
		}else PORTB = 0x00; //���� �� ������ ���� �� ���������, ���������� �� �����.
    }
}

//------------------------------------������� �������� ������ ������------------------------------------
// �������� ������ ������ ��������,
// ���� ������� ����� ���� ���������,
// ����� �� ���������� ������ �� ����������.
int CheckButtonTriggres ()
{
	//���� ������ ����� ���� ������ ������ ��������, �� ������� ������ �� �������� ����������
	while ((RSTRIGGER) && (JKTRIGGER) || (TTRIGGER) && (DTRIGGER) || (JKTRIGGER) && (TTRIGGER) || (RSTRIGGER) && (DTRIGGER) || (DTRIGGER) && (JKTRIGGER))
	{
		PORTB=0xFF;
		_delay_ms(150);
		PORTB=0x00;
		_delay_ms(150);
		PORTB=0xFF;
		_delay_ms(150);
	}
	
	//���� ��� ������, ���������� 0 
	return 0;
}

