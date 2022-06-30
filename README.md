# Capstone-Project Team. Raise (2022, GBSW)

## 웹(Front-end) 깃허브 repository link<br>

https://github.com/jinhyo-dev/Capstone-Project-Front-end

## 1.프로젝트 개요

### 1-1. 프로젝트 주제

    'Smart Farm'

### 1-2. 개발 동기(프로젝트 선정 배경)

저희 할머니께서 시골에서 농사를 짓는데 가끔씩 도와드리다 보니 힘들어서 간단한 조작만으로 식물을 키우는 장치를 만들어야겠다는 생각과 더불어 요즘 개인 농장으로 식물을 재배하는 분들이 많아 그러한 생각을 베이스로 "
스마트팜" 이라는 아이디어가 떠오르게 되었습니다.

### 1-3. 수행 목표

웹사이트로 작물의 현재 현황을 보여주고, 각 식물을 키우는 방법을 담는 것과 일정한 시간마다 물을 자동으로 공급해 주는 시스템 만들기

## 2. 팀 소개

|  구분  |      이름      |                                                                      사진                                                                      |          Mail           |              Github              |                   role             |
|:----:|:------------:|:--------------------------------------------------------------------------------------------------------------------------------------------:|:-----------------------:|:--------------------------------:|:----------------------------------:|
|  팀장  |     이준호      | <img src="https://user-images.githubusercontent.com/86733620/175867981-4b9bdd15-631e-4cf3-a153-627fb25bc62e.jpg" width="100%" height="100%"> |  glwnsgh123@icloud.com  | https://github.com/junho12-tech  |아두이노 개발, 팀 내부 총괄, 외적 디자인, 기획 |
|  팀원  |     김진효      | <img src="https://user-images.githubusercontent.com/86733620/175867409-88daa0dd-5022-42ce-b322-2b215ce2a08e.jpg" width="100%" height="100%"/>  |    admin@jinhyo.dev     |  https://github.com/jinhyo-dev   | 웹 디자인 및 Front-end & Back-end Development |
|  팀원  |     이승우      |  <img src="https://user-images.githubusercontent.com/86733620/175868471-a83923cb-89b0-4d05-9c5f-ec384f705b30.jpg" width="100%" height="100%">  | po01033171881@gmail.com | https://github.com/leeseowoo0810 |               아두이노 개발 및 발표         |
|  팀원  |     권기찬      |  <img src="https://user-images.githubusercontent.com/86733620/175868748-b70f6b61-8653-4f3f-968e-2b4ef760efb7.JPG" width="100%" height="100%">  |  gichan0723@gmail.com   |   https://github.com/atuailyal   |           보고서 작성, PPT 제작 및 발표      |

## 3. 사용기술

