#include <stdio.h>
//c표준 라이브러리 중 하나인 stdio.h 헤더파일에 선언된 내용을 포함시킴  

int main() 
//main 시작함수로 시작  
{
	int salary = 0;
	//정수형 변수 salary 를 생성하고 초기값 0으로 설정  
	int money[10] = { 50000, 10000, 5000, 1000, 500, 100, 50, 10, 5, 1 };
	//크기가 10인 정수형 1차원 배열 money를 생성하고 위 값을 지정   
	int count[10];
	//크기가 10인 정수형 1차원 배열 count를 생성  
	scanf_s("%d", &salary);
	//정수형 형식지정자 %d를 사용하여 salary 값 입력받기  
	for (int i = 0; i < 10; i++) 
	//반복문인 for문을 사용하여 임의의 변수 i가 0부터 시작해서 10보다 작을때 아래의 코드를 실행하고 i의 값에 1을 더함  
	{
		count[i] = salary / money[i]; 
		//count배열에서 i값에 해당되는 칸에 salary값을 money배열에서 i값에 해당되는 칸에 할당되어져 있는 값으로 나눈 몫을 대입함  
		salary = salary - (money[i] * count[i]);
		//salary 변수에 기존 salary변수의 값에서 money배열에서 i값에 해당되는 칸에 할당되어져 있는 값과 count배열에서 i값에 해당되는칸에 할당되어져 있는 값의 곱을 뺀 값을 대입함  
	}
	for (int i = 0; i < 10; i++)
	//반복문인 for문을 사용하여 임의의 변수 i가 0부터 시작해서 10보다 작을때 아래의 코드를 실행하고 i의 값에 1을 더함  
	{
		printf("%d\n", count[i]);
		//정수형 형식지정자 %d를 사용하여 count배열에서 i값에 해당되는 칸에 할당되어져 있는 값을 출력함  
	}
	return 0;
	//main함수 종료  
}
