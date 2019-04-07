using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{


    //2d oyunda mouse hareketini takip eden sprite.
    //Input.mouseposition bize screen pointteki bilgileri döner. Transform.pos ise world space.Aynı düzlemde olmaları gerekir.
    //onun için trans.pos world'den screen'e çeviriliyor.



    private void Update()
    {
        Vector2 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);

        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90 ;

        Quaternion axis = Quaternion.AngleAxis(angle, transform.forward);
        transform.rotation = axis;
    }
}
