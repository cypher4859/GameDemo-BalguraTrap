using System;
using System.Collections.Generic;

namespace GameItemsInterfacesDemo
{
	public class PirateRoom : StoryChapter
	{
        public PirateRoom()
        {

        }

        public override void createStoryMoments(List<StoryEvent> listOfEventsInMoment)
        {
            StoryMoment enterPirateRoomMoment = new StoryMoment(
                "You're currently in a tunnel of rough hewn rock. Walking forward you come to an opening. Moving through it you enter into a chamber of carved rock.",
                "Looking around the chamber you find a bare floor that contains only a chest."
            );

            StoryMoment inspectTheChestMoment = new StoryMoment(
                "Stepping forward you approach the chest and begin to inspect it and the area around it.",
                "You feel confident in the knowledge of the chest."
            );

            StoryMoment openTheChestMoment = new StoryMoment(
                "You place your hands upon the chest and begin to lift the lid of the chest.",
                "The chest opens and you see before you the contents."
            );

            StoryMoment viewContentsChestMoment = new StoryMoment(
                "You see before you a set of approximately 500 gold coins, a magical necklace of rare design, and a set of bone dice.",
                "Do you take the items?"
            );

            StoryMoment takeContentsChestMoment = new StoryMoment(
                "You reach in and begin to fill your back pack with the contents of the chest.",
                "You step back from the chest."
            );

            StoryMoment monsterAppearsItsAMimick = new StoryMoment(
                "A scaly toung flips out from beneath the pile of gold and teeth jut out from the lid. You're staring into the mouth of a mimick!",
                ""
            );

            StoryMoment exitCalmPirateRoomMoment = new StoryMoment(
                "You leave the pirate chamber in it's dark gloom.",
                ""
            );
        }

        public override void createStoryEvents()
        {
            throw new NotImplementedException();
        }
    }
}

