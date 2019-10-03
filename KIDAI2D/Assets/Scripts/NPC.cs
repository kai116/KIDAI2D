using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {
       [Header ("對話")]
       public string SayStart = "";
       public string SayNotComplete = "";
       public string SayComplete = "";
    [Header("對話速度")]
    public float TalkSpeed;
    [Header("任務相關")]
    public bool Complete;
    public float CompletePlayer, CompleteFinish;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
