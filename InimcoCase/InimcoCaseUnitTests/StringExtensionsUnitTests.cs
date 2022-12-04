using InimcoCase.Util;

namespace InimcoCaseUnitTests;

public class StringExtensionsUnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ReversingARegularStringPasses()
    {
        var name = "Tijl De Blander";
        var reversedName = name.Reverse();
        Assert.AreEqual(reversedName,"rednalB eD ljiT" );
    }
    
    [Test]
    public void ReversingAStringWithAccentsPasses()
    {
        var name = "Tijl De Blandér";
        var reversedName = name.Reverse();
        Assert.AreEqual(reversedName,"rédnalB eD ljiT" );
    }
    
    [Test]
    public void ReversingAStringWithPunctuationMarks()
    {
        var name = "Tijl De Blander !-";
        var reversedName = name.Reverse();
        Assert.AreEqual(reversedName,"-! rednalB eD ljiT" );
    }

    [Test]
    public void GetVowelCountWorksWithRegularString()
    {
        var name = "Bo terham";
        var vowelCount = name.GetVowelCount();
        Assert.AreEqual(vowelCount, 3);
    }
    
    [Test]
    public void GetVowelCountWorksDespitePunctuationMarks()
    {
        var name = "Bo-terham!";
        var vowelCount = name.GetVowelCount();
        Assert.AreEqual(vowelCount, 3);
    }
    [Test]
    public void GetVowelCountWorksWithAccents()
    {
        var name = "Bö térham";
        var vowelCount = name.GetVowelCount();
        Assert.AreEqual(vowelCount, 3);
    }
    
    [Test]
    public void GetVowelCountWorksWhenThereAreNoVowels()
    {
        var name = "H4ck3r";
        var vowelCount = name.GetVowelCount();
        Assert.AreEqual(vowelCount, 0);
    }
    
    [Test]
    public void GetVowelCountWorksWhenStringIsEmpty()
    {
        var name = string.Empty;
        var vowelCount = name.GetVowelCount();
        Assert.AreEqual(vowelCount, 0);
    }

    [Test]
    public void GetConsonantCountWorksWithRegularString()
    {
        var name = "Sinterklaas";
        var consonantCount = name.GetConsonantCount();
        Assert.AreEqual(consonantCount, 7);
    }
    
    
    [Test]
    public void GetConsonantCountIgnoresPunctuationMarks()
    {
        var name = "Sinter-klaas!";
        var consonantCount = name.GetConsonantCount();
        Assert.AreEqual(consonantCount, 7);
    }
    
    [Test]
    public void GetConsonantCountWorksWithEmptyString()
    {
        var name = string.Empty;
        var consonantCount = name.GetConsonantCount();
        Assert.AreEqual(consonantCount, 0);
    }
}