using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class fly : NetworkBehaviour
{

    float yaw = 0,yaw0=0;         // 偏航角，绕Y轴旋转的角度
    float pitch = 0,pitch0=0;       // 俯仰角，绕Z轴旋转的角度
    float roll = 0;  // 翻滚角，绕X轴旋转的角度
    // Use this for initialization
    void Start () {
		
	}
    private void Update()
    {

    }
    // Update is called once per frame
    void FixedUpdate() {
        if (!isLocalPlayer)    //如果不是本地客户端，就返回，不执行下面的操作
        {
            return;
        }
        transform.position += Vector3.ClampMagnitude(transform.forward, 0.5f);

        pitch -= Input.GetAxis("Mouse Y") * 5;  
        yaw += Input.GetAxis("Mouse X") * 5;
        yaw0 += Mathf.Clamp((yaw - yaw0) / 20, -2, 2);

        pitch0 += Mathf.Clamp((pitch - pitch0) / 20, -3, 3); ;
  
        roll = Mathf.Clamp(yaw0 - yaw, -30, 30) * 3;

        transform.rotation = Quaternion.Euler(pitch0, yaw0, roll);
     
    }
}
