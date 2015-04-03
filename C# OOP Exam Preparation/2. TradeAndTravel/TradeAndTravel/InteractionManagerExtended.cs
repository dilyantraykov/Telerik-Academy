namespace TradeAndTravel
{
    public class InteractionManagerExtended : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    item = base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
                    break;
            }
            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    location = base.CreateLocation(locationTypeString, locationName);
                    break;
            }
            return location;
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    person = base.CreatePerson(personTypeString, personNameString, personLocation);
                    break;
            }
            return person;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(commandWords, actor);
                    break;
                case "craft":
                    HandleCraftInteraction(commandWords, actor);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleCraftInteraction(string[] commandWords, Person actor)
        {
            var gatherItemName = commandWords[3];
            var hasWood = false;
            var hasIron = false;

            var itemType = commandWords[2];

            foreach (var item in actor.ListInventory())
            {
                if (item is Iron)
                {
                    hasIron = true;
                }
                else if (item is Wood)
                {
                    hasWood = true;
                }
            }

            if (itemType == "weapon" && hasIron && hasWood)
            {
                AddToPerson(actor, new Weapon(gatherItemName));
            }
            else if (itemType == "armor" && hasIron)
            {
                AddToPerson(actor, new Armor(gatherItemName));
            }
        }

        private void HandleGatherInteraction(string[] commandWords,Person actor)
        {
            var gatherItemName = commandWords[2];
            var hasWeapon = false;
            var hasArmor = false;

            foreach (var item in actor.ListInventory())
            {
                if (item is Weapon)
                {
                    hasWeapon = true;
                }
                else if (item is Armor)
                {
                    hasArmor = true;
                }
            }

            if (actor.Location.LocationType == LocationType.Forest && hasWeapon)
            {
                AddToPerson(actor, new Wood(gatherItemName));  
            }
            else if (actor.Location.LocationType == LocationType.Mine && hasArmor)
            {
                AddToPerson(actor, new Iron(gatherItemName));               
            }
        }
    }
}
