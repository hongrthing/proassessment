#include <stdio.h>
//c표준 라이브러리 중 하나인 stdio.h 헤더파일에 선언된 내용을 포함시킴
 
int main()
//main 시작함수로 시작 
{
	int i, count = 0, answer;
	// 정수형 변수 i, count, answer생성
	//count 변수 초기값 0으로 지정  
	scanf("%d", &answer);
	//정수형 형식지정자 %d를 사용해 answer값 입력받기  
	for (i = 1; i < 101; i++)
	//반복문인 for문을 사용하여 임의의 변수 i가 0부터 시작해서 101보다 작을때 아래의 코드를 실행하고 i의 값에 1을 더함  
	{
		if (i % answer != 0)
		//조건문 if를 사용하여 i의 값을 answer의 값으로 나눈 나머지가 0이 아닐때 아래의 코드를 실행  
		{
			continue;
			//아래 코드를 건너뜀   
		}
		count++;
		//count의 값에 1을 더함  
	}
	printf("1부터 100까지의 수 중에서 %d의 배수는 %d개입니다. ", answer, count);
	//정수형 형식지정자 %d를 사용하여 answer값과 count값을 출력  
	return 0;
	//main 함수 종료 
}
