using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NPCDialogueData",menuName = "Data/NPC", order = 1)]
public class NPCDialogueData : ScriptableObject
{
    public List<string> Repliks => repliks;
   [SerializeField]
    protected List<string> repliks;
}
