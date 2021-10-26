using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DangoMimikyu.EventManagement
{
    public interface IEventArgData
    {
        string eventName { get; } // name of the event to listen to, this variable is set as a read-only accessor
    }


    public class EventArgumentData<T> : IEventArgData
    {
        public string eventName { private set; get; }
        public T otherArguments;

        public EventArgumentData(string EventToSub, T otherArgs)
        {
            eventName = EventToSub;
            otherArguments = otherArgs;
        }
    }
}