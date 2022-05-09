using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EducationEvents : MonoBehaviour
{
    Dictionary<int, string> events;
    Dictionary<int, string> eventNames;
    Dictionary<int, string> eventEducation;
    [SerializeField] string eventName1;
    [SerializeField] string eventName2; 
    [SerializeField] string eventName3;
    [SerializeField] string eventName4;
    [SerializeField] string eventName5;
    [SerializeField] string event1;
    [SerializeField] string event2;
    [SerializeField] string event3;
    [SerializeField] string event4;
    [SerializeField] string event5;
    [SerializeField] string eventEducation1;
    [SerializeField] string eventEducation2;
    [SerializeField] string eventEducation3;
    [SerializeField] string eventEducation4;
    [SerializeField] string eventEducation5;

    [SerializeField] public GameObject eventCanvas;
    [SerializeField] public GameObject educationCanvas;
    [SerializeField] TMP_Text currentEventName;
    [SerializeField] TMP_Text currentEvent;

    public int eventNum;



    private void Awake()
    {
        eventNames = new Dictionary<int, string>();
        events = new Dictionary<int, string>();
        if(eventCanvas == null)
        {
            eventCanvas = GameObject.FindGameObjectWithTag("EventCanvas");
        }
        if(educationCanvas == null)
        {
            educationCanvas = GameObject.FindGameObjectWithTag("EducationalCanvas");
        }
        eventCanvas.SetActive(true);
        educationCanvas.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        populateStrings();
        populateDictionaries();
        eventCanvas.SetActive(false);
        educationCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void populateStrings()
    {
        eventName1 = "Broken Fishing Pole";
        eventName2 = "Broken Cast Net";
        eventName3 = "Boat Sinks";
        eventName4 = "Oil Spill";
        eventName5 = "Nefarious Business Proposal";

        event1 = "Oh man oh man this is it! You have hooked the big one! This is probably a world record fish. You are too busy envisioning the press conferences and people asking" +
            " for your autograph that you forget to check your drag and....*SNAP*... your fishing pole breaks.";
        event2 = "Just as you have done before at least 3 times, you throw your Cast Net......right into a motor boat's engine propeller. The owner of the boat shoots you a nasty look" +
            " and continues out to sea. You wonder if you will ever see your fishing net again.....(you won't)";
        event3 = "Ah this is the life. Nothing but the sea, fish, and those pesky seagulls to interupt your careful introspection as you lazily steer your boat.......right into a shallow reef." +
            " Your boat is severely damaged and sinking. Maybe it wasn't such a good idea to name the boat The Titanic 2: Electric Bugaloo. You break off a door and float until rescue comes.";
        event4 = "An oil tanker owned by 'TotallyNotTheBadGuys Petroleum'has hit a reef and caused a devastating oil spill. The local authorities are calling all able boats to help in the cleanup effort" +
            " Will you answer the call (lose out on catching any fish this month)";
        event5 = "A local business man that claims he is 'totally on the up and up' offers you $10,000 dollars to head out to see and drop 'a totally harmless' package deep out at sea." +
            "The money is far more than you can make fishing, and the oceans a big place, right? What do you do?";
    }
    void populateDictionaries()
    {
        events.Add(1, event1);
        events.Add(2, event2);
        events.Add(3, event3);
        events.Add(4, event4);
        events.Add(5, event5);

        eventNames.Add(1, eventName1);
        eventNames.Add(2, eventName2);
        eventNames.Add(3, eventName3);
        eventNames.Add(4, eventName4);
        eventNames.Add(5, eventName5);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        eventNum = Random.Range(1, 1);
        eventCanvas.SetActive(true);
        currentEvent.text = events[eventNum];
        currentEventName.text = eventNames[eventNum];
    }
}
