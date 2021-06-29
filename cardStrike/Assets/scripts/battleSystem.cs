using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum BattleState{start , playerTurn,enemyTurn , win ,loss }
public class battleSystem : MonoBehaviour
{
    public BattleState state;
    public GameObject enemy;
    public GameObject player;
    public Transform pSpawn;
    public Transform eSpawn;
    unit enemyUnit;
    unit playerUnit;
    void Start()
    {
     state = BattleState.start;
     setup();   
    }

    void setup()
    {
        Instantiate(player , pSpawn);
        playerUnit = player.GetComponent<unit>();
        
        Instantiate(enemy , eSpawn );
        enemyUnit = enemy.GetComponent<unit>();
    }
}
