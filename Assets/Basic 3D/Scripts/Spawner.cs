using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject ragdollCharacter;
    [SerializeField] KeyCode spawnKey;

    private void Update()
    {
        if (Input.GetKeyDown(spawnKey))
        {
            //When the key is pressed, instantiate the prefab at the spawner's current position and rotation.
            GameObject newRagdoll = Instantiate(ragdollCharacter, transform.position, transform.rotation);
        }
    }
}
