using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text displayText;

    [HideInInspector] public RoomNavigation roomNavigation;
    [HideInInspector] public List<string> interactionDescriptionsInRoom = new List<string>();

    // This is the log
    List<string> actionLog = new List<string>();

	// Use this for initialization
	void Awake ()
    {
        roomNavigation = GetComponent<RoomNavigation>();
	}

    private void Start()
    {
        DisplayRoomText();
        DisplayLoggedText();
    }

    public void DisplayRoomText()
    {
        UnpackRoom();
        string joinedInteractionDescriptions = string.Join("/n", interactionDescriptionsInRoom.ToArray());
        string combinedText = roomNavigation.currentRoom.description + "\n" 
            + joinedInteractionDescriptions;

        LogStringWithReturn(combinedText);
    }

    public void LogStringWithReturn(string stringToAdd)
    {
        actionLog.Add(stringToAdd + "\n");
    }

    public void DisplayLoggedText()
    {
        string logAsText = string.Join("/n", actionLog.ToArray());

        displayText.text = logAsText;
    }

    void UnpackRoom()
    {
        roomNavigation.UnpackExitsInRoom();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
