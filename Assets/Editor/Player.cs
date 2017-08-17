namespace Editor
{
    public class Player
    {
        public IInventory Inventory;
        public IWeapon Weapon;

        public float Damage(float multiplier)
        {
            return Weapon.Damage() * multiplier;
        }

        public void AddToInventory(IItem item)
        {
            Inventory.Add(item);
        }
    }
}
