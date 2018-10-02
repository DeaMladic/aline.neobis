using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;


    void Start()
    {
        agent.updateRotation = false;
    }
    void Update()
    {
        if (Input.GetKey("w"))

        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }

            if (agent.remainingDistance > agent.stoppingDistance)
            {
                character.Move(agent.desiredVelocity, false, false);
            }
            else
            {
                character.Move(Vector3.zero, false, false);
            }

        }
    }
