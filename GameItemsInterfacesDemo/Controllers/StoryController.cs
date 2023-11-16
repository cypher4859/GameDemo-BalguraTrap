using System;
using System.Collections.Generic;

namespace GameItemsInterfacesDemo
{
    public class StoryController
    {
        private StoryChapter _currentStoryChapter;

        public StoryChapter currentStoryChapter
        {
            get { return _currentStoryChapter; }
            set { _currentStoryChapter = value; }
        }
        private List<StoryChapter> _listOfStoryChapters = new List<StoryChapter>();
        public StoryController()
        {
            PirateRoom pirateRoom = new PirateRoom();
            _listOfStoryChapters.Add(pirateRoom);
        }
    }

    /// <summary>
    /// A story chapter represents a series of story moments each of which contains a series of events.
    /// </summary>
    public abstract class StoryChapter
    {
        protected StoryMoment currentStoryMoment;
        protected List<StoryMoment> momentsInChapter = new List<StoryMoment>();

        public abstract void createStoryMoments(List<StoryEvent> listOfEventsInMoment);
        public abstract void createStoryEvents();
    }

    /// <summary>
    /// A story moment has a set of text that can be displayed when the moment begins and ends
    /// as well as a list of events that can happen.
    /// </summary>
    public class StoryMoment
    {
        protected string onEntranceText; // Used when the moment Starts
        protected string onExitText; // Used when the moment ends
        protected List<StoryEvent> eventsInMoment = new List<StoryEvent>();

        public StoryMoment(string entranceText, string exitText, List<StoryEvent> listOfEvents = null)
        {
            onEntranceText = entranceText;
            onExitText = exitText;
            eventsInMoment = listOfEvents;
        }
    }

    /// <summary>
    /// A story event is equivalent to an item in a linked list.
    /// It can point to a previous event as well as a future event.
    /// </summary>
    public class StoryEvent
    {
        protected StoryEvent nextStoryEvent;
        protected StoryEvent previousStoryEvent;

        protected virtual void handleStoryEvent()
        {
            throw new NotImplementedException();
        }
    }
}

