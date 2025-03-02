using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI hpText;
    
    [SerializeField] private PlayerCharacterController bobby;
    [SerializeField] private GameObject skillsHolder;
    [SerializeField] private GameObject SkillGroup;
    public Sprite[] skillIcons;
    
    public void RefreshHPText(int newHP)
    {
        hpText.text = newHP.ToString();
    }

    private void Awake()
    {
        bobby.onTakeDamageEventAction += RefreshHPText;
        AssignSpritesToSkillButton();
    }

    private void Start()
    {
        hpText.text = bobby.Hp.ToString();
    }
    
    private void AssignSpritesToSkillButton()
    {
        SkillButtonUI[] skillsButtonUI = skillsHolder.GetComponentsInChildren<SkillButtonUI>();
        
        for (int i = 0; i < skillsButtonUI.Length; i++)
        {
            skillsButtonUI[i].skillIcon.sprite =  skillIcons[i];
            skillsButtonUI[i].skillNameText.text = "Skill " + (i + 1);
        }
    }
}
