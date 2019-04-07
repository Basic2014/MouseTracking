using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetEnemy : MonoBehaviour
{
    [SerializeField]
    private Transform enemy;

    //2d oyunda var olan hedefe açı hesaplayarak otomatik dönen karakter.

    private void Update()
    {

        Vector2 direction = enemy.position - transform.position;
        Debug.DrawRay(transform.position, direction, Color.red);

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;

        //Aşağıdakilerin hepsi dönüş sağlar

        //transform.eulerAngles = new Vector3(0, 0, angle);
        //transform.localEulerAngles = new Vector3(0, 0, angle);

        Quaternion angleAxis = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = angleAxis;


    }


}
