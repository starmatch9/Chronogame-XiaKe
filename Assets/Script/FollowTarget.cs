using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//卷轴滚动脚本（模仿Cinemation）

//   * LateUpdate *
//LateUpdate() 在所有 Update() 执行后调用,适用于依赖于其他对象更新的脚本
//

public class FollowTarget : MonoBehaviour
{
    [Header("目标游戏对象")]
    public Transform target;

    [Header("相关参数")]
    public float followSpeed = 5f;
    public float deadZoneTop = 2f; //死区顶部
    public float deadZoneBottom = 4f; //死区底部

    void LateUpdate()
    {
        if (target == null)
        {
            return;
        }

        //维护相机的当前位置
        Vector3 currentPos = transform.position;

        //直接将目标位置设置为角色位置
        Vector3 targetPos = target.position;

        targetPos.z = currentPos.z;

        //立即跟随
        transform.position = targetPos;
    }
}
