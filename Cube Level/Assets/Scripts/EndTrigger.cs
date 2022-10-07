using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameOrderer gameOrderer;
    void OnTriggerEnter()
    {
        gameOrderer.CompleteLevel();
    }
}
