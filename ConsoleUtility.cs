namespace B02_TextRPG
{
    internal class ConsoleUtility
    {
        // 메뉴 초이스 함수
        // 번호에 제한을 주기위해 최소, 최대 값이 필요하다.
        public static int PromptMenuChoice(int min, int max)
        {
            // 유저가 될 때까지 시도할 수 있게 하기 위해 while (true)
            while (true)
            {
                Console.Write("원하시는 번호를 입력해주세요 : ");

                // 입력을 제대로 했는지 확인하기 위한 조건
                // 제대로 숫자를(입력을) 넣었고 && 그 숫자가 최소 값 이상이고 && 최대 값 이하라면
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= min && choice <= max)
                {
                    // 유저가 입력한 값에 따라 반환한다.
                    return choice;
                }
                Console.WriteLine("잘못된 입력입니다.");
            }
        }

        // 작성 된 글자수가 몇 글자 짜리인가 판단
        public static int GetPrintTextLength(string str)
        {
            int length = 0;
            foreach (char c in str)
            {
                if (char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter)
                {
                    length += 2; // 한글과 같은 넓은 문자에 대해 길이를 2로 취급
                }
                else
                {
                    length += 1; // 나머지 문자에 대해 길이를 1로 취급
                }
            }
            return length;
        }

        // 고정폭의 글자 출력
        // totalLength = 글자수 제한
        public static string SpacingLetters(string str, int totalLength)
        {
            int curentLength = GetPrintTextLength(str);
            int padding = totalLength - curentLength;
            return str.PadRight(str.Length + padding);
        }
    }
}