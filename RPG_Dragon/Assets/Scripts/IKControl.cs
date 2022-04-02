using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKControl : MonoBehaviour
{

    Animator anim;
    Transform leftIKtraget;
    Transform rightIKtraget;
    Transform hintLeft;
    Transform hintRight;

    [Header("dynamic Ik values")]
    Vector3 leftFootPos;
    Vector3 rightFootPos;
    Quaternion leftFootRot;
    Quaternion rightFootRot;
    float leftFootWeight;
    float rightFootWeight;
    public Transform leftFoot;
    public Transform rightFoot;

    [Header("IK properites values")]
    public float offsetY;
    public float lookIkWeight = 1.0f;
    public float bodyWeight = 0.7f;
    public float headWeight = 0.9f;
    public float eyeSight = 1f;
    public float clampWeight = 1f;
    public Transform lookPos;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        leftFoot = anim.GetBoneTransform(HumanBodyBones.LeftFoot);
        rightFoot = anim.GetBoneTransform(HumanBodyBones.RightFoot);
        leftFootRot = leftFoot.rotation;
        rightFootRot = rightFoot.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * 10f, Color.red);
        RaycastHit leftHit, rightHit;
        Vector3 lPos = leftFoot.TransformPoint(Vector3.zero);
        Vector3 rPos = rightFoot.TransformPoint(Vector3.zero);
        if (Physics.Raycast(lPos, Vector3.down, out leftHit, 1))
        {
            leftFootPos = leftHit.point;
            leftFootRot = Quaternion.FromToRotation(transform.up, leftHit.normal) * transform.rotation;
        }
        if (Physics.Raycast(rPos, Vector3.down, out rightHit, 1))
        {
            rightFootPos = rightHit.point;
            rightFootRot = Quaternion.FromToRotation(transform.up, rightHit.normal) * transform.rotation;
        }
    }
    private void OnAnimatorIK()
    {
        leftFootWeight = anim.GetFloat("MyleftFoot");
        rightFootWeight = anim.GetFloat("MyrightFoot");
        anim.SetIKPositionWeight(AvatarIKGoal.RightFoot, rightFootWeight);
        anim.SetIKPositionWeight(AvatarIKGoal.LeftFoot, leftFootWeight);
        anim.SetIKPosition(AvatarIKGoal.LeftFoot, leftFootPos + new Vector3(0, offsetY, 0));
        anim.SetIKPosition(AvatarIKGoal.RightFoot, rightFootPos + new Vector3(0, offsetY, 0));
        anim.SetIKRotationWeight(AvatarIKGoal.LeftFoot, leftFootWeight);
        anim.SetIKRotationWeight(AvatarIKGoal.RightFoot, rightFootWeight);
        anim.SetIKRotation(AvatarIKGoal.LeftFoot, leftFootRot);
        anim.SetIKRotation(AvatarIKGoal.RightFoot, rightFootRot);
    }
}
