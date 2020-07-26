using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private UIManager ui;
    public void OnEnable()
    {
        SpawnManager.enemyCount++;
        ui = GameObject.Find("UIManager").GetComponent<UIManager>();
        ui.UpdateEnemyCount();
        Die();
    }

    public void OnDisable()
    {
        SpawnManager.enemyCount--;
        ui.UpdateEnemyCount();
    }

    void Die()
    {
        Destroy(this.gameObject, Random.Range(2, 6));
    }
}
