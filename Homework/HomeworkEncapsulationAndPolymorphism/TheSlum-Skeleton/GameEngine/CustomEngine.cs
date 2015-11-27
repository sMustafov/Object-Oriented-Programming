using System;
using TheSlum.Characters;
using TheSlum.Items;

namespace TheSlum.GameEngine
{
    public class CustomEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0].ToLower())
            {
                case "status":
                    this.PrintCharactersStatus(this.characterList);
                    break;
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
                default:
                    ExecuteCommand(inputParams);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            Character character;
            switch (inputParams[1].ToLower())
            {
                case "warrior":
                    character = new Warrior(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]),
                            (Team)Enum.Parse(typeof(Team), inputParams[5], true));
                    this.characterList.Add(character);
                    break;

                case "mage":
                    character = new Mage(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]),
                         (Team)Enum.Parse(typeof(Team), inputParams[5], true));
                    this.characterList.Add(character);
                    break;

                case "healer":
                    character = new Healer(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]),
                        (Team)Enum.Parse(typeof(Team), inputParams[5], true));
                    this.characterList.Add(character);
                    break;
            }
        }

        protected new void AddItem(string[] inputParams)
        {
            Character characterToAcceptIitem = GetCharacterById(inputParams[1]);
            Item itemToAdd;
            switch (inputParams[2].ToLower())
            {
                case "axe":
                    itemToAdd = new Axe(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "shield":
                    itemToAdd = new Shield(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "pill":
                    itemToAdd = new Pill(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "injection":
                    itemToAdd = new Injection(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                default:
                    break;
            }
        }
    }
}