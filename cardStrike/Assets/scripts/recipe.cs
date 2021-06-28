using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "rcp", menuName = "recipe")]
public class recipe : ScriptableObject 
{
    public elements Input1;
    public elements Input2;
    public List<elements> result = new List<elements>();
}