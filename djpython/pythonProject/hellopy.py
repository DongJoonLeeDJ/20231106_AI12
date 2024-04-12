'''
여러 줄 짜리 문자열이자
주석도 될 수 있음
옆에 변수가 붙으면 문자열로써 쓸 수 있고
변 수 없으면 그냥 주석임...
'''
a = '''
여러 줄 짜리 문자열이자
주석도 될 수 있음
옆에 변수가 붙으면 문자열로써 쓸 수 있고
변 수 없으면 그냥 주석임...
'''
"""
안녕하세요
이건 주석
입니다
"""
b = """
주석이자
곧 
문자열입니다.
"""
print(a)
print(b)
# 한 줄 주석은 #이며(mysql이랑 동일) ctrl shift f10하면 현재 코드 실행

# 파이썬은 변수 앞에 let, var, int 등 붙이지 않음!!!!!!!
age1 = 15
age2 = 35
if age1<20:
    print('미성년자입니다.') #들여쓰기만 잘해주면 됨, 중괄호 안 씀
    print('따라서 술을 먹을 수 없습니다.')

if age2<20:
    print('미성년자!')
    print('담배를 살 수 없어요!')
elif age2<30: #else if가 아니라 elif라고 적음
    print('아직은 그래도 젊지')
    print('부럽다...')
elif age2<40:
    print('사회적으로 아직은 어리게 볼 수도 있어요')
    print('집에서 디아블로 게임해도 욕은 안 먹을 수도 있어요')
else:
    print('집에서 디아나 스타를 하고 싶어도 손목이 아플 수 있어요')
    print('엄마한테 등짝 스매싱 맞을 수도 있어요')

simbols = [('python','비단뱀'), ('linux','펭귄'), ('java','커피')]
print('언어를 하나 입력해보세요.')
lang = input()
print('그 언어를 상징하는 것을 입력해보세요.')
sim = input()
simbols.append((lang,sim))

for l,s in simbols:
    print(l,s)
    print('언어:%s, 상징:%s'  %   (l,s)  )
    print('언어={}, 상징={}'.format(l,s))

#java, c#과는 다르게 import문을 중간에도 쓸 수 있음
import Student
#Student stu = new Student() # java,C#버전
stu = Student.Student() #Student 클래스 안의
# Student 생성자 호출(__init__를 호출한 것임)
stu.doStudy()








