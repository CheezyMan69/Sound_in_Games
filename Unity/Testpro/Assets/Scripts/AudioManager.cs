using FMODUnity;
using FMOD.Studio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [Header("Avatar")] public EventReference avatarCollisionEvent;
    public EventReference avatarPickUpEvent;

    public void AvatarCollisionPlay() //plays one shot on collision 
    {
        RuntimeManager.PlayOneShot(avatarCollisionEvent);
    }

    public void AvatarPickUpPlay() //plays one shot on pick up object
    {
        RuntimeManager.PlayOneShot(avatarPickUpEvent);
    }
}
