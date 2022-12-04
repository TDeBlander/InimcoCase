namespace InimcoCase.Util;

public static class StringExtensions
{
    public static int GetVowelCount(this string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return 0;
        
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'á', 'à', 'â', 'ä', 'ã',  'å', 'æ',  'ç',  'é',  'è',  'ê', 'ë',  'í',  'ì',  'î',  'ï',  'ñ', 'ó', 'ò', 'ô', 'ö', 'õ', 'ø', 'œ', 'ß', 'ú', 'ù', 'û', 'ü' };
        
        return input.ToLower().Count(c => vowels.Contains(c));
    }
    
    public static int GetConsonantCount(this string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return 0;
        
        char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'y','z'};

        return input.ToLower().Count(c => consonants.Contains(c));
    }

    public static string Reverse(this string input)
    {
        var charArray = input.ToCharArray();
        
        Array.Reverse(charArray);
        
        return new string(charArray);
        
    } }  
