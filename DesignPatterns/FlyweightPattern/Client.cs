

namespace FlyweightPattern
{
    public class Client
    {
        public static void Main()
        {
            CharacterFlyweightFactory factory = new CharacterFlyweightFactory();

            FontSize size16Font = new FontSize(16);
            size16Font.AddToCharacterList(factory.GetFlyweight('A'));
            size16Font.AddToCharacterList(factory.GetFlyweight('B'));
            size16Font.PrintCharacter();
        
            FontSize size20Font = new FontSize(20);
            size20Font.AddToCharacterList(factory.GetFlyweight('B'));
            size20Font.AddToCharacterList(factory.GetFlyweight('C'));
            size20Font.PrintCharacter();
            
        }
    }
}
