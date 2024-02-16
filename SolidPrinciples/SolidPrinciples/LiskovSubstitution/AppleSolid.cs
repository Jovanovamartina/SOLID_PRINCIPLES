
namespace SolidPrinciples.LiskovSubstitution
{
    public interface IFruit
    {
        string GetColor();
    }
    public class AppleSolid : IFruit
    {
        public string GetColor()
        {
            return "Red";
        }
    }
    public class OrangeSolid : IFruit
    {
        public string GetColor()
        {
            return "Orange";
        }
    }
}

