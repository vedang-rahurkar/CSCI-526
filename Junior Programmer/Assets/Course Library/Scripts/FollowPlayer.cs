using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float lag = 50.0f;

    public Vector3[] offset;
    public bool left = false;
    bool toggle = false;

    // Start is called before the first frame update
    void Start()
    {
        offset[0] = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(Input.GetKeyDown(left?KeyCode.LeftControl: KeyCode.RightControl))
            toggle = !toggle;
        transform.position = player.transform.position + offset[toggle?1:0];
    }
}
