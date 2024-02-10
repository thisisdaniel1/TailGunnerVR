using UnityEngine;

public class GyroManager : MonoBehaviour
{
    public Gyroscope gyro;
    public Quaternion rotation;
    public bool gyroActive;

    public void EnableGyro(){
        // if gyro is not already assigned, assign it
        if (gyroActive){
            return;
        }

        if (SystemInfo.supportsGyroscope){
            gyro = Input.gyro;
            gyro.enabled = true;
            gyroActive = gyro.enabled;
        }
        else{
            Debug.Log("Gyro is not supported on this device");
        }
    }

    void Update(){
        if (gyroActive){
            rotation = gyro.attitude;
        }
    }
}
