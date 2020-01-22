using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Character
{
    private string name;
    private double baseHealth;
    private double health;
    private double baseArmor;
    private double armor;
    private double abilityPoints;
    private double restHealMultiplier;

    public Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
    {
        this.Name = name;
        this.BaseHealth = health;
        this.Health = health;
        this.BaseArmor = armor;
        this.Armor = armor;
        this.AbilityPoints = abilityPoints;
        this.Bag = bag;
        this.Faction = faction;
        this.restHealMultiplier = 0.2;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"Name cannot be null or whitespace!");
            }
            this.name = value;
        }
    }
    public double BaseHealth
    {
        get
        {
            return this.baseHealth;
        }
        private set
        {
            this.baseHealth = value;
        }
    }
    public double Health
    {
        get { return this.health; }
        set
        {
            if (value<0)
            {
                value = 0;
            }
            else if (value>this.BaseHealth)
            {
                value = this.BaseHealth;
            }
            this.health = value;
        }
    }
    public double BaseArmor
    {
        get
        {
            return this.baseArmor;
        }
        private set
        {
            this.baseArmor = value;
        }
    }
    public double Armor
    {
        get { return this.armor; }
        set
        {
            if (value>this.BaseArmor)
            {
                value = this.BaseArmor;
            }
            else if (value<0)
            {
                value = 0;
            }
            this.armor = value;
        }

    }
    public double AbilityPoints
    {
        get
        {
            return this.abilityPoints;
        }
        private set
        {
            this.abilityPoints = value;
        }
    }
    public Faction Faction { get;}
    public virtual double RestHealMultiplier
    {
        get
        {
            return this.restHealMultiplier;
        }
    }
    public bool IsAlive { get; set; } = true;

    public Bag Bag { get; }

    public void TakeDamage(double hitPoints)
    {
        EnsureAlive();

        if (hitPoints>this.Armor)
        {
            hitPoints -= this.Armor;
            this.Armor = 0;
            this.Health -= hitPoints;
        }
        else
        {
            this.Armor -= hitPoints;
        }
    }

    public void Rest()
    {
        EnsureAlive();
        this.Health += BaseHealth*RestHealMultiplier;
    }

    public void UseItem(Item item)
    {
        EnsureAlive();
        UseItemOn(item, this);
        
    }
    public void UseItemOn(Item item, Character character)
    {
        EnsureAlive();
        character.EnsureAlive();
        item.AffectCharacter(character);
    }

    public void GiveCharacterItem(Item item, Character character)
    {
        EnsureAlive();
        character.EnsureAlive();
        character.Bag.AddItem(item);
        this.Bag.RemoveItem(item);
    }
    public void ReceiveItem(Item item)
    {
        EnsureAlive();
        Bag.AddItem(item);
    }
    public void EnsureAlive()
    {
        if (this.IsAlive == false)
        {
            throw new InvalidOperationException("Must be alive to perform this action!");
        }
    }
}

