using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class cam : NetworkBehaviour
{

    float yaw = 0;         // 偏航角，绕Y轴旋转的角度
    float pitch = 0;       // 俯仰角，绕Z轴旋转的角度
    const float roll = 0;  // 翻滚角，绕X轴旋转的角度
                           // Use this for initialization
    void Start () {
       
        
    }
    private void OnNetworkInstantiate(NetworkMessageInfo info)
    {
        
    }

    // Update is called once per frame
    void Update () {
		
	}

    void FixedUpdate()
    {
        if (!isLocalPlayer)    //如果不是本地客户端，就返回，不执行下面的操作
        {
            return;
        }


        // Rotate
        pitch -= Input.GetAxis("Mouse Y") * 5;
            //pitch = Mathf.Clamp(pitch, -30, 30);
            yaw += Input.GetAxis("Mouse X") * 5;
            //yaw = Mathf.Clamp(yaw, -30, 30);
            transform.rotation = Quaternion.Euler(pitch, yaw, roll);
        
    }
}
