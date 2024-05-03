﻿using System;
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
            return monsters;
        }

        public List<Monster> GetRandomMonsters()
        {
            List<Monster> randomMonsters = new List<Monster>();

            int numMonsters = random.Next(1, 5);

            for (int i = 0; i < numMonsters; i++)
            {
                int randomIndex = random.Next(0, monsters.Count);
                randomMonsters.Add(monsters[randomIndex]);
            }

            return randomMonsters;
        }
    }
}
