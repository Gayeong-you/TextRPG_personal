namespace ConsoleApp;

public class step3
{
    //1번

    static void SayHello()
    {
        Console.WriteLine("안녕하세요");
    }
    static void Main()
    {
        SayHello();
        StartGame();
        PrintLine();
        DisplayMenu();
        PrintLevel(5);
        PrintHp(80);
        MonsterAttack("고블린");
        TakeDamage(10);
        PrintItemPrice("HP포션",50);
        
        //5번
        GreetPerson();
        
        int result = Add(10, 20);
        Console.WriteLine(result); //11번
        
        result = Subtract(100, 30);
        int remianingHP = result; //12번
        
        result = Multiply(5, 10);
        int totalDamage = result;//13번
        
        float result2 = Divide(10.0f, 4.0f);//14번
        
        GetWelcomeMessage("스파르타");//15번


    }
    
    
    
   // 2. **(선언)**
   //
   static void StartGame()
   {
       Console.Write("게임을 시작합니다!");
   }

  
   
   
  //3번
  static void PrintLine()
  {
      Console.WriteLine("===");
  }

  
  //4. **(선언)**

  static void DisplayMenu()
  {
      Console.WriteLine("메뉴: 1. 상태 보기 2. 인벤토리 3. 상점");
  }

  
  //5번

  static void GreetPerson(string name)
  {
      Console.WriteLine("안녕하세요"+name+"님!");
  }

  static void GreetPerson()
  {
      Console.WriteLine("Gayeong");
  }


  //6번

  static void PrintLevel(int level)
  {
      Console.WriteLine("당신의 레벨은"+level+"입니다.");
  }
  
  
  //7번

  static void PrintHp(int hp)
  {
      Console.WriteLine($"현재 HP: {hp}");
  }
  
  
  
  //8번

  static void MonsterAttack(string monsterName)
  {
      Console.WriteLine(monsterName+"이(가) 공격합니다!");
  }
  
  
  //9번

  static void TakeDamage(int damage)
  {
      Console.WriteLine("플레이어는"+damage+"의 데미지를 입었습니다.");
  }
  

  
  //10번

  static void PrintItemPrice(string itemName, int price)
  {
      Console.WriteLine(itemName+"의 가격은"+price+"골드입니다.");
  }
  


  //11번

  static int Add(int a, int b)
  {
      int sum = a + b;
      return sum;
  }
  
  //12번

  static int Subtract(int a, int b)
  {
      int sum = a - b;
      return sum;
  }
  
  
  //13번
  
  static int Multiply(int a, int b)
  {
      int sum = a * b;
      return sum;
  }
  
 //14번

 static float Divide(float a, float b)
 {
     return a / b;
 }
 
 
 

 static string GetWelcomeMessage(string name)
 {
     return "환영합니다." + name + "님";
 }
 
 
}