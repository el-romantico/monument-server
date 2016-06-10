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
                    case 3:
                        return StaticData.StaticData.NdkBG;
                    case 4:
                        return StaticData.StaticData.SuBG;
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
                    case 3:
                        return StaticData.StaticData.NdkEN;
                    case 4:
                        return StaticData.StaticData.SuEN;
                    default:
                        return string.Empty;
                }
            }
        }
    }
}
