using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_TextRPG
{
    public class MonsterManager
    {
        private Random random = new Random();
        private List<Monster> monsters;

        public MonsterManager()
        {
            monsters = new List<Monster>();
            InitializeMonsters();
        }

        private void InitializeMonsters() // 몬스터를 초기화 메소드 
        {
            monsters.Add(new Monster("혁최몬", 2, 15, 5));
            monsters.Add(new Monster("록유몬", 3, 10, 9));
            monsters.Add(new Monster("석우몬", 5, 25, 8));
        }

        public List<Monster> GetMonsters()
        {
            List<Monster> monsters = new List<Monster>();

            // 랜덤한 수의 몬스터를 생성
            Random random = new Random();
            int numberOfMonsters = random.Next(1, 5); // 1부터 4까지의 랜덤한 수

            for (int i = 0; i < numberOfMonsters; i++)
            {
                // 몬스터를 생성하고 목록에 추가
                monsters.Add(this.monsters[random.Next(this.monsters.Count)]);
            }
            return monsters;
        }

        

    }
}
