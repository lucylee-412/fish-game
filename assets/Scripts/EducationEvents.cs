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
    Dictionary<int, string> nonEduEvents;
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
    [SerializeField] string didYouKnow;

    [SerializeField] string nonEduEventName1;
    [SerializeField] string nonEduEventName2;
    [SerializeField] string nonEduEventName3;
    [SerializeField] string nonEduEventName4;

    [SerializeField] string nonEduEvent1;
    [SerializeField] string nonEduEvent2;
    [SerializeField] string nonEduEvent3;
    [SerializeField] string nonEduEvent4;

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
        eventName1 = "Illegal Fish Caught";
        eventName2 = "Fishing Limit Reahed";
        eventName3 = "Fishing with Explosives!";
        eventName4 = "Oil Spill";
        eventName5 = "Nefarious Business Proposal";

        event1 = "As you go to claim your catch, you see a local endangered species has found its way into your possession. You know that this fish sells for $2500 for use in the aqauriums of the criminal underworld, but it is" +
			"illegal to remove one from its local habitat. Do you keep the fish and sell it in the criminal underworld?;
        event2 = "A upcoming storm has forced all of the other so-called 'wise' fishermen inside and you experience an embarrassment of riches in the fish department. You quickly reach your limit of fish, but no one is around" +
			" and the fish are just begging to be cause. Do you stay and keep fishing?";
        event3 = "One of your friends has a surplus of dynamite and attempts to convince you of the benefits of fishing with explosives. After hearing them out, you can clearly see that the method is effective" +
			"and you can turn a quick profit of $10,000 in one month. Do you want to fish with explosives?";
        event4 = "An oil tanker owned by 'TotallyNotTheBadGuys Petroleum' has hit a reef and caused a devastating oil spill. The local authorities are calling all able boats to help in the cleanup effort" +
            " Will you answer the call (lose out on catching any fish this month)?";
        event5 = "A local business man that claims he is 'totally on the up and up' offers you $10,000 dollars to head out to see and drop 'a totally harmless' package deep out at sea." +
            "The money is far more than you can make fishing, and the oceans a big place, right? What do you do?";

        eventEducation1 = "Many fish are protected by various government agencies all over the globe. Taking fish directly from reefs for use in aquariums can be harmful to a marine population if left" +
			"unregulated. Punishments for keeping protected fish range from fines to jail time in extreme cases.";
        eventEducation2 = "Fish populations are closely monitored in marine habitats and fish limits are calculated based on the populations. Ignoring limits can have extreme consquences for the " +
			"unscrupulous fisherman, as US Fish & Wildlife is empowered to search any catch to ensure limits are respected. Failure to do so can lead to fines and jail time.";
        eventEducation3 = "It should come as no surprise that fishing with explosives is highly destructive to a marine ecosystem. This method of fishing is more commonly seen in developing countries" +
            "and the damage caused to reefs, which are vital for a robust marine ecosystem in many parts of the world, is immense.";
        eventEducation4 = "Oil in marine ecosystems that stem from human activity can have severe consequences for a marine ecosystem in the short term. Mammals and sealife that breach the surface" +
			"are at greatest risk of harm as the oil floats to the surface. Quick action to contain and clean man made oil spills is crucial to protecting the marine ecosystem.;
        eventEducation5 = "Prior to the 1970s, ocean dumping was commonplace in many parts of the world, as the ocean was viewed as a place of near unlimited capacity to disperse" +
			"waste. Subsequent research would prove this assumption false and while many places have enacted measures to prevent/limit ocean dumping, international waters and 3rd world countries " +
			"remain largely unregulated";
        didYouKnow = "Did you know?";

        nonEduEventName1 = "Broken Fishing Pole"; ;
        nonEduEventName2 = "Bait Stolen";
        nonEduEventName3 = "Broken Cast Net"; ;
        nonEduEventName4 = "Fish Spoils";
        nonEduEventName5 = "Boat Sinks";

        nonEduEvent1 = "Oh man oh man this is it! You have hooked the big one! This is probably a world record fish. You are too busy envisioning the press conferences and people asking" +
        " for your autograph that you forget to check your drag and....*SNAP*... your fishing pole breaks.";
        nonEduEvent2 = "Just as you get settle down in the perfect fishing spot, you notice a big white mass in the sky headed your way. Perplexed, you attempt to puzzle out the meaning of " +
			" this event, when you hear a deafening squawking of seagulls....And its too late. The pirates of the sky quickly steal all your bait and you must replace it all.";
        nonEduEvent3 = "Just as you have done before at least 3 times, you throw your Cast Net......right into a passing boat's engine propeller. The owner of the boat shoots you a nasty look" +
        " and continues out to sea. You wonder if you will ever see your fishing net again.....(you won't)";
        nonEduEvent4 = "You have a relatively fantastic day of fishing and you catch a large number of fish. You immediately daydream of the riches in store for yourself. As you pack up your equipment to" +
			" head home for the day, you notice a funny smell coming from your fish container. To your horror, you realize you forgot to put water in the container and all the fish have spoiled in the heat (no money this month).";
        nonEduEvent5 = "Ah this is the life. Nothing but the sea, fish, and those pesky seagulls to interupt your careful introspection as you lazily steer your boat.......right into a shallow reef." +
        " Your boat is severely damaged and sinking. Maybe it wasn't such a good idea to name the boat The Titanic 2: Electric Bugaloo. You break off a door and float on it until rescue comes.";;




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