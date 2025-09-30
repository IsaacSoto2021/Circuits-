using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Skill
{
    public string skillName;
    public bool unlocked;
    public List<Skill> prerequisites;
    public Button skillButton; // UI button

    public Skill(string name)
    {
        skillName = name;
        unlocked = false;
        prerequisites = new List<Skill>();
    }

    public bool CanUnlock()
    {
        foreach (Skill prereq in prerequisites)
        {
            if (!prereq.unlocked)
                return false;
        }
        return true;
    }

    public void Unlock()
    {
        if (CanUnlock() && !unlocked)
        {
            unlocked = true;
            skillButton.interactable = false; // disable button after unlocking
            
        }
        else
        {
            
        }
    }
}
