#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main() {
	// ������ :: "����Ű�� ��"
	// &(�ּҿ�����), *

	int num = 5;
	printf("�� :: %d\n", num);
	printf("�ּҰ� :: %d\n\n", &num);	
		// & :: ������ �޸� �ּ� ��ȯ

	// ������ ���� :: "Ư�� �޸𸮸� ����Ű�� ����"
	// - num�� ����Ű�� ���� ����
	int* pnum;		// "��� ������ ����Ű��" pnum ���� ����
	pnum = &num;
	printf("�׳� pnum ��� :: %d\n", pnum);
	printf("*pnum ��� :: %d\n", *pnum);
}