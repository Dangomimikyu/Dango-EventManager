using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DangoMimikyu.EventManagement;

public class ExampleBehaviour : MonoBehaviour
{
    private Rigidbody m_rb;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody>();

        EventManager.instance.StartListening(GameEvents.TestEvent_Teleport, Teleport);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
            EventManager.instance.DispatchEvent(GameEvents.TestEvent_Teleport);
		}
    }

    private void Teleport(EventArgumentData ea)
	{
        transform.localPosition = new Vector3(0.0f, 2.0f, 0.0f);
	}
}
