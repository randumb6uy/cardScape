using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cardFunc : MonoBehaviour
{
    
    public Card card;
    public Text _name;
    public Text description;
    public Text cost;
    public Image artwork;
    void Start()
    {
        _name.text = card._name;
        description.text = card.description;
        cost.text = card.cost.ToString();
        artwork.sprite = card.image;   
    }

    
}
