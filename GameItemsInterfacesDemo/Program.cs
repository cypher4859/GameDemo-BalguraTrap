using System;
using System.Collections.Generic;

namespace GameItemsInterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Things this repo showcases:
            // =========================
            // objects/classes
            // inheritance
            // interfaces
            // virtuals
            // abstracts

            // This repo is unfinished as far as being a text based game
            // however you'll find a couple additions that were not shown in the
            // video demonstration of writing this. These new additions are here
            // to help lay some groundwork if you wanted to extend this.
            // - StoryController (manages the story and everything about it)
            // - PirateRoom (pieces of the story that our StoryController drives)

            // *NOTE for the curious*: this project does not make use of "event driven" programming
            // but if you were building this to be dynamic, i.e. player can do ALL
            // sorts of things, enemies can do things of their own will, etc. then
            // you would want to use "event driven" programming. Tricky to understand,
            // but easy to use and a powerhouse of functionality.


            Console.WriteLine("Hello We're going to explore a dungeon");

            // Player is currently in a tunnel
            // They're about to walk into a rock chamber with a pirate chest in it
            // Likely be at least 2 enemies

            // Create the items we need
            // - Room
            // - Chest
            // - Enemies

            // Handle player exploring the pirate chest
            List<Enemy> listOfEnemies = new List<Enemy>();

            Player player = new Player();

            MimickEnemy mimickEnemy = new MimickEnemy("mike");
            BalguraMonster primaryEnemy = new BalguraMonster("someName");
            Enemy secondaryEnemy = new BalguraMonster("carl");
            GhostMonster ghost = new GhostMonster("Casper");

            listOfEnemies.Add(mimickEnemy);
            listOfEnemies.Add(primaryEnemy);
            listOfEnemies.Add(secondaryEnemy);
            listOfEnemies.Add(ghost);

            PossessedMetalSword possessedSword = new PossessedMetalSword("Casper");
            possessedSword.isPossessingSomething = true;
            possessedSword.SwingSword();

            // Casting to the Interface shape
            MetalSword metalSword = new MetalSword();
            (metalSword as ISword).SwingSword();

            //primaryEnemy.PerformAttack();
            //mimickEnemy.PerformAttack();

            foreach(Enemy enemy in listOfEnemies)
            {
                enemy.PerformAttack();
            }
        }
    }
}
