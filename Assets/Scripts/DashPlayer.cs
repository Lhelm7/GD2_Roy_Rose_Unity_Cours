using UnityEngine;

public class DashPlayer : MonoBehaviour
{
    [Header("Dash")] public float dashSpeed = 25f;
    public float dashDuration = 0.12f;
    public float dashCooldown = 0.4f;
    public int maxDashes = 1;
    public bool preserveYVelocity = false;
    public KeyCode dashKey = KeyCode.LeftShift;

    
    }


