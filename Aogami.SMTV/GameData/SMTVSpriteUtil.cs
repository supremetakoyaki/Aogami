using System.Drawing;

namespace Aogami.SMTV.GameData
{
    public static class SMTVSpriteUtil
    {
        public static Bitmap? GetSprite(string SpriteName)
        {
            return Resources.ResourceManager.GetObject(SpriteName) as Bitmap;
        }
    }
}
