using System;

namespace Miyeonsi_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("┌──────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                          │");
            Console.WriteLine("│    두근두근....                                          │");
            Console.WriteLine("│                      게임속에 들어가 연애를 즐겨보자!    │");
            Console.WriteLine("│                                                          │");
            Console.WriteLine("└──────────────────────────────────────────────────────────┘");
            Console.WriteLine("┌───────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                               │ ");
            Console.WriteLine("│    게임 설명                                                                  │");
            Console.WriteLine("│                                                                               │");
            Console.WriteLine("│    당신은 게임속으로 들어가 같은 교양을 듣는 남학생을 꼬셔야 합니다.          │");
            Console.WriteLine("│    남학생에게 여러 대화를 나누고 데이트를 함께하며 호감도를 높여보세요!       │");
            Console.WriteLine("│    선택지에 따라 호감도가 달라집니다. 호감도가 20이상이면 게임 클리어         │");
            Console.WriteLine("│    호감도가 마이너스로 끝날 시 당신은 남학생에게 차이며 휴학을 하게 됩니다.   │");

            Console.WriteLine("│    게임을 종료하고 싶다면 q를 눌러주세요.                                     │");
            Console.WriteLine("│    스페이스를 누르면 게임이 시작됩니다.                                       │");
            Console.WriteLine("│                                                                               │ ");
            Console.WriteLine("└───────────────────────────────────────────────────────────────────────────────┘");
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    break;
                }
            }

            int heart = 1;
            int stage = 1;

            while (true)
            {
                Console.Clear();

                //-----------------------------------
                //
                //   문제
                //
                //-----------------------------------
                if (stage == 1)
                {
                    Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("│ 새로운 새학기... 당신은 교실에서 마음에 드는 남학생을 발견합니다.  어느 자리에 앉으시겠습니까? │");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("│ 1번: 옆자리                                                                                    │");
                    Console.WriteLine("│ 2번: 앞자리                                                                                    │ ");
                    Console.WriteLine("│ 3번: 뒷자리                                                                                    │");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("└────────────────────────────────────────────────────────────────────────────────────────────────┘");



                }
                else if (stage == 2)
                {
                    Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("│ 남학생이 모르는 문제를 물어봅니다 어떤 대답을 하시겠습니까?                                    │");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("│ 1번: 아! 이거 정답은 3번이야 ㅎㅎ 원래 모르면 조삼모사거든                                     │");
                    Console.WriteLine("│ 2번: 미안 나도 모르겠어ㅠㅠ                                                                    │");
                    Console.WriteLine("│ 3번: (아무말 없이 교수님을 모셔온다,)                                                          │");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("└────────────────────────────────────────────────────────────────────────────────────────────────┘");
                }
                else if (stage == 3)
                {
                    Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("│ 교수님께서 팀플을 진행합니다. 운좋게도 같은 팀이 되었습니다. 어떤 역할을 맡으시겠습니까?       │");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("│ 1번: 리더쉽 하면 나야! 내가 조장을 할게.                                                       │");
                    Console.WriteLine("│ 2번: 나 발표는 자신있어!                                                                       │");
                    Console.WriteLine("│ 3번: 내가 ppt를 만들어도 될까?                                                                 │");
                    Console.WriteLine("│ 4번: 자료조사는 내가 맡고싶어                                                                  │");
                    Console.WriteLine("│ 5번: 저는 남는거 할게요...                                                                     │");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("└────────────────────────────────────────────────────────────────────────────────────────────────┘");
                }

                else if (stage == 4)
                {
                    Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine("│                                                                                                                                                                                                                       │");
                    Console.WriteLine("│ 깜짝이벤트!!!                                                                                                                                                                                                         │");
                    Console.WriteLine("│                                                                                                                                                                                                                       │");
                    Console.WriteLine("│ 남학생과 가위바위보 게임! 게임에서 이기면 5점 동점이면 1점 지면 게임오버 입니다.                                                                                                                                  │");
                    Console.WriteLine("│                                                                                                                                                                                                                       │");
                    Console.WriteLine("│ 1 = 가위                                                                                                                                                                                                              │");
                    Console.WriteLine("│ 2 = 바위                                                                                                                                                                                                              │");
                    Console.WriteLine("│ 3 = 보                                                                                                                                                                                                                │");
                    Console.WriteLine("│                                                                                                                                                                                                                       │");
                    Console.WriteLine("└────────────────────────────────────────────────────────────────────────────────────────────────┘");

                    //-----------------------------------
                    // 스테이지 : 4(깜짝게임)
                    //-----------------------------------
                    string my = Console.ReadLine();
                    Console.Clear();
                    Console.Write("나의 선택은 :" + my);

                    Random rand = new Random();
                    int com = rand.Next(0, 3);

                    string you = "";


                    if (com == 0)
                    {
                        you = "1";
                    }
                    else if (com == 1)
                    {
                        you = "2";
                    }
                    else if (com == 2)
                    {
                        you = "3";
                    }
                    Console.WriteLine("남학생의 선택은:" + you);

                    if (my == "1")
                    {
                        if (you == "1")
                        {
                            Console.WriteLine("비겼습니다.(호감도 +1)");
                            heart += 1;
                        }
                        else if (you == "2")
                        {
                            Console.WriteLine("졌습니다.(호감도 +0)");
                            heart = 0;
                        }
                        else if (you == "3")
                        {
                            Console.WriteLine("이겼습니다.(호감도 +5)");
                            heart += 5;
                        }
                    }
                    if (my == "2")
                    {
                        if (you == "2")
                        {
                            Console.WriteLine("비겼습니다.(호감도 +1)");
                            heart += 1;
                        }
                        else if (you == "3")
                        {
                            Console.WriteLine("졌습니다.(호감도 +0)");
                            heart = 0;
                        }
                        else if (you == "1")
                        {
                            Console.WriteLine("이겼습니다.(호감도 +5)");
                            heart += 5;
                        }
                    }
                    if (my == "3")
                    {
                        if (you == "3")
                        {
                            Console.WriteLine("비겼습니다.(호감도 +1)");
                            heart += 1;
                        }
                        else if (you == "1")
                        {
                            Console.WriteLine("졌습니다.(호감도 +0)");
                            heart = 0;
                        }
                        else if (you == "2")
                        {
                            Console.WriteLine("이겼습니다.(호감도 +5)");
                            heart += 5;
                        }
                        else
                        {
                            Console.WriteLine("잘못 입력 하셨습니다.");
                        }


                    }

                    


                    //-----------------------------------
                    // 게임의 종료 조건 : 성공/실패
                    //-----------------------------------

                    if (heart <= 0)
                    {
                        Console.WriteLine("당신은 차였습니다... 교무처로 가 휴학을 신청하세요...");
                        break;
                    }
                }

                else if (stage == 5)
                {
                    Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("│ 내일은 프로젝트의 마지막 날... 기억에 남을 선물을 주고 싶다. 무엇을 줄까?                      │");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("│ 1번: 남학생을 닮은 인형                                                                        │");
                    Console.WriteLine("│ 2번: 먹고 남은 음료수 뚜껑                                                                     │");
                    Console.WriteLine("│ 3번: 당첨! 이라 적힌 아이스크림 막대기                                                         │");
                    Console.WriteLine("│ 4번: 민트초코 간식                                                                             │");
                    Console.WriteLine("│ 5번: 솔의 눈 음료수                                                                            │");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("└────────────────────────────────────────────────────────────────────────────────────────────────┘");


                }
                else if (stage == 6)
                {
                    Console.WriteLine("┌────────────────────────────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("│프로젝트를 마쳤다.. 이제 팀플에서 그를 볼 수 없다는 생각에 당신은 돌직구를 던지기로 한다        │");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("│ 1번: 혹시 관심있는 여자애 있어?                                                                │");
                    Console.WriteLine("│ 2번: 도를 믿으세요?                                                                            │");
                    Console.WriteLine("│ 3번: 내가 밥 사줄게. 같이 밥 먹을래?                                                           │");
                    Console.WriteLine("│                                                                                                │ ");
                    Console.WriteLine("└────────────────────────────────────────────────────────────────────────────────────────────────┘");


                }
                else if (stage == 7)
                {
                    // 마지막 스테이지
                    Console.WriteLine("┌─────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine("│         모든 수업이 끝나 종강했다.. 그에게 마음을 물어보자      │");
                    Console.WriteLine("│                                                                 │");
                    Console.WriteLine("│                   !!최종 호감도 확인!!                          │");
                    Console.WriteLine("│                                                                 │");
                    Console.WriteLine("└─────────────────────────────────────────────────────────────────┘");

                    // 최종 호감도 확인
                    Console.WriteLine("총 호감도: " + heart);

                    // 엔딩 
                    if (heart >= 20)
                    {
                        Console.WriteLine("남학생에게 고백을 받았습니다! 달콤한 CC를 즐겨보세요!");
                    }
                    else if (heart >= 10 && heart < 20)
                    {
                        Console.WriteLine("남학생이 친구로 지내길 원합니다... 남사친을 얻었습니다.");
                    }
                    else
                    {
                        Console.WriteLine("당신은 남학생에게 아무것도 아닌 존재입니다... 그냥 전과하세요");
                    }

                    // 게임 종료
                    break;
                }

                //-----------------------------------
                //
                //   답
                //
                //-----------------------------------

                if (stage == 1)
                {
                    string user = Console.ReadLine();
                    Console.WriteLine("내가 선택한 것은?: " + user);

                    //-----------------------------------
                    // 스테이지 : 1
                    //-----------------------------------

                    if (user == "1")
                    {
                        Console.WriteLine("남학생: 아 미안.. 여기 자리있어..     (호감도 -1)");
                        heart--;
                    }
                    else if (user == "2")
                    {
                        Console.WriteLine("남학생: (처음보는 사람이네.. 공부 잘하려나) (호감도 +5)");
                        heart += 5;
                    }
                    else if (user == "3")
                    {
                        Console.WriteLine("남학생:... 수업 언제 시작하지? (호감도 +1)");
                        heart++;
                    }
                    
                    }
                if (stage == 2)
                {
                    string user = Console.ReadLine();
                    Console.WriteLine("내가 선택한 것은?: " + user);
                    if (user == "1")
                    {
                        Console.WriteLine("남학생: ㅋㅋㅋㅋ알겠어 잘 찍어볼게!(재밌는 애네...)     (호감도 +3)");
                        heart += 3;
                    }
                    else if (user == "2")
                    {
                        Console.WriteLine("남학생: 아 그래..? 어쩔 수 없지..(똑똑한 줄 알았는데 실망..)     (호감도 -2)");
                        heart -= 2;
                    }
                    else if (user == "3")
                    {
                        Console.WriteLine("남학생: 아 네 교수님.. 저 이 문제를 모르겠는데요..(교수님을 불러준 애는 처음보네.)     (호감도 +1)");
                        heart++;
                    }
                }
                 if (stage == 3)
                {
                    string user = Console.ReadLine();
                    Console.WriteLine("내가 선택한 것은?: " + user);
                    if (user == "1")
                    {
                        Console.WriteLine("남학생: 오~ 자신감 믿음직스러운데?     (호감도 +1)");
                        heart += 1;
                    }
                    else if (user == "2")
                    {
                        Console.WriteLine("남학생: 발표 잘하는거 쉽지 않은데!     (호감도 +1)");
                        heart += 1;
                    }
                    else if (user == "3")
                    {
                        Console.WriteLine("남학생: 보노보노 넣는거 아냐..? 걱정되는데...     (호감도 -2)");
                        heart -= 2;
                    }
                    else if (user == "4")
                    {
                        Console.WriteLine("남학생: 나도 자료조사 하려 했는데 같이 하면 되겠다!.)     (호감도 +3)");
                        heart += 3;
                    }
                    else if (user == "5")
                    {
                        Console.WriteLine("남학생: 자신감이 없나... 좀 그렇네.)     (호감도 -3)");
                        heart -= 3;
                    }

                }

                 if (stage == 5)
                {
                    string user = Console.ReadLine();
                    Console.WriteLine("내가 선택한 것은?: " + user);
                    if (user == "1")
                    {
                        Console.WriteLine("남학생: 으...스토커 아니야?     (호감도 -5)");
                        heart -= 5;
                    }
                    else if (user == "2")
                    {
                        Console.WriteLine("남학생: 이건...뭐지..?     (호감도 -1)");
                        heart -= 1;
                    }
                    else if (user == "3")
                    {
                        Console.WriteLine("남학생: 아싸! 점심시간에 먹어야지!     (호감도 +4)");
                        heart += 4;
                    }
                    else if (user == "4")
                    {
                        Console.WriteLine("남학생: 오 먹을줄 아는 애였잖아?     (호감도 +2)");
                        heart += 2;
                    }
                    else if (user == "5")
                    {
                        Console.WriteLine("아 이런거 왜 먹어     (호감도 -10)");
                        heart -= 10;
                    }
                }

                if (stage == 6)
                {
                    string user = Console.ReadLine();
                    Console.WriteLine("내가 선택한 것은?: " + user);
                    if (user == "1" && stage == 6)
                    {
                        Console.WriteLine("남학생: 없긴한데 딱히 관심있진 않아    (호감도 -3)");
                        heart -= 3;
                    }
                    else if (user == "2" && stage == 6)
                    {
                        Console.WriteLine("남학생: 도....레미파솔라시도?    (호감도 +3)");
                        heart += 3;
                    }
                    else if (user == "3" && stage == 6)
                    {
                        Console.WriteLine("남학생: 아 진짜? 비싼거 먹어도 되는거지? 가자~~    (호감도 +5)");
                        heart += 5;
                    }

                }


                stage++;
                    Console.WriteLine("                                   ");
                    Console.WriteLine("총 호감도: " + heart);
                    Console.WriteLine("\n\n다음 이벤트로 넘어가려면 아무 키나 누르세요.");
                    Console.ReadKey();

                }
            }
        }
    }

