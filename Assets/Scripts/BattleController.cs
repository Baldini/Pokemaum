using UnityEngine;
using System.Collections;

public class BattleController : MonoBehaviour
{

    private Player pPlayer;
    private Enemy pEnemy;
    // Use this for initialization
    void Start()
    {
        pPlayer = FindObjectOfType<Player>();
        pEnemy = FindObjectOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
