using UnityEngine;
using System.Collections;

public class NavAgentScript : MonoBehaviour {

    [SerializeField]
    Transform m_target;

    NavMeshAgent m_agent;
	// Use this for initialization
	void Start () {
        m_agent = this.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        m_agent.SetDestination(m_target.position);
	}

    public Transform target
    {
        get { return m_target; }
        set { m_target = value; }
    }
}
