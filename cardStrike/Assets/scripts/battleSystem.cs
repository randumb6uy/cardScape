using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum BattleState{start , playerTurn,enemyTurn , win ,loss }
public class battleSystem : MonoBehaviour
{
    public BattleState state;
    public GameObject[] enemys;
    public GameObject player;
    public Transform pSpawn;
    public Transform eSpawn;
    public unit enemyUnit;
    public unit playerUnit;
    public HUD playerHud;
    public Text dialouge;
    public HUD enemyHud;
    public GameObject currentEnemy;
    void Start()
    {
     state = BattleState.start;
     setup();   
    }

    void setup()
    {
        int rand = Random.Range(0 , enemys.Length);
        Instantiate(player , pSpawn.position , Quaternion.identity);
        playerUnit = player.GetComponent<unit>();
        playerUnit.health = playerUnit.maxHealth;
        playerUnit.defence = playerUnit.maxDefence;
        playerUnit.energy = playerUnit.maxEnergy;
        
        currentEnemy = Instantiate(enemys[rand] , eSpawn.position , Quaternion.identity) as GameObject;
        enemyUnit = currentEnemy.GetComponent<unit>();
        enemyUnit.health = enemyUnit.maxHealth;
        enemyUnit.defence = enemyUnit.maxDefence;
        

        dialouge.text = "prepare your move !";
        
        playerHud.SetHud(playerUnit);
        enemyHud.SetHud(enemyUnit);
        
        state = BattleState.playerTurn;
        
    }
    private void Update() 
    {
        if (enemyUnit != null)
        {
//            Debug.Log("enemy is ready");    
        }   
    }
}
