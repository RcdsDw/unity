using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class BillardMaster : MonoBehaviour
{
    public Balle balle;
    public Balle[] enemies;
    private Vector3 ballePos;
    private Vector3[] enemiesPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ballePos = balle.transform.position;
        //foreach (Balle enemy in enemies)
        //{
        //    foreach (Vector3 enemyPos in enemiesPos)
        //    {
        //        enemyPos = enemy.transform.position;
        //    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
