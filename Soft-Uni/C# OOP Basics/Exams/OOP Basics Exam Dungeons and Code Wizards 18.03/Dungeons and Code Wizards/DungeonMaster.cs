using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DungeonMaster
{
    private List<Character> allCharacters;
    private CharacterFactory characterFactory;
    private ItemFactory itemFactory;
    private List<Item> itemPool;
    private int lastSurvivorRounds;

    public DungeonMaster()
    {
        this.allCharacters = new List<Character>();
        this.characterFactory = new CharacterFactory();
        this.itemFactory = new ItemFactory();
        this.itemPool = new List<Item>();
    }

    public string JoinParty(string[] args)
    {
        var newCharacter = characterFactory.CreateCharacter(args);
        allCharacters.Add(newCharacter);
        return $"{args[2]} joined the party!";
    }

    public string AddItemToPool(string[] args)
    {
        var newItem = itemFactory.CreateItem(args);
        itemPool.Add(newItem);
        return $"{newItem.GetType().Name} added to pool.";
    }

    public string PickUpItem(string[] args)
    {
        Character selectedCharacter = CharacterExists(args[0]);

        if (itemPool.Count == 0)
        {
            throw new InvalidOperationException("No items left in pool!");
        }

        Item pickedUpItem = itemPool.Last();
        selectedCharacter.Bag.AddItem(pickedUpItem);
        itemPool.Remove(pickedUpItem);

        return $"{selectedCharacter.Name} picked up {pickedUpItem.GetType().Name}!";
    }

    public string UseItem(string[] args)
    {
        Character selectedCharacter = CharacterExists(args[0]);

        var itemToBeUsed = selectedCharacter.Bag.GetItem(args[1]);
        selectedCharacter.UseItem(itemToBeUsed);
        return $"{selectedCharacter.Name} used {itemToBeUsed.GetType().Name}.";
    }

    public string UseItemOn(string[] args)
    {
        var selectedCharacter = CharacterExists(args[0]);
        var receiver = CharacterExists(args[1]);
        Item selectedItem = selectedCharacter.Bag.GetItem(args[2]);
        selectedCharacter.UseItemOn(selectedItem, receiver);

        return $"{selectedCharacter.Name} used {selectedItem} on {receiver.Name}.";
    }

    public string GiveCharacterItem(string[] args)
    {
        var selectedCharacter = CharacterExists(args[0]);
        var receiver = CharacterExists(args[1]);
        Item selectedItem = selectedCharacter.Bag.GetItem(args[2]);
        selectedCharacter.GiveCharacterItem(selectedItem, receiver);
        selectedCharacter.Bag.RemoveItem(selectedItem);
        return $"{selectedCharacter.Name} gave {receiver.Name} {selectedItem}.";
    }

    public string GetStats()
    {
        var sortedCharacters = allCharacters.OrderBy (c => c.IsAlive).OrderByDescending(c => c.Health).ToList();
        var sb = new StringBuilder();

        foreach (var character in sortedCharacters)
        {
            sb.Append($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: ");
            if (character.IsAlive == true)
            {
                sb.Append("Alive");
            }
            else if (character.IsAlive == false)
            {
                sb.Append("Dead");
            }
            sb.AppendLine();
        }
        return sb.ToString().TrimEnd();
    }

    public string Attack(string[] args)
    {
        Character attacker = CharacterExists(args[0]);
        Character receiver = CharacterExists(args[1]);

        if (attacker.GetType().Name == "Cleric")
        {
            throw new ArgumentException($"{attacker.Name} cannot attack!");
        }

        Warrior warrior = (Warrior)attacker;

        warrior.Attack(receiver);
        var sb = new StringBuilder();
        sb.Append($"{attacker.Name} attacks {receiver.Name} for {attacker.AbilityPoints} hit points!");

        if (receiver.Health<0)
        {
            receiver.Health = 0;
        }
        sb.Append($" {receiver.Name} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

        if (receiver.Health==0)
        {
            receiver.IsAlive = false;
            sb.AppendLine();
            sb.Append($"{receiver.Name} is dead!");
        }

        return sb.ToString();
    }

    public string Heal(string[] args)
    {
        Cleric healer = (Cleric) CharacterExists(args[0]);
        var healingReceiver = CharacterExists(args[1]);

        if (healer.GetType().Name == "Warrior")
        {
            throw new ArgumentException($"{healer.Name} cannot heal!");
        }
        healer.Heal(healingReceiver);
        var sb = new StringBuilder();
        sb.Append($"{healer.Name} heals {healingReceiver.Name} for {healer.AbilityPoints}! {healingReceiver.Name} has {healingReceiver.Health} health now!");
        return sb.ToString();
    }

    public string EndTurn()
    {
        var survivors = allCharacters.Where(c => c.IsAlive).ToList();
        StringBuilder sb = new StringBuilder();

        foreach (var survivor in survivors)
        {
            var previousHealth = survivor.Health;
            survivor.Rest();
            sb.Append($"{survivor.Name} rests ({previousHealth} => {survivor.Health})");
            sb.AppendLine();
        }
        if (survivors.Count <= 1)
        {
            this.lastSurvivorRounds++;
        }
        return sb.ToString().TrimEnd('\n', '\r');
    }

    public bool IsGameOver()
    {
        var oneOrZeroSurvivors = allCharacters.Where(c => c.IsAlive).Count() <= 1;
        var roundsWithOneOrLessSurvivors = lastSurvivorRounds > 1;
        return oneOrZeroSurvivors && roundsWithOneOrLessSurvivors;
    }

    public Character CharacterExists(string name)
    {
        var selectedCharacter = allCharacters.Where(c => c.Name == name).FirstOrDefault();

        if (selectedCharacter == null)
        {
            throw new ArgumentException($"Character {name} not found!");
        }
        return selectedCharacter;
    }
}

