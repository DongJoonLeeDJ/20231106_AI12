class Student: #self 키워드는 무조건 필수
    def __init__(self):
        pass # 아무 것도 안 한다는 의미
    def doStudy(self):
        print('몇 시간 공부할래?')
        studytime = int(input())
        print('%d시간 공부합니다.' % studytime)