#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main() {
	//		예제 :: 5개의 성적을 입력을 모두 받은 뒤,
	//		성적값들에 대해 한번씩 순회하며,
	//		60 아래의 값이 발견되면 60으로 값을 변경한다.
	//		그 뒤로, 5개의 성적에 대한 평균값을 구해라.
	//		다만, 배열을 사용하되 포인터 형태의 배열을 사용하고
	//		[] 기호는 포인터 배열을 선언할 때만 사용하여라.
	//		(배열값 조회에선 다른 방법을 찾아볼 것)

	// 1. 5개의 성적을 입력 (순회해야해서 배열로 받기)
	int score[5];
	int* pscore = score;
	for (int i = 0; i < 5; i++) {
		// scanf("%d", *pscore[i]);
		scanf("%d", pscore + i);		// 주소값을 필요 (&score[i])
			// pscore :: pscore의 시작 주소 (일반 배열도 그럼)
	}

	// 2. 배열의 값 순회하며, 60 아래의 값을 60으로 수정
	for (int i = 0; i < 5; i++) {
		if (*(pscore + i) < 60) {
			*(pscore + i) = 60;
		}
	}

	// 3. 5개의 성적에 대해서, 평균값을 구하라.
	double result = 0;
	for (int i = 0;i < 5;i++) {
		result += *(pscore + i);
	}
	printf("평균값 :: %.1f", result / 5);
}