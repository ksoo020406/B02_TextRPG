# B02_TextRPG
 
04.29
***진행사항
강소은 : 메인메뉴에서 선택지를 고를 때 주어진 숫자 외의 다른 입력이 입력될 경우 '잘못된 입력입니다' 출력 필요.
이는 다른 메뉴에서도 공통된 사항이기 때문에 공유가 될 ConsoleUtility 스크립트 제작. ConsoleUtility스크립트에 해당 기능을 해줄 PromptMenuChoice 함수 제작.
            // 2. 선택한 결과를 검증한다.
            int choice = ConsoleUtility.PromptMenuChoice(1, 4);

            // 3. 선택한 결과에 따라 보내준다.
            switch (choice)
            {
                case 1:
                    //StatusMenu(); <= 해당 기능 구현시 마다 수정 필요
                    break;
                case 2:
                    //전투하기 메뉴 메소드
                    break;
                case 3:
                    //InventoryMenu();
                    break;
                case 4:
                    //StoreMenu();
                    break;
            }

유예린 : 게임 시작페이지 만드는 중이었고, 시작멘트랑 캐릭터 생성하시겠습니까? 멘트만 구현되었습니다. 이름이랑 직업 설정하는거 만드는 중이었어요!

배재준 : Git 특강을 재수강?하였고 프로젝트는 아직 시작하지 못했습니다.

이수진 : git에 상점 부분은 연결완료. 5주차 강의 알고리즘 들으면서 추가 기능 구현 생각 중이였습니다.

***머지사항
스타트, 메인메뉴, 스토어 메뉴 브랜치를 Dev에 머지했다. 잘 작동 되는 것도 확인.
