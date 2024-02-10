using UnityEngine;

public class FollowGyro : MonoBehaviour
{
    // shifts the rotation of the object to your phone
    public Quaternion baseRotation = new Quaternion(0, 0, 1, 0);
    public GyroManager gyroManager;
    //public Gyroscope gyro;

    void Start(){
        gyroManager.EnableGyro();
    }

    void Update(){
        transform.localRotation = gyroManager.rotation * baseRotation;
    }
}
