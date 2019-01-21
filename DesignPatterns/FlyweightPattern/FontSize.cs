using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    class FontSize : ICharacter
    {
        private int fontSize;
        private List<Character> characters;

        public FontSize(int fontSize)
        {
            this.fontSize = fontSize;
            characters = new List<Character>();
        }

        public void AddToCharacterList(Character character)
        {
            characters.Add(character);
        }

        public void RemoveFromCharacterList(Character character)
        {
            characters.Remove(character);
        }

        public void PrintCharacter()
        {
            foreach(Character character in characters)
            {
                Console.WriteLine("Character is " + character.character + " and font size is " + fontSize);
            }

        }
    }
}
