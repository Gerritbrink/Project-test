using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ConvesationManager : MonoBehaviour
{
    public Convesation conversation;
    public int convoNum;
    public TMP_Text text;
    void Start ()
    {
        
        text.text = conversation.convoText[convoNum];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
