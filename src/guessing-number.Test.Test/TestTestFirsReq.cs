using Xunit;
using System;
using FluentAssertions;

namespace guessing_number.Test.Test;

[Collection("Sequential")]
public class TestPrintInitialMessageSuccess
{
    [Trait("Category", "1 - Criou testes de sucesso para o TestPrintInitialMessage.")]
    [Theory(DisplayName = "TestPrintInitialMessage deve ser executado com sucesso quando printar a saudação")]
    [InlineData(new object[] {new string[]{"---Bem-vindo ao Guessing Game---", "Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!"}})]
    public void TestSucessTestPrintInitialMessage(string[] entry)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestPrintInitialMessage(entry);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestPrintInitialMessageFail
{
    [Trait("Category", "2 - Criou testes de falha para o TestPrintInitialMessage.")]
    [Theory(DisplayName = "TestPrintInitialMessage deve falhar com sucesso quando não printar a saudação")]
    [InlineData(new object[] {new string[]{"Bem vindo ao Guessing Game", "Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!"}})]
    [InlineData(new object[] {new string[]{"---Bem vindo ao Guessing Game---", "Para começar, tente adivinhar o número que eu pensei, entre -100 e 100"}})]
    [InlineData(new object[] {new string[]{"Bem vindo ao Guessing Game", "Para começar, tente adivinhar o número que eu pensei, entre -100 e 100"}})]
    [InlineData(new object[] {new string[]{"Bem vindo ao Guessing Game", "Para começar, tente adivinhar o número que eu pensei"}})]
    public void TestFailTestPrintInitialMessage(string[] entry)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestPrintInitialMessage(entry);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestReceiveUserInputAndConvertSuccess
{
    [Trait("Category", "3 - Criou testes de sucesso para o TestReceiveUserInputAndConvert.")]
    [Theory(DisplayName = "TestReceiveUserInputAndConvert deve ser executado com sucesso quando receber a entrada correta")]
    [InlineData("10", 10)]
    [InlineData("20", 20)]    
    [InlineData("-99", -99)]
    [InlineData("-45", -45)]
    [InlineData("0", 0)]
    public void TestSucessTestReceiveUserInputAndConvert(string entry, int expected)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestReceiveUserInputAndConvert(entry, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestReceiveUserInputAndConvertFail
{
    [Trait("Category", "4 - Criou testes de falha para o TestReceiveUserInputAndConvert.")]
    [Theory(DisplayName = "TestReceiveUserInputAndConvert deve falhar quando receber a entrada errada")]
    [InlineData("9", 10)]
    [InlineData("-20", 20)]    
    [InlineData("99", -99)]
    [InlineData("45", -45)]
    [InlineData("0", 1)]
    public void TestFailTestReceiveUserInputAndConvert(string entry, int expected)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestReceiveUserInputAndConvert(entry, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestReceiveUserInputAndVerifyTypeSuccess
{
    [Trait("Category", "5 - Criou testes de sucesso para o TestReceiveUserInputAndVerifyType.")]
    [Theory(DisplayName = "TestReceiveUserInputAndVerifyType deve executar com sucesso quando receber a entrada correta")]
    [InlineData(new object[] {new string[]{"test", "10"}, 10})]
    [InlineData(new object[] {new string[]{"", "test again", "43"}, 43})]
    [InlineData(new object[] {new string[]{"test", "", "test again again", "90"}, 90})]
    [InlineData(new object[] {new string[]{"10,", "10"}, 10})]
    [InlineData(new object[] {new string[]{"10-10", "10"}, 10})]    
    public void TestSucessTestReceiveUserInputAndVerifyType(string[] entrys, int expected)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestReceiveUserInputAndVerifyType(entrys, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestReceiveUserInputAndVerifyTypeFail
{
    [Trait("Category", "6 - Criou testes de falha para o TestReceiveUserInputAndVerifyType.")]
    [Theory(DisplayName = "TestReceiveUserInputAndVerifyType deve falhar quando receber a entrada errada")]
    [InlineData(new object[] {new string[]{"10", "11"}, 0})]
    [InlineData(new object[] {new string[]{"", "test again", "43"}, -43})]
    [InlineData(new object[] {new string[]{"test", "10", "test again again", "90"}, 0})]
    [InlineData(new object[] {new string[]{"10,", "10"}, -10})]
    [InlineData(new object[] {new string[]{"10-10", "10"}, -10})]    
    public void TestFailTestReceiveUserInputAndVerifyType(string[] entrys, int expected)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestReceiveUserInputAndVerifyType(entrys, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestReceiveUserInputAndVerifyRangeSuccess
{
    [Trait("Category", "7 - Criou testes de sucesso para o TestReceiveUserInputAndVerifyRange.")]
    [Theory(DisplayName = "TestReceiveUserInputAndVerifyRange deve executar com sucesso quando receber a entrada correta")]
    [InlineData(new object[] {new string[]{"1000", "10"}, 10})]
    [InlineData(new object[] {new string[]{"-1000", "20"}, 20})]
    [InlineData(new object[] {new string[]{"-999", "-555", "15"}, 15})]
    [InlineData(new object[] {new string[]{"999", "1"}, 1})]
    [InlineData(new object[] {new string[]{"100000", "77"}, 77})]
    public void TestSucessTestReceiveUserInputAndVerifyRange(string[] entrys, int expected)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestReceiveUserInputAndVerifyRange(entrys, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestReceiveUserInputAndVerifyRangeFail
{
    [Trait("Category", "8 - Criou testes de falha para o TestReceiveUserInputAndVerifyRange.")]
    [Theory(DisplayName = "TestReceiveUserInputAndVerifyRange deve falhar quando receber a entrada errada")]
    [InlineData(new object[] {new string[]{"1000", "10"}, 1000})]
    [InlineData(new object[] {new string[]{"-1000", "20"}, -20})]
    [InlineData(new object[] {new string[]{"-999", "-555", "15"}, -99})]
    [InlineData(new object[] {new string[]{"999", "1"}, 999})]
    [InlineData(new object[] {new string[]{"100000", "77"}, -77})]
    public void TestFailTestReceiveUserInputAndVerifyRange(string[] entrys, int expected)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestReceiveUserInputAndVerifyRange(entrys, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}