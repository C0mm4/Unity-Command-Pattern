using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteSkill : Skill
{
    public override void execute()
    {
        Debug.Log("Concrete Skill is Execute.");
    }
}
