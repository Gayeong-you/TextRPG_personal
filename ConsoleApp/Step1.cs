namespace ConsoleApp;


    public class Character
    {
        public int level = 255;
        public string name = "daisy";
        public string job = "wizard";
        public int attack = 300; 
        public int defense = 500;
        public int health = 200;
        public int Gold = 1000;
        
    }

    public class TextRpg 
    { 
        Character character = new Character();

       string[] itemNames = 
        {
            "무쇠갑옷", //0
            "낡은 검", //1
            "연습용 창", //2
        };
       
        int[] itemTypes = //아이템 타입 배열
        {
            1, //방어구
            0, //무기
            0  
        };

        int[] itemStats = //아이템 공격력 배열
        {
            5, //무쇠갑옷, 방어력
            2, //낡은 검, 공격력
            3 //연습용 창, 공격력
        };

        string[] itemAbout = //아이템 설명 배열
        {
            "무쇠로 만들어져 튼튼한 갑옷입니다.", 
            "쉽게 볼 수 있는 낡은 검입니다.",   
            "검보다는 그대로 창이 다루기 쉽죠."  
        };
        
        //장착여부 배열 만들기 (장비를 찼는지 안찼는지 따져보아야하는데, false 안 찬 상태가 기본이다.)
        bool [] equipment =
        {
            false,
            false,
            false
        };
        
        
        static void Main()
        {
            TextRpg textRpg  = new TextRpg();
            textRpg.Intro();
        }
        
        public void Intro()
        {
            while(true)
            {
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.\n이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
                Console.WriteLine("1.상태 보기\n2.인벤토리");
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                
                    string input = Console.ReadLine();
                    if (input == "1") 
                    {
                        Console.WriteLine("상태보기를 선택했습니다.");
                        Information(); 
                    }
                    else if (input == "2")
                    {
                        Console.WriteLine("인벤토리를 선택했습니다."); 
                        Inventory();
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                    }
                
            }
            
        }
        public void Information() //step 3 상태보기 
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("상태 보기 \n 캐릭터의 정보가 표시됩니다.");
                Console.WriteLine($"Level: {character.level}\n{character.name}( {character.job} )\n공격력: {character.attack}\n방어력: {character.defense}\n체력: {character.health}\nGold: {character.Gold} G");
                
                Console.WriteLine("0.나가기");
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                
                string input = Console.ReadLine();
                
                    if  (input == "1")
                    {
                        Console.WriteLine(character.name);
                        Console.WriteLine(character.job);
                        Console.WriteLine(character.level);
                        Console.WriteLine(character.health);
                        Console.WriteLine(character.Gold);
                        Console.WriteLine(character.attack);
                        Console.WriteLine(character.defense);
                    }
                    else if (input == "0")
                    {
                        Console.Clear();
                        TextRpg textRpg  = new TextRpg();
                        textRpg.Intro();
                    }
            }
        }
        
        public void InventoryList() 
        { 
            for (int i = 0; i< 3; i++) //배열은 무조건 반복문!
            {
                Console.Write($"-{itemNames[i]}");
                
                if (equipment[i]==true) //아이템 장착시 앞에 E 붙여줌
                {
                    Console.Write("[E]");
                }
                if (itemTypes[i] == 0) //무기
                {
                    Console.Write($"\t공격력+{itemStats[i]}");
                }
                else if (itemTypes[i] == 1) //방어구
                {
                    Console.Write($"\t방어력+{itemStats[i]}");
                }
             
                Console.WriteLine($"|\t{itemAbout[i]}");
            }
        } 

        public void Inventory()  //step 5
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine("[아이템 목록]");
                
                //아이템 목록 호출
                InventoryList();
                
                Console.WriteLine("1.장착 관리");
                Console.WriteLine("0.나가기");
                string input = Console.ReadLine();
                
                
                if (input == "1")
                {
                    Console.WriteLine("장착 관리를 실행합니다");
                    Equipment(character);
                }
                else if (input == "0")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
                
            }
        }
        
        
        //장착관리 매서드 
        public void Equipment(Character character){
            Console.Clear();
           
            for (int i = 0; i<itemNames.Length; i++)
            {
                Console.Write($"{i+1}{itemNames[i]}"); 
                if (equipment[i]==true)
                {
                    Console.Write("[E]");
                }
                if (itemTypes[i] == 0)
                {
                    Console.Write($"\t공격력+{itemStats[i]}");
                }
                else if (itemTypes[i] == 1)
                {
                    Console.Write($"\t방어력+{itemStats[i]}");
                }
                
             
                Console.WriteLine($"|\t{itemAbout[i]}");
            }
            
            
            string input = Console.ReadLine(); //유저가 값을 넣음 1.2.3. 백그라운드 0.1.2
            int idx = int.Parse(input)-1;   //백그라운드에서 인덱스값(0~2)과 유저가 입력한 문자값(1~3)이 다르기 때문에 인풋에 하나 빼줌
            
           
           if (equipment[idx]==false) //장비를 장착하고 있지 않을때
           {
               equipment[idx] = true;
               if (itemTypes[idx] == 0) //무기
               {
                   character.attack += itemStats[idx]; //무기+(공격력)
               }
               else if (itemTypes[idx] == 1)//방어구
               {
                   character.defense += itemStats[idx]; //방어구 +방어력
               }
           }
           else //장착하고 있을 때 
           {
               equipment[idx] = false;
               if (itemTypes[idx] == 0) //무기
               {
                   character.attack -= itemStats[idx]; //무기-(공격력)
               }
               else if (itemTypes[idx] == 1)//방어구
               {
                   character.defense -= itemStats[idx]; //방어구 -방어력
               }
           }
           
           InventoryList();
           
            string input2 = Console.ReadLine();
            if (input2 == "0")
            {
                Console.Clear();
                return;
            }
            
            if (equipment[idx]==true)
            {
              InventoryList();
              Information();
            }
            

        }
    }



