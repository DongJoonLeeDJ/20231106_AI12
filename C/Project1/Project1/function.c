#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

// n=5, 5*4*3*2*1 순으로 곱셈 진행할 예정
int factorial(int n) {
	if (n == 1) { return 1; }
	else {
		return n * factorial(n - 1);
	}
}

// 재귀 :: 자기 자신을 호출하는 함수
int main(){
	// 예제 :: 팩토리얼
	// "n을 입력받고, n! 값을 구하라"
	// n! = n*(n-1)* ... * 2 *1

	// 1. n 입력
	int n;
	scanf("%d", &n);

	int result = factorial(n);
	printf("결과값 :: %d", result);
}