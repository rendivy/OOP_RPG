﻿using System;
using System.Collections.Generic;
 using System.Deployment.Internal;
 using System.Linq;
 using System.Threading;
using WindowsFormsApp1.Objects;
using WindowsFormsApp1.Objects.Assets;
 using WindowsFormsApp1.Objects.Dungeon;
 using WindowsFormsApp1.Objects.Enemies;

namespace WindowsFormsApp1
{
    public static class GameEngine
    {
        private static AssetFactory assetFactory = new AssetFactory();

        private static List<Creature> creatures = new List<Creature>();
        private static List<GameObject> gameObjects = new List<GameObject>();

        private static MainCharacter mainCharacter;
        private static List<NPC> npc = new List<NPC>();
        private static List<Enemy> enemies = new List<Enemy>();

        private static List<Chest> chests = new List<Chest>();

        private static Random rnd = new Random();

        private static System.Threading.Timer creatureMoveTimer;

        private static bool isRunning = true;
        
        private static Dungeon dungeon = new Dungeon(new Coordinates(400f, 400f));
        
        private static double CalculateDistance(GameObject creature)
        {
            return Math.Sqrt((creature.Coordinates.X - mainCharacter.Coordinates.X) * (creature.Coordinates.X - mainCharacter.Coordinates.X) +
                             (creature.Coordinates.Y - mainCharacter.Coordinates.Y) *(creature.Coordinates.Y - mainCharacter.Coordinates.Y));
        }
        
        public static GameObject GetNearestObject<T>()
        {
            var filtredCreatures = gameObjects.OfType<T>().ToList().OfType<GameObject>().ToList();
            
            var index = 0;
            var nearestDistance = CalculateDistance(filtredCreatures[0]);
            
            for (int i = 1; i < filtredCreatures.Count; i++)
            {
                var currentDistance = CalculateDistance(filtredCreatures[i]);

                if (currentDistance < nearestDistance)
                {
                    nearestDistance = currentDistance;
                    index = i;
                }
            }

            return filtredCreatures[index];
        }
        
        public static void EnemyAction()
        {
            for (int k = 0; k < enemies.Count; k++)
                creatures[0] = enemies[k].UseAction(creatures[0]);
        }
        
        public static void MoveCreatures(float width, float height)
        {
            for (int i = 0; i < creatures.Count; i++)
            {
                if (rnd.NextDouble() < 0.25)
                    creatures[i].Move(width, height);
                else
                    creatures[i].Stop();
            }
        }

        public static Coordinates GetRandomCoordinates(float width, float height)
        {
            return new Coordinates((float)GameEngine.rnd.NextDouble() * width,
                (float)GameEngine.rnd.NextDouble() * height);
        }
        
        public static void GenerateCreatures(float width, float height)
        {
            enemies = new EnemyFactory(width, height).Enemies;
            npc = new NPCfactory(width, height).NPClist;
            mainCharacter = new MainCharacter(GetRandomCoordinates(width, height));
            
            creatures.Add(mainCharacter);
            
            foreach (var enemy in enemies)
                creatures.Add(enemy);
            
            foreach (var npc in npc)
                creatures.Add(npc);

            foreach (var creature in creatures)
                gameObjects.Add(creature);

            chests = dungeon.Chests;

            foreach (var chest in chests)
                gameObjects.Add(chest);
        }
        
        public static void PlayerAttack(object sender, EventArgs e)
        {
            GameObject enemy = GetNearestObject<Enemy>();
            
            int enemyIndex = Enemies.IndexOf((Enemy)enemy);
            int creatureIndex = Creatures.IndexOf((Creature)enemy);
            int gameObjectIndex = GameObjects.IndexOf(enemy);
            
            enemy = (Enemy)MainCharacter.Attack((Creature)enemy);

            Enemies[enemyIndex] = (Enemy)enemy;
            Creatures[creatureIndex] = (Creature)enemy;
            GameObjects[gameObjectIndex] = enemy;
        }
        
        public static void UpdateGameEngine(float width, float height)
        {
            EnemyAction();
            MoveCreatures(width, height);
            GameEngine.mainCharacter.Bleed();
        }

        public static Timer CreatureMoveTimer
        {
            get => creatureMoveTimer;
            set => creatureMoveTimer = value;
        }

        public static List<Enemy> Enemies
        {
            get => enemies;
            set => enemies = value;
        }

        public static bool IsRunning
        {
            get => isRunning;
            set => isRunning = value;
        }
        
        public static Random Rnd => rnd;
        public static List<NPC> Npc => npc;

        public static MainCharacter MainCharacter
        {
            get => mainCharacter;
            set => mainCharacter = value;
        }
        public static List<Creature> Creatures => creatures;
        public static List<GameObject> GameObjects => gameObjects;
        public static AssetFactory AssetFactory => assetFactory;
        public static Dungeon Dungeon => dungeon;
        public static List<Chest> Chests => chests;
    }
}
