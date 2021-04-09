# :dart: unity
###### - 게임제작 강의 정리 및 실습
<br />

## 교재 및 리소스
##### - [그림으로 이해하고 만들면서 익히는 유니티 교과서[개정 4판]](https://www.gilbut.co.kr/book/view?bookcode=BN002998&keyword=%EC%9C%A0%EB%8B%88%ED%8B%B0%20%EA%B5%90%EA%B3%BC%EC%84%9C&collection=GB_BOOK)
##### - https://github.com/gilbutITbook/080267
<br />

## [Game]
### 1. [3D Cube](./3D_Cube)
* 3D Cube Object 생성 후 translation, rotation, scale 적용(수치는 내 마음대로)
<br />

![3D_Cube](https://user-images.githubusercontent.com/35367660/113586651-bad1aa00-9668-11eb-9bf4-dc769af68737.PNG)
<br />

### 2. [C# Programming](./C%23_Programming)
* [C# Script](./C%23_Programming/Assets/Test.cs) 작성 후 콘솔 창 확인
1. Player 클래스를 만들고 Attack(), Damage() 메소드의 결과 출력.
2. Rectangle 클래스를 만들고 rectangle의 넓이와 둘레를 출력.
3. Student 클래스를 만들고 멤버변수 score 배열에 차례대로 수학, 과학, 영어, 국어, 음악 점수를 저장. 제니와 지수의 과목 성적과 평균을 출력.
<br />

![C#_Script](https://user-images.githubusercontent.com/35367660/113848534-8dedd600-97d3-11eb-82aa-359a57e97c3b.PNG)
<br />

### 3. [Roulette_Game](./Roulette_Game)
* [[Roulette]](./Roulette_Game/Roulette) : 왼쪽 마우스를 클릭하면 Roulette이 회전, 시간이 지날수록 서서히 멈춤.

<img src="https://user-images.githubusercontent.com/35367660/114051921-7f351b00-98c8-11eb-998d-159f7f4b00ff.gif" width="500">

* [[Three Roulettes]](./Roulette_Game/Three_Roulettes)
1. Left Roulette - 왼쪽 마우스를 클릭하면 회전하다가 정지함. 화살표로 선택된 운수를 출력
2. Middle Roulette - Left Roulette을 왼쪽으로 60도 회전한 상태로 배치. 왼쪽 마우스 클릭하면 회전하다가, 오른쪽 마우스를 클릭하면 회전 속도 1씩 감소
3. Right Roulette - Left Roulette을 오른쪽으로 60도 회전한 상태로 배치. 왼쪽 마우스를 클릭하는 동안 계속 회전, 왼쪽 마우스를 클릭 해제하면 서서히 멈춤

<img src="https://user-images.githubusercontent.com/35367660/114121314-1cc03700-9929-11eb-80ce-cdb3ea63d571.gif" width="800">
<br />


## 참고자료
* .gitignore 생성 [참고1](https://github.com/github/gitignore/blob/master/Unity.gitignore) (/[Ll]ibrary/, /[Tt]emp/ 등 에서 맨앞의 '/' 을 삭제한다.)
