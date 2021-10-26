using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace DangoMimikyu.EventManagement
{
    public class EventManager : MonoBehaviour
    {
        public static EventManager instance { private set; get; }

        private Dictionary<EventTypes, Action<IEventArgData>> m_EventnameToEvent = new Dictionary<EventTypes, Action<IEventArgData>>(); // dictionary of <eventName, ActualEventAction>

        public static event Action<int> testAction;
        #region Monobehaviour functions
        void Awake()
        {
            if (!instance)
            {
                instance = this;
            }
            else
            {
                Debug.LogWarning("Existing EventManager already exist but you're trying to make a new one. will destroy the old one");
                Destroy(instance);
                instance = this;
            }
        }

        void Update()
        {

        }
        #endregion

        #region Subscription functions
        public void StartListening(EventTypes eventType, object sub)
        {

        }
        #endregion
    }
}