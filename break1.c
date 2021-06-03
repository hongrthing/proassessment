#include <stdio.h>
//c표준 라이브러리 중 하나인 stdio.h 헤더파일에 선언된 내용을 포함시킴

int main()
//main 시작함수로 시작 
{
	int answer; 
	//정수형 변수 answer생성  
	while (1)
	//반복문인 while문의 조건을 1로 하여 무한루프를 생성함  
	{
		scanf("%d", &answer); 
		//정수형 형식지정자 %d를 사용하여 answer 값 입력받기  
		if (answer == 0)
		//조건문 if를 사용하여 answer가 0일때 아래의 코드(16 ~ 19)를 실행  
		{
			break; 
			//while문 종료  
		}
		else
		//위의 조건을 충족하지 않았을때 아래의 코드(22 ~ 25)를 실행  
		{
			printf("%d 입력\n", answer); 
			//정수형 형식지정자 %d를 사용하여 answer 값 출력, 줄바꿈  
		}
	}

	return 0;
	//main 함수 종료  
}
