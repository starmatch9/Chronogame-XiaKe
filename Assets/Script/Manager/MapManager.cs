using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public GameObject target;

    public GameObject map_1;
    public GameObject map_2;
    public GameObject map_3;
    public GameObject map_4;

    private void Update()
    {
        //target的位置高于map_1的位置时，将map_3和map_4的位置提升16.875个单位
        if (target.transform.position.y > map_1.transform.position.y)
        {
            Vector3 map3Position = map_3.transform.position;
            map3Position.y = map_1.transform.position.y + 16.875f;
            map_3.transform.position = map3Position;

            Vector3 map4Position = map_4.transform.position;
            map4Position.y = map_1.transform.position.y + 16.875f;
            map_4.transform.position = map4Position;

            //map_1与map_4，map_2与map_3交换游戏对象
            GameObject temp = map_1;
            map_1 = map_4;
            map_4 = temp;

            temp = map_2;
            map_2 = map_3;
            map_3 = temp;
        }
        //target的位置高于map_4的位置时，将map_1和map_2的位置降低16.875个单位
        if (target.transform.position.y < map_4.transform.position.y)
        {
            Vector3 map1Position = map_1.transform.position;
            map1Position.y = map_4.transform.position.y - 16.875f;
            map_1.transform.position = map1Position;

            Vector3 map2Position = map_2.transform.position;
            map2Position.y = map_4.transform.position.y - 16.875f;
            map_2.transform.position = map2Position;

            //map_1与map_4，map_2与map_3交换游戏对象
            GameObject temp = map_1;
            map_1 = map_4;
            map_4 = temp;

            temp = map_2;
            map_2 = map_3;
            map_3 = temp;
        }
        //target的位置左于map_2的位置时，将map_1和map_4的位置左移30个单位
        if (target.transform.position.x < map_2.transform.position.x)
        {
            Vector3 map1Position = map_1.transform.position;
            map1Position.x = map_2.transform.position.x - 30f;
            map_1.transform.position = map1Position;

            Vector3 map4Position = map_4.transform.position;
            map4Position.x = map_2.transform.position.x - 30f;
            map_4.transform.position = map4Position;

            //map_1与map_2，map_3与map_4交换游戏对象
            GameObject temp = map_1;
            map_1 = map_2;
            map_2 = temp;

            temp = map_3;
            map_3 = map_4;
            map_4 = temp;
        }
        //target的位置右于map_1的位置时，将map_2和map_3的位置右移30个单位
        if (target.transform.position.x > map_1.transform.position.x)
        {
            Vector3 map2Position = map_2.transform.position;
            map2Position.x = map_1.transform.position.x + 30f;
            map_2.transform.position = map2Position;

            Vector3 map3Position = map_3.transform.position;
            map3Position.x = map_1.transform.position.x + 30f;
            map_3.transform.position = map3Position;

            //map_1与map_2，map_3与map_4交换游戏对象
            GameObject temp = map_1;
            map_1 = map_2;
            map_2 = temp;

            temp = map_3;
            map_3 = map_4;
            map_4 = temp;
        }
    }
}
