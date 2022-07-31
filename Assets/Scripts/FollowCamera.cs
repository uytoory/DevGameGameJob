using UnityEngine;

public sealed class FollowCamera : MonoBehaviour
{
    public Transform objToFollow;
    public Vector3 offset;

    public void FollowTo(Transform obj)
    {
        objToFollow = obj;
    }

    private void LateUpdate()
    {
        if (objToFollow == null) return;
        transform.position = objToFollow.position + offset;
        transform.LookAt(objToFollow);
    }
}
