using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{

    public CommandSlot slot = new CommandSlot();
    Skill skill = new ConcreteSkill();


    // Start is called before the first frame update
    void Start()
    {
        slot.cmd = skill;

        slot.cmd.execute();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
