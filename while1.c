#include <stdio.h>
//c표준 라이브러리 중 하나인 stdio.h 헤더파일에 선언된 내용을 포함시킴

int main()
//main 시작함수로 시작
{
	int i = 1, end;
	//정수형 변수 i, end 생성한뒤 i의 값을 1로 지정  
	printf("수를 입력하세요: "); 
	//문장 출력  
	scanf("%d", &end); 
	//정수형 형식지정자를 사용하여 end 값 입력받기  
	while (i < end); { 
	//반복문인 while문을 사용하여 i의 값이 end값 보다 작을때 아래의 코드를 실행  
	printf("%d", i); 
	//정수형 형식지정를 사용하여 i값 출력  
	i++; 
	//i의 현재값에 1을 더한 값을 i의 값으로 지정  
	}
	return 0;
	//main함수 종료
}
