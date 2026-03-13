using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("=== 컬렉션 셔플 테스트 ===");
List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine($"원본: {string.Join(", " , num)}");
num.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", num)}");

List<string> deck = new List<string> { "♠A", "♥K", "♦Q", "♣J" };
Console.WriteLine($"원본: {string.Join(", ", deck)}");
deck.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", deck)}");

List<string> student = new List<string> { "김철수", "이영희", "박민수", "최지연", "정우진" };
Console.WriteLine($"원본: {string.Join(", ", student)}");
student.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", student)}");

static class Collection
{
    
    public static List<T> Shuffle<T>(this List<T> ary)
    {
        Random random = new Random();
        int length = ary.Count;

        try
        {
            for(int i = length-1; i>0; i--)
            {
                int r = random.Next(0, i +1);
                T temp = ary[i];
                ary[i] = ary[r];
                ary[r] = temp;
            }
        }
        catch when (ary == null) 
        {
            throw new ArgumentNullException();
        }
        return ary;
    }
}