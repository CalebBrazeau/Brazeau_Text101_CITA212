using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10,14)] [SerializeField] string strStoryText;
    [SerializeField] State[] strNextStates;

    public string strGetStateStory()
    {

        return strStoryText;
    }
    public State[] GetNextStates()
    {
        return strNextStates;
    }
}
