public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => [];

    public static Dictionary<int, string> GetExistingDictionary() => new()
    {
        { 91, "India" },
        { 55, "Brazil" },
        { 1 , "United States of America" },
    };

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName) => new()
    {
        { countryCode, countryName }
    };

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);

        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
    {
        if(!existingDictionary.TryGetValue(countryCode, out var country))
        {
            return string.Empty;
        }

        return country;
    }
        

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode) => 
        existingDictionary.ContainsKey(countryCode);

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if(!existingDictionary.ContainsKey(countryCode)) return existingDictionary;

        existingDictionary[countryCode] = countryName;

        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);

        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary) {
        if(existingDictionary.Count <= 0) return string.Empty;

        return existingDictionary.Values
            .OrderBy(countryName => countryName.Length)
            .ToArray()[^1];
    } 
}