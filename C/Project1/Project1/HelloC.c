#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
// stdio.h :: ����� �Լ� �����ϴ� ���̺귯��

int main() {
	// ���α׷� ���� �� ������ ��ɾ main���� �ۼ�
	
	// ����� :: printf(), scanf()
	int num;		// ������
	char ch;		// ������ (C���� String���� ����)
	double d;		// �Ǽ���
	// int(%d) -> char(%c) -> double(%lf) ������ �Է�
	scanf("%d %c %lf", &num, &ch, &d);
	// %c :: "������ �Է¹��� ���� �ִ�."

	printf("�ȳ��ϼ��� �������Դϴ�.\n");
	printf("������ :: %d\n", num);
	printf("���ڰ� :: %c\n", ch);
	printf("�Ǽ��� :: %.1f\n", d);	
	// double�� ��½� %f ����ص� ����
}