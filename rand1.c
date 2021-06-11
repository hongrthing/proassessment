#include<stdio.h> 
//c표준 라이브러리 중 하나인 stdio.h 헤더파일에 선언된 내용을 포함시킴
#include<stdlib.h> 
//c표준 라이브러리 중 하나인 stdlib.h 헤더파일에 선언된 내용을 포함시킴
#include<time.h> 
//c표준 라이브러리 중 하나인 time.h 헤더파일에 선언된 내용을 포함시킴 
 
int main(void)
//main 시작함수로 시작
{
	int a;
	//정수형 변수 a 생성  
	srand((unsigned)time(NULL));
	//0 ~ 32367(2바이트의 최대 표현범위)중 임의의 숫자를 하나 뽑음 (난수 생성) 

	for (a = 0; a < 6; a++)
	//반복문인 for문을 사용하여 임의의 변수 a가 0부터 시작해서 6보다 작을때 아래의 코드를 실행하고 a의 값에 1을 더함

		printf("%d  ", 1 + rand() % 45);
		//정수형 형식지정자를 사용하여 난수를 45로 나눈뒤 그 나머지값에 1을 더한 값을 출력  
	return 0;
	//main함수 종료
}
