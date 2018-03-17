using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AllController : NetworkBehaviour
{
    float yaw = 0, yaw0 = 0;         // 偏航角，绕Y轴旋转的角度
    float pitch = 0, pitch0 = 0;       // 俯仰角，绕Z轴旋转的角度
    float roll = 0;  // 翻滚角，绕X轴旋转的角度
    public Object zidan;
    int counts = 0;
    
    // Use this for initialization
                          // Use this for initialization
    void Start()
    {
        UnityEngine.Cursor.visible = false;
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //GameObject.FindWithTag("MainCamera").transform.parent = this.transform;
    }


    void FixedUpdate()
    {
        if (!isLocalPlayer)    //如果不是本地客户端，就返回，不执行下面的操作
        {
            return;
        }
        
        transform.position += Vector3.ClampMagnitude(transform.forward, 2f);
        GameObject.FindWithTag("MainCamera").transform.position = transform.position + transform.forward * -14 + transform.up * 5;
        pitch -= Input.GetAxis("Mouse Y") * 5;
        yaw += Input.GetAxis("Mouse X") * 5;
        
        yaw0 += Mathf.Clamp((yaw - yaw0) / 20, -2, 2);
        pitch0 += Mathf.Clamp((pitch - pitch0) / 20, -3, 3); ;
        roll = Mathf.Clamp(yaw0 - yaw, -30, 30) * 3;


        GameObject.FindWithTag("MainCamera").transform.rotation = Quaternion.Euler(pitch, yaw, 0);
        transform.rotation = Quaternion.Euler(pitch0, yaw0, roll);

        if (Input.GetMouseButton(0) && counts++ > 5)
        {
            Instantiate(zidan, this.transform.position, this.transform.rotation);
        }
        if (counts++ > 5)
        {
            counts = 0;
        }


    }
}
