using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroManager : MonoBehaviour
{
    /// <summary>
    /// gyromanager handles gyroscope detection and returns the gyroscopic rotation
    /// </summary>
    #region Instance
    private static GyroManager instance;

    public static GyroManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GyroManager>();
                if(instance == null)
                {
                    instance = new GameObject("Spawned GyroManager", typeof(GyroManager)).GetComponent<GyroManager>();
                }
            }

            return instance; 
        }
        set
        {
            instance = value;
        }
    }
    #endregion

    [Header("Logic")]
    private Gyroscope gyro;
    private Quaternion rotation;
    private bool gyroActive;

    public void EnableGyro()
    {
        //already active
        if (gyroActive)
        {
            return;
        }

        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            gyroActive = gyro.enabled;
            Debug.Log("Gyroscope found.");
        }
        else
        {
            Debug.Log("Gyroscope not found.");
        }
    }

    private void Update()
    {
        if (gyroActive)
        {
            rotation = gyro.attitude;
        }
    }

    public Quaternion GetGyroRotation()
    {
        return rotation;
    }
}
