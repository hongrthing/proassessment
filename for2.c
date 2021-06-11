#include <stdio.h>
//c표준 라이브러리 중 하나인 stdio.h 헤더파일에 선언된 내용을 포함시킴

/* line 4 ~ 19까지 주석처리  
int main() 
//main 시작함수로 시작 (한줄 주석 처리는 필요 없지만 편의상 사용) 
{
	int i; 
	//정수형 변수 i 생성  
	for (i = 1; i < 10; i++)
	//반복문인 for문을 사용하여 임의의 변수 i가 0부터 시작해서 10보다 작을때 아래의 코드(line 12 ~ 15)를 실행하고 i의 값에 1을 더함
	{
		printf("2x%d = %2d\n", i, i * 2); 
		//위의 문자열에서 정수형 형식 지정자를 사용하여 앞에는 i값을 출력하고, 뒤에는 2자리수 이하일땐 앞에 공백을 추가한뒤 i값을 출력함  
	}
	return 0; 
	//main함수 종료
}
*/

#include <stdio.h>
//c표준 라이브러리 중 하나인 stdio.h 헤더파일에 선언된 내용을 포함시킴
int main()
//main 시작함수로 시작
{
	int i, j; 
	//정수형 변수 i, j생성  
	for(i = 2; i < 10; i++)
	//반복문인 for문을 사용하여 임의의 변수 i가 2부터 시작해서 10보다 작을때 아래의 코드(line 30 ~ 37)를 실행하고 i의 값에 1을 더함
	{
		for (j = 1; j < 10; j++)
		//반복문인 for문을 사용하여 임의의 변수 j가 1부터 시작해서 10보다 작을때 아래의 코드(line 33 ~  36)를 실행하고 j의 값에 1을 더함
		{
			printf("%dx%d = %d", i, j, i*j); 
			//정수형 형식지정자를 사용하여 앞에서 부터 차례대로 i, j, i와 j를 곱한값을 출력함  
		}
	}
}