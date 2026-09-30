 internal class Program
 {
    //플레이어 클래스
    
    static void Main(string[] args)
    {
        //Random random = new Random();
        //var randValue = random.Next(6);
        //Console.WriteLine(randValue);

        //math
        //var v = -1000;
        //Math.Abs(v);
        //Console.WriteLine(v);   

        //var pi = Math.PI;
        //Console.WriteLine(pi);

        //무언가 구현하고 싶을 때 ctrl + "."하면 구현 가능 

        //GameRankingSYS ranking = GameRankingSYS();

        List<Student> list = new List<Student>();
        list.Add(new Student() { name = "설지운", grade = 1 });
        foreach (var item in list)
        {
            Console.WriteLine(item.name + " : " + item.grade);
        }
        
        }
}   

