namespace Monument.Service
{
    public static class DataService
    {
        public static string GetData(int id, string locale)
        {
            if(locale.ToLower() == "bg")
            {
                switch (id)
                {
                    case 1:
                        return StaticData.StaticData.NevskiBG;
                    case 2:
                        return StaticData.StaticData.VazovBG;
                    default:
                        return string.Empty;
                }
            }
            else
            {
                switch (id)
                {
                    case 1:
                        return StaticData.StaticData.NevskiEN;
                    case 2:
                        return StaticData.StaticData.VazovEN;
                    default:
                        return string.Empty;
                }
            }
        }
    }
}
