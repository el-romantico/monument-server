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
                    default:
                        return string.Empty;
                }
            }
            else
            {
                switch (id)
                {
                    case 1:
                        return StaticData.StaticData.NevskiBG;
                    default:
                        return string.Empty;
                }
            }
        }
    }
}
