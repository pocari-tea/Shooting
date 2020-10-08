using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;        // 따라다닐 타겟 오브젝트의 Transform
 
    private Transform tr;                // 카메라 자신의 Transform
    
    // 카메라 범위 (맵 밖은 나오지 않도록 한다)
    [SerializeField]
    private BoxCollider bound;

    private Vector3 minBound;
    private Vector3 maxBound;

    private float halfWidth;
    private float halfHeight;

    private Camera theCamera;
 
    void Start()
    {
        tr = GetComponent<Transform>();
        
        // 카메라 범위
        theCamera = GetComponent<Camera>();
        minBound = bound.bounds.min;
        maxBound = bound.bounds.max;
        halfHeight = theCamera.orthographicSize;
        halfWidth = halfHeight * Screen.width / Screen.height;
    }
 
    void LateUpdate()
    {
        tr.position = new Vector3(target.position.x, target.position.y, tr.position.z);
 
        tr.LookAt(target);
        
        // 맵 범위설정 (카메라 제어)
        float clampedX = Mathf.Clamp(this.transform.position.x, minBound.x + halfWidth, maxBound.x - halfWidth);
        float clampedY = Mathf.Clamp(this.transform.position.y, minBound.y + halfHeight, maxBound.y - halfHeight);
        
        this.transform.position = new Vector3(clampedX, clampedY, this.transform.position.z);
    }
}
