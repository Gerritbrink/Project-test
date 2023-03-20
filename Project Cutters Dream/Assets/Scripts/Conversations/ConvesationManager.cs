using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvesationManager : MonoBehaviour
{
    public Convesation conversation;
    public int convoNum;
    
    void Start ()
    {
        print(conversation.convoText[convoNum]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