#### 3-1. 개발에 사용한 기술
![C#](https://img.shields.io/badge/Csharp-239120?style=round-square&logo=Csharp&logoColor=white)
![Arduino](https://img.shields.io/badge/Arduino-00979D?style=round-square&logo=arduino&logoColor=white)
![Next.js](https://img.shields.io/badge/Next.js-000?style=round-square&logo=Next.js&logoColor=white)
![Typescript](https://img.shields.io/badge/Typescript-3178C6?style=round-square&logo=typescript&logoColor=white)
![Scss](https://img.shields.io/badge/Scss-CC6699?style=round-square&logo=sass&logoColor=white)


#### 3-2. 개발에 소요된 물품 및 준비물
물통 밑 토양에 사용된 ph 센서, 식물재배용 텐트의 온도와 습도를 위한 온 습도센서와 산성도 측정을 위한 ph 센서와
토양의 수분 농도 측정을 위한 수위센서, 산성도 측정 후 알맞은 산성도를 맞추기 위한 산성용액과 ph 용액과 그것을 옮겨줄 수중모터
물통에서 화분으로 물을 주기 위한 고용량 물 펌프, 물의 양을 제어하기 위한 릴레이 모듈, 식물재배용 텐트의 공조 시스템을 위한 220v 팬과 깨끗한 공기를 나가게 해주기 위한
필터, 식물의 광합성을 위한 led3개, 모든 것을 제어하기 위한 아두이노 3개, 쉽게 웹사이트를 볼 수 있게 해주는 태블릿, 태블릿을 거치하기 위한
태블릿 거치대 아두이노에서 입력받은 데이터를 데이터베이스로 이동시키기 위한 노트북, 겨울철 식물의 동사 방지를 위한 발열 매트

#### 총 준비물

    ph센서 2개, 수중모터 2개, 온습도 센서, 수위센서, 물 펌프, 식물재배용 텐트, 배수관, LED 바 3개, 팬, 필터, 화분, 흙,산성용액, ph용액, 아두이노3개, 발열매트
## 4. 수행 추진 일정

* 계획 작성 및 필요한 물품들 구매 (2022년 3월 초)
* 웹사이트 프로그래밍 시작 및 아두이노 코딩 시작 (2022년 4월 말 ~ 5월 초)
* 식물을 키울 수 있는 텐트 조립과 LED, 환풍기 설치 (2022년 5월 중순)
* 아두이노 코딩 완료 및 텐트 조립과 물 공급기 1차 완성 (2022년 5월 말 ~ 6월 초)
* 웹사이트 개발 완료 및 물 공급 최종 완성 (2022년 6월 중순 ~ 현재)

## 5. 프로젝트 상세 소개

#### 5-1. 레이아웃 세부 설명
- 결과 페이지 <br>
![Capstone-page](https://user-images.githubusercontent.com/86733620/176645512-c7d86f75-0834-4f2d-b3f7-a55ce9460057.gif)
> 위에서 받은 데이터들을 Next.js 프레임 워크를 사용하여 웹으로 사용자가 보기 쉽도록 출력하였습니다. 웹 페이지는 1분마다 자동으로 새로고침되며 최근 데이터를 불러옵니다. 사용자는 새로운 데이터가 들어왔는지 새로고침 버튼을 통해 최근 데이터를 불러 올 수 있습니다. 그리고 데이터 지우기 버튼을 누르면 SQL 명령어 'TRUNCATE'를 실행시켜 데이테베이스 필드를 모두 초기화하는 기능을 만들었습니다. 거기에 더불어 사용자가 식울을 어떻게 재배 할 수 있는지 '식물도감' 페이지를 만들어 모두가 쉽고 간단하게 스마트 팜을 이용하였으면 좋겠다는 생각으로 위에 같은 페이지를 제작하게 되었습니다.
#### 5-2. 데이터베이스 구조

|    Field    | data type | explanation  | Properties |
|:-----------:|:---------:|:------------:|:----------:|
|  humidity   |   float   |   습도       |     NN     |
| temperature |   float   |      온도      |     NN     |
| water_level |   float   |    토양 수위     |     NN     |
|     ph      |   float   |    pH 지수     |     NN     |
|    date     |   text    | 데이터를 입력받은 시간 |     NN     |

#### 5-3. 세부 수행 과정
* 아두이노의 실행과정

    
    물통에 대한 산성도를 ph센서가 측정하여 만약 산성도가 높다면 ph엔 용액에 들어있는 수중모터가 가동하여,
    산성도를 낮춰주고 산성도가 낮다면 산성엔 용액의 수중모터가 반응하여 산성도를 높여준다.
    그래서 물의 적절한 산성도가 완성되면 하루에 한번씩 화분에 연결되있는 배수관으로 릴레이모듈의 물펌프가
    가동되어 물을 주게 된다. 그리고 led와 환풍팬은 24시간 돌도록 설계되어있다. 그리고 화분에 설치된 
    온습도 센서, ph센서, 수위센서는 24시간 가동되어 웹 데이터 베이스에 데이터를 보낸다.


* 웹 실행 과정


    위에서 입력받은 데이터를 Next.js 프레임워크로 가져온다. SQL 명령어를 통해 가장 최근에 입력받은 데이터를
    불러와 페이지에 출력한다. '모든 데이터 보기' 버튼을 누르면 이때까지 입력받은 모든 데이터를 출력한다.
    그리고 새로고침 버튼을 누를 시 location.reload()를 실행시키고, 1분마다 이 함수가 실행된다.
    데이터 지우기 버튼을 누르면 데이터베이스의 'TRUNCATE' 명령어를 실행해 테이블 내 모든 데이터를
    초기화 시킨다. 만약 현재 입력받은 데이터가 하나도 없다면 '현재 입력받은 데이터가 없습니다.'라는 문구를
    페이지에 출력한다. 식물도감 페이지는 각 식물마다 고유한 value가 주어지는데, 만약 이 버튼이 바뀌면
    onChange 함수를 이용하여 바뀔 때마다 달라진 value에 따라 조건부 렌더링을 하여 클릭 한 식물의 컴포넌트를
    보여준다.

## 6. 사용자 수행 흐름도

저희가 만든 스마트 팜은 처음부터 자동화를 목표로 만들었으므로, 사용자가 수행해야 할 것이 없습니다.

## 7. 프로젝트 추진 결과

#### 7-1. 결과 분석

처음 계획한 산성도 측정, 물 자동 공급, 온습도 체크 기능은 잘 작동합니다. 텐트 안에서 LED를 켜서 광합성을 가능하게 하고, 식물들을 키우면서 아두이노의 센서를 사용해 현재 온도, 습도, 산성도, 토양 수위를
데이터베이스에 넣고 사용자가 그 데이터를 입력받은 시간과 데이터를 웹사이트에서 쉽게 확인 할 수 있도록 테이블을 출력하는 기능을 완성하였습니다.

#### 7-2. 유지 보수

토양 산성도를 측정하여 PH 용액을 자동 공급하는 기능과, 전체적인 크기를 키우는 것, 온습도를 체크해서 일정 온습도 오차 값에서 벗어날 경우에 그 상황에 맞는 대처를 가능하게 할 계획입니다. 계획대로라면 앞에서
설명드린 기능들을 모두 포함할 예정이었으나, 시간과 금전적인 제약이 있어서 포함하지 못하였습니다.

## 8. 결과 및 발표 자료

#### 깃허브 저장소 주소

https://github.com/jinhyo-dev/2022GBSW-Capstone-Project

#### 실행 주소(웹)

https://capstone.jinhyo.dev

#### 프로젝트 소개 영상 / 팀 소개 영상
- 프로젝트 소개 영상
- 팀 소개 영상



https://user-images.githubusercontent.com/86733620/176339438-6c445cf6-12a8-4b81-960e-dd567aba7634.mp4


#### 계획 발표 자료
https://docs.google.com/presentation/d/1AyIjMhHzWTQqpex6JTnphlfc6zIxOEOqHCIKaiRuIeU/edit?usp=sharing
#### 중간 발표 자료
https://docs.google.com/presentation/d/1DkQhXjxBPvRBFmGbJu-7akROYeW7u4gyB-_GA9EiAwg/edit?usp=sharing
#### 최종 발표 자료

