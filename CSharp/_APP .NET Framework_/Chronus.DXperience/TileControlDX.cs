using DevExpress.XtraEditors;

namespace Chronus.DXperience
{
    public class TileControlDX
    {
        private TileControlDX()
        {

        }

        public static string GetTileItemSizeTamanho(TileItemSize tamanho)
        {
            switch (tamanho)
            {
                case TileItemSize.Small:
                    return "P";
                case TileItemSize.Large:
                    return "G";
                case TileItemSize.Medium:
                    return "M";
                case TileItemSize.Wide:
                    return "W";
                default:
                    return "M";
            }
        }

        public static TileItemSize GetTamanhoTileItemSize(string tamanho)
        {
            switch (tamanho)
            {
                case "P":
                    return TileItemSize.Small;
                case "G":
                    return TileItemSize.Large;
                case "M":
                    return TileItemSize.Medium;
                case "W":
                    return TileItemSize.Wide;
                default:
                    return TileItemSize.Medium;
            }
        }
    }
}
