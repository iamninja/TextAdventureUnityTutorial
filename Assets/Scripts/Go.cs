using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActoins/Go")]
public class Go : InputAction
{

    public override void RespondToInput(GameController controller, string[] seperatedInputWords)
    {
        controller.roomNavigation.AttemptToChangeRooms(seperatedInputWords[1]);
    }
}
