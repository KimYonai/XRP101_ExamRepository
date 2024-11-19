# 1번 문제

주어진 프로젝트 내에서 CubeManager 객체는 다음의 책임을 가진다
- 해당 객체 생성 시 Cube프리팹의 인스턴스를 생성한다
- Cube 인스턴스의 컨트롤러를 참조해 위치를 변경한다.

제시된 소스코드에서는 큐브 인스턴스 생성 후 아래의 좌표로 이동시키는 것을 목표로 하였다
- x : 3
- y : 0
- z : 3

제시된 소스코드에서 문제가 발생하는 `원인을 모두 서술`하시오.

## 답안
- CubeManager의 소스코드에서 CreateCube(큐브 프리팹 생성 함수)가 먼저 진행되지 않은 채로 SetCubePosition(큐브 프리팹 위치 함수)를 실행하여 큐브 프리팹이 생성되지 않는 문제 
  - SetCubePosition를 CreateCube 아래에 위치시켜 큐브 프리팹이 생성되게 문제 해결
- 큐브 프리팹이 (0, 0, 0) 좌표에 생성되는 문제 발생
  - CubeController의 SetPosition에서 SetPoint를 (3, 0, 3)으로 새로 할당
  - CubeManager의 SetCubePosition에서 CubeController를 참조하여 큐브 프리팹의 위치를 (3, 0, 3)으로 지정하는 것으로 문제 해결
