using System;
using System.Collections.Generic;

namespace Section07
{
    //Lambda : 일회용 함수를 만드는데 사용하는 문법
    //함수의 선언을 하나하나 하지 않고 빠르게 만들 수 있는 방법(무명 함수)

    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }
    
    class Lambda
    {
        //가상의 인벤토리 
        static List<Item> _items = new List<Item>();

        //delegate bool ItemSelector(Item item);
        delegate Return MyFunc<T, Return>(T item);

        static Item FindItem(Func<Item, bool> selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }
        /*
        static Item FindItem(ItemSelector selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }
        */

        //public Lambda()
        public static void Main(string[] args)
        {
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            //delegate를 사용한 무명함수(Anonymous Function)
            //Item item = FindItem(delegate (Item i) {return i.ItemType == ItemType.Weapon;});

            //Lambda : 입력값 => 반환값 
            //Item item = FindItem((Item i) => { return i.ItemType == ItemType.Weapon; });

            //ItemSelector selector = new ItemSelector((Item i) => { return i.ItemType == ItemType.Weapon; });
            //Item item = FindItem(selector);

            //Func<Item, bool> selector = (Item i) => { return i.ItemType == ItemType.Weapon; };
            //Item item = FindItem(selector);

            Item item = FindItem((Item i) => { return i.ItemType == ItemType.Weapon; });

            // delegate를 직접 선언하지 않아도 , 이미 만들어진 애들이 존재한다.
            // -> 반환 타입이 있을 경우 Func
            // -> 반환 타입이 없으면 Action
        }
    }
}
