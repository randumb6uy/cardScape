using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recipeMixer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject reactant = null;

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount >= 2)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                reactant = transform.GetChild(i).gameObject; 

            }   
        }   
    }
}
