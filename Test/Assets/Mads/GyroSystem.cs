using UnityEngine;

public class GyroSystem : MonoBehaviour
{
    public TextMesh text;
    private int fps;
    private Quaternion origin;
    private Gyroscope gyro;

    private void Awake()
    {
        gyro = Input.gyro;
        gyro.enabled = true;
        origin = gyro.attitude;

        transform.parent.rotation = Quaternion.Euler(90, 90, 0);
        origin = new Quaternion(0, 0, 1, 0);
    }

    private void Update()
    {
        fps += 1;

        transform.localRotation = gyro.attitude * origin;

        text.text = fps + "\n" + Input.gyro.attitude.eulerAngles + "\n" + transform.rotation.eulerAngles;
    }

    private Quaternion ConvertRightHandedToLeftHandedQuaternion(Quaternion rightHandedQuaternion)
    {
        return new Quaternion(-rightHandedQuaternion.x,
            -rightHandedQuaternion.z,
            -rightHandedQuaternion.y,
            rightHandedQuaternion.w);
    }
}