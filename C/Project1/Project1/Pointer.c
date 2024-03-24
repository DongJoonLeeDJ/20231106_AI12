#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main() {
	// 포인터 :: "가리키는 것"
	// &(주소연산자), *

	int num = 5;
	printf("값 :: %d\n", num);
	printf("주소값 :: %d\n\n", &num);	
		// & :: 변수의 메모리 주소 반환

	// 포인터 변수 :: "특정 메모리를 가리키는 변수"
	// - num을 가리키는 변수 생성
	int* pnum;		// "어느 지점을 가리키는" pnum 변수 생성
	pnum = &num;
	printf("그냥 pnum 출력 :: %d\n", pnum);
	printf("*pnum 출력 :: %d\n", *pnum);
}